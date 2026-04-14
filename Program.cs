    using static Assignment_LINQ_Session02_.Source;
namespace Assignment_LINQ_Session02_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            ////1. Get top 3 most expensive products
            //var result = ProductList.OrderByDescending(p => p.UnitPrice)
            //                .Take(3);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Question02
            //2. show page 2 of products, with page size = 5
            //int pageNumber = 2;
            //int pageSize=5; 
            //var result = ProductList.Skip((pageNumber - 1) * pageSize)
            //    .Take(pageSize);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Question03
            ////3. Take products from the list as long as Their UnitPrice is less than
            ////$25(list is ordered by price).
            ////Answer
            //var result = ProductList.OrderBy(p => p.UnitPrice)
            //  .TakeWhile(p => p.UnitPrice < 25);
            //     foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Question04
            ////4. Check if ALL products in the "Seafood" category are in stock
            /////Answer
            //var result = ProductList.Where(p => p.Category == "Seafood")
            //    .All(p => p.UnitsInStock > 0);
            //    Console.WriteLine(result);//true
            #endregion
            #region Question05
            ////5. Check if the ID list contains 9
            //int[] ids = { 3, 9, 13, 18 };
            //var result = ids.Contains(9);
            //Console.WriteLine(result);//true
            #endregion
            #region Question06
            ////6. Group all products by Category and print each group with its
            ////product count.
            ////Answer
            //var result = ProductList.GroupBy(p => p.Category)
            //    .Select(p => new
            //    {
            //        category = p.Key
            //    ,
            //        count = p.Count()
            //    });
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Question07
            ////7. Group products by Category and project only product names per
            //// group
            ////Answer
            //var result = ProductList.GroupBy(p => new { p.Category, p.ProductName });

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Key);
            //}
            #endregion
            #region Question08
            // //8. Find all categories that have MORE THAN 3 products
            ////Answer
            // var result = ProductList.GroupBy(p => p.Category)
            //     .Where(p => p.Count() > 3)
            //     .Select(p => p.Key);

            // foreach (var item in result)
            // {
            //     Console.WriteLine(item);
            // }
            #endregion
            #region Question09
            ////9. Using QUERY SYNTAX, group customers by Country, and for each
            //// group select { Country, Count, TotalOrderValue }.
            ////Answer
            //var result = from C in CustomerList
            //             group C by C.Country into g
            //             select new
            //             {
            //                 Country = g.Key,
            //                 Count = g.Count(),
            //                 TotalOrderValue = g.Sum(c => c.Orders.Sum(o => o.Total))
            //             };

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Question10
            ////10. Calculate the total number of units in stock across all products
            ////Answer
            //var result = ProductList.Sum(p => p.UnitsInStock);
            //    Console.WriteLine(result);
            #endregion
            #region Question11
            ////11. Find the CHEAPEST and MOST EXPENSIVE product prices
            //var result = ProductList.Max(p => p.UnitPrice);
            //    Console.WriteLine($"EXPENSIVE ={result}");
            //var result2 = ProductList.Min(p => p.UnitPrice);
            //    Console.WriteLine($"CHEAPEST={result2}");
            #endregion
        }
    }
}
