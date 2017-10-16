namespace WebApplication2.Views.Shared
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

        public string postalCode { get; set; }

        public string phoneNo { get; set; }

        public string email { get; set; }
    }
}
