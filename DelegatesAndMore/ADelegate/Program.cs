using System;

namespace ADelegate
{
    /// <summary>
    /// A delegate is a type that represents references to methods with a particular parameter list and return type.
    /// When you instantiate a delegate, you can associate its instance with any
    /// method with a compatible signature and return type. 
    /// You can invoke (or call) the method through the delegate instance.
    /// </summary>
    class Program
    {
        delegate int NumberChanger(int n);
        static void Main(string[] args)
        {
            int num = 10;

            int AddNum(int p)
            {
                num += p;
                return num;
            }
            int MultNum(int q)
            {
                num *= q;
                return num;
            }
            int getNum()
            {
                return num;
            }

            //create delegate instances - not invoking
            NumberChanger nc1 = new NumberChanger(AddNum);
            NumberChanger nc2 = new NumberChanger(MultNum);

            //calling the methods using the delegate objects
            nc1(25);
            Console.WriteLine("Value of Num: {0}", getNum());
            nc2(5);
            Console.WriteLine("Value of Num: {0}", getNum());


            // Multicasting of a Delegate

            NumberChanger nc;

            nc = nc1;
            nc += nc2;

            // nc contains both events

            nc(5);
            Console.WriteLine("Value of Num: {0}", getNum());
            Console.ReadKey();
        }
    }
}
