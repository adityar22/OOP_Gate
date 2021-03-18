using System;

namespace Gate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Gate!");

            kerajaan raja = new kerajaan();
            kosakata kata = new kosakata();

            int option = 0;
            while(option != -1){
                Console.WriteLine("\n");
                Console.WriteLine("1. List Kerajaan & Raja");
                Console.WriteLine("2. Cari Raja");
                Console.WriteLine("3. Cari Kosakata");
                Console.WriteLine("Ketik -1 untuk berhenti");
                Console.WriteLine("Masukkan nomor menu yang dipilih: ");
                option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");

                switch (option)
                {
                    case 1:
                        raja.raja_show();
                        break;
                    case 2:
                        raja.raja_search();
                        break;
                    case 3:
                        kata.kata_search();
                        break;
                    default:
                        break;
                }
                
            }
        }
    }
}
