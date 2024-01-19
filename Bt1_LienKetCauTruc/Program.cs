using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bt1_LienKetCauTruc
{
    class Node
    {
        private int info;
        private Node next;



        public Node(int x)
        {
            info = x;
            next = null;
        }
        public int InFo
        {
            set { info = value; }
            get { return info; }
        }
        public Node Next
        {
            set { next = value; }
            get { return next; }
        }


        class DSLienKetDon
        {
            private Node Head;

            public DSLienKetDon()
            {
                Head = null;
            }
            public void ThemDau(int x)
            {
                Node q = new Node(x);

                q.Next = Head;
                Head = q;
            }
            public void ThemCui(int x)
            {
                Node p = new Node(x);
                if (Head == null)
                {
                    Head = p;
                }
                else
                {
                    Node q = Head;
                    while (q.Next != null)
                    {
                        q = q.Next;
                    }

                    q.Next = p;

                }
            }
            public void Xuat()
            {
                Node p = Head;
                while (p != null)
                {
                    Console.WriteLine($"{p.info}");
                    p = p.Next;
                }

            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                DSLienKetDon ds = new DSLienKetDon();
                Console.WriteLine("Xuat Danh sach");
                ds.ThemDau(8);
                ds.ThemDau(5);
                ds.ThemDau(7);
                ds.ThemCui(9);
                ds.Xuat();
                Console.ReadLine();
            }
        }
    }
}

