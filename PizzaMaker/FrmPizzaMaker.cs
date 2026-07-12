/*
 * Ricardo Ramirez
 * CST- 250
 * 7/7/26
 * PIzza Maker
 * Activity 4
 */

using System.Drawing.Text;
using System.Text;
using PizzaMakerClassLibrary.Models;
using PizzaMakerClassLibrary.Services.BusinessLogicLayer;

namespace PizzaMaker

{
    public partial class FrmPizzaMaker : Form
    {
        private PizzaModel pizzaModel;

        private PizzaLogic pizzaLogic;
        public FrmPizzaMaker()
        {
            InitializeComponent();
            pizzaModel = new PizzaModel();

            pizzaLogic = new PizzaLogic();

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
            pizzaModel.SauceQuantity = hsbSauce.Value;
            pizzaModel.CheeseQuantity = hsbCheese.Value;
        }

        private void DtpDeliveryTimeValueChangeEH(object sender, EventArgs e)
        {
            pizzaModel.DeliveryTime = dtpDeliveryTime.Value;
        }

        private void PicPizzaBoxColorClickEH(object sender, EventArgs e)
        {
            using ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                picPizzaBoxColor.BackColor = colorDialog.Color;
                pizzaModel.PizzaBoxColor = colorDialog.Color;

            }
        }

        private void FrmPizzaMaker_Load(object sender, EventArgs e)
        {

        }

        private void BtnResetFormClickEH(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ResetControls(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is TextBox)
                    ((TextBox)control).Clear();

                if (control is CheckBox)
                    ((CheckBox)control).Checked = false;

                if (control is RadioButton)
                    ((RadioButton)control).Checked = false;

                if (control is ListBox)
                    ((ListBox)control).ClearSelected();

                if (control is HScrollBar)
                    ((HScrollBar)control).Value = 0;

                if (control is DateTimePicker)
                    ((DateTimePicker)control).Value = DateTime.Now;

                if (control is PictureBox)
                    ((PictureBox)control).BackColor = Color.White;

                if (control.HasChildren)
                    ResetControls(control);
            }


            lblSauce.Text = "00";
            lblCheese.Text = "00";

            btnCreatePizza.Enabled = false;
            btnResetForm.Enabled = false;
            btnSeeFullOrder.Enabled = false;
        }



        private void ResetForm()
        {
            pizzaModel = new PizzaModel();

            ResetControls(this);
            UpdatePrice();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void grpExtraGoodies_Enter(object sender, EventArgs e)
        {

        }

        private void grpCrust_Enter(object sender, EventArgs e)
        {

        }

        private void BtnCreatePizzaClickEH(object sender, EventArgs e)
        {
            bool isValidPizza;
            int pizzaCount;

            (isValidPizza, pizzaCount) = pizzaLogic.AddPizzaToOrder(pizzaModel);

            if (isValidPizza)
            {
                ResetForm();
                btnSeeFullOrder.Enabled = true;
            }
        }

        private void btnSeeFullOrder_ClickEH(object sender, EventArgs e)
        {
            FrmOrderDetails frmOrderDetails =
                new FrmOrderDetails(pizzaLogic.GetPizzaOrder(), pizzaLogic);

            frmOrderDetails.ShowDialog();
        }
    }
}

