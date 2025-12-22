namespace Project_1_SimpleCalculetor.Forms.ProgramsForms
{
    partial class Form_UserInputTable
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
            this.components = new System.ComponentModel.Container();
            this.listView = new System.Windows.Forms.ListView();
            this.Colu_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Colu_FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Colu_LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Butt_ = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TB_FirstName = new System.Windows.Forms.TextBox();
            this.TB_LastName = new System.Windows.Forms.TextBox();
            this.lab_FirstName = new System.Windows.Forms.Label();
            this.lab_LastName = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.ButExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Colu_ID,
            this.Colu_FirstName,
            this.Colu_LastName});
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(355, -2);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(368, 389);
            this.listView.TabIndex = 5;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // Colu_ID
            // 
            this.Colu_ID.Text = "ID";
            this.Colu_ID.Width = 89;
            // 
            // Colu_FirstName
            // 
            this.Colu_FirstName.Text = "First Name";
            this.Colu_FirstName.Width = 113;
            // 
            // Colu_LastName
            // 
            this.Colu_LastName.Text = "Last Name";
            this.Colu_LastName.Width = 115;
            // 
            // Butt_
            // 
            this.Butt_.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.Butt_.Location = new System.Drawing.Point(32, 277);
            this.Butt_.Name = "Butt_";
            this.Butt_.Size = new System.Drawing.Size(79, 36);
            this.Butt_.TabIndex = 2;
            this.Butt_.Tag = "add";
            this.Butt_.Text = "Add";
            this.Butt_.UseVisualStyleBackColor = true;
            this.Butt_.Click += new System.EventHandler(this.ButtChecked);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.button1.Location = new System.Drawing.Point(113, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 36);
            this.button1.TabIndex = 3;
            this.button1.Tag = "remove";
            this.button1.Text = "Remove";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ButtChecked);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.button2.Location = new System.Drawing.Point(216, 277);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 36);
            this.button2.TabIndex = 4;
            this.button2.Tag = "edit";
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ButtChecked);
            // 
            // TB_FirstName
            // 
            this.TB_FirstName.BackColor = System.Drawing.SystemColors.HighlightText;
            this.TB_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.TB_FirstName.Location = new System.Drawing.Point(145, 150);
            this.TB_FirstName.Name = "TB_FirstName";
            this.TB_FirstName.Size = new System.Drawing.Size(109, 26);
            this.TB_FirstName.TabIndex = 0;
            this.TB_FirstName.Validating += new System.ComponentModel.CancelEventHandler(this.Text_FN_LN);
            // 
            // TB_LastName
            // 
            this.TB_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.TB_LastName.Location = new System.Drawing.Point(145, 182);
            this.TB_LastName.Name = "TB_LastName";
            this.TB_LastName.Size = new System.Drawing.Size(109, 26);
            this.TB_LastName.TabIndex = 1;
            // 
            // lab_FirstName
            // 
            this.lab_FirstName.AutoSize = true;
            this.lab_FirstName.BackColor = System.Drawing.Color.Transparent;
            this.lab_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.lab_FirstName.ForeColor = System.Drawing.Color.Cornsilk;
            this.lab_FirstName.Location = new System.Drawing.Point(33, 149);
            this.lab_FirstName.Name = "lab_FirstName";
            this.lab_FirstName.Size = new System.Drawing.Size(106, 25);
            this.lab_FirstName.TabIndex = 6;
            this.lab_FirstName.Text = "First Name";
            // 
            // lab_LastName
            // 
            this.lab_LastName.AutoSize = true;
            this.lab_LastName.BackColor = System.Drawing.Color.Transparent;
            this.lab_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.lab_LastName.ForeColor = System.Drawing.Color.Cornsilk;
            this.lab_LastName.Location = new System.Drawing.Point(33, 183);
            this.lab_LastName.Name = "lab_LastName";
            this.lab_LastName.Size = new System.Drawing.Size(106, 25);
            this.lab_LastName.TabIndex = 7;
            this.lab_LastName.Text = "Last Name";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            this.notifyIcon.Text = "notifyIcon";
            this.notifyIcon.Visible = true;
            // 
            // ButExit
            // 
            this.ButExit.Location = new System.Drawing.Point(12, 12);
            this.ButExit.Name = "ButExit";
            this.ButExit.Size = new System.Drawing.Size(75, 23);
            this.ButExit.TabIndex = 8;
            this.ButExit.Text = "Exit";
            this.ButExit.UseVisualStyleBackColor = true;
            this.ButExit.Click += new System.EventHandler(this.But_Exit);
            // 
            // Form_UserInputTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(715, 383);
            this.Controls.Add(this.ButExit);
            this.Controls.Add(this.lab_LastName);
            this.Controls.Add(this.lab_FirstName);
            this.Controls.Add(this.TB_LastName);
            this.Controls.Add(this.TB_FirstName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Butt_);
            this.Controls.Add(this.listView);
            this.Name = "Form_UserInputTable";
            this.Text = "User Input Table";
            this.Load += new System.EventHandler(this.Form_UserInputTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader Colu_ID;
        private System.Windows.Forms.ColumnHeader Colu_FirstName;
        private System.Windows.Forms.ColumnHeader Colu_LastName;
        private System.Windows.Forms.Button Butt_;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TB_FirstName;
        private System.Windows.Forms.TextBox TB_LastName;
        private System.Windows.Forms.Label lab_FirstName;
        private System.Windows.Forms.Label lab_LastName;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Button ButExit;
    }
}