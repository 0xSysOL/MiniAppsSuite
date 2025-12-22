using Project_1_SimpleCalculetor.Forms.ProgramsForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1_SimpleCalculetor.Logical
{
    internal class Logic_ProgramSelection
    {


        private  enum _programs 
        { calculate = 0,user_input_table =1,to_do_list=2,books=3,b_d_e=4,s_b_l=5 };
        private void _HideForm(Form HideForm) 
        {

            HideForm.Hide();
    
        }
        public RadioButton ChangeRadio(object sender) 
        {
        
        
            return (RadioButton)sender;
        }
        public void changeRadios(RadioButton get_Radio,ref RadioButton current_radio)
        {


            current_radio.BackColor = Color.Transparent;
            
            get_Radio.Checked = true;
            current_radio = get_Radio;

            get_Radio.BackColor = Color.DarkGreen;

        }



        public void Proc_WitchProgramWeWantToRun(int Index, Form HideForm) 
        {

            switch ((_programs)Index) 
            {


                case _programs.calculate:

                    Form_CalculateApp ShowCalculateForm = new Form_CalculateApp(HideForm);
                    ShowCalculateForm.Show();
                    _HideForm(HideForm);
                    break;
                     
                case _programs.user_input_table:

                    Form_UserInputTable ShowUserInputTable = new Form_UserInputTable(HideForm);
                    ShowUserInputTable.Show();
                    _HideForm(HideForm);
                    break;

                case _programs.to_do_list:

                    Form_To_Do_List Show_To_Do_ListForm = new Form_To_Do_List(HideForm);
                    Show_To_Do_ListForm.Show();
                    _HideForm(HideForm);
                     

                    break;
               
                case _programs.books:

                    Form_Library Show_LibraryForm = new Form_Library(HideForm);
                    Show_LibraryForm.Show();
                    _HideForm(HideForm);
                   

                    break;
                
                case _programs.b_d_e:
                    // soon

                    break;
                
                case _programs.s_b_l:
                    // soon

                    break;



            }



        }



      







        }



    }

