namespace clientweb.ModelData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Booking")]
    public partial class Booking
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Booking()
        {
            BookingHistories = new HashSet<BookingHistory>();
            Containers = new HashSet<Container>();
        }

        public int BookingID { get; set; }

        public DateTime? PlanDate { get; set; }

        [StringLength(100)]
        public string ShipmentNo { get; set; }

        [StringLength(100)]
        public string BookingNo { get; set; }

        [StringLength(100)]
        public string Declaration { get; set; }

        public DateTime? DeclarationDate { get; set; }

        public int? CustID { get; set; }

        public byte? Status { get; set; }

        public bool? IsContainer { get; set; }

        public bool? Active { get; set; }

        public DateTime? Created { get; set; }

        public int? CreatedBy { get; set; }

        public virtual User User { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual BookingDetail BookingDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookingHistory> BookingHistories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Container> Containers { get; set; }
    }
}
