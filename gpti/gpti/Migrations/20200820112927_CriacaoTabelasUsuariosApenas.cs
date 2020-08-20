using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace gpti.Migrations
{
    public partial class CriacaoTabelasUsuariosApenas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "Agenda",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(nullable: false)
            //            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //        Data = table.Column<DateTime>(nullable: false),
            //        Hora = table.Column<string>(nullable: true),
            //        ContInt = table.Column<string>(nullable: true),
            //        ContExt = table.Column<string>(nullable: true),
            //        Local = table.Column<string>(nullable: true),
            //        TelCont = table.Column<string>(nullable: true),
            //        Descricao = table.Column<string>(nullable: true),
            //        Tipo = table.Column<string>(nullable: true),
            //        Minutos = table.Column<string>(nullable: true),
            //        TempoDesloc = table.Column<string>(nullable: true),
            //        Resolvido_Data = table.Column<DateTime>(nullable: true),
            //        Resolvido_Hora = table.Column<string>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Agenda", x => x.Id);
            //    });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 64, nullable: false),
                    Name = table.Column<string>(maxLength: 64, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 64, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 64, nullable: false),
                    UserName = table.Column<string>(maxLength: 64, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 64, nullable: true),
                    Email = table.Column<string>(maxLength: 64, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 64, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            //migrationBuilder.CreateTable(
            //    name: "Cab",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(nullable: false)
            //            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //        Empresa = table.Column<string>(nullable: true),
            //        DadosContato = table.Column<string>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Cab", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Clientes",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(nullable: false)
            //            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //        Nome = table.Column<string>(nullable: true),
            //        Razao = table.Column<string>(nullable: true),
            //        Endereco = table.Column<string>(nullable: true),
            //        Cep = table.Column<string>(nullable: true),
            //        Bairro = table.Column<string>(nullable: true),
            //        Cidade = table.Column<string>(nullable: true),
            //        Estado = table.Column<string>(nullable: true),
            //        Valor = table.Column<double>(nullable: false),
            //        Vencimento = table.Column<DateTime>(nullable: true),
            //        Multa = table.Column<double>(nullable: true),
            //        CGC = table.Column<string>(nullable: true),
            //        Inscricao = table.Column<string>(nullable: true),
            //        Telefone = table.Column<string>(nullable: true),
            //        Contato = table.Column<string>(nullable: true),
            //        Cobranca = table.Column<string>(nullable: true),
            //        Dolar = table.Column<double>(nullable: true),
            //        VendaAlugu = table.Column<string>(nullable: true),
            //        Salario = table.Column<string>(nullable: true),
            //        IniContrat = table.Column<DateTime>(nullable: true),
            //        IniManut = table.Column<string>(nullable: true),
            //        Mensagem = table.Column<string>(nullable: true),
            //        CodMem = table.Column<string>(nullable: true),
            //        UltBol = table.Column<double>(nullable: true),
            //        Obs = table.Column<string>(nullable: true),
            //        FormaPg = table.Column<string>(nullable: true),
            //        E_mail = table.Column<string>(nullable: true),
            //        Homepage = table.Column<string>(nullable: true),
            //        Corresp = table.Column<string>(nullable: true),
            //        Sistema = table.Column<string>(nullable: true),
            //        Versao = table.Column<string>(nullable: true),
            //        Parcelas = table.Column<double>(nullable: true),
            //        ValPar = table.Column<double>(nullable: true),
            //        DtInicio = table.Column<DateTime>(nullable: true),
            //        Receita = table.Column<double>(nullable: true),
            //        Custo = table.Column<double>(nullable: true),
            //        Tempo = table.Column<double>(nullable: true),
            //        ValorTotal = table.Column<double>(nullable: true),
            //        DescFat = table.Column<double>(nullable: true),
            //        Login = table.Column<string>(nullable: true),
            //        Senha = table.Column<string>(nullable: true),
            //        Autorizado = table.Column<string>(nullable: true),
            //        Mensagem_No_Site = table.Column<string>(nullable: true),
            //        PastaServer = table.Column<string>(nullable: true),
            //        PastaClient = table.Column<string>(nullable: true),
            //        PercSobreSalario = table.Column<double>(nullable: true),
            //        DataTravaSistema = table.Column<DateTime>(nullable: true),
            //        DiasARenovar = table.Column<int>(nullable: true),
            //        BancoCobr = table.Column<string>(nullable: true),
            //        Opcao_NO = table.Column<string>(nullable: true),
            //        mysql_ip = table.Column<string>(nullable: true),
            //        mysql_nomebd = table.Column<string>(nullable: true),
            //        mysql_user = table.Column<string>(nullable: true),
            //        mysql_pwd = table.Column<string>(nullable: true),
            //        QtMaq = table.Column<int>(nullable: true),
            //        QtMaqDesktop = table.Column<int>(nullable: true),
            //        QtMaqMovel = table.Column<int>(nullable: true),
            //        DtRescisao = table.Column<DateTime>(nullable: true),
            //        DtAudVal = table.Column<DateTime>(nullable: true),
            //        DtUltAcesso = table.Column<DateTime>(nullable: true),
            //        DtEmiBol = table.Column<DateTime>(nullable: true),
            //        NumBoleto = table.Column<string>(nullable: true),
            //        CorrecaoDiariaAtraso = table.Column<double>(nullable: false),
            //        HrEmiBol = table.Column<string>(nullable: true),
            //        LoginEmiBol = table.Column<string>(nullable: true),
            //        NomeEmissorBol = table.Column<string>(nullable: true),
            //        QtMaquinasReg = table.Column<int>(nullable: true),
            //        PercSalAdMaq = table.Column<double>(nullable: false),
            //        CritMensalid = table.Column<string>(nullable: true),
            //        MesAtraso = table.Column<string>(nullable: true),
            //        ValorAnterior = table.Column<double>(nullable: false),
            //        ValMensMob = table.Column<double>(nullable: false),
            //        QtUsuariosMob = table.Column<int>(nullable: true),
            //        ValMensSiteOnl = table.Column<double>(nullable: false),
            //        DiaSemanaBkp = table.Column<int>(nullable: true),
            //        DataUltBkp = table.Column<DateTime>(nullable: true),
            //        HoraUltBkp = table.Column<string>(nullable: true),
            //        E_mail2 = table.Column<string>(nullable: true),
            //        E_mail3 = table.Column<string>(nullable: true),
            //        MostraAnuncios = table.Column<int>(nullable: true),
            //        Senha_A = table.Column<int>(nullable: true),
            //        PercDesconto = table.Column<double>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Clientes", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Pendencias",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(nullable: false)
            //            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //        Prior = table.Column<int>(nullable: true),
            //        Tipo = table.Column<string>(nullable: true),
            //        Cliente = table.Column<string>(nullable: true),
            //        Descricao = table.Column<string>(nullable: true),
            //        DataSolic = table.Column<DateTime>(nullable: true),
            //        Posicao = table.Column<string>(nullable: true),
            //        DataPos = table.Column<DateTime>(nullable: true),
            //        HoraPos = table.Column<string>(nullable: true),
            //        QuemSolic = table.Column<string>(nullable: true),
            //        FormaSolic = table.Column<string>(nullable: true),
            //        ComentInt = table.Column<string>(nullable: true),
            //        Sistema = table.Column<string>(nullable: true),
            //        Usuario = table.Column<string>(nullable: true),
            //        Previsao = table.Column<DateTime>(nullable: true),
            //        Minutos = table.Column<int>(nullable: false),
            //        QtdDias = table.Column<int>(nullable: false),
            //        DtLanc = table.Column<DateTime>(nullable: true),
            //        Prog = table.Column<string>(nullable: true),
            //        NovoItem = table.Column<int>(nullable: false),
            //        Urgente = table.Column<int>(nullable: false),
            //        NaWeb = table.Column<string>(nullable: true),
            //        Projeto = table.Column<string>(nullable: true),
            //        DescricaoOrig = table.Column<string>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Pendencias", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "RCP",
            //    columns: table => new
            //    {
            //        Id = table.Column<double>(nullable: false),
            //        Data = table.Column<DateTime>(nullable: false),
            //        Hora = table.Column<string>(nullable: true),
            //        ContInt = table.Column<string>(nullable: true),
            //        ContExt = table.Column<string>(nullable: true),
            //        Local = table.Column<string>(nullable: true),
            //        TelCont = table.Column<string>(nullable: true),
            //        Posicao = table.Column<string>(nullable: true),
            //        Tipo = table.Column<string>(nullable: true),
            //        Ct = table.Column<string>(nullable: true),
            //        Email = table.Column<string>(nullable: true),
            //        Origem = table.Column<string>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_RCP", x => x.Id);
            //    });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(maxLength: 64, nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(maxLength: 64, nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
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
                    LoginProvider = table.Column<string>(maxLength: 64, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 64, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(maxLength: 64, nullable: false)
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
                    UserId = table.Column<string>(maxLength: 64, nullable: false),
                    RoleId = table.Column<string>(maxLength: 64, nullable: false)
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
                    UserId = table.Column<string>(maxLength: 64, nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 64, nullable: false),
                    Name = table.Column<string>(maxLength: 64, nullable: false),
                    Value = table.Column<string>(nullable: true)
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
                unique: true);

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
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "Agenda");

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
            //    name: "Cab");

            //migrationBuilder.DropTable(
            //    name: "Clientes");

            //migrationBuilder.DropTable(
            //    name: "Pendencias");

            //migrationBuilder.DropTable(
            //    name: "RCP");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
