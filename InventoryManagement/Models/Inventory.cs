using System.ComponentModel;
using System.Linq;

namespace InventoryManagement.Models
{
    public class Inventory
    {
        public BindingList<Product> Products { get; set; } = new BindingList<Product>();
        public BindingList<Part> Parts { get; set; } = new BindingList<Part>();

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public bool RemoveProduct(int productId)
        {
            var product = LookupProduct(productId);

            if (product != null)
            {
                Products.Remove(product);
                return true;
            }
            return false;
        }

        public Product LookupProduct(int productId)
        {
            return Products.SingleOrDefault(p => p.Id == productId);
        }

        public void UpdateProduct(int productId, Product product)
        {
            var productToReplace = LookupProduct(productId);

            if (productToReplace != null)
                Products[Products.IndexOf(productToReplace)] = product;
        }

        public void AddPart(Part part)
        {
            Parts.Add(part);
        }

        public bool RemovePart(int partId)
        {
            var part = LookupPart(partId);

            if (part != null)
            {
                Parts.Remove(part);
                return true;
            }
            return false;
        }

        public Part LookupPart(int partId)
        {
            return Parts.SingleOrDefault(p => p.Id == partId);
        }

        public void UpdatePart(int partId, Part part)
        {
            var partToReplace = LookupPart(partId);

            if (partToReplace != null)
                Parts[Parts.IndexOf(partToReplace)] = part;
        }

        public bool IsPartInUse(Part part)
        {
            var queryableProducts = Products.ToList();
            return queryableProducts.Any(p => p.AssociatedParts.Contains(part));
        }
    }
}
