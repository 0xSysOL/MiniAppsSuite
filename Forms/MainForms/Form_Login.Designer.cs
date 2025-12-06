namespace Project_1_SimpleCalculetor
{
    partial class Form_Login
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
            this.LabelLogin = new System.Windows.Forms.Label();
            this.TX_UserName = new System.Windows.Forms.TextBox();
            this.TX_Password = new System.Windows.Forms.TextBox();
            this.ButLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelLogin
            // 
            this.LabelLogin.AutoSize = true;
            this.LabelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLogin.ForeColor = System.Drawing.Color.GhostWhite;
            this.LabelLogin.Location = new System.Drawing.Point(196, 65);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(111, 37);
            this.LabelLogin.TabIndex = 0;
            this.LabelLogin.Text = "Log in";
            // 
            // TX_UserName
            // 
            this.TX_UserName.BackColor = System.Drawing.SystemColors.Window;
            this.TX_UserName.Location = new System.Drawing.Point(168, 141);
            this.TX_UserName.Name = "TX_UserName";
            this.TX_UserName.Size = new System.Drawing.Size(182, 22);
            this.TX_UserName.TabIndex = 1;
            this.TX_UserName.TextChanged += new System.EventHandler(this.TX_UserName_TextChanged);
            // 
            // TX_Password
            // 
            this.TX_Password.BackColor = System.Drawing.SystemColors.Window;
            this.TX_Password.Location = new System.Drawing.Point(168, 179);
            this.TX_Password.Name = "TX_Password";
            this.TX_Password.PasswordChar = '*';
            this.TX_Password.Size = new System.Drawing.Size(182, 22);
            this.TX_Password.TabIndex = 2;
            // 
            // ButLogin
            // 
            this.ButLogin.Location = new System.Drawing.Point(199, 221);
            this.ButLogin.Name = "ButLogin";
            this.ButLogin.Size = new System.Drawing.Size(108, 27);
            this.ButLogin.TabIndex = 3;
            this.ButLogin.Text = "Submit";
            this.ButLogin.UseVisualStyleBackColor = true;
            this.ButLogin.Click += new System.EventHandler(this.ButLogin_Click);
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(569, 364);
            this.Controls.Add(this.ButLogin);
            this.Controls.Add(this.TX_Password);
            this.Controls.Add(this.TX_UserName);
            this.Controls.Add(this.LabelLogin);
            this.Name = "Form_Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelLogin;
        private System.Windows.Forms.TextBox TX_UserName;
        private System.Windows.Forms.TextBox TX_Password;
        private System.Windows.Forms.Button ButLogin;
    }
}

