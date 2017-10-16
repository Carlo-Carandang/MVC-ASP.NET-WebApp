namespace WebApplication2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customer")]
    public partial class Customer
    {
        public int ID { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

        public string streetNo { get; set; }

        public string city { get; set; }

        public string province { get; set; }

        public string country { get; set; }

        [Display(Name = "Postal code")]
        [Required(ErrorMessage = "The postal code is required")]
        [RegularExpression("([A-Z]\d){3}", ErrorMessage = "Postal code is not valid")]
        public string postalCode { get; set; }

        [Display(Name = "Phone number")]
        [Required(ErrorMessage = "The phone number is required")]
        [RegularExpression("\d{3}-\d{3}-\d{4}", ErrorMessage = "Phone number is not valid")]
        public string phoneNo { get; set; }

        [Display(Name = "Email address")]
        [Required(ErrorMessage = "The email adress is required")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Email is not valid")]
        public string email { get; set; }
    }
}
