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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBluetooth));
            this.label_Status = new System.Windows.Forms.Label();
            this.groupBox_Info2 = new System.Windows.Forms.GroupBox();
            this.label_Info2 = new System.Windows.Forms.Label();
            this.checkBox_PermanentSync = new System.Windows.Forms.CheckBox();
            this.groupBox_Info3 = new System.Windows.Forms.GroupBox();
            this.label_Info3 = new System.Windows.Forms.Label();
            this.checkBox_SkipNameCheck = new System.Windows.Forms.CheckBox();
            this.groupBox_Info4 = new System.Windows.Forms.GroupBox();
            this.button_DeviceSearch = new System.Windows.Forms.Button();
            this.label_Info4 = new System.Windows.Forms.Label();
            this.groupBox_Info1 = new System.Windows.Forms.GroupBox();
            this.label_Info1 = new System.Windows.Forms.Label();
            this.checkBox_RemoveExisting = new System.Windows.Forms.CheckBox();
            this.groupBox_Info2.SuspendLayout();
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
            this.groupBox_Info2.Controls.Add(this.label_Info2);
            this.groupBox_Info2.Controls.Add(this.checkBox_PermanentSync);
            this.groupBox_Info2.Location = new System.Drawing.Point(15, 112);
            this.groupBox_Info2.Name = "groupBox_Info2";
            this.groupBox_Info2.Size = new System.Drawing.Size(780, 98);
            this.groupBox_Info2.TabIndex = 2;
            this.groupBox_Info2.TabStop = false;
            // 
            // label_Info2
            // 
            this.label_Info2.Location = new System.Drawing.Point(191, 16);
            this.label_Info2.Name = "label_Info2";
            this.label_Info2.Size = new System.Drawing.Size(569, 75);
            this.label_Info2.TabIndex = 6;
            this.label_Info2.Text = resources.GetString("label_Info2.Text");
            // 
            // checkBox_PermanentSync
            // 
            this.checkBox_PermanentSync.AutoSize = true;
            this.checkBox_PermanentSync.Location = new System.Drawing.Point(13, 19);
            this.checkBox_PermanentSync.Name = "checkBox_PermanentSync";
            this.checkBox_PermanentSync.Size = new System.Drawing.Size(102, 17);
            this.checkBox_PermanentSync.TabIndex = 0;
            this.checkBox_PermanentSync.Text = "Permanent sync";
            this.checkBox_PermanentSync.UseVisualStyleBackColor = true;
            // 
            // groupBox_Info3
            // 
            this.groupBox_Info3.Controls.Add(this.label_Info3);
            this.groupBox_Info3.Controls.Add(this.checkBox_SkipNameCheck);
            this.groupBox_Info3.Location = new System.Drawing.Point(15, 216);
            this.groupBox_Info3.Name = "groupBox_Info3";
            this.groupBox_Info3.Size = new System.Drawing.Size(780, 71);
            this.groupBox_Info3.TabIndex = 3;
            this.groupBox_Info3.TabStop = false;
            // 
            // label_Info3
            // 
            this.label_Info3.Location = new System.Drawing.Point(191, 16);
            this.label_Info3.Name = "label_Info3";
            this.label_Info3.Size = new System.Drawing.Size(569, 50);
            this.label_Info3.TabIndex = 6;
            this.label_Info3.Text = "- This skips the check for \'Nintendo\' and will try to pair anything waiting.\r\n\r\n-" +
    " If you get an ignored device, try searching again a few more times, if still ig" +
    "nored use this option.\r\n\r\n";
            // 
            // checkBox_SkipNameCheck
            // 
            this.checkBox_SkipNameCheck.AutoSize = true;
            this.checkBox_SkipNameCheck.Location = new System.Drawing.Point(10, 19);
            this.checkBox_SkipNameCheck.Name = "checkBox_SkipNameCheck";
            this.checkBox_SkipNameCheck.Size = new System.Drawing.Size(144, 17);
            this.checkBox_SkipNameCheck.TabIndex = 0;
            this.checkBox_SkipNameCheck.Text = "Skip device name check";
            this.checkBox_SkipNameCheck.UseVisualStyleBackColor = true;
            // 
            // groupBox_Info4
            // 
            this.groupBox_Info4.Controls.Add(this.button_DeviceSearch);
            this.groupBox_Info4.Controls.Add(this.label_Info4);
            this.groupBox_Info4.Location = new System.Drawing.Point(15, 293);
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
            this.button_DeviceSearch.Text = "Search and add Wii devices";
            this.button_DeviceSearch.UseVisualStyleBackColor = true;
            this.button_DeviceSearch.Click += new System.EventHandler(this.button_DeviceSearch_Click);
            // 
            // label_Info4
            // 
            this.label_Info4.Location = new System.Drawing.Point(191, 16);
            this.label_Info4.Name = "label_Info4";
            this.label_Info4.Size = new System.Drawing.Size(569, 73);
            this.label_Info4.TabIndex = 6;
            this.label_Info4.Text = "- Press red sync button in the battery compartment of device.\r\n\r\n- The device lig" +
    "ht should be flashing, now click the \'Search\' button.\r\n\r\n- DO NOT click any blue" +
    "tooth popups until this finishes.";
            // 
            // groupBox_Info1
            // 
            this.groupBox_Info1.Controls.Add(this.label_Info1);
            this.groupBox_Info1.Controls.Add(this.checkBox_RemoveExisting);
            this.groupBox_Info1.Location = new System.Drawing.Point(12, 35);
            this.groupBox_Info1.Name = "groupBox_Info1";
            this.groupBox_Info1.Size = new System.Drawing.Size(783, 71);
            this.groupBox_Info1.TabIndex = 1;
            this.groupBox_Info1.TabStop = false;
            // 
            // label_Info1
            // 
            this.label_Info1.Location = new System.Drawing.Point(194, 16);
            this.label_Info1.Name = "label_Info1";
            this.label_Info1.Size = new System.Drawing.Size(569, 49);
            this.label_Info1.TabIndex = 6;
            this.label_Info1.Text = "- Removes all bluetooth devices with \'Nintendo\' in the name.\r\n\r\n- Search will not" +
    " find devices already added, so permanent sync or fixing broken entries requires" +
    " their removal first.";
            // 
            // checkBox_RemoveExisting
            // 
            this.checkBox_RemoveExisting.AutoSize = true;
            this.checkBox_RemoveExisting.Checked = true;
            this.checkBox_RemoveExisting.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_RemoveExisting.Location = new System.Drawing.Point(13, 19);
            this.checkBox_RemoveExisting.Name = "checkBox_RemoveExisting";
            this.checkBox_RemoveExisting.Size = new System.Drawing.Size(138, 17);
            this.checkBox_RemoveExisting.TabIndex = 0;
            this.checkBox_RemoveExisting.Text = "Remove existing entries";
            this.checkBox_RemoveExisting.UseVisualStyleBackColor = true;
            // 
            // FormBluetooth
            // 
            this.AcceptButton = this.button_DeviceSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 402);
            this.Controls.Add(this.groupBox_Info1);
            this.Controls.Add(this.groupBox_Info4);
            this.Controls.Add(this.groupBox_Info3);
            this.Controls.Add(this.groupBox_Info2);
            this.Controls.Add(this.label_Status);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBluetooth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bluetooth Add Wii Device";
            this.groupBox_Info2.ResumeLayout(false);
            this.groupBox_Info2.PerformLayout();
            this.groupBox_Info3.ResumeLayout(false);
            this.groupBox_Info3.PerformLayout();
            this.groupBox_Info4.ResumeLayout(false);
            this.groupBox_Info1.ResumeLayout(false);
            this.groupBox_Info1.PerformLayout();
            this.ResumeLayout(false);

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
    }
}