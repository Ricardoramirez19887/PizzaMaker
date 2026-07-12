using System;
using System.Collections.Generic;
using System.Text;
using PizzaMakerClassLibrary.Models;
using PizzaMakerClassLibrary.Services.DataAccesLayer;

namespace PizzaMakerClassLibrary.Services.BusinessLogicLayer
{
    public class PizzaLogic
    {
        public PizzaLogic()
        {
            PizzaDAO = new PizzaDAO();
        }

        public PizzaDAO PizzaDAO { get; }

        public (bool, int) AddPizzaToOrder(PizzaModel pizzaModel)
        {
            bool isValidPizza = pizzaModel != null;

            if (!isValidPizza)
            {
                return (false, 0);
            }

            int pizzaCount = PizzaDAO.AddPizzaToOrder(pizzaModel);

            return (true, pizzaCount);
        }
    }
}







