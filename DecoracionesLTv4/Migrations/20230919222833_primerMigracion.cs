using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DecoracionesLTv4.Migrations
{
    /// <inheritdoc />
    public partial class primerMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            //migrationBuilder.CreateTable(
            //    name: "categorias",
            //    columns: table => new
            //    {
            //        id_categoria = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        nombre = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
            //        descripcion = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
            //        estado = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
            //        fechaRegistro = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_id", x => x.id_categoria);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "cliente",
            //    columns: table => new
            //    {
            //        idCliente = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        tipo = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
            //        nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        cedula = table.Column<int>(type: "int", nullable: false),
            //        telefono = table.Column<int>(type: "int", nullable: true),
            //        direccion = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
            //        fechaRegistro = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_cliente", x => x.idCliente);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ingredientes",
            //    columns: table => new
            //    {
            //        id_ingrediente = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        nombre = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
            //        descripcion = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
            //        estado = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
            //        precio = table.Column<double>(type: "float", nullable: false),
            //        fechaRegistro = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ingredient", x => x.id_ingrediente);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "producto",
            //    columns: table => new
            //    {
            //        idProducto = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        nombre = table.Column<string>(type: "varchar(80)", unicode: false, maxLength: 80, nullable: false),
            //        descripcion = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
            //        precio = table.Column<float>(type: "real", nullable: false),
            //        estado = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
            //        fechaRegistro = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_productos", x => x.idProducto);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "servicio",
            //    columns: table => new
            //    {
            //        idServicio = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        nombre = table.Column<string>(type: "varchar(80)", unicode: false, maxLength: 80, nullable: false),
            //        descripcion = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
            //        precio = table.Column<float>(type: "real", nullable: false),
            //        estado = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
            //        fechaRegistro = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_servicios", x => x.idServicio);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ventas",
            //    columns: table => new
            //    {
            //        id_venta = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        fechaCreacion = table.Column<DateTime>(type: "date", nullable: true, defaultValueSql: "(getdate())"),
            //        nombre = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        precio = table.Column<float>(type: "real", nullable: false),
            //        fechaRegistro = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_venta", x => x.id_venta);
            //    });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            //migrationBuilder.DropTable(
            //    name: "categorias");

            //migrationBuilder.DropTable(
            //    name: "cliente");

            //migrationBuilder.DropTable(
            //    name: "ingredientes");

            //migrationBuilder.DropTable(
            //    name: "producto");

            //migrationBuilder.DropTable(
            //    name: "servicio");

            //migrationBuilder.DropTable(
            //    name: "ventas");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
