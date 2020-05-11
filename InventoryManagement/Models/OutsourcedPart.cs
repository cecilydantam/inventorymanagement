namespace InventoryManagement.Models
{
    public class OutsourcedPart : Part
    {
        public OutsourcedPart(bool newPart, int maxId = 0, int existingId = 0) : base(newPart: newPart, maxId: maxId, existingId: existingId) { }
        public string CompanyName { get; set; }
    }
}
