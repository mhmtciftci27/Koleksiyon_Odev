using System.Collections;
using System;

internal class Program
{
    static void Main(string[] args)
    {
        ArrayList asal = new ArrayList();
        ArrayList nasal = new ArrayList();
        Console.WriteLine("20 Tane Pozitif Sayı Giriniz:");
        int sayac = 1;
        while (sayac<=5)
        {
            int sayi = Convert.ToInt32(Console.ReadLine());
            if(sayi<=0)
                Console.WriteLine("Pozitif bir sayı giriniz");
            else if(sayi==2) 
            {
                asal.Add(sayi);
                sayac+=1;
            }
            else
            {
                int sonuc = Asalmi(sayi);
                if(sonuc==0)
                    nasal.Add(sayi);
                else
                    asal.Add(sayi);
                sayac+=1;
            }
        }
        asal.Sort();
        nasal.Sort();
        int toplam = 0;
        int toplam2= 0;

        foreach (var item in asal)
        {
            toplam +=Convert.ToInt32(item);
            Console.Write(item);
        }
        foreach (var item in nasal)
        {
            toplam2 += Convert.ToInt32(item);
            Console.Write(item);
        }
        
        Console.WriteLine("Asal Sayıların Toplamı:"+ toplam);
        Console.WriteLine("Asal Sayıların Ortalaması:"+ toplam/asal.Count); 
        Console.WriteLine("Asal Olmayan Sayıların Toplamı:"+ toplam2);
        Console.WriteLine("Asal Olmayan Sayıların Ortalaması:"+ toplam2/nasal.Count); 
    }
    private static int Asalmi(int sayi)
    {
        int i;
        for (i = 2; i <= sayi - 1; i++)
        {
            if (sayi % i == 0)
            {
                return 0; //nasal
            }
        }
        if (i == sayi)
        {
            return 1;
        }
        return 0;
    }
}