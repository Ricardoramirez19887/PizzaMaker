namespace PizzaMaker
{
    partial class FrmOrderDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblOrderDetails = new Label();
            dgvPizzaOrder = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvPizzaOrder).BeginInit();
            SuspendLayout();
            // 
            // lblOrderDetails
            // 
            lblOrderDetails.AutoSize = true;
            lblOrderDetails.Location = new Point(39, 58);
            lblOrderDetails.Name = "lblOrderDetails";
            lblOrderDetails.Size = new Size(50, 20);
            lblOrderDetails.TabIndex = 0;
            lblOrderDetails.Text = "label1";
            // 
            // dgvPizzaOrder
            // 
            dgvPizzaOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPizzaOrder.Location = new Point(127, 32);
            dgvPizzaOrder.Name = "dgvPizzaOrder";
            dgvPizzaOrder.RowHeadersWidth = 51;
            dgvPizzaOrder.Size = new Size(643, 406);
            dgvPizzaOrder.TabIndex = 1;
            // 
            // FrmOrderDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvPizzaOrder);
            Controls.Add(lblOrderDetails);
            Name = "FrmOrderDetails";
            Text = "Pizza Order Details";
            Load += FrmOrderDetails_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPizzaOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOrderDetails;
        private DataGridView dgvPizzaOrder;
    }
}