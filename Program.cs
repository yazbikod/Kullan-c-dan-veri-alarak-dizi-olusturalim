using System.Collections;

// Dizi Tanımlamaları
int[] sayidizisi;
ArrayList teksayilar = new ArrayList();
ArrayList ciftSayilar = new ArrayList();

// Değişken Tanımlamaları
int elemansayisi, sayi, teksayi, ciftsayi;
int diziToplam = 0;

Console.Write("Sayı dizisi içine kaç eleman tanımlayacağınızı giriniz : ");
elemansayisi=Convert.ToInt32(Console.ReadLine());

if(elemansayisi>0)
{
    sayidizisi= new int[elemansayisi];
    Console.WriteLine("Dizi başarıyla oluşturuldu...");
    for (int i=0; i<sayidizisi.Length;i++)
    {
        Console.Write($"Diziye tanımlanacak {i+1}. sayıyı giriniz...");
        sayi = Convert.ToInt32(Console.ReadLine());
        sayidizisi[i]= sayi;
        if (sayidizisi[i] %2 == 0)
        {
            ciftsayi = sayidizisi[i];
            ciftSayilar.Add(ciftsayi);
        }
        else
        {
            teksayi = sayidizisi[i];
            teksayilar.Add(teksayi);
        }
        diziToplam += sayidizisi[i];
    }
}
else
    Console.WriteLine("Yanlış bir değer girdiniz...");
Console.WriteLine($"Dizi Elemanlarının Toplamı : {diziToplam}");
Console.Write("Tek Sayılar : ");
foreach(int yaz in teksayilar)
    Console.Write($"[{yaz}]");

Console.Write("\nÇift Sayılar : ");
foreach(int yazz in ciftSayilar)
    Console.Write($"[{yazz}]");
