namespace clientweb.ModelData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Driver")]
    public partial class Driver
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EmployeeID { get; set; }

        public int? TruckID { get; set; }

        public bool? Locked { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Truck Truck { get; set; }
    }
}
