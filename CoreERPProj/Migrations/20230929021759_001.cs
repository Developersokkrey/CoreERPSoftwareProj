using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoreERPProj.Migrations
{
    /// <inheritdoc />
    public partial class _001 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "COMPAN",
                columns: table => new
                {
                    CompID = table.Column<decimal>(type: "decimal(20,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SCID = table.Column<decimal>(type: "decimal(20,0)", nullable: false),
                    LCID = table.Column<decimal>(type: "decimal(20,0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COMPAN", x => x.CompID);
                });

            migrationBuilder.CreateTable(
                name: "CUREER",
                columns: table => new
                {
                    CurrID = table.Column<decimal>(type: "decimal(20,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Symbol = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CUREER", x => x.CurrID);
                });

            migrationBuilder.CreateTable(
                name: "FUNCTI",
                columns: table => new
                {
                    FunctID = table.Column<decimal>(type: "decimal(20,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FUNCTI", x => x.FunctID);
                });

            migrationBuilder.CreateTable(
                name: "BRANCH",
                columns: table => new
                {
                    BranchID = table.Column<decimal>(type: "decimal(20,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompID = table.Column<decimal>(type: "decimal(20,0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BRANCH", x => x.BranchID);
                    table.ForeignKey(
                        name: "FK_BRANCH_COMPAN_CompID",
                        column: x => x.CompID,
                        principalTable: "COMPAN",
                        principalColumn: "CompID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CUSMER",
                columns: table => new
                {
                    CustomerID = table.Column<decimal>(type: "decimal(20,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompID = table.Column<decimal>(type: "decimal(20,0)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CUSMER", x => x.CustomerID);
                    table.ForeignKey(
                        name: "FK_CUSMER_COMPAN_CompID",
                        column: x => x.CompID,
                        principalTable: "COMPAN",
                        principalColumn: "CompID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DEPMENT",
                columns: table => new
                {
                    DeparmentID = table.Column<decimal>(type: "decimal(20,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompID = table.Column<decimal>(type: "decimal(20,0)", nullable: false),
                    Enable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DEPMENT", x => x.DeparmentID);
                    table.ForeignKey(
                        name: "FK_DEPMENT_COMPAN_CompID",
                        column: x => x.CompID,
                        principalTable: "COMPAN",
                        principalColumn: "CompID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MARULE",
                columns: table => new
                {
                    RuleID = table.Column<decimal>(type: "decimal(20,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Enable = table.Column<bool>(type: "bit", nullable: false),
                    CompID = table.Column<decimal>(type: "decimal(20,0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MARULE", x => x.RuleID);
                    table.ForeignKey(
                        name: "FK_MARULE_COMPAN_CompID",
                        column: x => x.CompID,
                        principalTable: "COMPAN",
                        principalColumn: "CompID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VENDOR",
                columns: table => new
                {
                    VendorID = table.Column<decimal>(type: "decimal(20,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompID = table.Column<decimal>(type: "decimal(20,0)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VENDOR", x => x.VendorID);
                    table.ForeignKey(
                        name: "FK_VENDOR_COMPAN_CompID",
                        column: x => x.CompID,
                        principalTable: "COMPAN",
                        principalColumn: "CompID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EXRATE",
                columns: table => new
                {
                    ExchaRateID = table.Column<decimal>(type: "decimal(20,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurrID = table.Column<decimal>(type: "decimal(20,0)", nullable: false),
                    Rate1 = table.Column<decimal>(type: "decimal(25,12)", nullable: false),
                    Rate2 = table.Column<decimal>(type: "decimal(25,12)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EXRATE", x => x.ExchaRateID);
                    table.ForeignKey(
                        name: "FK_EXRATE_CUREER_CurrID",
                        column: x => x.CurrID,
                        principalTable: "CUREER",
                        principalColumn: "CurrID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BINFOR",
                columns: table => new
                {
                    BranInforID = table.Column<decimal>(type: "decimal(20,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchID = table.Column<decimal>(type: "decimal(20,0)", nullable: false),
                    PhoneNumber1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BINFOR", x => x.BranInforID);
                    table.ForeignKey(
                        name: "FK_BINFOR_BRANCH_BranchID",
                        column: x => x.BranchID,
                        principalTable: "BRANCH",
                        principalColumn: "BranchID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RUPRIV",
                columns: table => new
                {
                    RulePrivID = table.Column<decimal>(type: "decimal(20,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RuleID = table.Column<decimal>(type: "decimal(20,0)", nullable: false),
                    FunctID = table.Column<decimal>(type: "decimal(20,0)", nullable: false),
                    Enable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RUPRIV", x => x.RulePrivID);
                    table.ForeignKey(
                        name: "FK_RUPRIV_FUNCTI_FunctID",
                        column: x => x.FunctID,
                        principalTable: "FUNCTI",
                        principalColumn: "FunctID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RUPRIV_MARULE_RuleID",
                        column: x => x.RuleID,
                        principalTable: "MARULE",
                        principalColumn: "RuleID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UERACC",
                columns: table => new
                {
                    UserAccountID = table.Column<decimal>(type: "decimal(20,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RuleID = table.Column<decimal>(type: "decimal(20,0)", nullable: false),
                    CompID = table.Column<decimal>(type: "decimal(20,0)", nullable: false),
                    BranchID = table.Column<decimal>(type: "decimal(20,0)", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    DepartmentID = table.Column<decimal>(type: "decimal(20,0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UERACC", x => x.UserAccountID);
                    table.ForeignKey(
                        name: "FK_UERACC_BRANCH_BranchID",
                        column: x => x.BranchID,
                        principalTable: "BRANCH",
                        principalColumn: "BranchID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UERACC_COMPAN_CompID",
                        column: x => x.CompID,
                        principalTable: "COMPAN",
                        principalColumn: "CompID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UERACC_DEPMENT_DepartmentID",
                        column: x => x.DepartmentID,
                        principalTable: "DEPMENT",
                        principalColumn: "DeparmentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UERACC_MARULE_RuleID",
                        column: x => x.RuleID,
                        principalTable: "MARULE",
                        principalColumn: "RuleID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UPRIVI",
                columns: table => new
                {
                    PrivilegeID = table.Column<decimal>(type: "decimal(20,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserAccountID = table.Column<decimal>(type: "decimal(20,0)", nullable: false),
                    RulePrivID = table.Column<decimal>(type: "decimal(20,0)", nullable: false),
                    FunctID = table.Column<decimal>(type: "decimal(20,0)", nullable: false),
                    DepartmentID = table.Column<decimal>(type: "decimal(20,0)", nullable: false),
                    Enable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UPRIVI", x => x.PrivilegeID);
                    table.ForeignKey(
                        name: "FK_UPRIVI_DEPMENT_DepartmentID",
                        column: x => x.DepartmentID,
                        principalTable: "DEPMENT",
                        principalColumn: "DeparmentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UPRIVI_FUNCTI_FunctID",
                        column: x => x.FunctID,
                        principalTable: "FUNCTI",
                        principalColumn: "FunctID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UPRIVI_RUPRIV_RulePrivID",
                        column: x => x.RulePrivID,
                        principalTable: "RUPRIV",
                        principalColumn: "RulePrivID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UPRIVI_UERACC_UserAccountID",
                        column: x => x.UserAccountID,
                        principalTable: "UERACC",
                        principalColumn: "UserAccountID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BINFOR_BranchID",
                table: "BINFOR",
                column: "BranchID");

            migrationBuilder.CreateIndex(
                name: "IX_BRANCH_CompID",
                table: "BRANCH",
                column: "CompID");

            migrationBuilder.CreateIndex(
                name: "IX_CUSMER_CompID",
                table: "CUSMER",
                column: "CompID");

            migrationBuilder.CreateIndex(
                name: "IX_DEPMENT_CompID",
                table: "DEPMENT",
                column: "CompID");

            migrationBuilder.CreateIndex(
                name: "IX_EXRATE_CurrID",
                table: "EXRATE",
                column: "CurrID");

            migrationBuilder.CreateIndex(
                name: "IX_MARULE_CompID",
                table: "MARULE",
                column: "CompID");

            migrationBuilder.CreateIndex(
                name: "IX_RUPRIV_FunctID",
                table: "RUPRIV",
                column: "FunctID");

            migrationBuilder.CreateIndex(
                name: "IX_RUPRIV_RuleID",
                table: "RUPRIV",
                column: "RuleID");

            migrationBuilder.CreateIndex(
                name: "IX_UERACC_BranchID",
                table: "UERACC",
                column: "BranchID");

            migrationBuilder.CreateIndex(
                name: "IX_UERACC_CompID",
                table: "UERACC",
                column: "CompID");

            migrationBuilder.CreateIndex(
                name: "IX_UERACC_DepartmentID",
                table: "UERACC",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_UERACC_RuleID",
                table: "UERACC",
                column: "RuleID");

            migrationBuilder.CreateIndex(
                name: "IX_UPRIVI_DepartmentID",
                table: "UPRIVI",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_UPRIVI_FunctID",
                table: "UPRIVI",
                column: "FunctID");

            migrationBuilder.CreateIndex(
                name: "IX_UPRIVI_RulePrivID",
                table: "UPRIVI",
                column: "RulePrivID");

            migrationBuilder.CreateIndex(
                name: "IX_UPRIVI_UserAccountID",
                table: "UPRIVI",
                column: "UserAccountID");

            migrationBuilder.CreateIndex(
                name: "IX_VENDOR_CompID",
                table: "VENDOR",
                column: "CompID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BINFOR");

            migrationBuilder.DropTable(
                name: "CUSMER");

            migrationBuilder.DropTable(
                name: "EXRATE");

            migrationBuilder.DropTable(
                name: "UPRIVI");

            migrationBuilder.DropTable(
                name: "VENDOR");

            migrationBuilder.DropTable(
                name: "CUREER");

            migrationBuilder.DropTable(
                name: "RUPRIV");

            migrationBuilder.DropTable(
                name: "UERACC");

            migrationBuilder.DropTable(
                name: "FUNCTI");

            migrationBuilder.DropTable(
                name: "BRANCH");

            migrationBuilder.DropTable(
                name: "DEPMENT");

            migrationBuilder.DropTable(
                name: "MARULE");

            migrationBuilder.DropTable(
                name: "COMPAN");
        }
    }
}
