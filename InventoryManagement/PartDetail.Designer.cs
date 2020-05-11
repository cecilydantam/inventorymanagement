namespace InventoryManagement
{
    partial class PartDetail
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
            this.rdbInHouse = new System.Windows.Forms.RadioButton();
            this.rdbOutsourced = new System.Windows.Forms.RadioButton();
            this.lblPartId = new System.Windows.Forms.Label();
            this.lblPartIdValue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMachineId = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.numMinimum = new System.Windows.Forms.NumericUpDown();
            this.numMaximum = new System.Windows.Forms.NumericUpDown();
            this.numInventory = new System.Windows.Forms.NumericUpDown();
            this.numCost = new System.Windows.Forms.NumericUpDown();
            this.numMachineId = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numMinimum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaximum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMachineId)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblHeader.Location = new System.Drawing.Point(21, 23);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(103, 20);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "(mode) Part";
            // 
            // rdbInHouse
            // 
            this.rdbInHouse.AutoSize = true;
            this.rdbInHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbInHouse.Location = new System.Drawing.Point(25, 70);
            this.rdbInHouse.Name = "rdbInHouse";
            this.rdbInHouse.Size = new System.Drawing.Size(93, 24);
            this.rdbInHouse.TabIndex = 2;
            this.rdbInHouse.TabStop = true;
            this.rdbInHouse.Text = "In-House";
            this.rdbInHouse.UseVisualStyleBackColor = true;
            this.rdbInHouse.CheckedChanged += new System.EventHandler(this.rdbInHouse_CheckedChanged);
            // 
            // rdbOutsourced
            // 
            this.rdbOutsourced.AutoSize = true;
            this.rdbOutsourced.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbOutsourced.Location = new System.Drawing.Point(194, 70);
            this.rdbOutsourced.Name = "rdbOutsourced";
            this.rdbOutsourced.Size = new System.Drawing.Size(110, 24);
            this.rdbOutsourced.TabIndex = 3;
            this.rdbOutsourced.TabStop = true;
            this.rdbOutsourced.Text = "Outsourced";
            this.rdbOutsourced.UseVisualStyleBackColor = true;
            this.rdbOutsourced.CheckedChanged += new System.EventHandler(this.rdbOutsourced_CheckedChanged);
            // 
            // lblPartId
            // 
            this.lblPartId.AutoSize = true;
            this.lblPartId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartId.Location = new System.Drawing.Point(21, 116);
            this.lblPartId.Name = "lblPartId";
            this.lblPartId.Size = new System.Drawing.Size(64, 24);
            this.lblPartId.TabIndex = 4;
            this.lblPartId.Text = "Part ID";
            // 
            // lblPartIdValue
            // 
            this.lblPartIdValue.AutoSize = true;
            this.lblPartIdValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartIdValue.Location = new System.Drawing.Point(190, 116);
            this.lblPartIdValue.Name = "lblPartIdValue";
            this.lblPartIdValue.Size = new System.Drawing.Size(68, 24);
            this.lblPartIdValue.TabIndex = 5;
            this.lblPartIdValue.Text = "(partId)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Inventory";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Minimum";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Maximum";
            // 
            // lblMachineId
            // 
            this.lblMachineId.AutoSize = true;
            this.lblMachineId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMachineId.Location = new System.Drawing.Point(21, 424);
            this.lblMachineId.Name = "lblMachineId";
            this.lblMachineId.Size = new System.Drawing.Size(105, 24);
            this.lblMachineId.TabIndex = 11;
            this.lblMachineId.Text = "Machine ID";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.Location = new System.Drawing.Point(21, 424);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(147, 24);
            this.lblCompanyName.TabIndex = 12;
            this.lblCompanyName.Text = "Company Name";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(194, 165);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(141, 29);
            this.txtName.TabIndex = 13;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyName.Location = new System.Drawing.Point(194, 421);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(141, 29);
            this.txtCompanyName.TabIndex = 19;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.Location = new System.Drawing.Point(201, 471);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(134, 39);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DimGray;
            this.btnCancel.Location = new System.Drawing.Point(25, 471);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(134, 39);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // numMinimum
            // 
            this.numMinimum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMinimum.Location = new System.Drawing.Point(194, 321);
            this.numMinimum.Name = "numMinimum";
            this.numMinimum.Size = new System.Drawing.Size(141, 29);
            this.numMinimum.TabIndex = 22;
            // 
            // numMaximum
            // 
            this.numMaximum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMaximum.Location = new System.Drawing.Point(194, 370);
            this.numMaximum.Name = "numMaximum";
            this.numMaximum.Size = new System.Drawing.Size(141, 29);
            this.numMaximum.TabIndex = 23;
            // 
            // numInventory
            // 
            this.numInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numInventory.Location = new System.Drawing.Point(194, 217);
            this.numInventory.Maximum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.numInventory.Name = "numInventory";
            this.numInventory.Size = new System.Drawing.Size(141, 29);
            this.numInventory.TabIndex = 24;
            // 
            // numCost
            // 
            this.numCost.DecimalPlaces = 2;
            this.numCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCost.Location = new System.Drawing.Point(194, 268);
            this.numCost.Name = "numCost";
            this.numCost.Size = new System.Drawing.Size(141, 29);
            this.numCost.TabIndex = 25;
            // 
            // numMachineId
            // 
            this.numMachineId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMachineId.Location = new System.Drawing.Point(194, 421);
            this.numMachineId.Name = "numMachineId";
            this.numMachineId.Size = new System.Drawing.Size(141, 29);
            this.numMachineId.TabIndex = 26;
            // 
            // PartDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 533);
            this.Controls.Add(this.numMachineId);
            this.Controls.Add(this.numCost);
            this.Controls.Add(this.numInventory);
            this.Controls.Add(this.numMaximum);
            this.Controls.Add(this.numMinimum);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.lblMachineId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPartIdValue);
            this.Controls.Add(this.lblPartId);
            this.Controls.Add(this.rdbOutsourced);
            this.Controls.Add(this.rdbInHouse);
            this.Controls.Add(this.lblHeader);
            this.Name = "PartDetail";
            this.Text = "Part Detail";
            this.Load += new System.EventHandler(this.PartDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numMinimum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaximum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMachineId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.RadioButton rdbInHouse;
        private System.Windows.Forms.RadioButton rdbOutsourced;
        private System.Windows.Forms.Label lblPartId;
        private System.Windows.Forms.Label lblPartIdValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMachineId;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.NumericUpDown numMinimum;
        private System.Windows.Forms.NumericUpDown numMaximum;
        private System.Windows.Forms.NumericUpDown numInventory;
        private System.Windows.Forms.NumericUpDown numCost;
        private System.Windows.Forms.NumericUpDown numMachineId;
    }
}