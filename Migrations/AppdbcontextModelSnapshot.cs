// <auto-generated />
using EmployeeManagement.Modals;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EmployeeManagement.Migrations
{
    [DbContext(typeof(Appdbcontext))]
    partial class AppdbcontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EmloyManagement.modal.Employ", b =>
                {
                    b.Property<int>("EmployID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployID");

                    b.ToTable("Employ");

                    b.HasData(
                        new
                        {
                            EmployID = 1,
                            Email = "John.smith@gmail.com",
                            FirstName = "John",
                            Gender = 0,
                            LastName = "Smith"
                        },
                        new
                        {
                            EmployID = 2,
                            Email = "Joe1987@gmail.com",
                            FirstName = "Joe",
                            Gender = 0,
                            LastName = "Gabrial"
                        },
                        new
                        {
                            EmployID = 3,
                            Email = "StrangerThings234@gmail.com",
                            FirstName = "Will",
                            Gender = 0,
                            LastName = "Hamster"
                        },
                        new
                        {
                            EmployID = 4,
                            Email = "Shela.Bhabi@gmail.com",
                            FirstName = "shela",
                            Gender = 1,
                            LastName = "Barber"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
