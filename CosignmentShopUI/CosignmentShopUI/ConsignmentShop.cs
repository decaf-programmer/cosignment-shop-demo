using CosignmentShopLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CosignmentShopUI
{
    public partial class ConsignmentShop : Form
    {
        private Store store = new Store();
        private List<Item> shoppingCartData = new List<Item>();
        BindingSource itemsBinding = new BindingSource();
        BindingSource cartBinding = new BindingSource();
        BindingSource vendorsBinding = new BindingSource();
        private double storeProfitValue = 0;
        
        public ConsignmentShop()
        {
            InitializeComponent();
            SetupData();

            itemsBinding.DataSource = store.Items.Where(x=>x.Sold == false).ToList();
            itemsListBox.DataSource = itemsBinding;

            itemsListBox.DisplayMember = "Display";
            itemsListBox.ValueMember = "Display";

            cartBinding.DataSource = shoppingCartData;
            shoppingCartListbox.DataSource = cartBinding;

            shoppingCartListbox.DisplayMember = "Display";
            shoppingCartListbox.ValueMember = "Display";

            vendorsBinding.DataSource = store.Vendors;
            vendorListbox.DataSource = vendorsBinding;

            vendorListbox.DisplayMember = "Display";
            vendorListbox.ValueMember = "Display";
        }
        
        private void SetupData()
        {
            store.Vendors.Add(new Vendor { FirstName = "Bill", LastName = "Smith", Commission = .5 });
            store.Vendors.Add(new Vendor { FirstName = "Sue", LastName = "Jones", Commission = .3 });
            store.Vendors.Add(new Vendor { FirstName = "Anith", LastName = "Trezeguet", Commission = .2 });

            store.Items.Add(new Item
            {
                Title = "Moby Dick",
                Description = "A book about a whale",
                Price = 4.50,
                Owner = store.Vendors[0]
            });

            store.Items.Add(new Item
            {
                Title = "A Tale of Two Cities",
                Description = "A book about a revolution",
                Price = 4.30,
                Owner = store.Vendors[1]
            });

            store.Items.Add(new Item
            {
                Title = "Jane Eyre",
                Description = "A book about a girl",
                Price = 3.80,
                Owner = store.Vendors[2]
            });

            store.Name = "Seconds are Better";

        }

        private void addCartButton_Click(object sender, EventArgs e)
        {
            Item selectedItem = (Item)itemsListBox.SelectedItem;
            shoppingCartData.Add(selectedItem);
            cartBinding.ResetBindings(false);
        }

        private void makePurchase_Click(object sender, EventArgs e)
        {
            foreach(Item item in shoppingCartData)
            {
                item.Sold = true;
                item.Owner.PaymentDue += item.Owner.Commission * item.Price;
                storeProfitValue += (1- item.Owner.Commission * item.Price);
            }
            shoppingCartData.Clear();

            itemsBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList();
            storeProfit.Text = string.Format("${0}", storeProfitValue);

            cartBinding.ResetBindings(false);
            itemsBinding.ResetBindings(false);
            vendorsBinding.ResetBindings(false);

        }
    }
}
