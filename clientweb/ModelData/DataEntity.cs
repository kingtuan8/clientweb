namespace clientweb.ModelData
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataEntity : DbContext
    {
        public DataEntity()
            : base("name=DataEntity")
        {
        }

        public virtual DbSet<Area> Areas { get; set; }
        public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<BookingDetail> BookingDetails { get; set; }
        public virtual DbSet<BookingHistory> BookingHistories { get; set; }
        public virtual DbSet<Container> Containers { get; set; }
        public virtual DbSet<ContainerHistory> ContainerHistories { get; set; }
        public virtual DbSet<ContainerInvoice> ContainerInvoices { get; set; }
        public virtual DbSet<ContainerTransport> ContainerTransports { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Driver> Drivers { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<ListTruckLinked> ListTruckLinkeds { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Mooc> Moocs { get; set; }
        public virtual DbSet<Permission> Permissions { get; set; }
        public virtual DbSet<PermissionRole> PermissionRoles { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<RolesUser> RolesUsers { get; set; }
        public virtual DbSet<Store> Stores { get; set; }
        public virtual DbSet<TransportTruckLink> TransportTruckLinks { get; set; }
        public virtual DbSet<Truck> Trucks { get; set; }
        public virtual DbSet<TypeTransport> TypeTransports { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UsersIsCustomer> UsersIsCustomers { get; set; }
        public virtual DbSet<UsersIsEmployee> UsersIsEmployees { get; set; }
        public virtual DbSet<WEB_EmailRecieve> WEB_EmailRecieve { get; set; }
        public virtual DbSet<WEB_GuestMessage> WEB_GuestMessage { get; set; }
        public virtual DbSet<WEB_Infomation> WEB_Infomation { get; set; }
        public virtual DbSet<WEB_Slide> WEB_Slide { get; set; }
        public virtual DbSet<WEB_Thread> WEB_Thread { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Booking>()
                .Property(e => e.ShipmentNo)
                .IsUnicode(false);

            modelBuilder.Entity<Booking>()
                .Property(e => e.BookingNo)
                .IsUnicode(false);

            modelBuilder.Entity<Booking>()
                .Property(e => e.Declaration)
                .IsUnicode(false);

            modelBuilder.Entity<Booking>()
                .HasOptional(e => e.BookingDetail)
                .WithRequired(e => e.Booking);

            modelBuilder.Entity<BookingDetail>()
                .Property(e => e.InCount)
                .IsUnicode(false);

            modelBuilder.Entity<Container>()
                .Property(e => e.ContainerNo)
                .IsUnicode(false);

            modelBuilder.Entity<Container>()
                .HasOptional(e => e.ContainerInvoice)
                .WithRequired(e => e.Container);

            modelBuilder.Entity<Container>()
                .HasOptional(e => e.ContainerTransport)
                .WithRequired(e => e.Container);

            modelBuilder.Entity<Container>()
                .HasOptional(e => e.TransportTruckLink)
                .WithRequired(e => e.Container);

            modelBuilder.Entity<ContainerInvoice>()
                .Property(e => e.HoaDonNang)
                .IsUnicode(false);

            modelBuilder.Entity<ContainerInvoice>()
                .Property(e => e.TienNang)
                .IsUnicode(false);

            modelBuilder.Entity<ContainerInvoice>()
                .Property(e => e.HoaDonHa)
                .IsUnicode(false);

            modelBuilder.Entity<ContainerInvoice>()
                .Property(e => e.TienHa)
                .IsUnicode(false);

            modelBuilder.Entity<ContainerInvoice>()
                .Property(e => e.HoaDonLocalCharge)
                .IsUnicode(false);

            modelBuilder.Entity<ContainerInvoice>()
                .Property(e => e.TienLocalCharge)
                .IsUnicode(false);

            modelBuilder.Entity<ContainerInvoice>()
                .Property(e => e.HoaDonKhac)
                .IsUnicode(false);

            modelBuilder.Entity<ContainerInvoice>()
                .Property(e => e.TienHDKhac)
                .IsUnicode(false);

            modelBuilder.Entity<ContainerInvoice>()
                .Property(e => e.HoaDonPhatSinh)
                .IsUnicode(false);

            modelBuilder.Entity<ContainerInvoice>()
                .Property(e => e.PhiPhatSinh)
                .IsUnicode(false);

            modelBuilder.Entity<ContainerInvoice>()
                .Property(e => e.PhiNoInvoice)
                .IsUnicode(false);

            modelBuilder.Entity<ContainerInvoice>()
                .Property(e => e.CuocContDepot)
                .IsUnicode(false);

            modelBuilder.Entity<ContainerInvoice>()
                .Property(e => e.CuocHangTau)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.CustCode)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.TaxCode)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.MobilePhone)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Email1)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Email2)
                .IsUnicode(false);

            modelBuilder.Entity<Department>()
                .Property(e => e.DeptCode)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.EmployeeCode)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.MobilePhone)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.BookingDetails)
                .WithOptional(e => e.Employee)
                .HasForeignKey(e => e.AssignIn);

            modelBuilder.Entity<Employee>()
                .HasOptional(e => e.Driver)
                .WithRequired(e => e.Employee);

            modelBuilder.Entity<Location>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Location>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Location>()
                .HasMany(e => e.BookingDetails)
                .WithOptional(e => e.Location)
                .HasForeignKey(e => e.LocationUp);

            modelBuilder.Entity<Location>()
                .HasMany(e => e.BookingDetails1)
                .WithOptional(e => e.Location1)
                .HasForeignKey(e => e.LocationDown);

            modelBuilder.Entity<Mooc>()
                .Property(e => e.MoocNo)
                .IsUnicode(false);

            modelBuilder.Entity<Permission>()
                .Property(e => e.PermissionCode)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<TransportTruckLink>()
                .Property(e => e.TruckNo)
                .IsUnicode(false);

            modelBuilder.Entity<Truck>()
                .Property(e => e.TruckNo)
                .IsUnicode(false);

            modelBuilder.Entity<TypeTransport>()
                .HasMany(e => e.Containers)
                .WithOptional(e => e.TypeTransport)
                .HasForeignKey(e => e.TypeTransportID);

            modelBuilder.Entity<User>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.HashPass)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Bookings)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.CreatedBy);

            modelBuilder.Entity<User>()
                .HasMany(e => e.BookingHistories)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.CreatedBy);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Containers)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.CreatedBy);

            modelBuilder.Entity<User>()
                .HasMany(e => e.ContainerHistories)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.CreatedBy);

            modelBuilder.Entity<User>()
                .HasMany(e => e.ContainerInvoices)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.CreatedBy);

            modelBuilder.Entity<User>()
                .HasMany(e => e.ContainerTransports)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.CreatedBy);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Customers)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.CreatedBy);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Departments)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.CreatedBy);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Employees)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.CreatedBy);

            modelBuilder.Entity<User>()
                .HasMany(e => e.TransportTruckLinks)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.CreatedBy);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Users1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.CreatedBy);

            modelBuilder.Entity<User>()
                .HasOptional(e => e.UsersIsCustomer)
                .WithRequired(e => e.User);

            modelBuilder.Entity<User>()
                .HasOptional(e => e.UsersIsEmployee)
                .WithRequired(e => e.User);

            modelBuilder.Entity<User>()
                .HasMany(e => e.WEB_Thread)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.CreatedBy);

            modelBuilder.Entity<WEB_EmailRecieve>()
                .Property(e => e.EmailAddress)
                .IsUnicode(false);

            modelBuilder.Entity<WEB_GuestMessage>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<WEB_Infomation>()
                .Property(e => e.Typed)
                .IsUnicode(false);

            modelBuilder.Entity<WEB_Slide>()
                .Property(e => e.SlideImage)
                .IsUnicode(false);

            modelBuilder.Entity<WEB_Thread>()
                .Property(e => e.ThreadImage)
                .IsUnicode(false);

            modelBuilder.Entity<WEB_Thread>()
                .Property(e => e.URLRewrite)
                .IsUnicode(false);
        }
    }
}
