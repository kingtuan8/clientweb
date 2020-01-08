namespace clientweb.ModelData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WEB_Thread
    {
        [Key]
        public int ThreadID { get; set; }

        [StringLength(200)]
        public string ThreadTitle { get; set; }

        [StringLength(400)]
        public string ThreadDescript { get; set; }

        public string ThreadContent { get; set; }

        [StringLength(100)]
        public string ThreadImage { get; set; }

        public byte? CategoryID { get; set; }

        [StringLength(200)]
        public string URLRewrite { get; set; }

        public DateTime? Created { get; set; }

        public int? CreatedBy { get; set; }

        public virtual User User { get; set; }
    }
}
