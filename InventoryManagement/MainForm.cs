using InventoryManagement.Enum;
using InventoryManagement.Models;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Linq;

namespace InventoryManagement
{
    public partial class MainForm : Form
    {
        public Inventory Inventory { get; set; } = new Inventory();
        public delegate void InventoryUpdated();

        public MainForm()
        {
            InitializeComponent();
            SeedData();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            BindGrids();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void BindGrids()
        {
            PartsGrid.DataSource = Inventory.Parts;
            ProductsGrid.DataSource = Inventory.Products;
        }

        private void btnAddPart_Click(object sender, EventArgs e)
        {
            var addPartForm = new PartDetail(DetailMode.Add, this);
            addPartForm.Show();
        }

        private void btnModifyPart_Click(object sender, EventArgs e)
        {
            var selectedPart = (Part)PartsGrid.SelectedRows[0].DataBoundItem;
            var modifyPartForm = new PartDetail(DetailMode.Modify, this, selectedPart);
            modifyPartForm.Show();
        }

        private void SeedData()
        {
            Inventory.Parts.Add(new InhousePart(true, 0) { Name = "dinglehopper", Cost = 3.5, Min = 0, Max = 10, InStock = 35, MachineId = 2 });
            Inventory.Parts.Add(new InhousePart(true, 1) { Name = "gizmos", Cost = 5, Min = 0, Max = 10, InStock = 25, MachineId = 2 });
            Inventory.Parts.Add(new InhousePart(true, 2) { Name = "gadgets", Cost = 10, Min = 0, Max = 10, InStock = 75, MachineId = 2 });
            Inventory.Parts.Add(new OutsourcedPart(true, 3) { Name = "whosits", Cost = 2, Min = 0, Max = 10, InStock = 100, CompanyName = "Acme" });
            Inventory.Parts.Add(new OutsourcedPart(true, 4) { Name = "whatsits", Cost = 1.75, Min = 0, Max = 10, InStock = 200, CompanyName = "Acme" });
            Inventory.Parts.Add(new OutsourcedPart(true, 5) { Name = "thingamabobs", Cost = 6, Min = 0, Max = 10, InStock = 20, CompanyName = "Acme" });

            Inventory.Products.Add(new Product() { Id = 1, Name = "tacos", Cost = 3.5, Min = 0, Max = 10, InStock = 35 });
            Inventory.Products.Add(new Product() { Id = 2, Name = "burgers", Cost = 3.5, Min = 0, Max = 10, InStock = 35 });
            Inventory.Products.Add(new Product() { Id = 3, Name = "mac n cheese", Cost = 3.5, Min = 0, Max = 10, InStock = 35 });
            Inventory.Products.Add(new Product() { Id = 4, Name = "robot mac n cheese", Cost = 3.5, Min = 0, Max = 10, InStock = 35 });
            Inventory.Products.Add(new Product() { Id = 5, Name = "carrots", Cost = 3.5, Min = 0, Max = 10, InStock = 35 });
            Inventory.Products.Add(new Product() { Id = 6, Name = "fruit", Cost = 3.5, Min = 0, Max = 10, InStock = 35 });
        }

        private void btnDeletePart_Click(object sender, EventArgs e)
        {
            var selectedPart = (Part)PartsGrid.SelectedRows[0].DataBoundItem;
            if (!Inventory.IsPartInUse(selectedPart))
            {
                Inventory.RemovePart(selectedPart.Id);
                BindGrids();
            }
            else
            {
                MessageBox.Show("Cannot delete part - currently in use", "Part In Use", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPartSearch_Click(object sender, EventArgs e)
        {
            PartsGrid.DataSource = SearchParts(txtPartSearch.Text.Trim());
        }

        private BindingList<Part> SearchParts(string query)
        {
            var queryableParts = Inventory.Parts.ToList();
            var searchResults = queryableParts.Where(p => p.Name.Contains(query)).ToList();
            return new BindingList<Part>(searchResults);
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            var addProductForm = new ProductDetail(DetailMode.Add, this);
            addProductForm.Show();
        }

        private void btnModifyProduct_Click(object sender, EventArgs e)
        {
            var selectedProduct = (Product)ProductsGrid.SelectedRows[0].DataBoundItem;
            var modifyProductForm = new ProductDetail(DetailMode.Modify, this, selectedProduct);
            modifyProductForm.Show();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            var selectedProduct = (Product)ProductsGrid.SelectedRows[0].DataBoundItem;
            Inventory.RemoveProduct(selectedProduct.Id);
            BindGrids();
        }

        private void btnProductSearch_Click(object sender, EventArgs e)
        {
            ProductsGrid.DataSource = SearchProducts(txtProductSearch.Text.Trim());
        }

        private BindingList<Product> SearchProducts(string query)
        {
            var queryableProducts = Inventory.Products.ToList();
            var searchResults = queryableProducts.Where(p => p.Name.Contains(query)).ToList();
            return new BindingList<Product>(searchResults);
        }
    }
}
