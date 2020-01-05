namespace clientweb.ModelData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContainerTransport")]
    public partial class ContainerTransport
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ContainerID { get; set; }

        public int? TruckID { get; set; }

        public int? EmployeeID { get; set; }

        public int? MoocID { get; set; }

        public DateTime? DateTransport { get; set; }

        public DateTime? Updated { get; set; }

        public int? CreatedBy { get; set; }

        public virtual Container Container { get; set; }

        public virtual User User { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Mooc Mooc { get; set; }

        public virtual Truck Truck { get; set; }
    }
}
