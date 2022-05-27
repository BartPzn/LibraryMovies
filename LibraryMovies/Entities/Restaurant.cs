using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Text;


namespace LibraryMovies.Entities
{
    public class Restaurant
    {
        //tworzy klucz glowny w bazie danych 
        public int Id { get; set; }
        //pole tekstowe, obowiązkowe, do 200 znaków
        public string Name { get; set; }
        //pole liczbowe, opcjonalne, wartości od 1900 włącznie do 2100 włącznie
        public string Description { get; set; }
        public string Category { get; set; }
        public string HasDelivery { get; set; }
        public string ContactEmail { get; set; }
        public string ContactNumber { get; set; }

        //bedzie reprezentowac klucz obcy do tabeli z adresem
        public int AddressId { get; set; }
        public virtual Address Address { get; set; }
        //bedzie latwiej poslugiwac sie obiektem typu restaurant 
        public virtual List<Dish> Dishes { get; set; }
    }
}
