using Project_1_SimpleCalculetor.Logical.ProgramsFormsLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1_SimpleCalculetor.Forms.ProgramsForms
{
    public partial class Form_To_Do_List : Form
    {
        private Form CurrentForm;
        public Form_To_Do_List(Form getProgramSele_Form)
        {
            InitializeComponent();
            CLB_AddTasktoList.Items.RemoveAt(0);
             CurrentForm = getProgramSele_Form;

        }

        Logic_To_Do_List Logic_TDL = new Logic_To_Do_List();
    



        private void Clicked(object sender, EventArgs e)
        {
            Button Btn = (Button)sender;
            Logic_TDL.Start_Proce(Btn,TB_AddedTasks,CLB_AddTasktoList,notifyIcon);

        }

        private void Form_To_Do_List_Load(object sender, EventArgs e)
        {

        }

        private void But_eixt(object sender, EventArgs e)
        {
            Common_Functions.BackToProgramSelection(this,CurrentForm);
        }
    }
}
