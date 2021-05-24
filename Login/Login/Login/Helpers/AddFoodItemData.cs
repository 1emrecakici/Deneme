using Firebase.Database;
using Firebase.Database.Query;
using Login.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Login.Helpers
{
    class AddFoodItemData
    {
        public List<FoodItem> FoodItems { get; set; }
        FirebaseClient client;
        public AddFoodItemData()
        {
            client = new FirebaseClient("https://deneme1-1baab-default-rtdb.firebaseio.com/");
            FoodItems = new List<FoodItem>()
            {
                new FoodItem()
                {
                    ProductID = 1,
                    CategoryID = 1,
                    ImageUrl = "http://cdn.getir.com/product/5cac8d0b03c5fd0001497976_tr_1579677305629.jpeg",
                    Name = "Muz",
                    Description = "Doğal Muz",
                    Rating ="4.8",
                    RatingDetail ="(121 ratings)",
                    HomeSelected= "CompleteHeart",
                    Price = 12
                },
                new FoodItem()
                {
                    ProductID = 2,
                    CategoryID = 1,
                    ImageUrl = "http://cdn.getir.com/product/5cac8d0b03c5fd0001497976_tr_1579677305629.jpeg",
                    Name = "Muz",
                    Description = "Doğal Muz",
                    Rating ="4.8",
                    RatingDetail ="(121 ratings)",
                    HomeSelected= "CompleteHeart",
                    Price = 12
                },
                new FoodItem()
                {
                    ProductID = 3,
                    CategoryID = 1,
                    ImageUrl = "http://cdn.getir.com/product/5cac8d0b03c5fd0001497976_tr_1579677305629.jpeg",
                    Name = "Muz",
                    Description = "Doğal Muz",
                    Rating ="4.8",
                    RatingDetail ="(121 ratings)",
                    HomeSelected= "CompleteHeart",
                    Price = 12
                },
                new FoodItem()
                {
                    ProductID = 4,
                    CategoryID = 1,
                    ImageUrl = "http://cdn.getir.com/product/5cac8d0b03c5fd0001497976_tr_1579677305629.jpeg",
                    Name = "Muz",
                    Description = "Doğal Muz",
                    Rating ="4.8",
                    RatingDetail ="(121 ratings)",
                    HomeSelected= "CompleteHeart",
                    Price = 12
                },
                new FoodItem()
                {
                    ProductID = 5,
                    CategoryID = 2,
                    ImageUrl = "http://cdn.getir.com/product/5cac8d0b03c5fd0001497976_tr_1579677305629.jpeg",
                    Name = "Muz",
                    Description = "Doğal Muz",
                    Rating ="4.8",
                    RatingDetail ="(121 ratings)",
                    HomeSelected= "CompleteHeart",
                    Price = 12
                },
                new FoodItem()
                {
                    ProductID = 6,
                    CategoryID = 2,
                    ImageUrl = "http://cdn.getir.com/product/5cac8d0b03c5fd0001497976_tr_1579677305629.jpeg",
                    Name = "Muz",
                    Description = "Doğal Muz",
                    Rating ="4.8",
                    RatingDetail ="(121 ratings)",
                    HomeSelected= "CompleteHeart",
                    Price = 12
                },
                new FoodItem()
                {
                    ProductID = 7,
                    CategoryID = 3,
                    ImageUrl = "http://cdn.getir.com/product/5cac8d0b03c5fd0001497976_tr_1579677305629.jpeg",
                    Name = "Muz",
                    Description = "Doğal Muz",
                    Rating ="4.8",
                    RatingDetail ="(121 ratings)",
                    HomeSelected= "CompleteHeart",
                    Price = 12
                },
                new FoodItem()
                {
                    ProductID = 8,
                    CategoryID = 3,
                    ImageUrl = "http://cdn.getir.com/product/5cac8d0b03c5fd0001497976_tr_1579677305629.jpeg",
                    Name = "Muz",
                    Description = "Doğal Muz",
                    Rating ="4.8",
                    RatingDetail ="(121 ratings)",
                    HomeSelected= "CompleteHeart",
                    Price = 12
                },

            };
        }

        public async Task AddFoodItemsAsync()
        {
            try
            {
                foreach (var item in FoodItems)
                {
                    await client.Child("FoodItems").PostAsync(new FoodItem()
                    {
                        CategoryID = item.CategoryID,
                        ProductID = item.ProductID,
                        Description = item.Description,
                        ImageUrl = item.ImageUrl,
                        Name = item.Name,
                        Rating= item.Rating,
                        RatingDetail= item.RatingDetail,
                        HomeSelected = item.HomeSelected,
                        Price = item.Price
                    });
                }
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }
}

