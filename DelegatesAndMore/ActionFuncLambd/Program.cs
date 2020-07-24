using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionFuncLambd
{
    class Program
    {
        public delegate int Manipulate(int a);

        // Action is a delegate
        public delegate void MyFristAction();

        // Func is a delegate with a return type
        // public delegate int MyFunc();

        static void Main(string[] args)
        {
            Manipulate lambdaDelegate = a => a * 2;
            var result = lambdaDelegate(5);

            MyFristAction myFirstAction = () => { var a = 2; };

            // An action is a delegate with no return type and optional input
            Action myAction = () => { lambdaDelegate(2); };
            Action<int> myScnAction = (a) => { var c = a * 2; };


            // A Func is a delegate with a return type
            Func<int> myFunc = () => 2;

            // Replace Manipulate with a Func
            Func<int, int> funcDelegate = a => a * 2;
            var funcResult = funcDelegate(5);
        }
    }
}
