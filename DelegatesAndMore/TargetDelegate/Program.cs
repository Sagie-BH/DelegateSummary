using System;

namespace TargetDelegate
{
    /// <summary>
    /// A delegate keeps track of two things - A Method & A Target
    /// </summary>
    /// <param name="anyInt"></param>
    delegate void MeDelegate(int anyInt);
    class Target
    {
        static void Main(string[] args)
        {
            MeDelegate d = Poo;

            Console.WriteLine(d.Target);
            Console.WriteLine(d.Method);
            //Output:
            //                 - No object
            //Void Poo(int32)  - Shows invoking method and parameters

            Target target = new Target();

            target.Hoo(7);

            d = target.Hoo;

            Console.WriteLine(d.Method);
            Console.WriteLine(d.Target);
            //Output:   //Void Hoo(int32) - Shows invoking method and parameters
            //TargetDelegate         - Shows targeted object ("d") class name ("Target") 
        }

        void Hoo(int b) { }

        static void Poo(int num) { }
    }
}

