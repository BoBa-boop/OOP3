using System;

namespace ConsoleApp6
{
    class Book
    {
        private string Author;
        private string Nazv;
        private int Str;
        private bool Kol;
        public Book(string Author, string Nazv, int Str, bool Kol)
        {
            this.Author = Author;
            this.Nazv = Nazv;
            this.Str = Str;
            this.Kol = Kol;
        }
        public void Print()

        {
            Console.WriteLine("Автор - " + Author);
            Console.WriteLine("Название книги - " + Nazv);
            Console.WriteLine("Количество страниц - " + Str);
            Console.WriteLine("Коллекционное издание - " + Kol);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
                Book nBook = new Book("Пушкин А.С.", "Евгений Онеген", 400, true);
                nBook.Print();
                Console.ReadKey();
        }

    }
}
