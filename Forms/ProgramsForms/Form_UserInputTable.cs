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
        private Form CurrentForm;
        public Form_UserInputTable(Form getProgramSele_Form)
        {
            InitializeComponent();
             CurrentForm = getProgramSele_Form;

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

            } else if (Logic_Proce.TypeButton((Button)sender) == "edit" && listView.Items.Count > 0)
            {
                errorProvider.Clear();
                Logic_Proce.StartProce(listView, TB_FirstName.Text, TB_LastName.Text, (Button)sender);
            }
            else
            {

                if (Logic_Proce.IsTextEmpty(TB_FirstName.Text))

                {
                    errorProvider.SetError(TB_FirstName, "Please enter Your First Name");
                    Common_Functions.Notification(notifyIcon, "Error", "Enter First Name", 1000);
                }
                else
                {
                    errorProvider.SetError(TB_LastName, "Please enter Your Last Name");
                    Common_Functions.Notification(notifyIcon, "Error", "Enter Last Name", 1000);
                }

            }




        }

        private void Text_FN_LN(object sender, CancelEventArgs e)
        {

        }

        private void But_Exit(object sender, EventArgs e)
        {
            Common_Functions.BackToProgramSelection(this, CurrentForm);
        }
    }
}
