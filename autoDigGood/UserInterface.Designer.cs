namespace autoDigGood
{
    partial class UserInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInterface));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.utilitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setDefaultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.uxCPUnumber = new System.Windows.Forms.NumericUpDown();
            this.uxInactiveNumber = new System.Windows.Forms.NumericUpDown();
            this.uxActiveNumber = new System.Windows.Forms.NumericUpDown();
            this.uxTextBatchFileName = new System.Windows.Forms.TextBox();
            this.uxButtonMstart = new System.Windows.Forms.Button();
            this.uxButtonMkill = new System.Windows.Forms.Button();
            this.uxTextStatus = new System.Windows.Forms.TextBox();
            this.uxMouseCap = new System.Windows.Forms.CheckBox();
            this.uxMouseY = new System.Windows.Forms.Label();
            this.uxMouseXlabel = new System.Windows.Forms.Label();
            this.uxMouseX = new System.Windows.Forms.Label();
            this.uxMouseYlabel = new System.Windows.Forms.Label();
            this.uxCheckAuto = new System.Windows.Forms.CheckBox();
            this.uxClearLog = new System.Windows.Forms.Button();
            this.uxCPUlabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxCPUnumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxInactiveNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxActiveNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.utilitiesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(318, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // utilitiesToolStripMenuItem
            // 
            this.utilitiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkForUpdateToolStripMenuItem,
            this.setDefaultsToolStripMenuItem});
            this.utilitiesToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.utilitiesToolStripMenuItem.Name = "utilitiesToolStripMenuItem";
            this.utilitiesToolStripMenuItem.Size = new System.Drawing.Size(69, 21);
            this.utilitiesToolStripMenuItem.Text = "Utilities";
            // 
            // checkForUpdateToolStripMenuItem
            // 
            this.checkForUpdateToolStripMenuItem.Name = "checkForUpdateToolStripMenuItem";
            this.checkForUpdateToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.checkForUpdateToolStripMenuItem.Text = "Check for update";
            this.checkForUpdateToolStripMenuItem.Click += new System.EventHandler(this.checkForUpdateToolStripMenuItem_Click);
            // 
            // setDefaultsToolStripMenuItem
            // 
            this.setDefaultsToolStripMenuItem.Name = "setDefaultsToolStripMenuItem";
            this.setDefaultsToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.setDefaultsToolStripMenuItem.Text = "Set defaults";
            this.setDefaultsToolStripMenuItem.Click += new System.EventHandler(this.setDefaultsToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "CPU threshold%:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Inactive time (minutes):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Active time (seconds):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Batch file name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(124, 389);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 18);
            this.label9.TabIndex = 9;
            this.label9.Text = "Current CPU usage:";
            // 
            // uxCPUnumber
            // 
            this.uxCPUnumber.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCPUnumber.Location = new System.Drawing.Point(179, 23);
            this.uxCPUnumber.Name = "uxCPUnumber";
            this.uxCPUnumber.Size = new System.Drawing.Size(70, 26);
            this.uxCPUnumber.TabIndex = 10;
            this.uxCPUnumber.ValueChanged += new System.EventHandler(this.uxCPUnumber_ValueChanged);
            // 
            // uxInactiveNumber
            // 
            this.uxInactiveNumber.DecimalPlaces = 1;
            this.uxInactiveNumber.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxInactiveNumber.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.uxInactiveNumber.Location = new System.Drawing.Point(179, 55);
            this.uxInactiveNumber.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.uxInactiveNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.uxInactiveNumber.Name = "uxInactiveNumber";
            this.uxInactiveNumber.Size = new System.Drawing.Size(70, 26);
            this.uxInactiveNumber.TabIndex = 11;
            this.uxInactiveNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.uxInactiveNumber.ValueChanged += new System.EventHandler(this.uxInactiveNumber_ValueChanged);
            // 
            // uxActiveNumber
            // 
            this.uxActiveNumber.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxActiveNumber.Location = new System.Drawing.Point(179, 87);
            this.uxActiveNumber.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.uxActiveNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.uxActiveNumber.Name = "uxActiveNumber";
            this.uxActiveNumber.Size = new System.Drawing.Size(70, 26);
            this.uxActiveNumber.TabIndex = 12;
            this.uxActiveNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.uxActiveNumber.ValueChanged += new System.EventHandler(this.uxActiveNumber_ValueChanged);
            // 
            // uxTextBatchFileName
            // 
            this.uxTextBatchFileName.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTextBatchFileName.Location = new System.Drawing.Point(179, 119);
            this.uxTextBatchFileName.Name = "uxTextBatchFileName";
            this.uxTextBatchFileName.Size = new System.Drawing.Size(93, 26);
            this.uxTextBatchFileName.TabIndex = 22;
            // 
            // uxButtonMstart
            // 
            this.uxButtonMstart.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxButtonMstart.Location = new System.Drawing.Point(12, 152);
            this.uxButtonMstart.Name = "uxButtonMstart";
            this.uxButtonMstart.Size = new System.Drawing.Size(142, 47);
            this.uxButtonMstart.TabIndex = 23;
            this.uxButtonMstart.Text = "Manual Start";
            this.uxButtonMstart.UseVisualStyleBackColor = true;
            this.uxButtonMstart.Click += new System.EventHandler(this.uxButtonMstart_Click);
            // 
            // uxButtonMkill
            // 
            this.uxButtonMkill.Enabled = false;
            this.uxButtonMkill.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxButtonMkill.Location = new System.Drawing.Point(12, 205);
            this.uxButtonMkill.Name = "uxButtonMkill";
            this.uxButtonMkill.Size = new System.Drawing.Size(142, 47);
            this.uxButtonMkill.TabIndex = 24;
            this.uxButtonMkill.Text = "Manual Stop";
            this.uxButtonMkill.UseVisualStyleBackColor = true;
            this.uxButtonMkill.Click += new System.EventHandler(this.uxButtonMkill_Click);
            // 
            // uxTextStatus
            // 
            this.uxTextStatus.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTextStatus.Location = new System.Drawing.Point(12, 258);
            this.uxTextStatus.Multiline = true;
            this.uxTextStatus.Name = "uxTextStatus";
            this.uxTextStatus.ReadOnly = true;
            this.uxTextStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.uxTextStatus.Size = new System.Drawing.Size(292, 123);
            this.uxTextStatus.TabIndex = 25;
            // 
            // uxMouseCap
            // 
            this.uxMouseCap.AutoSize = true;
            this.uxMouseCap.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxMouseCap.Location = new System.Drawing.Point(160, 180);
            this.uxMouseCap.Name = "uxMouseCap";
            this.uxMouseCap.Size = new System.Drawing.Size(114, 22);
            this.uxMouseCap.TabIndex = 27;
            this.uxMouseCap.Text = "Capture mouse";
            this.uxMouseCap.UseVisualStyleBackColor = true;
            this.uxMouseCap.CheckedChanged += new System.EventHandler(this.uxMouseCap_CheckedChanged);
            // 
            // uxMouseY
            // 
            this.uxMouseY.AutoSize = true;
            this.uxMouseY.Location = new System.Drawing.Point(229, 220);
            this.uxMouseY.Name = "uxMouseY";
            this.uxMouseY.Size = new System.Drawing.Size(13, 13);
            this.uxMouseY.TabIndex = 31;
            this.uxMouseY.Text = "0";
            // 
            // uxMouseXlabel
            // 
            this.uxMouseXlabel.AutoSize = true;
            this.uxMouseXlabel.Location = new System.Drawing.Point(181, 205);
            this.uxMouseXlabel.Name = "uxMouseXlabel";
            this.uxMouseXlabel.Size = new System.Drawing.Size(48, 13);
            this.uxMouseXlabel.TabIndex = 28;
            this.uxMouseXlabel.Text = "mouseX:";
            // 
            // uxMouseX
            // 
            this.uxMouseX.AutoSize = true;
            this.uxMouseX.Location = new System.Drawing.Point(229, 205);
            this.uxMouseX.Name = "uxMouseX";
            this.uxMouseX.Size = new System.Drawing.Size(13, 13);
            this.uxMouseX.TabIndex = 30;
            this.uxMouseX.Text = "0";
            // 
            // uxMouseYlabel
            // 
            this.uxMouseYlabel.AutoSize = true;
            this.uxMouseYlabel.Location = new System.Drawing.Point(181, 220);
            this.uxMouseYlabel.Name = "uxMouseYlabel";
            this.uxMouseYlabel.Size = new System.Drawing.Size(48, 13);
            this.uxMouseYlabel.TabIndex = 29;
            this.uxMouseYlabel.Text = "mouseY:";
            // 
            // uxCheckAuto
            // 
            this.uxCheckAuto.AutoSize = true;
            this.uxCheckAuto.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCheckAuto.Location = new System.Drawing.Point(160, 152);
            this.uxCheckAuto.Name = "uxCheckAuto";
            this.uxCheckAuto.Size = new System.Drawing.Size(126, 22);
            this.uxCheckAuto.TabIndex = 26;
            this.uxCheckAuto.Text = "Auto Start/Stop";
            this.uxCheckAuto.UseVisualStyleBackColor = true;
            this.uxCheckAuto.CheckedChanged += new System.EventHandler(this.uxCheckAuto_CheckedChanged);
            // 
            // uxClearLog
            // 
            this.uxClearLog.Location = new System.Drawing.Point(12, 387);
            this.uxClearLog.Name = "uxClearLog";
            this.uxClearLog.Size = new System.Drawing.Size(69, 23);
            this.uxClearLog.TabIndex = 32;
            this.uxClearLog.Text = "Clear log";
            this.uxClearLog.UseVisualStyleBackColor = true;
            this.uxClearLog.Click += new System.EventHandler(this.uxClearLog_Click);
            // 
            // uxCPUlabel
            // 
            this.uxCPUlabel.AutoSize = true;
            this.uxCPUlabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCPUlabel.Location = new System.Drawing.Point(255, 389);
            this.uxCPUlabel.Name = "uxCPUlabel";
            this.uxCPUlabel.Size = new System.Drawing.Size(16, 18);
            this.uxCPUlabel.TabIndex = 33;
            this.uxCPUlabel.Text = "0";
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 418);
            this.Controls.Add(this.uxCPUlabel);
            this.Controls.Add(this.uxClearLog);
            this.Controls.Add(this.uxMouseCap);
            this.Controls.Add(this.uxMouseY);
            this.Controls.Add(this.uxMouseXlabel);
            this.Controls.Add(this.uxMouseX);
            this.Controls.Add(this.uxMouseYlabel);
            this.Controls.Add(this.uxCheckAuto);
            this.Controls.Add(this.uxTextStatus);
            this.Controls.Add(this.uxButtonMkill);
            this.Controls.Add(this.uxButtonMstart);
            this.Controls.Add(this.uxTextBatchFileName);
            this.Controls.Add(this.uxActiveNumber);
            this.Controls.Add(this.uxInactiveNumber);
            this.Controls.Add(this.uxCPUnumber);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "UserInterface";
            this.Text = "autoDig v0.5";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxCPUnumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxInactiveNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxActiveNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem utilitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setDefaultsToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown uxCPUnumber;
        private System.Windows.Forms.NumericUpDown uxInactiveNumber;
        private System.Windows.Forms.NumericUpDown uxActiveNumber;
        private System.Windows.Forms.TextBox uxTextBatchFileName;
        private System.Windows.Forms.Button uxButtonMstart;
        private System.Windows.Forms.Button uxButtonMkill;
        private System.Windows.Forms.TextBox uxTextStatus;
        private System.Windows.Forms.CheckBox uxMouseCap;
        private System.Windows.Forms.Label uxMouseY;
        private System.Windows.Forms.Label uxMouseXlabel;
        private System.Windows.Forms.Label uxMouseX;
        private System.Windows.Forms.Label uxMouseYlabel;
        private System.Windows.Forms.CheckBox uxCheckAuto;
        private System.Windows.Forms.Button uxClearLog;
        private System.Windows.Forms.Label uxCPUlabel;
    }
}

