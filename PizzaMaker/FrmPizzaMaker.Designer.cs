namespace PizzaMaker
{
    partial class FrmPizzaMaker
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtName = new TextBox();
            grpIngredients = new GroupBox();
            chbBacon = new CheckBox();
            chbOlives = new CheckBox();
            chbMushrooms = new CheckBox();
            chbPineapple = new CheckBox();
            chbSausage = new CheckBox();
            chbPeppers = new CheckBox();
            chbTomatoes = new CheckBox();
            chbPepperoni = new CheckBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label2 = new Label();
            lsbStrangeAddons = new ListBox();
            grpCrust = new GroupBox();
            rdoGluttenFree = new RadioButton();
            rdoStuffedCrust = new RadioButton();
            rdoThinCrust = new RadioButton();
            rdoDeepDish = new RadioButton();
            grpExtraGoodies = new GroupBox();
            label6 = new Label();
            lblSauce = new Label();
            label4 = new Label();
            lblCheese = new Label();
            hsbCheese = new HScrollBar();
            hsbSauce = new HScrollBar();
            label3 = new Label();
            dtpDeliveryTime = new DateTimePicker();
            label5 = new Label();
            picPizzaBoxColor = new PictureBox();
            lblPizzaPrice = new Label();
            label8 = new Label();
            btnResetForm = new Button();
            btnCreatePizza = new Button();
            grpIngredients.SuspendLayout();
            grpCrust.SuspendLayout();
            grpExtraGoodies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPizzaBoxColor).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(69, 24);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(87, 19);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 30);
            txtName.TabIndex = 1;
            txtName.TextChanged += txtName_TextChanged;
            txtName.Leave += txtName_Leave;
            // 
            // grpIngredients
            // 
            grpIngredients.Controls.Add(chbBacon);
            grpIngredients.Controls.Add(chbOlives);
            grpIngredients.Controls.Add(chbMushrooms);
            grpIngredients.Controls.Add(chbPineapple);
            grpIngredients.Controls.Add(chbSausage);
            grpIngredients.Controls.Add(chbPeppers);
            grpIngredients.Controls.Add(chbTomatoes);
            grpIngredients.Controls.Add(chbPepperoni);
            grpIngredients.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpIngredients.Location = new Point(12, 58);
            grpIngredients.Name = "grpIngredients";
            grpIngredients.Size = new Size(180, 302);
            grpIngredients.TabIndex = 2;
            grpIngredients.TabStop = false;
            grpIngredients.Text = "Ingredients";
            // 
            // chbBacon
            // 
            chbBacon.AutoSize = true;
            chbBacon.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbBacon.Location = new Point(6, 63);
            chbBacon.Name = "chbBacon";
            chbBacon.Size = new Size(87, 28);
            chbBacon.TabIndex = 7;
            chbBacon.Text = "Bacon";
            chbBacon.UseVisualStyleBackColor = true;
            chbBacon.CheckedChanged += ChbIngredientCheckedChangeEH;
            // 
            // chbOlives
            // 
            chbOlives.AutoSize = true;
            chbOlives.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbOlives.Location = new Point(6, 97);
            chbOlives.Name = "chbOlives";
            chbOlives.Size = new Size(88, 28);
            chbOlives.TabIndex = 6;
            chbOlives.Text = "Olives";
            chbOlives.UseVisualStyleBackColor = true;
            chbOlives.CheckedChanged += ChbIngredientCheckedChangeEH;
            // 
            // chbMushrooms
            // 
            chbMushrooms.AutoSize = true;
            chbMushrooms.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbMushrooms.Location = new Point(6, 131);
            chbMushrooms.Name = "chbMushrooms";
            chbMushrooms.Size = new Size(141, 28);
            chbMushrooms.TabIndex = 5;
            chbMushrooms.Text = "Mushrooms";
            chbMushrooms.UseVisualStyleBackColor = true;
            chbMushrooms.CheckedChanged += ChbIngredientCheckedChangeEH;
            // 
            // chbPineapple
            // 
            chbPineapple.AutoSize = true;
            chbPineapple.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbPineapple.Location = new Point(6, 165);
            chbPineapple.Name = "chbPineapple";
            chbPineapple.Size = new Size(120, 28);
            chbPineapple.TabIndex = 4;
            chbPineapple.Text = "Pineapple";
            chbPineapple.UseVisualStyleBackColor = true;
            chbPineapple.CheckedChanged += ChbIngredientCheckedChangeEH;
            // 
            // chbSausage
            // 
            chbSausage.AutoSize = true;
            chbSausage.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbSausage.Location = new Point(6, 199);
            chbSausage.Name = "chbSausage";
            chbSausage.Size = new Size(104, 28);
            chbSausage.TabIndex = 3;
            chbSausage.Text = "Sausage";
            chbSausage.UseVisualStyleBackColor = true;
            chbSausage.CheckedChanged += ChbIngredientCheckedChangeEH;
            // 
            // chbPeppers
            // 
            chbPeppers.AutoSize = true;
            chbPeppers.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbPeppers.Location = new Point(6, 233);
            chbPeppers.Name = "chbPeppers";
            chbPeppers.Size = new Size(103, 28);
            chbPeppers.TabIndex = 2;
            chbPeppers.Text = "Peppers";
            chbPeppers.UseVisualStyleBackColor = true;
            chbPeppers.CheckedChanged += ChbIngredientCheckedChangeEH;
            // 
            // chbTomatoes
            // 
            chbTomatoes.AutoSize = true;
            chbTomatoes.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbTomatoes.Location = new Point(6, 267);
            chbTomatoes.Name = "chbTomatoes";
            chbTomatoes.Size = new Size(120, 28);
            chbTomatoes.TabIndex = 1;
            chbTomatoes.Text = "Tomatoes";
            chbTomatoes.UseVisualStyleBackColor = true;
            chbTomatoes.CheckedChanged += ChbIngredientCheckedChangeEH;
            // 
            // chbPepperoni
            // 
            chbPepperoni.AutoSize = true;
            chbPepperoni.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbPepperoni.Location = new Point(6, 29);
            chbPepperoni.Name = "chbPepperoni";
            chbPepperoni.Size = new Size(123, 28);
            chbPepperoni.TabIndex = 0;
            chbPepperoni.Text = "Pepperoni";
            chbPepperoni.UseVisualStyleBackColor = true;
            chbPepperoni.CheckedChanged += ChbIngredientCheckedChangeEH;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(237, 58);
            label2.Name = "label2";
            label2.Size = new Size(181, 24);
            label2.TabIndex = 3;
            label2.Text = "Strange Add Ons";
            // 
            // lsbStrangeAddons
            // 
            lsbStrangeAddons.FormattingEnabled = true;
            lsbStrangeAddons.Items.AddRange(new object[] { "Anchovies", "Chocolate", "Marshmallows", "Pickles", "Hot Cheetos", "Gummy Bears" });
            lsbStrangeAddons.Location = new Point(221, 87);
            lsbStrangeAddons.Name = "lsbStrangeAddons";
            lsbStrangeAddons.Size = new Size(197, 196);
            lsbStrangeAddons.TabIndex = 4;
            lsbStrangeAddons.SelectedIndexChanged += LsbStrangeAddOnsSelectedIndexChangeEH;
            // 
            // grpCrust
            // 
            grpCrust.Controls.Add(rdoGluttenFree);
            grpCrust.Controls.Add(rdoStuffedCrust);
            grpCrust.Controls.Add(rdoThinCrust);
            grpCrust.Controls.Add(rdoDeepDish);
            grpCrust.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpCrust.Location = new Point(460, 58);
            grpCrust.Name = "grpCrust";
            grpCrust.Size = new Size(177, 214);
            grpCrust.TabIndex = 5;
            grpCrust.TabStop = false;
            grpCrust.Text = "Crust";
            grpCrust.Enter += grpCrust_Enter;
            // 
            // rdoGluttenFree
            // 
            rdoGluttenFree.AutoSize = true;
            rdoGluttenFree.Location = new Point(6, 165);
            rdoGluttenFree.Name = "rdoGluttenFree";
            rdoGluttenFree.Size = new Size(151, 28);
            rdoGluttenFree.TabIndex = 8;
            rdoGluttenFree.TabStop = true;
            rdoGluttenFree.Text = "Gluten Free";
            rdoGluttenFree.UseVisualStyleBackColor = true;
            rdoGluttenFree.CheckedChanged += LsbStrangeAddOnsSelectedIndexChangeEH;
            // 
            // rdoStuffedCrust
            // 
            rdoStuffedCrust.AutoSize = true;
            rdoStuffedCrust.Location = new Point(6, 118);
            rdoStuffedCrust.Name = "rdoStuffedCrust";
            rdoStuffedCrust.Size = new Size(167, 28);
            rdoStuffedCrust.TabIndex = 9;
            rdoStuffedCrust.TabStop = true;
            rdoStuffedCrust.Text = "Stuffed Crust";
            rdoStuffedCrust.UseVisualStyleBackColor = true;
            rdoStuffedCrust.CheckedChanged += LsbStrangeAddOnsSelectedIndexChangeEH;
            // 
            // rdoThinCrust
            // 
            rdoThinCrust.AutoSize = true;
            rdoThinCrust.Location = new Point(6, 50);
            rdoThinCrust.Name = "rdoThinCrust";
            rdoThinCrust.Size = new Size(136, 28);
            rdoThinCrust.TabIndex = 7;
            rdoThinCrust.TabStop = true;
            rdoThinCrust.Text = "ThinCrust";
            rdoThinCrust.UseVisualStyleBackColor = true;
            rdoThinCrust.CheckedChanged += RdoCrustCheckedChangeEH;
            // 
            // rdoDeepDish
            // 
            rdoDeepDish.AutoSize = true;
            rdoDeepDish.Location = new Point(6, 84);
            rdoDeepDish.Name = "rdoDeepDish";
            rdoDeepDish.Size = new Size(136, 28);
            rdoDeepDish.TabIndex = 6;
            rdoDeepDish.TabStop = true;
            rdoDeepDish.Text = "Deep Dish";
            rdoDeepDish.UseVisualStyleBackColor = true;
            rdoDeepDish.CheckedChanged += RdoCrustCheckedChange;
            // 
            // grpExtraGoodies
            // 
            grpExtraGoodies.Controls.Add(label6);
            grpExtraGoodies.Controls.Add(lblSauce);
            grpExtraGoodies.Controls.Add(label4);
            grpExtraGoodies.Controls.Add(lblCheese);
            grpExtraGoodies.Controls.Add(hsbCheese);
            grpExtraGoodies.Controls.Add(hsbSauce);
            grpExtraGoodies.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpExtraGoodies.Location = new Point(33, 366);
            grpExtraGoodies.Name = "grpExtraGoodies";
            grpExtraGoodies.Size = new Size(600, 159);
            grpExtraGoodies.TabIndex = 6;
            grpExtraGoodies.TabStop = false;
            grpExtraGoodies.Text = "Extra Goodies";
            grpExtraGoodies.Enter += grpExtraGoodies_Enter;
            // 
            // label6
            // 
            label6.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(33, 37);
            label6.Name = "label6";
            label6.Size = new Size(197, 24);
            label6.TabIndex = 12;
            label6.Text = "Amount of Sauce";
            // 
            // lblSauce
            // 
            lblSauce.AutoSize = true;
            lblSauce.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSauce.Location = new Point(406, 37);
            lblSauce.Name = "lblSauce";
            lblSauce.Size = new Size(34, 24);
            lblSauce.TabIndex = 11;
            lblSauce.Text = "00";
            lblSauce.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(34, 87);
            label4.Name = "label4";
            label4.Size = new Size(175, 24);
            label4.TabIndex = 10;
            label4.Text = "Amount of Cheese";
            // 
            // lblCheese
            // 
            lblCheese.AutoSize = true;
            lblCheese.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCheese.Location = new Point(406, 89);
            lblCheese.Name = "lblCheese";
            lblCheese.Size = new Size(34, 24);
            lblCheese.TabIndex = 9;
            lblCheese.Text = "00";
            lblCheese.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // hsbCheese
            // 
            hsbCheese.Location = new Point(253, 87);
            hsbCheese.Name = "hsbCheese";
            hsbCheese.Size = new Size(100, 26);
            hsbCheese.TabIndex = 7;
            hsbCheese.ValueChanged += LsbStrangeAddOnsSelectedIndexChangeEH;
            // 
            // hsbSauce
            // 
            hsbSauce.Location = new Point(253, 37);
            hsbSauce.Name = "hsbSauce";
            hsbSauce.Size = new Size(100, 26);
            hsbSauce.TabIndex = 8;
            hsbSauce.ValueChanged += HsbExtraGoodiesValueChangedEH;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(671, 58);
            label3.Name = "label3";
            label3.Size = new Size(152, 24);
            label3.TabIndex = 7;
            label3.Text = "Delivery Time";
            label3.Click += label3_Click;
            // 
            // dtpDeliveryTime
            // 
            dtpDeliveryTime.Location = new Point(671, 87);
            dtpDeliveryTime.Name = "dtpDeliveryTime";
            dtpDeliveryTime.Size = new Size(321, 30);
            dtpDeliveryTime.TabIndex = 8;
            dtpDeliveryTime.ValueChanged += DtpDeliveryTimeValueChangeEH;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(671, 159);
            label5.Name = "label5";
            label5.Size = new Size(172, 24);
            label5.TabIndex = 9;
            label5.Text = "Pizza Box Color";
            label5.Click += label5_Click;
            // 
            // picPizzaBoxColor
            // 
            picPizzaBoxColor.BorderStyle = BorderStyle.FixedSingle;
            picPizzaBoxColor.Location = new Point(671, 186);
            picPizzaBoxColor.Name = "picPizzaBoxColor";
            picPizzaBoxColor.Size = new Size(125, 62);
            picPizzaBoxColor.TabIndex = 10;
            picPizzaBoxColor.TabStop = false;
            picPizzaBoxColor.Click += PicPizzaBoxColorClickEH;
            // 
            // lblPizzaPrice
            // 
            lblPizzaPrice.AutoSize = true;
            lblPizzaPrice.ForeColor = Color.Red;
            lblPizzaPrice.Location = new Point(1007, 156);
            lblPizzaPrice.Name = "lblPizzaPrice";
            lblPizzaPrice.Size = new Size(34, 24);
            lblPizzaPrice.TabIndex = 11;
            lblPizzaPrice.Text = "$0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(871, 159);
            label8.Name = "label8";
            label8.Size = new Size(130, 24);
            label8.TabIndex = 12;
            label8.Text = "Pizza Price:";
            // 
            // btnResetForm
            // 
            btnResetForm.Location = new Point(986, 483);
            btnResetForm.Name = "btnResetForm";
            btnResetForm.Size = new Size(152, 29);
            btnResetForm.TabIndex = 13;
            btnResetForm.Text = "Reset Form";
            btnResetForm.UseVisualStyleBackColor = true;
            btnResetForm.Click += BtnResetFormClickEH;
            // 
            // btnCreatePizza
            // 
            btnCreatePizza.Location = new Point(986, 448);
            btnCreatePizza.Name = "btnCreatePizza";
            btnCreatePizza.Size = new Size(165, 29);
            btnCreatePizza.TabIndex = 14;
            btnCreatePizza.Text = "Create Pizza";
            btnCreatePizza.UseVisualStyleBackColor = true;
            // 
            // FrmPizzaMaker
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 540);
            Controls.Add(btnCreatePizza);
            Controls.Add(btnResetForm);
            Controls.Add(label8);
            Controls.Add(lblPizzaPrice);
            Controls.Add(picPizzaBoxColor);
            Controls.Add(label5);
            Controls.Add(dtpDeliveryTime);
            Controls.Add(label3);
            Controls.Add(grpExtraGoodies);
            Controls.Add(grpCrust);
            Controls.Add(lsbStrangeAddons);
            Controls.Add(label2);
            Controls.Add(grpIngredients);
            Controls.Add(txtName);
            Controls.Add(label1);
            Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "FrmPizzaMaker";
            Text = "Reset Form";
            Load += FrmPizzaMaker_Load;
            grpIngredients.ResumeLayout(false);
            grpIngredients.PerformLayout();
            grpCrust.ResumeLayout(false);
            grpCrust.PerformLayout();
            grpExtraGoodies.ResumeLayout(false);
            grpExtraGoodies.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picPizzaBoxColor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private GroupBox grpIngredients;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private CheckBox chbBacon;
        private CheckBox chbOlives;
        private CheckBox chbMushrooms;
        private CheckBox chbPineapple;
        private CheckBox chbSausage;
        private CheckBox chbPeppers;
        private CheckBox chbTomatoes;
        private CheckBox chbPepperoni;
        private Label label2;
        private ListBox lsbStrangeAddons;
        private GroupBox grpCrust;
        private RadioButton rdoDeepDish;
        private RadioButton rdoThinCrust;
        private RadioButton rdoGluttenFree;
        private RadioButton rdoStuffedCrust;
        private GroupBox grpExtraGoodies;
        private HScrollBar hsbCheese;
        private HScrollBar hsbSauce;
        private Label label6;
        private Label lblSauce;
        private Label label4;
        private Label lblCheese;
        private Label label3;
        private DateTimePicker dtpDeliveryTime;
        private Label label5;
        private PictureBox picPizzaBoxColor;
        private Label lblPizzaPrice;
        private Label label8;
        private Button btnResetForm;
        private Button btnCreatePizza;
    }
}
