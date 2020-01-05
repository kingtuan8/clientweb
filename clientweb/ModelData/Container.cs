namespace clientweb.ModelData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Container")]
    public partial class Container
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Container()
        {
            ContainerHistories = new HashSet<ContainerHistory>();
        }

        public int ContainerID { get; set; }

        [StringLength(14)]
        public string ContainerNo { get; set; }

        public int? BookingID { get; set; }

        public int? TypeTransportID { get; set; }

        public bool? TypeTrans { get; set; }

        public bool? IsLocal { get; set; }

        public DateTime? Created { get; set; }

        public int? CreatedBy { get; set; }

        public bool? IsTransported { get; set; }

        public bool? IsDeleted { get; set; }

        public byte? StatusC { get; set; }

        public virtual Booking Booking { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContainerHistory> ContainerHistories { get; set; }

        public virtual ContainerTransport ContainerTransport { get; set; }

        public virtual ContainerInvoice ContainerInvoice { get; set; }

        public virtual User User { get; set; }

        public virtual TypeTransport TypeTransport { get; set; }

        public virtual TransportTruckLink TransportTruckLink { get; set; }
    }
}
