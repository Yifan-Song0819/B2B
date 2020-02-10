﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sunning.Data;

namespace Sunning.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Sunning.Models.Login", b =>
                {
                    b.Property<string>("user")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("passwd");

                    b.HasKey("user");

                    b.ToTable("Logins");
                });

            modelBuilder.Entity("Sunning.Models.Warehouse", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("address");

                    b.Property<string>("desc");

                    b.Property<string>("name");

                    b.Property<string>("owner");

                    b.HasKey("id");

                    b.ToTable("Warehouses");
                });
#pragma warning restore 612, 618
        }
    }
}
