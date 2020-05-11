using InventoryManagement.Enum;
using InventoryManagement.Models;
using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class ProductDetail : Form
    {
        public DetailMode Mode { get; set; }
        public Product ProductToModify { get; set; }
        public MainForm MainForm { get; set; }
        public BindingList<Part> AssociatedParts { get; set; } = new BindingList<Part>();

        public ProductDetail(DetailMode mode, MainForm parent, Product productToModify = null)
        {
            Mode = mode;
            MainForm = parent;
            ProductToModify = productToModify;
            AssociatedParts = (productToModify != null) ? ProductToModify.AssociatedParts : new BindingList<Part>();
            InitializeComponent();
            BindAllGrids();
        }

        private void BindAllGrids()
        {
            AllPartsGrid.DataSource = MainForm.Inventory.Parts;
            AssociatedPartsGrid.DataSource = AssociatedParts;
        }

        private void BindSelectedGrid()
        {
            AssociatedPartsGrid.DataSource = AssociatedParts;
        }

        private void ProductDetail_Load(object sender, EventArgs e)
        {
            if (Mode == DetailMode.Add)
            {
                lblHeader.Text = "Add Product";
                lblProductId.Visible = false;
                lblProductIdValue.Visible = false;
            }
            else if (Mode == DetailMode.Modify)
            {
                lblHeader.Text = "Modify Product";
                lblProductId.Visible = true;
                lblProductIdValue.Visible = true;

                LoadData();
            }
            else
            {
                Close();
            }
        }

        private void LoadData()
        {
            lblProductIdValue.Text = ProductToModify.Id.ToString();
            txtName.Text = ProductToModify.Name;
            numCost.Value = Convert.ToDecimal(ProductToModify.Cost);
            numInventory.Value = ProductToModify.InStock;
            numMinimum.Value = ProductToModify.Min;
            numMaximum.Value = ProductToModify.Max;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
                return;

            if (Mode == DetailMode.Add)
            {
                var product = ConstructProduct(true);
                SaveNewProduct(product);
            }
            else if (Mode == DetailMode.Modify)
            {
                var part = ConstructProduct(false, ProductToModify.Id);
                MainForm.Inventory.UpdateProduct(ProductToModify.Id, part);
            }

            MainForm.BindGrids();
            Close();
        }

        private Product ConstructProduct(bool isNew, int existingId = 0)
        {
            // Usually the DB would auto-increment
            var maxId = MainForm.Inventory.Products.OrderByDescending(p => p.Id).FirstOrDefault().Id;

            var product = new Product()
            {
                Id = (isNew) ? maxId + 1 : existingId,
                Name = txtName.Text,
                Cost = Convert.ToDouble(numCost.Value),
                InStock = Convert.ToInt32(numInventory.Value),
                Min = Convert.ToInt32(numMinimum.Value),
                Max = Convert.ToInt32(numMaximum.Value),
                AssociatedParts = AssociatedParts
            };

            return product;
        }

        private void SaveNewProduct(Product product)
        {
            if (ValidateProduct(product))
                MainForm.Inventory.AddProduct(product);
        }

        private bool ValidateProduct(Product product)
        {
            if (product.Min > product.Max)
            {
                MessageBox.Show("Min must be less than max.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool ValidateForm()
        {
            if (txtName.Text == null
                || numMaximum.Value == 0)
            {
                MessageBox.Show("Please Fill Out All Fields", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnAddPart_Click(object sender, EventArgs e)
        {
            var selectedPart = (Part)AllPartsGrid.SelectedRows[0].DataBoundItem;
            AssociatedParts.Add(selectedPart);
            BindSelectedGrid();
        }

        private void btnRemovePart_Click(object sender, EventArgs e)
        {
            var selectedPart = (Part)AssociatedPartsGrid.SelectedRows[0].DataBoundItem;
            AssociatedParts.Remove(selectedPart);
            BindSelectedGrid();
        }

        private void btnPartSearch_Click(object sender, EventArgs e)
        {
            AllPartsGrid.DataSource = SearchParts(txtPartSearch.Text.Trim());
        }

        private BindingList<Part> SearchParts(string query)
        {
            var queryableParts = MainForm.Inventory.Parts.ToList();
            var searchResults = queryableParts.Where(p => p.Name.Contains(query)).ToList();
            return new BindingList<Part>(searchResults);
        }
    }
}
