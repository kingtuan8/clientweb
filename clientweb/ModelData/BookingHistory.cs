namespace clientweb.ModelData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BookingHistory")]
    public partial class BookingHistory
    {
        [Key]
        public int HistoryID { get; set; }

        public int? BookingID { get; set; }

        public byte? TypeHistory { get; set; }

        [StringLength(300)]
        public string Comment { get; set; }

        public DateTime? Created { get; set; }

        public int? CreatedBy { get; set; }

        public virtual Booking Booking { get; set; }

        public virtual User User { get; set; }
    }
}
