namespace UserLogin
{
    partial class EnterScreen
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
            LoginButton = new Button();
            Password = new TextBox();
            Username = new TextBox();
            SuspendLayout();
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(245, 311);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(100, 23);
            LoginButton.TabIndex = 2;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            // 
            // Password
            // 
            Password.Location = new Point(245, 282);
            Password.Name = "Password";
            Password.PlaceholderText = "Password";
            Password.Size = new Size(100, 23);
            Password.TabIndex = 1;
            Password.TextChanged += Password_TextChanged;
            // 
            // Username
            // 
            Username.Location = new Point(245, 253);
            Username.Name = "Username";
            Username.PlaceholderText = "Username";
            Username.Size = new Size(100, 23);
            Username.TabIndex = 0;
            Username.TextChanged += Username_TextChanged;
            // 
            // EnterScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 601);
            Controls.Add(Username);
            Controls.Add(Password);
            Controls.Add(LoginButton);
            Name = "EnterScreen";
            Text = "EnterScreen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LoginButton;
        private TextBox Password;
        private TextBox Username;
    }
}