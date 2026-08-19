using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CABACUNGAN_OrderMealManagementSystem
{
    public partial class frm_OrderingForm : Form
    { 
        public frm_OrderingForm()
        {
            InitializeComponent();
        }
        private readonly Dictionary<string, double> prices = new Dictionary<string, double>() // This is my Collection which is the key and its value.
        {
            /*Main Dish*/ {"Chicken Adobo", 90}, {"Pork Adobo", 95}, {"Sinigang na Baboy", 110}, {"Kare-Kare", 120}, {"Bicol Express", 100}, {"Inihaw na Manok", 110}, {"Inihaw na Baboy", 115},
            {"Lumpiang Shanghai", 85}, {"Tinola", 95}, {"Bulalo", 150}, {"Humba", 105}, {"Afritada", 95}, {"Lechon Kawali", 120}, {"Sisig", 110}, {"Paksiw na Lechon", 115},
            /*Drinks*/ {"Calamansi Juice", 35}, {"Melon Chiller", 45}, {"Sago't Gulaman", 30}, {"Buko Pandan", 40}, {"Lambanog", 60}, {"Tuba", 50}, {"Apple Juice", 40},  
            /*AddOns*/ {"Atchara", 20}, {"Laing", 40}, {"Garlic Rice", 25}, {"Halo-Halo", 50}, {"Lumpia", 30}, {"Chicharon", 35}, {"Water", 15}, {"Extra-Rice", 20}     
        };
        public class OrderItem // THis is makes the object for the Items, Price and Quantity.
        {
            public string Name { get; set; }
            public int Quantity { get; set; }
            public double PricePerItem { get; set; }
            public double TotalPrice => Quantity * PricePerItem;
            public override string ToString()
            {
                return $"{Name} x{Quantity} - ₱{TotalPrice}";
            }
        }
        public class Order // this is also makes the objects for what is mentioned.
        {
            public string CustomerName { get; set; }
            public string ServingNumber { get; set; }
            public DateTime Date { get; set; }
            public string DineOption { get; set; }
            public string PaymentOption { get; set; }
            public List<OrderItem> OrderedItems { get; set; } = new List<OrderItem>();
            public double TotalAmount => OrderedItems.Sum(item => item.TotalPrice);
            public override string ToString() 
            {
                return $"{ServingNumber} | {CustomerName} | {Date:d} | {DineOption} | {PaymentOption} | Total: ₱{TotalAmount:F2}"; // to test or evalate.
            }
        }
        private void UpdateTotal() // Updates the Total each Time when called.
        {
            double total = 0;
            foreach (var item in lst_OrderedMeal.Items)
            {
                if (item is OrderItem order)
                {
                    total += order.TotalPrice;
                }
            }
            txt_Total.Text = $"₱{total:F2}";
        }
        private Random _rng = new Random();

        private void ResetServingNumber()
        {
            lbl_ServingDisplay.Text = "No. " + _rng.Next(100000, 9999999);
        }
        private void frm_OrderingForm_Load(object sender, EventArgs e) //For FormLoad.
        {
            lbl_ServingDisplay.Text = "No. " + new Random().Next(100000, 9999999);
            panelMainDish.Visible = true;
            panelAddons.Visible = false;
            panelDrinks.Visible = false;
            panelOrderSummary.Visible = false;
            UpdateTotal();
        }
        private void ClearOrder() //To clear.
        {
            txt_CostumerName.Clear();
            lst_OrderedMeal.Items.Clear();
            rb_DineIn.Checked = rb_TakeOut.Checked = rb_Delivery.Checked = false;
            rb_Cash.Checked = rb_EWallet.Checked = rb_OnlineBank.Checked = rb_Card.Checked = false;
            UpdateTotal();
        }
        private void AddItemToOrder(string item) //use for getting the order from the text in button.
        {
            if (!prices.TryGetValue(item, out double price)) return;

            bool found = false;
            for (int perClick = 0; perClick < lst_OrderedMeal.Items.Count; perClick++)
            {
                if (lst_OrderedMeal.Items[perClick] is OrderItem order)
                {
                    if (order.Name == item)
                    {
                        order.Quantity++;
                        lst_OrderedMeal.Items[perClick] = order;
                        found = true; break;
                    }
                }
            }
            if (!found)
            {
                lst_OrderedMeal.Items.Add(new OrderItem
                {
                    Name = item,
                    Quantity = 1,
                    PricePerItem = price
                });
            }
            UpdateTotal();
        }

        private void Btn_MainDish_Click(object sender, EventArgs e)
        { if (sender is Button btn) AddItemToOrder(btn.Text); }
        private void btn_Addons_Click(object sender, EventArgs e)
        { if (sender is Button btn) AddItemToOrder(btn.Text); }
        private void btn_Drinks_Click(object sender, EventArgs e)
        { if (sender is Button btn) AddItemToOrder(btn.Text); }
        
        private void gbtn_Remove_Click(object sender, EventArgs e)
        {
            if (lst_OrderedMeal.Items.Count == 0)
            {
                MessageBox.Show("No Area Selection. Please Select Something to Remove First.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (lst_OrderedMeal.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please Select An Item to Remove.", "",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            while (lst_OrderedMeal.SelectedIndices.Count > 0)
            {
                lst_OrderedMeal.Items.RemoveAt(lst_OrderedMeal.SelectedIndices[0]);
            }
            UpdateTotal();
        }
        private void gbtn_Minus_Click(object sender, EventArgs e)
        {
           
            if (lst_OrderedMeal.Items.Count == 0)
            {
                MessageBox.Show("No items in the order.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); return;
            }
            if (lst_OrderedMeal.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please Select An Item to Remove.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (lst_OrderedMeal.SelectedItem is OrderItem order)
            {
                order.Quantity--;

                if (order.Quantity <= 0)
                {
                    lst_OrderedMeal.Items.Remove(order);
                }
                else
                {
                    lst_OrderedMeal.Items[lst_OrderedMeal.SelectedIndex] = order;
                }
            }
            UpdateTotal();
        }
        private void gbtn_ClearAll_Click(object sender, EventArgs e)
        {
            if (lst_OrderedMeal.Items.Count > 0)
                ClearOrder();
            else MessageBox.Show("Order Already Cleared.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); UpdateTotal();
        }

        private void gbtn_Plus_Click(object sender, EventArgs e)
        {
            if (lst_OrderedMeal.SelectedItem is OrderItem order)
            {
                order.Quantity++;
                lst_OrderedMeal.Items[lst_OrderedMeal.SelectedIndex] = order;
            }
            else
            {
                MessageBox.Show("Please select an item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            UpdateTotal();
        }
        private void gbtn_MainDish_Click(object sender, EventArgs e)
        {
            panelMainDish.Visible = true;
            panelAddons.Visible = false;
            panelDrinks.Visible = false;
        }
        private void gbtn_Drinks_Click(object sender, EventArgs e)
        {
            panelDrinks.Visible = true;
            panelMainDish.Visible = false;
            panelAddons.Visible = false;
        }
        private void gbtn_AddOns_Click(object sender, EventArgs e)
        {
            panelAddons.Visible = true;
            panelMainDish.Visible = false;
            panelDrinks.Visible = false;
        }
        private void gbtn_PlaceOrder_Click(object sender, EventArgs e)
        {
            if (lst_OrderedMeal.Items.Count == 0)
            {
                MessageBox.Show("Please Add Your Order.", "Invalid Order", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool dineValid = rb_DineIn.Checked || rb_TakeOut.Checked || rb_Delivery.Checked;
            bool paymentValid = rb_Cash.Checked || rb_EWallet.Checked || rb_OnlineBank.Checked || rb_Card.Checked;
            gb_DineOption.Text = dineValid ? "Dine Option" : "Dine Option *";
            gb_Payment.Text = paymentValid ? "Payment Method" : "Payment Method *";
            gb_DineOption.ForeColor = dineValid ? SystemColors.ControlText : Color.Red;
            gb_Payment.ForeColor = paymentValid ? SystemColors.ControlText : Color.Red;
            if (!dineValid || !paymentValid)return;
            
            SubmitOrder();
            panelOrderSummary.Visible = true;
        }
        private void gbtn_CancelOrder_Click(object sender, EventArgs e)
        {
            if (lst_OrderedMeal.Items.Count == 0)
                MessageBox.Show("Order is empty.", "No Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (MessageBox.Show("Are you sure you want to cancel the order?", "Cancelation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                ClearOrder();
        }
        private string GetSelectedOption(params RadioButton[] buttons)
        {
            return buttons.FirstOrDefault(rb => rb.Checked)?.Tag?.ToString() ?? "";
        }
        private void SubmitOrder() // Create the all order
        {
            if (lst_OrderedMeal.Items.Count == 0)
            {
                MessageBox.Show("No items in the order!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string DineOption = GetSelectedOption(rb_DineIn, rb_TakeOut, rb_Delivery);
            string PaymentOption = GetSelectedOption(rb_Cash, rb_EWallet, rb_OnlineBank, rb_Card);

            Order order = new Order
            {
                CustomerName = txt_CostumerName.Text,
                ServingNumber = lbl_ServingDisplay.Text,
                Date = DateTime.Now,
                DineOption = DineOption,
                PaymentOption = PaymentOption,
                OrderedItems = lst_OrderedMeal.Items.Cast<OrderItem>().ToList()
            };


            string ordered = string.Join("\r\n", order.OrderedItems.Select(oi => oi.ToString())); 

            ListViewItem lvItem = new ListViewItem(order.ServingNumber); // Add to Lv_Order
            lvItem.SubItems.Add(order.CustomerName);
            lvItem.SubItems.Add(order.Date.ToString("g")); 
            lvItem.SubItems.Add(DineOption);
            lvItem.SubItems.Add(PaymentOption);
            lvItem.SubItems.Add("");      
            lvItem.SubItems.Add($"₱{order.TotalAmount:F2}"); 
            lv_Order.Items.Add(lvItem);

                foreach (var item in order.OrderedItems)
                {
                    ListViewItem RowItem = new ListViewItem(""); 
                    RowItem.SubItems.Add("");                     
                    RowItem.SubItems.Add("");                
                    RowItem.SubItems.Add("");                     
                    RowItem.SubItems.Add("");                    
                    RowItem.SubItems.Add("  " + item.ToString()); 
                    RowItem.SubItems.Add("");                     
                    lv_Order.Items.Add(RowItem);
                }
        }

        private void gbtn_Edit_Click(object sender, EventArgs e)
        {
            lv_Order.Items.Clear();
            panelOrderSummary.Visible = false; 
        }

        private void gbtn_AddOrder_Click(object sender, EventArgs e)
        {
            panelOrderSummary.Visible = false;
            ClearOrder();
            lv_Order.Items.Clear();
        }

        private void gbtn_Print_Click(object sender, EventArgs e)
        {
            string DineOption = GetSelectedOption(rb_DineIn, rb_TakeOut, rb_Delivery);
            string PaymentOption = GetSelectedOption(rb_Cash, rb_EWallet, rb_OnlineBank, rb_Card);

            Order order = new Order
            {
                CustomerName = txt_CostumerName.Text,
                ServingNumber = lbl_ServingDisplay.Text,
                Date = DateTime.Now,
                DineOption = DineOption,
                PaymentOption = PaymentOption,
                OrderedItems = lst_OrderedMeal.Items.Cast<OrderItem>().ToList()
            };
            var recieptForm = order;
            string equalLine = new string('=', 20);
            string separatorLine = new string('-', 40);
            string Center(string text) // to center sum text.
            {
                int width = 40;
                if (text.Length >= width) return text;
                int leftPadding = (width - text.Length) / 2;
                return new string(' ', leftPadding) + text;
            }

            string orderedItemsText = string.Join("\r\n", recieptForm.OrderedItems.Select(item => $"{item.Name,-20}{item.Quantity,3} x {item.TotalPrice,8:C}"));

            string receipt = Center("The Grand Marine") + "\r\n" + Center("     Restaurant") + "\r\n" + Center("    Official Receipt") + "\r\n" + equalLine + "\r\n" + $"Customer : {recieptForm.CustomerName}\r\n" +
                             $"Serving# : {recieptForm.ServingNumber}\r\n" + $"Date     : {order.Date.ToString("g")}\r\n" + separatorLine + "\r\n" + $"Dine     : {recieptForm.DineOption}\r\n" + $"Payment  : {recieptForm.PaymentOption}\r\n" +
                             separatorLine + "\r\n" + $"{"Item",-20}{"Qty",5}{"Price",10}\r\n" + separatorLine + "\r\n" + orderedItemsText + "\r\n" + separatorLine + "\r\n" + $"{"TOTAL:",-25}{recieptForm.OrderedItems.Sum(i => i.TotalPrice),15:C}\r\n" +
                             equalLine + "\r\n" + Center("Thank you for your order!") + "\r\n" + Center("Please come again, Marines!");

            DialogResult result = MessageBox.Show(receipt, "", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                ClearOrder();
                lv_Order.Items.Clear();
                panelMainDish.Visible = true;
                panelOrderSummary.Visible = false;
                panelDrinks.Visible = false;
                panelAddons.Visible = false;
                ResetServingNumber();
            }
        }
        private void gbtn_SignOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Sign Out?", "Sign Out", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                frm_LogInForm Out = new frm_LogInForm();
                Out.Show();
                this.Hide();
            }
        }
        private void btn_CloseMain_Click(object sender, EventArgs e) {Application.Exit();}
        private void btn_CloseMain_MouseEnter(object sender, EventArgs e) {btn_CloseMain.BackColor = Color.IndianRed;}
        private void btn_CloseMain_MouseLeave(object sender, EventArgs e) {btn_CloseMain.BackColor = SystemColors.Control;}
        private void btn_Close2_Click(object sender, EventArgs e){Application.Exit();}
        private void btn_Close2_MouseEnter(object sender, EventArgs e) {btn_Close2.BackColor = Color.IndianRed;}
        private void btn_Close2_MouseLeave(object sender, EventArgs e) {btn_Close2.BackColor = SystemColors.Control;}
    }
}