namespace clientweb.ModelData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContainerInvoice")]
    public partial class ContainerInvoice
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ContainerID { get; set; }

        [StringLength(20)]
        public string HoaDonNang { get; set; }

        [StringLength(10)]
        public string TienNang { get; set; }

        [StringLength(20)]
        public string HoaDonHa { get; set; }

        [StringLength(10)]
        public string TienHa { get; set; }

        [StringLength(20)]
        public string HoaDonLocalCharge { get; set; }

        [StringLength(10)]
        public string TienLocalCharge { get; set; }

        [StringLength(20)]
        public string HoaDonKhac { get; set; }

        [StringLength(10)]
        public string TienHDKhac { get; set; }

        [StringLength(20)]
        public string HoaDonPhatSinh { get; set; }

        [StringLength(10)]
        public string PhiPhatSinh { get; set; }

        [StringLength(10)]
        public string PhiNoInvoice { get; set; }

        [StringLength(400)]
        public string NoteInvoice { get; set; }

        [StringLength(10)]
        public string CuocContDepot { get; set; }

        [StringLength(10)]
        public string CuocHangTau { get; set; }

        public DateTime? Updated { get; set; }

        public bool? IsUpdateBill { get; set; }

        public int? CreatedBy { get; set; }

        public virtual Container Container { get; set; }

        public virtual User User { get; set; }
    }
}
