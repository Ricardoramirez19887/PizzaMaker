/*
 * Ricardo Ramirez
 * CST- 250
 * 7/7/26
 * PIzza Maker
 * Activity 4
 */

// Citation: Grand Canyon University. (2025). CST-250 Activity 4: Building a Data-Driven Pizza Order.
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaMaker.Models
{
    public class PizzaModel
    {
        public string ClietName { get; set; } = string.Empty;
        public List<string> Ingredients { get; set; }
        public List<string> StrangeAddOns { get; set; }
        public string CrustType { get; set; }
        public int SauceQuantity { get; set; }
        public int CheeseQuantity { get; set; }
        public DateTime DeliveryTime { get; set; } 
        public Color PizzaBoxColor { get; set; }
        public decimal Price { get; set; }

        public string ClientName { get; set; } = string.Empty;

        

        public PizzaModel()
        {
            ClietName = "";
            Ingredients = new List<string>();
            StrangeAddOns = new List<string>();
            CrustType = "";
            SauceQuantity = 0;
            CheeseQuantity = 0;
            DeliveryTime = DateTime.Now;
            PizzaBoxColor = Color.White;
            Price = 15.00m;

        }

    }
}