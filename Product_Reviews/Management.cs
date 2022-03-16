using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Reviews
{
    public class Management
    {
        public readonly LinqToDataTable datatable = new LinqToDataTable();
        public void Toprecords(List<ProductReview> listproductReview)
        {
            var recordedData = (from productReviews in listproductReview
                                orderby productReviews.Rating descending
                                select productReviews).Take(3);
            foreach(var list in recordedData)
            {
                Console.WriteLine("ProductID :- " + list.ProductID + " " + "UserID :- " + list.UserID
                    + " " + "Rating :- " + list.Rating + " " + "Review :- " + list.Review + " " + "isLike :- " + list.isLike);
            }
        }
        public void SelectRecords(List<ProductReview> listProductReview)
        {
            var recordedData = from productReviews in listProductReview
                               where (productReviews.ProductID == 1 || productReviews.ProductID == 4 || productReviews.ProductID == 9)
                               && productReviews.Rating > 3
                               select productReviews;
            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductID :- " + list.ProductID + " " + "UserID :- " + list.UserID
                    + " " + "Rating :- " + list.Rating + " " + "Review :- " + list.Review + " " + "isLike :- " + list.isLike);
            }
        }
        public void RetriveCountrecords(List<ProductReview> listProductReview)
        {
            var recordedData = listProductReview.GroupBy(x => x.ProductID).Select(x => new { ProductID = x.Key, Count = x.Count() });
            foreach (var list in recordedData)
            {
                Console.WriteLine(list.ProductID + "==>" + list.Count);
            }
        }
        public void RetriveTrueValue(List<ProductReview> listProductReview)
        {
            var recordData = (from productReview in listProductReview
                              where productReview.isLike == true
                              select productReview).ToList();
            foreach (var item in recordData)
            {
                Console.WriteLine(item.ProductID + "  " + item.UserID + "  "+item.Rating +"  "+item.Review+"  "+item.isLike);
            }
        }
        public void RetriveAverage(List<ProductReview> productReview)
        {
            double Ave = productReview.Average(x => x.Rating);
            Console.WriteLine("Average Rating is :- " +Ave);
        }
        public void ReviewNice(List<ProductReview> listProductReview)
        {
            var recordData = (from productReview in listProductReview
                              where productReview.Review == "Nice"
                              select productReview).ToList();
            foreach (var item in recordData)
            {
                Console.WriteLine("ProductID "+ item.ProductID + "  " +"UserID "+ item.UserID + "  " +"Rating "+ item.Rating + "  " +"Review "+ item.Review + "  " +"isLike "+ item.isLike);
            }
        }
        public void SpecificID(List<ProductReview> listProductReview)
        {
            var recordData = (from productReview in listProductReview
                              where productReview.ProductID == 10
                              select productReview).ToList();
            foreach (var item in recordData)
            {
                Console.WriteLine("ProductID " + item.ProductID + "  " + "UserID " + item.UserID + "  " + "Rating " + item.Rating + "  " + "Review " + item.Review + "  " + "isLike " + item.isLike);
            }
        }
    }
}

