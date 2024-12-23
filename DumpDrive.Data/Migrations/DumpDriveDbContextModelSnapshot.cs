﻿// <auto-generated />
using System;
using DumpDrive.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DumpDrive.Data.Migrations
{
    [DbContext(typeof(DumpDriveDbContext))]
    partial class DumpDriveDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("DumpDrive.Data.Entities.Models.AuditLog", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("ChangeType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("ChangedByUserId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("FileId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("ChangedByUserId");

                    b.HasIndex("FileId");

                    b.ToTable("AuditLogs");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f378597b-ac59-4f9e-ac19-5b25d816e1d7"),
                            ChangeType = "Created",
                            ChangedByUserId = new Guid("d7cd27c9-3228-4a36-9b9e-f6d49d7004f2"),
                            FileId = new Guid("a9576931-4a7d-4e1a-bfe5-04f37183a465"),
                            Timestamp = new DateTime(2024, 12, 23, 18, 34, 32, 444, DateTimeKind.Local).AddTicks(5611)
                        },
                        new
                        {
                            Id = new Guid("574219fe-499a-459f-9106-59df36fbaccd"),
                            ChangeType = "Created",
                            ChangedByUserId = new Guid("2cc482bc-2e1e-404e-b718-46161bd84fdc"),
                            FileId = new Guid("835acc43-8f26-4bd5-8605-c9da64022464"),
                            Timestamp = new DateTime(2024, 12, 23, 18, 34, 32, 444, DateTimeKind.Local).AddTicks(5635)
                        },
                        new
                        {
                            Id = new Guid("9e8e2376-89ee-4276-8ecb-aed6e0dece26"),
                            ChangeType = "Updated",
                            ChangedByUserId = new Guid("c5465eac-27d8-405e-8e8a-eaced647b477"),
                            FileId = new Guid("f3380411-ae38-447f-9d0a-35374171e7bb"),
                            Timestamp = new DateTime(2024, 12, 23, 18, 34, 32, 444, DateTimeKind.Local).AddTicks(5640)
                        },
                        new
                        {
                            Id = new Guid("43ffc831-34b2-4496-8308-f498d931a96c"),
                            ChangeType = "Created",
                            ChangedByUserId = new Guid("35d921a2-a2f4-48ff-8c42-e97bb6029b28"),
                            FileId = new Guid("0e9c0b20-41a1-4a8c-ad82-e6fb432d3e96"),
                            Timestamp = new DateTime(2024, 12, 23, 18, 34, 32, 444, DateTimeKind.Local).AddTicks(5650)
                        },
                        new
                        {
                            Id = new Guid("11c5b120-ef31-4994-80f7-7ad6a569e5e0"),
                            ChangeType = "Created",
                            ChangedByUserId = new Guid("2cc482bc-2e1e-404e-b718-46161bd84fdc"),
                            FileId = new Guid("52631aa8-0ddd-46da-b460-e228813095bc"),
                            Timestamp = new DateTime(2024, 12, 23, 18, 34, 32, 444, DateTimeKind.Local).AddTicks(5654)
                        },
                        new
                        {
                            Id = new Guid("13f82380-aa4c-4736-b698-daa5b2f9193b"),
                            ChangeType = "Updated",
                            ChangedByUserId = new Guid("c5465eac-27d8-405e-8e8a-eaced647b477"),
                            FileId = new Guid("76db8152-f3ea-4ed1-837d-71eeeb88b3c7"),
                            Timestamp = new DateTime(2024, 12, 23, 18, 34, 32, 444, DateTimeKind.Local).AddTicks(5677)
                        },
                        new
                        {
                            Id = new Guid("fc257c37-5399-4750-832d-3827748eed6e"),
                            ChangeType = "Created",
                            ChangedByUserId = new Guid("d7cd27c9-3228-4a36-9b9e-f6d49d7004f2"),
                            FileId = new Guid("5d59be09-3a25-4ada-8356-08e190ef1370"),
                            Timestamp = new DateTime(2024, 12, 23, 18, 34, 32, 444, DateTimeKind.Local).AddTicks(5681)
                        },
                        new
                        {
                            Id = new Guid("2be5eb5b-5b31-4405-a278-8c0bc3057f57"),
                            ChangeType = "Created",
                            ChangedByUserId = new Guid("c5465eac-27d8-405e-8e8a-eaced647b477"),
                            FileId = new Guid("615e4d6b-f6f5-4074-a1e3-3417039ef5ae"),
                            Timestamp = new DateTime(2024, 12, 23, 18, 34, 32, 444, DateTimeKind.Local).AddTicks(5687)
                        },
                        new
                        {
                            Id = new Guid("ad6785af-ee8a-4c0d-8475-0593c4ff5115"),
                            ChangeType = "Updated",
                            ChangedByUserId = new Guid("35d921a2-a2f4-48ff-8c42-e97bb6029b28"),
                            FileId = new Guid("23735773-88be-4f1a-bcb9-fefd2746aff5"),
                            Timestamp = new DateTime(2024, 12, 23, 18, 34, 32, 444, DateTimeKind.Local).AddTicks(5691)
                        });
                });

            modelBuilder.Entity("DumpDrive.Data.Entities.Models.Comment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("FileId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("FileId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            Id = new Guid("52832096-ce06-49d6-904a-4acb73e010d8"),
                            Content = "Great resume!",
                            CreatedAt = new DateTime(2024, 12, 23, 18, 34, 32, 444, DateTimeKind.Local).AddTicks(3491),
                            FileId = new Guid("a9576931-4a7d-4e1a-bfe5-04f37183a465"),
                            UserId = new Guid("d7cd27c9-3228-4a36-9b9e-f6d49d7004f2")
                        },
                        new
                        {
                            Id = new Guid("8bbf5526-f7e2-4fa7-b770-ce5c748e00a6"),
                            Content = "Lovely picture!",
                            CreatedAt = new DateTime(2024, 12, 23, 18, 34, 32, 444, DateTimeKind.Local).AddTicks(3515),
                            FileId = new Guid("835acc43-8f26-4bd5-8605-c9da64022464"),
                            UserId = new Guid("2cc482bc-2e1e-404e-b718-46161bd84fdc")
                        },
                        new
                        {
                            Id = new Guid("2446ceb9-81d1-464d-91b6-022feeb22606"),
                            Content = "Nice music!",
                            CreatedAt = new DateTime(2024, 12, 23, 18, 34, 32, 444, DateTimeKind.Local).AddTicks(3520),
                            FileId = new Guid("f3380411-ae38-447f-9d0a-35374171e7bb"),
                            UserId = new Guid("c5465eac-27d8-405e-8e8a-eaced647b477")
                        },
                        new
                        {
                            Id = new Guid("bac32300-4c43-4981-9ad7-cf48c62ff52a"),
                            Content = "Cool video!",
                            CreatedAt = new DateTime(2024, 12, 23, 18, 34, 32, 444, DateTimeKind.Local).AddTicks(3525),
                            FileId = new Guid("0e9c0b20-41a1-4a8c-ad82-e6fb432d3e96"),
                            UserId = new Guid("35d921a2-a2f4-48ff-8c42-e97bb6029b28")
                        },
                        new
                        {
                            Id = new Guid("204af48d-348d-4849-8793-a24971b0cded"),
                            Content = "This resume could be better.",
                            CreatedAt = new DateTime(2024, 12, 23, 18, 34, 32, 444, DateTimeKind.Local).AddTicks(3533),
                            FileId = new Guid("a9576931-4a7d-4e1a-bfe5-04f37183a465"),
                            UserId = new Guid("35d921a2-a2f4-48ff-8c42-e97bb6029b28")
                        },
                        new
                        {
                            Id = new Guid("e8ee2d2f-5d35-44ea-83c2-7963b04a79db"),
                            Content = "Beautiful image!",
                            CreatedAt = new DateTime(2024, 12, 23, 18, 34, 32, 444, DateTimeKind.Local).AddTicks(3540),
                            FileId = new Guid("835acc43-8f26-4bd5-8605-c9da64022464"),
                            UserId = new Guid("c5465eac-27d8-405e-8e8a-eaced647b477")
                        },
                        new
                        {
                            Id = new Guid("b9bfb166-d6b1-4017-b304-30d4c272c506"),
                            Content = "I dont like this song!",
                            CreatedAt = new DateTime(2024, 12, 23, 18, 34, 32, 444, DateTimeKind.Local).AddTicks(3544),
                            FileId = new Guid("f3380411-ae38-447f-9d0a-35374171e7bb"),
                            UserId = new Guid("c5465eac-27d8-405e-8e8a-eaced647b477")
                        },
                        new
                        {
                            Id = new Guid("c52b6f4a-88ee-4974-81c1-d2d9958ba44f"),
                            Content = "Amazing video!",
                            CreatedAt = new DateTime(2024, 12, 23, 18, 34, 32, 444, DateTimeKind.Local).AddTicks(3548),
                            FileId = new Guid("0e9c0b20-41a1-4a8c-ad82-e6fb432d3e96"),
                            UserId = new Guid("2cc482bc-2e1e-404e-b718-46161bd84fdc")
                        },
                        new
                        {
                            Id = new Guid("aa55974c-af19-455a-b3b8-163706f5a907"),
                            Content = "Excellent project plan!",
                            CreatedAt = new DateTime(2024, 12, 23, 18, 34, 32, 444, DateTimeKind.Local).AddTicks(3554),
                            FileId = new Guid("52631aa8-0ddd-46da-b460-e228813095bc"),
                            UserId = new Guid("2cc482bc-2e1e-404e-b718-46161bd84fdc")
                        },
                        new
                        {
                            Id = new Guid("77a50885-fe18-4e46-b93c-d028b542a377"),
                            Content = "Great presentation!",
                            CreatedAt = new DateTime(2024, 12, 23, 18, 34, 32, 444, DateTimeKind.Local).AddTicks(3560),
                            FileId = new Guid("76db8152-f3ea-4ed1-837d-71eeeb88b3c7"),
                            UserId = new Guid("35d921a2-a2f4-48ff-8c42-e97bb6029b28")
                        },
                        new
                        {
                            Id = new Guid("7158c0a1-27ea-4682-8b9e-91933101aca1"),
                            Content = "Very detailed report!",
                            CreatedAt = new DateTime(2024, 12, 23, 18, 34, 32, 444, DateTimeKind.Local).AddTicks(3564),
                            FileId = new Guid("5d59be09-3a25-4ada-8356-08e190ef1370"),
                            UserId = new Guid("d7cd27c9-3228-4a36-9b9e-f6d49d7004f2")
                        },
                        new
                        {
                            Id = new Guid("343e9b97-ca4f-4bc6-b8b0-ca607d51449f"),
                            Content = "Important archive data.",
                            CreatedAt = new DateTime(2024, 12, 23, 18, 34, 32, 444, DateTimeKind.Local).AddTicks(3568),
                            FileId = new Guid("615e4d6b-f6f5-4074-a1e3-3417039ef5ae"),
                            UserId = new Guid("2cc482bc-2e1e-404e-b718-46161bd84fdc")
                        },
                        new
                        {
                            Id = new Guid("ff0191ec-51cd-4540-ab65-6e4beb2a8bb8"),
                            Content = "Data needs cleanup.",
                            CreatedAt = new DateTime(2024, 12, 23, 18, 34, 32, 444, DateTimeKind.Local).AddTicks(3574),
                            FileId = new Guid("23735773-88be-4f1a-bcb9-fefd2746aff5"),
                            UserId = new Guid("d7cd27c9-3228-4a36-9b9e-f6d49d7004f2")
                        });
                });

            modelBuilder.Entity("DumpDrive.Data.Entities.Models.DumpFile", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("FolderId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("LastChanged")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("FolderId");

                    b.ToTable("Files");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a9576931-4a7d-4e1a-bfe5-04f37183a465"),
                            FolderId = new Guid("cbdef7a9-1287-4c83-bdf7-ceb5fa1858e6"),
                            LastChanged = new DateTime(2024, 12, 23, 18, 34, 32, 441, DateTimeKind.Local).AddTicks(5186),
                            Name = "resume.pdf",
                            Status = 0
                        },
                        new
                        {
                            Id = new Guid("835acc43-8f26-4bd5-8605-c9da64022464"),
                            FolderId = new Guid("d05857a5-0949-4d5b-aa4e-812d95796107"),
                            LastChanged = new DateTime(2024, 12, 23, 18, 34, 32, 444, DateTimeKind.Local).AddTicks(977),
                            Name = "holiday.jpg",
                            Status = 1
                        },
                        new
                        {
                            Id = new Guid("f3380411-ae38-447f-9d0a-35374171e7bb"),
                            FolderId = new Guid("96a50c96-d8a5-489e-ba48-d8752937a29a"),
                            LastChanged = new DateTime(2024, 12, 23, 18, 34, 32, 444, DateTimeKind.Local).AddTicks(1005),
                            Name = "song.mp3",
                            Status = 0
                        },
                        new
                        {
                            Id = new Guid("0e9c0b20-41a1-4a8c-ad82-e6fb432d3e96"),
                            FolderId = new Guid("9f57fee3-0281-4964-9957-6e1e3f6fd585"),
                            LastChanged = new DateTime(2024, 12, 23, 18, 34, 32, 444, DateTimeKind.Local).AddTicks(1010),
                            Name = "movie.mp4",
                            Status = 1
                        },
                        new
                        {
                            Id = new Guid("52631aa8-0ddd-46da-b460-e228813095bc"),
                            FolderId = new Guid("35e17ffe-f17f-4daf-9959-28fd59225c6c"),
                            LastChanged = new DateTime(2024, 12, 23, 18, 34, 32, 444, DateTimeKind.Local).AddTicks(1012),
                            Name = "project_plan.docx",
                            Status = 0
                        },
                        new
                        {
                            Id = new Guid("76db8152-f3ea-4ed1-837d-71eeeb88b3c7"),
                            FolderId = new Guid("35e17ffe-f17f-4daf-9959-28fd59225c6c"),
                            LastChanged = new DateTime(2024, 12, 23, 18, 34, 32, 444, DateTimeKind.Local).AddTicks(1022),
                            Name = "presentation.pptx",
                            Status = 1
                        },
                        new
                        {
                            Id = new Guid("5d59be09-3a25-4ada-8356-08e190ef1370"),
                            FolderId = new Guid("876ac257-805f-42fe-bf9d-6bdc61513790"),
                            LastChanged = new DateTime(2024, 12, 23, 18, 34, 32, 444, DateTimeKind.Local).AddTicks(1025),
                            Name = "report.pdf",
                            Status = 0
                        },
                        new
                        {
                            Id = new Guid("615e4d6b-f6f5-4074-a1e3-3417039ef5ae"),
                            FolderId = new Guid("fb493f64-8f9e-423f-8609-5398ffea0e24"),
                            LastChanged = new DateTime(2024, 12, 23, 18, 34, 32, 444, DateTimeKind.Local).AddTicks(1028),
                            Name = "archive.zip",
                            Status = 1
                        },
                        new
                        {
                            Id = new Guid("23735773-88be-4f1a-bcb9-fefd2746aff5"),
                            FolderId = new Guid("fb493f64-8f9e-423f-8609-5398ffea0e24"),
                            LastChanged = new DateTime(2024, 12, 23, 18, 34, 32, 444, DateTimeKind.Local).AddTicks(1031),
                            Name = "data.csv",
                            Status = 0
                        });
                });

            modelBuilder.Entity("DumpDrive.Data.Entities.Models.Folder", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("OwnerId")
                        .HasColumnType("uuid");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Folders");

                    b.HasData(
                        new
                        {
                            Id = new Guid("cbdef7a9-1287-4c83-bdf7-ceb5fa1858e6"),
                            Name = "Documents",
                            OwnerId = new Guid("d7cd27c9-3228-4a36-9b9e-f6d49d7004f2"),
                            Status = 0
                        },
                        new
                        {
                            Id = new Guid("d05857a5-0949-4d5b-aa4e-812d95796107"),
                            Name = "Photos",
                            OwnerId = new Guid("2cc482bc-2e1e-404e-b718-46161bd84fdc"),
                            Status = 1
                        },
                        new
                        {
                            Id = new Guid("96a50c96-d8a5-489e-ba48-d8752937a29a"),
                            Name = "Music",
                            OwnerId = new Guid("c5465eac-27d8-405e-8e8a-eaced647b477"),
                            Status = 0
                        },
                        new
                        {
                            Id = new Guid("9f57fee3-0281-4964-9957-6e1e3f6fd585"),
                            Name = "Videos",
                            OwnerId = new Guid("35d921a2-a2f4-48ff-8c42-e97bb6029b28"),
                            Status = 1
                        },
                        new
                        {
                            Id = new Guid("35e17ffe-f17f-4daf-9959-28fd59225c6c"),
                            Name = "Projects",
                            OwnerId = new Guid("c5465eac-27d8-405e-8e8a-eaced647b477"),
                            Status = 0
                        },
                        new
                        {
                            Id = new Guid("876ac257-805f-42fe-bf9d-6bdc61513790"),
                            Name = "Downloads",
                            OwnerId = new Guid("2cc482bc-2e1e-404e-b718-46161bd84fdc"),
                            Status = 1
                        },
                        new
                        {
                            Id = new Guid("fb493f64-8f9e-423f-8609-5398ffea0e24"),
                            Name = "Archives",
                            OwnerId = new Guid("d7cd27c9-3228-4a36-9b9e-f6d49d7004f2"),
                            Status = 0
                        });
                });

            modelBuilder.Entity("DumpDrive.Data.Entities.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d7cd27c9-3228-4a36-9b9e-f6d49d7004f2"),
                            Email = "ivona@gmail.com",
                            Password = "password123",
                            Username = "ivona"
                        },
                        new
                        {
                            Id = new Guid("2cc482bc-2e1e-404e-b718-46161bd84fdc"),
                            Email = "jure@gmail.com",
                            Password = "password456",
                            Username = "jure"
                        },
                        new
                        {
                            Id = new Guid("c5465eac-27d8-405e-8e8a-eaced647b477"),
                            Email = "bruno@gmail.com",
                            Password = "pass9",
                            Username = "bruno"
                        },
                        new
                        {
                            Id = new Guid("35d921a2-a2f4-48ff-8c42-e97bb6029b28"),
                            Email = "ana@gmail.com",
                            Password = "pass7",
                            Username = "ana"
                        });
                });

            modelBuilder.Entity("DumpDrive.Data.Entities.Models.AuditLog", b =>
                {
                    b.HasOne("DumpDrive.Data.Entities.Models.User", "ChangedByUser")
                        .WithMany("AuditLogs")
                        .HasForeignKey("ChangedByUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DumpDrive.Data.Entities.Models.DumpFile", "File")
                        .WithMany("AuditLogs")
                        .HasForeignKey("FileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ChangedByUser");

                    b.Navigation("File");
                });

            modelBuilder.Entity("DumpDrive.Data.Entities.Models.Comment", b =>
                {
                    b.HasOne("DumpDrive.Data.Entities.Models.DumpFile", "File")
                        .WithMany("Comments")
                        .HasForeignKey("FileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DumpDrive.Data.Entities.Models.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("File");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DumpDrive.Data.Entities.Models.DumpFile", b =>
                {
                    b.HasOne("DumpDrive.Data.Entities.Models.Folder", "Folder")
                        .WithMany("Files")
                        .HasForeignKey("FolderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Folder");
                });

            modelBuilder.Entity("DumpDrive.Data.Entities.Models.Folder", b =>
                {
                    b.HasOne("DumpDrive.Data.Entities.Models.User", "Owner")
                        .WithMany("Folders")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("DumpDrive.Data.Entities.Models.DumpFile", b =>
                {
                    b.Navigation("AuditLogs");

                    b.Navigation("Comments");
                });

            modelBuilder.Entity("DumpDrive.Data.Entities.Models.Folder", b =>
                {
                    b.Navigation("Files");
                });

            modelBuilder.Entity("DumpDrive.Data.Entities.Models.User", b =>
                {
                    b.Navigation("AuditLogs");

                    b.Navigation("Comments");

                    b.Navigation("Folders");
                });
#pragma warning restore 612, 618
        }
    }
}
