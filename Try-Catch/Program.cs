using System;

public class Program
{
    public static void Main()
    {
        try
        {
            Console.WriteLine("Bir Sayı Giriniz");
            double sayi = Convert.ToDouble(Console.ReadLine());
            double kare = Math.Pow(sayi, 2);//sayinin karesi alınıyor.
            Console.WriteLine("Girdiğiniz Sayının Karesi: " + kare);
        }
        catch (FormatException)
        {
            // Giriş geçersizse hata mesajını göster
            Console.WriteLine("Geçersiz giriş! Lütfen bir sayı giriniz.");
        }
        finally
        {
            Console.WriteLine("İşlem Tamamlandı");
        }
    }
}