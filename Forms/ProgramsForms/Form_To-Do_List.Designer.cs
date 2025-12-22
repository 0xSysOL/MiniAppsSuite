namespace Project_1_SimpleCalculetor.Forms.ProgramsForms
{
    partial class Form_To_Do_List
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
            this.Page_AddTasks = new System.Windows.Forms.TabPage();
            this.Butt_Exit = new System.Windows.Forms.Button();
            this.CLB_AddTasktoList = new System.Windows.Forms.CheckedListBox();
            this.But_Delete = new System.Windows.Forms.Button();
            this.But_Complate = new System.Windows.Forms.Button();
            this.But_AddTask = new System.Windows.Forms.Button();
            this.TB_AddedTasks = new System.Windows.Forms.TextBox();
            this.LabelPage_1 = new System.Windows.Forms.Label();
            this.Pages = new System.Windows.Forms.TabControl();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.Page_AddTasks.SuspendLayout();
            this.Pages.SuspendLayout();
            this.SuspendLayout();
            // 
            // Page_AddTasks
            // 
            this.Page_AddTasks.BackColor = System.Drawing.Color.White;
            this.Page_AddTasks.Controls.Add(this.Butt_Exit);
            this.Page_AddTasks.Controls.Add(this.CLB_AddTasktoList);
            this.Page_AddTasks.Controls.Add(this.But_Delete);
            this.Page_AddTasks.Controls.Add(this.But_Complate);
            this.Page_AddTasks.Controls.Add(this.But_AddTask);
            this.Page_AddTasks.Controls.Add(this.TB_AddedTasks);
            this.Page_AddTasks.Controls.Add(this.LabelPage_1);
            this.Page_AddTasks.Location = new System.Drawing.Point(4, 25);
            this.Page_AddTasks.Name = "Page_AddTasks";
            this.Page_AddTasks.Padding = new System.Windows.Forms.Padding(3);
            this.Page_AddTasks.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Page_AddTasks.Size = new System.Drawing.Size(338, 425);
            this.Page_AddTasks.TabIndex = 0;
            this.Page_AddTasks.Text = "Add Task";
            // 
            // Butt_Exit
            // 
            this.Butt_Exit.Location = new System.Drawing.Point(3, 6);
            this.Butt_Exit.Name = "Butt_Exit";
            this.Butt_Exit.Size = new System.Drawing.Size(75, 23);
            this.Butt_Exit.TabIndex = 1;
            this.Butt_Exit.Text = "Exit";
            this.Butt_Exit.UseVisualStyleBackColor = true;
            this.Butt_Exit.Click += new System.EventHandler(this.But_eixt);
            // 
            // CLB_AddTasktoList
            // 
            this.CLB_AddTasktoList.FormattingEnabled = true;
            this.CLB_AddTasktoList.Items.AddRange(new object[] {
            " "});
            this.CLB_AddTasktoList.Location = new System.Drawing.Point(82, 150);
            this.CLB_AddTasktoList.Name = "CLB_AddTasktoList";
            this.CLB_AddTasktoList.Size = new System.Drawing.Size(174, 157);
            this.CLB_AddTasktoList.TabIndex = 7;
            // 
            // But_Delete
            // 
            this.But_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.But_Delete.Location = new System.Drawing.Point(177, 364);
            this.But_Delete.Name = "But_Delete";
            this.But_Delete.Size = new System.Drawing.Size(99, 30);
            this.But_Delete.TabIndex = 6;
            this.But_Delete.Tag = "Delete";
            this.But_Delete.Text = "Delete";
            this.But_Delete.UseVisualStyleBackColor = true;
            this.But_Delete.Click += new System.EventHandler(this.Clicked);
            // 
            // But_Complate
            // 
            this.But_Complate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.But_Complate.Location = new System.Drawing.Point(61, 364);
            this.But_Complate.Name = "But_Complate";
            this.But_Complate.Size = new System.Drawing.Size(101, 33);
            this.But_Complate.TabIndex = 5;
            this.But_Complate.Tag = "Complated";
            this.But_Complate.Text = "Complate";
            this.But_Complate.UseVisualStyleBackColor = true;
            this.But_Complate.Click += new System.EventHandler(this.Clicked);
            // 
            // But_AddTask
            // 
            this.But_AddTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.But_AddTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.But_AddTask.Location = new System.Drawing.Point(82, 111);
            this.But_AddTask.Name = "But_AddTask";
            this.But_AddTask.Size = new System.Drawing.Size(174, 33);
            this.But_AddTask.TabIndex = 4;
            this.But_AddTask.Tag = "ADD_T";
            this.But_AddTask.Text = "+ Add task";
            this.But_AddTask.UseVisualStyleBackColor = false;
            this.But_AddTask.Click += new System.EventHandler(this.Clicked);
            // 
            // TB_AddedTasks
            // 
            this.TB_AddedTasks.BackColor = System.Drawing.Color.AntiqueWhite;
            this.TB_AddedTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.TB_AddedTasks.Location = new System.Drawing.Point(48, 66);
            this.TB_AddedTasks.Name = "TB_AddedTasks";
            this.TB_AddedTasks.Size = new System.Drawing.Size(244, 30);
            this.TB_AddedTasks.TabIndex = 1;
            // 
            // LabelPage_1
            // 
            this.LabelPage_1.AutoSize = true;
            this.LabelPage_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.LabelPage_1.Location = new System.Drawing.Point(104, 18);
            this.LabelPage_1.Name = "LabelPage_1";
            this.LabelPage_1.Size = new System.Drawing.Size(138, 31);
            this.LabelPage_1.TabIndex = 0;
            this.LabelPage_1.Text = "To Do List";
            // 
            // Pages
            // 
            this.Pages.Controls.Add(this.Page_AddTasks);
            this.Pages.Cursor = System.Windows.Forms.Cursors.Default;
            this.Pages.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pages.Location = new System.Drawing.Point(0, 0);
            this.Pages.Name = "Pages";
            this.Pages.SelectedIndex = 0;
            this.Pages.Size = new System.Drawing.Size(346, 454);
            this.Pages.TabIndex = 0;
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            this.notifyIcon.Text = "notifyIcon";
            this.notifyIcon.Visible = true;
            // 
            // Form_To_Do_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 450);
            this.Controls.Add(this.Pages);
            this.Name = "Form_To_Do_List";
            this.Text = "To Do List";
            this.Load += new System.EventHandler(this.Form_To_Do_List_Load);
            this.Page_AddTasks.ResumeLayout(false);
            this.Page_AddTasks.PerformLayout();
            this.Pages.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage Page_AddTasks;
        private System.Windows.Forms.CheckedListBox CLB_AddTasktoList;
        private System.Windows.Forms.Button But_Delete;
        private System.Windows.Forms.Button But_Complate;
        private System.Windows.Forms.Button But_AddTask;
        private System.Windows.Forms.TextBox TB_AddedTasks;
        private System.Windows.Forms.Label LabelPage_1;
        private System.Windows.Forms.TabControl Pages;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Button Butt_Exit;
    }
}