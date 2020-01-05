namespace clientweb.ModelData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TransportTruckLink")]
    public partial class TransportTruckLink
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ContainerID { get; set; }

        public int? TruckLinkID { get; set; }

        [StringLength(15)]
        public string TruckNo { get; set; }

        [StringLength(50)]
        public string DriverName { get; set; }

        public DateTime? DateTransport { get; set; }

        [StringLength(400)]
        public string Noted { get; set; }

        public DateTime? Updated { get; set; }

        public int? CreatedBy { get; set; }

        public virtual Container Container { get; set; }

        public virtual ListTruckLinked ListTruckLinked { get; set; }

        public virtual User User { get; set; }
    }
}
