using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class laba2_agr_po_znach
    {
        class A
        {
            public A() { c.c1 = 35; }
            ~A() { }

            public void mA() { Console.WriteLine("method of A"); }

            public B bA { get { Console.Write("get b ->"); return b; } }
            public C cA { get { Console.Write("get c ->"); return c; } }
            public J jA { get { Console.Write("get j ->"); return j; } }

            private B b = new B();
            private C c = new C();
            private J j = new J();
        }

        class B
        {
            public B() { }
            ~B() { }

            public void mB() { Console.WriteLine("method of B"); }

            public D dA { get { Console.Write("get d ->"); return d; } }
            public K kA { get { Console.Write("get k ->"); return k; } }
            private D d = new D();
            private K k = new K();
        }

        class C
        {
            public C() { this.c1 = 15; }
            public void mC() { Console.WriteLine("method of C"); }

            public E eA { get { Console.Write("get e ->"); return e; } }
            public F fA { get { Console.Write("get f ->"); return f; } }
            
            private E e = new E();
            private F f = new F();
            public int c1 { get; set; }
        }

        class D
        {
            public D() { }
            public void mD() { Console.WriteLine("method of D"); }
        }

        class E
        {
            public E() { }
            public void mE() { Console.WriteLine("method of E"); }
        }

        class F
        {
            public F() { }
            public void mF() { Console.WriteLine("method of F"); }

        }

        class J
        {
            public J() { }

            public void mJ() { Console.WriteLine("method of J"); }
        }
        class K
        {
            public K() { }

            public void mK() { Console.WriteLine("method of K"); }
        }

        
        
        static void Main(string[] args)
        {
            A a = new A();

            a.mA();
            a.bA.mB();
            a.cA.mC();
            a.jA.mJ();

            a.bA.dA.mD();

            a.cA.eA.mE();
            a.cA.fA.mF();
            a.bA.kA.mK();

            Console.ReadKey();
        }
    }
}
