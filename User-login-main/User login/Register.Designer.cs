namespace User_login
{
    partial class Register
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
            this.button1 = new System.Windows.Forms.Button();
            this.Username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Password1 = new System.Windows.Forms.TextBox();
            this.Password2 = new System.Windows.Forms.TextBox();
            this.Create = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.FilePathLabel = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.pnlSignUp = new System.Windows.Forms.Panel();
            this.pnlSignUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(759, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(142, 42);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(100, 20);
            this.Username.TabIndex = 1;
            this.Username.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "User name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Confirm password";
            // 
            // Password1
            // 
            this.Password1.Location = new System.Drawing.Point(155, 89);
            this.Password1.Name = "Password1";
            this.Password1.Size = new System.Drawing.Size(100, 20);
            this.Password1.TabIndex = 5;
            this.Password1.TextChanged += new System.EventHandler(this.Password1_TextChanged);
            // 
            // Password2
            // 
            this.Password2.Location = new System.Drawing.Point(182, 133);
            this.Password2.Name = "Password2";
            this.Password2.Size = new System.Drawing.Size(100, 20);
            this.Password2.TabIndex = 6;
            this.Password2.TextChanged += new System.EventHandler(this.Password2_TextChanged);
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(182, 159);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(106, 23);
            this.Create.TabIndex = 7;
            this.Create.Text = "Create account";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(323, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(239, 52);
            this.button2.TabIndex = 8;
            this.button2.Text = "Choose where login infos are stored";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FilePathLabel
            // 
            this.FilePathLabel.AutoSize = true;
            this.FilePathLabel.Location = new System.Drawing.Point(644, 84);
            this.FilePathLabel.Name = "FilePathLabel";
            this.FilePathLabel.Size = new System.Drawing.Size(35, 13);
            this.FilePathLabel.TabIndex = 9;
            this.FilePathLabel.Text = "label4";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(21, 45);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(240, 52);
            this.button3.TabIndex = 10;
            this.button3.Text = "Load XML file";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pnlSignUp
            // 
            this.pnlSignUp.Controls.Add(this.label1);
            this.pnlSignUp.Controls.Add(this.Username);
            this.pnlSignUp.Controls.Add(this.label2);
            this.pnlSignUp.Controls.Add(this.Password1);
            this.pnlSignUp.Controls.Add(this.Create);
            this.pnlSignUp.Controls.Add(this.label3);
            this.pnlSignUp.Controls.Add(this.Password2);
            this.pnlSignUp.Location = new System.Drawing.Point(262, 137);
            this.pnlSignUp.Name = "pnlSignUp";
            this.pnlSignUp.Size = new System.Drawing.Size(407, 199);
            this.pnlSignUp.TabIndex = 11;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.pnlSignUp);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.FilePathLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.pnlSignUp.ResumeLayout(false);
            this.pnlSignUp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Password1;
        private System.Windows.Forms.TextBox Password2;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label FilePathLabel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel pnlSignUp;
    }
}