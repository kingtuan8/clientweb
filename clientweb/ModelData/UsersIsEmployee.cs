namespace clientweb.ModelData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UsersIsEmployee")]
    public partial class UsersIsEmployee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserID { get; set; }

        public int? EmployeeID { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual User User { get; set; }
    }
}
