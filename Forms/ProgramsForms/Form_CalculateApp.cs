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
    public partial class Form_CalculateApp : Form
    {
        private Form CurrentForm;
        public Form_CalculateApp(Form getProgramSele_Form)
        {
            InitializeComponent();
            button0.Tag = (Byte)0;
            button1.Tag = (Byte)1;
            button2.Tag = (Byte)2;
            button3.Tag = (Byte)3;
            button4.Tag = (Byte)4;
            button5.Tag = (Byte)5;
            button6.Tag = (Byte)6;
            button7.Tag = (Byte)7;
            button8.Tag = (Byte)8;
            button9.Tag = (Byte)9;
            button_Mul.Tag = (char)'*';
            button_Div.Tag = (char)'/';
            button_Sub.Tag = (char)'-';
            button_Add.Tag = (char)'+';
            CurrentForm = getProgramSele_Form;
        }

        Logic_CalculateApp clsStart = new Logic_CalculateApp();
       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void EnterValue(object sender, EventArgs e)
        {

            TB_ShowOperations.Text += ((Button)sender).Tag;


        }


        private void EnterOperation(object sender, EventArgs e)
        {

            TB_ShowOperations.Text += ((Button)sender).Tag.ToString();


        }

        private void BTN_Clear_Click(object sender, EventArgs e)
        {
            TB_ShowOperations.Text = "";

        }

        private void button_Eq_Click(object sender, EventArgs e)
        {

            
            long Result = clsStart.StartOperation_Calculator(TB_ShowOperations.Text);
            if (Result != -1) 
            {
                TB_ShowOperations.Text = Result.ToString();
            }
            else 
            {
                            TB_ShowOperations.Text = "Error";
                Common_Functions.Notification(notifyIcon_Calculate, "Error", "Syntax Error", 1000);
          

            }
            
        }

        private void But_Exit(object sender, EventArgs e)
        {
            Common_Functions.BackToProgramSelection(this,CurrentForm);
        }
    } 
}
