using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class IzmenaRideDTOModela : Migration
    {
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
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: false),
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

            migrationBuilder.CreateTable(
                name: "Passengers",
                columns: table => new
                {
                    PassengerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Lastname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PassengersLatitude = table.Column<double>(type: "float", nullable: true),
                    PassengersLongitude = table.Column<double>(type: "float", nullable: true),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passengers", x => x.PassengerId);
                });

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    RatingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RideId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Score = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.RatingId);
                });

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
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
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

            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    Driver_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    Longitude = table.Column<double>(type: "float", nullable: false),
                    StartPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PricePerKM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DriverStatus = table.Column<int>(type: "int", nullable: false),
                    PassengerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.Driver_ID);
                    table.ForeignKey(
                        name: "FK_Drivers_Passengers_PassengerId",
                        column: x => x.PassengerId,
                        principalTable: "Passengers",
                        principalColumn: "PassengerId");
                });

            migrationBuilder.CreateTable(
                name: "Rides",
                columns: table => new
                {
                    RideId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PassengerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Driver_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RatingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartLatitude = table.Column<double>(type: "float", nullable: false),
                    StartLongitude = table.Column<double>(type: "float", nullable: false),
                    EndLatitude = table.Column<double>(type: "float", nullable: false),
                    EndLongitude = table.Column<double>(type: "float", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    StatusMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PassengerRatingRatingId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PassengerId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rides", x => x.RideId);
                    table.ForeignKey(
                        name: "FK_Rides_Drivers_Driver_ID",
                        column: x => x.Driver_ID,
                        principalTable: "Drivers",
                        principalColumn: "Driver_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rides_Passengers_PassengerId",
                        column: x => x.PassengerId,
                        principalTable: "Passengers",
                        principalColumn: "PassengerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rides_Passengers_PassengerId1",
                        column: x => x.PassengerId1,
                        principalTable: "Passengers",
                        principalColumn: "PassengerId");
                    table.ForeignKey(
                        name: "FK_Rides_Ratings_PassengerRatingRatingId",
                        column: x => x.PassengerRatingRatingId,
                        principalTable: "Ratings",
                        principalColumn: "RatingId");
                });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Driver_ID", "Brand", "DriverStatus", "FirstName", "LastName", "Latitude", "Longitude", "PassengerId", "PricePerKM", "StartPrice" },
                values: new object[,]
                {
                    { new Guid("02f293bb-fd5d-4614-9f35-a108c7f14764"), "TOYOTA", 0, "Dang", "Erskine", 45.217855950352465, 19.834207010840032, null, 1.7497987535854724m, 4.824188848962091m },
                    { new Guid("03e03163-d1e8-4aa4-808f-1491bf7f0560"), "Lincoln", 0, "Delair", "Meredith", 45.252036208353331, 19.868004870058986, null, 1.6143386734417438m, 6.054391760371328m },
                    { new Guid("04f8dc2c-a90d-428f-a699-8f8fc57276f8"), "Porsche", 0, "Walker", "Maruk", 45.217759832566678, 19.812095479197652, null, 1.0201468787267918m, 8.987330756776993m },
                    { new Guid("076dfade-a481-4720-8fbf-86f5e31d175e"), "RAM", 0, "Welch", "Vaishali", 45.226846241954064, 19.839414266674314, null, 1.3494145070278685m, 3.1034505930423064m },
                    { new Guid("07d358a5-77c3-4446-8d22-783ada246f67"), "FIAT", 0, "Harold", "Karl", 45.286324628710155, 19.859015812248142, null, 1.7153672461915734m, 9.684974884213723m },
                    { new Guid("095380e7-22e1-4178-af88-49d0bc547736"), "Buick", 0, "Edie", "Maeve", 45.204068043710627, 19.850483415082969, null, 1.2435787993749734m, 1.5525301188205578m },
                    { new Guid("095ea7ec-9209-4fdc-98b7-f7fbbcc56afc"), "Audi", 0, "Carling", "Angeles", 45.256456267336631, 19.839344022449293, null, 1.2919937229218867m, 3.8797762168830876m },
                    { new Guid("0c0f320d-896e-48b2-8bd4-36081de3615f"), "Land Rover", 0, "Maurits", "Anurag", 45.253925064457675, 19.828862737626718, null, 1.7104501368390608m, 4.2596837052732415m },
                    { new Guid("0d9f69e0-9bb6-4a24-9a89-8ba4555158bf"), "Chevrolet", 0, "Krizia", "Brusovanik", 45.267957633744437, 19.799666210958843, null, 1.6786208486121708m, 7.342233447742731m },
                    { new Guid("0e605ccb-5535-475d-b02f-7170ba6a5767"), "Mini", 0, "Rue", "Henrik", 45.234728393171295, 19.822851909980773, null, 1.1939296054078634m, 1.7459564675100006m },
                    { new Guid("0e655290-29d2-46f6-8adb-b45b8622b54e"), "TOYOTA", 0, "Aden", "Eliza", 45.268648133812405, 19.831866095348715, null, 1.391490893102681m, 8.095125839709704m },
                    { new Guid("105c841e-203b-4e5c-9d4d-39f8f4e130f3"), "Lamborghini", 0, "Aparna", "Segundo", 45.225215199148884, 19.883468373193303, null, 1.2154110733189056m, 3.652480026698223m },
                    { new Guid("111e65f5-52a5-45ea-be17-f31b5e834405"), "Pagani Automobili S.p.A.", 0, "Morrissey", "Kellie", 45.274651670577768, 19.791858685850482, null, 1.3417230653533827m, 2.18234253206158m },
                    { new Guid("12c13742-98c2-4c0d-a74c-d28a878621ef"), "McLaren", 0, "Flora", "Allesdandro", 45.250220306572913, 19.80629652423562, null, 1.6560543096854814m, 9.747141997226342m },
                    { new Guid("15f16314-0333-4e92-8321-6f8493ffc1a4"), "Cadillac", 0, "Misael", "Gizelle", 45.260938791275308, 19.796892550971364, null, 1.0686156356587282m, 4.528765037827812m },
                    { new Guid("164d2f31-7ac4-47f6-9a3a-bc728c719f4f"), "Pagani Automobili S.p.A.", 0, "Jamison", "Ash", 45.278270343256636, 19.852105063006313, null, 1.3374700364494403m, 8.12755415792042m },
                    { new Guid("19ee384f-233d-44da-a686-526a5d96c4c7"), "Mitsubishi Motors Corporation", 0, "Bechmann", "Maikol", 45.279071426502327, 19.862370160619843, null, 1.324328579217307m, 4.565442360558393m },
                    { new Guid("1bb72d0b-6a17-429f-9ca7-1317089277eb"), "Volvo", 0, "Jessa", "Tetiana", 45.228208563610373, 19.864794930227959, null, 1.4501630881251706m, 4.989849053623997m },
                    { new Guid("1c421f60-6570-4c60-8816-49fea6f03c2f"), "Roush", 0, "Bernardino", "Danel", 45.262091751738382, 19.836733731194897, null, 1.685522127629019m, 5.239149409686604m },
                    { new Guid("1c9df88b-8c0d-426c-8f3d-5f6b29887771"), "CHEVROLET", 0, "Construccion", "Rossi", 45.287037867075718, 19.853352110430713, null, 1.1262567197952467m, 4.052167523478899m },
                    { new Guid("210fd3e0-4849-4278-bd1e-d280c65c7c49"), "Chrysler", 0, "Ibrahim", "Alina", 45.2993118675817, 19.796265612687975, null, 1.1089619486674978m, 10.521486246480235m },
                    { new Guid("256dc23b-4a54-43e3-8e08-73ccce206ed6"), "Mitsubishi Motors Corporation", 0, "Yev", "Leeann", 45.243827207876294, 19.795146332823769, null, 1.4038353529833358m, 7.1267708754257715m },
                    { new Guid("268bf2de-5473-4cd4-b34d-5ac63b7c66ec"), "Aston Martin Lagonda Ltd", 0, "Oracio", "Richie", 45.224688333074994, 19.83919841648629, null, 1.385540803473964m, 9.910185805400143m },
                    { new Guid("275df2a3-6d6d-4e11-9d0d-cd03641b123f"), "Roush", 0, "Evangeline", "Granados", 45.255782205655841, 19.854106076392526, null, 1.7553795014338474m, 6.146249025698085m },
                    { new Guid("28a3f5ef-c4cb-4b5c-a872-9a8849f62c95"), "INFINITI", 0, "Deepti", "Devara", 45.275913260410107, 19.85081695839504, null, 1.6342564595450453m, 10.57353943753355m },
                    { new Guid("28e300f5-159d-456e-ba31-63cbf12f034c"), "Volkswagen", 0, "Werner", "Inde", 45.221608244262498, 19.819591497862248, null, 1.3967480906659557m, 4.545871705956596m },
                    { new Guid("2c84cba7-77f2-467b-be5f-4ff251d5da16"), "Honda", 0, "Marin", "Jesus", 45.296192164092709, 19.814406778655229, null, 1.308227287026685m, 3.9326792288937376m },
                    { new Guid("2ccd25a3-6a3f-4d20-972c-8bbb4702c791"), "Roush", 0, "Bernardino", "Danel", 45.262091751738382, 19.836733731194897, null, 1.685522127629019m, 5.239149409686604m },
                    { new Guid("2d1e2028-35b1-4b75-b803-20b5fad24081"), "NISSAN", 0, "Rasika", "Raimundo", 45.291779211384224, 19.800023095935906, null, 1.0891868325268717m, 4.793560726767151m },
                    { new Guid("2d916139-f776-4321-9c25-5075d639575e"), "ALFA ROMEO", 0, "Allison", "Royden", 45.295945743171906, 19.857674174593402, null, 1.5237046745427651m, 10.405094574404158m },
                    { new Guid("2fc34047-066b-4c16-b2f7-dfff1cdb9fbe"), "Acura", 0, "Anais", "Johnna", 45.287676498702332, 19.843019007354567, null, 1.1278655668254658m, 10.710397156830041m },
                    { new Guid("3181f5c1-669a-4d9b-9f13-cc8dce11405f"), "Honda", 0, "Libbey", "Ernest", 45.282891901118944, 19.876434018077504, null, 1.2475192510221107m, 5.449373131830329m },
                    { new Guid("33a155c8-d417-4737-a374-21096b428f0d"), "Volvo", 0, "Taryn", "Bener", 45.230507721803349, 19.8096740775133, null, 1.58709815212918m, 10.487772005185393m },
                    { new Guid("3526bc60-7217-4a54-8156-c2b559bb99a0"), "Mercedes-Benz", 0, "Marielle", "Orzai", 45.247779667723108, 19.842528794842231, null, 1.1929093189440756m, 4.356274892567532m },
                    { new Guid("35359b05-c33e-4664-b6ab-5b74cd91681e"), "Volvo", 0, "Lluvia", "Judd", 45.244554013188768, 19.872895707350001, null, 1.253412375617725m, 5.882144460892146m },
                    { new Guid("353a5f8d-9e62-4616-9189-695e97a88fb6"), "Land Rover", 0, "Oja", "Chin", 45.256914630896212, 19.858970871427317, null, 1.26487632045056m, 10.747802492089736m },
                    { new Guid("356b7c3f-7a36-42a2-a841-a0adf1c5aa7f"), "INFINITI", 0, "Haas", "Chad", 45.288022877311491, 19.874835733268696, null, 1.5866952090365798m, 8.087357945507915m },
                    { new Guid("36383cc5-2fc4-4757-ba7e-d41bdf739d1c"), "Ford", 0, "Cora", "Otra", 45.278586743787962, 19.802530466611248, null, 1.7253447233445418m, 10.91510684753183m },
                    { new Guid("38f9eb5f-80ba-49d4-af7b-2f072b44867d"), "Jeep", 0, "Iya", "Jhonatan", 45.276139257770936, 19.843919556371958, null, 1.6328898520108956m, 7.314957794295983m },
                    { new Guid("3c69c9cc-b6e7-4f7e-b170-1fcfaac5a1b0"), "MASERATI", 0, "Residencia", "Casper", 45.229981095425153, 19.837153864471194, null, 1.554999380283847m, 9.574431191837565m },
                    { new Guid("3c8a9db0-e636-4ddc-817c-87ad52152e36"), "Mini", 0, "Larae", "Lindsey", 45.288988349342716, 19.869009669621189, null, 1.2705361960792216m, 3.7409616159613304m },
                    { new Guid("3cf1ff8f-a51d-453b-8850-68376374366f"), "Porsche", 0, "Lily", "Eugenia", 45.257195153791159, 19.808529545036901, null, 1.7101176770777686m, 2.275882597440534m }
                });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Driver_ID", "Brand", "DriverStatus", "FirstName", "LastName", "Latitude", "Longitude", "PassengerId", "PricePerKM", "StartPrice" },
                values: new object[,]
                {
                    { new Guid("3db32039-6ddb-4b33-80f7-c1261770bc14"), "Buick", 0, "Edie", "Maeve", 45.204068043710627, 19.850483415082969, null, 1.2435787993749734m, 1.5525301188205578m },
                    { new Guid("41a1b3ae-1f97-4e8b-9091-bd2162598a3d"), "Lincoln", 0, "Geri", "Miii", 45.240326613759379, 19.856313447907667, null, 1.7338599905115184m, 10.732414512171566m },
                    { new Guid("452415f2-1144-4a49-8bb2-cd46eb16993b"), "Volvo", 0, "Zena", "Kirstein", 45.238319779725494, 19.810359597732457, null, 1.7020772550670218m, 10.79799094974425m },
                    { new Guid("45ac7fc7-9790-4d9b-a85c-715dee4bfc44"), "Porsche", 0, "Chrissy", "Tanyia", 45.279449168518042, 19.785822522191463, null, 1.4492458808602435m, 2.028265801352166m },
                    { new Guid("47c22e59-8c23-456e-accf-98cb993d6d0a"), "Mercedes-Benz", 0, "Fernanda", "Berry", 45.284341031601357, 19.88214656986014, null, 1.228808543535298m, 2.642344591342897m },
                    { new Guid("4953796f-942f-4c38-a16f-6d607970aa80"), "Bentley", 0, "Brandy", "Eleanor", 45.299538969878988, 19.880643245594662, null, 1.6281722977710191m, 5.728713211147051m },
                    { new Guid("49ff33f6-928c-4767-98b8-78e84e05ecc0"), "Roush", 0, "Rossane", "Jessica", 45.266559868005444, 19.829707954977223, null, 1.504112436608676m, 9.364469311550952m },
                    { new Guid("4a29d639-b6a9-4b06-93ab-737df6c82f01"), "CHEVROLET", 0, "Edouard", "Jehan", 45.210031240196187, 19.819412677818654, null, 1.2289611665909137m, 10.316446613551822m },
                    { new Guid("4bcda8a6-0756-44c0-b55a-2a7526e3a62d"), "Lamborghini", 0, "Ilhan", "Reserved", 45.269939911723235, 19.805821814574692, null, 1.7714084180476508m, 8.149353140401365m },
                    { new Guid("4e4383c9-4d90-4f7e-817e-826d44e8891f"), "LEXUS", 0, "Raina", "Lula", 45.223453054301878, 19.830829334577729, null, 1.0164590921625576m, 6.269772816844689m },
                    { new Guid("4ef04a84-f49d-49b3-8a1b-ea41124044bc"), "Porsche", 0, "Lily", "Eugenia", 45.257195153791159, 19.808529545036901, null, 1.7101176770777686m, 2.275882597440534m },
                    { new Guid("4f6f3172-537b-4a7d-8a7f-6ca04089f7de"), "Mini", 0, "Maurits", "Paulien", 45.296887928208001, 19.858852384808518, null, 1.7376903735062375m, 4.928084949383901m },
                    { new Guid("50ede44b-104d-44e6-ab43-abef6dea2bf2"), "CHEVROLET", 0, "Edouard", "Jehan", 45.210031240196187, 19.819412677818654, null, 1.2289611665909137m, 10.316446613551822m },
                    { new Guid("51edf0eb-2a12-4471-8a4b-9b50b32f5eb9"), "CHEVROLET", 0, "Construccion", "Rossi", 45.287037867075718, 19.853352110430713, null, 1.1262567197952467m, 4.052167523478899m },
                    { new Guid("524e3d66-8930-4c4a-9eb6-92c7841bb239"), "MAZDA", 0, "Rafal", "Monserrat", 45.282153330425473, 19.800982908909283, null, 1.0444604099295751m, 6.848472092200129m },
                    { new Guid("53313b62-3711-470b-9a8d-4d4a8790e1b5"), "Roush", 0, "Iva", "Sloane", 45.218399244374908, 19.792091597548286, null, 1.6978977180498203m, 8.769920005723455m },
                    { new Guid("54e75460-fdaa-4749-9068-d91aab61d045"), "Bentley", 0, "Ann", "Canosa", 45.204344318934922, 19.835281956415212, null, 1.476499130995161m, 3.3429406521108387m },
                    { new Guid("5512262b-dc37-46f9-8feb-bc47f88520dc"), "INFINITI", 0, "Jastinder", "Homero", 45.269815899190036, 19.810080082882855, null, 1.5244558202271907m, 1.9469998885842523m },
                    { new Guid("557df9f4-655f-4914-9235-26af654fd8bf"), "Bentley", 0, "Lupita", "Bennet", 45.280486776875811, 19.844408581896609, null, 1.1702439175398553m, 10.496768111188889m },
                    { new Guid("5745a575-e860-4141-b49e-7f56fc2938f1"), "MASERATI", 0, "Vartan", "Rhee", 45.298049374458131, 19.878864637212104, null, 1.5393415373611448m, 6.559482220099541m },
                    { new Guid("58238a88-1a34-4b5b-aac8-0cfd843baa4b"), "Lincoln", 0, "Javid", "Tranta", 45.216149699839988, 19.853299911074188, null, 1.214353703785661m, 4.696927726796888m },
                    { new Guid("588413a8-594b-4e0f-8fb7-7e7dbb938a81"), "Porsche", 0, "Jen", "Shar", 45.210580578767569, 19.787137195434291, null, 1.7006360867551042m, 9.781009068780087m },
                    { new Guid("598fc8c0-9936-4aed-aa2d-4a465f3bdf60"), "Lamborghini", 0, "Letizia", "Kerry", 45.281638953906281, 19.813600296747204, null, 1.099366625884517m, 1.3295397945411715m },
                    { new Guid("5aad41b9-808e-425b-86cd-22601100c5ed"), "Honda", 0, "Talbot", "Carwen", 45.250169050776421, 19.794775524085665, null, 1.4473141471090796m, 4.881600711969098m },
                    { new Guid("5d98a101-3a66-4ea4-ab6e-3cf6dfad615a"), "MAZDA", 0, "Rafal", "Monserrat", 45.282153330425473, 19.800982908909283, null, 1.0444604099295751m, 6.848472092200129m },
                    { new Guid("5dbc2aa9-35bc-4d05-ab4a-d82c8ade3a96"), "TOYOTA", 0, "Dang", "Erskine", 45.217855950352465, 19.834207010840032, null, 1.7497987535854724m, 4.824188848962091m },
                    { new Guid("5e5672dc-dccc-40bb-9249-74d965e24645"), "Porsche", 0, "Vlada", "Marisela", 45.275549215170642, 19.878672958375621, null, 1.692150219149442m, 4.292175821808732m },
                    { new Guid("5ed35720-d23f-4766-8019-4fa4102b74d0"), "Jaguar", 0, "Dilini", "Joy", 45.204205166231176, 19.821658287825695, null, 1.5632855538691586m, 9.828321299882433m },
                    { new Guid("615d82c7-7325-487f-ab3d-91f2d976a4ff"), "Land Rover", 0, "Oja", "Chin", 45.256914630896212, 19.858970871427317, null, 1.26487632045056m, 10.747802492089736m },
                    { new Guid("618719ed-97ea-4375-a915-3bf0bedbd4fe"), "RAM", 0, "Renata", "Yadi", 45.296758424609912, 19.847822587069356, null, 1.5933840239464465m, 3.1678197529395926m },
                    { new Guid("63e87ff3-ea02-496e-85dd-ce80c31ca6ad"), "Mercedes-Benz", 0, "Osvando", "Nicolaios", 45.216763399661289, 19.839646217936401, null, 1.390698997245516m, 2.4629580725247315m },
                    { new Guid("64a22db6-845f-44c4-9b5a-d0cc673aafac"), "Volvo", 0, "Taryn", "Bener", 45.230507721803349, 19.8096740775133, null, 1.58709815212918m, 10.487772005185393m },
                    { new Guid("67c89bd2-4d47-4d3f-a234-b07fc5c39731"), "Chevrolet", 0, "Jerome", "Hoj", 45.26187929944556, 19.852975472519034, null, 1.332259599316662m, 4.833445837024005m },
                    { new Guid("67dfa905-f875-4692-8d17-97839c1f6e07"), "Roush", 0, "Rossane", "Jessica", 45.266559868005444, 19.829707954977223, null, 1.504112436608676m, 9.364469311550952m },
                    { new Guid("685fb13a-a4da-488e-b8a3-cf77631682fa"), "Honda", 0, "Libbey", "Ernest", 45.282891901118944, 19.876434018077504, null, 1.2475192510221107m, 5.449373131830329m },
                    { new Guid("69241901-e735-4d23-8c4d-a104b47cbb72"), "Lincoln", 0, "Javid", "Tranta", 45.216149699839988, 19.853299911074188, null, 1.214353703785661m, 4.696927726796888m },
                    { new Guid("6b3ef949-0717-46c7-9aad-71c305c2cf24"), "MASERATI", 0, "Magali", "Vibeke", 45.21619104847931, 19.788370458607901, null, 1.6719496977709882m, 4.795675055141949m },
                    { new Guid("6b74d115-e273-4787-982a-65cf9470cd13"), "Volkswagen", 0, "Werner", "Inde", 45.221608244262498, 19.819591497862248, null, 1.3967480906659557m, 4.545871705956596m },
                    { new Guid("6bf43f6b-dacb-41ca-8002-62fb56460d2c"), "Lincoln", 0, "Geri", "Miii", 45.240326613759379, 19.856313447907667, null, 1.7338599905115184m, 10.732414512171566m },
                    { new Guid("6c2f9932-320c-4862-aa78-ac25e7345a33"), "Subaru", 0, "Luz", "Jacqui", 45.282357438284876, 19.870750281402625, null, 1.3275739312198804m, 7.389799555041893m },
                    { new Guid("6cb33e24-f892-4ddf-b2bf-8ec6a2d2fc7d"), "Jaguar", 0, "Dilini", "Joy", 45.204205166231176, 19.821658287825695, null, 1.5632855538691586m, 9.828321299882433m },
                    { new Guid("6e5b71b8-4fdf-47cc-9041-ea102b09318b"), "BMW", 0, "Alessandro", "Ame", 45.213878946434399, 19.83500906624565, null, 1.1394055188065981m, 10.629290075265152m }
                });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Driver_ID", "Brand", "DriverStatus", "FirstName", "LastName", "Latitude", "Longitude", "PassengerId", "PricePerKM", "StartPrice" },
                values: new object[,]
                {
                    { new Guid("703ca90d-1ba5-49d8-8c6f-e9cbb719e0ea"), "Roush", 0, "Iva", "Sloane", 45.218399244374908, 19.792091597548286, null, 1.6978977180498203m, 8.769920005723455m },
                    { new Guid("72c4517b-1e21-4b03-8269-e9a00dca06ef"), "Mini", 0, "Maurits", "Paulien", 45.296887928208001, 19.858852384808518, null, 1.7376903735062375m, 4.928084949383901m },
                    { new Guid("744c3eb1-e1bb-453c-aa9a-67a0fc67a393"), "Roush", 0, "Dahlia", "Pandora", 45.222647874969191, 19.786655808995068, null, 1.0651228912043087m, 7.807872207177916m },
                    { new Guid("74e531d2-1e75-4c0a-aa93-95127596eb3d"), "Aston Martin Lagonda Ltd", 0, "Oracio", "Richie", 45.224688333074994, 19.83919841648629, null, 1.385540803473964m, 9.910185805400143m },
                    { new Guid("76906508-1853-44b8-8f56-3efe607fa373"), "Jeep", 0, "Jurg", "Colleen", 45.27947091909018, 19.803280137550804, null, 1.0642568736345543m, 1.1178482649382784m },
                    { new Guid("7691a260-5b99-4dcc-84f7-aa5f3daf8516"), "Rolls-Royce Motor Cars Limited", 0, "Henrik", "Edwin", 45.260099746320648, 19.846618295659582, null, 1.452835505779086m, 8.383483200020429m },
                    { new Guid("78df1d19-25d9-4a8e-a1e5-724dd6a59773"), "TOYOTA", 0, "Henry", "Violoncella", 45.220604547812769, 19.860464073132178, null, 1.6549856762871982m, 8.414841851640341m },
                    { new Guid("7b3dffb6-1829-4f28-9418-5cac0d8574eb"), "Audi", 0, "Beata", "Salome", 45.29945492843008, 19.844297003241515, null, 1.0417866558859206m, 1.2473101141077794m },
                    { new Guid("7ba6ca2b-c677-41c2-aa4d-e680452d30aa"), "SCION", 0, "Vanessa", "Moran", 45.243401442719865, 19.845486901252453, null, 1.766625245740726m, 1.5974547157697985m },
                    { new Guid("7c1dde51-a03e-4974-acb5-a558f98b71ba"), "ALFA ROMEO", 0, "Allison", "Royden", 45.295945743171906, 19.857674174593402, null, 1.5237046745427651m, 10.405094574404158m },
                    { new Guid("7c717e4d-5582-4803-96f0-574b60372676"), "Jaguar", 0, "Mannix", "Gisella", 45.296266247572717, 19.804770086487757, null, 1.6910908453429156m, 3.2823166597464395m },
                    { new Guid("7e86b0ce-a093-4ff1-8969-71a13e2084be"), "Jeep", 0, "Iya", "Jhonatan", 45.276139257770936, 19.843919556371958, null, 1.6328898520108956m, 7.314957794295983m },
                    { new Guid("7ef78725-4ac0-44d7-8e3e-422cf9e1ece3"), "GMC", 0, "Brehan", "Leonardo", 45.284932615672936, 19.861347707346106, null, 1.0165564995215457m, 10.543527811952874m },
                    { new Guid("815f2254-3812-4d55-afff-c0558d9ec549"), "Rolls-Royce Motor Cars Limited", 0, "Henrik", "Edwin", 45.260099746320648, 19.846618295659582, null, 1.452835505779086m, 8.383483200020429m },
                    { new Guid("83d3aca0-c76d-4292-8175-fd9fdf5e62b2"), "Lincoln", 0, "Delair", "Meredith", 45.252036208353331, 19.868004870058986, null, 1.6143386734417438m, 6.054391760371328m },
                    { new Guid("85b42bd7-0fdc-492c-8684-d0df815b53bf"), "MAZDA", 0, "Callaghan", "Aiden", 45.215384546791014, 19.846282477003452, null, 1.7442378744022409m, 4.395966844983313m },
                    { new Guid("87434999-5115-42f9-9fc2-befe2f41054d"), "Chevrolet", 0, "Trace", "Gerry", 45.290891491829363, 19.828444245832451, null, 1.6389965205075372m, 8.368466873577997m },
                    { new Guid("876ed352-7833-42d9-a691-0522c4734660"), "Acura", 0, "Jasmine", "Dorothy", 45.209423511503424, 19.81749485016757, null, 1.3610869109414416m, 7.115251420780801m },
                    { new Guid("87a251b0-6fe7-4864-9ef1-a9edd44f63b3"), "Mini", 0, "Rue", "Henrik", 45.234728393171295, 19.822851909980773, null, 1.1939296054078634m, 1.7459564675100006m },
                    { new Guid("87e76964-7528-4a1e-a4b0-0a2d3a30e0de"), "Dodge", 0, "Andreas", "Adolfo", 45.265939837651047, 19.832946913832068, null, 1.7380170039298m, 8.510688070544214m },
                    { new Guid("88661c0d-2239-49a1-9940-9255660593d3"), "Bentley", 0, "Liliya", "Yeliz", 45.278508705345807, 19.806480944684065, null, 1.7553152421709535m, 4.360324081230656m },
                    { new Guid("8abe7849-a39b-4803-b36e-608e3ec94640"), "Lamborghini", 0, "Letizia", "Kerry", 45.281638953906281, 19.813600296747204, null, 1.099366625884517m, 1.3295397945411715m },
                    { new Guid("8d388c9d-f9c8-4db5-a7b8-093fed1bd788"), "Audi", 0, "Marc", "Erin", 45.262776103747605, 19.866401987510415, null, 1.0237952565130846m, 1.8608874905715336m },
                    { new Guid("90fe0fce-0d6d-476d-abca-fd519033a4df"), "Volvo", 0, "Lluvia", "Judd", 45.244554013188768, 19.872895707350001, null, 1.253412375617725m, 5.882144460892146m },
                    { new Guid("91647298-a7da-4cbd-8741-3f8245bf4228"), "Mini", 0, "Dianna", "Michal", 45.247323100321054, 19.842409377101806, null, 1.0397465494006515m, 5.223227457896003m },
                    { new Guid("91a3c2f3-7c36-43ad-bd23-c1bd3faa89ca"), "Mercedes-Benz", 0, "Marielle", "Orzai", 45.247779667723108, 19.842528794842231, null, 1.1929093189440756m, 4.356274892567532m },
                    { new Guid("929789bc-df5e-4100-b595-e9e68d3fbc87"), "Porsche", 0, "Chrissy", "Tanyia", 45.279449168518042, 19.785822522191463, null, 1.4492458808602435m, 2.028265801352166m },
                    { new Guid("92b77ec0-0238-41e3-9959-b28131b6a1ac"), "Acura", 0, "Jasmine", "Dorothy", 45.209423511503424, 19.81749485016757, null, 1.3610869109414416m, 7.115251420780801m },
                    { new Guid("948fa20c-310a-45b1-b0ba-413bfc8808c9"), "Bentley", 0, "Ann", "Canosa", 45.204344318934922, 19.835281956415212, null, 1.476499130995161m, 3.3429406521108387m },
                    { new Guid("94a7131e-b4ad-45af-90b4-e98bec6cab61"), "INFINITI", 0, "Deepti", "Devara", 45.275913260410107, 19.85081695839504, null, 1.6342564595450453m, 10.57353943753355m },
                    { new Guid("96a408c2-3882-4021-bd76-b750fc886821"), "Roush", 0, "Evangeline", "Granados", 45.255782205655841, 19.854106076392526, null, 1.7553795014338474m, 6.146249025698085m },
                    { new Guid("9864f4a6-449f-44aa-a25b-d62235e676c3"), "Roush", 0, "Dahlia", "Pandora", 45.222647874969191, 19.786655808995068, null, 1.0651228912043087m, 7.807872207177916m },
                    { new Guid("9946a11c-37e0-41fe-855d-efbb8d48b016"), "BMW", 0, "Jacques", "Lane", 45.213790253612132, 19.79774102895696, null, 1.7987752163597301m, 4.055436177433148m },
                    { new Guid("9a48e3d9-1b1e-4db1-9d1d-ea3690a82517"), "TOYOTA", 0, "Henry", "Violoncella", 45.220604547812769, 19.860464073132178, null, 1.6549856762871982m, 8.414841851640341m },
                    { new Guid("9b574fee-0cd2-47b5-a7ac-b8c9fb916445"), "LEXUS", 0, "Raina", "Lula", 45.223453054301878, 19.830829334577729, null, 1.0164590921625576m, 6.269772816844689m },
                    { new Guid("9b8bcc30-f7a5-41f2-940b-f9edde3cc91a"), "Cadillac", 0, "Olga", "Kristen", 45.29340112834867, 19.822498825540769, null, 1.6875309773099558m, 6.45756305740285m },
                    { new Guid("9c1ea92c-c082-4207-a832-9bfa3eed5819"), "Cadillac", 0, "Olga", "Kristen", 45.29340112834867, 19.822498825540769, null, 1.6875309773099558m, 6.45756305740285m },
                    { new Guid("9d9a7e19-4835-4073-a81b-648bf307ca58"), "Aston Martin Lagonda Ltd", 0, "Elliot", "Loiselin", 45.222723321894421, 19.793603471598757, null, 1.5879618679964944m, 2.4186214661952135m },
                    { new Guid("9e1c1fc6-0830-4500-b243-e238cf46cc7c"), "Lamborghini", 0, "Aparna", "Segundo", 45.225215199148884, 19.883468373193303, null, 1.2154110733189056m, 3.652480026698223m },
                    { new Guid("9e98f657-824b-46e1-b635-4fef3929645a"), "Mini", 0, "Larae", "Lindsey", 45.288988349342716, 19.869009669621189, null, 1.2705361960792216m, 3.7409616159613304m },
                    { new Guid("9f8b56ae-b4ef-43c4-bd88-00a37f371b55"), "Audi", 0, "Beata", "Salome", 45.29945492843008, 19.844297003241515, null, 1.0417866558859206m, 1.2473101141077794m },
                    { new Guid("a0a18bd9-f8bd-4c70-8746-196b8310e948"), "Bentley", 0, "Liliya", "Yeliz", 45.278508705345807, 19.806480944684065, null, 1.7553152421709535m, 4.360324081230656m }
                });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Driver_ID", "Brand", "DriverStatus", "FirstName", "LastName", "Latitude", "Longitude", "PassengerId", "PricePerKM", "StartPrice" },
                values: new object[,]
                {
                    { new Guid("a3007e2f-ab07-45b2-bc03-4aa4c1f7b57c"), "Aston Martin Lagonda Ltd", 0, "Leonard", "Emerald", 45.2572972194831, 19.855507893571811, null, 1.2124823508556823m, 10.14906639309747m },
                    { new Guid("a6437c91-f79f-4084-ba57-171a2d856cec"), "Ford", 0, "Leif", "Nalini", 45.281617289392479, 19.841755384683445, null, 1.0236099738160866m, 2.7658329456040622m },
                    { new Guid("a72c98eb-7277-47c1-aa4a-52aaccffc203"), "Cadillac", 0, "Misael", "Gizelle", 45.260938791275308, 19.796892550971364, null, 1.0686156356587282m, 4.528765037827812m },
                    { new Guid("a73aab84-88fd-4e12-96db-2bc252009b82"), "Jaguar", 0, "Mannix", "Gisella", 45.296266247572717, 19.804770086487757, null, 1.6910908453429156m, 3.2823166597464395m },
                    { new Guid("a7ae1750-2a3f-45fa-8c4c-2eae89609d9b"), "BMW", 0, "Alessandro", "Ame", 45.213878946434399, 19.83500906624565, null, 1.1394055188065981m, 10.629290075265152m },
                    { new Guid("a91cc8a6-747b-4cf4-81a3-a1193755fadf"), "Dodge", 0, "Andreas", "Adolfo", 45.265939837651047, 19.832946913832068, null, 1.7380170039298m, 8.510688070544214m },
                    { new Guid("ac6aa112-5704-49a5-9fc6-690a290970ce"), "INFINITI", 0, "Jastinder", "Homero", 45.269815899190036, 19.810080082882855, null, 1.5244558202271907m, 1.9469998885842523m },
                    { new Guid("ae893044-ab75-4563-a906-3716217f5a95"), "Jeep", 0, "Greening", "Brockie", 45.275815226573968, 19.811590339120048, null, 1.1547939566454073m, 4.416711302958615m },
                    { new Guid("aeab3cbc-64ba-41ca-9ffb-a238e8c776fc"), "MAZDA", 0, "Megpg", "Eunice", 45.219490140494258, 19.798772403836473, null, 1.3455814143383005m, 9.776292871306692m },
                    { new Guid("afcba7d0-4cb0-4110-8a03-a5119c7eba32"), "Chevrolet", 0, "Jerome", "Hoj", 45.26187929944556, 19.852975472519034, null, 1.332259599316662m, 4.833445837024005m },
                    { new Guid("b15f9baa-63d2-4380-adfd-bac000d901f4"), "FIAT", 0, "Harold", "Karl", 45.286324628710155, 19.859015812248142, null, 1.7153672461915734m, 9.684974884213723m },
                    { new Guid("b253f1bb-87c0-40de-9e27-143b3b508445"), "Aston Martin Lagonda Ltd", 0, "Knox", "Lorrie", 45.264656353292338, 19.837986673820598, null, 1.536456046701279m, 4.863201684677997m },
                    { new Guid("b5253883-a0f3-4125-8614-1ee7aa5dc2b0"), "Jeep", 0, "Greening", "Brockie", 45.275815226573968, 19.811590339120048, null, 1.1547939566454073m, 4.416711302958615m },
                    { new Guid("b5bad2d4-2415-485e-a913-49cbeda39e72"), "Porsche", 0, "Vlada", "Marisela", 45.275549215170642, 19.878672958375621, null, 1.692150219149442m, 4.292175821808732m },
                    { new Guid("b62344d2-8dc3-4d84-b20a-06f3e301cad9"), "GMC", 0, "Brehan", "Leonardo", 45.284932615672936, 19.861347707346106, null, 1.0165564995215457m, 10.543527811952874m },
                    { new Guid("b6bda5a4-6626-4afb-b725-9653290eccba"), "Acura", 0, "Anais", "Johnna", 45.287676498702332, 19.843019007354567, null, 1.1278655668254658m, 10.710397156830041m },
                    { new Guid("b7aa004c-428f-4726-a7b9-c8134f46c637"), "Chevrolet", 0, "Trace", "Gerry", 45.290891491829363, 19.828444245832451, null, 1.6389965205075372m, 8.368466873577997m },
                    { new Guid("b853bf5a-e953-47ed-9ed4-b1f4ffbf300e"), "RAM", 0, "Welch", "Vaishali", 45.226846241954064, 19.839414266674314, null, 1.3494145070278685m, 3.1034505930423064m },
                    { new Guid("b8c99143-e930-4f18-b162-c94f287c89ef"), "Jeep", 0, "Jurg", "Colleen", 45.27947091909018, 19.803280137550804, null, 1.0642568736345543m, 1.1178482649382784m },
                    { new Guid("ba3f0738-5f78-4b5f-97b0-c48d8c369118"), "McLaren", 0, "Flora", "Allesdandro", 45.250220306572913, 19.80629652423562, null, 1.6560543096854814m, 9.747141997226342m },
                    { new Guid("bdce2357-4f5b-4aa7-87e3-34ec1344b58d"), "Mini", 0, "Jerildy", "Tzipora", 45.26373409468961, 19.820524995264094, null, 1.6770837896990307m, 3.156359811608757m },
                    { new Guid("be51daab-a061-4bbe-be49-6f8881a18c7e"), "Volvo", 0, "Zena", "Kirstein", 45.238319779725494, 19.810359597732457, null, 1.7020772550670218m, 10.79799094974425m },
                    { new Guid("c22b3f05-02e8-49c6-99f1-0bae6b28766b"), "Land Rover", 0, "Maurits", "Anurag", 45.253925064457675, 19.828862737626718, null, 1.7104501368390608m, 4.2596837052732415m },
                    { new Guid("c2ee96ca-acf4-4be7-ada4-337b4efa9c71"), "Pagani Automobili S.p.A.", 0, "Morrissey", "Kellie", 45.274651670577768, 19.791858685850482, null, 1.3417230653533827m, 2.18234253206158m },
                    { new Guid("c33576be-042b-4e24-8dad-eb03a06a2e94"), "INFINITI", 0, "Haas", "Chad", 45.288022877311491, 19.874835733268696, null, 1.5866952090365798m, 8.087357945507915m },
                    { new Guid("c34e9263-c7af-4550-a535-71ff905a0230"), "Mitsubishi Motors Corporation", 0, "Yev", "Leeann", 45.243827207876294, 19.795146332823769, null, 1.4038353529833358m, 7.1267708754257715m },
                    { new Guid("c58714bc-588d-4d50-af7b-b32c7087874c"), "Honda", 0, "Marin", "Jesus", 45.296192164092709, 19.814406778655229, null, 1.308227287026685m, 3.9326792288937376m },
                    { new Guid("c61b0d8d-42fd-47da-8e69-3a2ff6030ff0"), "Chrysler", 0, "Ibrahim", "Alina", 45.2993118675817, 19.796265612687975, null, 1.1089619486674978m, 10.521486246480235m },
                    { new Guid("c696e618-07ba-4d54-a310-4c47b16d1f74"), "RAM", 0, "Renata", "Yadi", 45.296758424609912, 19.847822587069356, null, 1.5933840239464465m, 3.1678197529395926m },
                    { new Guid("cb75324b-060c-4b53-9567-ba5f7a9a7cee"), "Bentley", 0, "Brandy", "Eleanor", 45.299538969878988, 19.880643245594662, null, 1.6281722977710191m, 5.728713211147051m },
                    { new Guid("cc0f87a9-ca69-4f24-b7f2-aea6c4a87b5c"), "Subaru", 0, "Lombardet", "Casandra", 45.250568287681887, 19.824187873005126, null, 1.6563058877839092m, 10.512932624252946m },
                    { new Guid("cebe4ad1-2bbe-48a1-afdb-5f05809fc704"), "INFINITI", 0, "Bici", "Travis", 45.201686751190202, 19.802496053471067, null, 1.2016309984417113m, 10.491378188758173m },
                    { new Guid("d0622614-5cd2-4943-a7f0-3f10d8ed2b19"), "Mini", 0, "Jerildy", "Tzipora", 45.26373409468961, 19.820524995264094, null, 1.6770837896990307m, 3.156359811608757m },
                    { new Guid("d4047fbd-df99-45b5-b5e3-ca128a98d1f1"), "Dodge", 0, "Construccion", "Petty", 45.227061274337601, 19.836243969656948, null, 1.0452853161733882m, 3.69863700318812m },
                    { new Guid("d4ad2298-235e-4683-ae0d-22d222437e1e"), "Chevrolet", 0, "Krizia", "Brusovanik", 45.267957633744437, 19.799666210958843, null, 1.6786208486121708m, 7.342233447742731m },
                    { new Guid("d54cc5e9-a4e6-48de-920e-d052fc952ec7"), "Lincoln", 0, "Gert", "Andres", 45.279225594403293, 19.790054798757847, null, 1.1643840016635394m, 1.328847558195744m },
                    { new Guid("d5d429fa-5232-4774-91b9-86222ad15ea9"), "Aston Martin Lagonda Ltd", 0, "Elliot", "Loiselin", 45.222723321894421, 19.793603471598757, null, 1.5879618679964944m, 2.4186214661952135m },
                    { new Guid("d644d760-446b-4767-a589-2668d90a9a8e"), "INFINITI", 0, "Bici", "Travis", 45.201686751190202, 19.802496053471067, null, 1.2016309984417113m, 10.491378188758173m },
                    { new Guid("d65015d1-ce53-4aa3-b01b-5d9cd586a167"), "Pagani Automobili S.p.A.", 0, "Jamison", "Ash", 45.278270343256636, 19.852105063006313, null, 1.3374700364494403m, 8.12755415792042m },
                    { new Guid("d692eff7-c77c-4bf6-b00e-ecf5242ae23b"), "Aston Martin Lagonda Ltd", 0, "Pauline", "Gunnar", 45.216454140074177, 19.848281178208055, null, 1.7036066928092553m, 4.427610056630678m },
                    { new Guid("d6ca8306-da20-4560-bb9b-577b8187137f"), "Subaru", 0, "Luz", "Jacqui", 45.282357438284876, 19.870750281402625, null, 1.3275739312198804m, 7.389799555041893m },
                    { new Guid("d823521a-96eb-4a80-848e-ba077a925c09"), "Porsche", 0, "Jen", "Shar", 45.210580578767569, 19.787137195434291, null, 1.7006360867551042m, 9.781009068780087m }
                });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Driver_ID", "Brand", "DriverStatus", "FirstName", "LastName", "Latitude", "Longitude", "PassengerId", "PricePerKM", "StartPrice" },
                values: new object[,]
                {
                    { new Guid("db4877e3-d780-430d-a455-ec86f1bc3fc4"), "Volvo", 0, "Emma", "Tasha", 45.285854370015166, 19.866548271059557, null, 1.0566431268333218m, 8.509215393598028m },
                    { new Guid("dcda0636-b405-4f2b-ba96-ed376f5f1f7d"), "MASERATI", 0, "Magali", "Vibeke", 45.21619104847931, 19.788370458607901, null, 1.6719496977709882m, 4.795675055141949m },
                    { new Guid("ddf5b15d-92af-4eaa-8d9f-ff368a5333a9"), "Honda", 0, "Talbot", "Carwen", 45.250169050776421, 19.794775524085665, null, 1.4473141471090796m, 4.881600711969098m },
                    { new Guid("e1e27950-d146-4e9a-9c56-2dfaf88514f3"), "Chrysler", 0, "Russell", "Rune", 45.223988703409404, 19.821203339044121, null, 1.669900944787707m, 7.442289794627493m },
                    { new Guid("e2277f64-498a-4e6d-abd2-ddafd6e59c16"), "Subaru", 0, "Lombardet", "Casandra", 45.250568287681887, 19.824187873005126, null, 1.6563058877839092m, 10.512932624252946m },
                    { new Guid("e2617225-eb8b-4baa-9061-ffd04dba658d"), "Ford", 0, "Leif", "Nalini", 45.281617289392479, 19.841755384683445, null, 1.0236099738160866m, 2.7658329456040622m },
                    { new Guid("e337beef-9b60-49d0-9270-61f95439620d"), "MASERATI", 0, "Residencia", "Casper", 45.229981095425153, 19.837153864471194, null, 1.554999380283847m, 9.574431191837565m },
                    { new Guid("e5d81d7a-ce8d-4fc2-994f-6af35b1de2c3"), "Audi", 0, "Marc", "Erin", 45.262776103747605, 19.866401987510415, null, 1.0237952565130846m, 1.8608874905715336m },
                    { new Guid("e6df56e9-3d93-450d-9533-77c41418433a"), "Dodge", 0, "Construccion", "Petty", 45.227061274337601, 19.836243969656948, null, 1.0452853161733882m, 3.69863700318812m },
                    { new Guid("e703f427-19cf-4c34-869e-f46977972f83"), "BMW", 0, "Jacques", "Lane", 45.213790253612132, 19.79774102895696, null, 1.7987752163597301m, 4.055436177433148m },
                    { new Guid("e7631502-81e2-4dbb-ac32-0a13cb2f2280"), "Lamborghini", 0, "Ilhan", "Reserved", 45.269939911723235, 19.805821814574692, null, 1.7714084180476508m, 8.149353140401365m },
                    { new Guid("e9381f9a-44b8-4dd2-bcb0-43c6646db647"), "NISSAN", 0, "Rasika", "Raimundo", 45.291779211384224, 19.800023095935906, null, 1.0891868325268717m, 4.793560726767151m },
                    { new Guid("e9623c29-fb07-4aeb-b91e-5e221bd26e00"), "Ford", 0, "Cora", "Otra", 45.278586743787962, 19.802530466611248, null, 1.7253447233445418m, 10.91510684753183m },
                    { new Guid("ea40f9ce-5a45-4315-8a17-87f42bc77c03"), "SCION", 0, "Vanessa", "Moran", 45.243401442719865, 19.845486901252453, null, 1.766625245740726m, 1.5974547157697985m },
                    { new Guid("ea6d6f01-3aa4-4290-b034-d7c0922aefe5"), "Aston Martin Lagonda Ltd", 0, "Pauline", "Gunnar", 45.216454140074177, 19.848281178208055, null, 1.7036066928092553m, 4.427610056630678m },
                    { new Guid("eade4beb-8cdd-4578-b3c1-697456d60511"), "Bentley", 0, "Lupita", "Bennet", 45.280486776875811, 19.844408581896609, null, 1.1702439175398553m, 10.496768111188889m },
                    { new Guid("ec0ecdb1-2550-437b-bd1e-6c92ba54b6ea"), "Aston Martin Lagonda Ltd", 0, "Knox", "Lorrie", 45.264656353292338, 19.837986673820598, null, 1.536456046701279m, 4.863201684677997m },
                    { new Guid("ee2c3533-b9e5-4311-9b40-bb9f0297c1c4"), "Audi", 0, "Carling", "Angeles", 45.256456267336631, 19.839344022449293, null, 1.2919937229218867m, 3.8797762168830876m },
                    { new Guid("ef94ce3c-e804-4326-8f23-f7af5c03776b"), "TOYOTA", 0, "Aden", "Eliza", 45.268648133812405, 19.831866095348715, null, 1.391490893102681m, 8.095125839709704m },
                    { new Guid("f106b059-d236-46e6-b5a7-108b07774187"), "MAZDA", 0, "Megpg", "Eunice", 45.219490140494258, 19.798772403836473, null, 1.3455814143383005m, 9.776292871306692m },
                    { new Guid("f5481417-4c1d-4ab4-b9c0-71c9966e5a13"), "Porsche", 0, "Walker", "Maruk", 45.217759832566678, 19.812095479197652, null, 1.0201468787267918m, 8.987330756776993m },
                    { new Guid("f6330dc0-001d-460a-8b39-a17c534cc082"), "MASERATI", 0, "Vartan", "Rhee", 45.298049374458131, 19.878864637212104, null, 1.5393415373611448m, 6.559482220099541m },
                    { new Guid("f93b3c0b-7746-4e29-894b-259a8dee5b81"), "Mercedes-Benz", 0, "Fernanda", "Berry", 45.284341031601357, 19.88214656986014, null, 1.228808543535298m, 2.642344591342897m },
                    { new Guid("f9a2ce77-8a24-4cbc-b7e7-ff7b3b656493"), "Aston Martin Lagonda Ltd", 0, "Leonard", "Emerald", 45.2572972194831, 19.855507893571811, null, 1.2124823508556823m, 10.14906639309747m },
                    { new Guid("f9cc8b2b-6645-4af4-8f22-84b8baf48ce4"), "Mercedes-Benz", 0, "Osvando", "Nicolaios", 45.216763399661289, 19.839646217936401, null, 1.390698997245516m, 2.4629580725247315m },
                    { new Guid("f9d172b9-d1d0-4513-9c8a-6280953e0e06"), "Chrysler", 0, "Russell", "Rune", 45.223988703409404, 19.821203339044121, null, 1.669900944787707m, 7.442289794627493m },
                    { new Guid("fa93dd86-276e-4579-91ba-8d1551906a1b"), "Mini", 0, "Dianna", "Michal", 45.247323100321054, 19.842409377101806, null, 1.0397465494006515m, 5.223227457896003m },
                    { new Guid("facf229b-3063-4351-a7ab-aa38c6ab9d41"), "Volvo", 0, "Emma", "Tasha", 45.285854370015166, 19.866548271059557, null, 1.0566431268333218m, 8.509215393598028m },
                    { new Guid("fbd6605d-9b81-456d-8d12-8c0d063b91fe"), "Lincoln", 0, "Gert", "Andres", 45.279225594403293, 19.790054798757847, null, 1.1643840016635394m, 1.328847558195744m },
                    { new Guid("fc5aa968-e764-4ba3-9ac1-bb09fba5f6b4"), "Volvo", 0, "Jessa", "Tetiana", 45.228208563610373, 19.864794930227959, null, 1.4501630881251706m, 4.989849053623997m },
                    { new Guid("fc77713e-0f32-44a1-9776-2f723d9d76c1"), "Mitsubishi Motors Corporation", 0, "Bechmann", "Maikol", 45.279071426502327, 19.862370160619843, null, 1.324328579217307m, 4.565442360558393m },
                    { new Guid("fe5b9cab-3bc9-4401-bb6c-677e0361ae15"), "MAZDA", 0, "Callaghan", "Aiden", 45.215384546791014, 19.846282477003452, null, 1.7442378744022409m, 4.395966844983313m }
                });

            migrationBuilder.InsertData(
                table: "Passengers",
                columns: new[] { "PassengerId", "Birthday", "Email", "FirstName", "Lastname", "PassengersLatitude", "PassengersLongitude" },
                values: new object[,]
                {
                    { new Guid("1c27245f-f4eb-415f-81e1-84a26f99c99c"), new DateTime(1987, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "ana@example.com", "Ana", "Ivanovic", 44.786568287681888, 20.448921673005128 },
                    { new Guid("1d95e8e3-9727-4261-91d8-58eccddd189e"), new DateTime(1990, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "marko@example.com", "Marko", "Petrovic", 43.32090222876819, 21.895758973005126 },
                    { new Guid("4e976325-6cbe-4796-b659-88ecee425a25"), new DateTime(1993, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "raca93@gmail.com", "Radivoje", "Bjelic", 45.290568287681893, 19.924187873005128 },
                    { new Guid("962ce67c-2618-4d8f-b5c3-4949c42751ba"), new DateTime(1992, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "jelena@example.com", "Jelena", "Jankovic", 44.012793528768192, 20.91142273005126 },
                    { new Guid("d229912b-cc98-4a43-9c1c-f4f3e72eb4a7"), new DateTime(1994, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "marija@example.com", "Marija", "Maric", 44.01652128768189, 21.00585973005126 },
                    { new Guid("fd2fbcb9-fbaa-4a46-b181-40d19a69c7d0"), new DateTime(1985, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "nikola@example.com", "Nikola", "Nikolic", 45.26713522876819, 19.833549673005127 }
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

            migrationBuilder.CreateIndex(
                name: "IX_Drivers_PassengerId",
                table: "Drivers",
                column: "PassengerId");

            migrationBuilder.CreateIndex(
                name: "IX_Passengers_Email",
                table: "Passengers",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rides_Driver_ID",
                table: "Rides",
                column: "Driver_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Rides_PassengerId",
                table: "Rides",
                column: "PassengerId");

            migrationBuilder.CreateIndex(
                name: "IX_Rides_PassengerId1",
                table: "Rides",
                column: "PassengerId1");

            migrationBuilder.CreateIndex(
                name: "IX_Rides_PassengerRatingRatingId",
                table: "Rides",
                column: "PassengerRatingRatingId");
        }

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

            migrationBuilder.DropTable(
                name: "Rides");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Drivers");

            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DropTable(
                name: "Passengers");
        }
    }
}
