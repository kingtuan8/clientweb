namespace clientweb.ModelData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Mooc")]
    public partial class Mooc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Mooc()
        {
            ContainerTransports = new HashSet<ContainerTransport>();
        }

        public int MoocID { get; set; }

        [StringLength(30)]
        public string MoocNo { get; set; }

        public int? TruckID { get; set; }

        public bool? Locked { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContainerTransport> ContainerTransports { get; set; }

        public virtual Truck Truck { get; set; }
    }
}
