using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Maze.Database.Migrations
{
    /// <inheritdoc />
    public partial class Maze : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Timezone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Days",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Days", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Externals",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tvrage = table.Column<int>(type: "int", nullable: true),
                    Thetvdb = table.Column<int>(type: "int", nullable: true),
                    Imdb = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Externals", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Types",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Types", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Networks",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    CountryID = table.Column<int>(type: "int", nullable: true),
                    OfficialSite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Networks", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Networks_Countries_CountryID",
                        column: x => x.CountryID,
                        principalTable: "Countries",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Shows",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeID = table.Column<int>(type: "int", nullable: true),
                    LanguageID = table.Column<int>(type: "int", nullable: true),
                    StatusID = table.Column<int>(type: "int", nullable: true),
                    Runtime = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AverageRuntime = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Premiered = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Ended = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OfficialSite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ScheduleTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RatingAverage = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Weight = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NetworkID = table.Column<int>(type: "int", nullable: true),
                    ExternalID = table.Column<int>(type: "int", nullable: true),
                    ImageMedium = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageOriginal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Summary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Updated = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    LinkSelf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LinkPreviousEpisode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LinkPreviousEpisodeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shows", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Shows_Externals_ExternalID",
                        column: x => x.ExternalID,
                        principalTable: "Externals",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Shows_Languages_LanguageID",
                        column: x => x.LanguageID,
                        principalTable: "Languages",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Shows_Networks_NetworkID",
                        column: x => x.NetworkID,
                        principalTable: "Networks",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Shows_Statuses_StatusID",
                        column: x => x.StatusID,
                        principalTable: "Statuses",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Shows_Types_TypeID",
                        column: x => x.TypeID,
                        principalTable: "Types",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "DayShow",
                columns: table => new
                {
                    DaysID = table.Column<int>(type: "int", nullable: false),
                    ShowsID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DayShow", x => new { x.DaysID, x.ShowsID });
                    table.ForeignKey(
                        name: "FK_DayShow_Days_DaysID",
                        column: x => x.DaysID,
                        principalTable: "Days",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DayShow_Shows_ShowsID",
                        column: x => x.ShowsID,
                        principalTable: "Shows",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GenreShow",
                columns: table => new
                {
                    GenresID = table.Column<int>(type: "int", nullable: false),
                    ShowsID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenreShow", x => new { x.GenresID, x.ShowsID });
                    table.ForeignKey(
                        name: "FK_GenreShow_Genres_GenresID",
                        column: x => x.GenresID,
                        principalTable: "Genres",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GenreShow_Shows_ShowsID",
                        column: x => x.ShowsID,
                        principalTable: "Shows",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DayShow_ShowsID",
                table: "DayShow",
                column: "ShowsID");

            migrationBuilder.CreateIndex(
                name: "IX_GenreShow_ShowsID",
                table: "GenreShow",
                column: "ShowsID");

            migrationBuilder.CreateIndex(
                name: "IX_Networks_CountryID",
                table: "Networks",
                column: "CountryID");

            migrationBuilder.CreateIndex(
                name: "IX_Shows_ExternalID",
                table: "Shows",
                column: "ExternalID");

            migrationBuilder.CreateIndex(
                name: "IX_Shows_LanguageID",
                table: "Shows",
                column: "LanguageID");

            migrationBuilder.CreateIndex(
                name: "IX_Shows_NetworkID",
                table: "Shows",
                column: "NetworkID");

            migrationBuilder.CreateIndex(
                name: "IX_Shows_StatusID",
                table: "Shows",
                column: "StatusID");

            migrationBuilder.CreateIndex(
                name: "IX_Shows_TypeID",
                table: "Shows",
                column: "TypeID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DayShow");

            migrationBuilder.DropTable(
                name: "GenreShow");

            migrationBuilder.DropTable(
                name: "Days");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Shows");

            migrationBuilder.DropTable(
                name: "Externals");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "Networks");

            migrationBuilder.DropTable(
                name: "Statuses");

            migrationBuilder.DropTable(
                name: "Types");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
