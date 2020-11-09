namespace WiiBalanceWalker
{
    partial class FormBluetooth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBluetooth));
            this.label_Status = new System.Windows.Forms.Label();
            this.groupBox_Info2 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.clipboardCopy = new System.Windows.Forms.ToolStripButton();
            this.btPinTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Info2 = new System.Windows.Forms.Label();
            this.checkBox_PermanentSync = new System.Windows.Forms.CheckBox();
            this.groupBox_Info3 = new System.Windows.Forms.GroupBox();
            this.checkBox_RemoveExisting = new System.Windows.Forms.CheckBox();
            this.RemoveExisting = new System.Windows.Forms.Button();
            this.label_Info1 = new System.Windows.Forms.Label();
            this.label_Info3 = new System.Windows.Forms.Label();
            this.checkBox_SkipNameCheck = new System.Windows.Forms.CheckBox();
            this.groupBox_Info4 = new System.Windows.Forms.GroupBox();
            this.button_DeviceSearch = new System.Windows.Forms.Button();
            this.label_Info4 = new System.Windows.Forms.Label();
            this.groupBox_Info1 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox_Info2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox_Info3.SuspendLayout();
            this.groupBox_Info4.SuspendLayout();
            this.groupBox_Info1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Status
            // 
            this.label_Status.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_Status.Location = new System.Drawing.Point(12, 9);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(783, 23);
            this.label_Status.TabIndex = 0;
            this.label_Status.Text = "Read the information below...";
            this.label_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox_Info2
            // 
            this.groupBox_Info2.Controls.Add(this.toolStrip1);
            this.groupBox_Info2.Controls.Add(this.btPinTextbox);
            this.groupBox_Info2.Controls.Add(this.label1);
            this.groupBox_Info2.Controls.Add(this.label_Info2);
            this.groupBox_Info2.Controls.Add(this.checkBox_PermanentSync);
            this.groupBox_Info2.Location = new System.Drawing.Point(12, 156);
            this.groupBox_Info2.Name = "groupBox_Info2";
            this.groupBox_Info2.Size = new System.Drawing.Size(780, 116);
            this.groupBox_Info2.TabIndex = 2;
            this.groupBox_Info2.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.CanOverflow = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clipboardCopy});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(119, 47);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(26, 25);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.TabStop = true;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // clipboardCopy
            // 
            this.clipboardCopy.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.clipboardCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clipboardCopy.Image = ((System.Drawing.Image)(resources.GetObject("clipboardCopy.Image")));
            this.clipboardCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.clipboardCopy.Name = "clipboardCopy";
            this.clipboardCopy.Size = new System.Drawing.Size(23, 22);
            this.clipboardCopy.Text = "clipboardCopy";
            this.clipboardCopy.ToolTipText = "Copy pin code to clipboard";
            this.clipboardCopy.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btPinTextbox
            // 
            this.btPinTextbox.Location = new System.Drawing.Point(16, 49);
            this.btPinTextbox.Name = "btPinTextbox";
            this.btPinTextbox.ReadOnly = true;
            this.btPinTextbox.Size = new System.Drawing.Size(100, 20);
            this.btPinTextbox.TabIndex = 7;
            this.btPinTextbox.Text = "pin should appear here";
            this.btPinTextbox.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Permanent PIN code:";
            // 
            // label_Info2
            // 
            this.label_Info2.Location = new System.Drawing.Point(194, 16);
            this.label_Info2.Name = "label_Info2";
            this.label_Info2.Size = new System.Drawing.Size(566, 91);
            this.label_Info2.TabIndex = 6;
            this.label_Info2.Text = resources.GetString("label_Info2.Text");
            // 
            // checkBox_PermanentSync
            // 
            this.checkBox_PermanentSync.AutoSize = true;
            this.checkBox_PermanentSync.Checked = true;
            this.checkBox_PermanentSync.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_PermanentSync.Location = new System.Drawing.Point(6, 90);
            this.checkBox_PermanentSync.Name = "checkBox_PermanentSync";
            this.checkBox_PermanentSync.Size = new System.Drawing.Size(179, 17);
            this.checkBox_PermanentSync.TabIndex = 0;
            this.checkBox_PermanentSync.TabStop = false;
            this.checkBox_PermanentSync.Text = "Show permanent sync PIN code";
            this.checkBox_PermanentSync.UseVisualStyleBackColor = true;
            this.checkBox_PermanentSync.Visible = false;
            // 
            // groupBox_Info3
            // 
            this.groupBox_Info3.Controls.Add(this.checkBox_RemoveExisting);
            this.groupBox_Info3.Controls.Add(this.RemoveExisting);
            this.groupBox_Info3.Controls.Add(this.label_Info1);
            this.groupBox_Info3.Location = new System.Drawing.Point(12, 269);
            this.groupBox_Info3.Name = "groupBox_Info3";
            this.groupBox_Info3.Size = new System.Drawing.Size(780, 113);
            this.groupBox_Info3.TabIndex = 3;
            this.groupBox_Info3.TabStop = false;
            // 
            // checkBox_RemoveExisting
            // 
            this.checkBox_RemoveExisting.AutoSize = true;
            this.checkBox_RemoveExisting.Location = new System.Drawing.Point(559, 19);
            this.checkBox_RemoveExisting.Name = "checkBox_RemoveExisting";
            this.checkBox_RemoveExisting.Size = new System.Drawing.Size(138, 17);
            this.checkBox_RemoveExisting.TabIndex = 0;
            this.checkBox_RemoveExisting.Text = "Remove existing entries";
            this.checkBox_RemoveExisting.UseVisualStyleBackColor = true;
            this.checkBox_RemoveExisting.Visible = false;
            // 
            // RemoveExisting
            // 
            this.RemoveExisting.Location = new System.Drawing.Point(25, 19);
            this.RemoveExisting.Name = "RemoveExisting";
            this.RemoveExisting.Size = new System.Drawing.Size(106, 43);
            this.RemoveExisting.TabIndex = 7;
            this.RemoveExisting.Text = "Remove existing";
            this.RemoveExisting.UseVisualStyleBackColor = true;
            this.RemoveExisting.Click += new System.EventHandler(this.RemoveExisting_Click);
            // 
            // label_Info1
            // 
            this.label_Info1.Location = new System.Drawing.Point(191, 16);
            this.label_Info1.Name = "label_Info1";
            this.label_Info1.Size = new System.Drawing.Size(569, 94);
            this.label_Info1.TabIndex = 6;
            this.label_Info1.Text = resources.GetString("label_Info1.Text");
            // 
            // label_Info3
            // 
            this.label_Info3.Location = new System.Drawing.Point(197, 524);
            this.label_Info3.Name = "label_Info3";
            this.label_Info3.Size = new System.Drawing.Size(569, 50);
            this.label_Info3.TabIndex = 6;
            this.label_Info3.Text = "- This skips the check for \'Nintendo\' and will try to pair anything waiting.\r\n\r\n-" +
    " If you get an ignored device, try searching again a few more times, if still ig" +
    "nored use this option.\r\n\r\n";
            this.label_Info3.Visible = false;
            // 
            // checkBox_SkipNameCheck
            // 
            this.checkBox_SkipNameCheck.AutoSize = true;
            this.checkBox_SkipNameCheck.Location = new System.Drawing.Point(33, 521);
            this.checkBox_SkipNameCheck.Name = "checkBox_SkipNameCheck";
            this.checkBox_SkipNameCheck.Size = new System.Drawing.Size(144, 17);
            this.checkBox_SkipNameCheck.TabIndex = 0;
            this.checkBox_SkipNameCheck.TabStop = false;
            this.checkBox_SkipNameCheck.Text = "Skip device name check";
            this.checkBox_SkipNameCheck.UseVisualStyleBackColor = true;
            this.checkBox_SkipNameCheck.Visible = false;
            // 
            // groupBox_Info4
            // 
            this.groupBox_Info4.Controls.Add(this.button_DeviceSearch);
            this.groupBox_Info4.Location = new System.Drawing.Point(17, 401);
            this.groupBox_Info4.Name = "groupBox_Info4";
            this.groupBox_Info4.Size = new System.Drawing.Size(780, 97);
            this.groupBox_Info4.TabIndex = 4;
            this.groupBox_Info4.TabStop = false;
            // 
            // button_DeviceSearch
            // 
            this.button_DeviceSearch.Location = new System.Drawing.Point(10, 19);
            this.button_DeviceSearch.Name = "button_DeviceSearch";
            this.button_DeviceSearch.Size = new System.Drawing.Size(163, 58);
            this.button_DeviceSearch.TabIndex = 0;
            this.button_DeviceSearch.TabStop = false;
            this.button_DeviceSearch.Text = "Search and add Wii devices";
            this.button_DeviceSearch.UseVisualStyleBackColor = true;
            this.button_DeviceSearch.Click += new System.EventHandler(this.button_DeviceSearch_Click);
            // 
            // label_Info4
            // 
            this.label_Info4.Location = new System.Drawing.Point(199, 16);
            this.label_Info4.Name = "label_Info4";
            this.label_Info4.Size = new System.Drawing.Size(566, 102);
            this.label_Info4.TabIndex = 6;
            this.label_Info4.Text = resources.GetString("label_Info4.Text");
            // 
            // groupBox_Info1
            // 
            this.groupBox_Info1.Controls.Add(this.label_Info4);
            this.groupBox_Info1.Location = new System.Drawing.Point(12, 35);
            this.groupBox_Info1.Name = "groupBox_Info1";
            this.groupBox_Info1.Size = new System.Drawing.Size(783, 123);
            this.groupBox_Info1.TabIndex = 1;
            this.groupBox_Info1.TabStop = false;
            // 
            // FormBluetooth
            // 
            this.AcceptButton = this.button_DeviceSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 385);
            this.Controls.Add(this.label_Info3);
            this.Controls.Add(this.groupBox_Info1);
            this.Controls.Add(this.checkBox_SkipNameCheck);
            this.Controls.Add(this.groupBox_Info4);
            this.Controls.Add(this.groupBox_Info3);
            this.Controls.Add(this.groupBox_Info2);
            this.Controls.Add(this.label_Status);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBluetooth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add/Remove Bluetooth Wii Device";
            this.groupBox_Info2.ResumeLayout(false);
            this.groupBox_Info2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox_Info3.ResumeLayout(false);
            this.groupBox_Info3.PerformLayout();
            this.groupBox_Info4.ResumeLayout(false);
            this.groupBox_Info1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Status;
        private System.Windows.Forms.GroupBox groupBox_Info2;
        private System.Windows.Forms.Label label_Info2;
        private System.Windows.Forms.CheckBox checkBox_PermanentSync;
        private System.Windows.Forms.GroupBox groupBox_Info3;
        private System.Windows.Forms.Label label_Info3;
        private System.Windows.Forms.CheckBox checkBox_SkipNameCheck;
        private System.Windows.Forms.GroupBox groupBox_Info4;
        private System.Windows.Forms.Button button_DeviceSearch;
        private System.Windows.Forms.Label label_Info4;
        private System.Windows.Forms.GroupBox groupBox_Info1;
        private System.Windows.Forms.Label label_Info1;
        private System.Windows.Forms.CheckBox checkBox_RemoveExisting;
        private System.Windows.Forms.TextBox btPinTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton clipboardCopy;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button RemoveExisting;
    }
}