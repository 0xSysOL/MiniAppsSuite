namespace Project_1_SimpleCalculetor
{
    partial class Form_ProgramSelection
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
            this.Labe_ShowScreenChoice = new System.Windows.Forms.Label();
            this.butSubmet = new System.Windows.Forms.Button();
            this.rad_Calculetor = new System.Windows.Forms.RadioButton();
            this.rad_UserInputTable = new System.Windows.Forms.RadioButton();
            this.rad_ToDoList = new System.Windows.Forms.RadioButton();
            this.rad_Books = new System.Windows.Forms.RadioButton();
            this.rad_BDE = new System.Windows.Forms.RadioButton();
            this.rad_SBL = new System.Windows.Forms.RadioButton();
            this.PicB_SBL = new System.Windows.Forms.PictureBox();
            this.PicB_BDE = new System.Windows.Forms.PictureBox();
            this.PicB_Calculate = new System.Windows.Forms.PictureBox();
            this.PicB_Books = new System.Windows.Forms.PictureBox();
            this.PicB_ToDoList = new System.Windows.Forms.PictureBox();
            this.PicB_UserInputTable = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicB_SBL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicB_BDE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicB_Calculate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicB_Books)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicB_ToDoList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicB_UserInputTable)).BeginInit();
            this.SuspendLayout();
            // 
            // Labe_ShowScreenChoice
            // 
            this.Labe_ShowScreenChoice.AutoSize = true;
            this.Labe_ShowScreenChoice.BackColor = System.Drawing.Color.Transparent;
            this.Labe_ShowScreenChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Labe_ShowScreenChoice.ForeColor = System.Drawing.Color.Cornsilk;
            this.Labe_ShowScreenChoice.Location = new System.Drawing.Point(254, 45);
            this.Labe_ShowScreenChoice.Name = "Labe_ShowScreenChoice";
            this.Labe_ShowScreenChoice.Size = new System.Drawing.Size(377, 54);
            this.Labe_ShowScreenChoice.TabIndex = 6;
            this.Labe_ShowScreenChoice.Text = "Choose Program";
            // 
            // butSubmet
            // 
            this.butSubmet.Location = new System.Drawing.Point(336, 361);
            this.butSubmet.Name = "butSubmet";
            this.butSubmet.Size = new System.Drawing.Size(199, 50);
            this.butSubmet.TabIndex = 6;
            this.butSubmet.Tag = "false";
            this.butSubmet.Text = "Submit";
            this.butSubmet.UseVisualStyleBackColor = true;
            this.butSubmet.Click += new System.EventHandler(this.butSubmet_Click);
            // 
            // rad_Calculetor
            // 
            this.rad_Calculetor.AutoSize = true;
            this.rad_Calculetor.BackColor = System.Drawing.Color.Transparent;
            this.rad_Calculetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.rad_Calculetor.ForeColor = System.Drawing.Color.White;
            this.rad_Calculetor.Location = new System.Drawing.Point(12, 289);
            this.rad_Calculetor.Name = "rad_Calculetor";
            this.rad_Calculetor.Size = new System.Drawing.Size(112, 26);
            this.rad_Calculetor.TabIndex = 0;
            this.rad_Calculetor.TabStop = true;
            this.rad_Calculetor.Tag = "Calc";
            this.rad_Calculetor.Text = "Calculetor";
            this.rad_Calculetor.UseVisualStyleBackColor = false;
            this.rad_Calculetor.Click += new System.EventHandler(this.radioChange);
            // 
            // rad_UserInputTable
            // 
            this.rad_UserInputTable.AutoSize = true;
            this.rad_UserInputTable.BackColor = System.Drawing.Color.Transparent;
            this.rad_UserInputTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.rad_UserInputTable.ForeColor = System.Drawing.Color.White;
            this.rad_UserInputTable.Location = new System.Drawing.Point(141, 289);
            this.rad_UserInputTable.Name = "rad_UserInputTable";
            this.rad_UserInputTable.Size = new System.Drawing.Size(169, 26);
            this.rad_UserInputTable.TabIndex = 1;
            this.rad_UserInputTable.Tag = "UserInputTable ";
            this.rad_UserInputTable.Text = "User Input Table ";
            this.rad_UserInputTable.UseVisualStyleBackColor = false;
            this.rad_UserInputTable.Click += new System.EventHandler(this.radioChange);
            // 
            // rad_ToDoList
            // 
            this.rad_ToDoList.AutoSize = true;
            this.rad_ToDoList.BackColor = System.Drawing.Color.Transparent;
            this.rad_ToDoList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.rad_ToDoList.ForeColor = System.Drawing.Color.White;
            this.rad_ToDoList.Location = new System.Drawing.Point(351, 289);
            this.rad_ToDoList.Name = "rad_ToDoList";
            this.rad_ToDoList.Size = new System.Drawing.Size(115, 26);
            this.rad_ToDoList.TabIndex = 2;
            this.rad_ToDoList.Tag = "ToDoList";
            this.rad_ToDoList.Text = "To-Do List";
            this.rad_ToDoList.UseVisualStyleBackColor = false;
            this.rad_ToDoList.Click += new System.EventHandler(this.radioChange);
            // 
            // rad_Books
            // 
            this.rad_Books.AutoSize = true;
            this.rad_Books.BackColor = System.Drawing.Color.Transparent;
            this.rad_Books.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.rad_Books.ForeColor = System.Drawing.Color.White;
            this.rad_Books.Location = new System.Drawing.Point(493, 289);
            this.rad_Books.Name = "rad_Books";
            this.rad_Books.Size = new System.Drawing.Size(81, 26);
            this.rad_Books.TabIndex = 3;
            this.rad_Books.Tag = "Books";
            this.rad_Books.Text = "Books";
            this.rad_Books.UseVisualStyleBackColor = false;
            this.rad_Books.Click += new System.EventHandler(this.radioChange);
            // 
            // rad_BDE
            // 
            this.rad_BDE.AutoSize = true;
            this.rad_BDE.BackColor = System.Drawing.Color.Transparent;
            this.rad_BDE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.rad_BDE.ForeColor = System.Drawing.Color.White;
            this.rad_BDE.Location = new System.Drawing.Point(618, 289);
            this.rad_BDE.Name = "rad_BDE";
            this.rad_BDE.Size = new System.Drawing.Size(127, 26);
            this.rad_BDE.TabIndex = 4;
            this.rad_BDE.Tag = "BDE";
            this.rad_BDE.Text = "Soon (BDE)";
            this.rad_BDE.UseVisualStyleBackColor = false;
            this.rad_BDE.Click += new System.EventHandler(this.radioChange);
            // 
            // rad_SBL
            // 
            this.rad_SBL.AutoSize = true;
            this.rad_SBL.BackColor = System.Drawing.Color.Transparent;
            this.rad_SBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.rad_SBL.ForeColor = System.Drawing.Color.White;
            this.rad_SBL.Location = new System.Drawing.Point(770, 289);
            this.rad_SBL.Name = "rad_SBL";
            this.rad_SBL.Size = new System.Drawing.Size(124, 26);
            this.rad_SBL.TabIndex = 5;
            this.rad_SBL.Tag = "SBL";
            this.rad_SBL.Text = "Soon (SBL)";
            this.rad_SBL.UseVisualStyleBackColor = false;
            this.rad_SBL.Click += new System.EventHandler(this.radioChange);
            // 
            // PicB_SBL
            // 
            this.PicB_SBL.BackColor = System.Drawing.Color.Transparent;
            this.PicB_SBL.Image = global::Project_1_SimpleCalculetor.Properties.Resources.book;
            this.PicB_SBL.Location = new System.Drawing.Point(770, 163);
            this.PicB_SBL.Name = "PicB_SBL";
            this.PicB_SBL.Size = new System.Drawing.Size(124, 120);
            this.PicB_SBL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicB_SBL.TabIndex = 5;
            this.PicB_SBL.TabStop = false;
            this.PicB_SBL.Tag = "5";
            this.PicB_SBL.Click += new System.EventHandler(this.ClickedOnPicture);
            // 
            // PicB_BDE
            // 
            this.PicB_BDE.BackColor = System.Drawing.Color.Transparent;
            this.PicB_BDE.Image = global::Project_1_SimpleCalculetor.Properties.Resources.data_entry;
            this.PicB_BDE.Location = new System.Drawing.Point(618, 163);
            this.PicB_BDE.Name = "PicB_BDE";
            this.PicB_BDE.Size = new System.Drawing.Size(127, 120);
            this.PicB_BDE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicB_BDE.TabIndex = 4;
            this.PicB_BDE.TabStop = false;
            this.PicB_BDE.Tag = "4";
            this.PicB_BDE.Click += new System.EventHandler(this.ClickedOnPicture);
            // 
            // PicB_Calculate
            // 
            this.PicB_Calculate.BackColor = System.Drawing.Color.Transparent;
            this.PicB_Calculate.Image = global::Project_1_SimpleCalculetor.Properties.Resources.Icono_Calculadora_Blue;
            this.PicB_Calculate.Location = new System.Drawing.Point(12, 170);
            this.PicB_Calculate.Name = "PicB_Calculate";
            this.PicB_Calculate.Size = new System.Drawing.Size(112, 113);
            this.PicB_Calculate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicB_Calculate.TabIndex = 3;
            this.PicB_Calculate.TabStop = false;
            this.PicB_Calculate.Tag = "0";
            this.PicB_Calculate.Click += new System.EventHandler(this.ClickedOnPicture);
            // 
            // PicB_Books
            // 
            this.PicB_Books.BackColor = System.Drawing.Color.Transparent;
            this.PicB_Books.Image = global::Project_1_SimpleCalculetor.Properties.Resources.Uma_pilha_de_livros____Vetor_Premium;
            this.PicB_Books.Location = new System.Drawing.Point(472, 163);
            this.PicB_Books.Name = "PicB_Books";
            this.PicB_Books.Size = new System.Drawing.Size(125, 120);
            this.PicB_Books.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicB_Books.TabIndex = 2;
            this.PicB_Books.TabStop = false;
            this.PicB_Books.Tag = "3";
            this.PicB_Books.Click += new System.EventHandler(this.ClickedOnPicture);
            // 
            // PicB_ToDoList
            // 
            this.PicB_ToDoList.BackColor = System.Drawing.Color.Transparent;
            this.PicB_ToDoList.Image = global::Project_1_SimpleCalculetor.Properties.Resources.List_free_icons_designed_by_Freepik;
            this.PicB_ToDoList.Location = new System.Drawing.Point(351, 163);
            this.PicB_ToDoList.Name = "PicB_ToDoList";
            this.PicB_ToDoList.Size = new System.Drawing.Size(115, 120);
            this.PicB_ToDoList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicB_ToDoList.TabIndex = 1;
            this.PicB_ToDoList.TabStop = false;
            this.PicB_ToDoList.Tag = "2";
            this.PicB_ToDoList.Click += new System.EventHandler(this.ClickedOnPicture);
            // 
            // PicB_UserInputTable
            // 
            this.PicB_UserInputTable.BackColor = System.Drawing.Color.Wheat;
            this.PicB_UserInputTable.Cursor = System.Windows.Forms.Cursors.Default;
            this.PicB_UserInputTable.Image = global::Project_1_SimpleCalculetor.Properties.Resources.table;
            this.PicB_UserInputTable.Location = new System.Drawing.Point(156, 170);
            this.PicB_UserInputTable.Name = "PicB_UserInputTable";
            this.PicB_UserInputTable.Size = new System.Drawing.Size(169, 113);
            this.PicB_UserInputTable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicB_UserInputTable.TabIndex = 0;
            this.PicB_UserInputTable.TabStop = false;
            this.PicB_UserInputTable.Tag = "1";
            this.PicB_UserInputTable.Click += new System.EventHandler(this.ClickedOnPicture);
            // 
            // Form_ProgramSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(906, 487);
            this.Controls.Add(this.rad_SBL);
            this.Controls.Add(this.rad_BDE);
            this.Controls.Add(this.rad_Books);
            this.Controls.Add(this.rad_ToDoList);
            this.Controls.Add(this.rad_UserInputTable);
            this.Controls.Add(this.rad_Calculetor);
            this.Controls.Add(this.butSubmet);
            this.Controls.Add(this.Labe_ShowScreenChoice);
            this.Controls.Add(this.PicB_SBL);
            this.Controls.Add(this.PicB_BDE);
            this.Controls.Add(this.PicB_Calculate);
            this.Controls.Add(this.PicB_Books);
            this.Controls.Add(this.PicB_ToDoList);
            this.Controls.Add(this.PicB_UserInputTable);
            this.Name = "Form_ProgramSelection";
            this.Text = "Program Selection";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicB_SBL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicB_BDE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicB_Calculate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicB_Books)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicB_ToDoList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicB_UserInputTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicB_UserInputTable;
        private System.Windows.Forms.PictureBox PicB_ToDoList;
        private System.Windows.Forms.PictureBox PicB_Books;
        private System.Windows.Forms.PictureBox PicB_Calculate;
        private System.Windows.Forms.PictureBox PicB_BDE;
        private System.Windows.Forms.PictureBox PicB_SBL;
        private System.Windows.Forms.Label Labe_ShowScreenChoice;
        private System.Windows.Forms.Button butSubmet;
        private System.Windows.Forms.RadioButton rad_Calculetor;
        private System.Windows.Forms.RadioButton rad_UserInputTable;
        private System.Windows.Forms.RadioButton rad_ToDoList;
        private System.Windows.Forms.RadioButton rad_Books;
        private System.Windows.Forms.RadioButton rad_BDE;
        private System.Windows.Forms.RadioButton rad_SBL;
    }
}