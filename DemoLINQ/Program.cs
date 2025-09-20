using System.Collections.Immutable;
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
            #region Aggregate Operators - Immediate Ececution
            #region Count 
            //var result = ProductsList.Count(); // linq Method 
            //result = ProductsList.Count;// property of List<T>
            //var result = ProductsList.Count(p => p.UnitsInStock == 0); // linq Method
            //bool productTryGetCount = ProductsList.TryGetNonEnumeratedCount(out result);
            #endregion
            #region Max , Min 
            //var result = ProductsList.Max();
            //Console.WriteLine(result);
            //var result = ProductsList.Max(p => p.UnitPrice);
            //var MinLengthProductName = ProductsList.Min(p => p.ProductName);
            //var Re = (from p in ProductsList
            //          where p.ProductName == MinLengthProductName
            //          select p).FirstOrDefault();
            /********************************************************/
            //var result = ProductsList.MinBy(P => P.ProductName); // .NET 6.0 
            //Console.WriteLine(result);
            #endregion

            #endregion

            #region  Casting Operators - Immediate Execution 
            //List<Product> result  = ProductsList.Where(p => p.UnitsInStock == 0).ToList(); // casting to List 
            //Product[] array = ProductsList.Where(p => p.UnitsInStock == 0).ToArray(); // casting to array 
            //Dictionary<long, Product> dictionary = ProductsList.Where(p => p.UnitsInStock == 0)
            //                                                     .ToDictionary(p => p.ProductID); // casting to Dictionary
            //Dictionary<long, string> dictionary1 = ProductsList.Where(p => p.UnitsInStock == 0)
            //                                                .ToDictionary(p => p.ProductID,p=>p.ProductName); // casting to Dictionary
            //foreach (var item in dictionary)
            //{
            //    Console.WriteLine(item.Key);
            //    Console.WriteLine(item.Value);
            //}
            /***/
            // Comparer the Default Equality Comparer  object to object 

            //HashSet<Product> hashSet = ProductsList.Where(p => p.UnitsInStock == 0)
            //                                     .ToHashSet(); // casting to HashSet
            //var hastset = ProductsList.Where(p => p.UnitsInStock == 0)
            //                         .ToImmutableHashSet(); // casting to HashSet Immutable ,to orderby 
            //foreach (var item in hashSet)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #endregion
        }
    }
}
