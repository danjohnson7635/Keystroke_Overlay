namespace OsuOverlay
{
    partial class Form2
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
            this.checkBoxKPS = new System.Windows.Forms.CheckBox();
            this.btnUnpressedColor = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.btnPressedColor = new System.Windows.Forms.Button();
            this.btnFontColor = new System.Windows.Forms.Button();
            this.btnBackgroundColor = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRestoreDefaultSettings = new System.Windows.Forms.Button();
            this.lblUP = new System.Windows.Forms.Label();
            this.lblP = new System.Windows.Forms.Label();
            this.lblF = new System.Windows.Forms.Label();
            this.lblBG = new System.Windows.Forms.Label();
            this.checkBoxCountByKey = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkBoxKPS
            // 
            this.checkBoxKPS.AutoSize = true;
            this.checkBoxKPS.Checked = true;
            this.checkBoxKPS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxKPS.Location = new System.Drawing.Point(46, 24);
            this.checkBoxKPS.Name = "checkBoxKPS";
            this.checkBoxKPS.Size = new System.Drawing.Size(168, 17);
            this.checkBoxKPS.TabIndex = 0;
            this.checkBoxKPS.Text = "Show Keys Per Second (KPS)";
            this.checkBoxKPS.UseVisualStyleBackColor = true;
            this.checkBoxKPS.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnUnpressedColor
            // 
            this.btnUnpressedColor.Location = new System.Drawing.Point(46, 77);
            this.btnUnpressedColor.Name = "btnUnpressedColor";
            this.btnUnpressedColor.Size = new System.Drawing.Size(168, 23);
            this.btnUnpressedColor.TabIndex = 1;
            this.btnUnpressedColor.Text = "change key unpressed color";
            this.btnUnpressedColor.UseVisualStyleBackColor = true;
            this.btnUnpressedColor.Click += new System.EventHandler(this.button1_Click);
            // 
            // colorDialog
            // 
            this.colorDialog.AnyColor = true;
            // 
            // btnPressedColor
            // 
            this.btnPressedColor.Location = new System.Drawing.Point(46, 106);
            this.btnPressedColor.Name = "btnPressedColor";
            this.btnPressedColor.Size = new System.Drawing.Size(168, 23);
            this.btnPressedColor.TabIndex = 2;
            this.btnPressedColor.Text = "change key pressed color";
            this.btnPressedColor.UseVisualStyleBackColor = true;
            this.btnPressedColor.Click += new System.EventHandler(this.btnPressedColor_Click);
            // 
            // btnFontColor
            // 
            this.btnFontColor.Location = new System.Drawing.Point(46, 164);
            this.btnFontColor.Name = "btnFontColor";
            this.btnFontColor.Size = new System.Drawing.Size(168, 23);
            this.btnFontColor.TabIndex = 3;
            this.btnFontColor.Text = "change font color";
            this.btnFontColor.UseVisualStyleBackColor = true;
            this.btnFontColor.Click += new System.EventHandler(this.btnFontColor_Click);
            // 
            // btnBackgroundColor
            // 
            this.btnBackgroundColor.Location = new System.Drawing.Point(46, 135);
            this.btnBackgroundColor.Name = "btnBackgroundColor";
            this.btnBackgroundColor.Size = new System.Drawing.Size(168, 23);
            this.btnBackgroundColor.TabIndex = 4;
            this.btnBackgroundColor.Text = "change background color";
            this.btnBackgroundColor.UseVisualStyleBackColor = true;
            this.btnBackgroundColor.Click += new System.EventHandler(this.btnBackgroundColor_Click);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(46, 367);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 5;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(128, 367);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRestoreDefaultSettings
            // 
            this.btnRestoreDefaultSettings.Location = new System.Drawing.Point(46, 223);
            this.btnRestoreDefaultSettings.Name = "btnRestoreDefaultSettings";
            this.btnRestoreDefaultSettings.Size = new System.Drawing.Size(157, 23);
            this.btnRestoreDefaultSettings.TabIndex = 7;
            this.btnRestoreDefaultSettings.Text = "Restore Defaults";
            this.btnRestoreDefaultSettings.UseVisualStyleBackColor = true;
            this.btnRestoreDefaultSettings.Click += new System.EventHandler(this.btnRestoreDefaultSettings_Click);
            // 
            // lblUP
            // 
            this.lblUP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUP.Location = new System.Drawing.Point(220, 77);
            this.lblUP.Name = "lblUP";
            this.lblUP.Size = new System.Drawing.Size(38, 23);
            this.lblUP.TabIndex = 8;
            // 
            // lblP
            // 
            this.lblP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblP.Location = new System.Drawing.Point(220, 106);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(38, 23);
            this.lblP.TabIndex = 9;
            // 
            // lblF
            // 
            this.lblF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblF.Location = new System.Drawing.Point(220, 164);
            this.lblF.Name = "lblF";
            this.lblF.Size = new System.Drawing.Size(38, 23);
            this.lblF.TabIndex = 11;
            // 
            // lblBG
            // 
            this.lblBG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBG.Location = new System.Drawing.Point(220, 135);
            this.lblBG.Name = "lblBG";
            this.lblBG.Size = new System.Drawing.Size(38, 23);
            this.lblBG.TabIndex = 10;
            // 
            // checkBoxCountByKey
            // 
            this.checkBoxCountByKey.AutoSize = true;
            this.checkBoxCountByKey.Checked = true;
            this.checkBoxCountByKey.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCountByKey.Location = new System.Drawing.Point(46, 48);
            this.checkBoxCountByKey.Name = "checkBoxCountByKey";
            this.checkBoxCountByKey.Size = new System.Drawing.Size(158, 17);
            this.checkBoxCountByKey.TabIndex = 12;
            this.checkBoxCountByKey.Text = "Show Individual Key Counts";
            this.checkBoxCountByKey.UseVisualStyleBackColor = true;
            this.checkBoxCountByKey.CheckedChanged += new System.EventHandler(this.checkBoxCountByKey_CheckedChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 446);
            this.Controls.Add(this.checkBoxCountByKey);
            this.Controls.Add(this.lblF);
            this.Controls.Add(this.lblBG);
            this.Controls.Add(this.lblP);
            this.Controls.Add(this.lblUP);
            this.Controls.Add(this.btnRestoreDefaultSettings);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnBackgroundColor);
            this.Controls.Add(this.btnFontColor);
            this.Controls.Add(this.btnPressedColor);
            this.Controls.Add(this.btnUnpressedColor);
            this.Controls.Add(this.checkBoxKPS);
            this.Name = "Form2";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxKPS;
        private System.Windows.Forms.Button btnUnpressedColor;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button btnPressedColor;
        private System.Windows.Forms.Button btnFontColor;
        private System.Windows.Forms.Button btnBackgroundColor;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRestoreDefaultSettings;
        private System.Windows.Forms.Label lblUP;
        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.Label lblF;
        private System.Windows.Forms.Label lblBG;
        private System.Windows.Forms.CheckBox checkBoxCountByKey;
    }
}