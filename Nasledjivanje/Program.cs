using BusinessLogicLayer;
using DataAccessLayer;
using DataAccessLayer.Repository;
using DataAccessLayer.Repository.Implementations;
using System;

namespace Nasledjivanje
{
    public class A
    {
        public virtual void Print()
        {
            Console.WriteLine("A");
        }
    }

    public class B : A
    {
        public override void Print()
        {
            Console.WriteLine("B");
        }
    }

    public class C : B
    {
        public new void Print()
        {
            Console.WriteLine("C");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //A a = new A();
            //A b = new B();
            A c = new C();
            //a.Print();
            //b.Print();
            c.Print();

            IZaposleniService zaposleni = new ZaposleniService(new InMemUnitOfWork());

            Console.ReadKey();
        }
    }
}
