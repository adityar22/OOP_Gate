using System;
using System.IO;

namespace Gate
{
    public class kerajaan
    {
        public static string[] list_raja = new string[100];
        public static string[] list_nama = new string[100];
        public static string[] list_text = new string[100];
        public static string text_space = @"text\";
        

        public void raja_nama(int kode){
            kerajaan raja = new kerajaan();

            StreamReader txtRaja = new StreamReader(text_space+list_raja[kode-1]+".txt");

            string nama = txtRaja.ReadLine();
            int i = 0;

            while (nama != "-1")
            {
                Console.WriteLine("{0}. {1}",i+1,nama);
                nama = txtRaja.ReadLine();
                i++;
            }
            txtRaja.Close();
        }

        public void raja_show(){
            kerajaan raja = new kerajaan();

            StreamReader txtKrjn = new StreamReader(text_space+"kerajaan.txt");

            string line = txtKrjn.ReadLine();
            int i = 0;

            while (line != "-1")
            {
                list_raja[i] = line;
                Console.WriteLine("{0}. {1}",i+1, list_raja[i]);
                line = txtKrjn.ReadLine();
                i++;
            }
            txtKrjn.Close();

            Console.WriteLine("Masukkan kode kerajaan: ");
            int kode = Convert.ToInt32(Console.ReadLine());
            raja.raja_nama(kode);
        }

        public void raja_list(){

        }

        public void raja_search(){
            kerajaan raja = new kerajaan();
            raja.raja_list();

            Console.WriteLine("Masukkan raja yang ingin dicari: ");
            string hint = Console.ReadLine();

            int status = 0;
            int i = 0;
            while (list_nama[i] != null)
            {
                if (hint == list_nama[i])
                {
                    Console.WriteLine("{0}",list_nama[i]);
                    Console.WriteLine("{0}",list_text[i]);
                    status = 1;
                    break;
                }
                i++;
            }
            if (status == 0)
            {
                Console.WriteLine("Nama Raja tidak ditemukan!");
            }
        }
    }
}