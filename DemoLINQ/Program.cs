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
            #region Generation Operators [valid only with Method Syntax]
            // The only way to call them is as static Methods of Enumerable class
            //var result = Enumerable.Range(10, 20); // generate sequence of integers start from 10 count 20 numbers
            //var products = Enumerable.Repeat(new Product() { Category = "Meat" }, 100);
            //// Generate sequence of Empty 
            //var result = Enumerable.Empty<Product>().ToArray();
            #endregion
            #region  Set Operators 
            //var Nubmers01 = Enumerable.Range(0,100);
            //var Nubmers02 = Enumerable.Range(50, 100);
            //var result = Nubmers01.Union(Nubmers02); // distinct numbers from both sequences
            //result = Nubmers01.Concat(Nubmers02); // all numbers from both sequences remove duplicates
            //result = Nubmers01.Distinct(); // distinct numbers from single sequence
            //result  = Nubmers01.Intersect(Nubmers02); // common numbers in both sequences
            //result = Nubmers01.Except(Nubmers02); // numbers in first sequence not in second sequence
            /***************************************************/
            //var products01 = new List<Product>()
            //{
            //    new Product() {ProductID = 1, ProductName = "Chai", Category = "Beverages",
            //                UnitPrice = 18.00M, UnitsInStock = 100},
            //            new Product{ ProductID = 2, ProductName = "Chang", Category = "Beverages",
            //            UnitPrice = 19.0000M, UnitsInStock = 17 },
            //          new Product{ ProductID = 3, ProductName = "Aniseed Syrup", Category = "Condiments",
            //            UnitPrice = 10.0000M, UnitsInStock = 13 },
            //          new Product{ ProductID = 4, ProductName = "Chef Anton's Cajun Seasoning", Category = "Condiments",
            //            UnitPrice = 22.0000M, UnitsInStock = 53 },
            //          new Product{ ProductID = 5, ProductName = "Chef Anton's Gumbo Mix", Category = "Condiments",
            //            UnitPrice = 21.3500M, UnitsInStock = 0 },
            //};
            //var products02 = new List<Product>() {

            //    new Product() {ProductID = 1, ProductName = "Chai", Category = "Beverages",
            //                UnitPrice = 18.00M, UnitsInStock = 100},
            //            new Product{ ProductID = 2, ProductName = "Chang", Category = "Beverages",
            //            UnitPrice = 19.0000M, UnitsInStock = 17 },
            //          new Product{ ProductID = 4, ProductName = "Chef Anton's Cajun Seasoning", Category = "Condiments",
            //            UnitPrice = 22.0000M, UnitsInStock = 53 },
            //};
            //var result = products01.Union(products02);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //var result = products01.UnionBy(products02,p=>p.ProductName); 
            //var result = products01.IntersectBy(products02.Select(p => p.ProductID), p => p.ProductID);
            //var result = products01.ExceptBy(products02.Select(p => p.ProductID), p => p.ProductID);

            #endregion

            #endregion
        }
    }
}
