
namespace CashierApp
{
    partial class MainForm
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
            this.lboxProducts = new System.Windows.Forms.ListBox();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.cbSubCategory = new System.Windows.Forms.ComboBox();
            this.lbWelcome = new System.Windows.Forms.Label();
            this.lbSubCategory = new System.Windows.Forms.Label();
            this.lbCategory = new System.Windows.Forms.Label();
            this.lbDepartment = new System.Windows.Forms.Label();
            this.lboxBasket = new System.Windows.Forms.ListBox();
            this.nudProductQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnAddToBasket = new System.Windows.Forms.Button();
            this.gbProducts = new System.Windows.Forms.GroupBox();
            this.gbQuantity = new System.Windows.Forms.GroupBox();
            this.tbProductPrice = new System.Windows.Forms.TextBox();
            this.lbProductPrice = new System.Windows.Forms.Label();
            this.tbFinalPrice = new System.Windows.Forms.TextBox();
            this.gbBasket = new System.Windows.Forms.GroupBox();
            this.btnClearBascet = new System.Windows.Forms.Button();
            this.btnRemoveProduct = new System.Windows.Forms.Button();
            this.btnRemovePiece = new System.Windows.Forms.Button();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.gbFinishOrder = new System.Windows.Forms.GroupBox();
            this.rbtnCard = new System.Windows.Forms.RadioButton();
            this.rbtnCash = new System.Windows.Forms.RadioButton();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.statusBox = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnLogOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudProductQuantity)).BeginInit();
            this.gbProducts.SuspendLayout();
            this.gbQuantity.SuspendLayout();
            this.gbBasket.SuspendLayout();
            this.gbFinishOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lboxProducts
            // 
            this.lboxProducts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lboxProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboxProducts.FormattingEnabled = true;
            this.lboxProducts.ItemHeight = 22;
            this.lboxProducts.Location = new System.Drawing.Point(21, 40);
            this.lboxProducts.Margin = new System.Windows.Forms.Padding(2);
            this.lboxProducts.Name = "lboxProducts";
            this.lboxProducts.Size = new System.Drawing.Size(330, 466);
            this.lboxProducts.TabIndex = 0;
            this.lboxProducts.SelectedIndexChanged += new System.EventHandler(this.lboxProducts_SelectedIndexChanged);
            // 
            // cbDepartment
            // 
            this.cbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Location = new System.Drawing.Point(355, 63);
            this.cbDepartment.Margin = new System.Windows.Forms.Padding(2);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(215, 33);
            this.cbDepartment.TabIndex = 1;
            this.cbDepartment.TabStop = false;
            this.cbDepartment.SelectedIndexChanged += new System.EventHandler(this.cbDepartment_SelectedIndexChanged);
            this.cbDepartment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxes_KeyPress);
            // 
            // cbCategory
            // 
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(355, 125);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(2);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(215, 33);
            this.cbCategory.TabIndex = 2;
            this.cbCategory.TabStop = false;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            this.cbCategory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxes_KeyPress);
            // 
            // cbSubCategory
            // 
            this.cbSubCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSubCategory.FormattingEnabled = true;
            this.cbSubCategory.Location = new System.Drawing.Point(355, 188);
            this.cbSubCategory.Margin = new System.Windows.Forms.Padding(2);
            this.cbSubCategory.Name = "cbSubCategory";
            this.cbSubCategory.Size = new System.Drawing.Size(215, 33);
            this.cbSubCategory.TabIndex = 3;
            this.cbSubCategory.TabStop = false;
            this.cbSubCategory.SelectedIndexChanged += new System.EventHandler(this.cbSubCategory_SelectedIndexChanged);
            this.cbSubCategory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxes_KeyPress);
            // 
            // lbWelcome
            // 
            this.lbWelcome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbWelcome.Font = new System.Drawing.Font("Myanmar Text", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWelcome.Location = new System.Drawing.Point(11, 28);
            this.lbWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(1458, 38);
            this.lbWelcome.TabIndex = 5;
            this.lbWelcome.Text = "Have a good day";
            this.lbWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSubCategory
            // 
            this.lbSubCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubCategory.Location = new System.Drawing.Point(356, 160);
            this.lbSubCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSubCategory.Name = "lbSubCategory";
            this.lbSubCategory.Size = new System.Drawing.Size(214, 25);
            this.lbSubCategory.TabIndex = 88;
            this.lbSubCategory.Text = "Subcategory";
            this.lbSubCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCategory
            // 
            this.lbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategory.Location = new System.Drawing.Point(356, 95);
            this.lbCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(214, 28);
            this.lbCategory.TabIndex = 89;
            this.lbCategory.Text = "Category";
            this.lbCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDepartment
            // 
            this.lbDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDepartment.Location = new System.Drawing.Point(356, 40);
            this.lbDepartment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDepartment.Name = "lbDepartment";
            this.lbDepartment.Size = new System.Drawing.Size(214, 20);
            this.lbDepartment.TabIndex = 90;
            this.lbDepartment.Text = "Department";
            this.lbDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lboxBasket
            // 
            this.lboxBasket.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lboxBasket.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboxBasket.FormattingEnabled = true;
            this.lboxBasket.ItemHeight = 22;
            this.lboxBasket.Location = new System.Drawing.Point(26, 42);
            this.lboxBasket.Margin = new System.Windows.Forms.Padding(2);
            this.lboxBasket.Name = "lboxBasket";
            this.lboxBasket.Size = new System.Drawing.Size(426, 378);
            this.lboxBasket.TabIndex = 91;
            // 
            // nudProductQuantity
            // 
            this.nudProductQuantity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nudProductQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudProductQuantity.Location = new System.Drawing.Point(44, 33);
            this.nudProductQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.nudProductQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudProductQuantity.Name = "nudProductQuantity";
            this.nudProductQuantity.ReadOnly = true;
            this.nudProductQuantity.Size = new System.Drawing.Size(128, 30);
            this.nudProductQuantity.TabIndex = 92;
            this.nudProductQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudProductQuantity.ValueChanged += new System.EventHandler(this.nudProductQuantity_ValueChanged);
            // 
            // btnAddToBasket
            // 
            this.btnAddToBasket.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddToBasket.BackColor = System.Drawing.Color.Bisque;
            this.btnAddToBasket.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddToBasket.Location = new System.Drawing.Point(8, 117);
            this.btnAddToBasket.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddToBasket.Name = "btnAddToBasket";
            this.btnAddToBasket.Size = new System.Drawing.Size(199, 37);
            this.btnAddToBasket.TabIndex = 94;
            this.btnAddToBasket.Text = "Add to basket";
            this.btnAddToBasket.UseVisualStyleBackColor = false;
            this.btnAddToBasket.Click += new System.EventHandler(this.btnAddToBasket_Click);
            // 
            // gbProducts
            // 
            this.gbProducts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbProducts.Controls.Add(this.gbQuantity);
            this.gbProducts.Controls.Add(this.lboxProducts);
            this.gbProducts.Controls.Add(this.cbDepartment);
            this.gbProducts.Controls.Add(this.cbCategory);
            this.gbProducts.Controls.Add(this.cbSubCategory);
            this.gbProducts.Controls.Add(this.lbDepartment);
            this.gbProducts.Controls.Add(this.lbCategory);
            this.gbProducts.Controls.Add(this.lbSubCategory);
            this.gbProducts.Location = new System.Drawing.Point(26, 85);
            this.gbProducts.Name = "gbProducts";
            this.gbProducts.Size = new System.Drawing.Size(579, 515);
            this.gbProducts.TabIndex = 95;
            this.gbProducts.TabStop = false;
            this.gbProducts.Text = "Select a product";
            // 
            // gbQuantity
            // 
            this.gbQuantity.Controls.Add(this.nudProductQuantity);
            this.gbQuantity.Controls.Add(this.btnAddToBasket);
            this.gbQuantity.Controls.Add(this.tbProductPrice);
            this.gbQuantity.Controls.Add(this.lbProductPrice);
            this.gbQuantity.Location = new System.Drawing.Point(355, 216);
            this.gbQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbQuantity.Name = "gbQuantity";
            this.gbQuantity.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbQuantity.Size = new System.Drawing.Size(215, 168);
            this.gbQuantity.TabIndex = 91;
            this.gbQuantity.TabStop = false;
            // 
            // tbProductPrice
            // 
            this.tbProductPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbProductPrice.Enabled = false;
            this.tbProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProductPrice.Location = new System.Drawing.Point(44, 86);
            this.tbProductPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbProductPrice.Name = "tbProductPrice";
            this.tbProductPrice.Size = new System.Drawing.Size(128, 30);
            this.tbProductPrice.TabIndex = 98;
            // 
            // lbProductPrice
            // 
            this.lbProductPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProductPrice.Location = new System.Drawing.Point(44, 63);
            this.lbProductPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbProductPrice.Name = "lbProductPrice";
            this.lbProductPrice.Size = new System.Drawing.Size(128, 21);
            this.lbProductPrice.TabIndex = 97;
            this.lbProductPrice.Text = "Product price:";
            this.lbProductPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbFinalPrice
            // 
            this.tbFinalPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbFinalPrice.Enabled = false;
            this.tbFinalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFinalPrice.Location = new System.Drawing.Point(92, 97);
            this.tbFinalPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFinalPrice.Name = "tbFinalPrice";
            this.tbFinalPrice.Size = new System.Drawing.Size(146, 34);
            this.tbFinalPrice.TabIndex = 96;
            // 
            // gbBasket
            // 
            this.gbBasket.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbBasket.Controls.Add(this.btnClearBascet);
            this.gbBasket.Controls.Add(this.btnRemoveProduct);
            this.gbBasket.Controls.Add(this.btnRemovePiece);
            this.gbBasket.Controls.Add(this.lboxBasket);
            this.gbBasket.Location = new System.Drawing.Point(611, 86);
            this.gbBasket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbBasket.Name = "gbBasket";
            this.gbBasket.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbBasket.Size = new System.Drawing.Size(483, 515);
            this.gbBasket.TabIndex = 97;
            this.gbBasket.TabStop = false;
            this.gbBasket.Text = "Basket";
            // 
            // btnClearBascet
            // 
            this.btnClearBascet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearBascet.BackColor = System.Drawing.Color.OrangeRed;
            this.btnClearBascet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClearBascet.Location = new System.Drawing.Point(349, 461);
            this.btnClearBascet.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearBascet.Name = "btnClearBascet";
            this.btnClearBascet.Size = new System.Drawing.Size(103, 49);
            this.btnClearBascet.TabIndex = 101;
            this.btnClearBascet.Text = "Clear";
            this.btnClearBascet.UseVisualStyleBackColor = false;
            this.btnClearBascet.Click += new System.EventHandler(this.btnClearBascet_Click);
            // 
            // btnRemoveProduct
            // 
            this.btnRemoveProduct.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRemoveProduct.BackColor = System.Drawing.Color.OrangeRed;
            this.btnRemoveProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemoveProduct.Location = new System.Drawing.Point(184, 461);
            this.btnRemoveProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveProduct.Name = "btnRemoveProduct";
            this.btnRemoveProduct.Size = new System.Drawing.Size(103, 49);
            this.btnRemoveProduct.TabIndex = 100;
            this.btnRemoveProduct.Text = "Remove Product";
            this.btnRemoveProduct.UseVisualStyleBackColor = false;
            this.btnRemoveProduct.Click += new System.EventHandler(this.btnRemoveProduct_Click);
            // 
            // btnRemovePiece
            // 
            this.btnRemovePiece.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemovePiece.BackColor = System.Drawing.Color.OrangeRed;
            this.btnRemovePiece.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemovePiece.Location = new System.Drawing.Point(26, 461);
            this.btnRemovePiece.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemovePiece.Name = "btnRemovePiece";
            this.btnRemovePiece.Size = new System.Drawing.Size(103, 49);
            this.btnRemovePiece.TabIndex = 99;
            this.btnRemovePiece.Text = "Remove Piece";
            this.btnRemovePiece.UseVisualStyleBackColor = false;
            this.btnRemovePiece.Click += new System.EventHandler(this.btnRemovePiece_Click);
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.lbTotalPrice.Location = new System.Drawing.Point(62, 51);
            this.lbTotalPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(205, 42);
            this.lbTotalPrice.TabIndex = 91;
            this.lbTotalPrice.Text = "Totalprice";
            this.lbTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbFinishOrder
            // 
            this.gbFinishOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFinishOrder.Controls.Add(this.rbtnCard);
            this.gbFinishOrder.Controls.Add(this.rbtnCash);
            this.gbFinishOrder.Controls.Add(this.btnConfirm);
            this.gbFinishOrder.Controls.Add(this.lbTotalPrice);
            this.gbFinishOrder.Controls.Add(this.tbFinalPrice);
            this.gbFinishOrder.Location = new System.Drawing.Point(1100, 86);
            this.gbFinishOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbFinishOrder.Name = "gbFinishOrder";
            this.gbFinishOrder.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbFinishOrder.Size = new System.Drawing.Size(323, 256);
            this.gbFinishOrder.TabIndex = 100;
            this.gbFinishOrder.TabStop = false;
            this.gbFinishOrder.Text = "Finish order";
            // 
            // rbtnCard
            // 
            this.rbtnCard.AutoSize = true;
            this.rbtnCard.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rbtnCard.Location = new System.Drawing.Point(189, 145);
            this.rbtnCard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnCard.Name = "rbtnCard";
            this.rbtnCard.Size = new System.Drawing.Size(49, 40);
            this.rbtnCard.TabIndex = 101;
            this.rbtnCard.Text = "Card";
            this.rbtnCard.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rbtnCard.UseVisualStyleBackColor = true;
            // 
            // rbtnCash
            // 
            this.rbtnCash.AutoSize = true;
            this.rbtnCash.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rbtnCash.Checked = true;
            this.rbtnCash.Location = new System.Drawing.Point(92, 145);
            this.rbtnCash.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnCash.Name = "rbtnCash";
            this.rbtnCash.Size = new System.Drawing.Size(52, 40);
            this.rbtnCash.TabIndex = 100;
            this.rbtnCash.TabStop = true;
            this.rbtnCash.Text = "Cash";
            this.rbtnCash.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rbtnCash.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConfirm.BackColor = System.Drawing.Color.Bisque;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirm.Location = new System.Drawing.Point(62, 187);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(205, 46);
            this.btnConfirm.TabIndex = 99;
            this.btnConfirm.Text = "Confirm purchase";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // statusBox
            // 
            this.statusBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.statusBox.Location = new System.Drawing.Point(1299, 499);
            this.statusBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(124, 101);
            this.statusBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.statusBox.TabIndex = 101;
            this.statusBox.TabStop = false;
            // 
            // timer
            // 
            this.timer.Interval = 2500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogOut.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(26, 619);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(140, 46);
            this.btnLogOut.TabIndex = 102;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1480, 678);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.gbFinishOrder);
            this.Controls.Add(this.gbBasket);
            this.Controls.Add(this.gbProducts);
            this.Controls.Add(this.lbWelcome);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudProductQuantity)).EndInit();
            this.gbProducts.ResumeLayout(false);
            this.gbQuantity.ResumeLayout(false);
            this.gbQuantity.PerformLayout();
            this.gbBasket.ResumeLayout(false);
            this.gbFinishOrder.ResumeLayout(false);
            this.gbFinishOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lboxProducts;
        private System.Windows.Forms.Label lbWelcome;
        private System.Windows.Forms.Label lbSubCategory;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.Label lbDepartment;
        private System.Windows.Forms.ListBox lboxBasket;
        private System.Windows.Forms.NumericUpDown nudProductQuantity;
        private System.Windows.Forms.Button btnAddToBasket;
        private System.Windows.Forms.GroupBox gbProducts;
        private System.Windows.Forms.TextBox tbFinalPrice;
        private System.Windows.Forms.GroupBox gbBasket;
        private System.Windows.Forms.Label lbTotalPrice;
        private System.Windows.Forms.Label lbProductPrice;
        private System.Windows.Forms.TextBox tbProductPrice;
        private System.Windows.Forms.GroupBox gbFinishOrder;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.RadioButton rbtnCard;
        private System.Windows.Forms.RadioButton rbtnCash;
        private System.Windows.Forms.Button btnClearBascet;
        private System.Windows.Forms.Button btnRemoveProduct;
        private System.Windows.Forms.Button btnRemovePiece;
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.ComboBox cbSubCategory;
        private System.Windows.Forms.PictureBox statusBox;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.GroupBox gbQuantity;
    }
}