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
    public partial class Form_UserInputTable : Form
    {
        public Form_UserInputTable()
        {
            InitializeComponent();
        }
        Logic_UserInputTable Logic_Proce = new Logic_UserInputTable();

        private void Form_UserInputTable_Load(object sender, EventArgs e)
        {

        }

        private void ButtChecked(object sender, EventArgs e)
        {

            if (!Logic_Proce.IsTextBoxesEmpty(TB_FirstName.Text, TB_LastName.Text))
            {
                errorProvider.Clear();

                Logic_Proce.StartProce(listView, TB_FirstName.Text, TB_LastName.Text, (Button)sender);
            
            }
            else
            {
                errorProvider.SetError(TB_FirstName, "Please enter Your First Name");
                errorProvider.SetError(TB_LastName, "Please enter Your Last Name");
            }




        }

        private void Text_FN_LN(object sender, CancelEventArgs e)
        {

        }
    }
}
