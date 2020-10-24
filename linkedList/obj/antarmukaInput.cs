using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkedList
{
    class Interface
    {
        public LList p = new LList();

        int Length, Fill, NotFill, Start, Avail;

        public void MainMenu()
        {
            byte pil;
            bool x = true;

            while (x == true)
            {
                Console.Clear();
                Console.WriteLine("|=======LINKED LIST========|");
                p.ShowTable();
                p.ShowLlist(p.Start,"Start");
                p.ShowLlist(p.Avail, "Avail");
                Console.WriteLine("--------------------------");
                Console.WriteLine("1. Set dari kosong\n2. Penyisipan\n3. Exit");
                Console.Write("|Pilihan :");
                pil = Convert.ToByte(Console.ReadLine());
                switch (pil)
                {
                    case 1:
                        Reset();
                        break;
                    case 2:
                        Insert();
                        break;
                    case 3:
                        x = false;
                        break;
                    default:
                        Console.WriteLine("Input tidak dikenal!");
                        Console.ReadKey();
                        break;
                }
            }
        }

        void Reset()
        {
            //Constructor

            Console.WriteLine("|-SETUP");

            Console.Write("|-Panjang Linked List:");
            Length = Convert.ToInt16(Console.ReadLine());

            Console.Write("|-Banyak list yang akan diisi : ");
            Fill = Convert.ToInt16(Console.ReadLine());
            NotFill = Length - Fill;

            Console.Write("|-Start : ");
            Start = Convert.ToInt16(Console.ReadLine());

            Console.Write("|-Avail : ");
            Avail = Convert.ToInt16(Console.ReadLine());
 
            p = new LList(Length,Start,Avail);

            //Fill from Zero

            Console.WriteLine("--------------------------");
            Console.WriteLine("|-SETUP LINK");
            p.Setup(Fill, Start, false);
            Console.WriteLine("|-SETUP AVAIL");
            p.Setup(NotFill, Avail,true);
        }

        void Insert()
        {
            int Item;
            Console.WriteLine("|-INSFIRST");
            Console.Write("|-Item baru :");
            Item = Convert.ToInt16(Console.ReadLine());
            p.InsFirst(Item);
        }
    }
}
