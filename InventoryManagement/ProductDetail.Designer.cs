namespace InventoryManagement
{
    partial class ProductDetail
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.numCost = new System.Windows.Forms.NumericUpDown();
            this.numInventory = new System.Windows.Forms.NumericUpDown();
            this.numMaximum = new System.Windows.Forms.NumericUpDown();
            this.numMinimum = new System.Windows.Forms.NumericUpDown();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblProductIdValue = new System.Windows.Forms.Label();
            this.lblProductId = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.AllPartsGrid = new System.Windows.Forms.DataGridView();
            this.AssociatedPartsGrid = new System.Windows.Forms.DataGridView();
            this.btnAddPart = new System.Windows.Forms.Button();
            this.btnRemovePart = new System.Windows.Forms.Button();
            this.btnPartSearch = new System.Windows.Forms.Button();
            this.txtPartSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaximum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinimum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllPartsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssociatedPartsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblHeader.Location = new System.Drawing.Point(25, 27);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(132, 20);
            this.lblHeader.TabIndex = 2;
            this.lblHeader.Text = "(mode) Product";
            // 
            // numCost
            // 
            this.numCost.DecimalPlaces = 2;
            this.numCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCost.Location = new System.Drawing.Point(202, 223);
            this.numCost.Name = "numCost";
            this.numCost.Size = new System.Drawing.Size(141, 29);
            this.numCost.TabIndex = 37;
            // 
            // numInventory
            // 
            this.numInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numInventory.Location = new System.Drawing.Point(202, 172);
            this.numInventory.Maximum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.numInventory.Name = "numInventory";
            this.numInventory.Size = new System.Drawing.Size(141, 29);
            this.numInventory.TabIndex = 36;
            // 
            // numMaximum
            // 
            this.numMaximum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMaximum.Location = new System.Drawing.Point(202, 325);
            this.numMaximum.Name = "numMaximum";
            this.numMaximum.Size = new System.Drawing.Size(141, 29);
            this.numMaximum.TabIndex = 35;
            // 
            // numMinimum
            // 
            this.numMinimum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMinimum.Location = new System.Drawing.Point(202, 276);
            this.numMinimum.Name = "numMinimum";
            this.numMinimum.Size = new System.Drawing.Size(141, 29);
            this.numMinimum.TabIndex = 34;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(202, 120);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(141, 29);
            this.txtName.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 24);
            this.label5.TabIndex = 32;
            this.label5.Text = "Maximum";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 24);
            this.label4.TabIndex = 31;
            this.label4.Text = "Minimum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 24);
            this.label3.TabIndex = 30;
            this.label3.Text = "Cost";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 29;
            this.label2.Text = "Inventory";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 24);
            this.label1.TabIndex = 28;
            this.label1.Text = "Name";
            // 
            // lblProductIdValue
            // 
            this.lblProductIdValue.AutoSize = true;
            this.lblProductIdValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductIdValue.Location = new System.Drawing.Point(198, 71);
            this.lblProductIdValue.Name = "lblProductIdValue";
            this.lblProductIdValue.Size = new System.Drawing.Size(101, 24);
            this.lblProductIdValue.TabIndex = 27;
            this.lblProductIdValue.Text = "(productId)";
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductId.Location = new System.Drawing.Point(29, 71);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(97, 24);
            this.lblProductId.TabIndex = 26;
            this.lblProductId.Text = "Product ID";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.Location = new System.Drawing.Point(630, 440);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(134, 39);
            this.btnSave.TabIndex = 38;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DimGray;
            this.btnCancel.Location = new System.Drawing.Point(398, 440);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(134, 39);
            this.btnCancel.TabIndex = 39;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AllPartsGrid
            // 
            this.AllPartsGrid.AllowUserToAddRows = false;
            this.AllPartsGrid.AllowUserToDeleteRows = false;
            this.AllPartsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllPartsGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.AllPartsGrid.Location = new System.Drawing.Point(398, 71);
            this.AllPartsGrid.Name = "AllPartsGrid";
            this.AllPartsGrid.ReadOnly = true;
            this.AllPartsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AllPartsGrid.Size = new System.Drawing.Size(366, 123);
            this.AllPartsGrid.TabIndex = 40;
            // 
            // AssociatedPartsGrid
            // 
            this.AssociatedPartsGrid.AllowUserToAddRows = false;
            this.AssociatedPartsGrid.AllowUserToDeleteRows = false;
            this.AssociatedPartsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AssociatedPartsGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.AssociatedPartsGrid.Location = new System.Drawing.Point(398, 255);
            this.AssociatedPartsGrid.Name = "AssociatedPartsGrid";
            this.AssociatedPartsGrid.ReadOnly = true;
            this.AssociatedPartsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AssociatedPartsGrid.Size = new System.Drawing.Size(366, 123);
            this.AssociatedPartsGrid.TabIndex = 41;
            // 
            // btnAddPart
            // 
            this.btnAddPart.BackColor = System.Drawing.Color.DimGray;
            this.btnAddPart.Location = new System.Drawing.Point(630, 204);
            this.btnAddPart.Name = "btnAddPart";
            this.btnAddPart.Size = new System.Drawing.Size(134, 39);
            this.btnAddPart.TabIndex = 42;
            this.btnAddPart.Text = "Add Part";
            this.btnAddPart.UseVisualStyleBackColor = false;
            this.btnAddPart.Click += new System.EventHandler(this.btnAddPart_Click);
            // 
            // btnRemovePart
            // 
            this.btnRemovePart.BackColor = System.Drawing.Color.DimGray;
            this.btnRemovePart.Location = new System.Drawing.Point(630, 392);
            this.btnRemovePart.Name = "btnRemovePart";
            this.btnRemovePart.Size = new System.Drawing.Size(134, 39);
            this.btnRemovePart.TabIndex = 43;
            this.btnRemovePart.Text = "Remove Part";
            this.btnRemovePart.UseVisualStyleBackColor = false;
            this.btnRemovePart.Click += new System.EventHandler(this.btnRemovePart_Click);
            // 
            // btnPartSearch
            // 
            this.btnPartSearch.BackColor = System.Drawing.Color.DimGray;
            this.btnPartSearch.ForeColor = System.Drawing.Color.White;
            this.btnPartSearch.Location = new System.Drawing.Point(630, 27);
            this.btnPartSearch.Name = "btnPartSearch";
            this.btnPartSearch.Size = new System.Drawing.Size(134, 39);
            this.btnPartSearch.TabIndex = 44;
            this.btnPartSearch.Text = "Search";
            this.btnPartSearch.UseVisualStyleBackColor = false;
            this.btnPartSearch.Click += new System.EventHandler(this.btnPartSearch_Click);
            // 
            // txtPartSearch
            // 
            this.txtPartSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartSearch.Location = new System.Drawing.Point(398, 33);
            this.txtPartSearch.Name = "txtPartSearch";
            this.txtPartSearch.Size = new System.Drawing.Size(229, 29);
            this.txtPartSearch.TabIndex = 45;
            // 
            // ProductDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.txtPartSearch);
            this.Controls.Add(this.btnPartSearch);
            this.Controls.Add(this.btnRemovePart);
            this.Controls.Add(this.btnAddPart);
            this.Controls.Add(this.AssociatedPartsGrid);
            this.Controls.Add(this.AllPartsGrid);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.numCost);
            this.Controls.Add(this.numInventory);
            this.Controls.Add(this.numMaximum);
            this.Controls.Add(this.numMinimum);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblProductIdValue);
            this.Controls.Add(this.lblProductId);
            this.Controls.Add(this.lblHeader);
            this.Name = "ProductDetail";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.ProductDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaximum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinimum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllPartsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssociatedPartsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.NumericUpDown numCost;
        private System.Windows.Forms.NumericUpDown numInventory;
        private System.Windows.Forms.NumericUpDown numMaximum;
        private System.Windows.Forms.NumericUpDown numMinimum;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProductIdValue;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView AllPartsGrid;
        private System.Windows.Forms.DataGridView AssociatedPartsGrid;
        private System.Windows.Forms.Button btnAddPart;
        private System.Windows.Forms.Button btnRemovePart;
        private System.Windows.Forms.Button btnPartSearch;
        private System.Windows.Forms.TextBox txtPartSearch;
    }
}