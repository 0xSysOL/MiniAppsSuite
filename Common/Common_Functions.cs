using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1_SimpleCalculetor
{
    internal class Common_Functions
    {

        public static void Notification(NotifyIcon Get_NFI, string Title, string Text, int timeout)
        {
           
            Get_NFI.BalloonTipTitle = Title;
            Get_NFI.BalloonTipText = Text;
            Get_NFI.Icon = SystemIcons.Error;
            Get_NFI.ShowBalloonTip(timeout);

        }
        public static void BackToProgramSelection(Form ProgramForm,Form SelectionPrograms) 
        {

            ProgramForm.Close();
            SelectionPrograms.Show();
        
        }

    }
}
