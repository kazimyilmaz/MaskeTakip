






using Business.Concrete;
using Entities.Concrete;

SelamVer(isim: "Kazım");
SelamVer();

Person person1 = new Person();
person1.FirstName = "KAZIM";
person1.LastName = "YILMAZ";  
person1.DateOfBirthYear = 2000;
person1.NationalyIdentity = 123;

static void SelamVer(string isim = "İsimsiz")
{
    Console.WriteLine(  "Merhaba" + isim);
}

PttManager pttManager = new(new PersonManager());
pttManager.GiveMask(person1);   


//Console.WriteLine("Hello, World!");
