using book_linq;

LinqQueries queries = new();

//Toda la colecion
//ImprimirValores(queries.TodaLaColleccion());
//Libros desde 2000
//Console.WriteLine($"Algun libro fue publicado en el 2005? - { queries.GetAnhioBook()}");
ImprimirValores(queries.GellAll());

//Imprime
void ImprimirValores ( IEnumerable<Book> books)
{
    Console.WriteLine("{0,-60} {1,9}  {2,11}  {3,11}\n", "Titulo" , "N. paginas" , "Fecha de publicacion" , "Estado");
    foreach ( var book in books)
    {
        Console.WriteLine("{0,-60} {1,9}  {2,11} {3,11}", book.Title , book.PageCount , book.PublishedDate.ToShortDateString(), book.Status );
    }
}
