using System;
using System.Collections.Generic;
using System.Text;
using PizzaMakerClassLibrary.Models;
using System.IO;

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

    public List<PizzaModel> GetPizzaOrder()
    {
        return _pizzaOrder;
    }

    public bool WriteOrderToFile()
    {
        string directoryPath = Path.Combine(
          AppDomain.CurrentDomain.BaseDirectory,
          "App_Data");

        string pizzaString = "";

        if (!Directory.Exists(directoryPath))
        {
            Directory.CreateDirectory(directoryPath);
        }

        try
        {
            using StreamWriter writer = new StreamWriter(
              Path.Combine(directoryPath, "PizzaOrder.txt"));

            foreach (PizzaModel pizza in _pizzaOrder)
            {
                pizzaString =
                  $"Name: {pizza.ClientName}, " +
                  $"Ingredients: {string.Join(", ", pizza.Ingredients)}, " +
                  $"Strange Add Ons: {string.Join(", ", pizza.StrangeAddOns)}, " +
                  $"Crust: {pizza.CrustType}, " +
                  $"Sauce: {pizza.SauceQuantity}, " +
                  $"Cheese: {pizza.CheeseQuantity}, " +
                  $"Delivery Time: {pizza.DeliveryTime}, " +
                  $"Pizza Box Color: {pizza.PizzaBoxColor.Name}, " +
                  $"Price: {pizza.Price:C}";

                writer.WriteLine(pizzaString);
            }
        }
        catch
        {
            return false;
        }

        return true;
    }
}

       
         
    


