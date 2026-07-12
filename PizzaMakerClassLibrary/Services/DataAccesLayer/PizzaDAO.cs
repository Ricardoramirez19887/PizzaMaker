using System;
using System.Collections.Generic;
using System.Text;
using PizzaMakerClassLibrary.Models;

// Citation: Grand Canyon University(2025).
// CST-250 Activity 4: Building a Data-Driven Pizza Order System with N-Layer Architecture
namespace PizzaMakerClassLibrary.Services.DataAccesLayer
{
    /// <summary>
    /// Adds a pizza to the current order.
    /// </summary>
    /// <param name="newPizza"> The pizzah being added.</param>
    /// <return> The number of pizza currently in the order.</return>
    /// </summary>   
    
    }
    public class PizzaDAO
    {
        private List<PizzaModel> _pizzaOrder;

        public PizzaDAO()
        {
            _pizzaOrder = new List<PizzaModel>();
        }

        public int AddPizzaToOrder(PizzaModel newPizza)
        {
            _pizzaOrder.Add(newPizza);

            return _pizzaOrder.Count;
        }
    }

