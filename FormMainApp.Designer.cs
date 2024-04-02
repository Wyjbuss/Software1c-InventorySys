namespace WyattBussellC968Software1C_
{
    partial class mainApplicationWindow
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
            this.dataGridViewParts = new System.Windows.Forms.DataGridView();
            this.buttonAddParts = new System.Windows.Forms.Button();
            this.buttonModifyParts = new System.Windows.Forms.Button();
            this.buttonDeleteParts = new System.Windows.Forms.Button();
            this.buttonSearchParts = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelParts = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxSearchParts = new System.Windows.Forms.TextBox();
            this.textBoxSearchProducts = new System.Windows.Forms.TextBox();
            this.labelProducts = new System.Windows.Forms.Label();
            this.buttonSearchProducts = new System.Windows.Forms.Button();
            this.buttonDeleteProducts = new System.Windows.Forms.Button();
            this.buttonModifyProducts = new System.Windows.Forms.Button();
            this.buttonAddProducts = new System.Windows.Forms.Button();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewParts
            // 
            this.dataGridViewParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParts.Location = new System.Drawing.Point(31, 125);
            this.dataGridViewParts.Name = "dataGridViewParts";
            this.dataGridViewParts.ReadOnly = true;
            this.dataGridViewParts.Size = new System.Drawing.Size(508, 326);
            this.dataGridViewParts.TabIndex = 0;
            this.dataGridViewParts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewParts_CellClick);
            this.dataGridViewParts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridViewParts.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewParts_DataBindingComplete);
            this.dataGridViewParts.SelectionChanged += new System.EventHandler(this.dataGridViewParts_SelectionChanged);
            // 
            // buttonAddParts
            // 
            this.buttonAddParts.Location = new System.Drawing.Point(302, 457);
            this.buttonAddParts.Name = "buttonAddParts";
            this.buttonAddParts.Size = new System.Drawing.Size(75, 23);
            this.buttonAddParts.TabIndex = 1;
            this.buttonAddParts.Text = "Add";
            this.buttonAddParts.UseVisualStyleBackColor = true;
            this.buttonAddParts.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonAddParts_MouseClick);
            // 
            // buttonModifyParts
            // 
            this.buttonModifyParts.Location = new System.Drawing.Point(383, 457);
            this.buttonModifyParts.Name = "buttonModifyParts";
            this.buttonModifyParts.Size = new System.Drawing.Size(75, 23);
            this.buttonModifyParts.TabIndex = 2;
            this.buttonModifyParts.Text = "Modify";
            this.buttonModifyParts.UseVisualStyleBackColor = true;
            this.buttonModifyParts.Click += new System.EventHandler(this.buttonModifyParts_Click);
            this.buttonModifyParts.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonModifyParts_MouseClick);
            // 
            // buttonDeleteParts
            // 
            this.buttonDeleteParts.Location = new System.Drawing.Point(464, 457);
            this.buttonDeleteParts.Name = "buttonDeleteParts";
            this.buttonDeleteParts.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteParts.TabIndex = 3;
            this.buttonDeleteParts.Text = "Delete";
            this.buttonDeleteParts.UseVisualStyleBackColor = true;
            this.buttonDeleteParts.Click += new System.EventHandler(this.buttonDeleteParts_Click);
            this.buttonDeleteParts.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonDeleteParts_MouseClick);
            // 
            // buttonSearchParts
            // 
            this.buttonSearchParts.Location = new System.Drawing.Point(302, 97);
            this.buttonSearchParts.Name = "buttonSearchParts";
            this.buttonSearchParts.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchParts.TabIndex = 4;
            this.buttonSearchParts.Text = "Search";
            this.buttonSearchParts.UseVisualStyleBackColor = true;
            this.buttonSearchParts.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonSearchParts_MouseClick);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(995, 537);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonExit_MouseClick);
            // 
            // labelParts
            // 
            this.labelParts.AutoSize = true;
            this.labelParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParts.Location = new System.Drawing.Point(25, 88);
            this.labelParts.Name = "labelParts";
            this.labelParts.Size = new System.Drawing.Size(78, 31);
            this.labelParts.TabIndex = 6;
            this.labelParts.Text = "Parts";
            this.labelParts.Click += new System.EventHandler(this.labelParts_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(24, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(486, 39);
            this.labelTitle.TabIndex = 7;
            this.labelTitle.Text = "Inventory Management System";
            // 
            // textBoxSearchParts
            // 
            this.textBoxSearchParts.Location = new System.Drawing.Point(383, 99);
            this.textBoxSearchParts.Name = "textBoxSearchParts";
            this.textBoxSearchParts.Size = new System.Drawing.Size(156, 20);
            this.textBoxSearchParts.TabIndex = 8;
            // 
            // textBoxSearchProducts
            // 
            this.textBoxSearchProducts.Location = new System.Drawing.Point(914, 99);
            this.textBoxSearchProducts.Name = "textBoxSearchProducts";
            this.textBoxSearchProducts.Size = new System.Drawing.Size(156, 20);
            this.textBoxSearchProducts.TabIndex = 15;
            // 
            // labelProducts
            // 
            this.labelProducts.AutoSize = true;
            this.labelProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProducts.Location = new System.Drawing.Point(556, 88);
            this.labelProducts.Name = "labelProducts";
            this.labelProducts.Size = new System.Drawing.Size(122, 31);
            this.labelProducts.TabIndex = 14;
            this.labelProducts.Text = "Products";
            // 
            // buttonSearchProducts
            // 
            this.buttonSearchProducts.Location = new System.Drawing.Point(833, 97);
            this.buttonSearchProducts.Name = "buttonSearchProducts";
            this.buttonSearchProducts.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchProducts.TabIndex = 13;
            this.buttonSearchProducts.Text = "Search";
            this.buttonSearchProducts.UseVisualStyleBackColor = true;
            this.buttonSearchProducts.Click += new System.EventHandler(this.buttonSearchProducts_Click);
            this.buttonSearchProducts.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonSearchProducts_MouseClick);
            // 
            // buttonDeleteProducts
            // 
            this.buttonDeleteProducts.Location = new System.Drawing.Point(995, 457);
            this.buttonDeleteProducts.Name = "buttonDeleteProducts";
            this.buttonDeleteProducts.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteProducts.TabIndex = 12;
            this.buttonDeleteProducts.Text = "Delete";
            this.buttonDeleteProducts.UseVisualStyleBackColor = true;
            this.buttonDeleteProducts.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonDeleteProducts_MouseClick);
            // 
            // buttonModifyProducts
            // 
            this.buttonModifyProducts.Location = new System.Drawing.Point(914, 457);
            this.buttonModifyProducts.Name = "buttonModifyProducts";
            this.buttonModifyProducts.Size = new System.Drawing.Size(75, 23);
            this.buttonModifyProducts.TabIndex = 11;
            this.buttonModifyProducts.Text = "Modify";
            this.buttonModifyProducts.UseVisualStyleBackColor = true;
            this.buttonModifyProducts.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonModifyProducts_MouseClick);
            // 
            // buttonAddProducts
            // 
            this.buttonAddProducts.Location = new System.Drawing.Point(833, 457);
            this.buttonAddProducts.Name = "buttonAddProducts";
            this.buttonAddProducts.Size = new System.Drawing.Size(75, 23);
            this.buttonAddProducts.TabIndex = 10;
            this.buttonAddProducts.Text = "Add";
            this.buttonAddProducts.UseVisualStyleBackColor = true;
            this.buttonAddProducts.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonAddProducts_MouseClick);
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Location = new System.Drawing.Point(562, 125);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.Size = new System.Drawing.Size(508, 326);
            this.dataGridViewProducts.TabIndex = 9;
            this.dataGridViewProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProducts_CellContentClick);
            this.dataGridViewProducts.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewProducts_DataBindingComplete);
            this.dataGridViewProducts.SelectionChanged += new System.EventHandler(this.dataGridViewProducts_SelectionChanged);
            // 
            // mainApplicationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 583);
            this.Controls.Add(this.textBoxSearchProducts);
            this.Controls.Add(this.labelProducts);
            this.Controls.Add(this.buttonSearchProducts);
            this.Controls.Add(this.buttonDeleteProducts);
            this.Controls.Add(this.buttonModifyProducts);
            this.Controls.Add(this.buttonAddProducts);
            this.Controls.Add(this.dataGridViewProducts);
            this.Controls.Add(this.textBoxSearchParts);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelParts);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSearchParts);
            this.Controls.Add(this.buttonDeleteParts);
            this.Controls.Add(this.buttonModifyParts);
            this.Controls.Add(this.buttonAddParts);
            this.Controls.Add(this.dataGridViewParts);
            this.Name = "mainApplicationWindow";
            this.Text = "Wyatt Bussell\'s Inventory System";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewParts;
        private System.Windows.Forms.Button buttonAddParts;
        private System.Windows.Forms.Button buttonModifyParts;
        private System.Windows.Forms.Button buttonDeleteParts;
        private System.Windows.Forms.Button buttonSearchParts;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelParts;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxSearchParts;
        private System.Windows.Forms.TextBox textBoxSearchProducts;
        private System.Windows.Forms.Label labelProducts;
        private System.Windows.Forms.Button buttonSearchProducts;
        private System.Windows.Forms.Button buttonDeleteProducts;
        private System.Windows.Forms.Button buttonModifyProducts;
        private System.Windows.Forms.Button buttonAddProducts;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
    }
}

