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

        public void StartProce(ListView  AddToList, string Text_1, string Text_2,Button Type) 
        {


            ListViewItem NewList = new ListViewItem(RandomID().ToString());
            NewList.SubItems.Add(Text_1);
            NewList.SubItems.Add(Text_2);



            AddToList.Items.Add(NewList);
            




        }



    }
}
