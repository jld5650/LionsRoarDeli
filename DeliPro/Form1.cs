//Jorge Diaz
//DeliProject
//An app that helps employees at a Deli calculate the bill for their customers

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliPro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       //Dictionary
        Dictionary<string, float> cost, largeCost;


        private void Form1_Load(object sender, EventArgs e)
        {
            #region Dictionary Values
            //Adds string to comboboxes
            Special.Items.AddRange(new string[] { "The Chicken Salad", "The Works", "The Veggie" });
            Subs.Items.AddRange(new string[] { "Ham and Cheese", "Italian", "American" });
            Bev.Items.AddRange(new string[] { "Water", "Fountain Soda", "Bottled Soda", "Fresh Iced Tea" });
            Sides.Items.AddRange(new string[] { "Chips", "Cookies", "Cole Slaw", "Potato Salad" });

            //Price dictionaries
            cost = new Dictionary<string, float>();
            largeCost = new Dictionary<string, float>();
            
            // matches strings with float values
                    
                    //Large sub
                    largeCost["Ham and Cheese"] = 7.00f;
                    largeCost["Italian"] = 7.50f;
                    largeCost["American"] = 7.50f;
                    //Large Special
                    largeCost["The Chicken Salad"] = 7.00f;
                    largeCost["The Works"] = 8.00f;
                    largeCost["The Veggie"] = 6.00f;
                    //Large Beverage
                    largeCost["Water"] = .00f;
                    largeCost["Fountain Soda"] = 2.50f;
                    largeCost["Bottled Soda"] = 2.00f;
                    largeCost["Fresh Iced Tea"] = 2.00f;
                    //Large Sides
                    largeCost["Chips"] = 2.00f;
                    largeCost["Cookies"] = 2.25f;
                    largeCost["Cole Slaw"] = 3.00f;
                    largeCost["Potato Salad"] = 3.25f;
               
                    //Subs
                    cost["Ham and Cheese"] = 4.00f;
                    cost["Italian"] = 4.50f;
                    cost["American"] = 4.50f;
                    //Specials
                    cost["The Chicken Salad"] = 4.50f;
                    cost["The Works"] = 5.00f;
                    cost["The Veggie"] = 4.00f;
                    //Beverages
                    cost["Water"] = .00f;
                    cost["Fountain Soda"] = 1.50f;
                    cost["Bottled Soda"] = 1.75f;
                    cost["Fresh Iced Tea"] = 1.25f;
                    //Sides
                    cost["Chips"] = 1.00f;
                    cost["Cookies"] = 1.50f;
                    cost["Cole Slaw"] = 2.00f;
                    cost["Potato Salad"] = 2.50f;
                #endregion
            
        }
        //Place Order Button
        private void Order_Click(object sender, EventArgs e)
        {
            float orderTotal = 0;
            float tax;
            float total;
            float delivery = 3.00f;
            float delivery2 = 2.00f;
            float deliveryLimit3 = .01f;
            float deliveryLimit4 = 10.00f;
            float deliveryLimit1 = 10.01f;
            float deliveryLimit2 = 30.00f;
            
            #region Caculates Unchecked Items (Regular Priced)
            foreach (string food in yourFood.Items)
            {
                
                orderTotal += cost[food];
                tax = orderTotal * 0.06f;
                total = orderTotal + tax;
                orderTotalBox.Text = String.Format("{0:C}", orderTotal);
                taxBox.Text = String.Format("{0:C}", tax);

                if (discount.Checked)
                {
                    totalPriceBox.Text = String.Format("{0:C}", total - (orderTotal * .1));
                }
                else
                { totalPriceBox.Text = String.Format("{0:C}", total); }
                if (discount.Checked)
                {
                    if (deliveryChk.Checked)
                    {
                        if (deliveryLimit3 < total && total < deliveryLimit4)
                            totalPriceBox.Text = String.Format("{0:C}", (total + delivery) - (orderTotal * .1f));
                        if (deliveryLimit1 < total && total < deliveryLimit2)
                            totalPriceBox.Text = String.Format("{0:C}", (total + delivery2) - (orderTotal * .1f));
                        if (total > 30.01)
                            totalPriceBox.Text = String.Format("{0:C}", total - (orderTotal * .1f));
                    }
                }
                else
                    if (deliveryChk.Checked)
                    {
                        if (deliveryLimit3 < total && total < deliveryLimit4)
                            totalPriceBox.Text = String.Format("{0:C}", total + delivery);
                        if (deliveryLimit1 < total && total < deliveryLimit2)
                            totalPriceBox.Text = String.Format("{0:C}", total + delivery2);
                        if (total > 30.01)
                            totalPriceBox.Text = String.Format("{0:C}", total);

                    }

            }
          #endregion

            #region Calculates CheckedItems(larges)
            foreach (string food in yourFood.CheckedItems)
            { 
                  
                    orderTotal += largeCost[food] - cost[food];
                    tax = orderTotal * 0.06f;
                    total = orderTotal + tax;
                    orderTotalBox.Text = String.Format("{0:C}", orderTotal);
                    taxBox.Text = String.Format("{0:C}", tax);

                if (discount.Checked)
                    {
                        totalPriceBox.Text = String.Format("{0:C}", total - (orderTotal * .1));
                    }
                    else
                    { totalPriceBox.Text = String.Format("{0:C}", total); }
                   
                if (discount.Checked)
                    {
                        if (deliveryChk.Checked)
                        {
                            if (deliveryLimit3 < total && total < deliveryLimit4)
                                totalPriceBox.Text = String.Format("{0:C}", (total + delivery) - (orderTotal * .1f));
                            if (deliveryLimit1 < total && total < deliveryLimit2)
                                totalPriceBox.Text = String.Format("{0:C}", (total + delivery2) - (orderTotal * .1f));
                            if (total > 30.01)
                                totalPriceBox.Text = String.Format("{0:C}", total - (orderTotal * .1f));
                        }
                    }
                    else
                        if (deliveryChk.Checked)
                        {
                            if (deliveryLimit3 < total && total < deliveryLimit4)
                                totalPriceBox.Text = String.Format("{0:C}", total + delivery);
                            if (deliveryLimit1 < total && total < deliveryLimit2)
                                totalPriceBox.Text = String.Format("{0:C}", total + delivery2);
                            if (total > 30.01)
                                totalPriceBox.Text = String.Format("{0:C}", total);
                        }  
                  
            } 
           #endregion
         }
    
        #region Resets Application
        private void newOrder_Click(object sender, EventArgs e)
        
            
        {   
            //Clears TextBoxes and ListBoxes
            orderTotalBox.Text = String.Empty;
            taxBox.Text = String.Empty;
            totalPriceBox.Text = String.Empty;
            yourFood.Items.Clear();
            
            //Reset ComboBoxes
            Subs.SelectedIndex = -1;
            Special.SelectedIndex = -1;
            Sides.SelectedIndex = -1;
            Bev.SelectedIndex = -1;
            
            //Clears CheckBoxes
            deliveryChk.Checked = false;
            discount.Checked = false;
        }
        #endregion
        //Seperate Order Button
        private void sepOrder_Click(object sender, EventArgs e)
        {
            yourFood.Items.Clear();
            Subs.SelectedIndex = -1;
            Special.SelectedIndex = -1;
            Sides.SelectedIndex = -1;
            Bev.SelectedIndex = -1;
        }  
        
        //Delete Item Button
        private void deleteItm_Click(object sender, EventArgs e)
        {
             yourFood.Items.Remove(yourFood.SelectedItem); 
        }
       
         #region Add Item Buttons
        //Add traditional menu item
        private void getEntreeBtn_Click(object sender, EventArgs e)
        {  
            if (Subs.SelectedIndex > -1)
              { 
                    yourFood.Items.Add(Subs.SelectedItem);
              }
        }
        //Add special menu item
        private void getSpecialBtn_Click(object sender, EventArgs e)
        {   
            if (Special.SelectedIndex > -1) //if combobox value is selected
                { 
                    yourFood.Items.Add(Special.SelectedItem);  //Add item to listbox
                }
        }
        //add beverage menu item
        private void getBev_Click(object sender, EventArgs e)
        {
            if (Bev.SelectedIndex > -1)
                {
                    yourFood.Items.Add(Bev.SelectedItem);
                }
        }
        //add side menu item
        private void getSideBtn_Click(object sender, EventArgs e)
        {
            if (Sides.SelectedIndex > -1)
                {   
                yourFood.Items.Add(Sides.SelectedItem);
                
                }
        }
#endregion

         #region Unused Event Handlers
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {

        }
        private void menuTip_Popup(object sender, PopupEventArgs e)
        {

        }
        private void TaxLbl_Click(object sender, EventArgs e)
        {

        }
        private void yourFood_SelectedIndexChanged(object sender, EventArgs e)
        {

        } 
        private void discount_CheckedChanged(object sender, EventArgs e)
        {

        } 
        private void largeSub_CheckedChanged(object sender, EventArgs e)
        {
           
        }  
        private void deliveryChk_CheckedChanged(object sender, EventArgs e)
        {

        }   
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void button1_ControlAdded(object sender, ControlEventArgs e)
        {

        }       
        private void pictureBox2_Click(object sender, EventArgs e)
       


        {

        }
    #endregion

       
     }    
 }

