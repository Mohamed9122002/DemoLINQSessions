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
            #region Transformation [Projection] Operators [Select ,SelectMany]
            // First overload of Select method 
            //var productsNames = ProductsList.Select(p=>p.ProductName);
            //foreach (var item in productsNames)
            //{
            //    Console.WriteLine(item);
            //}
            // Query Syntax 
            //var productsNames = from p in ProductsList
            //                    select p.ProductName;
            ///*******************/
            // Select Product Id and Product Name 
            //var result = ProductsList.Select(p => new { p.ProductID, p.ProductName });
            //result = from p in ProductsList
            //              select new { p.ProductID, p.ProductName };
            ///*******************/
            // Select Product In Stock and Apply Discount 10% on its Price 
            //var result = ProductsList.Where(p=>p.UnitsInStock>0)
            //                         .Select(p => new
            //                         {
            //                             p.ProductID,
            //                             p.ProductName,
            //                             p.UnitPrice,
            //                             PriceAfterDiscount = p.UnitPrice * 0.1m
            //                         });

            /// ///*******************/
            // Second overload of Select method => Indexed Select  valid only with Fluent Syntax , Cannot be used with Query Syntax
            //var productsNames = ProductsList.Where(p => p.UnitsInStock > 0).Select((p, i) => new
            //{
            //    Index = i ,
            //    Name = p.ProductName,
            //});

            ///*******************/
            // SelectCustomer Orders 
            // using SelectMany method Select Customer of arr [orders]
            //var result = CustomersList.SelectMany(c => c.Orders);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Ordering Operators [OrderByAsc , OrderByDescending , ThenBy , ThenByDescending , Reverse]
            // Get Products Ordered by UnitPrice Ascending
            //var result = ProductsList.OrderBy(p => p.UnitPrice);
            ////*****************************
            // Get Products Ordered by UnitPrice Descending 
            //var result = ProductsList.OrderByDescending(p => p.UnitPrice);
            //// Query Syntax 
            //result = from p in ProductsList
            //         orderby p.UnitPrice descending
            //         select p;

            ////*****************************
            //// Get Products order by Price Asc and Number of items in stock 
            //var result = ProductsList.OrderBy(p => p.UnitPrice)
            //                          .ThenByDescending(p => p.UnitsInStock);

            #endregion
            #region Element Operator - Immediate Execution [Valid only With Fluent Syntax]
            //var firstProduct = ProductsList.First(); // get first element at sequence 
            // First and last May bw Throw Exception -> Will Exception if the sequence is empty
            /***********************************************************************************/
            //var result = ProductsList.FirstOrDefault();
            // FirstOrDefault and LastOrDefault will not throw Exception if the sequence is empty return default value
            // second overload of FirstOrDefault and LastOrDefault
            ////if there is no matching element => return default value Null 
            //var result = ProductsList.LastOrDefault(p=>p.UnitsInStock>0);
            /*************************************************/
            //var result = ProductsList.ElementAt(0);
            //Console.WriteLine(result); // element at => exception if index is out of range
            //var result = ProductsList.ElementAtOrDefault(77); // element at or default => return default value if index is out of range
            /********************************************************************************/
            //var result = ProductsList.Single(p => p.ProductID == 1);
            // if sequence contains  only one element match condition -> return the element 
            // if no element match condition => throw exception [sequence empty ,sequence conation more than one element match condtion]
            ///// SingleOrDefault 
            //var result = ProductsList.SingleOrDefault(P => P.UnitPrice == 9999999);
            //Console.WriteLine(result);
            // if sequence contains no element match condition => return default value Null
            // if sequence contains more than one element match condition => throw exception
            // if sequence contains only one element match condition => return the element


            #endregion
            #endregion
        }
    }
}
