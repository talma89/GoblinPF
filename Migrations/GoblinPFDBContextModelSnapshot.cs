﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using GoblinPF.Entities;

namespace GoblinPF.Migrations
{
    [DbContext(typeof(GoblinPFDBContext))]
    partial class GoblinPFDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752");

            modelBuilder.Entity("GoblinPF.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("GoblinPF.Entities.Transaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("BuySell");

                    b.Property<int?>("CategoryId");

                    b.Property<double>("Cost");

                    b.Property<DateTime>("TimeStamp");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Transaction");
                });

            modelBuilder.Entity("GoblinPF.Entities.Transaction", b =>
                {
                    b.HasOne("GoblinPF.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");
                });
        }
    }
}
