namespace User_login
{
    partial class Login
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
            this.test1 = new System.Windows.Forms.Label();
            this.test2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // test1
            // 
            this.test1.AutoSize = true;
            this.test1.Location = new System.Drawing.Point(307, 166);
            this.test1.Name = "test1";
            this.test1.Size = new System.Drawing.Size(35, 13);
            this.test1.TabIndex = 0;
            this.test1.Text = "label1";
            this.test1.Click += new System.EventHandler(this.test1_Click);
            // 
            // test2
            // 
            this.test2.AutoSize = true;
            this.test2.Location = new System.Drawing.Point(301, 234);
            this.test2.Name = "test2";
            this.test2.Size = new System.Drawing.Size(35, 13);
            this.test2.TabIndex = 1;
            this.test2.Text = "label2";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.test2);
            this.Controls.Add(this.test1);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label test1;
        private System.Windows.Forms.Label test2;
    }
}