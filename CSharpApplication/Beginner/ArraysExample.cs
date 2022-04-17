using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
internal class ArraysExample
{
    public ArraysExample()
    {
        // Tek Boyutlu Dizi
        int[] arr = new int[3];//dizi oluşturma
        // int[] dizi = new int[5] { 10, 20, 30, 40, 50 }; // Bildiri sırasında diziyi başlatmanın 3 yolu vardır.
        // int[] dizi = new int[]{ 10, 20, 30, 40, 50 }; // Dizinin boyutunu atlayabiliriz.
        // int[] dizi = { 10, 20, 30, 40, 50 }; // Yeni operatörü de atlayabiliriz.
        arr[0] = 10;//dizi başlatılıyor
        arr[1] = 20;
        arr[2] = 30;

        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
        // çapraz dizi
        foreach (int i in arr)
        {
            Console.WriteLine(i);
        }
        /* Çıktı:
         * 10
         * 20
         * 30
         * 10
         * 20
         * 30
        */
        // Çok Boyutlu Dizi
        int[,] arr1 = new int[2, 2];//2D dizi bildirimi
        arr1[0, 0] = 10;//başlatma
        arr1[1, 1] = 20;
        arr1[1, 0] = 110;
        arr1[1, 1] = 120;

        // çapraz geçiş
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write(arr1[i, j] + " ");
            }
        }
        /* Çıktı:
         * 10 0 110 120
         */
        int[,,] arr2 = new int[2, 2, 3] {
                {
                    { 1, 2, 3 },
                    { 4, 5, 6 }
                },
                {
                    { 7, 8, 9 },
                    { 10, 11, 12 }
                }

            };//3B dizi bildirimi

        Console.WriteLine();//her satırda yeni satır
        /*
        * Length          : Dizinin tüm boyutlarındaki toplam eleman sayısını almak için kullanılır.
        * LongLength : Dizinin tüm boyutlarındaki toplam öğe sayısını temsil eden 64 bitlik bir tamsayı elde etmek için kullanılır.
        * Rank            : Dizinin rankını(boyut sayısını) almak için kullanılır.
        */
        // çapraz geçiş
        for (int i = 0; i < arr2.GetLongLength(0); i++)
        {

            for (int j = 0; j < arr2.GetLongLength(i); j++)
            {

                for (int k = 0; k < arr2.Rank; k++)
                {
                    Console.Write(arr2[i, j, k] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        /*Çıktı:
         * 1 2 3
         * 4 5 6
         *
         * 7 8 9
         * 10 11 12
        */
        /*
         * Jagged dizi, üye dizilerin farklı boyutlarda olabileceği bir dizi dizisidir. Başka bir deyişle,
         * her dizi indeksinin uzunluğu farklı olabilir. Jagged Array öğeleri referans türleridir ve varsayılan olarak null olarak başlatılır.
         * Jagged Array, çok boyutlu dizilerle de karıştırılabilir.
         */
        // Pürüzlü Dizi
        // Dört öğenin Jagged Dizisini bildirin:
        int[][] jagged_arr = new int[2][];
        // Elemanları başlat
        jagged_arr[0] = new int[] { 1, 2, 3 };
        jagged_arr[1] = new int[] { 11, 34, 67 };

        // Dizi öğelerini göster:
        for (int n = 0; n < jagged_arr.Length; n++)
        {
            // Satır numarasını yazdır
            Console.WriteLine("Satır({0}): ", n);
            for (int k = 0; k < jagged_arr[n].Length; k++)
            {
                // Satırdaki elemanları yazdır
                Console.Write("{0} ", jagged_arr[n][k]);
            }
            Console.WriteLine();
        }
        /* Çıktı:
         * Satır (0):
         * 1 2 3
         * Satır (1):
         * 11 34 67
        */
        Console.ReadKey();
    }

}


