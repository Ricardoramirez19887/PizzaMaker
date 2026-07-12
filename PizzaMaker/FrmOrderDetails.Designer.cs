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
            // FrmOrderDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblOrderDetails);
            Name = "FrmOrderDetails";
            Text = "Pizza Order Details";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOrderDetails;
    }
}