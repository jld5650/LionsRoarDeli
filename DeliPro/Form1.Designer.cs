namespace DeliPro
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Subs = new System.Windows.Forms.ComboBox();
            this.Order = new System.Windows.Forms.Button();
            this.orderTotalBox = new System.Windows.Forms.TextBox();
            this.taxBox = new System.Windows.Forms.TextBox();
            this.totalPriceBox = new System.Windows.Forms.TextBox();
            this.orderLbl = new System.Windows.Forms.Label();
            this.TaxLbl = new System.Windows.Forms.Label();
            this.totalPriceLbl = new System.Windows.Forms.Label();
            this.getEntreeBtn = new System.Windows.Forms.Button();
            this.deliveryChk = new System.Windows.Forms.CheckBox();
            this.newOrder = new System.Windows.Forms.Button();
            this.deleteItm = new System.Windows.Forms.Button();
            this.getSpecialBtn = new System.Windows.Forms.Button();
            this.Special = new System.Windows.Forms.ComboBox();
            this.sepOrder = new System.Windows.Forms.Button();
            this.tradLbl = new System.Windows.Forms.Label();
            this.specialLbl = new System.Windows.Forms.Label();
            this.discount = new System.Windows.Forms.CheckBox();
            this.Bev = new System.Windows.Forms.ComboBox();
            this.Sides = new System.Windows.Forms.ComboBox();
            this.getSideBtn = new System.Windows.Forms.Button();
            this.getBev = new System.Windows.Forms.Button();
            this.bevLbl = new System.Windows.Forms.Label();
            this.sideLbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.yourFood = new System.Windows.Forms.CheckedListBox();
            this.largeItemLbl = new System.Windows.Forms.Label();
            this.menuTips = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Subs
            // 
            this.Subs.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Subs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Subs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subs.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Subs.FormattingEnabled = true;
            this.Subs.Location = new System.Drawing.Point(12, 37);
            this.Subs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Subs.Name = "Subs";
            this.Subs.Size = new System.Drawing.Size(120, 21);
            this.Subs.TabIndex = 0;
            this.menuTips.SetToolTip(this.Subs, resources.GetString("Subs.ToolTip"));
            // 
            // Order
            // 
            this.Order.BackColor = System.Drawing.Color.GreenYellow;
            this.Order.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Order.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Order.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Order.Location = new System.Drawing.Point(241, 284);
            this.Order.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Order.Name = "Order";
            this.Order.Size = new System.Drawing.Size(274, 56);
            this.Order.TabIndex = 1;
            this.Order.Text = "Place Order";
            this.Order.UseVisualStyleBackColor = false;
            this.Order.Click += new System.EventHandler(this.Order_Click);
            // 
            // orderTotalBox
            // 
            this.orderTotalBox.BackColor = System.Drawing.Color.YellowGreen;
            this.orderTotalBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.orderTotalBox.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderTotalBox.ForeColor = System.Drawing.Color.MidnightBlue;
            this.orderTotalBox.Location = new System.Drawing.Point(301, 361);
            this.orderTotalBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.orderTotalBox.Multiline = true;
            this.orderTotalBox.Name = "orderTotalBox";
            this.orderTotalBox.Size = new System.Drawing.Size(60, 18);
            this.orderTotalBox.TabIndex = 2;
            // 
            // taxBox
            // 
            this.taxBox.BackColor = System.Drawing.Color.YellowGreen;
            this.taxBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.taxBox.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxBox.ForeColor = System.Drawing.Color.MidnightBlue;
            this.taxBox.Location = new System.Drawing.Point(301, 407);
            this.taxBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.taxBox.Multiline = true;
            this.taxBox.Name = "taxBox";
            this.taxBox.Size = new System.Drawing.Size(60, 19);
            this.taxBox.TabIndex = 3;
            // 
            // totalPriceBox
            // 
            this.totalPriceBox.BackColor = System.Drawing.Color.YellowGreen;
            this.totalPriceBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.totalPriceBox.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceBox.ForeColor = System.Drawing.Color.MidnightBlue;
            this.totalPriceBox.Location = new System.Drawing.Point(425, 389);
            this.totalPriceBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.totalPriceBox.Multiline = true;
            this.totalPriceBox.Name = "totalPriceBox";
            this.totalPriceBox.Size = new System.Drawing.Size(60, 20);
            this.totalPriceBox.TabIndex = 4;
            // 
            // orderLbl
            // 
            this.orderLbl.AutoSize = true;
            this.orderLbl.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderLbl.ForeColor = System.Drawing.Color.Black;
            this.orderLbl.Location = new System.Drawing.Point(237, 361);
            this.orderLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.orderLbl.Name = "orderLbl";
            this.orderLbl.Size = new System.Drawing.Size(56, 19);
            this.orderLbl.TabIndex = 5;
            this.orderLbl.Text = "Price:";
            // 
            // TaxLbl
            // 
            this.TaxLbl.AutoSize = true;
            this.TaxLbl.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaxLbl.ForeColor = System.Drawing.Color.Black;
            this.TaxLbl.Location = new System.Drawing.Point(249, 407);
            this.TaxLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TaxLbl.Name = "TaxLbl";
            this.TaxLbl.Size = new System.Drawing.Size(44, 19);
            this.TaxLbl.TabIndex = 6;
            this.TaxLbl.Text = "Tax:";
            this.TaxLbl.Click += new System.EventHandler(this.TaxLbl_Click);
            // 
            // totalPriceLbl
            // 
            this.totalPriceLbl.AutoSize = true;
            this.totalPriceLbl.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceLbl.ForeColor = System.Drawing.Color.Black;
            this.totalPriceLbl.Location = new System.Drawing.Point(399, 365);
            this.totalPriceLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalPriceLbl.Name = "totalPriceLbl";
            this.totalPriceLbl.Size = new System.Drawing.Size(116, 21);
            this.totalPriceLbl.TabIndex = 7;
            this.totalPriceLbl.Text = "Total Price";
            // 
            // getEntreeBtn
            // 
            this.getEntreeBtn.BackColor = System.Drawing.Color.GreenYellow;
            this.getEntreeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.getEntreeBtn.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getEntreeBtn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.getEntreeBtn.Location = new System.Drawing.Point(138, 36);
            this.getEntreeBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.getEntreeBtn.Name = "getEntreeBtn";
            this.getEntreeBtn.Size = new System.Drawing.Size(64, 22);
            this.getEntreeBtn.TabIndex = 8;
            this.getEntreeBtn.Text = "Add";
            this.getEntreeBtn.UseVisualStyleBackColor = false;
            this.getEntreeBtn.Click += new System.EventHandler(this.getEntreeBtn_Click);
            // 
            // deliveryChk
            // 
            this.deliveryChk.AutoSize = true;
            this.deliveryChk.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliveryChk.ForeColor = System.Drawing.Color.MidnightBlue;
            this.deliveryChk.Location = new System.Drawing.Point(371, 243);
            this.deliveryChk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.deliveryChk.Name = "deliveryChk";
            this.deliveryChk.Size = new System.Drawing.Size(91, 19);
            this.deliveryChk.TabIndex = 10;
            this.deliveryChk.Text = "Delivery?";
            this.deliveryChk.UseVisualStyleBackColor = true;
            this.deliveryChk.CheckedChanged += new System.EventHandler(this.deliveryChk_CheckedChanged);
            // 
            // newOrder
            // 
            this.newOrder.BackColor = System.Drawing.Color.GreenYellow;
            this.newOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.newOrder.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newOrder.ForeColor = System.Drawing.Color.MidnightBlue;
            this.newOrder.Location = new System.Drawing.Point(16, 389);
            this.newOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.newOrder.Name = "newOrder";
            this.newOrder.Size = new System.Drawing.Size(190, 50);
            this.newOrder.TabIndex = 11;
            this.newOrder.Text = "New Order";
            this.newOrder.UseVisualStyleBackColor = false;
            this.newOrder.Click += new System.EventHandler(this.newOrder_Click);
            // 
            // deleteItm
            // 
            this.deleteItm.BackColor = System.Drawing.Color.GreenYellow;
            this.deleteItm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteItm.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteItm.ForeColor = System.Drawing.Color.MidnightBlue;
            this.deleteItm.Location = new System.Drawing.Point(16, 284);
            this.deleteItm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.deleteItm.Name = "deleteItm";
            this.deleteItm.Size = new System.Drawing.Size(190, 47);
            this.deleteItm.TabIndex = 12;
            this.deleteItm.Text = "Delete Item";
            this.deleteItm.UseVisualStyleBackColor = false;
            this.deleteItm.Click += new System.EventHandler(this.deleteItm_Click);
            // 
            // getSpecialBtn
            // 
            this.getSpecialBtn.BackColor = System.Drawing.Color.GreenYellow;
            this.getSpecialBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.getSpecialBtn.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getSpecialBtn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.getSpecialBtn.Location = new System.Drawing.Point(138, 78);
            this.getSpecialBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.getSpecialBtn.Name = "getSpecialBtn";
            this.getSpecialBtn.Size = new System.Drawing.Size(64, 22);
            this.getSpecialBtn.TabIndex = 13;
            this.getSpecialBtn.Text = "Add";
            this.getSpecialBtn.UseVisualStyleBackColor = false;
            this.getSpecialBtn.Click += new System.EventHandler(this.getSpecialBtn_Click);
            // 
            // Special
            // 
            this.Special.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Special.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Special.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Special.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Special.FormattingEnabled = true;
            this.Special.Location = new System.Drawing.Point(12, 79);
            this.Special.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Special.Name = "Special";
            this.Special.Size = new System.Drawing.Size(120, 21);
            this.Special.TabIndex = 14;
            this.menuTips.SetToolTip(this.Special, resources.GetString("Special.ToolTip"));
            // 
            // sepOrder
            // 
            this.sepOrder.BackColor = System.Drawing.Color.GreenYellow;
            this.sepOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sepOrder.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sepOrder.ForeColor = System.Drawing.Color.MidnightBlue;
            this.sepOrder.Location = new System.Drawing.Point(16, 337);
            this.sepOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sepOrder.Name = "sepOrder";
            this.sepOrder.Size = new System.Drawing.Size(190, 46);
            this.sepOrder.TabIndex = 16;
            this.sepOrder.Text = "Seperate Order";
            this.sepOrder.UseVisualStyleBackColor = false;
            this.sepOrder.Click += new System.EventHandler(this.sepOrder_Click);
            // 
            // tradLbl
            // 
            this.tradLbl.AutoSize = true;
            this.tradLbl.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tradLbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tradLbl.Location = new System.Drawing.Point(12, 14);
            this.tradLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tradLbl.Name = "tradLbl";
            this.tradLbl.Size = new System.Drawing.Size(146, 19);
            this.tradLbl.TabIndex = 17;
            this.tradLbl.Text = "Traditional Subs";
            // 
            // specialLbl
            // 
            this.specialLbl.AutoSize = true;
            this.specialLbl.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specialLbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.specialLbl.Location = new System.Drawing.Point(11, 57);
            this.specialLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.specialLbl.Name = "specialLbl";
            this.specialLbl.Size = new System.Drawing.Size(127, 19);
            this.specialLbl.TabIndex = 18;
            this.specialLbl.Text = "Specialty Subs";
            // 
            // discount
            // 
            this.discount.AutoSize = true;
            this.discount.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discount.ForeColor = System.Drawing.Color.MidnightBlue;
            this.discount.Location = new System.Drawing.Point(107, 243);
            this.discount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.discount.Name = "discount";
            this.discount.Size = new System.Drawing.Size(201, 19);
            this.discount.TabIndex = 19;
            this.discount.Text = "Student/Faculty Discount";
            this.discount.UseVisualStyleBackColor = true;
            this.discount.CheckedChanged += new System.EventHandler(this.discount_CheckedChanged);
            // 
            // Bev
            // 
            this.Bev.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Bev.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Bev.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bev.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Bev.FormattingEnabled = true;
            this.Bev.Location = new System.Drawing.Point(12, 124);
            this.Bev.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Bev.Name = "Bev";
            this.Bev.Size = new System.Drawing.Size(120, 21);
            this.Bev.TabIndex = 20;
            this.menuTips.SetToolTip(this.Bev, resources.GetString("Bev.ToolTip"));
            // 
            // Sides
            // 
            this.Sides.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Sides.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Sides.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sides.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Sides.FormattingEnabled = true;
            this.Sides.Location = new System.Drawing.Point(12, 168);
            this.Sides.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Sides.Name = "Sides";
            this.Sides.Size = new System.Drawing.Size(120, 21);
            this.Sides.TabIndex = 21;
            this.menuTips.SetToolTip(this.Sides, resources.GetString("Sides.ToolTip"));
            // 
            // getSideBtn
            // 
            this.getSideBtn.BackColor = System.Drawing.Color.GreenYellow;
            this.getSideBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.getSideBtn.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getSideBtn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.getSideBtn.Location = new System.Drawing.Point(138, 167);
            this.getSideBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.getSideBtn.Name = "getSideBtn";
            this.getSideBtn.Size = new System.Drawing.Size(64, 22);
            this.getSideBtn.TabIndex = 23;
            this.getSideBtn.Text = "Add";
            this.getSideBtn.UseVisualStyleBackColor = false;
            this.getSideBtn.Click += new System.EventHandler(this.getSideBtn_Click);
            // 
            // getBev
            // 
            this.getBev.BackColor = System.Drawing.Color.GreenYellow;
            this.getBev.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.getBev.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getBev.ForeColor = System.Drawing.Color.MidnightBlue;
            this.getBev.Location = new System.Drawing.Point(138, 123);
            this.getBev.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.getBev.Name = "getBev";
            this.getBev.Size = new System.Drawing.Size(64, 22);
            this.getBev.TabIndex = 24;
            this.getBev.Text = "Add";
            this.getBev.UseVisualStyleBackColor = false;
            this.getBev.Click += new System.EventHandler(this.getBev_Click);
            // 
            // bevLbl
            // 
            this.bevLbl.AutoSize = true;
            this.bevLbl.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bevLbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.bevLbl.Location = new System.Drawing.Point(12, 102);
            this.bevLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bevLbl.Name = "bevLbl";
            this.bevLbl.Size = new System.Drawing.Size(89, 19);
            this.bevLbl.TabIndex = 25;
            this.bevLbl.Text = "Beverages";
            // 
            // sideLbl
            // 
            this.sideLbl.AutoSize = true;
            this.sideLbl.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sideLbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.sideLbl.Location = new System.Drawing.Point(12, 146);
            this.sideLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sideLbl.Name = "sideLbl";
            this.sideLbl.Size = new System.Drawing.Size(51, 19);
            this.sideLbl.TabIndex = 26;
            this.sideLbl.Text = "Sides";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.YellowGreen;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.textBox1.Location = new System.Drawing.Point(12, 204);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 13);
            this.textBox1.TabIndex = 27;
            this.textBox1.Text = "Special Requests...";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // yourFood
            // 
            this.yourFood.BackColor = System.Drawing.Color.YellowGreen;
            this.yourFood.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.yourFood.CheckOnClick = true;
            this.yourFood.Dock = System.Windows.Forms.DockStyle.Right;
            this.yourFood.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourFood.ForeColor = System.Drawing.Color.MidnightBlue;
            this.yourFood.FormattingEnabled = true;
            this.yourFood.Location = new System.Drawing.Point(523, 0);
            this.yourFood.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.yourFood.Name = "yourFood";
            this.yourFood.Size = new System.Drawing.Size(156, 453);
            this.yourFood.TabIndex = 28;
            this.yourFood.SelectedIndexChanged += new System.EventHandler(this.yourFood_SelectedIndexChanged);
            // 
            // largeItemLbl
            // 
            this.largeItemLbl.AutoSize = true;
            this.largeItemLbl.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.largeItemLbl.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.largeItemLbl.Location = new System.Drawing.Point(327, 0);
            this.largeItemLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.largeItemLbl.Name = "largeItemLbl";
            this.largeItemLbl.Size = new System.Drawing.Size(188, 19);
            this.largeItemLbl.TabIndex = 29;
            this.largeItemLbl.Text = "Check items for large!";
            // 
            // menuTips
            // 
            this.menuTips.AutoPopDelay = 7900;
            this.menuTips.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuTips.ForeColor = System.Drawing.Color.Black;
            this.menuTips.InitialDelay = 50;
            this.menuTips.IsBalloon = true;
            this.menuTips.ReshowDelay = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(359, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 15);
            this.label1.TabIndex = 30;
            this.label1.Text = "Check items for large!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(185, 192);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(336, 36);
            this.label2.TabIndex = 34;
            this.label2.Text = "LION\'S ROAR DELI!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(314, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 57);
            this.label3.TabIndex = 35;
            this.label3.Text = "   Best \r\n     in \r\n Town!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DeliPro.Properties.Resources.Man_eats_sandwich;
            this.pictureBox1.Location = new System.Drawing.Point(340, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 152);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DeliPro.Properties.Resources.sandwich1;
            this.pictureBox2.Location = new System.Drawing.Point(209, 37);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(125, 152);
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(679, 453);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.largeItemLbl);
            this.Controls.Add(this.yourFood);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.sideLbl);
            this.Controls.Add(this.bevLbl);
            this.Controls.Add(this.getBev);
            this.Controls.Add(this.getSideBtn);
            this.Controls.Add(this.Sides);
            this.Controls.Add(this.Bev);
            this.Controls.Add(this.discount);
            this.Controls.Add(this.specialLbl);
            this.Controls.Add(this.tradLbl);
            this.Controls.Add(this.sepOrder);
            this.Controls.Add(this.Special);
            this.Controls.Add(this.getSpecialBtn);
            this.Controls.Add(this.deleteItm);
            this.Controls.Add(this.newOrder);
            this.Controls.Add(this.deliveryChk);
            this.Controls.Add(this.getEntreeBtn);
            this.Controls.Add(this.totalPriceLbl);
            this.Controls.Add(this.TaxLbl);
            this.Controls.Add(this.orderLbl);
            this.Controls.Add(this.totalPriceBox);
            this.Controls.Add(this.taxBox);
            this.Controls.Add(this.orderTotalBox);
            this.Controls.Add(this.Order);
            this.Controls.Add(this.Subs);
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Lion\'s Roar Deli";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Subs;
        private System.Windows.Forms.Button Order;
        private System.Windows.Forms.TextBox orderTotalBox;
        private System.Windows.Forms.TextBox taxBox;
        private System.Windows.Forms.TextBox totalPriceBox;
        private System.Windows.Forms.Label orderLbl;
        private System.Windows.Forms.Label TaxLbl;
        private System.Windows.Forms.Label totalPriceLbl;
        private System.Windows.Forms.Button getEntreeBtn;
        private System.Windows.Forms.CheckBox deliveryChk;
        private System.Windows.Forms.Button newOrder;
        private System.Windows.Forms.Button deleteItm;
        private System.Windows.Forms.Button getSpecialBtn;
        private System.Windows.Forms.ComboBox Special;
        private System.Windows.Forms.Button sepOrder;
        private System.Windows.Forms.Label tradLbl;
        private System.Windows.Forms.Label specialLbl;
        private System.Windows.Forms.CheckBox discount;
        private System.Windows.Forms.ComboBox Bev;
        private System.Windows.Forms.ComboBox Sides;
        private System.Windows.Forms.Button getSideBtn;
        private System.Windows.Forms.Button getBev;
        private System.Windows.Forms.Label bevLbl;
        private System.Windows.Forms.Label sideLbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckedListBox yourFood;
        private System.Windows.Forms.Label largeItemLbl;
        private System.Windows.Forms.ToolTip menuTips;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

    }
}

