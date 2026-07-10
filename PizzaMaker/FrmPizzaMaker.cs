using PizzaMaker.Models;
using System.Drawing.Text;
using System.Text;
namespace PizzaMaker
{
    public partial class FrmPizzaMaker : Form
    {
        private PizzaModel pizzaModel;
        public FrmPizzaMaker()
        {
            InitializeComponent();
            pizzaModel = new PizzaModel();

            btnCreatePizza.Enabled = false;
            btnResetForm.Enabled = false;
        }

        private void EnablePizzaCreation()
        {
            btnCreatePizza.Enabled = true;
            btnResetForm.Enabled = true;
        }

        private void UpdatePrice()
        {
            decimal price = 15.00m;

            price += pizzaModel.Ingredients.Count * 0.50m;
            price += pizzaModel.StrangeAddOns.Count * 0.50m;

            if (pizzaModel.CrustType == "Gluten Free")
            {
                price += 1.00m;
            }

            lblPizzaPrice.Text = price.ToString("C");
            pizzaModel.Price = price;

            btnCreatePizza.Enabled = false;
            btnResetForm.Enabled = false;

            UpdatePrice();
        }

        private void ChbIngredientCheckChangedEH(object sender, EventArgs e)
        {
            pizzaModel.Ingredients.Clear();

            if (chbPepperoni.Checked) pizzaModel.Ingredients.Add("Pepperoni");
            if (chbBacon.Checked) pizzaModel.Ingredients.Add("Bacon");
            if (chbOlives.Checked) pizzaModel.Ingredients.Add("Olives");
            if (chbMushrooms.Checked) pizzaModel.Ingredients.Add("Mushrooms");
            if (chbPineapple.Checked) pizzaModel.Ingredients.Add("Pineapple");
            if (chbSausage.Checked) pizzaModel.Ingredients.Add("Sausage");
            if (chbPeppers.Checked) pizzaModel.Ingredients.Add("Peppers");
            if (chbTomatoes.Checked) pizzaModel.Ingredients.Add("Tomatoes");

            UpdatePrice();
        }



        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            pizzaModel.ClientName = txtName.Text;
            EnablePizzaCreation();
        }

        private void ChbIngredientCheckedChangeEH(object sender, EventArgs e)
        {
            UpdatePrice();
        }

        private void LsbStrangeAddOnsSelectedIndexChangeEH(object sender, EventArgs e)
        {
            pizzaModel.StrangeAddOns =
                lsbStrangeAddons.SelectedItems.Cast<string>().ToList();

            UpdatePrice();

        }

        private void RdoCrustCheckedChangeEH(object sender, EventArgs e)
        {

        }

        private void RdoCrustCheckedChange(object sender, EventArgs e)
        {

        }

        private void HsbExtraGoodiesValueChangedEH(object sender, EventArgs e)
        {

        }

        private void DtpDeliveryTimeValueChangeEH(object sender, EventArgs e)
        {
            pizzaModel.DeliveryTime = dtpDeliveryTime.Value;
        }
    }
}
