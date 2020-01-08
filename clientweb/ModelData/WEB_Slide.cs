namespace clientweb.ModelData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WEB_Slide
    {
        [Key]
        public int SlideID { get; set; }

        [StringLength(400)]
        public string SlideContent { get; set; }

        [StringLength(200)]
        public string SlideImage { get; set; }
    }
}
