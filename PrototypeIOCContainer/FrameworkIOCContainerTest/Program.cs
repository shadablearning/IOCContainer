using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrameworkIOCContainer.Core;

namespace FrameworkIOCContainerTest
{
    interface ITest1
    {
        void Print();
    }

    class ClassTest1 : ITest1
    {
        public void Print()
        {
            Console.WriteLine("ClassName: {0}, HashCode: {1}", this.GetType().Name, this.GetHashCode());
        }
    }

    class ClassTest2 : ITest1
    {
        public void Print()
        {
            Console.WriteLine("ClassName: {0}, HashCode: {1}", this.GetType().Name, this.GetHashCode());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IContainer container = new FrameworkIOCContainer.Container();

            // testing instance type resigtration for class
            Console.WriteLine("testing instance type resigtration for class");
            container.RegisterInstanceType<ITest1, ClassTest1>();

            //Now Resolve the Object
            ITest1 obj1 = container.Resolve<ITest1>();

            Console.ReadLine();
        }
    }
}
