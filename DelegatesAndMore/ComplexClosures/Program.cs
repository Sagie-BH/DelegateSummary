using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeperatedActions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Each action got her own values for GiveMeAction
            Action a = GiveMeAction();
            Action b = GiveMeAction();
            b(); a(); a(); a(); b();

        }
        /// <summary>
        /// The Compilier builds a class in the backgroud to hold the properties and methods.
        /// 
        /// </summary>
        class CompilierBussines
        {
            int i = 5;

            public void NoNameMethod()
            {
                i++;
            }
            public void NoNameScnMethod()
            {
                i += 2;
            }
        }

        private static Action GiveMeAction()
        {
            Action ret = null;

            var temp = new CompilierBussines();

            ret += temp.NoNameMethod;
            ret += temp.NoNameScnMethod;

            //int i = 5;

            //ret += () => i++;
            //ret += () => i += 2;
            return ret;
        }
    }
}
