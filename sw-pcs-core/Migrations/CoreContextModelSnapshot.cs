﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using sw_pcs_core;

namespace sw_pcs_core.Migrations
{
    [DbContext(typeof(CoreContext))]
    partial class CoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("sw_pcs_core.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("AccountId");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("Email");

                    b.Property<string>("Mobile");

                    b.Property<DateTime>("ModifiedOn");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("User");
                });
#pragma warning restore 612, 618
        }
    }
}
