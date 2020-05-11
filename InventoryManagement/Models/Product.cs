using System.ComponentModel;
using System.Linq;

namespace InventoryManagement.Models
{
    public class Product
    {
        // Email from course instructor said that framework getters and setters are acceptable.
        public int Id { get; set; }
        public string Name { get; set; }
        public double Cost { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public BindingList<Part> AssociatedParts { get; set; } = new BindingList<Part>();

        public void AddAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }

        public bool RemoveAssociatedPart(int partId)
        {
            var part = LookupAssociatedPart(partId);

            if (part != null)
            {
                AssociatedParts.Remove(part);
                return true;
            }

            return false;
        }

        public Part LookupAssociatedPart(int partId)
        {
            return AssociatedParts.SingleOrDefault(p => p.Id == partId);
        }
    }
}
