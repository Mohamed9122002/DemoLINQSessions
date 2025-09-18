using static DemoLINQ.ListGenerator;
namespace DemoLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Demo Session 01 LINQ 
            #region Filtration [Restrication ] Operation - Where 
            // Get Products out of stock 
            // Fluent Syntax 
            /// Frist overload of Where method
            //var productsOutOfStock = ProductsList.Where(p=>p.UnitsInStock == 0);
            //foreach (var item in productsOutOfStock)
            //{
            //    Console.WriteLine(item);
            //}
            // Query Syntax 
            //var results = from p in ProductsList
            //              where p.UnitsInStock == 0
            //              select p;
            //foreach (var item in results)
            //    Console.WriteLine(item);
            // Second overload => indexed Where  of Where method
            //var productsOutOfStock = ProductsList.Where((p, i) => i < 10 && p.UnitsInStock == 0);
            // Search in the first 10 products only
            // Indexed Where Valid only with Fluent Syntax , Cannot be used with Query Syntax
            #endregion
            #endregion
        }
    }
}
