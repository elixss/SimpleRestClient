namespace PerformApiCalls
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code (modified)

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor. (i did anyway lol)
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.Title = new System.Windows.Forms.Label();
            this.UriTextBox = new System.Windows.Forms.TextBox();
            this.UriLabel = new System.Windows.Forms.Label();
            this.AuthTextBox = new System.Windows.Forms.TextBox();
            this.AuthLabel = new System.Windows.Forms.Label();
            this.ResponseTextBox = new System.Windows.Forms.RichTextBox();
            this.RequestButton = new System.Windows.Forms.Button();
            this.ReqMethodLabel = new System.Windows.Forms.Label();
            this.GetMethodCheck = new System.Windows.Forms.CheckBox();
            this.ResponseLabel = new System.Windows.Forms.Label();
            this.AboutButton = new System.Windows.Forms.Button();
            this.SourceButton = new System.Windows.Forms.LinkLabel();
            this.HideAuthCheck = new System.Windows.Forms.CheckBox();
            this.SupportButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Title.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Title.Location = new System.Drawing.Point(25, 24);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(455, 28);
            this.Title.TabIndex = 0;
            this.Title.Text = "Perform API calls and see the JSON response below";
            // 
            // UriTextBox
            // 
            this.UriTextBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UriTextBox.Location = new System.Drawing.Point(34, 87);
            this.UriTextBox.Name = "UriTextBox";
            this.UriTextBox.Size = new System.Drawing.Size(455, 22);
            this.UriTextBox.TabIndex = 1;
            // 
            // UriLabel
            // 
            this.UriLabel.AutoSize = true;
            this.UriLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UriLabel.Location = new System.Drawing.Point(25, 69);
            this.UriLabel.Name = "UriLabel";
            this.UriLabel.Size = new System.Drawing.Size(75, 15);
            this.UriLabel.TabIndex = 2;
            this.UriLabel.Text = "Enter the URI";
            // 
            // AuthTextBox
            // 
            this.AuthTextBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AuthTextBox.Location = new System.Drawing.Point(35, 147);
            this.AuthTextBox.Name = "AuthTextBox";
            this.AuthTextBox.Size = new System.Drawing.Size(455, 22);
            this.AuthTextBox.TabIndex = 3;
            this.AuthTextBox.UseSystemPasswordChar = true;
            // 
            // AuthLabel
            // 
            this.AuthLabel.AutoSize = true;
            this.AuthLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AuthLabel.Location = new System.Drawing.Point(25, 129);
            this.AuthLabel.Name = "AuthLabel";
            this.AuthLabel.Size = new System.Drawing.Size(394, 15);
            this.AuthLabel.TabIndex = 4;
            this.AuthLabel.Text = "Set an auhorization header here. No need for JSON strings, only the value.";
            // 
            // ResponseTextBox
            // 
            this.ResponseTextBox.AutoSize = true;
            this.ResponseTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.ResponseTextBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResponseTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ResponseTextBox.Location = new System.Drawing.Point(25, 297);
            this.ResponseTextBox.Name = "ResponseTextBox";
            this.ResponseTextBox.ReadOnly = true;
            this.ResponseTextBox.Size = new System.Drawing.Size(517, 130);
            this.ResponseTextBox.TabIndex = 5;
            this.ResponseTextBox.Text = "Response will be shown here.";
            // 
            // RequestButton
            // 
            this.RequestButton.Location = new System.Drawing.Point(34, 232);
            this.RequestButton.Name = "RequestButton";
            this.RequestButton.Size = new System.Drawing.Size(284, 28);
            this.RequestButton.TabIndex = 6;
            this.RequestButton.Text = "Perform API request";
            this.RequestButton.UseVisualStyleBackColor = true;
            this.RequestButton.Click += new System.EventHandler(this.RequestButton_Click);
            // 
            // ReqMethodLabel
            // 
            this.ReqMethodLabel.AutoSize = true;
            this.ReqMethodLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ReqMethodLabel.Location = new System.Drawing.Point(25, 189);
            this.ReqMethodLabel.Name = "ReqMethodLabel";
            this.ReqMethodLabel.Size = new System.Drawing.Size(294, 15);
            this.ReqMethodLabel.TabIndex = 9;
            this.ReqMethodLabel.Text = "Choose your method (currently only GET is supported)";
            // 
            // GetMethodCheck
            // 
            this.GetMethodCheck.AutoSize = true;
            this.GetMethodCheck.Checked = true;
            this.GetMethodCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.GetMethodCheck.Enabled = false;
            this.GetMethodCheck.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GetMethodCheck.Location = new System.Drawing.Point(35, 207);
            this.GetMethodCheck.Name = "GetMethodCheck";
            this.GetMethodCheck.Size = new System.Drawing.Size(46, 19);
            this.GetMethodCheck.TabIndex = 11;
            this.GetMethodCheck.Text = "GET";
            this.GetMethodCheck.UseVisualStyleBackColor = true;
            // 
            // ResponseLabel
            // 
            this.ResponseLabel.AutoSize = true;
            this.ResponseLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ResponseLabel.Location = new System.Drawing.Point(24, 279);
            this.ResponseLabel.Name = "ResponseLabel";
            this.ResponseLabel.Size = new System.Drawing.Size(57, 15);
            this.ResponseLabel.TabIndex = 12;
            this.ResponseLabel.Text = "Response";
            // 
            // AboutButton
            // 
            this.AboutButton.Location = new System.Drawing.Point(745, 1);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(62, 25);
            this.AboutButton.TabIndex = 13;
            this.AboutButton.Text = "About";
            this.AboutButton.UseVisualStyleBackColor = true;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // SourceButton
            // 
            this.SourceButton.AutoSize = true;
            this.SourceButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SourceButton.LinkColor = System.Drawing.Color.DodgerBlue;
            this.SourceButton.Location = new System.Drawing.Point(689, 4);
            this.SourceButton.Name = "SourceButton";
            this.SourceButton.Size = new System.Drawing.Size(50, 19);
            this.SourceButton.TabIndex = 14;
            this.SourceButton.TabStop = true;
            this.SourceButton.Text = "Source";
            this.SourceButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SourceButton_Click);
            // 
            // HideAuthCheck
            // 
            this.HideAuthCheck.AutoSize = true;
            this.HideAuthCheck.Checked = true;
            this.HideAuthCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.HideAuthCheck.Location = new System.Drawing.Point(507, 151);
            this.HideAuthCheck.Name = "HideAuthCheck";
            this.HideAuthCheck.Size = new System.Drawing.Size(51, 19);
            this.HideAuthCheck.TabIndex = 15;
            this.HideAuthCheck.Text = "Hide";
            this.HideAuthCheck.UseVisualStyleBackColor = true;
            this.HideAuthCheck.CheckedChanged += new System.EventHandler(this.HideAuthCheck_Click);
            // 
            // SupportButton
            // 
            this.SupportButton.Location = new System.Drawing.Point(531, 4);
            this.SupportButton.Name = "SupportButton";
            this.SupportButton.Size = new System.Drawing.Size(152, 23);
            this.SupportButton.TabIndex = 16;
            this.SupportButton.Text = "Support the dev";
            this.SupportButton.UseVisualStyleBackColor = true;
            this.SupportButton.Click += new System.EventHandler(this.SupportButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(689, 397);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(92, 30);
            this.ExitButton.TabIndex = 17;
            this.ExitButton.Text = "Close";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 439);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SupportButton);
            this.Controls.Add(this.HideAuthCheck);
            this.Controls.Add(this.SourceButton);
            this.Controls.Add(this.AboutButton);
            this.Controls.Add(this.ResponseLabel);
            this.Controls.Add(this.GetMethodCheck);
            this.Controls.Add(this.ReqMethodLabel);
            this.Controls.Add(this.RequestButton);
            this.Controls.Add(this.ResponseTextBox);
            this.Controls.Add(this.AuthLabel);
            this.Controls.Add(this.AuthTextBox);
            this.Controls.Add(this.UriLabel);
            this.Controls.Add(this.UriTextBox);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "REST client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Title;
        private TextBox UriTextBox;
        private Label UriLabel;
        private TextBox AuthTextBox;
        private Label AuthLabel;
        private RichTextBox ResponseTextBox;
        private Button RequestButton;
        private Label ReqMethodLabel;
        private CheckBox GetMethodCheck;
        private Label ResponseLabel;
        private Button AboutButton;
        private LinkLabel SourceButton;
        private CheckBox HideAuthCheck;
        private Button SupportButton;
        private Button ExitButton;
    }
}