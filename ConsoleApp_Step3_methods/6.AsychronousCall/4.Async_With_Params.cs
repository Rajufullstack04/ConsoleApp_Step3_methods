using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAsyncContainer
{
    class UserAsyncClass
    {
        //
        public static async Task Main()
        {
            //int id      = await UserAsyncClass.GetStudnetID();

            //string name = await UserAsyncClass.GetStudnetName();

            //bool isMerit = await UserAsyncClass.isMeritStudent();

            Task<int> studentIDTask = UserAsyncClass.GetStudnetID();
            Task<string> studentNameTask = UserAsyncClass.GetStudnetName();
            Task<bool> studentIsMeritTask = UserAsyncClass.isMeritStudent();

            await Task.WhenAll(studentIDTask, studentNameTask, studentIsMeritTask);

            int id = studentIDTask.Result;
            string name = studentNameTask.Result;

            //name._____________   = "john";
            bool isMerit = studentIsMeritTask.Result;

            Console.WriteLine(id);
            Console.WriteLine(name);
            Console.WriteLine(isMerit);


        }


        //Defination
        public static async Task<int> GetStudnetID()
        {
            //  i have the db record 
            await Task.Delay(5000);
            return 101;
            // i want to resutnr 101
        }

        //Defaintion
        public static async Task<string> GetStudnetName()
        {
            //  i have the db record 
            await Task.Delay(10000);
            return "peter";
            // i want to resutnr 101
        }


        public static async Task<bool> isMeritStudent()
        {
            //  i have the db record 
            await Task.Delay(8000);
            return false;
            // i want to resutnr 101
        }



        //Synchrounc call
        public static async Task<int> GetStudnetAge()
        {
            //  i have the db record 
            //await Task.Delay(1000000);
            return 20;
            // i want to resutnr 101
        }

        //public static int GetStudnetAge()
        //{
        //    //  i have the db record 
        //    //await Task.Delay(1000000);
        //    return 20;
        //    // i want to resutnr 101
        //}
    }
}