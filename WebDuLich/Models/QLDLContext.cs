using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using WebDuLich.ModelViews;

#nullable disable

namespace WebDuLich.Models
{
    public partial class QLDLContext : DbContext
    {
        public QLDLContext()
        {
        }

        public QLDLContext(DbContextOptions<QLDLContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Orderdetail> Orderdetails { get; set; }
        public virtual DbSet<Page> Pages { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Transactstatus> Transactstatuses { get; set; }
        public DbSet<Contact> Contacts { get; set; }

        public string WebRootPath { get; internal set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=HUYNH\\SQLEXPRESS;Initial Catalog=QLDL;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => e.AccId)
                    .HasName("PK__ACCOUNTS__91CBC378D8DDA719");

                entity.ToTable("ACCOUNTS");

                entity.Property(e => e.Access).HasColumnName("access");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Encode)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.FullName).HasMaxLength(150);

                entity.Property(e => e.LastLogin).HasColumnType("datetime");

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.Phone)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK__ACCOUNTS__RoleId__276EDEB3");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.CatId)
                    .HasName("PK__CATEGORI__6A1C8AFA05CE9600");

                entity.ToTable("CATEGORIES");

                entity.Property(e => e.CatName).HasMaxLength(300);

                entity.Property(e => e.Image).HasMaxLength(300);

                entity.Property(e => e.Levels).HasColumnName("levels");

                entity.Property(e => e.Title).HasMaxLength(300);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.CusId)
                    .HasName("PK__CUSTOMER__2F187110F9E49177");

                entity.ToTable("CUSTOMERS");

                entity.Property(e => e.Address).HasMaxLength(300);

                entity.Property(e => e.Avata).HasMaxLength(300);

                entity.Property(e => e.Birthday).HasColumnType("datetime");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(300);

                entity.Property(e => e.Encode)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.FullName).HasMaxLength(300);

                entity.Property(e => e.LastLogin).HasColumnType("datetime");

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(300);

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.LocationId)
                    .HasConstraintName("FK__CUSTOMERS__Locat__173876EA");
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.ToTable("LOCATIONS");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.Namewithtype).HasMaxLength(300);

                entity.Property(e => e.Pathwithtype).HasMaxLength(300);

                entity.Property(e => e.Slug).HasMaxLength(100);

                entity.Property(e => e.Type).HasMaxLength(20);
            });

            modelBuilder.Entity<News>(entity =>
            {
                entity.HasKey(e => e.PostId)
                    .HasName("PK__NEWS__AA12601876C0BC79");

                entity.ToTable("NEWS");

                entity.Property(e => e.Author).HasMaxLength(300);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Image).HasMaxLength(300);

                entity.Property(e => e.MetaDesc).HasMaxLength(300);

                entity.Property(e => e.MetaKey).HasMaxLength(300);

                entity.Property(e => e.ShortContent).HasMaxLength(300);

                entity.Property(e => e.Tile).HasMaxLength(300);

                entity.HasOne(d => d.Acc)
                    .WithMany(p => p.News)
                    .HasForeignKey(d => d.AccId)
                    .HasConstraintName("FK__NEWS__AccId__2B3F6F97");

                entity.HasOne(d => d.Cat)
                    .WithMany(p => p.News)
                    .HasForeignKey(d => d.CatId)
                    .HasConstraintName("FK__NEWS__CatId__2A4B4B5E");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("ORDERS");

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentDate).HasColumnType("datetime");

                entity.Property(e => e.ShipDate).HasColumnType("datetime");

                entity.HasOne(d => d.Cus)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CusId)
                    .HasConstraintName("FK__ORDERS__CusId__1BFD2C07");

                entity.HasOne(d => d.Transact)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.TransactId)
                    .HasConstraintName("FK__ORDERS__Transact__1CF15040");
            });

            modelBuilder.Entity<Orderdetail>(entity =>
            {
                entity.ToTable("ORDERDETAILS");

                entity.Property(e => e.ShipDate).HasColumnType("datetime");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Orderdetails)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK__ORDERDETA__Order__1FCDBCEB");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Orderdetails)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__ORDERDETA__Produ__20C1E124");
            });

            modelBuilder.Entity<Page>(entity =>
            {
                entity.ToTable("PAGES");

                entity.Property(e => e.CreatDate).HasColumnType("datetime");

                entity.Property(e => e.Image).HasMaxLength(300);

                entity.Property(e => e.MetaDesc).HasMaxLength(300);

                entity.Property(e => e.MetaKey).HasMaxLength(300);

                entity.Property(e => e.PageName).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(300);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("PRODUCTS");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateModified).HasColumnType("datetime");

                entity.Property(e => e.Image).HasMaxLength(300);

                entity.Property(e => e.MetaDesc).HasMaxLength(300);

                entity.Property(e => e.MetaKey).HasMaxLength(300);

                entity.Property(e => e.ProductName).HasMaxLength(300);

                entity.Property(e => e.ShortDesc).HasMaxLength(300);

                entity.Property(e => e.Title)
                    .HasMaxLength(300)
                    .HasColumnName("title");

                entity.Property(e => e.Video)
                    .HasMaxLength(300)
                    .HasColumnName("video");

                entity.HasOne(d => d.Cat)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CatId)
                    .HasConstraintName("FK__PRODUCTS__CatId__1273C1CD");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("ROLES");

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.RoleName).HasMaxLength(100);
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.ToTable("CONTACT");

                entity.HasKey(e => e.IdLienHe); // Xác định IdLienHe làm khóa chính

                entity.Property(e => e.IdLienHe).HasColumnName("IdLienHe"); // Đặt tên cho cột khóa chính (nếu khác với tên trường trong lớp)
                entity.Property(e => e.FullName).HasMaxLength(300);
                entity.Property(e => e.Email).HasMaxLength(300);
                entity.Property(e => e.Phone).HasMaxLength(12).IsUnicode(false);
                entity.Property(e => e.CreatedAt).HasColumnType("datetime");
                entity.Property(e => e.Note).HasMaxLength(500);
            });



            modelBuilder.Entity<Transactstatus>(entity =>
            {
                entity.HasKey(e => e.TransactId)
                    .HasName("PK__TRANSACT__4400DE5519308CAD");

                entity.ToTable("TRANSACTSTATUS");

                entity.Property(e => e.Status).HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }



        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        public DbSet<WebDuLich.ModelViews.RegisterVM> RegisterVM { get; set; }
    }
}
