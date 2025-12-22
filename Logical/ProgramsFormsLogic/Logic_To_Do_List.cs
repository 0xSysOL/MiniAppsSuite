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

        private void AddTask(TextBox T_Box, CheckedListBox T_CLB, NotifyIcon GetN) 
        {

            if (T_Box.Text != "") 
            
                T_CLB.Items.Add(T_Box.Text, false);
            else 
             Common_Functions.Notification(GetN, "Error", "Plase Enter Task Name", 1000);
       
                          

            

        }
        private void ComplateTasks(CheckedListBox CLB) 
        {

           
            if (CLB.SelectedIndex >= 0 && CLB.GetItemChecked(CLB.SelectedIndex))
            {
                
                CLB.Items.RemoveAt(CLB.SelectedIndex);

            }
           
        }
        private void DeleteTasks(CheckedListBox CLB) 
        {


            if (CLB.SelectedIndex >= 0)
            {
                CLB.Items.RemoveAt(CLB.SelectedIndex);
                
            }
            

        }
        public bool Start_Proce(Button Btn,TextBox T_Box,CheckedListBox CLB,NotifyIcon GetN) 
        {

                switch (Btn.Tag) 
            {

                case "ADD_T":
                    
                    AddTask(T_Box, CLB,GetN);

                    break;

                case "Complated":

                    ComplateTasks(CLB);
                break;


                case "Delete":

                    DeleteTasks(CLB);

                break;



            }
            return false;


        }



    }
}
