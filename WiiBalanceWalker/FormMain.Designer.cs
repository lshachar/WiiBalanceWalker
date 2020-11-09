namespace WiiBalanceWalker
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.label_rwWT = new System.Windows.Forms.Label();
            this.button_Connect = new System.Windows.Forms.Button();
            this.label_brX = new System.Windows.Forms.Label();
            this.label_brY = new System.Windows.Forms.Label();
            this.label_brDL = new System.Windows.Forms.Label();
            this.label_brDR = new System.Windows.Forms.Label();
            this.groupBox_RawWeight = new System.Windows.Forms.GroupBox();
            this.label_rwBR = new System.Windows.Forms.Label();
            this.label_rwBL = new System.Windows.Forms.Label();
            this.label_rwTR = new System.Windows.Forms.Label();
            this.label_rwTL = new System.Windows.Forms.Label();
            this.groupBox_OffsetWeight = new System.Windows.Forms.GroupBox();
            this.label_owWT = new System.Windows.Forms.Label();
            this.label_owTL = new System.Windows.Forms.Label();
            this.label_owTR = new System.Windows.Forms.Label();
            this.label_owBL = new System.Windows.Forms.Label();
            this.label_owBR = new System.Windows.Forms.Label();
            this.groupBox_OffsetWeightRatio = new System.Windows.Forms.GroupBox();
            this.label_owrTL = new System.Windows.Forms.Label();
            this.label_owrTR = new System.Windows.Forms.Label();
            this.label_owrBL = new System.Windows.Forms.Label();
            this.label_owrBR = new System.Windows.Forms.Label();
            this.groupBox_General = new System.Windows.Forms.GroupBox();
            this.zeroout = new System.Windows.Forms.Button();
            this.button_SetCenterOffset = new System.Windows.Forms.Button();
            this.button_ResetDefaults = new System.Windows.Forms.Button();
            this.button_BluetoothAddDevice = new System.Windows.Forms.Button();
            this.checkBox_SendCGtoXY = new System.Windows.Forms.CheckBox();
            this.groupBox_BalanceRatio = new System.Windows.Forms.GroupBox();
            this.label_brDF = new System.Windows.Forms.Label();
            this.groupBox_BalanceRatioTriggers = new System.Windows.Forms.GroupBox();
            this.numericUpDown_TMFB = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_TMLR = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_TFB = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_TLR = new System.Windows.Forms.NumericUpDown();
            this.label_TMFB = new System.Windows.Forms.Label();
            this.label_TMLR = new System.Windows.Forms.Label();
            this.label_TFB = new System.Windows.Forms.Label();
            this.label_TLR = new System.Windows.Forms.Label();
            this.label_Status = new System.Windows.Forms.Label();
            this.groupBox_Actions = new System.Windows.Forms.GroupBox();
            this.checkBox_DisableActions = new System.Windows.Forms.CheckBox();
            this.numericUpDown_ADR = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_ADL = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_AJ = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_AM = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_AB = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_AF = new System.Windows.Forms.NumericUpDown();
            this.comboBox_ADR = new System.Windows.Forms.ComboBox();
            this.comboBox_AJ = new System.Windows.Forms.ComboBox();
            this.comboBox_ADL = new System.Windows.Forms.ComboBox();
            this.label_ActionJump = new System.Windows.Forms.Label();
            this.label_ActionDiagonalRight = new System.Windows.Forms.Label();
            this.label_ActionDiagonalLeft = new System.Windows.Forms.Label();
            this.label_ActionModifier = new System.Windows.Forms.Label();
            this.label_ActionBackward = new System.Windows.Forms.Label();
            this.label_ActionForward = new System.Windows.Forms.Label();
            this.label_ActionRight = new System.Windows.Forms.Label();
            this.label_ActionLeft = new System.Windows.Forms.Label();
            this.numericUpDown_AR = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_AL = new System.Windows.Forms.NumericUpDown();
            this.comboBox_AM = new System.Windows.Forms.ComboBox();
            this.comboBox_AF = new System.Windows.Forms.ComboBox();
            this.comboBox_AB = new System.Windows.Forms.ComboBox();
            this.comboBox_AR = new System.Windows.Forms.ComboBox();
            this.comboBox_AL = new System.Windows.Forms.ComboBox();
            this.checkBox_EnableJoystick = new System.Windows.Forms.CheckBox();
            this.consoleBox = new System.Windows.Forms.TextBox();
            this.checkBox_Send4LoadSensors = new System.Windows.Forms.CheckBox();
            this.groupBox_vJoy_output = new System.Windows.Forms.GroupBox();
            this.checkBox_ShowValuesInConsole = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.VJoyIDUpDown = new System.Windows.Forms.NumericUpDown();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.checkBox_StartupAutoConnect = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.startupOptions = new System.Windows.Forms.GroupBox();
            this.checkBox_StartMinimized = new System.Windows.Forms.CheckBox();
            this.checkBox_AutoTare = new System.Windows.Forms.CheckBox();
            this.groupBox_RawWeight.SuspendLayout();
            this.groupBox_OffsetWeight.SuspendLayout();
            this.groupBox_OffsetWeightRatio.SuspendLayout();
            this.groupBox_General.SuspendLayout();
            this.groupBox_BalanceRatio.SuspendLayout();
            this.groupBox_BalanceRatioTriggers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TMFB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TMLR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TFB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TLR)).BeginInit();
            this.groupBox_Actions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ADR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ADL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_AJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_AM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_AB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_AF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_AR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_AL)).BeginInit();
            this.groupBox_vJoy_output.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VJoyIDUpDown)).BeginInit();
            this.startupOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_rwWT
            // 
            this.label_rwWT.AutoSize = true;
            this.label_rwWT.Location = new System.Drawing.Point(63, 113);
            this.label_rwWT.Name = "label_rwWT";
            this.label_rwWT.Size = new System.Drawing.Size(25, 13);
            this.label_rwWT.TabIndex = 0;
            this.label_rwWT.Text = "WT";
            // 
            // button_Connect
            // 
            this.button_Connect.Location = new System.Drawing.Point(174, 82);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(183, 48);
            this.button_Connect.TabIndex = 0;
            this.button_Connect.Text = "Connect to Wii Balance Board";
            this.button_Connect.UseVisualStyleBackColor = true;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // label_brX
            // 
            this.label_brX.AutoSize = true;
            this.label_brX.Location = new System.Drawing.Point(25, 32);
            this.label_brX.Name = "label_brX";
            this.label_brX.Size = new System.Drawing.Size(14, 13);
            this.label_brX.TabIndex = 0;
            this.label_brX.Text = "X";
            // 
            // label_brY
            // 
            this.label_brY.AutoSize = true;
            this.label_brY.Location = new System.Drawing.Point(101, 32);
            this.label_brY.Name = "label_brY";
            this.label_brY.Size = new System.Drawing.Size(14, 13);
            this.label_brY.TabIndex = 0;
            this.label_brY.Text = "Y";
            // 
            // label_brDL
            // 
            this.label_brDL.AutoSize = true;
            this.label_brDL.Location = new System.Drawing.Point(25, 76);
            this.label_brDL.Name = "label_brDL";
            this.label_brDL.Size = new System.Drawing.Size(21, 13);
            this.label_brDL.TabIndex = 0;
            this.label_brDL.Text = "DL";
            // 
            // label_brDR
            // 
            this.label_brDR.AutoSize = true;
            this.label_brDR.Location = new System.Drawing.Point(101, 76);
            this.label_brDR.Name = "label_brDR";
            this.label_brDR.Size = new System.Drawing.Size(23, 13);
            this.label_brDR.TabIndex = 0;
            this.label_brDR.Text = "DR";
            // 
            // groupBox_RawWeight
            // 
            this.groupBox_RawWeight.Controls.Add(this.label_rwBR);
            this.groupBox_RawWeight.Controls.Add(this.label_rwBL);
            this.groupBox_RawWeight.Controls.Add(this.label_rwTR);
            this.groupBox_RawWeight.Controls.Add(this.label_rwTL);
            this.groupBox_RawWeight.Controls.Add(this.label_rwWT);
            this.groupBox_RawWeight.Location = new System.Drawing.Point(12, 12);
            this.groupBox_RawWeight.Name = "groupBox_RawWeight";
            this.groupBox_RawWeight.Size = new System.Drawing.Size(150, 139);
            this.groupBox_RawWeight.TabIndex = 3;
            this.groupBox_RawWeight.TabStop = false;
            this.groupBox_RawWeight.Text = "Raw Weight ";
            // 
            // label_rwBR
            // 
            this.label_rwBR.AutoSize = true;
            this.label_rwBR.Location = new System.Drawing.Point(101, 76);
            this.label_rwBR.Name = "label_rwBR";
            this.label_rwBR.Size = new System.Drawing.Size(22, 13);
            this.label_rwBR.TabIndex = 0;
            this.label_rwBR.Text = "BR";
            // 
            // label_rwBL
            // 
            this.label_rwBL.AutoSize = true;
            this.label_rwBL.Location = new System.Drawing.Point(25, 76);
            this.label_rwBL.Name = "label_rwBL";
            this.label_rwBL.Size = new System.Drawing.Size(20, 13);
            this.label_rwBL.TabIndex = 0;
            this.label_rwBL.Text = "BL";
            // 
            // label_rwTR
            // 
            this.label_rwTR.AutoSize = true;
            this.label_rwTR.Location = new System.Drawing.Point(101, 32);
            this.label_rwTR.Name = "label_rwTR";
            this.label_rwTR.Size = new System.Drawing.Size(22, 13);
            this.label_rwTR.TabIndex = 0;
            this.label_rwTR.Text = "TR";
            // 
            // label_rwTL
            // 
            this.label_rwTL.AutoSize = true;
            this.label_rwTL.Location = new System.Drawing.Point(25, 32);
            this.label_rwTL.Name = "label_rwTL";
            this.label_rwTL.Size = new System.Drawing.Size(20, 13);
            this.label_rwTL.TabIndex = 0;
            this.label_rwTL.Text = "TL";
            // 
            // groupBox_OffsetWeight
            // 
            this.groupBox_OffsetWeight.Controls.Add(this.label_owWT);
            this.groupBox_OffsetWeight.Controls.Add(this.label_owTL);
            this.groupBox_OffsetWeight.Controls.Add(this.label_owTR);
            this.groupBox_OffsetWeight.Controls.Add(this.label_owBL);
            this.groupBox_OffsetWeight.Controls.Add(this.label_owBR);
            this.groupBox_OffsetWeight.Location = new System.Drawing.Point(168, 12);
            this.groupBox_OffsetWeight.Name = "groupBox_OffsetWeight";
            this.groupBox_OffsetWeight.Size = new System.Drawing.Size(150, 139);
            this.groupBox_OffsetWeight.TabIndex = 4;
            this.groupBox_OffsetWeight.TabStop = false;
            this.groupBox_OffsetWeight.Text = "Offset Weight";
            // 
            // label_owWT
            // 
            this.label_owWT.AutoSize = true;
            this.label_owWT.Location = new System.Drawing.Point(63, 113);
            this.label_owWT.Name = "label_owWT";
            this.label_owWT.Size = new System.Drawing.Size(25, 13);
            this.label_owWT.TabIndex = 1;
            this.label_owWT.Text = "WT";
            // 
            // label_owTL
            // 
            this.label_owTL.AutoSize = true;
            this.label_owTL.Location = new System.Drawing.Point(25, 32);
            this.label_owTL.Name = "label_owTL";
            this.label_owTL.Size = new System.Drawing.Size(20, 13);
            this.label_owTL.TabIndex = 0;
            this.label_owTL.Text = "TL";
            // 
            // label_owTR
            // 
            this.label_owTR.AutoSize = true;
            this.label_owTR.Location = new System.Drawing.Point(101, 32);
            this.label_owTR.Name = "label_owTR";
            this.label_owTR.Size = new System.Drawing.Size(22, 13);
            this.label_owTR.TabIndex = 0;
            this.label_owTR.Text = "TR";
            // 
            // label_owBL
            // 
            this.label_owBL.AutoSize = true;
            this.label_owBL.Location = new System.Drawing.Point(25, 76);
            this.label_owBL.Name = "label_owBL";
            this.label_owBL.Size = new System.Drawing.Size(20, 13);
            this.label_owBL.TabIndex = 0;
            this.label_owBL.Text = "BL";
            // 
            // label_owBR
            // 
            this.label_owBR.AutoSize = true;
            this.label_owBR.Location = new System.Drawing.Point(101, 76);
            this.label_owBR.Name = "label_owBR";
            this.label_owBR.Size = new System.Drawing.Size(22, 13);
            this.label_owBR.TabIndex = 0;
            this.label_owBR.Text = "BR";
            // 
            // groupBox_OffsetWeightRatio
            // 
            this.groupBox_OffsetWeightRatio.Controls.Add(this.label_owrTL);
            this.groupBox_OffsetWeightRatio.Controls.Add(this.label_owrTR);
            this.groupBox_OffsetWeightRatio.Controls.Add(this.label_owrBL);
            this.groupBox_OffsetWeightRatio.Controls.Add(this.label_owrBR);
            this.groupBox_OffsetWeightRatio.Location = new System.Drawing.Point(324, 12);
            this.groupBox_OffsetWeightRatio.Name = "groupBox_OffsetWeightRatio";
            this.groupBox_OffsetWeightRatio.Size = new System.Drawing.Size(150, 139);
            this.groupBox_OffsetWeightRatio.TabIndex = 4;
            this.groupBox_OffsetWeightRatio.TabStop = false;
            this.groupBox_OffsetWeightRatio.Text = "Offset Weight Ratio";
            // 
            // label_owrTL
            // 
            this.label_owrTL.AutoSize = true;
            this.label_owrTL.Location = new System.Drawing.Point(25, 32);
            this.label_owrTL.Name = "label_owrTL";
            this.label_owrTL.Size = new System.Drawing.Size(20, 13);
            this.label_owrTL.TabIndex = 0;
            this.label_owrTL.Text = "TL";
            // 
            // label_owrTR
            // 
            this.label_owrTR.AutoSize = true;
            this.label_owrTR.Location = new System.Drawing.Point(101, 32);
            this.label_owrTR.Name = "label_owrTR";
            this.label_owrTR.Size = new System.Drawing.Size(22, 13);
            this.label_owrTR.TabIndex = 0;
            this.label_owrTR.Text = "TR";
            // 
            // label_owrBL
            // 
            this.label_owrBL.AutoSize = true;
            this.label_owrBL.Location = new System.Drawing.Point(25, 76);
            this.label_owrBL.Name = "label_owrBL";
            this.label_owrBL.Size = new System.Drawing.Size(20, 13);
            this.label_owrBL.TabIndex = 0;
            this.label_owrBL.Text = "BL";
            // 
            // label_owrBR
            // 
            this.label_owrBR.AutoSize = true;
            this.label_owrBR.Location = new System.Drawing.Point(101, 76);
            this.label_owrBR.Name = "label_owrBR";
            this.label_owrBR.Size = new System.Drawing.Size(22, 13);
            this.label_owrBR.TabIndex = 0;
            this.label_owrBR.Text = "BR";
            // 
            // groupBox_General
            // 
            this.groupBox_General.Controls.Add(this.zeroout);
            this.groupBox_General.Controls.Add(this.button_SetCenterOffset);
            this.groupBox_General.Controls.Add(this.button_ResetDefaults);
            this.groupBox_General.Controls.Add(this.button_BluetoothAddDevice);
            this.groupBox_General.Controls.Add(this.button_Connect);
            this.groupBox_General.Location = new System.Drawing.Point(12, 157);
            this.groupBox_General.Name = "groupBox_General";
            this.groupBox_General.Size = new System.Drawing.Size(373, 136);
            this.groupBox_General.TabIndex = 0;
            this.groupBox_General.TabStop = false;
            this.groupBox_General.Text = "General";
            // 
            // zeroout
            // 
            this.zeroout.Enabled = false;
            this.zeroout.Location = new System.Drawing.Point(15, 28);
            this.zeroout.Name = "zeroout";
            this.zeroout.Size = new System.Drawing.Size(138, 26);
            this.zeroout.TabIndex = 7;
            this.zeroout.Text = "Tare Balance Board";
            this.toolTip1.SetToolTip(this.zeroout, "Press this button while no weight is on the balance board, to reset all current r" +
        "aw weight values to zero");
            this.zeroout.UseVisualStyleBackColor = true;
            this.zeroout.Click += new System.EventHandler(this.zeroout_Click);
            // 
            // button_SetCenterOffset
            // 
            this.button_SetCenterOffset.Enabled = false;
            this.button_SetCenterOffset.Location = new System.Drawing.Point(15, 59);
            this.button_SetCenterOffset.Name = "button_SetCenterOffset";
            this.button_SetCenterOffset.Size = new System.Drawing.Size(138, 34);
            this.button_SetCenterOffset.TabIndex = 2;
            this.button_SetCenterOffset.Text = "Set current balance as center";
            this.toolTip1.SetToolTip(this.button_SetCenterOffset, "While standing or sitting on the balance board, click this button to set your cur" +
        "rent balance point as center");
            this.button_SetCenterOffset.UseVisualStyleBackColor = true;
            this.button_SetCenterOffset.Click += new System.EventHandler(this.button_SetCenterOffset_Click);
            // 
            // button_ResetDefaults
            // 
            this.button_ResetDefaults.Location = new System.Drawing.Point(15, 96);
            this.button_ResetDefaults.Name = "button_ResetDefaults";
            this.button_ResetDefaults.Size = new System.Drawing.Size(138, 34);
            this.button_ResetDefaults.TabIndex = 3;
            this.button_ResetDefaults.Text = "Load default settings and exit";
            this.button_ResetDefaults.UseVisualStyleBackColor = true;
            this.button_ResetDefaults.Click += new System.EventHandler(this.button_ResetDefaults_Click);
            // 
            // button_BluetoothAddDevice
            // 
            this.button_BluetoothAddDevice.Location = new System.Drawing.Point(174, 29);
            this.button_BluetoothAddDevice.Name = "button_BluetoothAddDevice";
            this.button_BluetoothAddDevice.Size = new System.Drawing.Size(183, 46);
            this.button_BluetoothAddDevice.TabIndex = 1;
            this.button_BluetoothAddDevice.Text = "Add/Remove bluetooth Wii device";
            this.button_BluetoothAddDevice.UseVisualStyleBackColor = true;
            this.button_BluetoothAddDevice.Click += new System.EventHandler(this.button_BluetoothAddDevice_Click);
            // 
            // checkBox_SendCGtoXY
            // 
            this.checkBox_SendCGtoXY.AutoSize = true;
            this.checkBox_SendCGtoXY.Checked = true;
            this.checkBox_SendCGtoXY.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_SendCGtoXY.Location = new System.Drawing.Point(6, 19);
            this.checkBox_SendCGtoXY.Name = "checkBox_SendCGtoXY";
            this.checkBox_SendCGtoXY.Size = new System.Drawing.Size(128, 17);
            this.checkBox_SendCGtoXY.TabIndex = 5;
            this.checkBox_SendCGtoXY.Text = "Send CG to X/Y axes";
            this.toolTip1.SetToolTip(this.checkBox_SendCGtoXY, "Send your center of gravity (balance point) as an X/Y input, to the virtual joyst" +
        "ick device.");
            this.checkBox_SendCGtoXY.UseVisualStyleBackColor = true;
            this.checkBox_SendCGtoXY.CheckedChanged += new System.EventHandler(this.checkBox_SendCGtoXY_CheckedChanged);
            // 
            // groupBox_BalanceRatio
            // 
            this.groupBox_BalanceRatio.Controls.Add(this.label_brDF);
            this.groupBox_BalanceRatio.Controls.Add(this.label_brX);
            this.groupBox_BalanceRatio.Controls.Add(this.label_brDR);
            this.groupBox_BalanceRatio.Controls.Add(this.label_brDL);
            this.groupBox_BalanceRatio.Controls.Add(this.label_brY);
            this.groupBox_BalanceRatio.Location = new System.Drawing.Point(480, 12);
            this.groupBox_BalanceRatio.Name = "groupBox_BalanceRatio";
            this.groupBox_BalanceRatio.Size = new System.Drawing.Size(150, 139);
            this.groupBox_BalanceRatio.TabIndex = 5;
            this.groupBox_BalanceRatio.TabStop = false;
            this.groupBox_BalanceRatio.Text = "Balance Ratio";
            // 
            // label_brDF
            // 
            this.label_brDF.AutoSize = true;
            this.label_brDF.Location = new System.Drawing.Point(65, 113);
            this.label_brDF.Name = "label_brDF";
            this.label_brDF.Size = new System.Drawing.Size(21, 13);
            this.label_brDF.TabIndex = 0;
            this.label_brDF.Text = "DF";
            // 
            // groupBox_BalanceRatioTriggers
            // 
            this.groupBox_BalanceRatioTriggers.Controls.Add(this.numericUpDown_TMFB);
            this.groupBox_BalanceRatioTriggers.Controls.Add(this.numericUpDown_TMLR);
            this.groupBox_BalanceRatioTriggers.Controls.Add(this.numericUpDown_TFB);
            this.groupBox_BalanceRatioTriggers.Controls.Add(this.numericUpDown_TLR);
            this.groupBox_BalanceRatioTriggers.Controls.Add(this.label_TMFB);
            this.groupBox_BalanceRatioTriggers.Controls.Add(this.label_TMLR);
            this.groupBox_BalanceRatioTriggers.Controls.Add(this.label_TFB);
            this.groupBox_BalanceRatioTriggers.Controls.Add(this.label_TLR);
            this.groupBox_BalanceRatioTriggers.Location = new System.Drawing.Point(18, 260);
            this.groupBox_BalanceRatioTriggers.Name = "groupBox_BalanceRatioTriggers";
            this.groupBox_BalanceRatioTriggers.Size = new System.Drawing.Size(239, 136);
            this.groupBox_BalanceRatioTriggers.TabIndex = 1;
            this.groupBox_BalanceRatioTriggers.TabStop = false;
            this.groupBox_BalanceRatioTriggers.Text = "Balance Ratio Triggers";
            // 
            // numericUpDown_TMFB
            // 
            this.numericUpDown_TMFB.Location = new System.Drawing.Point(178, 104);
            this.numericUpDown_TMFB.Maximum = new decimal(new int[] {
            51,
            0,
            0,
            0});
            this.numericUpDown_TMFB.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_TMFB.Name = "numericUpDown_TMFB";
            this.numericUpDown_TMFB.Size = new System.Drawing.Size(49, 20);
            this.numericUpDown_TMFB.TabIndex = 3;
            this.numericUpDown_TMFB.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_TMFB.ValueChanged += new System.EventHandler(this.numericUpDown_TMFB_ValueChanged);
            // 
            // numericUpDown_TMLR
            // 
            this.numericUpDown_TMLR.Location = new System.Drawing.Point(178, 78);
            this.numericUpDown_TMLR.Maximum = new decimal(new int[] {
            51,
            0,
            0,
            0});
            this.numericUpDown_TMLR.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_TMLR.Name = "numericUpDown_TMLR";
            this.numericUpDown_TMLR.Size = new System.Drawing.Size(49, 20);
            this.numericUpDown_TMLR.TabIndex = 2;
            this.numericUpDown_TMLR.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_TMLR.ValueChanged += new System.EventHandler(this.numericUpDown_TMLR_ValueChanged);
            // 
            // numericUpDown_TFB
            // 
            this.numericUpDown_TFB.Location = new System.Drawing.Point(178, 52);
            this.numericUpDown_TFB.Maximum = new decimal(new int[] {
            51,
            0,
            0,
            0});
            this.numericUpDown_TFB.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_TFB.Name = "numericUpDown_TFB";
            this.numericUpDown_TFB.Size = new System.Drawing.Size(49, 20);
            this.numericUpDown_TFB.TabIndex = 1;
            this.numericUpDown_TFB.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_TFB.ValueChanged += new System.EventHandler(this.numericUpDown_TFB_ValueChanged);
            // 
            // numericUpDown_TLR
            // 
            this.numericUpDown_TLR.Location = new System.Drawing.Point(178, 26);
            this.numericUpDown_TLR.Maximum = new decimal(new int[] {
            51,
            0,
            0,
            0});
            this.numericUpDown_TLR.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_TLR.Name = "numericUpDown_TLR";
            this.numericUpDown_TLR.Size = new System.Drawing.Size(49, 20);
            this.numericUpDown_TLR.TabIndex = 0;
            this.numericUpDown_TLR.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_TLR.ValueChanged += new System.EventHandler(this.numericUpDown_TLR_ValueChanged);
            // 
            // label_TMFB
            // 
            this.label_TMFB.AutoSize = true;
            this.label_TMFB.Location = new System.Drawing.Point(6, 106);
            this.label_TMFB.Name = "label_TMFB";
            this.label_TMFB.Size = new System.Drawing.Size(156, 13);
            this.label_TMFB.TabIndex = 0;
            this.label_TMFB.Text = "- Modifier + Foward / Backward";
            // 
            // label_TMLR
            // 
            this.label_TMLR.AutoSize = true;
            this.label_TMLR.Location = new System.Drawing.Point(6, 80);
            this.label_TMLR.Name = "label_TMLR";
            this.label_TMLR.Size = new System.Drawing.Size(116, 13);
            this.label_TMLR.TabIndex = 0;
            this.label_TMLR.Text = "- Modifier + Left / Right";
            // 
            // label_TFB
            // 
            this.label_TFB.AutoSize = true;
            this.label_TFB.Location = new System.Drawing.Point(6, 54);
            this.label_TFB.Name = "label_TFB";
            this.label_TFB.Size = new System.Drawing.Size(110, 13);
            this.label_TFB.TabIndex = 0;
            this.label_TFB.Text = "- Forward / Backward";
            // 
            // label_TLR
            // 
            this.label_TLR.AutoSize = true;
            this.label_TLR.Location = new System.Drawing.Point(6, 28);
            this.label_TLR.Name = "label_TLR";
            this.label_TLR.Size = new System.Drawing.Size(67, 13);
            this.label_TLR.TabIndex = 0;
            this.label_TLR.Text = "- Left / Right";
            // 
            // label_Status
            // 
            this.label_Status.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_Status.Location = new System.Drawing.Point(12, 296);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(618, 24);
            this.label_Status.TabIndex = 4;
            this.label_Status.Text = "STATUS";
            this.label_Status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox_Actions
            // 
            this.groupBox_Actions.Controls.Add(this.groupBox_BalanceRatioTriggers);
            this.groupBox_Actions.Controls.Add(this.checkBox_DisableActions);
            this.groupBox_Actions.Controls.Add(this.numericUpDown_ADR);
            this.groupBox_Actions.Controls.Add(this.numericUpDown_ADL);
            this.groupBox_Actions.Controls.Add(this.numericUpDown_AJ);
            this.groupBox_Actions.Controls.Add(this.numericUpDown_AM);
            this.groupBox_Actions.Controls.Add(this.numericUpDown_AB);
            this.groupBox_Actions.Controls.Add(this.numericUpDown_AF);
            this.groupBox_Actions.Controls.Add(this.comboBox_ADR);
            this.groupBox_Actions.Controls.Add(this.comboBox_AJ);
            this.groupBox_Actions.Controls.Add(this.comboBox_ADL);
            this.groupBox_Actions.Controls.Add(this.label_ActionJump);
            this.groupBox_Actions.Controls.Add(this.label_ActionDiagonalRight);
            this.groupBox_Actions.Controls.Add(this.label_ActionDiagonalLeft);
            this.groupBox_Actions.Controls.Add(this.label_ActionModifier);
            this.groupBox_Actions.Controls.Add(this.label_ActionBackward);
            this.groupBox_Actions.Controls.Add(this.label_ActionForward);
            this.groupBox_Actions.Controls.Add(this.label_ActionRight);
            this.groupBox_Actions.Controls.Add(this.label_ActionLeft);
            this.groupBox_Actions.Controls.Add(this.numericUpDown_AR);
            this.groupBox_Actions.Controls.Add(this.numericUpDown_AL);
            this.groupBox_Actions.Controls.Add(this.comboBox_AM);
            this.groupBox_Actions.Controls.Add(this.comboBox_AF);
            this.groupBox_Actions.Controls.Add(this.comboBox_AB);
            this.groupBox_Actions.Controls.Add(this.comboBox_AR);
            this.groupBox_Actions.Controls.Add(this.comboBox_AL);
            this.groupBox_Actions.Location = new System.Drawing.Point(636, 12);
            this.groupBox_Actions.Name = "groupBox_Actions";
            this.groupBox_Actions.Size = new System.Drawing.Size(296, 437);
            this.groupBox_Actions.TabIndex = 2;
            this.groupBox_Actions.TabStop = false;
            this.groupBox_Actions.Text = "Actions";
            // 
            // checkBox_DisableActions
            // 
            this.checkBox_DisableActions.AutoSize = true;
            this.checkBox_DisableActions.Location = new System.Drawing.Point(18, 407);
            this.checkBox_DisableActions.Name = "checkBox_DisableActions";
            this.checkBox_DisableActions.Size = new System.Drawing.Size(113, 17);
            this.checkBox_DisableActions.TabIndex = 0;
            this.checkBox_DisableActions.Text = "Disable All Actions";
            this.checkBox_DisableActions.UseVisualStyleBackColor = true;
            this.checkBox_DisableActions.CheckedChanged += new System.EventHandler(this.checkBox_DisableActions_CheckedChanged);
            // 
            // numericUpDown_ADR
            // 
            this.numericUpDown_ADR.Location = new System.Drawing.Point(235, 215);
            this.numericUpDown_ADR.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDown_ADR.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.numericUpDown_ADR.Name = "numericUpDown_ADR";
            this.numericUpDown_ADR.Size = new System.Drawing.Size(49, 20);
            this.numericUpDown_ADR.TabIndex = 17;
            // 
            // numericUpDown_ADL
            // 
            this.numericUpDown_ADL.Location = new System.Drawing.Point(235, 188);
            this.numericUpDown_ADL.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDown_ADL.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.numericUpDown_ADL.Name = "numericUpDown_ADL";
            this.numericUpDown_ADL.Size = new System.Drawing.Size(49, 20);
            this.numericUpDown_ADL.TabIndex = 15;
            // 
            // numericUpDown_AJ
            // 
            this.numericUpDown_AJ.Location = new System.Drawing.Point(235, 161);
            this.numericUpDown_AJ.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDown_AJ.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.numericUpDown_AJ.Name = "numericUpDown_AJ";
            this.numericUpDown_AJ.Size = new System.Drawing.Size(49, 20);
            this.numericUpDown_AJ.TabIndex = 13;
            // 
            // numericUpDown_AM
            // 
            this.numericUpDown_AM.Location = new System.Drawing.Point(235, 134);
            this.numericUpDown_AM.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDown_AM.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.numericUpDown_AM.Name = "numericUpDown_AM";
            this.numericUpDown_AM.Size = new System.Drawing.Size(49, 20);
            this.numericUpDown_AM.TabIndex = 11;
            // 
            // numericUpDown_AB
            // 
            this.numericUpDown_AB.Location = new System.Drawing.Point(235, 107);
            this.numericUpDown_AB.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDown_AB.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.numericUpDown_AB.Name = "numericUpDown_AB";
            this.numericUpDown_AB.Size = new System.Drawing.Size(49, 20);
            this.numericUpDown_AB.TabIndex = 9;
            // 
            // numericUpDown_AF
            // 
            this.numericUpDown_AF.Location = new System.Drawing.Point(235, 80);
            this.numericUpDown_AF.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDown_AF.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.numericUpDown_AF.Name = "numericUpDown_AF";
            this.numericUpDown_AF.Size = new System.Drawing.Size(49, 20);
            this.numericUpDown_AF.TabIndex = 7;
            // 
            // comboBox_ADR
            // 
            this.comboBox_ADR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ADR.FormattingEnabled = true;
            this.comboBox_ADR.Location = new System.Drawing.Point(104, 215);
            this.comboBox_ADR.Name = "comboBox_ADR";
            this.comboBox_ADR.Size = new System.Drawing.Size(125, 21);
            this.comboBox_ADR.TabIndex = 16;
            // 
            // comboBox_AJ
            // 
            this.comboBox_AJ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_AJ.FormattingEnabled = true;
            this.comboBox_AJ.Location = new System.Drawing.Point(104, 161);
            this.comboBox_AJ.Name = "comboBox_AJ";
            this.comboBox_AJ.Size = new System.Drawing.Size(125, 21);
            this.comboBox_AJ.TabIndex = 12;
            // 
            // comboBox_ADL
            // 
            this.comboBox_ADL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ADL.FormattingEnabled = true;
            this.comboBox_ADL.Location = new System.Drawing.Point(104, 188);
            this.comboBox_ADL.Name = "comboBox_ADL";
            this.comboBox_ADL.Size = new System.Drawing.Size(125, 21);
            this.comboBox_ADL.TabIndex = 14;
            // 
            // label_ActionJump
            // 
            this.label_ActionJump.AutoSize = true;
            this.label_ActionJump.Location = new System.Drawing.Point(15, 164);
            this.label_ActionJump.Name = "label_ActionJump";
            this.label_ActionJump.Size = new System.Drawing.Size(38, 13);
            this.label_ActionJump.TabIndex = 0;
            this.label_ActionJump.Text = "- Jump";
            // 
            // label_ActionDiagonalRight
            // 
            this.label_ActionDiagonalRight.AutoSize = true;
            this.label_ActionDiagonalRight.Location = new System.Drawing.Point(15, 218);
            this.label_ActionDiagonalRight.Name = "label_ActionDiagonalRight";
            this.label_ActionDiagonalRight.Size = new System.Drawing.Size(83, 13);
            this.label_ActionDiagonalRight.TabIndex = 0;
            this.label_ActionDiagonalRight.Text = "- Diagonal Right";
            // 
            // label_ActionDiagonalLeft
            // 
            this.label_ActionDiagonalLeft.AutoSize = true;
            this.label_ActionDiagonalLeft.Location = new System.Drawing.Point(15, 191);
            this.label_ActionDiagonalLeft.Name = "label_ActionDiagonalLeft";
            this.label_ActionDiagonalLeft.Size = new System.Drawing.Size(76, 13);
            this.label_ActionDiagonalLeft.TabIndex = 0;
            this.label_ActionDiagonalLeft.Text = "- Diagonal Left";
            // 
            // label_ActionModifier
            // 
            this.label_ActionModifier.AutoSize = true;
            this.label_ActionModifier.Location = new System.Drawing.Point(15, 137);
            this.label_ActionModifier.Name = "label_ActionModifier";
            this.label_ActionModifier.Size = new System.Drawing.Size(50, 13);
            this.label_ActionModifier.TabIndex = 0;
            this.label_ActionModifier.Text = "- Modifier";
            // 
            // label_ActionBackward
            // 
            this.label_ActionBackward.AutoSize = true;
            this.label_ActionBackward.Location = new System.Drawing.Point(15, 110);
            this.label_ActionBackward.Name = "label_ActionBackward";
            this.label_ActionBackward.Size = new System.Drawing.Size(61, 13);
            this.label_ActionBackward.TabIndex = 0;
            this.label_ActionBackward.Text = "- Backward";
            // 
            // label_ActionForward
            // 
            this.label_ActionForward.AutoSize = true;
            this.label_ActionForward.Location = new System.Drawing.Point(15, 83);
            this.label_ActionForward.Name = "label_ActionForward";
            this.label_ActionForward.Size = new System.Drawing.Size(51, 13);
            this.label_ActionForward.TabIndex = 0;
            this.label_ActionForward.Text = "- Forward";
            // 
            // label_ActionRight
            // 
            this.label_ActionRight.AutoSize = true;
            this.label_ActionRight.Location = new System.Drawing.Point(15, 56);
            this.label_ActionRight.Name = "label_ActionRight";
            this.label_ActionRight.Size = new System.Drawing.Size(38, 13);
            this.label_ActionRight.TabIndex = 0;
            this.label_ActionRight.Text = "- Right";
            // 
            // label_ActionLeft
            // 
            this.label_ActionLeft.AutoSize = true;
            this.label_ActionLeft.Location = new System.Drawing.Point(15, 29);
            this.label_ActionLeft.Name = "label_ActionLeft";
            this.label_ActionLeft.Size = new System.Drawing.Size(31, 13);
            this.label_ActionLeft.TabIndex = 0;
            this.label_ActionLeft.Text = "- Left";
            // 
            // numericUpDown_AR
            // 
            this.numericUpDown_AR.Location = new System.Drawing.Point(235, 53);
            this.numericUpDown_AR.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDown_AR.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.numericUpDown_AR.Name = "numericUpDown_AR";
            this.numericUpDown_AR.Size = new System.Drawing.Size(49, 20);
            this.numericUpDown_AR.TabIndex = 5;
            // 
            // numericUpDown_AL
            // 
            this.numericUpDown_AL.Location = new System.Drawing.Point(235, 26);
            this.numericUpDown_AL.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDown_AL.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.numericUpDown_AL.Name = "numericUpDown_AL";
            this.numericUpDown_AL.Size = new System.Drawing.Size(49, 20);
            this.numericUpDown_AL.TabIndex = 3;
            // 
            // comboBox_AM
            // 
            this.comboBox_AM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_AM.FormattingEnabled = true;
            this.comboBox_AM.Location = new System.Drawing.Point(104, 134);
            this.comboBox_AM.Name = "comboBox_AM";
            this.comboBox_AM.Size = new System.Drawing.Size(125, 21);
            this.comboBox_AM.TabIndex = 10;
            // 
            // comboBox_AF
            // 
            this.comboBox_AF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_AF.FormattingEnabled = true;
            this.comboBox_AF.Location = new System.Drawing.Point(104, 80);
            this.comboBox_AF.Name = "comboBox_AF";
            this.comboBox_AF.Size = new System.Drawing.Size(125, 21);
            this.comboBox_AF.TabIndex = 6;
            // 
            // comboBox_AB
            // 
            this.comboBox_AB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_AB.FormattingEnabled = true;
            this.comboBox_AB.Location = new System.Drawing.Point(104, 107);
            this.comboBox_AB.Name = "comboBox_AB";
            this.comboBox_AB.Size = new System.Drawing.Size(125, 21);
            this.comboBox_AB.TabIndex = 8;
            // 
            // comboBox_AR
            // 
            this.comboBox_AR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_AR.FormattingEnabled = true;
            this.comboBox_AR.Location = new System.Drawing.Point(104, 53);
            this.comboBox_AR.Name = "comboBox_AR";
            this.comboBox_AR.Size = new System.Drawing.Size(125, 21);
            this.comboBox_AR.TabIndex = 4;
            // 
            // comboBox_AL
            // 
            this.comboBox_AL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_AL.FormattingEnabled = true;
            this.comboBox_AL.Location = new System.Drawing.Point(104, 26);
            this.comboBox_AL.Name = "comboBox_AL";
            this.comboBox_AL.Size = new System.Drawing.Size(125, 21);
            this.comboBox_AL.TabIndex = 2;
            // 
            // checkBox_EnableJoystick
            // 
            this.checkBox_EnableJoystick.AutoSize = true;
            this.checkBox_EnableJoystick.Location = new System.Drawing.Point(459, 455);
            this.checkBox_EnableJoystick.Name = "checkBox_EnableJoystick";
            this.checkBox_EnableJoystick.Size = new System.Drawing.Size(117, 17);
            this.checkBox_EnableJoystick.TabIndex = 1;
            this.checkBox_EnableJoystick.Tag = "";
            this.checkBox_EnableJoystick.Text = "Enable vJoy output";
            this.toolTip1.SetToolTip(this.checkBox_EnableJoystick, "Sends the data to vJoy driver");
            this.checkBox_EnableJoystick.UseVisualStyleBackColor = true;
            this.checkBox_EnableJoystick.CheckedChanged += new System.EventHandler(this.checkBox_EnableJoystick_CheckedChanged);
            // 
            // consoleBox
            // 
            this.consoleBox.Location = new System.Drawing.Point(12, 323);
            this.consoleBox.Multiline = true;
            this.consoleBox.Name = "consoleBox";
            this.consoleBox.ReadOnly = true;
            this.consoleBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.consoleBox.Size = new System.Drawing.Size(435, 198);
            this.consoleBox.TabIndex = 7;
            this.consoleBox.Text = "vJoy Console";
            // 
            // checkBox_Send4LoadSensors
            // 
            this.checkBox_Send4LoadSensors.AutoSize = true;
            this.checkBox_Send4LoadSensors.Checked = true;
            this.checkBox_Send4LoadSensors.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Send4LoadSensors.Location = new System.Drawing.Point(6, 42);
            this.checkBox_Send4LoadSensors.Name = "checkBox_Send4LoadSensors";
            this.checkBox_Send4LoadSensors.Size = new System.Drawing.Size(156, 17);
            this.checkBox_Send4LoadSensors.TabIndex = 9;
            this.checkBox_Send4LoadSensors.Text = "Send 4 load sensors values";
            this.toolTip1.SetToolTip(this.checkBox_Send4LoadSensors, resources.GetString("checkBox_Send4LoadSensors.ToolTip"));
            this.checkBox_Send4LoadSensors.UseVisualStyleBackColor = true;
            this.checkBox_Send4LoadSensors.CheckedChanged += new System.EventHandler(this.checkBox_Send4LoadSensors_CheckedChanged);
            // 
            // groupBox_vJoy_output
            // 
            this.groupBox_vJoy_output.Controls.Add(this.checkBox_ShowValuesInConsole);
            this.groupBox_vJoy_output.Controls.Add(this.label1);
            this.groupBox_vJoy_output.Controls.Add(this.VJoyIDUpDown);
            this.groupBox_vJoy_output.Controls.Add(this.checkBox_Send4LoadSensors);
            this.groupBox_vJoy_output.Controls.Add(this.checkBox_SendCGtoXY);
            this.groupBox_vJoy_output.Location = new System.Drawing.Point(453, 326);
            this.groupBox_vJoy_output.Name = "groupBox_vJoy_output";
            this.groupBox_vJoy_output.Size = new System.Drawing.Size(177, 123);
            this.groupBox_vJoy_output.TabIndex = 10;
            this.groupBox_vJoy_output.TabStop = false;
            this.groupBox_vJoy_output.Text = "vJoy output";
            // 
            // checkBox_ShowValuesInConsole
            // 
            this.checkBox_ShowValuesInConsole.AutoSize = true;
            this.checkBox_ShowValuesInConsole.Location = new System.Drawing.Point(6, 65);
            this.checkBox_ShowValuesInConsole.Name = "checkBox_ShowValuesInConsole";
            this.checkBox_ShowValuesInConsole.Size = new System.Drawing.Size(138, 17);
            this.checkBox_ShowValuesInConsole.TabIndex = 13;
            this.checkBox_ShowValuesInConsole.Text = "Show values in console";
            this.toolTip1.SetToolTip(this.checkBox_ShowValuesInConsole, "print the measured values to the vJoy Console");
            this.checkBox_ShowValuesInConsole.UseVisualStyleBackColor = true;
            this.checkBox_ShowValuesInConsole.CheckedChanged += new System.EventHandler(this.ShowValues_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "VJoy Device ID:";
            this.toolTip1.SetToolTip(this.label1, "Leave this on 1, unless you\'re using multiple virtual joysticks, and would like t" +
        "o change the enumeration for the wii balance board device.");
            // 
            // VJoyIDUpDown
            // 
            this.VJoyIDUpDown.Location = new System.Drawing.Point(88, 94);
            this.VJoyIDUpDown.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.VJoyIDUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.VJoyIDUpDown.Name = "VJoyIDUpDown";
            this.VJoyIDUpDown.Size = new System.Drawing.Size(35, 20);
            this.VJoyIDUpDown.TabIndex = 11;
            this.toolTip1.SetToolTip(this.VJoyIDUpDown, "Noramlly leave this on 1. Unless you have several virtual joystick devices config" +
        "ured.");
            this.VJoyIDUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // checkBox_StartupAutoConnect
            // 
            this.checkBox_StartupAutoConnect.AutoSize = true;
            this.checkBox_StartupAutoConnect.Location = new System.Drawing.Point(6, 19);
            this.checkBox_StartupAutoConnect.Name = "checkBox_StartupAutoConnect";
            this.checkBox_StartupAutoConnect.Size = new System.Drawing.Size(201, 17);
            this.checkBox_StartupAutoConnect.TabIndex = 0;
            this.checkBox_StartupAutoConnect.Text = "Connect to Balance Board on startup";
            this.toolTip1.SetToolTip(this.checkBox_StartupAutoConnect, "To save you from clicking \'Connect to Wii Balance Board\' each time you launch Wii" +
        " Balance Walker");
            this.checkBox_StartupAutoConnect.UseVisualStyleBackColor = true;
            this.checkBox_StartupAutoConnect.CheckedChanged += new System.EventHandler(this.checkBox_StartupAutoConnect_CheckedChanged);
            // 
            // startupOptions
            // 
            this.startupOptions.Controls.Add(this.checkBox_StartMinimized);
            this.startupOptions.Controls.Add(this.checkBox_AutoTare);
            this.startupOptions.Controls.Add(this.checkBox_StartupAutoConnect);
            this.startupOptions.Location = new System.Drawing.Point(392, 157);
            this.startupOptions.Name = "startupOptions";
            this.startupOptions.Size = new System.Drawing.Size(238, 136);
            this.startupOptions.TabIndex = 12;
            this.startupOptions.TabStop = false;
            this.startupOptions.Text = "Startup Options";
            // 
            // checkBox_StartMinimized
            // 
            this.checkBox_StartMinimized.AutoSize = true;
            this.checkBox_StartMinimized.Location = new System.Drawing.Point(6, 65);
            this.checkBox_StartMinimized.Name = "checkBox_StartMinimized";
            this.checkBox_StartMinimized.Size = new System.Drawing.Size(139, 17);
            this.checkBox_StartMinimized.TabIndex = 2;
            this.checkBox_StartMinimized.Text = "Start Program Minimized";
            this.checkBox_StartMinimized.UseVisualStyleBackColor = true;
            this.checkBox_StartMinimized.CheckedChanged += new System.EventHandler(this.checkBox_StartMinimized_CheckedChanged);
            // 
            // checkBox_AutoTare
            // 
            this.checkBox_AutoTare.AutoSize = true;
            this.checkBox_AutoTare.Location = new System.Drawing.Point(6, 42);
            this.checkBox_AutoTare.Name = "checkBox_AutoTare";
            this.checkBox_AutoTare.Size = new System.Drawing.Size(201, 17);
            this.checkBox_AutoTare.TabIndex = 1;
            this.checkBox_AutoTare.Text = "Tare Balance Board after connection";
            this.checkBox_AutoTare.UseVisualStyleBackColor = true;
            this.checkBox_AutoTare.CheckedChanged += new System.EventHandler(this.checkBox_AutoTare_CheckedChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 533);
            this.Controls.Add(this.startupOptions);
            this.Controls.Add(this.groupBox_vJoy_output);
            this.Controls.Add(this.checkBox_EnableJoystick);
            this.Controls.Add(this.consoleBox);
            this.Controls.Add(this.groupBox_Actions);
            this.Controls.Add(this.label_Status);
            this.Controls.Add(this.groupBox_BalanceRatio);
            this.Controls.Add(this.groupBox_General);
            this.Controls.Add(this.groupBox_OffsetWeightRatio);
            this.Controls.Add(this.groupBox_OffsetWeight);
            this.Controls.Add(this.groupBox_RawWeight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wii Balance Walker - Version 0.5";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox_RawWeight.ResumeLayout(false);
            this.groupBox_RawWeight.PerformLayout();
            this.groupBox_OffsetWeight.ResumeLayout(false);
            this.groupBox_OffsetWeight.PerformLayout();
            this.groupBox_OffsetWeightRatio.ResumeLayout(false);
            this.groupBox_OffsetWeightRatio.PerformLayout();
            this.groupBox_General.ResumeLayout(false);
            this.groupBox_BalanceRatio.ResumeLayout(false);
            this.groupBox_BalanceRatio.PerformLayout();
            this.groupBox_BalanceRatioTriggers.ResumeLayout(false);
            this.groupBox_BalanceRatioTriggers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TMFB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TMLR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TFB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TLR)).EndInit();
            this.groupBox_Actions.ResumeLayout(false);
            this.groupBox_Actions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ADR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ADL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_AJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_AM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_AB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_AF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_AR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_AL)).EndInit();
            this.groupBox_vJoy_output.ResumeLayout(false);
            this.groupBox_vJoy_output.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VJoyIDUpDown)).EndInit();
            this.startupOptions.ResumeLayout(false);
            this.startupOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_rwWT;
        private System.Windows.Forms.Button button_Connect;
        private System.Windows.Forms.Label label_brX;
        private System.Windows.Forms.Label label_brY;
        private System.Windows.Forms.Label label_brDL;
        private System.Windows.Forms.Label label_brDR;
        private System.Windows.Forms.GroupBox groupBox_RawWeight;
        private System.Windows.Forms.Label label_rwBR;
        private System.Windows.Forms.Label label_rwBL;
        private System.Windows.Forms.Label label_rwTR;
        private System.Windows.Forms.Label label_rwTL;
        private System.Windows.Forms.GroupBox groupBox_OffsetWeight;
        private System.Windows.Forms.GroupBox groupBox_OffsetWeightRatio;
        private System.Windows.Forms.Label label_owTL;
        private System.Windows.Forms.Label label_owTR;
        private System.Windows.Forms.Label label_owBL;
        private System.Windows.Forms.Label label_owBR;
        private System.Windows.Forms.Label label_owrTL;
        private System.Windows.Forms.Label label_owrTR;
        private System.Windows.Forms.Label label_owrBL;
        private System.Windows.Forms.Label label_owrBR;
        private System.Windows.Forms.GroupBox groupBox_General;
        private System.Windows.Forms.GroupBox groupBox_BalanceRatio;
        private System.Windows.Forms.Label label_brDF;
        private System.Windows.Forms.GroupBox groupBox_BalanceRatioTriggers;
        private System.Windows.Forms.NumericUpDown numericUpDown_TMFB;
        private System.Windows.Forms.NumericUpDown numericUpDown_TMLR;
        private System.Windows.Forms.NumericUpDown numericUpDown_TFB;
        private System.Windows.Forms.NumericUpDown numericUpDown_TLR;
        private System.Windows.Forms.Label label_TMFB;
        private System.Windows.Forms.Label label_TMLR;
        private System.Windows.Forms.Label label_TFB;
        private System.Windows.Forms.Label label_TLR;
        private System.Windows.Forms.Label label_Status;
        private System.Windows.Forms.Button button_BluetoothAddDevice;
        private System.Windows.Forms.GroupBox groupBox_Actions;
        private System.Windows.Forms.ComboBox comboBox_AM;
        private System.Windows.Forms.ComboBox comboBox_AF;
        private System.Windows.Forms.ComboBox comboBox_AB;
        private System.Windows.Forms.ComboBox comboBox_AR;
        private System.Windows.Forms.ComboBox comboBox_AL;
        private System.Windows.Forms.Label label_ActionJump;
        private System.Windows.Forms.Label label_ActionDiagonalRight;
        private System.Windows.Forms.Label label_ActionDiagonalLeft;
        private System.Windows.Forms.Label label_ActionModifier;
        private System.Windows.Forms.Label label_ActionBackward;
        private System.Windows.Forms.Label label_ActionForward;
        private System.Windows.Forms.Label label_ActionRight;
        private System.Windows.Forms.Label label_ActionLeft;
        private System.Windows.Forms.NumericUpDown numericUpDown_AR;
        private System.Windows.Forms.NumericUpDown numericUpDown_AL;
        private System.Windows.Forms.NumericUpDown numericUpDown_ADR;
        private System.Windows.Forms.NumericUpDown numericUpDown_ADL;
        private System.Windows.Forms.NumericUpDown numericUpDown_AJ;
        private System.Windows.Forms.NumericUpDown numericUpDown_AM;
        private System.Windows.Forms.NumericUpDown numericUpDown_AB;
        private System.Windows.Forms.NumericUpDown numericUpDown_AF;
        private System.Windows.Forms.ComboBox comboBox_ADR;
        private System.Windows.Forms.ComboBox comboBox_AJ;
        private System.Windows.Forms.ComboBox comboBox_ADL;
        private System.Windows.Forms.Button button_SetCenterOffset;
        private System.Windows.Forms.Button button_ResetDefaults;
        private System.Windows.Forms.CheckBox checkBox_DisableActions;
        private System.Windows.Forms.Label label_owWT;
        private System.Windows.Forms.CheckBox checkBox_EnableJoystick;
        private System.Windows.Forms.CheckBox checkBox_SendCGtoXY;
        private System.Windows.Forms.Button zeroout;
        private System.Windows.Forms.TextBox consoleBox;
        private System.Windows.Forms.CheckBox checkBox_Send4LoadSensors;
        private System.Windows.Forms.GroupBox groupBox_vJoy_output;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.NumericUpDown VJoyIDUpDown;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_ShowValuesInConsole;
        private System.Windows.Forms.GroupBox startupOptions;
        private System.Windows.Forms.CheckBox checkBox_StartupAutoConnect;
        private System.Windows.Forms.CheckBox checkBox_AutoTare;
        private System.Windows.Forms.CheckBox checkBox_StartMinimized;
    }
}

