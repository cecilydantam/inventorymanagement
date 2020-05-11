namespace InventoryManagement.Models
{
    public class InhousePart : Part
    {
        public InhousePart(bool newPart, int maxId = 0, int existingId = 0) : base(newPart: newPart, maxId: maxId, existingId: existingId) { }
        public int MachineId { get; set; }
    }
}
