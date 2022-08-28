using System.Collections;
using System;

internal class Program2
{
    static void Main(string[] args)
    {
        ArrayList liste = new ArrayList();
        ArrayList k_liste = new ArrayList();
        ArrayList b_liste = new ArrayList();
        Console.WriteLine("20 Adet Sayı Giriniz:");
        int sayac = 1;
        while (sayac<=10)
        {
            liste.Add(Convert.ToInt32(Console.ReadLine()));
            sayac+=1;
        }
        Console.WriteLine("En Büyük/küçük bulunacak sayıyı giriniz: ");
        int sayi = Convert.ToInt32(Console.ReadLine());
        liste.Sort();
        
        int enbuyuk = 0;
        int enkucuk = 0;

        for (int i = 0; i < sayi; i++)
        {
            k_liste.Add(Convert.ToInt32(liste[i]));
            enkucuk += Convert.ToInt32(liste[i]);
        }
        liste.Reverse();
        for (int i = 0; i < sayi; i++)
        {
            b_liste.Add(Convert.ToInt32(liste[i]));
            enbuyuk += Convert.ToInt32(liste[i]);
        }
        Console.WriteLine("En kücük "+sayi+ " sayi");
        foreach (var item in k_liste)
        {
            Console.WriteLine(item);            
        }
        Console.WriteLine("En küçük sayıların Toplamı:"+ enkucuk);
        Console.WriteLine("En küçük Sayıların Ortalaması:"+ enkucuk/sayi);
        
        Console.WriteLine("En Büyük "+sayi+ " sayi");
        foreach (var item in b_liste)
        {
            Console.WriteLine(item);            
        }
        Console.WriteLine("En büyük Sayıların Toplamı:"+ enbuyuk);
        Console.WriteLine("En büyük Sayıların Ortalaması:"+ enbuyuk/sayi); 
    }
}