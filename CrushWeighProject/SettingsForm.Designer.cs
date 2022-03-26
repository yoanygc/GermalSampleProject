namespace CrushWeighProject
{
    partial class SettingsForm
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
            System.Windows.Forms.Label portLabel;
            System.Windows.Forms.Label iP_AddressLabel;
            System.Windows.Forms.Label modelLabel;
            System.Windows.Forms.Label label1;
            this.closeButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.brandTextBox = new System.Windows.Forms.TextBox();
            this.iP_AddressTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            portLabel = new System.Windows.Forms.Label();
            iP_AddressLabel = new System.Windows.Forms.Label();
            modelLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // portLabel
            // 
            portLabel.AutoSize = true;
            portLabel.Location = new System.Drawing.Point(18, 138);
            portLabel.Name = "portLabel";
            portLabel.Size = new System.Drawing.Size(42, 20);
            portLabel.TabIndex = 18;
            portLabel.Text = "Port:";
            // 
            // iP_AddressLabel
            // 
            iP_AddressLabel.AutoSize = true;
            iP_AddressLabel.Location = new System.Drawing.Point(18, 106);
            iP_AddressLabel.Name = "iP_AddressLabel";
            iP_AddressLabel.Size = new System.Drawing.Size(91, 20);
            iP_AddressLabel.TabIndex = 16;
            iP_AddressLabel.Text = "IP Address:";
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Location = new System.Drawing.Point(18, 74);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new System.Drawing.Size(56, 20);
            modelLabel.TabIndex = 14;
            modelLabel.Text = "Model:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(18, 42);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(56, 20);
            label1.TabIndex = 14;
            label1.Text = "Brand:";
            // 
            // closeButton
            // 
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton.Location = new System.Drawing.Point(667, 57);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(120, 39);
            this.closeButton.TabIndex = 13;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // acceptButton
            // 
            this.acceptButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.acceptButton.Location = new System.Drawing.Point(667, 12);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(120, 39);
            this.acceptButton.TabIndex = 14;
            this.acceptButton.Text = "Accept";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.connectButton);
            this.groupBox1.Controls.Add(this.portTextBox);
            this.groupBox1.Controls.Add(this.brandTextBox);
            this.groupBox1.Controls.Add(portLabel);
            this.groupBox1.Controls.Add(this.iP_AddressTextBox);
            this.groupBox1.Controls.Add(iP_AddressLabel);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(modelLabel);
            this.groupBox1.Controls.Add(this.modelTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 191);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Indicator:";
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(295, 103);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(103, 58);
            this.connectButton.TabIndex = 20;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            // 
            // portTextBox
            // 
            this.portTextBox.Location = new System.Drawing.Point(115, 135);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(106, 26);
            this.portTextBox.TabIndex = 19;
            // 
            // brandTextBox
            // 
            this.brandTextBox.Location = new System.Drawing.Point(115, 39);
            this.brandTextBox.Name = "brandTextBox";
            this.brandTextBox.Size = new System.Drawing.Size(283, 26);
            this.brandTextBox.TabIndex = 18;
            // 
            // iP_AddressTextBox
            // 
            this.iP_AddressTextBox.Location = new System.Drawing.Point(115, 103);
            this.iP_AddressTextBox.Name = "iP_AddressTextBox";
            this.iP_AddressTextBox.Size = new System.Drawing.Size(165, 26);
            this.iP_AddressTextBox.TabIndex = 17;
            // 
            // modelTextBox
            // 
            this.modelTextBox.Location = new System.Drawing.Point(115, 71);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(283, 26);
            this.modelTextBox.TabIndex = 15;
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.acceptButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeButton;
            this.ClientSize = new System.Drawing.Size(799, 543);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.closeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.TextBox iP_AddressTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox brandTextBox;
        private System.Windows.Forms.Button connectButton;
    }
}