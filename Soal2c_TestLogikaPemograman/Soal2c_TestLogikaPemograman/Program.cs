using System;

class spclcha
{

    static int OUT = 0;
    static int IN = 1;

    // mengambil jumlah kata pada string
    static int htgkalimat(String str)
    {
        int state = OUT;
        int jk = 0; // jumlah kata
        int i = 0;

        // Scan karakter 1 demi 1
        while (i < str.Length)
        {
            // Jika karakter berikutnya adalah pemisah, atur statusnya sebagai OUT
            if (str[i] == ' ')
                state = OUT;

            //Jika karakter berikutnya adalah spesial karakter, maka tidak dihitung
            else if (str[i] == '*' || str[i] == '_' || str[i] == '(' || str[i] == '['
                     || str[i] == '!' || str[i] == '&' || str[i] == '=')
            {
                --jk;
            }

            // Jika karakter berikutnya bukan pemisah
            // dan statusnya OUT
            // maka status mnjdi IN dan hitung jumlah kata

            else if (state == OUT)
            {
                state = IN;
                ++jk;
            }

            ++i;
        }

        return jk;
    }

    public static void Main()
    {
        String str = "Masing-masing anak mendap(atkan uang jajan ya=ng be&rbeda.";

        Console.WriteLine(str);
        Console.WriteLine("");
        Console.WriteLine("Jumalah kata pada kalimat tersebut adalah : " + htgkalimat(str));
        Console.ReadKey();
    }
}