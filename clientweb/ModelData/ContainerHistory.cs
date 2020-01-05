namespace clientweb.ModelData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContainerHistory")]
    public partial class ContainerHistory
    {
        [Key]
        public int HistoryID { get; set; }

        public int? ContainerID { get; set; }

        [StringLength(400)]
        public string Comment { get; set; }

        public DateTime? Created { get; set; }

        public int? CreatedBy { get; set; }

        public virtual Container Container { get; set; }

        public virtual User User { get; set; }
    }
}
