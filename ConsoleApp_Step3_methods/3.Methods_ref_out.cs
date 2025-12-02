using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefAndOutContainer
{
     class Program
    {
      static void Main()
        {
            int number1 = 0;
            bool status1 = false;
            string eName1 = null;

            //NormalMethod(number1, status1, eName1);
            Console.WriteLine($"Before method ID - {number1} , Status {status1} , eName {eName1}");

            RefParameterValuesMethod(ref number1, ref status1, ref eName1);

            Console.WriteLine($"After method ID - {number1} , Status {status1} , eName {eName1}");


            int number2;
            bool status2;
            string eName2;
            //RefParameterValuesMethod(ref number2, ref status2, ref eName2);
            OutParameterValuesMethod(out number2, out status2, out eName2);
            Console.WriteLine($"After method ID - {number2} , Status {status2} , eName {eName2}");

            int number = 0;
            bool IsSuccess = false;
            TryParseIntMethod("C#.net", ref number, out IsSuccess);
            Console.WriteLine($"After method ID - {number} , Status {IsSuccess}");



        }

        static void NormalMethod(int id, bool status, string ename)
        {
            id = 10;
            status = true;
            ename = "Raju";
        }

        static void RefParameterValuesMethod(ref int id, ref bool status, ref string ename)
        {
            id = 10;
            status = true;
            ename = "Raju";
        }

        static void OutParameterValuesMethod(out int id, out bool status, out string ename)
        {
            id = 10;
            status = true;
            ename = "Raju";
        }

        //TryParse out parameter


        //incase input successfully convert into int ---> true otherwise false
        static void TryParseIntMethod(string input, ref int number, out bool IsSuccess)
        {
            //int result;
            bool isStatus = int.TryParse(input, out number);
            //result  -- 10;
            //isStatus  -- true
            if (isStatus)
            {
                IsSuccess = true;
            }
            else
            {
                number = 0;
                IsSuccess = false;
            }
        }


    }
}
