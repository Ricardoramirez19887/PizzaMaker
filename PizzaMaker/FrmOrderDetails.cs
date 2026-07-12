using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PizzaMakerClassLibrary.Models;
using PizzaMakerClassLibrary.Services.BusinessLogicLayer;

// Citation: Grand Canyon University. (2025).
// CST-250 Activity 4: Building a Data-Driven Pizza ORder System with N-Layer Achitechture.

namespace PizzaMaker
{
    public partial class FrmOrderDetails : Form
    {
        private List<PizzaModel> _pizzaOrders;
        private PizzaLogic _pizzaLogic;
        public FrmOrderDetails(List<PizzaModel> pizzaOrders, PizzaLogic pizzaLogic)
        {
            InitializeComponent();

            _pizzaOrders = pizzaOrders;
            _pizzaLogic = pizzaLogic;

            DisplayPizzas();
        }

        private void DisplayPizzas()
        {
            dgvPizzaOrder.DataSource = null;
            dgvPizzaOrder.DataSource = _pizzaOrders;
        }

        private void FrmOrderDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
