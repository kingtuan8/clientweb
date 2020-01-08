namespace clientweb.ModelData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WEB_EmailRecieve
    {
        [Key]
        public int EmailID { get; set; }

        [StringLength(100)]
        public string EmailAddress { get; set; }

        public DateTime? Created { get; set; }
    }
}
