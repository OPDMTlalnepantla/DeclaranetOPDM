﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PadronObligados2021.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EntidadesFederativas",
                columns: table => new
                {
                    EntidadFederativaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntidadesFederativas", x => x.EntidadFederativaId);
                });

            migrationBuilder.CreateTable(
                name: "FuncionesPrincipales",
                columns: table => new
                {
                    FuncionPrincipalId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FuncionesPrincipales", x => x.FuncionPrincipalId);
                });

            migrationBuilder.CreateTable(
                name: "NivelesEscolares",
                columns: table => new
                {
                    NivelEscolarId = table.Column<string>(maxLength: 3, nullable: false),
                    Nombre = table.Column<string>(maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NivelesEscolares", x => x.NivelEscolarId);
                });

            migrationBuilder.CreateTable(
                name: "RegimenesMatrimoniales",
                columns: table => new
                {
                    RegimenMatrimonialId = table.Column<string>(maxLength: 3, nullable: false),
                    Nombre = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegimenesMatrimoniales", x => x.RegimenMatrimonialId);
                });

            migrationBuilder.CreateTable(
                name: "Sectores",
                columns: table => new
                {
                    SectorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sectores", x => x.SectorId);
                });

            migrationBuilder.CreateTable(
                name: "SituacionesPersonales",
                columns: table => new
                {
                    SituacionPersonalId = table.Column<string>(maxLength: 3, nullable: false),
                    Nombre = table.Column<string>(maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SituacionesPersonales", x => x.SituacionPersonalId);
                });

            migrationBuilder.CreateTable(
                name: "Municipios",
                columns: table => new
                {
                    MunicipioId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(maxLength: 100, nullable: true),
                    EntidadFederativaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Municipios", x => x.MunicipioId);
                    table.ForeignKey(
                        name: "FK_Municipios_EntidadesFederativas_EntidadFederativaId",
                        column: x => x.EntidadFederativaId,
                        principalTable: "EntidadesFederativas",
                        principalColumn: "EntidadFederativaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ServidoresPublicos",
                columns: table => new
                {
                    ServidorPublicoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(maxLength: 40, nullable: true),
                    PrimerApellido = table.Column<string>(maxLength: 40, nullable: true),
                    SegundoApellido = table.Column<string>(maxLength: 40, nullable: true),
                    CURP = table.Column<string>(maxLength: 18, nullable: true),
                    RFC = table.Column<string>(maxLength: 10, nullable: true),
                    Homoclave = table.Column<string>(maxLength: 3, nullable: true),
                    CorreoElectronico = table.Column<string>(maxLength: 100, nullable: true),
                    MunicipioId = table.Column<int>(nullable: false),
                    LocalidadNombre = table.Column<string>(maxLength: 50, nullable: true),
                    CodigoPostal = table.Column<int>(nullable: false),
                    CalleNombre = table.Column<string>(maxLength: 50, nullable: true),
                    NumeroExterior = table.Column<string>(maxLength: 10, nullable: true),
                    NumeroInterior = table.Column<string>(maxLength: 10, nullable: true),
                    NumeroCelular = table.Column<string>(maxLength: 10, nullable: true),
                    SituacionPersonalId = table.Column<string>(maxLength: 3, nullable: true),
                    RegimenMatrimonialId = table.Column<string>(maxLength: 3, nullable: true),
                    NumeroIdentificacionOficial = table.Column<string>(maxLength: 50, nullable: true),
                    FuncionPrincipalId = table.Column<int>(nullable: false),
                    TelefonoOficina = table.Column<string>(maxLength: 20, nullable: true),
                    EsServidorPublicoAnioAnterior = table.Column<string>(maxLength: 2, nullable: true),
                    NivelEscolarId = table.Column<string>(maxLength: 3, nullable: true),
                    InstitucionEducativa = table.Column<string>(maxLength: 200, nullable: true),
                    CarreraArea = table.Column<string>(maxLength: 150, nullable: true),
                    EstatusNivelEscolaridad = table.Column<string>(maxLength: 10, nullable: true),
                    DocumentoObtenido = table.Column<string>(maxLength: 11, nullable: true),
                    FechaObtencion = table.Column<DateTime>(nullable: false),
                    LugarInstitucion = table.Column<string>(maxLength: 16, nullable: true),
                    AmbitoSectorLaboral = table.Column<string>(maxLength: 7, nullable: true),
                    Nivel = table.Column<string>(maxLength: 20, nullable: true),
                    AmbitoPublico = table.Column<string>(maxLength: 17, nullable: true),
                    NombreEntePublico = table.Column<string>(maxLength: 100, nullable: true),
                    RFCEntePublico = table.Column<string>(maxLength: 10, nullable: true),
                    AreaAdscripcion = table.Column<string>(maxLength: 100, nullable: true),
                    EmpleoCargoComision = table.Column<string>(maxLength: 100, nullable: true),
                    FuncionPrincipalExperiencia = table.Column<string>(maxLength: 100, nullable: true),
                    FechaIngreso = table.Column<DateTime>(nullable: false),
                    FechaEgreso = table.Column<DateTime>(nullable: false),
                    SectorId = table.Column<int>(maxLength: 10, nullable: false),
                    NumeroEmpleado = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServidoresPublicos", x => x.ServidorPublicoId);
                    table.ForeignKey(
                        name: "FK_ServidoresPublicos_FuncionesPrincipales_FuncionPrincipalId",
                        column: x => x.FuncionPrincipalId,
                        principalTable: "FuncionesPrincipales",
                        principalColumn: "FuncionPrincipalId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServidoresPublicos_Municipios_MunicipioId",
                        column: x => x.MunicipioId,
                        principalTable: "Municipios",
                        principalColumn: "MunicipioId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServidoresPublicos_NivelesEscolares_NivelEscolarId",
                        column: x => x.NivelEscolarId,
                        principalTable: "NivelesEscolares",
                        principalColumn: "NivelEscolarId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ServidoresPublicos_RegimenesMatrimoniales_RegimenMatrimonialId",
                        column: x => x.RegimenMatrimonialId,
                        principalTable: "RegimenesMatrimoniales",
                        principalColumn: "RegimenMatrimonialId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ServidoresPublicos_Sectores_SectorId",
                        column: x => x.SectorId,
                        principalTable: "Sectores",
                        principalColumn: "SectorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServidoresPublicos_SituacionesPersonales_SituacionPersonalId",
                        column: x => x.SituacionPersonalId,
                        principalTable: "SituacionesPersonales",
                        principalColumn: "SituacionPersonalId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Municipios_EntidadFederativaId",
                table: "Municipios",
                column: "EntidadFederativaId");

            migrationBuilder.CreateIndex(
                name: "IX_ServidoresPublicos_FuncionPrincipalId",
                table: "ServidoresPublicos",
                column: "FuncionPrincipalId");

            migrationBuilder.CreateIndex(
                name: "IX_ServidoresPublicos_MunicipioId",
                table: "ServidoresPublicos",
                column: "MunicipioId");

            migrationBuilder.CreateIndex(
                name: "IX_ServidoresPublicos_NivelEscolarId",
                table: "ServidoresPublicos",
                column: "NivelEscolarId");

            migrationBuilder.CreateIndex(
                name: "IX_ServidoresPublicos_RegimenMatrimonialId",
                table: "ServidoresPublicos",
                column: "RegimenMatrimonialId");

            migrationBuilder.CreateIndex(
                name: "IX_ServidoresPublicos_SectorId",
                table: "ServidoresPublicos",
                column: "SectorId");

            migrationBuilder.CreateIndex(
                name: "IX_ServidoresPublicos_SituacionPersonalId",
                table: "ServidoresPublicos",
                column: "SituacionPersonalId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ServidoresPublicos");

            migrationBuilder.DropTable(
                name: "FuncionesPrincipales");

            migrationBuilder.DropTable(
                name: "Municipios");

            migrationBuilder.DropTable(
                name: "NivelesEscolares");

            migrationBuilder.DropTable(
                name: "RegimenesMatrimoniales");

            migrationBuilder.DropTable(
                name: "Sectores");

            migrationBuilder.DropTable(
                name: "SituacionesPersonales");

            migrationBuilder.DropTable(
                name: "EntidadesFederativas");
        }
    }
}
