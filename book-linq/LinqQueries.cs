using System;
using System.Reflection;
using System.Text.Json;

namespace book_linq
{
    public class LinqQueries
    {
        private List<Book> LibrosCollection = new List<Book>();
        public LinqQueries()
        {
            using (StreamReader reader = new StreamReader("books.json"))
            {

                string json = reader.ReadToEnd();
                this.LibrosCollection = System.Text.Json.JsonSerializer.Deserialize<List<Book>>(json, new System.Text.Json.JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                });
            }

        }
        public IEnumerable<Book> TodaLaColleccion()
        {
            return LibrosCollection;
        }


        //Permite filtrar los libros publicados entre lo 2000
        public IEnumerable<Book> FilterBook()
        {
            // extension method
            //return LibrosCollection.Where(p => p.PublishedDate.Year > 2000);

            //Query 
            return from book in LibrosCollection where book.PublishedDate.Year > 2000 select book;
        }

        //Retornar Libros que tengan mas de 250 paginas
        public IEnumerable<Book> FiltePage()
        {
            return from book in LibrosCollection
                   where book.PageCount > 250 && book.Title.Contains("in Action")
                   select book;

        }

        public bool GetStatusBook()
        {
            {
                return LibrosCollection.All(x => x.Status! == string.Empty);
            }

        }

        public bool GetAnhioBook()
        {
            {
                return LibrosCollection.Any(x => x.PublishedDate.Year == 0000);
            }

        }

        public IEnumerable<Book> GetAllName()
        {
            //return LibrosCollection.Where(p => p.Categories.Contains("Python"));
            return from Book in LibrosCollection
                   where Book.Categories.Contains("C#")
                   select Book;
        }

        public IEnumerable<Book> GellAll()
        {
            //return LibrosCollection.Where(p => p.Categories.Contains("Python"));
            return LibrosCollection
                .Where(x => x.Categories.Contains("Java"))
                .OrderBy(x => x.PublishedDate.Year > 2000);
             
        }
    }
}