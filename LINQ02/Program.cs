using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.Intrinsics.X86;
using static LINQ02.ListGenerator;
namespace LINQ02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  Aggregate Operators
            #region 1
            //var res = ProductsList.GroupBy(p => p.Category).Select(x => new
            //{
            //    category = x.Key,
            //    unitsInStock = x.Sum(x => x.UnitsInStock)
            //});
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 2. Get the cheapest price among each category's products
            //var res = ProductsList.GroupBy(p => p.Category).Select(x => new
            //{
            //    category = x.Key,
            //    CheapestPrice = x.Min(c=>c.UnitPrice)
            //});
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region 3. Get the products with the cheapest price in each category (Use Let)
            //var res = from p in ProductsList
            //          group p by p.Category
            //          into g
            //          let CheapestPrice = g.Min(x => x.UnitPrice)
            //          select CheapestPrice;

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region 4. Get the most expensive price among each category's products.
            //var res = ProductsList.GroupBy(p => p.Category).Select(x => new
            //{
            //    category = x.Key,
            //    MostExpensive = x.Max(x => x.UnitPrice),
            //});
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 5. Get the products with the most expensive price in each category.

            #endregion
            #region 6. Get the average price of each category's products.

            #endregion
            #endregion

            #region  Set Operators
            #region 1. Find the unique Category names from Product List
            //var res = ProductsList.Select(p => p.Category).Distinct();
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 2. Produce a Sequence containing the unique first letter from both product and customer names.
            //var res = ProductsList.Select(p => p.ProductName[0])
            //                      .Union(CustomersList.Select(c => c.CustomerName[0]))
            //                      .Distinct();
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            //#endregion
            #endregion
            #region 3. Create one sequence that contains the common first letter from both product and customer names.
            //var res = ProductsList.Select(p => p.ProductName[0])
            //                      .Intersect(CustomersList.Select(c => c.CustomerName[0]));
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 4. Create one sequence that contains the first letters of product names that are not also first letters of customer names.
            //var res = ProductsList.Select(p => p.ProductName[0])
            //                      .Except(CustomersList.Select(c => c.CustomerName[0]));
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 5. Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates
            //var res = ProductsList.Select(p => p.ProductName[^3..])
            //                      .Concat(CustomersList.Select(c => c.CustomerName[^3..]));
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #endregion

            #region  Partitioning Operators
            #region 1. Get the first 3 orders from customers in Washington
            //var res = CustomersList.Where(x => x.Region == "WA").SelectMany(c=>c.Orders).Take(3);
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 2. Get all but the first 2 orders from customers in Washington.
            //var res = CustomersList.Where(x => x.Region == "WA").SelectMany(c=>c.Orders).Skip(2);
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion
            #region 3. Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var res = numbers.TakeWhile((n, i) => n >= i);
            //foreach (int n in res)
            //{
            //    Console.WriteLine(n);
            //}

            #endregion
            #region 4.Get the elements of the array starting from the first element divisible by 3.

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var res = numbers.SkipWhile( n => n % 3 != 0);
            //foreach (int n in res)
            //{
            //    Console.WriteLine(n);
            //}

            #endregion
            #region 5. Get the elements of the array starting from the first element less than its position.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var res = numbers.SkipWhile((n, i) => n >= i);
            //foreach (int n in res)
            //{
            //    Console.WriteLine(n);
            //}
            #endregion
            #endregion

            #region Quantifiers
            #region 1. Determine if any of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First) contain the substring 'ei'.
            //var words = File.ReadAllLines("dictionary_english.txt");
            //var res = words.Any(w => w.Contains("ei"));
            //foreach (var word in words)
            //{
            //    Console.WriteLine(word);
            //}
            #endregion
            #region 2. Return a grouped a list of products only for categories that have at least one product that is out of stock.

            //var res = ProductsList.GroupBy(p => p.Category).Where(c => c.Any(p => p.UnitsInStock == 0))
            //                       .Select(p => p);
            //foreach (var c in res)
            //{
            //    Console.WriteLine(c.Key);
            //    foreach (var p in c)
            //    {
            //        Console.WriteLine($"           {p}");
            //    }
            //}

            #endregion
            #region 3. Return a grouped a list of products only for categories that have all of their products in stock.
            //var res = ProductsList.GroupBy(p => p.Category).Where(c => c.All(p => p.UnitsInStock > 0))
            //                       .Select(p => p);
            //foreach (var c in res)
            //{
            //    Console.WriteLine(c.Key);
            //    foreach (var p in c)
            //    {
            //        Console.WriteLine($"           {p}");
            //    }
            //}
            #endregion
            #endregion

            #region Grouping Operators
            #region Use group by to partition a list of numbers by their remainder when divided by 5
            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            //var res=numbers.GroupBy(x => x%5);
            //foreach (var c in res)
            //{
            //    Console.WriteLine(c.Key);
            //    foreach (var p in c)
            //    {
            //        Console.WriteLine($"           {p}");
            //    }
            //}
            #endregion
            #region Uses group by to partition a list of words by their first letter.Use dictionary_english.txt for Input

            //var words = File.ReadAllLines("dictionary_english.txt");
            //var res = words.GroupBy(w => w[0]);

            //foreach (var c in res)
            //{
            //    Console.WriteLine(c.Key);
            //    foreach (var p in c)
            //    {
            //        Console.WriteLine($"           {p}");
            //    }
            //}

            #endregion
            #region Use Group By with a custom comparer that matches words that are consists of the same Characters Together
            //String[] Arr = { "from", "salt", "earn", " last", "near", "form" };
            //var res=Arr.GroupBy(w=>w.Trim(), new )
            #endregion
            #endregion
        }
    }
}
