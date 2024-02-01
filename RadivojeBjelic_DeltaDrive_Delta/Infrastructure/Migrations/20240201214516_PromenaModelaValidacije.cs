using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class PromenaModelaValidacije : Migration
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
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    StatusMessage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PassengerRatingRatingId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Driver_ID1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rides", x => x.RideId);
                    table.ForeignKey(
                        name: "FK_Rides_Drivers_Driver_ID1",
                        column: x => x.Driver_ID1,
                        principalTable: "Drivers",
                        principalColumn: "Driver_ID");
                    table.ForeignKey(
                        name: "FK_Rides_Passengers_PassengerId",
                        column: x => x.PassengerId,
                        principalTable: "Passengers",
                        principalColumn: "PassengerId",
                        onDelete: ReferentialAction.Cascade);
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
                    { new Guid("0257a181-e637-48ca-81a6-52481edc38c1"), "Lamborghini", 0, "Aparna", "Segundo", 45.225215199148884, 19.883468373193303, null, 1.2154110733189056m, 3.652480026698223m },
                    { new Guid("037e2939-365c-4406-859c-c2d365dc9f1f"), "Audi", 0, "Beata", "Salome", 45.29945492843008, 19.844297003241515, null, 1.0417866558859206m, 1.2473101141077794m },
                    { new Guid("047e1314-bd73-4f0a-8998-3e19d4d14c87"), "NISSAN", 0, "Rasika", "Raimundo", 45.291779211384224, 19.800023095935906, null, 1.0891868325268717m, 4.793560726767151m },
                    { new Guid("04a395e1-0778-4b63-babc-f4138650a1bd"), "LEXUS", 0, "Raina", "Lula", 45.223453054301878, 19.830829334577729, null, 1.0164590921625576m, 6.269772816844689m },
                    { new Guid("0501a975-806f-4e9e-833b-1690b6867d5a"), "TOYOTA", 0, "Aden", "Eliza", 45.268648133812405, 19.831866095348715, null, 1.391490893102681m, 8.095125839709704m },
                    { new Guid("05f554f1-3fd9-489d-bbdc-27c65131ce47"), "Porsche", 0, "Chrissy", "Tanyia", 45.279449168518042, 19.785822522191463, null, 1.4492458808602435m, 2.028265801352166m },
                    { new Guid("09da16c9-51b6-4181-8e79-37998442c739"), "Chrysler", 0, "Ibrahim", "Alina", 45.2993118675817, 19.796265612687975, null, 1.1089619486674978m, 10.521486246480235m },
                    { new Guid("0d521093-cf60-43fa-81fc-9c4afe2661fc"), "MASERATI", 0, "Residencia", "Casper", 45.229981095425153, 19.837153864471194, null, 1.554999380283847m, 9.574431191837565m },
                    { new Guid("0d531ac0-832c-4c25-a724-dc099d03c6c2"), "BMW", 0, "Alessandro", "Ame", 45.213878946434399, 19.83500906624565, null, 1.1394055188065981m, 10.629290075265152m },
                    { new Guid("0df725a8-7f1a-4479-865d-aebb9d683908"), "Lincoln", 0, "Javid", "Tranta", 45.216149699839988, 19.853299911074188, null, 1.214353703785661m, 4.696927726796888m },
                    { new Guid("0e67f96b-f4d5-4c06-b3db-15a95ffac4bb"), "Mitsubishi Motors Corporation", 0, "Bechmann", "Maikol", 45.279071426502327, 19.862370160619843, null, 1.324328579217307m, 4.565442360558393m },
                    { new Guid("0f920701-c0e8-4877-b310-a96f1e996641"), "Aston Martin Lagonda Ltd", 0, "Leonard", "Emerald", 45.2572972194831, 19.855507893571811, null, 1.2124823508556823m, 10.14906639309747m },
                    { new Guid("11efbb99-f0d0-477e-b38d-d23f046616c6"), "Mini", 0, "Jerildy", "Tzipora", 45.26373409468961, 19.820524995264094, null, 1.6770837896990307m, 3.156359811608757m },
                    { new Guid("12a0f015-7477-48b9-b7ad-c3821bf28d6d"), "Pagani Automobili S.p.A.", 0, "Jamison", "Ash", 45.278270343256636, 19.852105063006313, null, 1.3374700364494403m, 8.12755415792042m },
                    { new Guid("13a14c45-a540-40e5-9308-8ccefe282cea"), "Jaguar", 0, "Dilini", "Joy", 45.204205166231176, 19.821658287825695, null, 1.5632855538691586m, 9.828321299882433m },
                    { new Guid("13ab10a7-80bf-4126-b8d0-e6835daf9deb"), "Mini", 0, "Dianna", "Michal", 45.247323100321054, 19.842409377101806, null, 1.0397465494006515m, 5.223227457896003m },
                    { new Guid("13d914a6-730b-47d6-9c87-bc9fd1d4bd2a"), "Mitsubishi Motors Corporation", 0, "Yev", "Leeann", 45.243827207876294, 19.795146332823769, null, 1.4038353529833358m, 7.1267708754257715m },
                    { new Guid("14b4ae09-9a6d-4972-90df-5e1926e61b9b"), "INFINITI", 0, "Jastinder", "Homero", 45.269815899190036, 19.810080082882855, null, 1.5244558202271907m, 1.9469998885842523m },
                    { new Guid("16217199-b78a-421b-9b9b-7dfed03b83f2"), "LEXUS", 0, "Raina", "Lula", 45.223453054301878, 19.830829334577729, null, 1.0164590921625576m, 6.269772816844689m },
                    { new Guid("1856faeb-11bf-45b1-b7e0-e3b76c28bcc6"), "Volvo", 0, "Zena", "Kirstein", 45.238319779725494, 19.810359597732457, null, 1.7020772550670218m, 10.79799094974425m },
                    { new Guid("19fcb926-4232-4862-a2e4-2bda4777fded"), "CHEVROLET", 0, "Edouard", "Jehan", 45.210031240196187, 19.819412677818654, null, 1.2289611665909137m, 10.316446613551822m },
                    { new Guid("1bcf86d6-42c3-4521-bc6b-358a8c9f1d32"), "Jeep", 0, "Jurg", "Colleen", 45.27947091909018, 19.803280137550804, null, 1.0642568736345543m, 1.1178482649382784m },
                    { new Guid("1cc9e684-152f-4acd-bc2c-b6ffeb739836"), "ALFA ROMEO", 0, "Allison", "Royden", 45.295945743171906, 19.857674174593402, null, 1.5237046745427651m, 10.405094574404158m },
                    { new Guid("1dc6c75e-bd98-4491-b4c2-1cdd1c2db2b6"), "Bentley", 0, "Lupita", "Bennet", 45.280486776875811, 19.844408581896609, null, 1.1702439175398553m, 10.496768111188889m },
                    { new Guid("1f14df0e-c211-413a-ae76-466aa01b7503"), "RAM", 0, "Welch", "Vaishali", 45.226846241954064, 19.839414266674314, null, 1.3494145070278685m, 3.1034505930423064m },
                    { new Guid("2008f709-915b-4c55-a035-341b99736c7f"), "Dodge", 0, "Andreas", "Adolfo", 45.265939837651047, 19.832946913832068, null, 1.7380170039298m, 8.510688070544214m },
                    { new Guid("21a7b1d4-0926-4b17-8a0a-aeeba4b168b2"), "Pagani Automobili S.p.A.", 0, "Morrissey", "Kellie", 45.274651670577768, 19.791858685850482, null, 1.3417230653533827m, 2.18234253206158m },
                    { new Guid("236da0dd-ce7d-4279-960c-9cd500e83914"), "Roush", 0, "Rossane", "Jessica", 45.266559868005444, 19.829707954977223, null, 1.504112436608676m, 9.364469311550952m },
                    { new Guid("23901611-9023-4269-89eb-595463044872"), "Jaguar", 0, "Mannix", "Gisella", 45.296266247572717, 19.804770086487757, null, 1.6910908453429156m, 3.2823166597464395m },
                    { new Guid("24ef880a-6495-4168-af77-2299234ddc2a"), "Chevrolet", 0, "Jerome", "Hoj", 45.26187929944556, 19.852975472519034, null, 1.332259599316662m, 4.833445837024005m },
                    { new Guid("28075456-40d7-4c03-9314-ba60f6a5f50c"), "Honda", 0, "Marin", "Jesus", 45.296192164092709, 19.814406778655229, null, 1.308227287026685m, 3.9326792288937376m },
                    { new Guid("2848ac4e-d9d1-4506-bff7-995f1cc3668f"), "MASERATI", 0, "Magali", "Vibeke", 45.21619104847931, 19.788370458607901, null, 1.6719496977709882m, 4.795675055141949m },
                    { new Guid("2aeae572-d6c2-486f-89d5-f777a64cb7fe"), "Honda", 0, "Libbey", "Ernest", 45.282891901118944, 19.876434018077504, null, 1.2475192510221107m, 5.449373131830329m },
                    { new Guid("2c907d4e-48ee-4ef8-b5d9-02749dcdfbf1"), "Audi", 0, "Marc", "Erin", 45.262776103747605, 19.866401987510415, null, 1.0237952565130846m, 1.8608874905715336m },
                    { new Guid("2e65f94a-e407-43d9-a39f-ec1ba5b0cd03"), "Chevrolet", 0, "Krizia", "Brusovanik", 45.267957633744437, 19.799666210958843, null, 1.6786208486121708m, 7.342233447742731m },
                    { new Guid("303509ff-0d13-45a8-aafd-1828b43b24b7"), "Roush", 0, "Evangeline", "Granados", 45.255782205655841, 19.854106076392526, null, 1.7553795014338474m, 6.146249025698085m },
                    { new Guid("3067a983-b37d-4f51-bb44-f6192616c56b"), "RAM", 0, "Welch", "Vaishali", 45.226846241954064, 19.839414266674314, null, 1.3494145070278685m, 3.1034505930423064m },
                    { new Guid("30e2327b-4d2c-4d97-a3f8-5852bc908256"), "Volvo", 0, "Emma", "Tasha", 45.285854370015166, 19.866548271059557, null, 1.0566431268333218m, 8.509215393598028m },
                    { new Guid("31839cb1-7714-4412-a071-e8d1a0abf910"), "Subaru", 0, "Luz", "Jacqui", 45.282357438284876, 19.870750281402625, null, 1.3275739312198804m, 7.389799555041893m },
                    { new Guid("36c67373-ca70-4097-9d93-1b8f450f7d84"), "BMW", 0, "Jacques", "Lane", 45.213790253612132, 19.79774102895696, null, 1.7987752163597301m, 4.055436177433148m },
                    { new Guid("3a69018c-2775-4cd4-8334-b93643b75880"), "SCION", 0, "Vanessa", "Moran", 45.243401442719865, 19.845486901252453, null, 1.766625245740726m, 1.5974547157697985m },
                    { new Guid("3af2d0c3-e671-446a-8b29-fc417dfdfbfb"), "Subaru", 0, "Lombardet", "Casandra", 45.250568287681887, 19.824187873005126, null, 1.6563058877839092m, 10.512932624252946m }
                });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Driver_ID", "Brand", "DriverStatus", "FirstName", "LastName", "Latitude", "Longitude", "PassengerId", "PricePerKM", "StartPrice" },
                values: new object[,]
                {
                    { new Guid("3b2e7354-08c0-4299-a22f-624bce82473d"), "Volvo", 0, "Lluvia", "Judd", 45.244554013188768, 19.872895707350001, null, 1.253412375617725m, 5.882144460892146m },
                    { new Guid("3b31a6c5-eb9a-4d3a-9af3-23edc79fe62b"), "Bentley", 0, "Lupita", "Bennet", 45.280486776875811, 19.844408581896609, null, 1.1702439175398553m, 10.496768111188889m },
                    { new Guid("3d665388-a702-4ad3-900f-8be6db40626a"), "MASERATI", 0, "Vartan", "Rhee", 45.298049374458131, 19.878864637212104, null, 1.5393415373611448m, 6.559482220099541m },
                    { new Guid("409b283a-0bcf-4b06-8581-f6713a239824"), "Ford", 0, "Leif", "Nalini", 45.281617289392479, 19.841755384683445, null, 1.0236099738160866m, 2.7658329456040622m },
                    { new Guid("4165e79b-5ef4-4e5d-b061-344ac04bca7e"), "Volkswagen", 0, "Werner", "Inde", 45.221608244262498, 19.819591497862248, null, 1.3967480906659557m, 4.545871705956596m },
                    { new Guid("46338423-6450-4fb5-9fcc-2b5e85358b5e"), "NISSAN", 0, "Rasika", "Raimundo", 45.291779211384224, 19.800023095935906, null, 1.0891868325268717m, 4.793560726767151m },
                    { new Guid("472c2d99-ca7f-4eec-8936-d954edf947e0"), "Dodge", 0, "Andreas", "Adolfo", 45.265939837651047, 19.832946913832068, null, 1.7380170039298m, 8.510688070544214m },
                    { new Guid("475791f2-cc86-4462-ba76-a341354fb680"), "INFINITI", 0, "Deepti", "Devara", 45.275913260410107, 19.85081695839504, null, 1.6342564595450453m, 10.57353943753355m },
                    { new Guid("47f26264-e470-404d-b6d7-8c9826f6746d"), "Volvo", 0, "Jessa", "Tetiana", 45.228208563610373, 19.864794930227959, null, 1.4501630881251706m, 4.989849053623997m },
                    { new Guid("4b25b687-2e13-4d61-b445-5727ba334594"), "BMW", 0, "Alessandro", "Ame", 45.213878946434399, 19.83500906624565, null, 1.1394055188065981m, 10.629290075265152m },
                    { new Guid("4cf2b3c5-ba5b-4afd-ae5f-36a3c4722e87"), "Roush", 0, "Rossane", "Jessica", 45.266559868005444, 19.829707954977223, null, 1.504112436608676m, 9.364469311550952m },
                    { new Guid("4dd78189-a296-4eb2-b5da-b272b38ca37c"), "ALFA ROMEO", 0, "Allison", "Royden", 45.295945743171906, 19.857674174593402, null, 1.5237046745427651m, 10.405094574404158m },
                    { new Guid("4f766e9f-bf86-44a7-bf86-e778bf7ea88d"), "Jeep", 0, "Greening", "Brockie", 45.275815226573968, 19.811590339120048, null, 1.1547939566454073m, 4.416711302958615m },
                    { new Guid("500fdebb-83ed-4fe7-8980-83fb82a22634"), "Acura", 0, "Anais", "Johnna", 45.287676498702332, 19.843019007354567, null, 1.1278655668254658m, 10.710397156830041m },
                    { new Guid("504ab627-321e-470a-b028-4ad858131d6a"), "Mini", 0, "Maurits", "Paulien", 45.296887928208001, 19.858852384808518, null, 1.7376903735062375m, 4.928084949383901m },
                    { new Guid("52231655-947f-49c7-b696-b33411720e1c"), "Porsche", 0, "Jen", "Shar", 45.210580578767569, 19.787137195434291, null, 1.7006360867551042m, 9.781009068780087m },
                    { new Guid("56b14391-946c-4b82-b29e-1ea7bd3cb516"), "Porsche", 0, "Lily", "Eugenia", 45.257195153791159, 19.808529545036901, null, 1.7101176770777686m, 2.275882597440534m },
                    { new Guid("5880f8db-3431-4bd1-9b0c-1fb1459a93f4"), "Dodge", 0, "Construccion", "Petty", 45.227061274337601, 19.836243969656948, null, 1.0452853161733882m, 3.69863700318812m },
                    { new Guid("5af7f6cb-abed-459e-af74-2ec1d3690a17"), "INFINITI", 0, "Deepti", "Devara", 45.275913260410107, 19.85081695839504, null, 1.6342564595450453m, 10.57353943753355m },
                    { new Guid("5b10f107-e3e6-4eaf-a413-4b5d128f119f"), "Lamborghini", 0, "Ilhan", "Reserved", 45.269939911723235, 19.805821814574692, null, 1.7714084180476508m, 8.149353140401365m },
                    { new Guid("5c05a624-7675-41ff-912f-6beeab5a969d"), "Acura", 0, "Jasmine", "Dorothy", 45.209423511503424, 19.81749485016757, null, 1.3610869109414416m, 7.115251420780801m },
                    { new Guid("5ce3d565-80ec-4221-af60-8d8f8766ddcb"), "MAZDA", 0, "Callaghan", "Aiden", 45.215384546791014, 19.846282477003452, null, 1.7442378744022409m, 4.395966844983313m },
                    { new Guid("5e5791f9-4ffb-405a-a54a-1632a370892a"), "MAZDA", 0, "Rafal", "Monserrat", 45.282153330425473, 19.800982908909283, null, 1.0444604099295751m, 6.848472092200129m },
                    { new Guid("6155e95a-9e62-4d09-a88b-1293638104ea"), "Mitsubishi Motors Corporation", 0, "Yev", "Leeann", 45.243827207876294, 19.795146332823769, null, 1.4038353529833358m, 7.1267708754257715m },
                    { new Guid("61827538-6a7d-412c-8bde-4f32b7bd4509"), "Land Rover", 0, "Maurits", "Anurag", 45.253925064457675, 19.828862737626718, null, 1.7104501368390608m, 4.2596837052732415m },
                    { new Guid("628c45db-9d2a-4534-8959-676a636946f0"), "McLaren", 0, "Flora", "Allesdandro", 45.250220306572913, 19.80629652423562, null, 1.6560543096854814m, 9.747141997226342m },
                    { new Guid("62f691fc-c5b1-4e71-9426-0cc8a02b7b8b"), "Mitsubishi Motors Corporation", 0, "Bechmann", "Maikol", 45.279071426502327, 19.862370160619843, null, 1.324328579217307m, 4.565442360558393m },
                    { new Guid("6494acf0-0c5b-4000-b426-a3ab5994f109"), "TOYOTA", 0, "Henry", "Violoncella", 45.220604547812769, 19.860464073132178, null, 1.6549856762871982m, 8.414841851640341m },
                    { new Guid("6504828c-7a9a-4fd8-8464-35f3f16906fc"), "Buick", 0, "Edie", "Maeve", 45.204068043710627, 19.850483415082969, null, 1.2435787993749734m, 1.5525301188205578m },
                    { new Guid("650a42e2-1b57-482e-a332-697e1a408af1"), "Honda", 0, "Talbot", "Carwen", 45.250169050776421, 19.794775524085665, null, 1.4473141471090796m, 4.881600711969098m },
                    { new Guid("660f1430-3e09-40ab-a48e-adbba17939f6"), "CHEVROLET", 0, "Construccion", "Rossi", 45.287037867075718, 19.853352110430713, null, 1.1262567197952467m, 4.052167523478899m },
                    { new Guid("6692f1d9-a705-482c-a342-1061822e90e0"), "Porsche", 0, "Jen", "Shar", 45.210580578767569, 19.787137195434291, null, 1.7006360867551042m, 9.781009068780087m },
                    { new Guid("66eb8798-b574-476b-8312-425a32c40a45"), "Lincoln", 0, "Geri", "Miii", 45.240326613759379, 19.856313447907667, null, 1.7338599905115184m, 10.732414512171566m },
                    { new Guid("688f4a52-0f42-4d69-9e9a-b72320d884e6"), "Bentley", 0, "Ann", "Canosa", 45.204344318934922, 19.835281956415212, null, 1.476499130995161m, 3.3429406521108387m },
                    { new Guid("68aa5aa9-cb53-4946-a45f-e780387d4333"), "MAZDA", 0, "Megpg", "Eunice", 45.219490140494258, 19.798772403836473, null, 1.3455814143383005m, 9.776292871306692m },
                    { new Guid("696059ae-2bad-4ca1-a657-d1632cb7dda7"), "TOYOTA", 0, "Dang", "Erskine", 45.217855950352465, 19.834207010840032, null, 1.7497987535854724m, 4.824188848962091m },
                    { new Guid("69ef2939-0299-4210-8bd4-e802e4f03643"), "Jeep", 0, "Iya", "Jhonatan", 45.276139257770936, 19.843919556371958, null, 1.6328898520108956m, 7.314957794295983m },
                    { new Guid("6a50de8a-8cc9-4a32-8aba-e0a0379e665a"), "Jeep", 0, "Iya", "Jhonatan", 45.276139257770936, 19.843919556371958, null, 1.6328898520108956m, 7.314957794295983m },
                    { new Guid("6ca9de70-cac6-4912-bf79-d32da92dde9f"), "CHEVROLET", 0, "Construccion", "Rossi", 45.287037867075718, 19.853352110430713, null, 1.1262567197952467m, 4.052167523478899m },
                    { new Guid("6ef11bc2-0b9b-4db4-be85-2f440d4407c7"), "Volvo", 0, "Taryn", "Bener", 45.230507721803349, 19.8096740775133, null, 1.58709815212918m, 10.487772005185393m },
                    { new Guid("71a4cc39-b78d-4409-b11a-9f9c98002a4f"), "Aston Martin Lagonda Ltd", 0, "Oracio", "Richie", 45.224688333074994, 19.83919841648629, null, 1.385540803473964m, 9.910185805400143m },
                    { new Guid("7296417f-49a8-4c76-b1a2-1931dcf341bc"), "Chevrolet", 0, "Jerome", "Hoj", 45.26187929944556, 19.852975472519034, null, 1.332259599316662m, 4.833445837024005m }
                });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Driver_ID", "Brand", "DriverStatus", "FirstName", "LastName", "Latitude", "Longitude", "PassengerId", "PricePerKM", "StartPrice" },
                values: new object[,]
                {
                    { new Guid("732fbf65-62d1-4ebf-95df-99d7a45ae9fc"), "Porsche", 0, "Vlada", "Marisela", 45.275549215170642, 19.878672958375621, null, 1.692150219149442m, 4.292175821808732m },
                    { new Guid("73a13b37-6e6c-4831-8cb0-410a5ee1bcdb"), "Porsche", 0, "Chrissy", "Tanyia", 45.279449168518042, 19.785822522191463, null, 1.4492458808602435m, 2.028265801352166m },
                    { new Guid("73aff2cb-1a9e-4c03-9f45-9077e9522b43"), "Roush", 0, "Evangeline", "Granados", 45.255782205655841, 19.854106076392526, null, 1.7553795014338474m, 6.146249025698085m },
                    { new Guid("7585b1e3-324e-4925-999e-41e01de10137"), "Aston Martin Lagonda Ltd", 0, "Knox", "Lorrie", 45.264656353292338, 19.837986673820598, null, 1.536456046701279m, 4.863201684677997m },
                    { new Guid("760f7b32-42c3-4229-b388-00642a5cbc81"), "Bentley", 0, "Ann", "Canosa", 45.204344318934922, 19.835281956415212, null, 1.476499130995161m, 3.3429406521108387m },
                    { new Guid("777dcb45-f4f5-41e8-bd6d-dedc97b1ca8f"), "Chrysler", 0, "Ibrahim", "Alina", 45.2993118675817, 19.796265612687975, null, 1.1089619486674978m, 10.521486246480235m },
                    { new Guid("7805fdec-376f-4deb-979a-c314b6dd9950"), "Mercedes-Benz", 0, "Marielle", "Orzai", 45.247779667723108, 19.842528794842231, null, 1.1929093189440756m, 4.356274892567532m },
                    { new Guid("782a8fe4-b740-4058-9b04-533207ea4ce5"), "Mini", 0, "Maurits", "Paulien", 45.296887928208001, 19.858852384808518, null, 1.7376903735062375m, 4.928084949383901m },
                    { new Guid("7fb506da-1b84-400e-bbfc-b15d31d91e90"), "GMC", 0, "Brehan", "Leonardo", 45.284932615672936, 19.861347707346106, null, 1.0165564995215457m, 10.543527811952874m },
                    { new Guid("819ce1ad-d35f-4552-8db9-78fc4e2256f1"), "Lincoln", 0, "Gert", "Andres", 45.279225594403293, 19.790054798757847, null, 1.1643840016635394m, 1.328847558195744m },
                    { new Guid("819daf82-dfe6-4ddf-a66b-ffa9da0ed00e"), "Volvo", 0, "Emma", "Tasha", 45.285854370015166, 19.866548271059557, null, 1.0566431268333218m, 8.509215393598028m },
                    { new Guid("85507b47-26a7-4c8a-b38d-ae60f8013fd3"), "Aston Martin Lagonda Ltd", 0, "Knox", "Lorrie", 45.264656353292338, 19.837986673820598, null, 1.536456046701279m, 4.863201684677997m },
                    { new Guid("86130e78-8474-43d9-a851-ee5022302d38"), "Audi", 0, "Beata", "Salome", 45.29945492843008, 19.844297003241515, null, 1.0417866558859206m, 1.2473101141077794m },
                    { new Guid("86c3f1c9-6b92-4c1f-ad8d-92810fa2ba80"), "Chrysler", 0, "Russell", "Rune", 45.223988703409404, 19.821203339044121, null, 1.669900944787707m, 7.442289794627493m },
                    { new Guid("8769ca8a-2534-449a-970f-f5048b2955e5"), "Ford", 0, "Cora", "Otra", 45.278586743787962, 19.802530466611248, null, 1.7253447233445418m, 10.91510684753183m },
                    { new Guid("8852297c-5210-4338-99ac-9450efb1b20f"), "TOYOTA", 0, "Henry", "Violoncella", 45.220604547812769, 19.860464073132178, null, 1.6549856762871982m, 8.414841851640341m },
                    { new Guid("88e070ad-4dfe-443c-aade-0c6efaff3f06"), "MAZDA", 0, "Megpg", "Eunice", 45.219490140494258, 19.798772403836473, null, 1.3455814143383005m, 9.776292871306692m },
                    { new Guid("899691f3-2f0e-4dd7-83f3-4f104ea1deaf"), "Pagani Automobili S.p.A.", 0, "Morrissey", "Kellie", 45.274651670577768, 19.791858685850482, null, 1.3417230653533827m, 2.18234253206158m },
                    { new Guid("8c3b751c-a4a0-4035-91d3-953589aff938"), "Rolls-Royce Motor Cars Limited", 0, "Henrik", "Edwin", 45.260099746320648, 19.846618295659582, null, 1.452835505779086m, 8.383483200020429m },
                    { new Guid("8c97772e-4d0e-4b04-98e6-35fe3586a759"), "Lincoln", 0, "Delair", "Meredith", 45.252036208353331, 19.868004870058986, null, 1.6143386734417438m, 6.054391760371328m },
                    { new Guid("8da017d1-3bd1-4662-aac8-c07e3d687c39"), "MASERATI", 0, "Magali", "Vibeke", 45.21619104847931, 19.788370458607901, null, 1.6719496977709882m, 4.795675055141949m },
                    { new Guid("8fd407d8-2b90-4bbf-a295-fe79bee6a990"), "Mercedes-Benz", 0, "Fernanda", "Berry", 45.284341031601357, 19.88214656986014, null, 1.228808543535298m, 2.642344591342897m },
                    { new Guid("901ef999-7a98-46a3-9ea5-7195ab5044d9"), "RAM", 0, "Renata", "Yadi", 45.296758424609912, 19.847822587069356, null, 1.5933840239464465m, 3.1678197529395926m },
                    { new Guid("908026f9-c1cc-43a6-8122-96ad0e3a6752"), "MAZDA", 0, "Callaghan", "Aiden", 45.215384546791014, 19.846282477003452, null, 1.7442378744022409m, 4.395966844983313m },
                    { new Guid("91da6b51-28d2-4049-b8bb-b9d6686725fe"), "Jeep", 0, "Jurg", "Colleen", 45.27947091909018, 19.803280137550804, null, 1.0642568736345543m, 1.1178482649382784m },
                    { new Guid("9225480d-15f3-414c-b99f-f685fafa0532"), "Roush", 0, "Iva", "Sloane", 45.218399244374908, 19.792091597548286, null, 1.6978977180498203m, 8.769920005723455m },
                    { new Guid("92edc8d2-69e0-4912-8870-18d6bef3f809"), "INFINITI", 0, "Jastinder", "Homero", 45.269815899190036, 19.810080082882855, null, 1.5244558202271907m, 1.9469998885842523m },
                    { new Guid("968df719-6562-4925-ac1d-b6a51509d796"), "Volvo", 0, "Lluvia", "Judd", 45.244554013188768, 19.872895707350001, null, 1.253412375617725m, 5.882144460892146m },
                    { new Guid("97645ed9-97a2-4814-a0dc-3e95e2868d8e"), "Land Rover", 0, "Oja", "Chin", 45.256914630896212, 19.858970871427317, null, 1.26487632045056m, 10.747802492089736m },
                    { new Guid("9ac025ce-902a-4f0c-8562-1228f0a94ed2"), "McLaren", 0, "Flora", "Allesdandro", 45.250220306572913, 19.80629652423562, null, 1.6560543096854814m, 9.747141997226342m },
                    { new Guid("9adae7ab-d784-45ab-98c8-be927d55780b"), "Lincoln", 0, "Delair", "Meredith", 45.252036208353331, 19.868004870058986, null, 1.6143386734417438m, 6.054391760371328m },
                    { new Guid("9bd096ca-ddb1-4311-9ef3-bbff99c5d7e9"), "Chevrolet", 0, "Trace", "Gerry", 45.290891491829363, 19.828444245832451, null, 1.6389965205075372m, 8.368466873577997m },
                    { new Guid("9c43031e-9708-4100-a674-efafe8aed06e"), "Volkswagen", 0, "Werner", "Inde", 45.221608244262498, 19.819591497862248, null, 1.3967480906659557m, 4.545871705956596m },
                    { new Guid("9cb1b748-b610-4c2a-811f-3e41bd3b95bd"), "Audi", 0, "Carling", "Angeles", 45.256456267336631, 19.839344022449293, null, 1.2919937229218867m, 3.8797762168830876m },
                    { new Guid("9d7653f8-10d6-4ce8-8659-1e59a597c475"), "Mini", 0, "Dianna", "Michal", 45.247323100321054, 19.842409377101806, null, 1.0397465494006515m, 5.223227457896003m },
                    { new Guid("9db444f8-7b10-43c9-8ed0-565d62229a32"), "TOYOTA", 0, "Dang", "Erskine", 45.217855950352465, 19.834207010840032, null, 1.7497987535854724m, 4.824188848962091m },
                    { new Guid("9fb0a563-8eed-4426-9a9a-08ccef5da358"), "INFINITI", 0, "Haas", "Chad", 45.288022877311491, 19.874835733268696, null, 1.5866952090365798m, 8.087357945507915m },
                    { new Guid("a311f914-d9ef-4cdc-9aa1-f91d729066fa"), "MASERATI", 0, "Residencia", "Casper", 45.229981095425153, 19.837153864471194, null, 1.554999380283847m, 9.574431191837565m },
                    { new Guid("a4221f1f-e6d6-41c4-879d-6f8d3768a1aa"), "RAM", 0, "Renata", "Yadi", 45.296758424609912, 19.847822587069356, null, 1.5933840239464465m, 3.1678197529395926m },
                    { new Guid("a441d7e9-9b77-4abf-a8bd-bb2de31522bb"), "Porsche", 0, "Lily", "Eugenia", 45.257195153791159, 19.808529545036901, null, 1.7101176770777686m, 2.275882597440534m },
                    { new Guid("a49358e6-2cc4-4ded-9537-9e96ee8240c6"), "Roush", 0, "Iva", "Sloane", 45.218399244374908, 19.792091597548286, null, 1.6978977180498203m, 8.769920005723455m },
                    { new Guid("a5cb6a26-3427-4247-a6c6-f2bc2d0703c4"), "Pagani Automobili S.p.A.", 0, "Jamison", "Ash", 45.278270343256636, 19.852105063006313, null, 1.3374700364494403m, 8.12755415792042m }
                });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Driver_ID", "Brand", "DriverStatus", "FirstName", "LastName", "Latitude", "Longitude", "PassengerId", "PricePerKM", "StartPrice" },
                values: new object[,]
                {
                    { new Guid("a6fbd735-1814-4f56-893e-86fe01141acd"), "SCION", 0, "Vanessa", "Moran", 45.243401442719865, 19.845486901252453, null, 1.766625245740726m, 1.5974547157697985m },
                    { new Guid("a7269b16-9539-4f99-abe7-97aabd041bd1"), "Dodge", 0, "Construccion", "Petty", 45.227061274337601, 19.836243969656948, null, 1.0452853161733882m, 3.69863700318812m },
                    { new Guid("a76ae74c-54e7-4d39-946f-64386a31eea2"), "Volvo", 0, "Taryn", "Bener", 45.230507721803349, 19.8096740775133, null, 1.58709815212918m, 10.487772005185393m },
                    { new Guid("a8cc72b6-248d-41a4-a6e9-5f6970693dda"), "Volvo", 0, "Jessa", "Tetiana", 45.228208563610373, 19.864794930227959, null, 1.4501630881251706m, 4.989849053623997m },
                    { new Guid("a8ebffc7-fcb0-4fe0-9b40-1e827fb4f4ad"), "Roush", 0, "Bernardino", "Danel", 45.262091751738382, 19.836733731194897, null, 1.685522127629019m, 5.239149409686604m },
                    { new Guid("a9509db9-8166-497a-93f0-b0a1cc02f78f"), "Aston Martin Lagonda Ltd", 0, "Elliot", "Loiselin", 45.222723321894421, 19.793603471598757, null, 1.5879618679964944m, 2.4186214661952135m },
                    { new Guid("a9627c88-0c8e-4ae2-bc1e-e51adf92132b"), "MAZDA", 0, "Rafal", "Monserrat", 45.282153330425473, 19.800982908909283, null, 1.0444604099295751m, 6.848472092200129m },
                    { new Guid("ac8bbea7-37cd-4805-941c-3352fadc5ac1"), "Chevrolet", 0, "Krizia", "Brusovanik", 45.267957633744437, 19.799666210958843, null, 1.6786208486121708m, 7.342233447742731m },
                    { new Guid("acad09ec-6b89-4b46-a28d-a6742f007718"), "Audi", 0, "Marc", "Erin", 45.262776103747605, 19.866401987510415, null, 1.0237952565130846m, 1.8608874905715336m },
                    { new Guid("acad1b48-ecbb-46fe-97b6-5ec4ca09e4e3"), "Honda", 0, "Libbey", "Ernest", 45.282891901118944, 19.876434018077504, null, 1.2475192510221107m, 5.449373131830329m },
                    { new Guid("ad5710ae-0bbd-41dd-80da-2e6ba1925d86"), "Volvo", 0, "Zena", "Kirstein", 45.238319779725494, 19.810359597732457, null, 1.7020772550670218m, 10.79799094974425m },
                    { new Guid("aff2141c-e02c-4c09-80e0-67bb2fc0698e"), "TOYOTA", 0, "Aden", "Eliza", 45.268648133812405, 19.831866095348715, null, 1.391490893102681m, 8.095125839709704m },
                    { new Guid("b07a0f50-0403-444f-a657-59adc9f431c2"), "Lamborghini", 0, "Letizia", "Kerry", 45.281638953906281, 19.813600296747204, null, 1.099366625884517m, 1.3295397945411715m },
                    { new Guid("b0803307-a3f1-43c6-b035-f44799f062f7"), "Audi", 0, "Carling", "Angeles", 45.256456267336631, 19.839344022449293, null, 1.2919937229218867m, 3.8797762168830876m },
                    { new Guid("b1e84e9e-c057-462c-8098-ddaa5b17820a"), "Cadillac", 0, "Olga", "Kristen", 45.29340112834867, 19.822498825540769, null, 1.6875309773099558m, 6.45756305740285m },
                    { new Guid("b279cf54-8acd-48eb-8add-99a322764174"), "Jeep", 0, "Greening", "Brockie", 45.275815226573968, 19.811590339120048, null, 1.1547939566454073m, 4.416711302958615m },
                    { new Guid("b3853700-9fa0-4234-9b2b-20c3f1258730"), "Land Rover", 0, "Oja", "Chin", 45.256914630896212, 19.858970871427317, null, 1.26487632045056m, 10.747802492089736m },
                    { new Guid("b4177834-d5d8-4960-8b9d-7def8deeb87d"), "GMC", 0, "Brehan", "Leonardo", 45.284932615672936, 19.861347707346106, null, 1.0165564995215457m, 10.543527811952874m },
                    { new Guid("b421d32b-a7be-4869-bc42-01fe3bc20066"), "Mini", 0, "Rue", "Henrik", 45.234728393171295, 19.822851909980773, null, 1.1939296054078634m, 1.7459564675100006m },
                    { new Guid("b6a1c4a6-9491-4e64-8efa-e8a526e3ca62"), "Lincoln", 0, "Gert", "Andres", 45.279225594403293, 19.790054798757847, null, 1.1643840016635394m, 1.328847558195744m },
                    { new Guid("b7ba99a7-8945-418e-9502-9e0603151b8c"), "Lamborghini", 0, "Aparna", "Segundo", 45.225215199148884, 19.883468373193303, null, 1.2154110733189056m, 3.652480026698223m },
                    { new Guid("b7c25052-b68d-4441-a6d8-64876d3c186b"), "Cadillac", 0, "Olga", "Kristen", 45.29340112834867, 19.822498825540769, null, 1.6875309773099558m, 6.45756305740285m },
                    { new Guid("b7ca5277-1f67-4f1a-8512-64e84f2a6107"), "Mini", 0, "Jerildy", "Tzipora", 45.26373409468961, 19.820524995264094, null, 1.6770837896990307m, 3.156359811608757m },
                    { new Guid("b8c3fcad-6752-4e40-8b7a-a2c3e6831f8c"), "Roush", 0, "Bernardino", "Danel", 45.262091751738382, 19.836733731194897, null, 1.685522127629019m, 5.239149409686604m },
                    { new Guid("b9f45acb-87bf-4175-a175-ca47fd2a3082"), "Acura", 0, "Anais", "Johnna", 45.287676498702332, 19.843019007354567, null, 1.1278655668254658m, 10.710397156830041m },
                    { new Guid("ba68ed3a-c4ec-4484-b1e9-a3815a82ba0f"), "Chrysler", 0, "Russell", "Rune", 45.223988703409404, 19.821203339044121, null, 1.669900944787707m, 7.442289794627493m },
                    { new Guid("bab53ddd-25f3-46e5-825c-a37d4eee7681"), "Mini", 0, "Larae", "Lindsey", 45.288988349342716, 19.869009669621189, null, 1.2705361960792216m, 3.7409616159613304m },
                    { new Guid("bf0cef2e-93e7-42a9-b1ba-bd7ac4273f73"), "Mini", 0, "Rue", "Henrik", 45.234728393171295, 19.822851909980773, null, 1.1939296054078634m, 1.7459564675100006m },
                    { new Guid("bf461fd9-3118-49c8-a20e-61407627bb41"), "Aston Martin Lagonda Ltd", 0, "Pauline", "Gunnar", 45.216454140074177, 19.848281178208055, null, 1.7036066928092553m, 4.427610056630678m },
                    { new Guid("c08c75ce-cdbc-4cfe-a39d-0c18e90e3807"), "Lamborghini", 0, "Ilhan", "Reserved", 45.269939911723235, 19.805821814574692, null, 1.7714084180476508m, 8.149353140401365m },
                    { new Guid("c1d14ff8-5cb2-43dd-a2d2-7f5711dd6c98"), "BMW", 0, "Jacques", "Lane", 45.213790253612132, 19.79774102895696, null, 1.7987752163597301m, 4.055436177433148m },
                    { new Guid("c35a0416-05f6-4673-abac-c916420eb86b"), "Honda", 0, "Talbot", "Carwen", 45.250169050776421, 19.794775524085665, null, 1.4473141471090796m, 4.881600711969098m },
                    { new Guid("c3a9832a-1920-490c-83bc-a3ce92ac90cb"), "Mercedes-Benz", 0, "Osvando", "Nicolaios", 45.216763399661289, 19.839646217936401, null, 1.390698997245516m, 2.4629580725247315m },
                    { new Guid("c71b24d4-3023-441d-b235-6e1599238a8f"), "CHEVROLET", 0, "Edouard", "Jehan", 45.210031240196187, 19.819412677818654, null, 1.2289611665909137m, 10.316446613551822m },
                    { new Guid("ca42374d-4f51-4e3b-9c52-4054a99b8c84"), "Mercedes-Benz", 0, "Marielle", "Orzai", 45.247779667723108, 19.842528794842231, null, 1.1929093189440756m, 4.356274892567532m },
                    { new Guid("cd2996c5-1341-430b-b73d-be4212b2d418"), "Aston Martin Lagonda Ltd", 0, "Elliot", "Loiselin", 45.222723321894421, 19.793603471598757, null, 1.5879618679964944m, 2.4186214661952135m },
                    { new Guid("cd3d31a7-fda2-4b21-bcde-78a5d35d3e8b"), "FIAT", 0, "Harold", "Karl", 45.286324628710155, 19.859015812248142, null, 1.7153672461915734m, 9.684974884213723m },
                    { new Guid("cd928192-b8a3-40f9-a2d2-3dd961a00556"), "INFINITI", 0, "Haas", "Chad", 45.288022877311491, 19.874835733268696, null, 1.5866952090365798m, 8.087357945507915m },
                    { new Guid("ceb21203-5257-4cb6-a337-556e7244b2dd"), "Honda", 0, "Marin", "Jesus", 45.296192164092709, 19.814406778655229, null, 1.308227287026685m, 3.9326792288937376m },
                    { new Guid("cedd2282-85a7-4e12-919b-75ef9ba3cc96"), "Bentley", 0, "Brandy", "Eleanor", 45.299538969878988, 19.880643245594662, null, 1.6281722977710191m, 5.728713211147051m },
                    { new Guid("d0b011c8-5831-401d-a736-b4394907eb5e"), "Jaguar", 0, "Dilini", "Joy", 45.204205166231176, 19.821658287825695, null, 1.5632855538691586m, 9.828321299882433m },
                    { new Guid("d16013e2-e395-4866-9cef-3037cc50e664"), "Subaru", 0, "Lombardet", "Casandra", 45.250568287681887, 19.824187873005126, null, 1.6563058877839092m, 10.512932624252946m }
                });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Driver_ID", "Brand", "DriverStatus", "FirstName", "LastName", "Latitude", "Longitude", "PassengerId", "PricePerKM", "StartPrice" },
                values: new object[,]
                {
                    { new Guid("d1770a59-201b-49f5-8218-1ea0200d6fb2"), "Aston Martin Lagonda Ltd", 0, "Oracio", "Richie", 45.224688333074994, 19.83919841648629, null, 1.385540803473964m, 9.910185805400143m },
                    { new Guid("d2366478-0f15-42ca-af36-9638706a0880"), "Lincoln", 0, "Geri", "Miii", 45.240326613759379, 19.856313447907667, null, 1.7338599905115184m, 10.732414512171566m },
                    { new Guid("d3f83519-336e-450a-a1d5-90f1f0919fca"), "Porsche", 0, "Walker", "Maruk", 45.217759832566678, 19.812095479197652, null, 1.0201468787267918m, 8.987330756776993m },
                    { new Guid("d5d23c8f-54fd-4467-9540-b9d8e2f77da0"), "MASERATI", 0, "Vartan", "Rhee", 45.298049374458131, 19.878864637212104, null, 1.5393415373611448m, 6.559482220099541m },
                    { new Guid("d8566a88-f64b-44c0-86e5-99291ff59093"), "Mercedes-Benz", 0, "Osvando", "Nicolaios", 45.216763399661289, 19.839646217936401, null, 1.390698997245516m, 2.4629580725247315m },
                    { new Guid("d8702c81-4798-46fe-a01e-c7c91588a626"), "Cadillac", 0, "Misael", "Gizelle", 45.260938791275308, 19.796892550971364, null, 1.0686156356587282m, 4.528765037827812m },
                    { new Guid("d92360f4-9d72-4239-9822-a700db889a3f"), "Acura", 0, "Jasmine", "Dorothy", 45.209423511503424, 19.81749485016757, null, 1.3610869109414416m, 7.115251420780801m },
                    { new Guid("d92cdde6-25af-4d60-bdd7-004a096503c9"), "Land Rover", 0, "Maurits", "Anurag", 45.253925064457675, 19.828862737626718, null, 1.7104501368390608m, 4.2596837052732415m },
                    { new Guid("d9b01310-2ebe-4ffa-9597-d01b361272ea"), "INFINITI", 0, "Bici", "Travis", 45.201686751190202, 19.802496053471067, null, 1.2016309984417113m, 10.491378188758173m },
                    { new Guid("dc673daa-9e1f-4587-8581-75e17b5397a9"), "Roush", 0, "Dahlia", "Pandora", 45.222647874969191, 19.786655808995068, null, 1.0651228912043087m, 7.807872207177916m },
                    { new Guid("dd575919-8785-4e22-929b-abb9bb614a3f"), "Lamborghini", 0, "Letizia", "Kerry", 45.281638953906281, 19.813600296747204, null, 1.099366625884517m, 1.3295397945411715m },
                    { new Guid("e02acf06-a5af-4bd5-b703-1717173b0f84"), "Ford", 0, "Cora", "Otra", 45.278586743787962, 19.802530466611248, null, 1.7253447233445418m, 10.91510684753183m },
                    { new Guid("e4509189-d3c7-404f-91ee-540140d330c3"), "Mini", 0, "Larae", "Lindsey", 45.288988349342716, 19.869009669621189, null, 1.2705361960792216m, 3.7409616159613304m },
                    { new Guid("e4798cca-da1d-4a1c-a24e-e7ac7ac0511c"), "Rolls-Royce Motor Cars Limited", 0, "Henrik", "Edwin", 45.260099746320648, 19.846618295659582, null, 1.452835505779086m, 8.383483200020429m },
                    { new Guid("e56bb02d-5387-4282-81f5-342c8ea153f7"), "INFINITI", 0, "Bici", "Travis", 45.201686751190202, 19.802496053471067, null, 1.2016309984417113m, 10.491378188758173m },
                    { new Guid("e5e33914-6257-4920-8d45-54fab80a9540"), "Porsche", 0, "Vlada", "Marisela", 45.275549215170642, 19.878672958375621, null, 1.692150219149442m, 4.292175821808732m },
                    { new Guid("e96778a5-9b50-4ec5-9718-42e4330c7323"), "Lincoln", 0, "Javid", "Tranta", 45.216149699839988, 19.853299911074188, null, 1.214353703785661m, 4.696927726796888m },
                    { new Guid("ed5b39d9-4c57-4704-9d04-9ec6294ad145"), "Cadillac", 0, "Misael", "Gizelle", 45.260938791275308, 19.796892550971364, null, 1.0686156356587282m, 4.528765037827812m },
                    { new Guid("ef0c4dcf-7f73-43ac-b9ee-647a9e447724"), "Bentley", 0, "Brandy", "Eleanor", 45.299538969878988, 19.880643245594662, null, 1.6281722977710191m, 5.728713211147051m },
                    { new Guid("f1556ec2-9b49-4d40-8640-340c1514c01b"), "Roush", 0, "Dahlia", "Pandora", 45.222647874969191, 19.786655808995068, null, 1.0651228912043087m, 7.807872207177916m },
                    { new Guid("f26055c4-39ba-4206-a1c0-31cfe8cae9d8"), "Ford", 0, "Leif", "Nalini", 45.281617289392479, 19.841755384683445, null, 1.0236099738160866m, 2.7658329456040622m },
                    { new Guid("f30eeb3d-ca1c-49d0-8f8f-e2248758e1c6"), "Chevrolet", 0, "Trace", "Gerry", 45.290891491829363, 19.828444245832451, null, 1.6389965205075372m, 8.368466873577997m },
                    { new Guid("f3799386-0493-458a-a215-f64546fd1c4a"), "Porsche", 0, "Walker", "Maruk", 45.217759832566678, 19.812095479197652, null, 1.0201468787267918m, 8.987330756776993m },
                    { new Guid("f42bf4ce-7dd6-43be-ab8b-0b80647e645e"), "Mercedes-Benz", 0, "Fernanda", "Berry", 45.284341031601357, 19.88214656986014, null, 1.228808543535298m, 2.642344591342897m },
                    { new Guid("f4d216d5-c383-47ad-910b-552fd8c82958"), "Aston Martin Lagonda Ltd", 0, "Pauline", "Gunnar", 45.216454140074177, 19.848281178208055, null, 1.7036066928092553m, 4.427610056630678m },
                    { new Guid("f61ee993-4af3-47f9-9e38-09b080430ffb"), "Bentley", 0, "Liliya", "Yeliz", 45.278508705345807, 19.806480944684065, null, 1.7553152421709535m, 4.360324081230656m },
                    { new Guid("f6d30608-2d75-4a7b-ab75-6c552c426d14"), "Buick", 0, "Edie", "Maeve", 45.204068043710627, 19.850483415082969, null, 1.2435787993749734m, 1.5525301188205578m },
                    { new Guid("ff7c4d63-1eff-4bd7-b4e8-3517788f1336"), "Subaru", 0, "Luz", "Jacqui", 45.282357438284876, 19.870750281402625, null, 1.3275739312198804m, 7.389799555041893m },
                    { new Guid("ff7f70db-25ba-42c9-86f9-c266e6d93203"), "Aston Martin Lagonda Ltd", 0, "Leonard", "Emerald", 45.2572972194831, 19.855507893571811, null, 1.2124823508556823m, 10.14906639309747m },
                    { new Guid("ffce2544-e213-4132-be09-48580de6a7d8"), "FIAT", 0, "Harold", "Karl", 45.286324628710155, 19.859015812248142, null, 1.7153672461915734m, 9.684974884213723m },
                    { new Guid("ffd58cb1-3a6e-4b87-bc73-04770580cd14"), "Bentley", 0, "Liliya", "Yeliz", 45.278508705345807, 19.806480944684065, null, 1.7553152421709535m, 4.360324081230656m },
                    { new Guid("ffeb4ef1-b8db-42b7-ab31-5598e19d76e2"), "Jaguar", 0, "Mannix", "Gisella", 45.296266247572717, 19.804770086487757, null, 1.6910908453429156m, 3.2823166597464395m }
                });

            migrationBuilder.InsertData(
                table: "Passengers",
                columns: new[] { "PassengerId", "Birthday", "Email", "FirstName", "Lastname", "PassengersLatitude", "PassengersLongitude", "Password" },
                values: new object[,]
                {
                    { new Guid("22be4661-93a2-4471-b2be-1d6e607cb35f"), new DateTime(1993, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "raca93@gmail.com", "Radivoje", "Bjelic", 45.290568287681893, 19.924187873005128, "dasd121231" },
                    { new Guid("4a9f0cd9-867e-4dd9-9d14-b07fe0ba7c30"), new DateTime(1990, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "marko@example.com", "Marko", "Petrovic", 43.32090222876819, 21.895758973005126, "dasd1tr231" },
                    { new Guid("676926ab-84e3-47d2-8027-43d1d6276bf1"), new DateTime(1987, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "ana@example.com", "Ana", "Ivanovic", 44.786568287681888, 20.448921673005128, "dasd1w1231" },
                    { new Guid("83449d5f-4c29-49c2-ad31-328252072b8c"), new DateTime(1992, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "jelena@example.com", "Jelena", "Jankovic", 44.012793528768192, 20.91142273005126, "daswwq21231" },
                    { new Guid("d2621c3d-8f78-4206-bb16-2952bb98f972"), new DateTime(1994, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "marija@example.com", "Marija", "Maric", 44.01652128768189, 21.00585973005126, "dasd1ghjbs231" },
                    { new Guid("f3df65d3-e166-4afa-8aaf-d7c42ac2d3ad"), new DateTime(1985, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "nikola@example.com", "Nikola", "Nikolic", 45.26713522876819, 19.833549673005127, "dasd1gfh31" }
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
                name: "IX_Rides_Driver_ID1",
                table: "Rides",
                column: "Driver_ID1");

            migrationBuilder.CreateIndex(
                name: "IX_Rides_PassengerId",
                table: "Rides",
                column: "PassengerId");

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
