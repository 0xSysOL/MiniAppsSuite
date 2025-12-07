using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1_SimpleCalculetor.Logical.ProgramsFormsLogic
{


    internal class Logic_UserInputTable
    {

      private int RandomID() 
        {
            Random GetID = new Random();
            
            return GetID.Next(30000);

        }

        public bool IsTextBoxesEmpty(string Text_1,string Text_2) 
        {

            return (Text_1 == "" && Text_2 == "") ? true : false;

            
        }

        public string TypeButton(Button Type) 
        {

            return (Type.Tag.ToString() == "add") ? "add" : (Type.Tag.ToString() == "remove") ? "remove" : "edit";

        }

       private bool IsUserSelectedOnItem(ListView GetList) 
        {

            return GetList.SelectedItems.Count > 0;
        }
        private bool IsItemEmpty(ListView GetList)
        {

            return GetList.Items.Count > 0;
        }


        public void StartProce(ListView List, string Text_1, string Text_2, Button Type)
        {
            

            switch (Type.Tag)
            {

                case "add":
                    ListViewItem NewList = new ListViewItem(RandomID().ToString());
                    NewList.SubItems.Add(Text_1);
                    NewList.SubItems.Add(Text_2);
                    List.Items.Add(NewList);
                    
                    break;

                case "remove":

                    if (IsUserSelectedOnItem(List)&&IsItemEmpty(List))
                        List.Items.Remove(List.SelectedItems[0]);


                    break;

                case "edit":

                    if (IsUserSelectedOnItem(List) && IsItemEmpty(List))
                    {
                        List.SelectedItems[0].SubItems[1].Text = Text_1;
                        List.SelectedItems[0].SubItems[2].Text = Text_2;
                    }
                    break;
            

            }




        }



    }
}
