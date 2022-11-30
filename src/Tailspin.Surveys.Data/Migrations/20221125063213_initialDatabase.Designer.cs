﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Tailspin.Surveys.Data.DataModels;

namespace Tailspin.Surveys.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221125063213_initialDatabase")]
    partial class initialDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Tailspin.Surveys.Data.DataModels.ContributorRequest", b =>
                {
                    b.Property<Guid>("TenantId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("uuid_generate_v4()");

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("SurveyId")
                        .HasColumnType("uuid");

                    b.HasKey("TenantId", "Id")
                        .HasName("ContributorRequests_pkey");

                    b.HasIndex("SurveyId", "TenantId");

                    b.ToTable("ContributorRequests");
                });

            modelBuilder.Entity("Tailspin.Surveys.Data.DataModels.Question", b =>
                {
                    b.Property<Guid>("TenantId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("uuid_generate_v4()");

                    b.Property<string>("PossibleAnswers")
                        .HasColumnType("text");

                    b.Property<Guid>("SurveyId")
                        .HasColumnType("uuid");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.HasKey("TenantId", "Id")
                        .HasName("Questions_pkey");

                    b.HasIndex("SurveyId", "TenantId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("Tailspin.Surveys.Data.DataModels.Survey", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("uuid_generate_v4()");

                    b.Property<Guid>("TenantId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("OwnerId")
                        .HasColumnType("uuid");

                    

                   

                    b.Property<bool>("Published")
                        .HasColumnType("boolean");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id", "TenantId")
                        .HasName("Surveys_pkey");

                    b.HasIndex("TenantId");

                   

                    b.ToTable("Surveys");
                });

            modelBuilder.Entity("Tailspin.Surveys.Data.DataModels.SurveyContributor", b =>
                {
                    b.Property<Guid>("SurveyId")
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("uuid_generate_v4()");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("TenantId")
                        .HasColumnType("uuid");

                    

                   

                    b.HasKey("SurveyId", "UserId", "TenantId")
                        .HasName("SurveyContributors_pkey");

                    b.HasIndex("TenantId");

                    b.HasIndex("SurveyId", "TenantId");


                    b.ToTable("SurveyContributors");
                });

            modelBuilder.Entity("Tailspin.Surveys.Data.DataModels.Tenant", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("uuid_generate_v4()");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("IssuerValue")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Tenants");
                });

            modelBuilder.Entity("Tailspin.Surveys.Data.DataModels.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("uuid_generate_v4()");

                    b.Property<Guid>("TenantId")
                        .HasColumnType("uuid");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("DisplayName")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("ObjectId")
                        .HasColumnType("text");

                    b.HasKey("Id", "TenantId")
                        .HasName("PK_User");

                    b.HasIndex("TenantId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Tailspin.Surveys.Data.DataModels.ContributorRequest", b =>
                {
                    b.HasOne("Tailspin.Surveys.Data.DataModels.Survey", "Survey")
                        .WithMany("ContributorRequests")
                        .HasForeignKey("SurveyId", "TenantId")
                        .HasConstraintName("FK_ContributorRequests_Surveys_SurveyId")
                        .IsRequired();

                    b.Navigation("Survey");
                });

            modelBuilder.Entity("Tailspin.Surveys.Data.DataModels.Question", b =>
                {
                    b.HasOne("Tailspin.Surveys.Data.DataModels.Survey", "Survey")
                        .WithMany("Questions")
                        .HasForeignKey("SurveyId", "TenantId")
                        .HasConstraintName("FK_Questions_SurveyId")
                        .IsRequired();

                    b.Navigation("Survey");
                });

            modelBuilder.Entity("Tailspin.Surveys.Data.DataModels.Survey", b =>
                {
                    b.HasOne("Tailspin.Surveys.Data.DataModels.Tenant", "Tenant")
                        .WithMany("Surveys")
                        .HasForeignKey("TenantId")
                        .HasConstraintName("FK_Surveys_tenant_tenantId")
                        .IsRequired();

                  

                    b.Navigation("Tenant");
                });

            modelBuilder.Entity("Tailspin.Surveys.Data.DataModels.SurveyContributor", b =>
                {
                    b.HasOne("Tailspin.Surveys.Data.DataModels.Tenant", "Tenant")
                        .WithMany()
                        .HasForeignKey("TenantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Tailspin.Surveys.Data.DataModels.Survey", "Survey")
                        .WithMany("SurveyContributors")
                        .HasForeignKey("SurveyId", "TenantId")
                        .HasConstraintName("FK_SurveyContributors_Surveys_SurveyId1")
                        .IsRequired();

                   

                    b.Navigation("Survey");

                    b.Navigation("Tenant");

                   
                });

            modelBuilder.Entity("Tailspin.Surveys.Data.DataModels.User", b =>
                {
                    b.HasOne("Tailspin.Surveys.Data.DataModels.Tenant", "Tenant")
                        .WithMany("Users")
                        .HasForeignKey("TenantId")
                        .HasConstraintName("FK_User_Tenant_TenantId")
                        .IsRequired();

                    b.Navigation("Tenant");
                });

            modelBuilder.Entity("Tailspin.Surveys.Data.DataModels.Survey", b =>
                {
                    b.Navigation("ContributorRequests");

                    b.Navigation("Questions");

                    b.Navigation("SurveyContributors");
                });

            modelBuilder.Entity("Tailspin.Surveys.Data.DataModels.Tenant", b =>
                {
                    b.Navigation("Surveys");

                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
