#region Using
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Text.RegularExpressions;
#endregion

namespace cncCutterController
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Dichiarazione delle variabili globali
        SerialPort Obj_SerialPort = new SerialPort();
        OpenFileDialog Obj_FileDialog = new OpenFileDialog();
        List<string> Lst_Comandi = new List<string>();
        delegate void AddChronologyMsg_CallBack(string str);
        delegate void EnableDisableOfControl_CallBack(Control c, bool b);
        static int Command_Iterator;
        Thread Execute;
        Boolean Stop_Execution = new Boolean();
        string Rx_Buffer = string.Empty;
        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GBRL_Load(object sender, EventArgs e)
        {
            AddChronologyMsg("cncCutterController aperto");

            #region Acquisizione e ordinamento delle porte seriali disponibili e compilazione della combobox
            List<string> tmp_Lista = new List<string>();
            string tmp_PortName = string.Empty;
            tmp_PortName = string.Empty;

            foreach (string str in SerialPort.GetPortNames())
                tmp_Lista.Add(str);

            tmp_Lista.Sort();
            foreach (string str in tmp_Lista)
            {
                CmbBx_PortName.Items.Add(str);
            }
            #endregion

            #region Abilitazione e dsabilitazione dei pulsanti
            #region Bottoni
            Btn_SerialPortOpen.Enabled = true;
            Btn_SerialPortClose.Enabled = false;
            Btn_ReloadFile.Enabled = false;
            Btn_StopTrasmission.Enabled = false;
            Btn_StartTrasmission.Enabled = false;
            #endregion
            #region GroupBox
            GrpBx_ManualExecution.Enabled = false;
            #endregion
            #endregion

            Stop_Execution = false;
            Obj_SerialPort.DataReceived += Obj_SerialPort_DataReceived;
        }


        /// <summary>
        /// Aggiunge un messaggio in cima alla cronologia
        /// </summary>
        /// <param name="msg">Messaggio da aggiungere alla cronologia</param>
        private void AddChronologyMsg(string msg)
        {
            #region Procedura che aggiorna la cronologia
            string CurrentTime = DateTime.Now.ToShortTimeString();

            if (RcTxtBx_Chronology.InvokeRequired)
            {
                AddChronologyMsg_CallBack Write = new AddChronologyMsg_CallBack(AddChronologyMsg);
                Invoke(Write, new object[] { msg });
            }
            else
            {
                string Content = RcTxtBx_Chronology.Text;
                RcTxtBx_Chronology.Text = CurrentTime + ": " + msg + Environment.NewLine + Content;
            }
            #endregion
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_LoadFile_Click(object sender, EventArgs e)
        {
            #region Impostazione dei parametri per aprire una finestra di dialogo
            Obj_FileDialog.DefaultExt = "txt";
            Obj_FileDialog.Filter = "G-code Files(*.CNC;*.NC;*.TAP;*.TXT)|*.CNC;*.NC;*.TAP;*.TXT|All files (*.*)|*.*";
            Obj_FileDialog.Title = "Cerca file dei comandi GCODE";
            #endregion

            if (Obj_FileDialog.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(Obj_FileDialog.FileName))
                {
                    StreamReader Selected_File = new StreamReader(Obj_FileDialog.FileName);
                    AddChronologyMsg("Hai aperto il file " + Obj_FileDialog.FileName);
                    TxtBx_LoadedFile.Text = Obj_FileDialog.FileName.ToString();
                    DtGrd_Commands.Rows.Clear();
                    string line = string.Empty;

                    #region Generazione della lista contenente i comandi caricati dal file
                    while ((line = Selected_File.ReadLine()) != null)
                    {
                        if (line.Trim() != "")
                        {
                            Lst_Comandi.Add(line.ToString());
                        }
                    }
                    #endregion

                    #region Compilazione del DataGrid
                    for (int i = 0; i < Lst_Comandi.Count; i++)
                    {
                        DtGrd_Commands.Rows.Add();
                        DtGrd_Commands.Rows[i].SetValues(Lst_Comandi[i], false, false);
                    }
                    #endregion

                    #region Abilita e/o Disabilita Controli
                    #region Dichiarazione delle liste
                    List<Control> ListToEnable = new List<Control>();
                    List<Control> ListToDisable = new List<Control>();
                    #endregion
                    #region Lista di controlli da abilitare
                    ListToEnable.Add(Btn_SerialPortClose);
                    ListToEnable.Add(GrpBx_ManualExecution);
                    #endregion
                    #region Lista di controlli da disabilitare
                    ListToDisable.Add(Btn_SerialPortOpen);
                    ListToDisable.Add(Btn_StartTrasmission);
                    #endregion
                    EnableDisable_Lists(ListToEnable, ListToDisable);
                    #endregion

                    Btn_ReloadFile.Enabled = true;
                    if (Btn_SerialPortClose.Enabled) Btn_StartTrasmission.Enabled = true;
                }
            }
        }

        /// <summary>
        /// Cancella il contenuto o della cronologia 
        /// o del DataGrid contentente i comandi
        /// in base a quale dei due e visualizzato 
        /// </summary>
        /// <param name="sender">Btn_Clear</param>
        /// <param name="e">OnClick</param>
        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            switch (TbCtrl_Outputs.SelectedTab.ToString())
            {
                #region Chronology visualizzato
                case "TabPage: {Chronology}":
                    RcTxtBx_Chronology.Text = string.Empty;
                    AddChronologyMsg("Cronologia azioni cancellata");
                    break;
                #endregion
                #region Commands visualizzato
                case "TabPage: {Commands}":
                    DtGrd_Commands.Rows.Clear();
                    break;
                #endregion
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_ReloadFile_Click(object sender, EventArgs e)
        {
            DtGrd_Commands.Rows.Clear();
            StreamReader Selected_File = new StreamReader(TxtBx_LoadedFile.Text);
            AddChronologyMsg("Hai ricaricato il file " + TxtBx_LoadedFile.Text);

            string line = string.Empty;

            #region Generazione della lista contenente i comandi caricati dal file
            while ((line = Selected_File.ReadLine()) != null)
            {
                if (line.Trim() != "")
                {
                    Lst_Comandi.Add(line.ToString());
                }
            }
            #endregion

            #region Compilazione del DataGrid
            for (int i = 0; i < Lst_Comandi.Count; i++)
            {
                DtGrd_Commands.Rows.Add();
                DtGrd_Commands.Rows[i].SetValues(Lst_Comandi[i], false, false);
            }
            #endregion

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_SerialPortOpen_Click(object sender, EventArgs e)
        {
            try
            {
                #region Imposto i parametri per la connessione alla porta seriale
                Obj_SerialPort.PortName = CmbBx_PortName.SelectedItem.ToString();
                Obj_SerialPort.BaudRate = 9600;
                Obj_SerialPort.DataBits = 8;
                Obj_SerialPort.StopBits = StopBits.One;
                Obj_SerialPort.Parity = Parity.None;
                #endregion
                try
                {
                    Obj_SerialPort.Open();
                    AddChronologyMsg("Connesso a " + Obj_SerialPort.PortName);

                    #region Abilita e disabilita i controli
                    List<Control> ListToEnable = new List<Control>();
                    List<Control> ListToDisable = new List<Control>();
                    ListToEnable.Add(Btn_SerialPortClose);
                    ListToEnable.Add(GrpBx_ManualExecution);
                    ListToDisable.Add(Btn_SerialPortOpen);
                    ListToDisable.Add(Btn_StartTrasmission);
                    EnableDisable_Lists(ListToEnable, ListToDisable);
                    #endregion

                }

                catch (Exception ex)
                {
                    AddChronologyMsg(ex.Message.ToString());
                }
            }

            catch (Exception)
            {
                AddChronologyMsg("Selezionare la porta COM");
            }

        }

        private void Btn_SerialPortClose_Click(object sender, EventArgs e)
        {
            try
            {
                Obj_SerialPort.Close();
                AddChronologyMsg("Disconnesso da " + Obj_SerialPort.PortName);

                #region Abilita e disabilita i controli
                List<Control> ListToEnable = new List<Control>();
                List<Control> ListToDisable = new List<Control>();
                ListToEnable.Add(Btn_SerialPortOpen);
                ListToEnable.Add(Btn_StartTrasmission);
                ListToDisable.Add(Btn_SerialPortClose);
                ListToDisable.Add(GrpBx_ManualExecution);
                EnableDisable_Lists(ListToEnable, ListToDisable);
                #endregion
            }
            catch (Exception ex)
            {
                AddChronologyMsg(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Avvio della'esecuzione dei comandi 
        /// </summary>
        /// <param name="sender">Btn_StartTrasmission</param>
        /// <param name="e">OnClick</param>
        private void Btn_StartTrasmission_Click(object sender, EventArgs e)
        {
            Command_Iterator = 0;

            Execute = new Thread(new ThreadStart(ExecuteCommand));
            Execute.Start();

            #region Abilita e disabilita i controli
            List<Control> tmp = new List<Control>();
            tmp.Add(Btn_StartTrasmission);
            tmp.Add(Btn_StopTrasmission);
            tmp.Add(Btn_ReloadFile);
            tmp.Add(Btn_Clear);
            tmp.Add(GrpBx_ManualExecution);
            if (Btn_StartTrasmission.Enabled) tmp.Add(Btn_StartTrasmission);
            EnableDisable_Lists(tmp, tmp);
            #endregion

            TbCtrl_Outputs.SelectTab(TbPg_Commands);
        }

        /// <summary>
        /// 
        /// </summary>
        private void ExecuteCommand()
        {
            Regex.Replace(Lst_Comandi[Command_Iterator], @"\.", @",");

            Obj_SerialPort.Write(Lst_Comandi[Command_Iterator] + " #");
            DtGrd_Commands.Rows[Command_Iterator].SetValues(Lst_Comandi[Command_Iterator], true, false);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_StopTrasmission_Click(object sender, EventArgs e)
        {
            Stop_Execution = true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Manual_Click(object sender, EventArgs e)
        {
            string Caller_Obj = ((Control)sender).Text;
            char Axis = Caller_Obj[0];
            char Direction = Caller_Obj[1];

            #region Acquisizione del valore distanza
            decimal Distance = decimal.Zero;
            if (RdBtn_Distance1mm.Checked)
            {
                Distance = Convert.ToDecimal(RdBtn_Distance1mm.Text);
            }
            else if (RdBtn_Distance10mm.Checked)
            {
                Distance = Convert.ToDecimal(RdBtn_Distance10mm.Text);
            }
            else if (RdBtn_DistanceXmm.Checked)
            {
                Distance = NumUpDw_ManualDistance.Value;
            }
            #endregion

            #region Generazione del Comando
            string CommandToDo = string.Empty;
            switch (Axis)
            {
                case 'X':
                    if (Direction == '+') CommandToDo = "G00 X" + Distance + " #";
                    if (Direction == '-') CommandToDo = "G00 X-" + Distance + " #";
                    break;
                case 'Y':
                    if (Direction == '+') CommandToDo = "G00 Y" + Distance + " #";
                    if (Direction == '-') CommandToDo = "G00 Y-" + Distance + " #";
                    break;
                case 'Z':
                    if (Direction == '+') CommandToDo = "G00 Z" + Distance + " #";
                    if (Direction == '-') CommandToDo = "G00 Z-" + Distance + " #";
                    break;
            }
            #endregion
            Obj_SerialPort.Write(CommandToDo);


            Btn_StartTrasmission.Enabled = false;
            Btn_StopTrasmission.Enabled = false;
            GrpBx_ManualExecution.Enabled = false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Obj_SerialPort_DataReceived(object sender, EventArgs e)
        {
            Rx_Buffer += Obj_SerialPort.ReadExisting();
            if (Rx_Buffer == "01" | Rx_Buffer == "1" | Rx_Buffer == "01\r" | Rx_Buffer == "1r\r")
            {
                Obj_SerialPort.DiscardInBuffer();
                Rx_Buffer = string.Empty;

                if (!Btn_StartTrasmission.Enabled & !Btn_StopTrasmission.Enabled & !GrpBx_ManualExecution.Enabled)
                {
                    AddChronologyMsg("Esecuzione manuale terminata");
                    #region Abilita e disabilita i controli
                    List<Control> tmp = new List<Control>();
                    tmp.Add(Btn_StartTrasmission);
                    tmp.Add(Btn_StopTrasmission);
                    tmp.Add(Btn_ReloadFile);
                    tmp.Add(GrpBx_ManualExecution);
                    EnableDisable_Lists(tmp, tmp);
                    #endregion
                }

                else if (!Btn_StartTrasmission.Enabled & Btn_StopTrasmission.Enabled & !GrpBx_ManualExecution.Enabled)
                {
                    DtGrd_Commands.Rows[Command_Iterator].SetValues(Lst_Comandi[Command_Iterator], true, true);
                    Command_Iterator++;
                    Execute.Abort();

                    if (Command_Iterator == Lst_Comandi.Count)
                    {
                        Command_Iterator = 0;
                        AddChronologyMsg("Esecuzione automatica completata");

                        #region Abilita e disabilita i controli
                        List<Control> tmp = new List<Control>();
                        tmp.Add(Btn_StartTrasmission);
                        tmp.Add(Btn_StopTrasmission);
                        tmp.Add(Btn_ReloadFile);
                        tmp.Add(GrpBx_ManualExecution);
                        tmp.Add(Btn_Clear);
                        EnableDisable_Lists(tmp, tmp);
                        #endregion

                    }
                    else
                    {
                        Execute = new Thread(new ThreadStart(ExecuteCommand));
                        Execute.Start();
                    }
                }
            }
        }


        private void EnableDisable_Lists(List<Control> ListOfControlsToEnable, List<Control> ListOfControlsToDisable)
        {
            foreach (Control item in ListOfControlsToEnable) EnableDisable(item, true);
            foreach (Control item in ListOfControlsToDisable) EnableDisable(item, false);
        }

        private void EnableDisable(Control c, bool b)
        {
            #region IF c.InvokeRequired
            if (c.InvokeRequired)
            {
                EnableDisableOfControl_CallBack Set = new EnableDisableOfControl_CallBack(EnableDisable);
                c.Invoke(Set, new object[] { c, b });
            }
            #endregion
            #region ELSE
            else
            {
                c.Enabled = b;

            }
            #endregion
        }
    }
}
