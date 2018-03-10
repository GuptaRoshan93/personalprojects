namespace Assignment_4
{
    partial class SearchForm
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
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.radioButtonTransactionId = new System.Windows.Forms.RadioButton();
            this.radioButtonEmailId = new System.Windows.Forms.RadioButton();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.listBoxDetails = new System.Windows.Forms.ListBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.groupBoxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.buttonSearch);
            this.groupBoxSearch.Controls.Add(this.listBoxDetails);
            this.groupBoxSearch.Controls.Add(this.textBoxSearch);
            this.groupBoxSearch.Controls.Add(this.radioButtonEmailId);
            this.groupBoxSearch.Controls.Add(this.radioButtonTransactionId);
            this.groupBoxSearch.Location = new System.Drawing.Point(72, 32);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(593, 406);
            this.groupBoxSearch.TabIndex = 0;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Search ";
            // 
            // radioButtonTransactionId
            // 
            this.radioButtonTransactionId.AutoSize = true;
            this.radioButtonTransactionId.Location = new System.Drawing.Point(23, 38);
            this.radioButtonTransactionId.Name = "radioButtonTransactionId";
            this.radioButtonTransactionId.Size = new System.Drawing.Size(149, 17);
            this.radioButtonTransactionId.TabIndex = 0;
            this.radioButtonTransactionId.TabStop = true;
            this.radioButtonTransactionId.Text = "Search with TransactionId";
            this.radioButtonTransactionId.UseVisualStyleBackColor = true;
            // 
            // radioButtonEmailId
            // 
            this.radioButtonEmailId.AutoSize = true;
            this.radioButtonEmailId.Location = new System.Drawing.Point(23, 77);
            this.radioButtonEmailId.Name = "radioButtonEmailId";
            this.radioButtonEmailId.Size = new System.Drawing.Size(118, 17);
            this.radioButtonEmailId.TabIndex = 1;
            this.radioButtonEmailId.TabStop = true;
            this.radioButtonEmailId.Text = "Search with EmailId";
            this.radioButtonEmailId.UseVisualStyleBackColor = true;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(23, 116);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(174, 20);
            this.textBoxSearch.TabIndex = 3;
            // 
            // listBoxDetails
            // 
            this.listBoxDetails.FormattingEnabled = true;
            this.listBoxDetails.Location = new System.Drawing.Point(23, 169);
            this.listBoxDetails.Name = "listBoxDetails";
            this.listBoxDetails.Size = new System.Drawing.Size(120, 95);
            this.listBoxDetails.TabIndex = 1;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(231, 113);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 469);
            this.Controls.Add(this.groupBoxSearch);
            this.Name = "SearchForm";
            this.Text = "Search";
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.RadioButton radioButtonEmailId;
        private System.Windows.Forms.RadioButton radioButtonTransactionId;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.ListBox listBoxDetails;
        private System.Windows.Forms.Button buttonSearch;
    }
}