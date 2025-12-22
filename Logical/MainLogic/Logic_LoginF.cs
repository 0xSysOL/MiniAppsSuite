using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1_SimpleCalculetor.Logical
{
    internal class Logic_LoginF
    {

        public void Proce_Login(string UserName,string Password,Form GetCurrent) 
        {



            if ((UserName == "Admin" && Password == "1234") || true) 
            {
                Form_ProgramSelection ProgramSelection = new Form_ProgramSelection();
                GetCurrent.Hide();
                ProgramSelection.Show();
            }



        }


    }
}
