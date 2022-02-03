using System;

namespace Telefon_Rehber_Uygulaması
{
    public class PersonManager : People
    {
        public void personAdd()
        {
            Console.WriteLine("Lütfen isim giriniz             :");
            string name = Console.ReadLine();
            Console.WriteLine("Lütfen soyisim giriniz          :");
            string lastName = Console.ReadLine();
            Console.WriteLine("Lütfen telefon numarası giriniz :");
            string phone = Console.ReadLine();

            persons.Add(new Person(name, lastName, phone));
            Console.WriteLine($"\n {name} {lastName} {phone} kişi eklendi.");

        }
        public void personDelete()
        {
            people();
            Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
            var search = Console.ReadLine();
            bool kayitvarmi = false;
            for (var i = 0; i < persons.Count; i++)
            {
                if (search == persons[i].name || search == persons[i].lastName)
                {
                    Console.WriteLine("Kullanıcı {0} silmek istediğinize eminmisiniz y/n", persons[i].Phone);
                    var answer = Console.ReadLine();
                    kayitvarmi = true;

                    if (answer == "y")
                    {
                        Console.WriteLine("Başarı ile silinmiştir");
                    }
                }
            }
            if (!kayitvarmi)
            {
                Console.WriteLine("Böyle bir kullanıcı bulamadık");
            }
        }
        public void personUpdate()
        {
            people();
            Console.WriteLine("Lütfen güncellemek istediğiniz kişinin ismini veya soyadını yazınız:");
            var search = Console.ReadLine();
            bool kayitvarmi = false;
            for (var i = 0; i < persons.Count; i++)
            {
                if (search == persons[i].name || search == persons[i].lastName)
                {
                    Console.WriteLine("Adı:{0}" +
                    "\nSoyadı:{1}" +
                    "\nNumarası:{2}" +
                    "\n**************", persons[i].name, persons[i].lastName, persons[i].Phone);
                }
            }
            if (!kayitvarmi)
            {
                Console.WriteLine("Böyle bir kullanıcı bulamadık");
            }
            Console.ReadLine();
        }
        public void guideSearch()
        {
            people();
            for (var i = 0; i < persons.Count; i++)
            {
                Console.WriteLine("Adı:{0}" +
                "\nSoyadı:{1}" +
                "\nNumarası:{2}" +
                "\n**************", persons[i].name, persons[i].lastName, persons[i].Phone);
            }

            Console.ReadLine();

        }
        public void personSearch()
        {
            people();
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz" +
                "\n**************************************" +
                "\nİsim ve Soyadına göre arama yapmak için (1)" +
                "\nNumaraya göre arama yapmak için (2)");
            var search = Console.ReadLine();
            if (search == "1")
            {
                Console.WriteLine("Lütfen arama yapmak istediğiniz kişinin adını veya soyadını yazınız");
                var answer = Console.ReadLine();
                bool kayitvarmi = false;
                for (var i = 0; i < persons.Count; i++)
                {
                    if (answer == persons[i].name || answer == persons[i].lastName)
                    {
                        Console.WriteLine("Adı:{0}" +
                        "\nSoyadı:{1}" +
                        "\nNumarası:{2}" +
                        "\n**************", persons[i].name, persons[i].lastName, persons[i].Phone);
                        kayitvarmi = true;
                    }
                }
                if (!kayitvarmi)
                {
                    Console.WriteLine("Böyle bir kullanıcı bulamadık");
                }
            }
            else if (search == "2")
            {
                Console.WriteLine("Lütfen numarayı tuşlayınız");
                string answer =Console.ReadLine();
                bool kayitvarmi = false;
                for (var i = 0; i < persons.Count; i++)
                {
                    if (answer == persons[i].Phone)
                    {
                        Console.WriteLine("Adı:{0}" +
                        "\nSoyadı:{1}" +
                        "\nNumarası:{2}" +
                        "\n**************", persons[i].name, persons[i].lastName, persons[i].Phone);
                        kayitvarmi = true;
                    }
                }
                if (!kayitvarmi)
                {
                    Console.WriteLine("Böyle bir kullanıcı bulamadık");
                }
            }
            else
            {
                Console.WriteLine("Geçersiz veye hatalı tuşlama yaptınız.");
            }
            Console.ReadLine();
        }

    }



}
