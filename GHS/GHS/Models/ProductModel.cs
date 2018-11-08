using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GHS.Models
{
    public class ProductModel
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string Name { get; set; }
        public virtual int CategoryId { get; set; }
        [EnumDataType(typeof(Category))]
        public Category Category
        {
            get
            {
                return (Category)this.CategoryId;
            }
            set
            {
                this.CategoryId = (int)value;
            }
        }
        public string Description { get; set; }
        [DataType(DataType.Currency)]
        public double Price { get; set; }

        public override bool Equals(object obj)
        {
            ProductModel that = (ProductModel)obj;
            if (this.Name == that.Name && this.Category == that.Category && this.Description == that.Description && this.Price == that.Price)
            {
                return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() ^ Category.GetHashCode() ^ Description.GetHashCode() ^ Price.GetHashCode();
        }

    }

    public enum Category
    {
        snacker,
        small,
        medium,
        large
    }
}
