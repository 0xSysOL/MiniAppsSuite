using Project_1_SimpleCalculetor.Logical;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1_SimpleCalculetor
{



    public partial class Form_ProgramSelection : Form
    {
        public Form_ProgramSelection()
        {
            InitializeComponent();
        }
      private  Logic_ProgramSelection _LogicProgramSelection = new Logic_ProgramSelection();
      private  RadioButton get = new RadioButton();
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private enum _programs
        { calculate = 0, user_input_table = 1, to_do_list = 2, books = 3, b_d_e = 4, s_b_l = 5 };
        public void Proc_WithRadioWeWantToChoose(PictureBox sender)
        {

            short index = Convert.ToInt16(sender.Tag);
            switch ((_programs)index)
            {

                case _programs.calculate:

                   
                    _LogicProgramSelection.changeRadios(rad_Calculetor,ref get);
                    break;

                case _programs.user_input_table:

                    _LogicProgramSelection.changeRadios(rad_UserInputTable,ref get);

                    break;
                case _programs.to_do_list:

                    _LogicProgramSelection.changeRadios(rad_ToDoList,ref get);

                    break;
                case _programs.books:

                    _LogicProgramSelection.changeRadios(rad_Books,ref get);

                    break;
                case _programs.b_d_e:

                    _LogicProgramSelection.changeRadios(rad_BDE,ref get);

                    break;

                case _programs.s_b_l:

                    _LogicProgramSelection.changeRadios(rad_SBL,ref get);

                    break;

            }
        }


        private void radioChange(object sender, EventArgs e)
        {


            if(sender.ToString().Contains("PictureBox")) 
            {
                
                Proc_WithRadioWeWantToChoose((PictureBox)sender);
                return;



            }

            get = _LogicProgramSelection.ChangeRadio(sender);

            if (Convert.ToBoolean(butSubmet.Tag) == true)
            {
                _LogicProgramSelection.Proc_WitchProgramWeWantToRun(get.TabIndex,this);
            }
            butSubmet.Tag = false;

        }
        private void butSubmet_Click(object sender, EventArgs e)
        {

            butSubmet.Tag = true;
            radioChange(get, e);

        }

        private void ClickedOnPicture(object sender, EventArgs e)
        {
            radioChange(sender, e);

        }

        
    }
}
