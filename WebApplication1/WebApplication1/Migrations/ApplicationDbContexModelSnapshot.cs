﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using WebApplication1.Controllers;

namespace WebApplication1.Migrations
{
    [DbContext(typeof(ApplicationDbContex))]
    partial class ApplicationDbContexModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication1.Controllers.Members", b =>
                {
                    b.Property<int>("MEmberId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("MemberFamily");

                    b.Property<string>("MemberName");

                    b.Property<string>("Password");

                    b.Property<string>("UserName");

                    b.HasKey("MEmberId");

                    b.ToTable("Members");
                });
#pragma warning restore 612, 618
        }
    }
}
