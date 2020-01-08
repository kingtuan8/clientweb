namespace clientweb.ModelData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WEB_GuestMessage
    {
        [Key]
        public int MessageID { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(60)]
        public string Email { get; set; }

        [StringLength(400)]
        public string Content { get; set; }

        public DateTime? Created { get; set; }
    }
}
