﻿// <auto-generated />
using System;
using AspDotNetCore.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AspDotNetCore.DataAccess.Migrations
{
    [DbContext(typeof(AspDotNetCoreDBContext))]
    partial class AspDotNetCoreDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AspDotNetCore.DataAccess.Models.Currency", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOnUtc")
                        .HasColumnType("datetime2");

                    b.Property<string>("CurrencyCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomFormatting")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DisplayLocale")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<bool>("LimitedToStores")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Published")
                        .HasColumnType("bit");

                    b.Property<decimal>("Rate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("RoundingTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedOnUtc")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Currencies");
                });

            modelBuilder.Entity("AspDotNetCore.DataAccess.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("AdminComment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AffiliateId")
                        .HasColumnType("int");

                    b.Property<int?>("BillingAddressId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CannotLoginUntilDateUtc")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedOnUtc")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CustomerGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailToRevalidate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FailedLoginAttempts")
                        .HasColumnType("int");

                    b.Property<bool>("HasShoppingCartItems")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSystemAccount")
                        .HasColumnType("bit");

                    b.Property<bool>("IsTaxExempt")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastActivityDateUtc")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastIpAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastLoginDateUtc")
                        .HasColumnType("datetime2");

                    b.Property<int>("RegisteredInStoreId")
                        .HasColumnType("int");

                    b.Property<bool>("RequireReLogin")
                        .HasColumnType("bit");

                    b.Property<int?>("ShippingAddressId")
                        .HasColumnType("int");

                    b.Property<string>("SystemName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VendorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("AspDotNetCore.DataAccess.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Designation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("AspDotNetCore.DataAccess.Models.EmployeeDetails", b =>
                {
                    b.Property<int>("EmployeeDetailsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.HasKey("EmployeeDetailsId");

                    b.HasIndex("EmployeeId")
                        .IsUnique();

                    b.ToTable("EmployeeDetails");
                });

            modelBuilder.Entity("AspDotNetCore.DataAccess.Models.Feature", b =>
                {
                    b.Property<int>("FeatureId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FeatureName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ModuleId")
                        .HasColumnType("int");

                    b.HasKey("FeatureId");

                    b.HasIndex("ModuleId");

                    b.ToTable("Features");
                });

            modelBuilder.Entity("AspDotNetCore.DataAccess.Models.Module", b =>
                {
                    b.Property<int>("ModuleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ModuleName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ModuleId");

                    b.ToTable("modules");
                });

            modelBuilder.Entity("AspDotNetCore.DataAccess.Models.SubFeature", b =>
                {
                    b.Property<int>("SubFeatureId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FeatureId")
                        .HasColumnType("int");

                    b.Property<string>("SubFeatureName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubFeatureId");

                    b.HasIndex("FeatureId");

                    b.ToTable("SubFeatures");
                });

            modelBuilder.Entity("AspDotNetCore.DataAccess.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("AspDotNetCore.DataAccess.Models.EmployeeDetails", b =>
                {
                    b.HasOne("AspDotNetCore.DataAccess.Models.Employee", "Employees")
                        .WithOne("EmployeeDetails")
                        .HasForeignKey("AspDotNetCore.DataAccess.Models.EmployeeDetails", "EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employees");
                });

            modelBuilder.Entity("AspDotNetCore.DataAccess.Models.Feature", b =>
                {
                    b.HasOne("AspDotNetCore.DataAccess.Models.Module", "Module")
                        .WithMany("Features")
                        .HasForeignKey("ModuleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Module");
                });

            modelBuilder.Entity("AspDotNetCore.DataAccess.Models.SubFeature", b =>
                {
                    b.HasOne("AspDotNetCore.DataAccess.Models.Feature", "Feature")
                        .WithMany("SubFeatures")
                        .HasForeignKey("FeatureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Feature");
                });

            modelBuilder.Entity("AspDotNetCore.DataAccess.Models.Employee", b =>
                {
                    b.Navigation("EmployeeDetails");
                });

            modelBuilder.Entity("AspDotNetCore.DataAccess.Models.Feature", b =>
                {
                    b.Navigation("SubFeatures");
                });

            modelBuilder.Entity("AspDotNetCore.DataAccess.Models.Module", b =>
                {
                    b.Navigation("Features");
                });
#pragma warning restore 612, 618
        }
    }
}
