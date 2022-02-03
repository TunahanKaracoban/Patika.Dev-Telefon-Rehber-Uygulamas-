using System.Collections.Generic;

namespace Telefon_Rehber_Uygulaması
{
    public class People
    {
        public List<Person> persons = new List<Person>();
        public void people()
        {
            persons.Add(new Person("Tunahan", "Karaçoban", "03215687495"));
            persons.Add(new Person("Alican", "Pamuk", "35162548701"));
            persons.Add(new Person("Tarık", "Demirci", "12345678925"));
        }
    }



}
