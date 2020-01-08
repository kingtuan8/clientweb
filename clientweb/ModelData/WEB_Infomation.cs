namespace clientweb.ModelData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WEB_Infomation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int InfoID { get; set; }

        [StringLength(300)]
        public string Content { get; set; }

        [StringLength(4)]
        public string Typed { get; set; }
    }
}
