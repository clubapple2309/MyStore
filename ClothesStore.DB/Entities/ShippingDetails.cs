using System.ComponentModel.DataAnnotations;


        namespace ClothesStore.DB.Entities
{
    public class ShippingDetails
    {
        [Required(ErrorMessage = "Enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Insert the first delivery address")]
        [Display(Name = "First Adress")]
        public string Line1 { get; set; }
        [Display(Name = "Second Adress")]
        public string Line2 { get; set; }
        [Display(Name = "Theard Adress")]
        public string Line3 { get; set; }

        [Required(ErrorMessage = "Enter city")]
        [Display(Name = "City")]
        public string City { get; set; }

        [Required(ErrorMessage = "Enter country")]
        [Display(Name = "Country")]
        public string Country { get; set; }
        public bool GiftWrap { get; set; }
    }
}