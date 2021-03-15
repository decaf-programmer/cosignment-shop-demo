
namespace CosignmentShopUI
{
    partial class ConsignmentShop
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
            this.headerText = new System.Windows.Forms.Label();
            this.itemsListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addCartButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.shoppingCartListbox = new System.Windows.Forms.ListBox();
            this.makePurchase = new System.Windows.Forms.Button();
            this.vendorListbox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.storeProfit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // headerText
            // 
            this.headerText.AutoSize = true;
            this.headerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerText.Location = new System.Drawing.Point(48, 71);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(369, 33);
            this.headerText.TabIndex = 0;
            this.headerText.Text = "Consignment Shop Demo";
            // 
            // itemsListBox
            // 
            this.itemsListBox.FormattingEnabled = true;
            this.itemsListBox.ItemHeight = 20;
            this.itemsListBox.Location = new System.Drawing.Point(54, 177);
            this.itemsListBox.Name = "itemsListBox";
            this.itemsListBox.Size = new System.Drawing.Size(289, 204);
            this.itemsListBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Store Items";
            // 
            // addCartButton
            // 
            this.addCartButton.Location = new System.Drawing.Point(405, 238);
            this.addCartButton.Name = "addCartButton";
            this.addCartButton.Size = new System.Drawing.Size(129, 51);
            this.addCartButton.TabIndex = 3;
            this.addCartButton.Text = "Add To Cart";
            this.addCartButton.UseVisualStyleBackColor = true;
            this.addCartButton.Click += new System.EventHandler(this.addCartButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(591, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Shopping Cart";
            // 
            // shoppingCartListbox
            // 
            this.shoppingCartListbox.FormattingEnabled = true;
            this.shoppingCartListbox.ItemHeight = 20;
            this.shoppingCartListbox.Location = new System.Drawing.Point(597, 177);
            this.shoppingCartListbox.Name = "shoppingCartListbox";
            this.shoppingCartListbox.Size = new System.Drawing.Size(297, 204);
            this.shoppingCartListbox.TabIndex = 4;
            // 
            // makePurchase
            // 
            this.makePurchase.Location = new System.Drawing.Point(761, 387);
            this.makePurchase.Name = "makePurchase";
            this.makePurchase.Size = new System.Drawing.Size(133, 47);
            this.makePurchase.TabIndex = 6;
            this.makePurchase.Text = "Purchase";
            this.makePurchase.UseVisualStyleBackColor = true;
            this.makePurchase.Click += new System.EventHandler(this.makePurchase_Click);
            // 
            // vendorListbox
            // 
            this.vendorListbox.FormattingEnabled = true;
            this.vendorListbox.ItemHeight = 20;
            this.vendorListbox.Location = new System.Drawing.Point(54, 430);
            this.vendorListbox.Name = "vendorListbox";
            this.vendorListbox.Size = new System.Drawing.Size(289, 204);
            this.vendorListbox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Vendors";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(598, 436);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Store Profit:";
            // 
            // storeProfit
            // 
            this.storeProfit.AutoSize = true;
            this.storeProfit.Location = new System.Drawing.Point(697, 436);
            this.storeProfit.Name = "storeProfit";
            this.storeProfit.Size = new System.Drawing.Size(0, 20);
            this.storeProfit.TabIndex = 10;
            // 
            // ConsignmentShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 678);
            this.Controls.Add(this.storeProfit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.vendorListbox);
            this.Controls.Add(this.makePurchase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.shoppingCartListbox);
            this.Controls.Add(this.addCartButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.itemsListBox);
            this.Controls.Add(this.headerText);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ConsignmentShop";
            this.Text = "CosignmentShop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerText;
        private System.Windows.Forms.ListBox itemsListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addCartButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox shoppingCartListbox;
        private System.Windows.Forms.Button makePurchase;
        private System.Windows.Forms.ListBox vendorListbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label storeProfit;
    }
}

