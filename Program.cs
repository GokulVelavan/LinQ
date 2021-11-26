using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        //UC1
        static void Main(string[] args)
        {
            List<ProductReview> Products = new List<ProductReview>()
            {
                new ProductReview(){ProductID=1,userID=1,Rating=1,Review="good",IsLike=true},
                new ProductReview(){ProductID=2,userID=2,Rating=3,Review="bad",IsLike=true},
                new ProductReview(){ProductID=3,userID=3,Rating=4,Review="good",IsLike=false},
                new ProductReview(){ProductID=4,userID=4,Rating=2,Review="good",IsLike=true},
                new ProductReview(){ProductID=5,userID=5,Rating=1,Review="bad",IsLike=true},
            };
            printdata(Products);
            Console.ReadLine();
        }
        public static void printdata(List<ProductReview> list)
        {
            foreach (ProductReview product in list)
            {
                Console.WriteLine("Productid: " + product.ProductID + "\t" + "userid: " + product.userID + "\t" + "review: " + product.Review + "\t" + "rating: " + product.Rating + "\t" + "is like: " + product.IsLike);
            }
        }
    }

}
