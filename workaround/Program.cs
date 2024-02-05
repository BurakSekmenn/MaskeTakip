// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using Entities.Concrete;

Console.WriteLine("Hello, World!");


SelamVer("ayşe");
SelamVer("fatma");
SelamVer("burak");
SelamVer("ahmet");
SelamVer();
topla(topla(5,3),topla(2,3));

string ogrenci1 = "ali";
string ogrenci2 = "veli";
string ogrenci3 = "ayşe";

string[] ogrencs = new string[3];
ogrencs[0] = "ali";
ogrencs[1] = "veli";
ogrencs[2] = "ayşe";

for(int i = 0; i <= ogrencs.Length; i++)
{
    Console.WriteLine($"Öğrencini Adı : {ogrencs[i]}");
}




static void SelamVer(string isim = "isimsiz")
{
    Console.WriteLine("Merhaba "+isim);
}


static int topla(int a=5,int b=2)
{
    int sonuc = a+b;
    Console.WriteLine("Toplam: " + sonuc.ToString()) ;
    return sonuc;
}

Person person1 = new Person();
person1.FirstName = "Ali";

PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);





//Solid prensipleri
//S: Single Responsibility Principle --- Bir sınıfın sadece bir işi olmalı
//O: Open Closed Principle  --- Bir sınıfın koduna dokunmadan, yeni özellikler eklemek
//L: Liskovs Substitution Principle --- Bir sınıfın alt sınıfları, üst sınıfın yerine geçebilmeli
//I: Interface Segregation Principle --- Bir sınıfın ihtiyacı olmayan özellikleri içermemeli
//D: Dependency Inversion Principle --- Bağımlılıklar soyutlamalara bağlı olmalı






