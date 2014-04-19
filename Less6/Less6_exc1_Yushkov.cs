using System;
using System.Collections.Generic;

namespace Less6_exc1
{
    class Program
    {
        static void Main(string[] args)
        {
            HandBook book = new HandBook();
            Console.WriteLine(book.GetCountry("Dublin"));
            Console.ReadKey();
        }
    }

    class HandBook
    {
        private Dictionary<string,string> _places = new Dictionary<string, string>();

        public HandBook()
        {
            _places.Add("Moscow", "Russia");
            _places.Add("New York", "U.S.A.");
            _places.Add("Seoul", "South Korea");
            _places.Add("Ottawa", "Canada");
            _places.Add("Dublin", "Ireland");
        }

        public string GetCountry(string city)
        {
            if (_places.ContainsKey(city))
            {
                return string.Format("{0} is in {1}",city, _places[city]);
            }
            else
            {
                return string.Format("There is no information");
            }
        }
    }
}
