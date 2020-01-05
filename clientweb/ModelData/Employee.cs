namespace clientweb.ModelData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            BookingDetails = new HashSet<BookingDetail>();
            ContainerTransports = new HashSet<ContainerTransport>();
            UsersIsEmployees = new HashSet<UsersIsEmployee>();
        }

        public int EmployeeID { get; set; }

        [StringLength(12)]
        public string EmployeeCode { get; set; }

        [StringLength(100)]
        public string FullName { get; set; }

        public int? DeptID { get; set; }

        [StringLength(100)]
        public string JobTitle { get; set; }

        [StringLength(40)]
        public string Email { get; set; }

        [StringLength(40)]
        public string MobilePhone { get; set; }

        [StringLength(200)]
        public string Address { get; set; }

        public DateTime? StartDate { get; set; }

        public bool? IsDriver { get; set; }

        public bool? Working { get; set; }

        public DateTime? Created { get; set; }

        public int? CreatedBy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookingDetail> BookingDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContainerTransport> ContainerTransports { get; set; }

        public virtual Department Department { get; set; }

        public virtual Driver Driver { get; set; }

        public virtual User User { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UsersIsEmployee> UsersIsEmployees { get; set; }
    }
}
