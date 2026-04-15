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
            #region Question12
            ////12. Get a distinct list of all product categories
            //var result = ProductList.Select(p=>p.Category).Distinct().ToList();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Question13
            ////13. find product IDs that are in setA but NOT in setB
            //int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
            //int[] setB = { 3, 6, 9, 12, 15, 13 };

            //var IDs = setA.Except(setB);
            //foreach (var item in IDs)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Question14
            ////14. Find countries that appear in list1 but NOT in list2
            ////(case -insensitive).

            ////Answer
            //string[] list1 = { "Germany", "France", "UK", "Spain" };
            //string[] list2 = { "france", "SPAIN", "Italy" };

            //var result = list1.Except(list2);
            //foreach(string item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Question15
            ////15. Build a Dictionary<int, Product> keyed by ProductID. Then
            ////retrieve and print the product with ID = 18.
            ////Answer

            //var result = ProductList.Where(p => p.ProductID == 18)
            //    .ToDictionary(p => p.ProductID)
            //    .Select(p => new { p.Key, p.Value });
            //    foreach (var item in result) {
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Question16
            ////16. Get the first product whose price is greater than $50.
            ////Answer
            //var result = ProductList.Where(p => p.UnitPrice > 50)
            //    .First();
            //Console.WriteLine(result);
            #endregion
            #region Question17
            ////17. Try to get the first product with a price > $500. it returns null 
            //// instead of throwing.

            ////Answer
            //var result = ProductList.FirstOrDefault(p => p.UnitPrice > 500);
            //Console.WriteLine(result);

            #endregion

            #region Question18
            ////18. Generate a multiplication table row for 7
            //// Answer
            //var Result = Enumerable.Range(1, 10)
            //                .Select(i => $"7*{i}={i * 7}");
            //foreach (var i in Result)
            //{

            //    Console.WriteLine(i);
            //}
            #endregion

    }
}
}
