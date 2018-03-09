namespace Assignment_5
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
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.listBoxBagelType = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelBagelPrice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.buttonCompleteOrder = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.listBoxSize = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.dataGridViewBagel = new System.Windows.Forms.DataGridView();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricebagel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalpricebagel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SizeBagel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bagelquantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSummary = new System.Windows.Forms.Button();
            this.groupBoxSummary = new System.Windows.Forms.GroupBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelAverageRevenue = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelTransaction = new System.Windows.Forms.Label();
            this.labelTotalRevenue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelBagelSold = new System.Windows.Forms.Label();
            this.buttonStock = new System.Windows.Forms.Button();
            this.panelStockReport = new System.Windows.Forms.Panel();
            this.radioButtonDownload = new System.Windows.Forms.RadioButton();
            this.buttonEmailDone = new System.Windows.Forms.Button();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.radioButtonEmail = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBagel)).BeginInit();
            this.groupBoxSummary.SuspendLayout();
            this.panelStockReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::Assignment_5.Properties.Resources.Mr_Bagel_Logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(2, 273);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(117, 110);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // listBoxBagelType
            // 
            this.listBoxBagelType.FormattingEnabled = true;
            this.listBoxBagelType.Items.AddRange(new object[] {
            "Halloumi",
            "Bangkok",
            "Chicken Philly",
            "Classic Club",
            "Kiltimagh Special ",
            "Veggie",
            "Ploughmans",
            "Mexicana",
            "Triple Cheese",
            "Atlantic Way",
            "Breakfast",
            "Maui",
            "Classic",
            "Chicken Caeser",
            "Student Surprise",
            "Cajun"});
            this.listBoxBagelType.Location = new System.Drawing.Point(12, 38);
            this.listBoxBagelType.Name = "listBoxBagelType";
            this.listBoxBagelType.Size = new System.Drawing.Size(152, 212);
            this.listBoxBagelType.TabIndex = 1;
            this.listBoxBagelType.SelectedIndexChanged += new System.EventHandler(this.listBoxBagelType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(341, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Price:";
            // 
            // labelBagelPrice
            // 
            this.labelBagelPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelBagelPrice.Location = new System.Drawing.Point(334, 85);
            this.labelBagelPrice.Name = "labelBagelPrice";
            this.labelBagelPrice.Size = new System.Drawing.Size(100, 23);
            this.labelBagelPrice.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(477, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quantity";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(480, 88);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(100, 20);
            this.textBoxQuantity.TabIndex = 6;
            // 
            // buttonCompleteOrder
            // 
            this.buttonCompleteOrder.Location = new System.Drawing.Point(567, 137);
            this.buttonCompleteOrder.Name = "buttonCompleteOrder";
            this.buttonCompleteOrder.Size = new System.Drawing.Size(75, 59);
            this.buttonCompleteOrder.TabIndex = 7;
            this.buttonCompleteOrder.Text = "Complete &Order";
            this.toolTip1.SetToolTip(this.buttonCompleteOrder, "Press for confirm order");
            this.buttonCompleteOrder.UseVisualStyleBackColor = true;
            this.buttonCompleteOrder.Click += new System.EventHandler(this.buttonCompleteOrder_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(480, 179);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 33);
            this.buttonClear.TabIndex = 8;
            this.buttonClear.Text = "&Clear";
            this.toolTip1.SetToolTip(this.buttonClear, "Cancel the order");
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonOrder
            // 
            this.buttonOrder.Location = new System.Drawing.Point(480, 122);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(75, 42);
            this.buttonOrder.TabIndex = 9;
            this.buttonOrder.Text = "&Add to Order                                                                    " +
    "                                    Add to                          ";
            this.toolTip1.SetToolTip(this.buttonOrder, "Press to Add to order");
            this.buttonOrder.UseVisualStyleBackColor = true;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(813, 273);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 40);
            this.buttonExit.TabIndex = 10;
            this.buttonExit.Text = "Exit";
            this.toolTip1.SetToolTip(this.buttonExit, "Close the application");
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // listBoxSize
            // 
            this.listBoxSize.FormattingEnabled = true;
            this.listBoxSize.Items.AddRange(new object[] {
            "Small ",
            "Medium",
            "Regular",
            "Large",
            "Extra Large"});
            this.listBoxSize.Location = new System.Drawing.Point(180, 85);
            this.listBoxSize.Name = "listBoxSize";
            this.listBoxSize.Size = new System.Drawing.Size(120, 95);
            this.listBoxSize.TabIndex = 11;
            this.listBoxSize.SelectedIndexChanged += new System.EventHandler(this.listBoxSize_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Total Running Price:";
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTotalPrice.Location = new System.Drawing.Point(334, 179);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(100, 23);
            this.labelTotalPrice.TabIndex = 13;
            // 
            // dataGridViewBagel
            // 
            this.dataGridViewBagel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBagel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Type,
            this.pricebagel,
            this.totalpricebagel,
            this.SizeBagel,
            this.Bagelquantity});
            this.dataGridViewBagel.Location = new System.Drawing.Point(141, 256);
            this.dataGridViewBagel.Name = "dataGridViewBagel";
            this.dataGridViewBagel.Size = new System.Drawing.Size(541, 199);
            this.dataGridViewBagel.TabIndex = 14;
            // 
            // Type
            // 
            this.Type.HeaderText = "BagelType";
            this.Type.Name = "Type";
            // 
            // pricebagel
            // 
            this.pricebagel.HeaderText = "Bagelcost";
            this.pricebagel.Name = "pricebagel";
            // 
            // totalpricebagel
            // 
            this.totalpricebagel.HeaderText = "Total order cost";
            this.totalpricebagel.Name = "totalpricebagel";
            // 
            // SizeBagel
            // 
            this.SizeBagel.HeaderText = "Bagel Size";
            this.SizeBagel.Name = "SizeBagel";
            // 
            // Bagelquantity
            // 
            this.Bagelquantity.HeaderText = "BagelQuantity";
            this.Bagelquantity.Name = "Bagelquantity";
            // 
            // buttonSummary
            // 
            this.buttonSummary.Location = new System.Drawing.Point(728, 235);
            this.buttonSummary.Name = "buttonSummary";
            this.buttonSummary.Size = new System.Drawing.Size(75, 33);
            this.buttonSummary.TabIndex = 15;
            this.buttonSummary.Text = "&Summary";
            this.toolTip1.SetToolTip(this.buttonSummary, "View the summary till now");
            this.buttonSummary.UseVisualStyleBackColor = false;
            this.buttonSummary.Click += new System.EventHandler(this.buttonSummary_Click);
            // 
            // groupBoxSummary
            // 
            this.groupBoxSummary.Controls.Add(this.buttonClose);
            this.groupBoxSummary.Controls.Add(this.labelAverageRevenue);
            this.groupBoxSummary.Controls.Add(this.label9);
            this.groupBoxSummary.Controls.Add(this.label8);
            this.groupBoxSummary.Controls.Add(this.label7);
            this.groupBoxSummary.Controls.Add(this.labelTransaction);
            this.groupBoxSummary.Controls.Add(this.labelTotalRevenue);
            this.groupBoxSummary.Controls.Add(this.label4);
            this.groupBoxSummary.Controls.Add(this.labelBagelSold);
            this.groupBoxSummary.Location = new System.Drawing.Point(648, 12);
            this.groupBoxSummary.Name = "groupBoxSummary";
            this.groupBoxSummary.Size = new System.Drawing.Size(240, 213);
            this.groupBoxSummary.TabIndex = 16;
            this.groupBoxSummary.TabStop = false;
            this.groupBoxSummary.Text = "Summary";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(80, 184);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 25;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelAverageRevenue
            // 
            this.labelAverageRevenue.AutoSize = true;
            this.labelAverageRevenue.Location = new System.Drawing.Point(144, 152);
            this.labelAverageRevenue.Name = "labelAverageRevenue";
            this.labelAverageRevenue.Size = new System.Drawing.Size(41, 13);
            this.labelAverageRevenue.TabIndex = 24;
            this.labelAverageRevenue.Text = "label10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Average Revenue";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Total Revenue";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Total Bagel sold";
            // 
            // labelTransaction
            // 
            this.labelTransaction.AutoSize = true;
            this.labelTransaction.Location = new System.Drawing.Point(144, 39);
            this.labelTransaction.Name = "labelTransaction";
            this.labelTransaction.Size = new System.Drawing.Size(35, 13);
            this.labelTransaction.TabIndex = 20;
            this.labelTransaction.Text = "label6";
            // 
            // labelTotalRevenue
            // 
            this.labelTotalRevenue.AutoSize = true;
            this.labelTotalRevenue.Location = new System.Drawing.Point(144, 110);
            this.labelTotalRevenue.Name = "labelTotalRevenue";
            this.labelTotalRevenue.Size = new System.Drawing.Size(35, 13);
            this.labelTotalRevenue.TabIndex = 19;
            this.labelTotalRevenue.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Total Transaction";
            // 
            // labelBagelSold
            // 
            this.labelBagelSold.AutoSize = true;
            this.labelBagelSold.Location = new System.Drawing.Point(144, 73);
            this.labelBagelSold.Name = "labelBagelSold";
            this.labelBagelSold.Size = new System.Drawing.Size(35, 13);
            this.labelBagelSold.TabIndex = 17;
            this.labelBagelSold.Text = "label4";
            // 
            // buttonStock
            // 
            this.buttonStock.Location = new System.Drawing.Point(728, 305);
            this.buttonStock.Name = "buttonStock";
            this.buttonStock.Size = new System.Drawing.Size(75, 42);
            this.buttonStock.TabIndex = 17;
            this.buttonStock.Text = "Stock Report";
            this.toolTip1.SetToolTip(this.buttonStock, "click to view stock report");
            this.buttonStock.UseVisualStyleBackColor = true;
            this.buttonStock.Click += new System.EventHandler(this.buttonStock_Click);
            // 
            // panelStockReport
            // 
            this.panelStockReport.Controls.Add(this.buttonCancel);
            this.panelStockReport.Controls.Add(this.radioButtonDownload);
            this.panelStockReport.Controls.Add(this.buttonEmailDone);
            this.panelStockReport.Controls.Add(this.textBoxEmail);
            this.panelStockReport.Controls.Add(this.radioButtonEmail);
            this.panelStockReport.Location = new System.Drawing.Point(688, 353);
            this.panelStockReport.Name = "panelStockReport";
            this.panelStockReport.Size = new System.Drawing.Size(200, 134);
            this.panelStockReport.TabIndex = 18;
            this.panelStockReport.Paint += new System.Windows.Forms.PaintEventHandler(this.panelStockReport_Paint);
            // 
            // radioButtonDownload
            // 
            this.radioButtonDownload.AutoSize = true;
            this.radioButtonDownload.Location = new System.Drawing.Point(15, 85);
            this.radioButtonDownload.Name = "radioButtonDownload";
            this.radioButtonDownload.Size = new System.Drawing.Size(73, 17);
            this.radioButtonDownload.TabIndex = 22;
            this.radioButtonDownload.TabStop = true;
            this.radioButtonDownload.Text = "Download";
            this.radioButtonDownload.UseVisualStyleBackColor = true;
            this.radioButtonDownload.CheckedChanged += new System.EventHandler(this.radioButtonDownload_CheckedChanged);
            // 
            // buttonEmailDone
            // 
            this.buttonEmailDone.Location = new System.Drawing.Point(97, 38);
            this.buttonEmailDone.Name = "buttonEmailDone";
            this.buttonEmailDone.Size = new System.Drawing.Size(63, 23);
            this.buttonEmailDone.TabIndex = 19;
            this.buttonEmailDone.Text = "&Done";
            this.toolTip1.SetToolTip(this.buttonEmailDone, "Press Done to send Email");
            this.buttonEmailDone.UseVisualStyleBackColor = true;
            this.buttonEmailDone.Click += new System.EventHandler(this.buttonEmailDone_Click);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(82, 12);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(100, 20);
            this.textBoxEmail.TabIndex = 21;
            // 
            // radioButtonEmail
            // 
            this.radioButtonEmail.AutoSize = true;
            this.radioButtonEmail.Location = new System.Drawing.Point(15, 13);
            this.radioButtonEmail.Name = "radioButtonEmail";
            this.radioButtonEmail.Size = new System.Drawing.Size(50, 17);
            this.radioButtonEmail.TabIndex = 19;
            this.radioButtonEmail.TabStop = true;
            this.radioButtonEmail.Text = "Email";
            this.radioButtonEmail.UseVisualStyleBackColor = true;
            this.radioButtonEmail.CheckedChanged += new System.EventHandler(this.radioButtonEmail_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "Bagel Type:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(198, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 18);
            this.label6.TabIndex = 20;
            this.label6.Text = "Bagel Size:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(140, 108);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(57, 23);
            this.buttonCancel.TabIndex = 21;
            this.buttonCancel.Text = "Close";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 512);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panelStockReport);
            this.Controls.Add(this.buttonStock);
            this.Controls.Add(this.groupBoxSummary);
            this.Controls.Add(this.buttonSummary);
            this.Controls.Add(this.dataGridViewBagel);
            this.Controls.Add(this.labelTotalPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxSize);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonOrder);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonCompleteOrder);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelBagelPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxBagelType);
            this.Controls.Add(this.pictureBoxLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Mr.Bagel";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBagel)).EndInit();
            this.groupBoxSummary.ResumeLayout(false);
            this.groupBoxSummary.PerformLayout();
            this.panelStockReport.ResumeLayout(false);
            this.panelStockReport.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.ListBox listBoxBagelType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelBagelPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Button buttonCompleteOrder;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ListBox listBoxSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.DataGridView dataGridViewBagel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricebagel;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalpricebagel;
        private System.Windows.Forms.DataGridViewTextBoxColumn SizeBagel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bagelquantity;
        private System.Windows.Forms.Button buttonSummary;
        private System.Windows.Forms.GroupBox groupBoxSummary;
        private System.Windows.Forms.Label labelBagelSold;
        private System.Windows.Forms.Label labelAverageRevenue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelTransaction;
        private System.Windows.Forms.Label labelTotalRevenue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonStock;
        private System.Windows.Forms.Panel panelStockReport;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.RadioButton radioButtonEmail;
        private System.Windows.Forms.Button buttonEmailDone;
        private System.Windows.Forms.RadioButton radioButtonDownload;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonCancel;
    }
}

