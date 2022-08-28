using System.Collections;
using System;

internal class Program3
{
    static void Main(string[] args)
    {
        string cumle = null;
        ArrayList liste = new ArrayList();
        ArrayList sesli = new ArrayList(){'a','e','ı','i','o','ö','u','ü','A','E','I','İ','O','Ö','U','Ü'};
        Console.WriteLine("Bir Cümle Giriniz:");
        cumle = Convert.ToString(Console.ReadLine());

        for(int i =0; i < cumle.Length; i++)
        {
            if(sesli.Contains(cumle[i])==true)
                liste.Add(cumle[i]);    
        }
        liste.Sort();
        foreach (var item in liste)
        {
            Console.WriteLine(item);
        }
    }
}