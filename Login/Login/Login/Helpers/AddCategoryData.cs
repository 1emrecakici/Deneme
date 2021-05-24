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
    public class AddCategoryData
    {
        public List<Category> Categories { get; set; }
        FirebaseClient client;
        public AddCategoryData()
        {
            client = new FirebaseClient("https://deneme1-1baab-default-rtdb.firebaseio.com/");
            Categories = new List<Category>()
            {
                new Category()
                {
                    CategoryID = 1,
                    CategoryName = "Burger",
                    CategoryPoster ="MainBurger",
                    ImageUrl = "walpaper1.png"
                },
                new Category()
                {
                    CategoryID = 2,
                    CategoryName = "Pizza",
                    CategoryPoster ="MainPizza",
                    ImageUrl = "walpaper1.png"
                },
                new Category()
                {
                    CategoryID=3,
                    CategoryName ="Desserts",
                    CategoryPoster ="MainDessert",
                    ImageUrl ="walpaper1.png"
                },
                new Category()
                {
                    CategoryID =4,
                    CategoryName = "Veg Burger",
                    CategoryPoster ="MainBurger",
                    ImageUrl ="walpaper1.png"

                },
                new Category()
                {
                    CategoryID =5,
                    CategoryName = "Veg Pizza",
                    CategoryPoster ="MainPizza",
                    ImageUrl ="walpaper1.png"

                },
                new Category()
                {
                    CategoryID =6,
                    CategoryName = "Cakes",
                    CategoryPoster ="MainDessert",
                    ImageUrl ="Dessert.png"

                }


            };
        }

        public async Task AddCategoriesAsync()
        {
            try
            {
                foreach(var category in Categories)
                {
                    await client.Child("Categories").PostAsync(new Category()
                    {
                        CategoryID = category.CategoryID,
                        CategoryName = category.CategoryName,
                        CategoryPoster = category.CategoryPoster,
                        ImageUrl = category.ImageUrl,
                        
                    });
                }
            }
            catch(Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }
}
