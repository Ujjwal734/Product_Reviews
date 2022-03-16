using Product_Reviews;
Console.WriteLine("Hello, World!");
List<ProductReview> productReviewList = new List<ProductReview>()
{
    new ProductReview(){ProductID=1,UserID=1,Rating=5,Review="Good",isLike=true},
    new ProductReview(){ProductID=2,UserID=1,Rating=4,Review="Good",isLike=true},
    new ProductReview(){ProductID=3,UserID=2,Rating=5,Review="Good",isLike=true},
    new ProductReview(){ProductID=4,UserID=2,Rating=4,Review="Nice",isLike=true},
    new ProductReview(){ProductID=4,UserID=3,Rating=2,Review="Nice",isLike=true},
    new ProductReview(){ProductID=6,UserID=3,Rating=1,Review="Bad",isLike=false},
    new ProductReview(){ProductID=7,UserID=4,Rating=1,Review="Bad",isLike=false},
    new ProductReview(){ProductID=8,UserID=5,Rating=4,Review="Good",isLike=true},
    new ProductReview(){ProductID=9,UserID=10,Rating=5,Review="Good",isLike=true},
    new ProductReview(){ProductID=10,UserID=10,Rating=3,Review="Nice",isLike=true},
    new ProductReview(){ProductID=11,UserID=10,Rating=4,Review="Good",isLike=true},
    new ProductReview(){ProductID=10,UserID=10,Rating=5,Review="Good",isLike=true},
    new ProductReview(){ProductID=10,UserID=10,Rating=5,Review="Good",isLike=true},
    new ProductReview(){ProductID=14,UserID=10,Rating=5,Review="Good",isLike=true},
};

Console.WriteLine("1.View all List\n2. Add Data to Table\n3. View Top 3 Records\n4. Select Specfic Records\n5. Count records\n6. View Like records" +
        "7. Finding Average Rating\n8. Reviewing Paticular Product Review\n9. View Specific ProductID\n10. Exit Product Review programme");
Management management = new Management();
int option = 0;
while (option != 10)
{
    Console.WriteLine("Choose From Given Options...! ");
    option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:
            foreach (var list in productReviewList)
            {
                Console.WriteLine("ProductID :- " + list.ProductID + " " + "UserID :- " + list.UserID
                + " " + "Rating :- " + list.Rating + " " + "Review :- " + list.Review + " " + "isLike :- " + list.isLike);
            }
            break;
        case 2:
            LinqToDataTable linqTo = new LinqToDataTable();
            linqTo.AddDataTable();
            break;
        case 3:
            management.Toprecords(productReviewList);
            break;
        case 4:
            management.SelectRecords(productReviewList);
            break;
        case 5:
            management.RetriveCountrecords(productReviewList);
            break;
        case 6:
            management.RetriveTrueValue(productReviewList);
            break;
        case 7:
            management.RetriveAverage(productReviewList);
            break;
        case 8:
            management.ReviewNice(productReviewList);
            break;
        case 9:
            management.SpecificID(productReviewList);
            break;
        case 10:
            
            break;
        default:
            Console.WriteLine("Choose From Given Option...! ");
            break;
    }
}