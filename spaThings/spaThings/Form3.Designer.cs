namespace spaThings
{
    partial class Form3
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            login = new Label();
            password = new Label();
            username = new Label();
            loginbutton = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(30, 110);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(30, 174);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // login
            // 
            login.AutoSize = true;
            login.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            login.Location = new Point(91, 40);
            login.Name = "login";
            login.Size = new Size(76, 30);
            login.TabIndex = 2;
            login.Text = "Log In";
            // 
            // password
            // 
            password.AutoSize = true;
            password.Location = new Point(30, 156);
            password.Name = "password";
            password.Size = new Size(57, 15);
            password.TabIndex = 3;
            password.Text = "Password";
            password.Click += label2_Click;
            // 
            // username
            // 
            username.AutoSize = true;
            username.Location = new Point(30, 92);
            username.Name = "username";
            username.Size = new Size(60, 15);
            username.TabIndex = 4;
            username.Text = "Username";
            username.Click += label3_Click;
            // 
            // loginbutton
            // 
            loginbutton.Location = new Point(92, 225);
            loginbutton.Name = "loginbutton";
            loginbutton.Size = new Size(75, 23);
            loginbutton.TabIndex = 5;
            loginbutton.Text = "Log In";
            loginbutton.UseVisualStyleBackColor = true;
            loginbutton.Click += button1_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(255, 283);
            Controls.Add(loginbutton);
            Controls.Add(username);
            Controls.Add(password);
            Controls.Add(login);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label login;
        private Label password;
        private Label username;
        private Button loginbutton;
    }
}