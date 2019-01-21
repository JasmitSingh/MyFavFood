﻿
using System.Collections.Generic;

using MyFavFood.Repositories.Entities;

namespace MyFavFood.Repositories
{
    public class FoodItemsRepository
    {
        /// <summary>
        /// Get the food item list
        /// </summary>
        public static List<FoodItem> GetAvailableFoodItemList()
        {
            // Create a dummy food list
            return new List<FoodItem>()
            {
                new FoodItem { ItemId = 1, ItemName = "Bak Kut Teh" },
                new FoodItem { ItemId = 2, ItemName = "Wanton Mee" },
                new FoodItem { ItemId = 3, ItemName = "Fried Carrot Cake" },
                new FoodItem { ItemId = 4, ItemName = "Dim Sum" },
                new FoodItem { ItemId = 5, ItemName = "Kaya Toast" },
                new FoodItem { ItemId = 6, ItemName = "Soft-Boiled Eggs" },
                new FoodItem { ItemId = 7, ItemName = "Crabs Chilli" },
                new FoodItem { ItemId = 8, ItemName = "Laksa" },
                new FoodItem { ItemId = 9, ItemName = "Curry Fish Head" },
                new FoodItem { ItemId = 10, ItemName = "Crabs Pepper" }
            };
        }
    }
}
