using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1_SimpleCalculetor.Logical.ProgramsFormsLogic
{
    internal class Logic_CalculateApp
    {

        private enum _enumOperation { Add = '+', Sub = '-', Mul = '*', Div = '/' };
        private int _Side_1 = 0;
        private int _Side_2 = 0;
        private char _Operation = ' ';
        private char _Operations(char Oper)
        {


            return Oper == '+' ? '+' : Oper == '-' ? '-' : Oper == '*' ? '*' : Oper == '/' ? '/' : '?';

        }

        private long _StartProce()
        {

            switch (_Operation)
            {

                case (char)_enumOperation.Add:
                    return _Side_1 + _Side_2;

                case (char)_enumOperation.Sub:
                    return _Side_1 - _Side_2;

                case (char)_enumOperation.Mul:
                    return _Side_1 * _Side_2;

                case (char)_enumOperation.Div:
                    return (_Side_2 != 0) ? _Side_1 / _Side_2 : -1;




            }

            return 0;
        }


        private bool AddValue(string Text, int LengthSide)
        {

            if (LengthSide == 0) return false;

            string Side1 = Text.Substring(0, LengthSide);
            string Side2 = Text.Substring(LengthSide + 1);

            _Side_1 = Convert.ToInt32(Side1);
            _Side_2 = Convert.ToInt32(Side2);
            _Operation = Text[LengthSide];

            return true;
        }
        private bool IsNegetiveNumber(int Oper,int i, bool []arr,string Text) 
        {

            

            if (Text[i] == '-' && arr[i - 1] == false)
                return arr[i] = true;
            else
                return arr[i] = false;


        }

        private void FillArrOperation(bool[] arr, string Text)
        {

            int[] getLength = new int[arr.Length];
            for (int i = 0; i < Text.Length; i++)
            {

                if (_Operations(Text[i]) != '?' && i != 0) 
                {
                    arr[i] = true;
                    IsNegetiveNumber(getLength[i],i,arr,Text);

                }

            }

            if (Text[0] == '-')  arr[0] = false;



        }

        private bool Filter(bool[] arr)
        {

            bool Number_OR_Operation = true;

            int Stop = 0;

            if (arr[0] == true || arr[arr.Length-1] == true) return true;


            for (int i = 0; i < arr.Length; i++) {

                if (arr[i] == true)
                {
                    Stop++;
                    Number_OR_Operation = false;

                }
                else if (arr.Length - 1 == i && arr[i] == false) 
                {
                    Number_OR_Operation = false;
                }
                else 
                {          
                    Number_OR_Operation = (Stop != 1) ? true : false;

                }

            }
                
           




            return Number_OR_Operation;
        } 
        private bool FindErrorsInText(bool[]arr,string Text) 
        {

            if (
                (_Operations(Text[0]) != '?' && _Operations(Text[0]) != '-')
                || 
                _Operations(Text[Text.Length-1]) != '?') 
                return true;

                
            FillArrOperation(arr, Text);

            

            return Filter(arr);


        }

        public long StartOperation_Calculator(string Text)
        {


           
            int LengthSides = 0;
            bool[] ArrCountOperation = new bool[Text.Length];

            if (FindErrorsInText(ArrCountOperation,Text)) return -1;


            for (int i = 0; i < Text.Length; i++)
            {

                if (_Operations(Text[i]) != '?' && i != 0)
                {
                    LengthSides = i;
                    break;
                }

            }

            if (AddValue(Text, LengthSides))
            {
                return _StartProce();
            }

            return -1;

        }

   


    }
}
