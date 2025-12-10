using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1_SimpleCalculetor.Logical.ProgramsFormsLogic
{
    internal class Logic_To_Do_List
    {

        private bool AddTask(TextBox T_Box) 
        {

            if (T_Box.Text != "") 
            {
                
                return true;

            }

            return false;
           

        }
        private void ComplateTasks(CheckedListBox CLB) 
        {
        

        }
        private void DeleteTasks(CheckedListBox CLB) 
        {
        
        }
        public void Start_Proce(Button Btn,TextBox T_Box,CheckedListBox CLB) 
        {

            switch (Btn.Tag) 
            {

                case "Add":
                    
                    AddTask(T_Box);

                break;

                case "Complated":

                    ComplateTasks(CLB);
                break;


                case "Delete":

                    DeleteTasks(CLB);

                break;



            }



        }



    }
}
