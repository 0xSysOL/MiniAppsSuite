using Project_1_SimpleCalculetor.Forms.ProgramsForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1_SimpleCalculetor.Logical
{
    internal class LogicForm2
    {



        private void _HideForm(Form HideForm) 
        {

            HideForm.Hide();

        }

        public void Proce_WitchProgramWeNeedToRun(int Index, Form HideForm) 
        {

            switch (Index) 
            {


                case 0:
                    Form_CalculateApp ShowCalculateForm = new Form_CalculateApp();
                    ShowCalculateForm.Show();
                    _HideForm(HideForm);
                    break;

                case 1:
                    Form_UserInputTable ShowUserInputTable = new Form_UserInputTable();
                    ShowUserInputTable.Show();
                    _HideForm(HideForm);



                    break;

                case 2:

                    break;
               
                case 3:

                    break;
                
                case 4:

                    break;
                
                case 5:

                    break;



            }



        }





    }
}
