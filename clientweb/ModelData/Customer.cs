namespace clientweb.ModelData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            Bookings = new HashSet<Booking>();
            UsersIsCustomers = new HashSet<UsersIsCustomer>();
        }

        [Key]
        public int CustID { get; set; }

        [StringLength(100)]
        public string CustName { get; set; }

        [StringLength(20)]
        public string CustCode { get; set; }

        [StringLength(12)]
        public string TaxCode { get; set; }

        [StringLength(200)]
        public string Address1 { get; set; }

        [StringLength(200)]
        public string Address2 { get; set; }

        [StringLength(16)]
        public string PhoneNumber { get; set; }

        [StringLength(16)]
        public string MobilePhone { get; set; }

        [StringLength(40)]
        public string Email1 { get; set; }

        [StringLength(40)]
        public string Email2 { get; set; }

        public bool? Active { get; set; }

        public DateTime? Created { get; set; }

        public int? CreatedBy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Booking> Bookings { get; set; }

        public virtual User User { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UsersIsCustomer> UsersIsCustomers { get; set; }
    }
}
