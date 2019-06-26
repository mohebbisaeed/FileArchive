    using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FileArchive.Repository.Migrations
{
    public partial class initdatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FileCustomProperties",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<int>(maxLength: 256, nullable: false),
                    FileCustomPropertyStatus = table.Column<int>(nullable: false),
                    Sorted = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileCustomProperties", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Files",
                columns: table => new
                {
                    //Id = table.Column<Guid>(nullable: false, defaultValueSql: "NEWSEQUENTIALID()"),
                    FileExtention = table.Column<string>(maxLength: 10, nullable: true),
                    //Body = table.Column<byte[]>(nullable: true)
                });
            //,
            //constraints: table =>
            //{
            //    table.PrimaryKey("PK_Files", x => x.Id);
            //});
//Manual add files table to filestream
            migrationBuilder.Sql(@"

                ALTER Table Files
                Add Id uniqueidentifier not null ROWGUIDCOL unique default NEWSEQUENTIALID()
                GO

                ALTER Table Files
                SET (filestream_on=FileArchive_FileGroup)
                GO

                USE FileArchive
                ALTER Table Files
                Add Body varbinary(max) FILESTREAM null
                GO
                ALTER TABLE Files
                ADD PRIMARY KEY (Id);
                ");

            migrationBuilder.CreateTable(
                name: "FileTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Title = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Folders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(maxLength: 256, nullable: true),
                    ParentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Folders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(maxLength: 50, nullable: true),
                    SettingKey = table.Column<string>(maxLength: 50, nullable: true),
                    Value = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ImageFiles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FileId = table.Column<Guid>(nullable: false),
                    Equip_Make = table.Column<string>(type: "varchar", maxLength: 50, nullable: true),
                    Y_ResolutionY = table.Column<string>(type: "varchar", maxLength: 20, nullable: true),
                    X_Resolution = table.Column<string>(type: "varchar", maxLength: 20, nullable: true),
                    User_Comment = table.Column<string>(maxLength: 50, nullable: true),
                    DTDigitized = table.Column<string>(type: "varchar", maxLength: 20, nullable: true),
                    Shutter_Speed = table.Column<string>(type: "varchar", maxLength: 20, nullable: true),
                    Flash = table.Column<string>(nullable: true),
                    Equip_Model = table.Column<string>(type: "varchar", maxLength: 50, nullable: true),
                    F_Number = table.Column<string>(type: "varchar", maxLength: 20, nullable: true),
                    Experture_Time = table.Column<string>(type: "varchar", maxLength: 20, nullable: true),
                    Sensing_Method = table.Column<string>(type: "varchar", maxLength: 50, nullable: true),
                    Width = table.Column<int>(nullable: false),
                    Height = table.Column<int>(nullable: false),
                    MapUrl = table.Column<string>(type: "varchar", maxLength: 100, nullable: true),
                    Latitude = table.Column<decimal>(type: "Decimal(9,6)", nullable: false),
                    Longitude = table.Column<decimal>(type: "Decimal(9,6)", nullable: false),
                    LatitudeGeoCode = table.Column<decimal>(type: "Decimal(15,10)", nullable: false),
                    LongitudeGeoCode = table.Column<decimal>(type: "Decimal(15,10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageFiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImageFiles_Files_FileId",
                        column: x => x.FileId,
                        principalTable: "Files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MediaFiles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FileId = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(maxLength: 256, nullable: true),
                    StartTime = table.Column<TimeSpan>(type: "time(7)", nullable: false),
                    EndTime = table.Column<TimeSpan>(type: "time(7)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MediaFiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MediaFiles_Files_FileId",
                        column: x => x.FileId,
                        principalTable: "Files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FileDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FileId = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    FolderId = table.Column<int>(nullable: false),
                    Title = table.Column<string>(maxLength: 256, nullable: true),
                    Keyword = table.Column<string>(maxLength: 256, nullable: true),
                    OrginalFileName = table.Column<string>(maxLength: 256, nullable: true),
                    ExtentionFile = table.Column<string>(maxLength: 10, nullable: true),
                    FileTypeId = table.Column<int>(nullable: false),
                    FileSize = table.Column<long>(nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "getdate()"),
                    IsPreviewFolder = table.Column<bool>(nullable: false),
                    RatingCount = table.Column<int>(nullable: false, defaultValue: 0),
                    Rating = table.Column<int>(nullable: false, defaultValueSql: "0"),
                    CustomProperty1 = table.Column<string>(maxLength: 256, nullable: true),
                    CustomProperty2 = table.Column<string>(maxLength: 256, nullable: true),
                    CustomProperty3 = table.Column<string>(maxLength: 256, nullable: true),
                    CustomProperty4 = table.Column<string>(maxLength: 256, nullable: true),
                    CustomProperty5 = table.Column<string>(maxLength: 256, nullable: true),
                    CustomProperty6 = table.Column<string>(maxLength: 256, nullable: true),
                    CustomProperty7 = table.Column<string>(maxLength: 256, nullable: true),
                    CustomProperty8 = table.Column<string>(maxLength: 256, nullable: true),
                    CustomProperty9 = table.Column<string>(maxLength: 256, nullable: true),
                    CustomProperty10 = table.Column<string>(maxLength: 256, nullable: true),
                    FileCustomPropertyStatusId1 = table.Column<int>(nullable: false),
                    FileCustomPropertyStatusId2 = table.Column<int>(nullable: false),
                    FileCustomPropertyStatusId3 = table.Column<int>(nullable: false),
                    FileCustomPropertyStatusId4 = table.Column<int>(nullable: false),
                    FileCustomPropertyStatusId5 = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FileDetails_Files_FileId",
                        column: x => x.FileId,
                        principalTable: "Files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FileDetails_FileTypes_FileTypeId",
                        column: x => x.FileTypeId,
                        principalTable: "FileTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FileDetails_Folders_FolderId",
                        column: x => x.FolderId,
                        principalTable: "Folders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FileDetails_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "FileTypes",
                columns: new[] { "Id", "Title" },
                values: new object[] { 1, "Image" });

            migrationBuilder.InsertData(
                table: "FileTypes",
                columns: new[] { "Id", "Title" },
                values: new object[] { 2, "Media" });

            migrationBuilder.InsertData(
                table: "FileTypes",
                columns: new[] { "Id", "Title" },
                values: new object[] { 3, "Other" });

            migrationBuilder.CreateIndex(
                name: "IX_FileDetails_FileId",
                table: "FileDetails",
                column: "FileId");

            migrationBuilder.CreateIndex(
                name: "IX_FileDetails_FileTypeId",
                table: "FileDetails",
                column: "FileTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_FileDetails_FolderId",
                table: "FileDetails",
                column: "FolderId");

            migrationBuilder.CreateIndex(
                name: "IX_FileDetails_UserId",
                table: "FileDetails",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ImageFiles_FileId",
                table: "ImageFiles",
                column: "FileId");

            migrationBuilder.CreateIndex(
                name: "IX_MediaFiles_FileId",
                table: "MediaFiles",
                column: "FileId");
//Manual add script 
           

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FileCustomProperties");

            migrationBuilder.DropTable(
                name: "FileDetails");

            migrationBuilder.DropTable(
                name: "ImageFiles");

            migrationBuilder.DropTable(
                name: "MediaFiles");

            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.DropTable(
                name: "FileTypes");

            migrationBuilder.DropTable(
                name: "Folders");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Files");
        }
    }
}
