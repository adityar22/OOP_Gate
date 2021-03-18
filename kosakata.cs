using System;
using System.IO;

namespace Gate
{
    public class kosakata                                                                                                                                                                            
    {
        public static string[] kamus_kata = new string[100];
        public static string[] arti_kata = new string[100];
        public static string text_space = @"/text/";

        public void kata_kamus(){
            StreamReader kamus = new StreamReader("kosakata.txt");
            string line = kamus.ReadLine();

            int i = 0;
            while (line != "-1")
            {
                kamus_kata[i] = line;
                line = kamus.ReadLine();
                i++;
            }
        }
        public void kata_search(){
            kosakata kata = new kosakata();
            kata.kata_kamus();

            Console.WriteLine("Masukkan kata yang ingin dicari: ");
            string hint = Console.ReadLine();

            int i = 0;
            int status = 0;
            while (kamus_kata[i] != null)
            {
                if (hint == kamus_kata[i])
                {
                    Console.WriteLine("{0}",kamus_kata[i]);
                    Console.WriteLine("{0}",arti_kata[i]);
                    status = 1;
                    break;
                }
                i++;
            }
            if (status == 0)
            {
                Console.WriteLine("Kata tidak ditemykan!");
            }
        }
    }
}