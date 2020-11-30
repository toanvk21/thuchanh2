using System;
using System.Net.Http.Headers;
using System.Runtime.InteropServices.ComTypes;

namespace bai_4
{
    class Dathuc
    {
        private int bac;
        private int[] a;
        public Dathuc()
        {
            bac = 0;
            a = new int[0];
        }
        public Dathuc(int bac)
        {
            this.bac = bac;
            a = new int[bac];
        }
        public void nhap()
        {
            for (int i = 0; i < bac; i++)
            {
                Console.Write("{0}"+i);
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        public void hien()
        {
            for (int i = 0; i < bac; i++)
            {
                Console.WriteLine("{0}",a[i]);
                Console.WriteLine();
            }
        }
        public Dathuc tong(Dathuc t2)
        {
            if (this.bac == t2.bac)
            {
                Dathuc t = new Dathuc(this.bac);
                for (int i = 0; i < bac; i++)
                {
                    t.a[i] = this.a[i] + t2.a[i];
                }
                return t;
            }
            else return null;
        }
        public Dathuc hieu(Dathuc t2)
        {
            if (this.bac == t2.bac)
            {
                Dathuc t = new Dathuc(this.bac);
                for (int i = 0; i < bac; i++)
                {
                    t.a[i] = this.a[i] - t2.a[i];
                }
                return t;
            }
            else return null;
        }
    }
    class test
    { 
        static void Main(string[] args)
        {
            Dathuc t1 = new Dathuc(2);
            t1.nhap(); Console.WriteLine("cac he so dt 1");t1.hien();
            Dathuc t2 = new Dathuc(2);
            t2.nhap(); Console.WriteLine("cac he so dt 2"); t2.hien();
            Dathuc t3 = t1.tong(t2);
            Dathuc t4 = t1.tong(t3);
            if (t3==null)
            {
                Console.WriteLine("2 dt khac bac");
            }
            else
                Console.WriteLine("tong 2 dt");
            t3.hien();
            if (t4==null)
            {
                Console.WriteLine("2 da thuc khac bac");
            }
            else
                Console.WriteLine("hieu 2 dt");
            t4.hien();
            Console.ReadKey();
        }
    }
}
