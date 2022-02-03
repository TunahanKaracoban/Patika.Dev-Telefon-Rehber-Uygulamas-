using System;
namespace Telefon_Rehber_Uygulaması
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            PersonManager personManager = new PersonManager();
            SelectFeature selectFeature = new SelectFeature();
            selectFeature._selectFeature();
            string Entry = Console.ReadLine();

            while (true)
            {
                if (Entry == "1")
                {
                    personManager.personAdd();
                    break;
                }
                else if (Entry == "2")
                {

                    personManager.personDelete();
                    break;
                }
                else if (Entry == "3")
                {
                    personManager.personUpdate();
                    break;
                }
                else if (Entry == "4")
                {
                    personManager.guideSearch();
                    break;
                }
                else if (Entry == "5")
                {
                    personManager.personSearch();
                    break;
                }
              

                else
                {
                    Console.WriteLine("Geçersiz işlem");
                    Console.ReadLine();
                    break;
                }
            }
        }
    }



}
