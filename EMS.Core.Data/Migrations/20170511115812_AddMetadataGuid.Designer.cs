using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using EMS.Core.Data;

namespace EMS.Core.Data.Migrations
{
    [DbContext(typeof(Web.Core.Data.Context))]
    [Migration("20170511115812_AddMetadataGuid")]
    partial class AddMetadataGuid
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EMS.Core.Entities.Company", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("EMS.Core.Entities.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("CompanyId");

                    b.Property<string>("FirstName");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LastName");

                    b.Property<string>("Position");

                    b.Property<int>("Salary");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("EMS.Core.Entities.Employee", b =>
                {
                    b.HasOne("EMS.Core.Entities.Company", "Company")
                        .WithMany("Employees")
                        .HasForeignKey("CompanyId");
                });
        }
    }
}
