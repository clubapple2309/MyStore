using System;
using System.ComponentModel.DataAnnotations;

namespace ClothesStore.DB.Entities
{
  public  class Product
    {
        public int ProductId { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Specify the name")]
        public string Name { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "Description")]
        [Required(ErrorMessage = "Specify Description")]
        public string Description { get; set; }

        [Display(Name = "Category")]
        [Required(ErrorMessage = "Specify Category")]
        public string Category { get; set; }

        [Display(Name = "Price $")]
        [Required(ErrorMessage = "Specify Price")]
        [Range(0.01, double.MaxValue, ErrorMessage = "A value must be positive")]
        public decimal Price { get; set; }

        public byte[] ImageData { get; set; }

        public string ImageMimeType { get; set; }
    }
}
