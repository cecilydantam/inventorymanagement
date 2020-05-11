using InventoryManagement.Enum;
using InventoryManagement.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class PartDetail : Form
    {
        public DetailMode Mode { get; set; }
        public PartSource Source { get; set; }
        public Part PartToModify { get; set; }
        public MainForm MainForm { get; set; }

        public PartDetail(DetailMode mode, MainForm parent, Part partToModify = null)
        {
            Mode = mode;
            MainForm = parent;
            PartToModify = partToModify;
            InitializeComponent();

            if (partToModify != null)
            {
                if (PartToModify.GetType() == typeof(InhousePart))
                {
                    Source = PartSource.Inhouse;
                    rdbInHouse.Checked = true;
                    rdbOutsourced.Checked = false;
                }

                if (PartToModify.GetType() == typeof(OutsourcedPart))
                {
                    Source = PartSource.Outsourced;
                    rdbInHouse.Checked = false;
                    rdbOutsourced.Checked = true;
                }
            }
        }

        private void PartDetail_Load(object sender, EventArgs e)
        {
            if (Mode == DetailMode.Add)
            {
                lblHeader.Text = "Add Part";
                lblPartId.Visible = false;
                lblPartIdValue.Visible = false;
            }
            else if (Mode == DetailMode.Modify)
            {
                lblHeader.Text = "Modify Part";
                lblPartId.Visible = true;
                lblPartIdValue.Visible = true;

                LoadData();
            }
            else
            {
                Close();
            }
        }

        private void LoadData()
        {
            lblPartIdValue.Text = PartToModify.Id.ToString();
            txtName.Text = PartToModify.Name;
            numCost.Value = Convert.ToDecimal(PartToModify.Cost);
            numInventory.Value = PartToModify.InStock;
            numMinimum.Value = PartToModify.Min;
            numMaximum.Value = PartToModify.Max;

            if (Source == PartSource.Inhouse)
            {
                var inHousePart = (InhousePart)PartToModify;
                numMachineId.Value = inHousePart.MachineId;
            }
            else if (Source == PartSource.Outsourced)
            {
                var outsourcedPart = (OutsourcedPart)PartToModify;
                txtCompanyName.Text = outsourcedPart.CompanyName;
            }
        }

        private void rdbInHouse_CheckedChanged(object sender, EventArgs e)
        {
            Source = PartSource.Inhouse;
            lblMachineId.Visible = true;
            numMachineId.Visible = true;
            lblCompanyName.Visible = false;
            txtCompanyName.Visible = false;
            txtCompanyName.Text = null;
        }

        private void rdbOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            Source = PartSource.Outsourced;
            lblMachineId.Visible = false;
            numMachineId.Visible = false;
            lblCompanyName.Visible = true;
            txtCompanyName.Visible = true;
            numMachineId.Value = 0;
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
                var part = ConstructPart(true);
                SaveNewPart(part);
            }
            else if (Mode == DetailMode.Modify)
            {
                var part = ConstructPart(false, PartToModify.Id);
                MainForm.Inventory.UpdatePart(PartToModify.Id, part);
            }

            MainForm.BindGrids();
            Close();
        }

        private Part ConstructPart(bool isNew, int existingId = 0)
        {
            // Usually the DB would auto-increment
            var maxId = MainForm.Inventory.Parts.OrderByDescending(p => p.Id).FirstOrDefault().Id;

            if (Source == PartSource.Inhouse)
            {
                var part = new InhousePart(isNew, maxId, existingId)
                {
                    Name = txtName.Text,
                    Cost = Convert.ToDouble(numCost.Value),
                    InStock = Convert.ToInt32(numInventory.Value),
                    Min = Convert.ToInt32(numMinimum.Value),
                    Max = Convert.ToInt32(numMaximum.Value),
                    MachineId = Convert.ToInt32(numMachineId.Value)
                };

                return part;
            }
            else if (Source == PartSource.Outsourced)
            {
                var part = new OutsourcedPart(isNew, maxId, existingId)
                {
                    Name = txtName.Text,
                    Cost = Convert.ToDouble(numCost.Value),
                    InStock = Convert.ToInt32(numInventory.Value),
                    Min = Convert.ToInt32(numMinimum.Value),
                    Max = Convert.ToInt32(numMaximum.Value),
                    CompanyName = txtCompanyName.Text
                };

                return part;
            }
            return null;
        }

        private void SaveNewPart(Part part)
        {
            if (ValidatePart(part))
                MainForm.Inventory.AddPart(part);
        }

        private bool ValidatePart(Part part)
        {
            if (part.Min > part.Max)
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

            if (Source == PartSource.Inhouse && numMachineId.Value == 0)
            {
                MessageBox.Show("Machine Id Cannot Be Zero", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (Source == PartSource.Outsourced && txtCompanyName == null)
            {
                MessageBox.Show("Please Provide Company Name", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
