namespace clientweb.ModelData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BookingDetail")]
    public partial class BookingDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BookingID { get; set; }

        public byte? TypeImEx { get; set; }

        public DateTime? ETDETA { get; set; }

        [StringLength(50)]
        public string InCount { get; set; }

        public DateTime? CutOffTime { get; set; }

        [StringLength(100)]
        public string MotherShip { get; set; }

        public int? AssignIn { get; set; }

        public int? NVLamLenhGiamSat { get; set; }

        public int? LocationUp { get; set; }

        public int? LocationDown { get; set; }

        public int? StoreID { get; set; }

        public string Noted { get; set; }

        public virtual Booking Booking { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Location Location { get; set; }

        public virtual Location Location1 { get; set; }

        public virtual Store Store { get; set; }
    }
}
