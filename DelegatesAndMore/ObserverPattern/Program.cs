using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Signal
    {
        public Action TrainsAreComing;
        public void HeresComesATrain()
        {
            TrainsAreComing();
        }
    }
    class Car
    {
        public Car(Signal trainSignal)
        {
            trainSignal.TrainsAreComing += StopTheCar;
        }
        private void StopTheCar()
        {
            Console.WriteLine("Stop");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Creating a new delegate of TrainSignal
            Signal trainSignal = new Signal();

            new Car(trainSignal);
            //
            Car a = new Car(trainSignal);
            Car b = new Car(trainSignal);
            Car c = new Car(trainSignal);

            //Calling the HereComesATrain method 
            trainSignal.HeresComesATrain();
            //Invokes the StopTheCar Method
        }
    }
}
