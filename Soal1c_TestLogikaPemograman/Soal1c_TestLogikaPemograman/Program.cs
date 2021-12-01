using System;

namespace Soal1c_TestLogikaPemograman
{
    class AngkaSama
    {
        // Kemungkinan Pasangan Kaoskaki
        static int htgkaoskaki(int[] arr, int n)
        {
            // Menyimpan perhitungan bnyk pasangan
            int count = 0;

            // Mengurutkan Array
            Array.Sort(arr);

            // Perulangan
            for (int i = 0; i < n - 1;)
            {

                // Kondisi menentukan angka yg berpasangan
                if (arr[i] == arr[i + 1])
                {
                    count++;
                    i = i + 2;
                }

                //Lanjut ke angka berikutnya
                else
                {
                    i++;
                }
            }
            return count;
        }
        public static void Main(string[] args)
        {
            int[] arr = { 1, 1, 3, 1, 2, 1, 3, 3, 3, 3 };
            int n = arr.Length;

            Console.WriteLine("1, 1, 3, 1, 2, 1, 3, 3, 3, 3\n");
            Console.WriteLine("Jumlah pasang kaos kaki yang dapat dijual adalah : " + htgkaoskaki(arr, n));
            Console.ReadLine();
        }
    }
}
