using static task_12.ListGenerator;

namespace task_12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region  Find all products that are out of stock.

            var products = ProductsList.Where(x => x.UnitsInStock == 0);


            //var result = from p in ProductsList
            //             where p.UnitsInStock == 0
            //             select p;


            foreach (var item in products)
            {
                //Console.WriteLine(item);
                //Console.WriteLine();
            }
            #endregion


            #region Find all products that are in stock and cost more than 3.00 per unit.
            var productsInStock = ProductsList.Where(x => x.UnitsInStock > 0 && x.UnitPrice > 3.00m);



            //var result =  from p in ProductsList
            //              where p.UnitsInStock > 0 && p.UnitPrice > 3.00m
            //              select p;


            foreach (var item in productsInStock)
            {
                //Console.WriteLine(item);
                //Console.WriteLine();
            }
            #endregion



            #region Returns digits whose name is shorter than their value.
            String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var digits = Arr.Where((value, index) => value.Length < index);

            foreach (var item in digits)
            {
               // Console.WriteLine(item);
            }

            #endregion



            #region Get first Product out of Stock 

            var productOutOfStock = ProductsList.First(x => x.UnitsInStock == 0);
            // Console.WriteLine(productOutOfStock);
            #endregion


            #region  first product whose Price > 1000, unless there is no match, in which case null is returned

            var priceMoreThan1000 = ProductsList.FirstOrDefault(x => x.UnitPrice > 1000);
            Console.WriteLine(priceMoreThan1000);
            #endregion



            #region Retrieve the second number greater than 5 

            int[] Arr1 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var secondNumber = Arr1.Where(x => x > 5).ElementAt(1);
           // Console.WriteLine(secondNumber);

            #endregion


            #region Uses Count to get the number of odd numbers in the array
            int[] Arr2 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var oddNumbers = Arr2.Where(x=>x % 2 != 0).Count();
            //Console.WriteLine(oddNumbers);
            #endregion


            #region  Return a list of customers and how many orders each has.
            var customers = CustomersList.Select(x => new
            {
               Name= x.CustomerName,
               orderCount= x.Orders.Count(),
            });

            foreach (var item in customers)
            {
              //  Console.WriteLine($"Name: {item.Name} , number of orders => {item.orderCount}");
            }
            #endregion


            #region Return a list of categories and how many products each has  (missed)
            var categories = ProductsList
                .GroupBy(x => x.Category)
                .Select(x => new
                {
                    Category = x.Key,
                    products = x.Count()
                });

            //var result =
            //        from p in ProductsList
            //        group p by p.Category into g
            //        select new
            //        {
            //            Category = g.Key,
            //            ProductsCount = g.Count()
            //        };

            foreach (var item in categories)
            {
                //Console.WriteLine($"{item.Category} => {item.products}");
            }
            #endregion




            #region Get the total of the numbers in an array
            int[] Arr3 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var total = Arr3.Sum();
            //Console.WriteLine(total);
            #endregion



            string[] dic = File.ReadAllLines("dictionary_english.txt");
            #region Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            int totalChars = dic.Sum(x => x.Length);
            //Console.WriteLine(totalChars);
            #endregion



            #region Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            int shortLength = dic.Min(x=> x.Length);
           // Console.WriteLine(shortLength);
            #endregion




            #region Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            int longestLength = dic.Max(x=> x.Length);
          //  Console.WriteLine(longestLength);
            #endregion



            #region  Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            double averageLenght = dic.Average(x=> x.Length);
            Console.WriteLine(averageLenght);
            #endregion




            #region  Sort a list of products by name
            var sort = ProductsList.OrderBy(x => x.ProductName);

            foreach (var item in sort)
            {
                //Console.WriteLine(item);
            }
            #endregion

            #region Uses a custom comparer to do a case-insensitive sort of the words in an array. (missed)
            String[] Arr4 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            var sortedArr4 = Arr4.OrderBy(x => x, StringComparer.OrdinalIgnoreCase);

            foreach (var item in sortedArr4)
            {
                Console.WriteLine(item);
            }
            #endregion



            #region  Sort a list of products by units in stock from highest to lowest.
            var sortedProducts = ProductsList.OrderByDescending(x=>x.UnitsInStock);

            foreach (var item in sortedProducts)
            {
              //  Console.WriteLine(item);
            }
            #endregion


            #region Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            string[] Arr5 = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

            var sortArr5 = Arr5
                .OrderBy(x => x.Length)
                .ThenBy(x=>x);

            foreach (var item in sortArr5)
            {
               // Console.WriteLine(item);
            }

            #endregion




            #region  Sort first by-word length and then by a case-insensitive sort of the words in an array
            String[] Arr6 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            var sortedArr6 = Arr6
                .OrderBy(x=>x.Length)
                .ThenBy(x=>x, StringComparer.OrdinalIgnoreCase);


            foreach (var item in sortedArr6)
            {
                // Console.WriteLine(item);
            }

            #endregion



            #region  Sort a list of products, first by category, and then by unit price, from highest to lowest.

            var productsby = ProductsList
                .OrderBy(x => x.Category)
                .ThenByDescending(x => x.UnitPrice);


            foreach (var item in productsby)
            {
               // Console.WriteLine(item);
            }
            #endregion




            #region Sort first by-word length and then by a case-insensitive descending sort of the words in an array.
            String[] Arr7 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            var sortedArr7 = Arr7
                .OrderBy(x=>x.Length)
                .ThenByDescending(x=>x, StringComparer.OrdinalIgnoreCase);


            foreach (var item in sortedArr7)
            {
              //  Console.WriteLine(item);
            }
            #endregion




            #region  Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            string[] Arr8 = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

            var digits2 = Arr8.Where(x => x[1] == 'i');

           var result2= digits2.Reverse();
            foreach (var item in result2)
            {
                //Console.WriteLine(item);
            }

            #endregion




            #region Return a sequence of just the names of a list of products.
            var names = ProductsList.Select(x => x.ProductName);

            foreach (var item in names)
            {
                //Console.WriteLine(item);
            }
            #endregion




            #region Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).
                

            String[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            var upperAndLower = words.Select(x=> new
            {
              uppper=  x.ToUpper(),
              lower=  x.ToLower()
            });

            foreach (var item in upperAndLower)
            {
                //Console.WriteLine($"{item.uppper} , {item.lower}");
            }

            #endregion



            #region Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.

            var propertiesOfProducts = ProductsList.Select(x => new
            {
                x.ProductID,
                x.ProductName,
                Price = x.UnitPrice
            });

            foreach (var item in propertiesOfProducts)
            {
                //Console.WriteLine($"{item.ProductID}.{item.ProductName} => {item.Price}");
            }
            #endregion



            #region Determine if the value of int in an array match their position in the array.

            int[] Arr9 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var position = Arr9
                    .Select((value, index) => new
                    {
                        Value = value,
                        answer = value == index
                    });

            foreach (var item in position)
            {
               // Console.WriteLine($"{item.Value}: {(item.answer ? "true" : "false")}");
            }
            #endregion




            #region  Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.

            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };


            var result = numbersA
                .SelectMany(a => numbersB
                .Where(b => a < b)
                .Select(b => new { A = a, B = b }));


            //var r = from a in numbersA
            //        from b in numbersB
            //        where a < b
            //        select new { A = a, B = b };


            foreach (var item in result)
            {
               // Console.WriteLine($"{item.A} less than {item.B}");
            }

            #endregion




            #region Select all orders where the order total is less than 500.00.

            var totalLessThan5000 = CustomersList
                    .SelectMany(x => x.Orders)
                    .Where(x => x.Total < 500.00m);

            foreach (var item in totalLessThan5000)
            {
                //Console.WriteLine(item);
            }
            #endregion



            #region Select all orders where the order was made in 1998 or later.
            
            var orders = CustomersList
                    .SelectMany(x => x.Orders)
                    .Where(x => x.OrderDate.Year >= 1998 );


            foreach (var item in orders)
            {
               // Console.WriteLine(item);
            }
            #endregion
        }
    }
}
