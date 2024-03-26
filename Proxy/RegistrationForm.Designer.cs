namespace Proxy
{
    partial class RegistrationForm
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LoginLabel = new Label();
            PassLabel = new Label();
            LoginBox = new TextBox();
            PasswordBox = new TextBox();
            LoginButton = new Button();
            SuspendLayout();
            // 
            // LoginLabel
            // 
            LoginLabel.Anchor = AnchorStyles.None;
            LoginLabel.AutoSize = true;
            LoginLabel.Location = new Point(145, 50);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(41, 15);
            LoginLabel.TabIndex = 0;
            LoginLabel.Text = "Логин";
            LoginLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PassLabel
            // 
            PassLabel.AutoSize = true;
            PassLabel.Location = new Point(141, 108);
            PassLabel.Name = "PassLabel";
            PassLabel.Size = new Size(49, 15);
            PassLabel.TabIndex = 1;
            PassLabel.Text = "Пароль";
            // 
            // LoginBox
            // 
            LoginBox.Location = new Point(116, 68);
            LoginBox.Name = "LoginBox";
            LoginBox.Size = new Size(100, 23);
            LoginBox.TabIndex = 2;
            // 
            // PasswordBox
            // 
            PasswordBox.Location = new Point(116, 126);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(100, 23);
            PasswordBox.TabIndex = 3;
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(127, 159);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(75, 23);
            LoginButton.TabIndex = 4;
            LoginButton.Text = "Войти";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 261);
            Controls.Add(LoginButton);
            Controls.Add(PasswordBox);
            Controls.Add(LoginBox);
            Controls.Add(PassLabel);
            Controls.Add(LoginLabel);
            Name = "RegistrationForm";
            Text = "Registration";
            Load += RegistrationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LoginLabel;
        private Label PassLabel;
        private TextBox LoginBox;
        private TextBox PasswordBox;
        private Button LoginButton;
    }
}
