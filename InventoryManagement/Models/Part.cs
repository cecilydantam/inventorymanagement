using System;

namespace InventoryManagement.Models
{
    public abstract class Part
    {
        public Part(bool newPart, int maxId = 0, int existingId = 0)
        {
            if (newPart)
            {
                Id = maxId + 1;
            }
            else
            {
                Id = existingId;
            }
        }
        // Email from course instructor said that framework getters and setters are acceptable.
        public int Id { get; set; }
        public string Name { get; set; }
        public double Cost { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
    }
}
