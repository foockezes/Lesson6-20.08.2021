using System;

namespace blackpaper
{
    class Movies
    {
        public string name;
        public int release;
        public string protagonist;
        public string country;
        public string language;
        public int duration;

        public void GetInfo()
        {
            Console.WriteLine($"Название Фильма: {name}");
            Console.WriteLine($"Релиз: {release}");
            Console.WriteLine($"Страна: {country}");
            Console.WriteLine($"Язык: {language}");
            Console.WriteLine($"Главный герой: {protagonist}");
            Console.WriteLine($"Длительность: {duration}");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Movies movies = new Movies();
            movies.name = "Matrix_4";
            movies.release = 2021;
            movies.country = "United States";
            movies.language = "English";
            movies.protagonist = "Keanu Reeves";
            movies.duration = 129;
            movies.GetInfo();


        }
    }
}
