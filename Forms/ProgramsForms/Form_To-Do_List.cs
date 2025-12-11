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
        public Form_To_Do_List()
        {
            InitializeComponent();
            CLB_AddTasktoList.Items.RemoveAt(0);
        }

        Logic_To_Do_List Logic_TDL = new Logic_To_Do_List();
    



        private void Clicked(object sender, EventArgs e)
        {
            Button Btn = (Button)sender;
            Logic_TDL.Start_Proce(Btn,TB_AddedTasks,CLB_AddTasktoList);

        }


    }
}
