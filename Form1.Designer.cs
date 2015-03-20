namespace cncCutterController
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberare le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Text = "Form1";

            this.GrpBx_SerialComunication = new System.Windows.Forms.GroupBox();
            this.Btn_SerialPortClose = new System.Windows.Forms.Button();
            this.Btn_SerialPortOpen = new System.Windows.Forms.Button();
            this.Lbl_PortName = new System.Windows.Forms.Label();
            this.CmbBx_PortName = new System.Windows.Forms.ComboBox();
            this.GrpBx_ManualExecution = new System.Windows.Forms.GroupBox();
            this.NumUpDw_ManualDistance = new System.Windows.Forms.NumericUpDown();
            this.Btn_Dec_Y = new System.Windows.Forms.Button();
            this.Lbl_InfoManualExecuting = new System.Windows.Forms.Label();
            this.Btn_Inc_X = new System.Windows.Forms.Button();
            this.RdBtn_Distance10mm = new System.Windows.Forms.RadioButton();
            this.Btn_Dec_X = new System.Windows.Forms.Button();
            this.Btn_Dec_Z = new System.Windows.Forms.Button();
            this.RdBtn_Distance1mm = new System.Windows.Forms.RadioButton();
            this.Btn_Inc_Y = new System.Windows.Forms.Button();
            this.RdBtn_DistanceXmm = new System.Windows.Forms.RadioButton();
            this.Btn_Inc_Z = new System.Windows.Forms.Button();
            this.GrpBx_Tools = new System.Windows.Forms.GroupBox();
            this.RcTxtBx_Chronology = new System.Windows.Forms.RichTextBox();
            this.TbCtrl_Outputs = new System.Windows.Forms.TabControl();
            this.TbPg_Chronology = new System.Windows.Forms.TabPage();
            this.TbPg_Commands = new System.Windows.Forms.TabPage();
            this.DtGrd_Commands = new System.Windows.Forms.DataGridView();
            this.DtGrd_Clm_Commands = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DtGrd_Clm_Sent = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DtGrd_Clm_Response = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Btn_LoadFile = new System.Windows.Forms.Button();
            this.TxtBx_LoadedFile = new System.Windows.Forms.TextBox();
            this.Btn_StartTrasmission = new System.Windows.Forms.Button();
            this.Btn_StopTrasmission = new System.Windows.Forms.Button();
            this.Btn_ReloadFile = new System.Windows.Forms.Button();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.GrpBx_SerialComunication.SuspendLayout();
            this.GrpBx_ManualExecution.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDw_ManualDistance)).BeginInit();
            this.TbCtrl_Outputs.SuspendLayout();
            this.TbPg_Chronology.SuspendLayout();
            this.TbPg_Commands.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtGrd_Commands)).BeginInit();
            this.SuspendLayout();
            // 
            // GrpBx_SerialComunication
            // 
            this.GrpBx_SerialComunication.Controls.Add(this.Btn_SerialPortClose);
            this.GrpBx_SerialComunication.Controls.Add(this.Btn_SerialPortOpen);
            this.GrpBx_SerialComunication.Controls.Add(this.Lbl_PortName);
            this.GrpBx_SerialComunication.Controls.Add(this.CmbBx_PortName);
            this.GrpBx_SerialComunication.Location = new System.Drawing.Point(16, 17);
            this.GrpBx_SerialComunication.Name = "GrpBx_SerialComunication";
            this.GrpBx_SerialComunication.Size = new System.Drawing.Size(263, 97);
            this.GrpBx_SerialComunication.TabIndex = 0;
            this.GrpBx_SerialComunication.TabStop = false;
            this.GrpBx_SerialComunication.Text = "Serial Comunication";
            // 
            // Btn_SerialPortClose
            // 
            this.Btn_SerialPortClose.Location = new System.Drawing.Point(125, 53);
            this.Btn_SerialPortClose.Name = "Btn_SerialPortClose";
            this.Btn_SerialPortClose.Size = new System.Drawing.Size(75, 23);
            this.Btn_SerialPortClose.TabIndex = 2;
            this.Btn_SerialPortClose.Text = "Close";
            this.Btn_SerialPortClose.UseVisualStyleBackColor = true;
            this.Btn_SerialPortClose.Click += new System.EventHandler(this.Btn_SerialPortClose_Click);
            // 
            // Btn_SerialPortOpen
            // 
            this.Btn_SerialPortOpen.Location = new System.Drawing.Point(43, 53);
            this.Btn_SerialPortOpen.Name = "Btn_SerialPortOpen";
            this.Btn_SerialPortOpen.Size = new System.Drawing.Size(75, 23);
            this.Btn_SerialPortOpen.TabIndex = 1;
            this.Btn_SerialPortOpen.Text = "Open";
            this.Btn_SerialPortOpen.UseVisualStyleBackColor = true;
            this.Btn_SerialPortOpen.Click += new System.EventHandler(this.Btn_SerialPortOpen_Click);
            // 
            // Lbl_PortName
            // 
            this.Lbl_PortName.AutoSize = true;
            this.Lbl_PortName.Location = new System.Drawing.Point(28, 29);
            this.Lbl_PortName.Name = "Lbl_PortName";
            this.Lbl_PortName.Size = new System.Drawing.Size(57, 13);
            this.Lbl_PortName.TabIndex = 1;
            this.Lbl_PortName.Text = "Port Name";
            // 
            // CmbBx_PortName
            // 
            this.CmbBx_PortName.FormattingEnabled = true;
            this.CmbBx_PortName.Location = new System.Drawing.Point(91, 26);
            this.CmbBx_PortName.Name = "CmbBx_PortName";
            this.CmbBx_PortName.Size = new System.Drawing.Size(121, 21);
            this.CmbBx_PortName.TabIndex = 0;
            // 
            // GrpBx_ManualExecution
            // 
            this.GrpBx_ManualExecution.Controls.Add(this.NumUpDw_ManualDistance);
            this.GrpBx_ManualExecution.Controls.Add(this.Btn_Dec_Y);
            this.GrpBx_ManualExecution.Controls.Add(this.Lbl_InfoManualExecuting);
            this.GrpBx_ManualExecution.Controls.Add(this.Btn_Inc_X);
            this.GrpBx_ManualExecution.Controls.Add(this.RdBtn_Distance10mm);
            this.GrpBx_ManualExecution.Controls.Add(this.Btn_Dec_X);
            this.GrpBx_ManualExecution.Controls.Add(this.Btn_Dec_Z);
            this.GrpBx_ManualExecution.Controls.Add(this.RdBtn_Distance1mm);
            this.GrpBx_ManualExecution.Controls.Add(this.Btn_Inc_Y);
            this.GrpBx_ManualExecution.Controls.Add(this.RdBtn_DistanceXmm);
            this.GrpBx_ManualExecution.Controls.Add(this.Btn_Inc_Z);
            this.GrpBx_ManualExecution.Location = new System.Drawing.Point(16, 120);
            this.GrpBx_ManualExecution.Name = "GrpBx_ManualExecution";
            this.GrpBx_ManualExecution.Size = new System.Drawing.Size(263, 199);
            this.GrpBx_ManualExecution.TabIndex = 0;
            this.GrpBx_ManualExecution.TabStop = false;
            this.GrpBx_ManualExecution.Text = "Manual Execution";
            // 
            // NumUpDw_ManualDistance
            // 
            this.NumUpDw_ManualDistance.DecimalPlaces = 2;
            this.NumUpDw_ManualDistance.Location = new System.Drawing.Point(183, 43);
            this.NumUpDw_ManualDistance.Name = "NumUpDw_ManualDistance";
            this.NumUpDw_ManualDistance.Size = new System.Drawing.Size(50, 20);
            this.NumUpDw_ManualDistance.TabIndex = 1;
            // 
            // Btn_Dec_Y
            // 
            this.Btn_Dec_Y.Location = new System.Drawing.Point(10, 117);
            this.Btn_Dec_Y.Name = "Btn_Dec_Y";
            this.Btn_Dec_Y.Size = new System.Drawing.Size(50, 30);
            this.Btn_Dec_Y.TabIndex = 5;
            this.Btn_Dec_Y.Text = "Y-";
            this.Btn_Dec_Y.UseVisualStyleBackColor = true;
            this.Btn_Dec_Y.Click += new System.EventHandler(this.Btn_Manual_Click);
            // 
            // Lbl_InfoManualExecuting
            // 
            this.Lbl_InfoManualExecuting.AutoSize = true;
            this.Lbl_InfoManualExecuting.Location = new System.Drawing.Point(54, 25);
            this.Lbl_InfoManualExecuting.Name = "Lbl_InfoManualExecuting";
            this.Lbl_InfoManualExecuting.Size = new System.Drawing.Size(133, 13);
            this.Lbl_InfoManualExecuting.TabIndex = 4;
            this.Lbl_InfoManualExecuting.Text = "Distances are in millimeters";
            // 
            // Btn_Inc_X
            // 
            this.Btn_Inc_X.Location = new System.Drawing.Point(66, 81);
            this.Btn_Inc_X.Name = "Btn_Inc_X";
            this.Btn_Inc_X.Size = new System.Drawing.Size(50, 30);
            this.Btn_Inc_X.TabIndex = 0;
            this.Btn_Inc_X.Text = "X+";
            this.Btn_Inc_X.UseVisualStyleBackColor = true;
            this.Btn_Inc_X.Click += new System.EventHandler(this.Btn_Manual_Click);
            // 
            // RdBtn_Distance10mm
            // 
            this.RdBtn_Distance10mm.AutoSize = true;
            this.RdBtn_Distance10mm.Location = new System.Drawing.Point(92, 43);
            this.RdBtn_Distance10mm.Name = "RdBtn_Distance10mm";
            this.RdBtn_Distance10mm.Size = new System.Drawing.Size(37, 17);
            this.RdBtn_Distance10mm.TabIndex = 2;
            this.RdBtn_Distance10mm.Text = "10";
            this.RdBtn_Distance10mm.UseVisualStyleBackColor = true;
            // 
            // Btn_Dec_X
            // 
            this.Btn_Dec_X.Location = new System.Drawing.Point(66, 153);
            this.Btn_Dec_X.Name = "Btn_Dec_X";
            this.Btn_Dec_X.Size = new System.Drawing.Size(50, 30);
            this.Btn_Dec_X.TabIndex = 3;
            this.Btn_Dec_X.Text = "X-";
            this.Btn_Dec_X.UseVisualStyleBackColor = true;
            this.Btn_Dec_X.Click += new System.EventHandler(this.Btn_Manual_Click);
            // 
            // Btn_Dec_Z
            // 
            this.Btn_Dec_Z.Location = new System.Drawing.Point(192, 153);
            this.Btn_Dec_Z.Name = "Btn_Dec_Z";
            this.Btn_Dec_Z.Size = new System.Drawing.Size(50, 30);
            this.Btn_Dec_Z.TabIndex = 1;
            this.Btn_Dec_Z.Text = "Z-";
            this.Btn_Dec_Z.UseVisualStyleBackColor = true;
            this.Btn_Dec_Z.Click += new System.EventHandler(this.Btn_Manual_Click);
            // 
            // RdBtn_Distance1mm
            // 
            this.RdBtn_Distance1mm.AutoSize = true;
            this.RdBtn_Distance1mm.Checked = true;
            this.RdBtn_Distance1mm.Location = new System.Drawing.Point(31, 41);
            this.RdBtn_Distance1mm.Name = "RdBtn_Distance1mm";
            this.RdBtn_Distance1mm.Size = new System.Drawing.Size(31, 17);
            this.RdBtn_Distance1mm.TabIndex = 1;
            this.RdBtn_Distance1mm.TabStop = true;
            this.RdBtn_Distance1mm.Text = "1";
            this.RdBtn_Distance1mm.UseVisualStyleBackColor = true;
            // 
            // Btn_Inc_Y
            // 
            this.Btn_Inc_Y.Location = new System.Drawing.Point(122, 117);
            this.Btn_Inc_Y.Name = "Btn_Inc_Y";
            this.Btn_Inc_Y.Size = new System.Drawing.Size(50, 30);
            this.Btn_Inc_Y.TabIndex = 4;
            this.Btn_Inc_Y.Text = "Y+";
            this.Btn_Inc_Y.UseVisualStyleBackColor = true;
            this.Btn_Inc_Y.Click += new System.EventHandler(this.Btn_Manual_Click);
            // 
            // RdBtn_DistanceXmm
            // 
            this.RdBtn_DistanceXmm.AutoSize = true;
            this.RdBtn_DistanceXmm.Location = new System.Drawing.Point(163, 45);
            this.RdBtn_DistanceXmm.Name = "RdBtn_DistanceXmm";
            this.RdBtn_DistanceXmm.Size = new System.Drawing.Size(14, 13);
            this.RdBtn_DistanceXmm.TabIndex = 3;
            this.RdBtn_DistanceXmm.UseVisualStyleBackColor = true;
            // 
            // Btn_Inc_Z
            // 
            this.Btn_Inc_Z.Location = new System.Drawing.Point(192, 81);
            this.Btn_Inc_Z.Name = "Btn_Inc_Z";
            this.Btn_Inc_Z.Size = new System.Drawing.Size(50, 30);
            this.Btn_Inc_Z.TabIndex = 2;
            this.Btn_Inc_Z.Text = "Z+";
            this.Btn_Inc_Z.UseVisualStyleBackColor = true;
            this.Btn_Inc_Z.Click += new System.EventHandler(this.Btn_Manual_Click);
            // 
            // GrpBx_Tools
            // 
            this.GrpBx_Tools.Location = new System.Drawing.Point(16, 325);
            this.GrpBx_Tools.Name = "GrpBx_Tools";
            this.GrpBx_Tools.Size = new System.Drawing.Size(263, 115);
            this.GrpBx_Tools.TabIndex = 1;
            this.GrpBx_Tools.TabStop = false;
            this.GrpBx_Tools.Text = "Tools";
            // 
            // RcTxtBx_Chronology
            // 
            this.RcTxtBx_Chronology.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RcTxtBx_Chronology.Location = new System.Drawing.Point(3, 3);
            this.RcTxtBx_Chronology.Name = "RcTxtBx_Chronology";
            this.RcTxtBx_Chronology.Size = new System.Drawing.Size(406, 285);
            this.RcTxtBx_Chronology.TabIndex = 3;
            this.RcTxtBx_Chronology.Text = "";
            // 
            // TbCtrl_Outputs
            // 
            this.TbCtrl_Outputs.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.TbCtrl_Outputs.Controls.Add(this.TbPg_Chronology);
            this.TbCtrl_Outputs.Controls.Add(this.TbPg_Commands);
            this.TbCtrl_Outputs.Location = new System.Drawing.Point(285, 120);
            this.TbCtrl_Outputs.Name = "TbCtrl_Outputs";
            this.TbCtrl_Outputs.SelectedIndex = 0;
            this.TbCtrl_Outputs.Size = new System.Drawing.Size(420, 320);
            this.TbCtrl_Outputs.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.TbCtrl_Outputs.TabIndex = 4;
            // 
            // TbPg_Chronology
            // 
            this.TbPg_Chronology.Controls.Add(this.RcTxtBx_Chronology);
            this.TbPg_Chronology.Location = new System.Drawing.Point(4, 25);
            this.TbPg_Chronology.Name = "TbPg_Chronology";
            this.TbPg_Chronology.Padding = new System.Windows.Forms.Padding(3);
            this.TbPg_Chronology.Size = new System.Drawing.Size(412, 291);
            this.TbPg_Chronology.TabIndex = 0;
            this.TbPg_Chronology.Text = "Chronology";
            this.TbPg_Chronology.UseVisualStyleBackColor = true;
            // 
            // TbPg_Commands
            // 
            this.TbPg_Commands.Controls.Add(this.DtGrd_Commands);
            this.TbPg_Commands.Location = new System.Drawing.Point(4, 25);
            this.TbPg_Commands.Name = "TbPg_Commands";
            this.TbPg_Commands.Padding = new System.Windows.Forms.Padding(3);
            this.TbPg_Commands.Size = new System.Drawing.Size(412, 291);
            this.TbPg_Commands.TabIndex = 1;
            this.TbPg_Commands.Text = "Commands";
            this.TbPg_Commands.UseVisualStyleBackColor = true;
            // 
            // DtGrd_Commands
            // 
            this.DtGrd_Commands.AllowUserToAddRows = false;
            this.DtGrd_Commands.AllowUserToDeleteRows = false;
            this.DtGrd_Commands.AllowUserToResizeColumns = false;
            this.DtGrd_Commands.AllowUserToResizeRows = false;
            this.DtGrd_Commands.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtGrd_Commands.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DtGrd_Clm_Commands,
            this.DtGrd_Clm_Sent,
            this.DtGrd_Clm_Response});
            this.DtGrd_Commands.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DtGrd_Commands.Location = new System.Drawing.Point(3, 3);
            this.DtGrd_Commands.MultiSelect = false;
            this.DtGrd_Commands.Name = "DtGrd_Commands";
            this.DtGrd_Commands.ReadOnly = true;
            this.DtGrd_Commands.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DtGrd_Commands.RowTemplate.ReadOnly = true;
            this.DtGrd_Commands.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DtGrd_Commands.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DtGrd_Commands.Size = new System.Drawing.Size(406, 285);
            this.DtGrd_Commands.TabIndex = 5;
            // 
            // DtGrd_Clm_Commands
            // 
            this.DtGrd_Clm_Commands.HeaderText = "Commands";
            this.DtGrd_Clm_Commands.Name = "DtGrd_Clm_Commands";
            this.DtGrd_Clm_Commands.ReadOnly = true;
            this.DtGrd_Clm_Commands.Width = 200;
            // 
            // DtGrd_Clm_Sent
            // 
            this.DtGrd_Clm_Sent.HeaderText = "Sent";
            this.DtGrd_Clm_Sent.Name = "DtGrd_Clm_Sent";
            this.DtGrd_Clm_Sent.ReadOnly = true;
            this.DtGrd_Clm_Sent.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DtGrd_Clm_Sent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DtGrd_Clm_Sent.Width = 82;
            // 
            // DtGrd_Clm_Response
            // 
            this.DtGrd_Clm_Response.HeaderText = "Response";
            this.DtGrd_Clm_Response.Name = "DtGrd_Clm_Response";
            this.DtGrd_Clm_Response.ReadOnly = true;
            this.DtGrd_Clm_Response.Width = 81;
            // 
            // Btn_LoadFile
            // 
            this.Btn_LoadFile.Location = new System.Drawing.Point(285, 17);
            this.Btn_LoadFile.Name = "Btn_LoadFile";
            this.Btn_LoadFile.Size = new System.Drawing.Size(75, 23);
            this.Btn_LoadFile.TabIndex = 5;
            this.Btn_LoadFile.Text = "Load";
            this.Btn_LoadFile.UseVisualStyleBackColor = true;
            this.Btn_LoadFile.Click += new System.EventHandler(this.Btn_LoadFile_Click);
            // 
            // TxtBx_LoadedFile
            // 
            this.TxtBx_LoadedFile.Location = new System.Drawing.Point(447, 19);
            this.TxtBx_LoadedFile.Name = "TxtBx_LoadedFile";
            this.TxtBx_LoadedFile.ReadOnly = true;
            this.TxtBx_LoadedFile.Size = new System.Drawing.Size(250, 20);
            this.TxtBx_LoadedFile.TabIndex = 6;
            // 
            // Btn_StartTrasmission
            // 
            this.Btn_StartTrasmission.Location = new System.Drawing.Point(623, 46);
            this.Btn_StartTrasmission.Name = "Btn_StartTrasmission";
            this.Btn_StartTrasmission.Size = new System.Drawing.Size(75, 23);
            this.Btn_StartTrasmission.TabIndex = 8;
            this.Btn_StartTrasmission.Text = "Start";
            this.Btn_StartTrasmission.UseVisualStyleBackColor = true;
            this.Btn_StartTrasmission.Click += new System.EventHandler(this.Btn_StartTrasmission_Click);
            // 
            // Btn_StopTrasmission
            // 
            this.Btn_StopTrasmission.Location = new System.Drawing.Point(622, 75);
            this.Btn_StopTrasmission.Name = "Btn_StopTrasmission";
            this.Btn_StopTrasmission.Size = new System.Drawing.Size(75, 23);
            this.Btn_StopTrasmission.TabIndex = 9;
            this.Btn_StopTrasmission.Text = "Stop";
            this.Btn_StopTrasmission.UseVisualStyleBackColor = true;
            this.Btn_StopTrasmission.Click += new System.EventHandler(this.Btn_StopTrasmission_Click);
            // 
            // Btn_ReloadFile
            // 
            this.Btn_ReloadFile.Location = new System.Drawing.Point(366, 17);
            this.Btn_ReloadFile.Name = "Btn_ReloadFile";
            this.Btn_ReloadFile.Size = new System.Drawing.Size(75, 23);
            this.Btn_ReloadFile.TabIndex = 7;
            this.Btn_ReloadFile.Text = "Reload";
            this.Btn_ReloadFile.UseVisualStyleBackColor = true;
            this.Btn_ReloadFile.Click += new System.EventHandler(this.Btn_ReloadFile_Click);
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.Location = new System.Drawing.Point(434, 116);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.Btn_Clear.TabIndex = 10;
            this.Btn_Clear.Text = "Clear";
            this.Btn_Clear.UseVisualStyleBackColor = true;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // GBRL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(733, 460);
            this.Controls.Add(this.Btn_Clear);
            this.Controls.Add(this.Btn_StopTrasmission);
            this.Controls.Add(this.Btn_StartTrasmission);
            this.Controls.Add(this.Btn_ReloadFile);
            this.Controls.Add(this.TxtBx_LoadedFile);
            this.Controls.Add(this.Btn_LoadFile);
            this.Controls.Add(this.TbCtrl_Outputs);
            this.Controls.Add(this.GrpBx_Tools);
            this.Controls.Add(this.GrpBx_ManualExecution);
            this.Controls.Add(this.GrpBx_SerialComunication);
            this.Name = "GBRL";
            this.Text = "cncCutterController";
            this.Load += new System.EventHandler(this.GBRL_Load);
            this.GrpBx_SerialComunication.ResumeLayout(false);
            this.GrpBx_SerialComunication.PerformLayout();
            this.GrpBx_ManualExecution.ResumeLayout(false);
            this.GrpBx_ManualExecution.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDw_ManualDistance)).EndInit();
            this.TbCtrl_Outputs.ResumeLayout(false);
            this.TbPg_Chronology.ResumeLayout(false);
            this.TbPg_Commands.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtGrd_Commands)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox GrpBx_SerialComunication;
        private System.Windows.Forms.GroupBox GrpBx_ManualExecution;
        private System.Windows.Forms.Button Btn_Inc_X;
        private System.Windows.Forms.Label Lbl_InfoManualExecuting;
        private System.Windows.Forms.RadioButton RdBtn_DistanceXmm;
        private System.Windows.Forms.RadioButton RdBtn_Distance10mm;
        private System.Windows.Forms.RadioButton RdBtn_Distance1mm;
        private System.Windows.Forms.Button Btn_Dec_Y;
        private System.Windows.Forms.Button Btn_Inc_Y;
        private System.Windows.Forms.Button Btn_Dec_Z;
        private System.Windows.Forms.Button Btn_Dec_X;
        private System.Windows.Forms.Button Btn_Inc_Z;
        private System.Windows.Forms.Button Btn_SerialPortClose;
        private System.Windows.Forms.Button Btn_SerialPortOpen;
        private System.Windows.Forms.Label Lbl_PortName;
        private System.Windows.Forms.ComboBox CmbBx_PortName;
        private System.Windows.Forms.NumericUpDown NumUpDw_ManualDistance;
        private System.Windows.Forms.GroupBox GrpBx_Tools;
        private System.Windows.Forms.RichTextBox RcTxtBx_Chronology;
        private System.Windows.Forms.TabControl TbCtrl_Outputs;
        private System.Windows.Forms.TabPage TbPg_Chronology;
        private System.Windows.Forms.TabPage TbPg_Commands;
        private System.Windows.Forms.DataGridView DtGrd_Commands;
        private System.Windows.Forms.DataGridViewTextBoxColumn DtGrd_Clm_Commands;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DtGrd_Clm_Sent;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DtGrd_Clm_Response;
        private System.Windows.Forms.Button Btn_LoadFile;
        private System.Windows.Forms.TextBox TxtBx_LoadedFile;
        private System.Windows.Forms.Button Btn_StartTrasmission;
        private System.Windows.Forms.Button Btn_StopTrasmission;
        private System.Windows.Forms.Button Btn_ReloadFile;
        private System.Windows.Forms.Button Btn_Clear;
    }
}

