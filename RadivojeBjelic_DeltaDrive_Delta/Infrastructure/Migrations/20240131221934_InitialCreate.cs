using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Passengers",
                columns: table => new
                {
                    PassengerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PassengerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PassengerLastname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PassengersLatitude = table.Column<double>(type: "float", nullable: false),
                    PassengersLongitude = table.Column<double>(type: "float", nullable: false),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Driver_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passengers", x => x.PassengerId);
                });

            migrationBuilder.CreateTable(
                name: "Rating",
                columns: table => new
                {
                    RatingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RideId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Score = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rating", x => x.RatingId);
                });

            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    Driver_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    Longitude = table.Column<double>(type: "float", nullable: false),
                    StartPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PricePerKM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
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
                        name: "FK_Rides_Rating_PassengerRatingRatingId",
                        column: x => x.PassengerRatingRatingId,
                        principalTable: "Rating",
                        principalColumn: "RatingId");
                });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Driver_ID", "Brand", "FirstName", "LastName", "Latitude", "Longitude", "PassengerId", "PricePerKM", "StartPrice" },
                values: new object[,]
                {
                    { new Guid("00312a50-3449-415a-84d3-c2d30b5ffa18"), "Bentley", "Ann", "Canosa", 45.204344318934922, 19.835281956415212, null, 1.476499130995161m, 3.3429406521108387m },
                    { new Guid("00384807-3830-4a0a-a3ad-cc52f2bbbd87"), "TOYOTA", "Henry", "Violoncella", 45.220604547812769, 19.860464073132178, null, 1.6549856762871982m, 8.414841851640341m },
                    { new Guid("012bfc89-ec51-48fa-b4b4-73277f28602c"), "Acura", "Anais", "Johnna", 45.287676498702332, 19.843019007354567, null, 1.1278655668254658m, 10.710397156830041m },
                    { new Guid("03fab690-0ade-454f-adc4-778e35a53b03"), "Roush", "Evangeline", "Granados", 45.255782205655841, 19.854106076392526, null, 1.7553795014338474m, 6.146249025698085m },
                    { new Guid("04281792-92cf-4ba2-8f6d-e1f2bc28f018"), "CHEVROLET", "Construccion", "Rossi", 45.287037867075718, 19.853352110430713, null, 1.1262567197952467m, 4.052167523478899m },
                    { new Guid("044c8b7a-30dd-48dc-91b5-54111551a2e6"), "Roush", "Rossane", "Jessica", 45.266559868005444, 19.829707954977223, null, 1.504112436608676m, 9.364469311550952m },
                    { new Guid("04c0e772-a2c7-4348-811f-5fbd35b186e9"), "Jaguar", "Mannix", "Gisella", 45.296266247572717, 19.804770086487757, null, 1.6910908453429156m, 3.2823166597464395m },
                    { new Guid("05e8ce12-9b1b-4a42-8c17-20316cc9de66"), "Volvo", "Lluvia", "Judd", 45.244554013188768, 19.872895707350001, null, 1.253412375617725m, 5.882144460892146m },
                    { new Guid("075e8036-a4ba-4720-8e4e-623888a1b527"), "Bentley", "Liliya", "Yeliz", 45.278508705345807, 19.806480944684065, null, 1.7553152421709535m, 4.360324081230656m },
                    { new Guid("0afd0520-4095-4e86-97e2-5638a746fdb2"), "Cadillac", "Misael", "Gizelle", 45.260938791275308, 19.796892550971364, null, 1.0686156356587282m, 4.528765037827812m },
                    { new Guid("0c235dc6-ce75-46dc-9567-ed468d35a7e3"), "Porsche", "Lily", "Eugenia", 45.257195153791159, 19.808529545036901, null, 1.7101176770777686m, 2.275882597440534m },
                    { new Guid("0c404bbf-5c14-43bb-a507-e1f01cf22d30"), "Honda", "Marin", "Jesus", 45.296192164092709, 19.814406778655229, null, 1.308227287026685m, 3.9326792288937376m },
                    { new Guid("0e008908-8c04-4253-86d6-8e793946e5ca"), "NISSAN", "Rasika", "Raimundo", 45.291779211384224, 19.800023095935906, null, 1.0891868325268717m, 4.793560726767151m },
                    { new Guid("108b7993-5d8c-4e1c-b06a-e2fb2d9b1928"), "Acura", "Jasmine", "Dorothy", 45.209423511503424, 19.81749485016757, null, 1.3610869109414416m, 7.115251420780801m },
                    { new Guid("10d96117-4fdb-459d-a340-013da75b244a"), "Pagani Automobili S.p.A.", "Morrissey", "Kellie", 45.274651670577768, 19.791858685850482, null, 1.3417230653533827m, 2.18234253206158m },
                    { new Guid("11458367-5e6f-4eda-8e15-4552c9469351"), "INFINITI", "Deepti", "Devara", 45.275913260410107, 19.85081695839504, null, 1.6342564595450453m, 10.57353943753355m },
                    { new Guid("1226a00a-5f0d-45da-af59-3e0004b576db"), "Buick", "Edie", "Maeve", 45.204068043710627, 19.850483415082969, null, 1.2435787993749734m, 1.5525301188205578m },
                    { new Guid("125e0455-7507-40b4-8eae-20a1e0ce762c"), "Aston Martin Lagonda Ltd", "Elliot", "Loiselin", 45.222723321894421, 19.793603471598757, null, 1.5879618679964944m, 2.4186214661952135m },
                    { new Guid("1c801a72-8d86-4293-a511-c3e810ea99db"), "McLaren", "Flora", "Allesdandro", 45.250220306572913, 19.80629652423562, null, 1.6560543096854814m, 9.747141997226342m },
                    { new Guid("1ca42713-1ee2-4bba-b9f3-ed9919236313"), "Porsche", "Walker", "Maruk", 45.217759832566678, 19.812095479197652, null, 1.0201468787267918m, 8.987330756776993m },
                    { new Guid("1d0ee7d7-7380-48de-93a4-16fbd6d92995"), "Volvo", "Jessa", "Tetiana", 45.228208563610373, 19.864794930227959, null, 1.4501630881251706m, 4.989849053623997m },
                    { new Guid("1db013fa-1dc9-45ea-bb49-0e00892f4ce8"), "Lincoln", "Gert", "Andres", 45.279225594403293, 19.790054798757847, null, 1.1643840016635394m, 1.328847558195744m },
                    { new Guid("1e752586-a031-4a1c-85fb-d398b0fcb82c"), "Lincoln", "Javid", "Tranta", 45.216149699839988, 19.853299911074188, null, 1.214353703785661m, 4.696927726796888m },
                    { new Guid("1f4ce584-98bc-406b-b729-5df40303ebbd"), "Rolls-Royce Motor Cars Limited", "Henrik", "Edwin", 45.260099746320648, 19.846618295659582, null, 1.452835505779086m, 8.383483200020429m },
                    { new Guid("21518100-0d0d-4a81-a6b6-ff459f611f3d"), "Chrysler", "Russell", "Rune", 45.223988703409404, 19.821203339044121, null, 1.669900944787707m, 7.442289794627493m },
                    { new Guid("21a16e48-58db-4e40-8f79-8ab4ec7a8fbb"), "MASERATI", "Magali", "Vibeke", 45.21619104847931, 19.788370458607901, null, 1.6719496977709882m, 4.795675055141949m },
                    { new Guid("22bd40df-ec85-4aaa-9d8a-e153e77c98cd"), "Dodge", "Andreas", "Adolfo", 45.265939837651047, 19.832946913832068, null, 1.7380170039298m, 8.510688070544214m },
                    { new Guid("238947c2-efac-442d-b2f1-debb0e62e9c9"), "TOYOTA", "Dang", "Erskine", 45.217855950352465, 19.834207010840032, null, 1.7497987535854724m, 4.824188848962091m },
                    { new Guid("245034df-c1d8-474d-bcdd-34757b3dbe89"), "Aston Martin Lagonda Ltd", "Leonard", "Emerald", 45.2572972194831, 19.855507893571811, null, 1.2124823508556823m, 10.14906639309747m },
                    { new Guid("266f3066-8693-495d-bf17-3921a45e3e24"), "Mercedes-Benz", "Osvando", "Nicolaios", 45.216763399661289, 19.839646217936401, null, 1.390698997245516m, 2.4629580725247315m },
                    { new Guid("27d1b77b-c8f0-4331-b51d-62cc38cc24eb"), "Mini", "Dianna", "Michal", 45.247323100321054, 19.842409377101806, null, 1.0397465494006515m, 5.223227457896003m },
                    { new Guid("29cdd1a1-1609-41d1-8b0a-068f7df1faaa"), "Bentley", "Brandy", "Eleanor", 45.299538969878988, 19.880643245594662, null, 1.6281722977710191m, 5.728713211147051m },
                    { new Guid("2baf16ee-f51a-464a-8cef-d15bf1339b07"), "Chevrolet", "Jerome", "Hoj", 45.26187929944556, 19.852975472519034, null, 1.332259599316662m, 4.833445837024005m },
                    { new Guid("2bcb0f22-7167-47bd-8543-3167987237c3"), "TOYOTA", "Aden", "Eliza", 45.268648133812405, 19.831866095348715, null, 1.391490893102681m, 8.095125839709704m },
                    { new Guid("2d4324c1-c640-4625-85af-56e36dfe7528"), "Lincoln", "Geri", "Miii", 45.240326613759379, 19.856313447907667, null, 1.7338599905115184m, 10.732414512171566m },
                    { new Guid("2f309aaa-d28f-41d9-9958-31000dde888c"), "Aston Martin Lagonda Ltd", "Pauline", "Gunnar", 45.216454140074177, 19.848281178208055, null, 1.7036066928092553m, 4.427610056630678m },
                    { new Guid("306220ce-dc37-41f4-84f5-767f19594a5e"), "Porsche", "Walker", "Maruk", 45.217759832566678, 19.812095479197652, null, 1.0201468787267918m, 8.987330756776993m },
                    { new Guid("30e3bbb4-a966-4231-aef1-6082989c909a"), "Jeep", "Jurg", "Colleen", 45.27947091909018, 19.803280137550804, null, 1.0642568736345543m, 1.1178482649382784m },
                    { new Guid("30f571b3-a2a7-4a62-afd6-baa4ae8a9995"), "Subaru", "Luz", "Jacqui", 45.282357438284876, 19.870750281402625, null, 1.3275739312198804m, 7.389799555041893m },
                    { new Guid("338e3a06-2656-4159-8c94-89788b9dc2f8"), "Mercedes-Benz", "Marielle", "Orzai", 45.247779667723108, 19.842528794842231, null, 1.1929093189440756m, 4.356274892567532m },
                    { new Guid("3450e767-0c1a-4fc3-bb85-6c2586a4c50a"), "BMW", "Jacques", "Lane", 45.213790253612132, 19.79774102895696, null, 1.7987752163597301m, 4.055436177433148m },
                    { new Guid("34a0f19e-e11b-434f-b085-249df01fddda"), "Bentley", "Lupita", "Bennet", 45.280486776875811, 19.844408581896609, null, 1.1702439175398553m, 10.496768111188889m }
                });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Driver_ID", "Brand", "FirstName", "LastName", "Latitude", "Longitude", "PassengerId", "PricePerKM", "StartPrice" },
                values: new object[,]
                {
                    { new Guid("3836b8c5-02fa-4353-b363-876a353ca8ef"), "Subaru", "Lombardet", "Casandra", 45.250568287681887, 19.824187873005126, null, 1.6563058877839092m, 10.512932624252946m },
                    { new Guid("395a9d10-01fe-412f-a696-bacf149f6ecc"), "Honda", "Libbey", "Ernest", 45.282891901118944, 19.876434018077504, null, 1.2475192510221107m, 5.449373131830329m },
                    { new Guid("3b8bc7ee-ba7f-415b-9dee-5950b22a5acd"), "Lamborghini", "Aparna", "Segundo", 45.225215199148884, 19.883468373193303, null, 1.2154110733189056m, 3.652480026698223m },
                    { new Guid("3cde6233-f1ce-44c7-866a-0709ccf42a94"), "INFINITI", "Jastinder", "Homero", 45.269815899190036, 19.810080082882855, null, 1.5244558202271907m, 1.9469998885842523m },
                    { new Guid("3e1a2000-aeec-499c-bac1-8078fa340d7c"), "CHEVROLET", "Edouard", "Jehan", 45.210031240196187, 19.819412677818654, null, 1.2289611665909137m, 10.316446613551822m },
                    { new Guid("41022739-3c60-4c45-b1fa-8a330692431f"), "Chevrolet", "Jerome", "Hoj", 45.26187929944556, 19.852975472519034, null, 1.332259599316662m, 4.833445837024005m },
                    { new Guid("449366d5-5c8f-40fb-9fc5-f39eae68ae97"), "Ford", "Cora", "Otra", 45.278586743787962, 19.802530466611248, null, 1.7253447233445418m, 10.91510684753183m },
                    { new Guid("457f51f2-1fb0-493d-ae07-bc3c82b6ffc8"), "Chevrolet", "Trace", "Gerry", 45.290891491829363, 19.828444245832451, null, 1.6389965205075372m, 8.368466873577997m },
                    { new Guid("461be80a-a291-4336-ac0d-f90001e39579"), "Volvo", "Taryn", "Bener", 45.230507721803349, 19.8096740775133, null, 1.58709815212918m, 10.487772005185393m },
                    { new Guid("47838cf6-e1ce-4243-8977-291b42b3beb7"), "Mini", "Maurits", "Paulien", 45.296887928208001, 19.858852384808518, null, 1.7376903735062375m, 4.928084949383901m },
                    { new Guid("47e51dfa-76c2-4d50-8126-8e369f6ad1f2"), "Mini", "Rue", "Henrik", 45.234728393171295, 19.822851909980773, null, 1.1939296054078634m, 1.7459564675100006m },
                    { new Guid("48546b5b-03f5-48e4-a771-b0fda887bf62"), "Ford", "Cora", "Otra", 45.278586743787962, 19.802530466611248, null, 1.7253447233445418m, 10.91510684753183m },
                    { new Guid("49ee95f7-daf1-4297-a9e5-ee730c1e1c1a"), "MAZDA", "Callaghan", "Aiden", 45.215384546791014, 19.846282477003452, null, 1.7442378744022409m, 4.395966844983313m },
                    { new Guid("4b23c030-52a0-4224-bb9f-51da2d7dcd24"), "Ford", "Leif", "Nalini", 45.281617289392479, 19.841755384683445, null, 1.0236099738160866m, 2.7658329456040622m },
                    { new Guid("4b43d9c2-bec1-4e14-bdab-cb65c00c525b"), "Cadillac", "Olga", "Kristen", 45.29340112834867, 19.822498825540769, null, 1.6875309773099558m, 6.45756305740285m },
                    { new Guid("4c583def-e8f9-4e41-b1c0-c40d66c60266"), "Audi", "Carling", "Angeles", 45.256456267336631, 19.839344022449293, null, 1.2919937229218867m, 3.8797762168830876m },
                    { new Guid("4d0face9-518c-43eb-804d-6e93cc6e47af"), "FIAT", "Harold", "Karl", 45.286324628710155, 19.859015812248142, null, 1.7153672461915734m, 9.684974884213723m },
                    { new Guid("4d13cbe6-6069-4546-a018-b6e723b0b9ed"), "Porsche", "Vlada", "Marisela", 45.275549215170642, 19.878672958375621, null, 1.692150219149442m, 4.292175821808732m },
                    { new Guid("4d7fa949-2054-4a26-ad71-274ecffa0e38"), "Porsche", "Jen", "Shar", 45.210580578767569, 19.787137195434291, null, 1.7006360867551042m, 9.781009068780087m },
                    { new Guid("4e1dddc4-94d2-4bc5-a96e-d0a0703aa3e0"), "Lamborghini", "Aparna", "Segundo", 45.225215199148884, 19.883468373193303, null, 1.2154110733189056m, 3.652480026698223m },
                    { new Guid("4f74e8be-f273-42fb-9cdf-7c9d59978f3e"), "Aston Martin Lagonda Ltd", "Oracio", "Richie", 45.224688333074994, 19.83919841648629, null, 1.385540803473964m, 9.910185805400143m },
                    { new Guid("5114128a-f086-4a0c-a475-11c18fffc471"), "Volvo", "Zena", "Kirstein", 45.238319779725494, 19.810359597732457, null, 1.7020772550670218m, 10.79799094974425m },
                    { new Guid("53c455e4-58c5-45c0-a75b-565ece3bbf5f"), "Volvo", "Zena", "Kirstein", 45.238319779725494, 19.810359597732457, null, 1.7020772550670218m, 10.79799094974425m },
                    { new Guid("5456deef-0b28-4651-8a30-36cd1c2746ff"), "Roush", "Dahlia", "Pandora", 45.222647874969191, 19.786655808995068, null, 1.0651228912043087m, 7.807872207177916m },
                    { new Guid("561dd4d4-081e-4916-970d-dd91ba615f5c"), "Aston Martin Lagonda Ltd", "Elliot", "Loiselin", 45.222723321894421, 19.793603471598757, null, 1.5879618679964944m, 2.4186214661952135m },
                    { new Guid("5657a030-7cf7-44cc-a1b1-354f1fffb1e3"), "Jaguar", "Dilini", "Joy", 45.204205166231176, 19.821658287825695, null, 1.5632855538691586m, 9.828321299882433m },
                    { new Guid("5a5c8759-c74d-4940-ae24-2741f3d4463e"), "Cadillac", "Misael", "Gizelle", 45.260938791275308, 19.796892550971364, null, 1.0686156356587282m, 4.528765037827812m },
                    { new Guid("5c850123-20a4-4a25-9c9d-c4a6c0f87e73"), "Land Rover", "Oja", "Chin", 45.256914630896212, 19.858970871427317, null, 1.26487632045056m, 10.747802492089736m },
                    { new Guid("5ea6d691-114d-4bb5-a927-6e05b002193c"), "Audi", "Carling", "Angeles", 45.256456267336631, 19.839344022449293, null, 1.2919937229218867m, 3.8797762168830876m },
                    { new Guid("5fd1ff5c-fd0f-4e08-9c7e-ae821de72b7f"), "Volvo", "Emma", "Tasha", 45.285854370015166, 19.866548271059557, null, 1.0566431268333218m, 8.509215393598028m },
                    { new Guid("6005e0e2-193d-483c-89a6-b58e19550feb"), "BMW", "Jacques", "Lane", 45.213790253612132, 19.79774102895696, null, 1.7987752163597301m, 4.055436177433148m },
                    { new Guid("60674fdf-43a8-4428-83e3-844ae8adde0e"), "Chrysler", "Russell", "Rune", 45.223988703409404, 19.821203339044121, null, 1.669900944787707m, 7.442289794627493m },
                    { new Guid("60ebd855-127e-4c80-af7d-91ba178d99b5"), "Mini", "Larae", "Lindsey", 45.288988349342716, 19.869009669621189, null, 1.2705361960792216m, 3.7409616159613304m },
                    { new Guid("60f1b0ad-6b82-4ca9-acf2-2b120d26c41d"), "Volvo", "Taryn", "Bener", 45.230507721803349, 19.8096740775133, null, 1.58709815212918m, 10.487772005185393m },
                    { new Guid("6194844d-18c0-4b67-b47a-072b43969c43"), "Roush", "Dahlia", "Pandora", 45.222647874969191, 19.786655808995068, null, 1.0651228912043087m, 7.807872207177916m },
                    { new Guid("6293b024-84b3-431f-ac37-59099db222e8"), "Lamborghini", "Ilhan", "Reserved", 45.269939911723235, 19.805821814574692, null, 1.7714084180476508m, 8.149353140401365m },
                    { new Guid("665dfd67-7d96-46ee-9e16-a8fb65960113"), "Lincoln", "Delair", "Meredith", 45.252036208353331, 19.868004870058986, null, 1.6143386734417438m, 6.054391760371328m },
                    { new Guid("6866345b-d0b0-435a-8f43-afbec8edb622"), "Honda", "Talbot", "Carwen", 45.250169050776421, 19.794775524085665, null, 1.4473141471090796m, 4.881600711969098m },
                    { new Guid("6c0e5122-01ab-4cb3-be3e-d8137904e94b"), "LEXUS", "Raina", "Lula", 45.223453054301878, 19.830829334577729, null, 1.0164590921625576m, 6.269772816844689m },
                    { new Guid("70cf66db-bc5f-4044-af6e-2630534cec67"), "Mercedes-Benz", "Fernanda", "Berry", 45.284341031601357, 19.88214656986014, null, 1.228808543535298m, 2.642344591342897m },
                    { new Guid("70de45d2-7745-497d-aa19-cca0ef7da697"), "Lamborghini", "Letizia", "Kerry", 45.281638953906281, 19.813600296747204, null, 1.099366625884517m, 1.3295397945411715m },
                    { new Guid("736b2bf6-fcf6-4ccf-90d4-86bc77e349bb"), "Roush", "Evangeline", "Granados", 45.255782205655841, 19.854106076392526, null, 1.7553795014338474m, 6.146249025698085m }
                });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Driver_ID", "Brand", "FirstName", "LastName", "Latitude", "Longitude", "PassengerId", "PricePerKM", "StartPrice" },
                values: new object[,]
                {
                    { new Guid("73e49a84-b36b-4da9-a1d8-93173fa6e732"), "FIAT", "Harold", "Karl", 45.286324628710155, 19.859015812248142, null, 1.7153672461915734m, 9.684974884213723m },
                    { new Guid("74338a17-98ae-4963-8de0-db9f92639ec1"), "Chevrolet", "Krizia", "Brusovanik", 45.267957633744437, 19.799666210958843, null, 1.6786208486121708m, 7.342233447742731m },
                    { new Guid("752bd157-3ff2-4a5e-b32f-c72740cc88ff"), "Jeep", "Iya", "Jhonatan", 45.276139257770936, 19.843919556371958, null, 1.6328898520108956m, 7.314957794295983m },
                    { new Guid("77050250-ee8b-4d32-9146-88f1b07f1626"), "GMC", "Brehan", "Leonardo", 45.284932615672936, 19.861347707346106, null, 1.0165564995215457m, 10.543527811952874m },
                    { new Guid("774e24d1-d5c4-4e35-8d3b-d5c98ca8d024"), "Jeep", "Jurg", "Colleen", 45.27947091909018, 19.803280137550804, null, 1.0642568736345543m, 1.1178482649382784m },
                    { new Guid("77bae0f3-0b04-4ce8-bd39-e172da84ec21"), "BMW", "Alessandro", "Ame", 45.213878946434399, 19.83500906624565, null, 1.1394055188065981m, 10.629290075265152m },
                    { new Guid("78b1703f-faf5-4294-8918-4bdf6693a555"), "BMW", "Alessandro", "Ame", 45.213878946434399, 19.83500906624565, null, 1.1394055188065981m, 10.629290075265152m },
                    { new Guid("7aa5cf58-af0a-41f9-9521-28fb7fb8c8ca"), "Buick", "Edie", "Maeve", 45.204068043710627, 19.850483415082969, null, 1.2435787993749734m, 1.5525301188205578m },
                    { new Guid("7ba646f7-83b7-4dd1-9fed-eaab803885ca"), "Chevrolet", "Trace", "Gerry", 45.290891491829363, 19.828444245832451, null, 1.6389965205075372m, 8.368466873577997m },
                    { new Guid("7ce42012-1531-450f-9b29-4db42c019131"), "Pagani Automobili S.p.A.", "Morrissey", "Kellie", 45.274651670577768, 19.791858685850482, null, 1.3417230653533827m, 2.18234253206158m },
                    { new Guid("7de509d7-8fc0-4a63-a5c8-593a015a85ca"), "MAZDA", "Rafal", "Monserrat", 45.282153330425473, 19.800982908909283, null, 1.0444604099295751m, 6.848472092200129m },
                    { new Guid("805bffbf-53f3-4f3b-afc5-1c87d8922cd8"), "Jeep", "Greening", "Brockie", 45.275815226573968, 19.811590339120048, null, 1.1547939566454073m, 4.416711302958615m },
                    { new Guid("812b0c2a-2707-4058-9e4f-4f361f36f791"), "Dodge", "Andreas", "Adolfo", 45.265939837651047, 19.832946913832068, null, 1.7380170039298m, 8.510688070544214m },
                    { new Guid("818df617-3c0f-48b4-ba9e-8cdceac7fe1f"), "Land Rover", "Maurits", "Anurag", 45.253925064457675, 19.828862737626718, null, 1.7104501368390608m, 4.2596837052732415m },
                    { new Guid("82130e47-cde3-4acf-94c1-ac7f92f61d16"), "INFINITI", "Haas", "Chad", 45.288022877311491, 19.874835733268696, null, 1.5866952090365798m, 8.087357945507915m },
                    { new Guid("82b7bf13-de4d-461d-bd8e-3ba249b96637"), "Subaru", "Luz", "Jacqui", 45.282357438284876, 19.870750281402625, null, 1.3275739312198804m, 7.389799555041893m },
                    { new Guid("82ecfb6c-885c-4723-a406-8e06f860e3fb"), "Pagani Automobili S.p.A.", "Jamison", "Ash", 45.278270343256636, 19.852105063006313, null, 1.3374700364494403m, 8.12755415792042m },
                    { new Guid("867918f3-ad4a-45f3-b182-4e54176d058e"), "ALFA ROMEO", "Allison", "Royden", 45.295945743171906, 19.857674174593402, null, 1.5237046745427651m, 10.405094574404158m },
                    { new Guid("8eded69e-c29a-46a3-a6e1-b6411c81d0bb"), "Chrysler", "Ibrahim", "Alina", 45.2993118675817, 19.796265612687975, null, 1.1089619486674978m, 10.521486246480235m },
                    { new Guid("902250cd-4cd6-469c-be44-8e3cbdb4c2d5"), "Lincoln", "Javid", "Tranta", 45.216149699839988, 19.853299911074188, null, 1.214353703785661m, 4.696927726796888m },
                    { new Guid("908499d4-fd5a-496d-b812-9a5b6fcb7578"), "Mini", "Maurits", "Paulien", 45.296887928208001, 19.858852384808518, null, 1.7376903735062375m, 4.928084949383901m },
                    { new Guid("914866ec-49e5-4cc3-939c-a8ad1b5b4752"), "Volvo", "Lluvia", "Judd", 45.244554013188768, 19.872895707350001, null, 1.253412375617725m, 5.882144460892146m },
                    { new Guid("91947210-a861-42c7-9345-1d5ac448b2bd"), "MAZDA", "Callaghan", "Aiden", 45.215384546791014, 19.846282477003452, null, 1.7442378744022409m, 4.395966844983313m },
                    { new Guid("9565a9d7-981a-49a9-aa7d-b109d2ebe3c2"), "Dodge", "Construccion", "Petty", 45.227061274337601, 19.836243969656948, null, 1.0452853161733882m, 3.69863700318812m },
                    { new Guid("97c1872f-f4a7-4a20-b4a0-14fb89a9636a"), "Bentley", "Brandy", "Eleanor", 45.299538969878988, 19.880643245594662, null, 1.6281722977710191m, 5.728713211147051m },
                    { new Guid("97fef705-46dd-41d2-a02b-dda77368e949"), "Honda", "Libbey", "Ernest", 45.282891901118944, 19.876434018077504, null, 1.2475192510221107m, 5.449373131830329m },
                    { new Guid("9cb38bd0-bdb5-4d96-bfb5-136902f63d0d"), "Porsche", "Lily", "Eugenia", 45.257195153791159, 19.808529545036901, null, 1.7101176770777686m, 2.275882597440534m },
                    { new Guid("9d53aba3-94aa-4e15-9ef4-f2f46743e473"), "Volkswagen", "Werner", "Inde", 45.221608244262498, 19.819591497862248, null, 1.3967480906659557m, 4.545871705956596m },
                    { new Guid("9dd2dcdc-04f3-450e-b17c-e278a897e88c"), "Roush", "Rossane", "Jessica", 45.266559868005444, 19.829707954977223, null, 1.504112436608676m, 9.364469311550952m },
                    { new Guid("a290f848-0813-46c9-a1cd-cb2e03542a1e"), "Jeep", "Greening", "Brockie", 45.275815226573968, 19.811590339120048, null, 1.1547939566454073m, 4.416711302958615m },
                    { new Guid("a9847ef8-bddc-481c-8510-a44d8bbb17a3"), "NISSAN", "Rasika", "Raimundo", 45.291779211384224, 19.800023095935906, null, 1.0891868325268717m, 4.793560726767151m },
                    { new Guid("aa6aebbb-2cd2-47b5-9352-5e9508e9f08c"), "Porsche", "Chrissy", "Tanyia", 45.279449168518042, 19.785822522191463, null, 1.4492458808602435m, 2.028265801352166m },
                    { new Guid("aa957d23-ef55-42f5-9363-d0f3be33e4a6"), "Audi", "Beata", "Salome", 45.29945492843008, 19.844297003241515, null, 1.0417866558859206m, 1.2473101141077794m },
                    { new Guid("ad4446a9-082c-4f60-b7a0-f35ba3bdbb0a"), "TOYOTA", "Henry", "Violoncella", 45.220604547812769, 19.860464073132178, null, 1.6549856762871982m, 8.414841851640341m },
                    { new Guid("af5e27cb-1506-44a2-85f4-48f239ef14c2"), "Mini", "Rue", "Henrik", 45.234728393171295, 19.822851909980773, null, 1.1939296054078634m, 1.7459564675100006m },
                    { new Guid("b050d01e-78d6-4efa-842d-b66404388a8c"), "MASERATI", "Magali", "Vibeke", 45.21619104847931, 19.788370458607901, null, 1.6719496977709882m, 4.795675055141949m },
                    { new Guid("b077a869-60af-4e3b-9edb-59a288d7c536"), "Mitsubishi Motors Corporation", "Yev", "Leeann", 45.243827207876294, 19.795146332823769, null, 1.4038353529833358m, 7.1267708754257715m },
                    { new Guid("b0c0f812-d997-44fd-904e-9f281535cc0a"), "Volkswagen", "Werner", "Inde", 45.221608244262498, 19.819591497862248, null, 1.3967480906659557m, 4.545871705956596m },
                    { new Guid("b0d8ebe6-4bb0-4354-b2d2-2e8dc75e674a"), "SCION", "Vanessa", "Moran", 45.243401442719865, 19.845486901252453, null, 1.766625245740726m, 1.5974547157697985m },
                    { new Guid("b5408978-a1bf-4d86-a0d1-c010ece7c6ae"), "CHEVROLET", "Construccion", "Rossi", 45.287037867075718, 19.853352110430713, null, 1.1262567197952467m, 4.052167523478899m },
                    { new Guid("b570ea38-6041-4e1f-a439-d0464f8f9e4a"), "Bentley", "Lupita", "Bennet", 45.280486776875811, 19.844408581896609, null, 1.1702439175398553m, 10.496768111188889m },
                    { new Guid("b60ac7d3-4edf-4556-9c8d-43dfd1efc024"), "Lincoln", "Gert", "Andres", 45.279225594403293, 19.790054798757847, null, 1.1643840016635394m, 1.328847558195744m }
                });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Driver_ID", "Brand", "FirstName", "LastName", "Latitude", "Longitude", "PassengerId", "PricePerKM", "StartPrice" },
                values: new object[,]
                {
                    { new Guid("b82eabc6-c0ff-4456-bb54-cf9d1e4dad56"), "Mini", "Dianna", "Michal", 45.247323100321054, 19.842409377101806, null, 1.0397465494006515m, 5.223227457896003m },
                    { new Guid("b8f05e00-a441-4e73-9bb4-a83dc1526b5e"), "Aston Martin Lagonda Ltd", "Pauline", "Gunnar", 45.216454140074177, 19.848281178208055, null, 1.7036066928092553m, 4.427610056630678m },
                    { new Guid("b90ea8c9-8afb-49db-96e5-f5deab1632ef"), "Mitsubishi Motors Corporation", "Bechmann", "Maikol", 45.279071426502327, 19.862370160619843, null, 1.324328579217307m, 4.565442360558393m },
                    { new Guid("ba39063b-4bc9-41f9-8d16-bcbfe1f77e84"), "Jeep", "Iya", "Jhonatan", 45.276139257770936, 19.843919556371958, null, 1.6328898520108956m, 7.314957794295983m },
                    { new Guid("ba7285e5-8e3d-45bd-9951-2a52e469204c"), "Pagani Automobili S.p.A.", "Jamison", "Ash", 45.278270343256636, 19.852105063006313, null, 1.3374700364494403m, 8.12755415792042m },
                    { new Guid("bbed36f7-c09b-4e11-b462-517555b0db9c"), "RAM", "Welch", "Vaishali", 45.226846241954064, 19.839414266674314, null, 1.3494145070278685m, 3.1034505930423064m },
                    { new Guid("bc2dd468-cbfa-436b-8c06-c63432afe1cb"), "Porsche", "Jen", "Shar", 45.210580578767569, 19.787137195434291, null, 1.7006360867551042m, 9.781009068780087m },
                    { new Guid("be0edef1-82b8-46b3-82c3-32c1d5905e7e"), "Aston Martin Lagonda Ltd", "Leonard", "Emerald", 45.2572972194831, 19.855507893571811, null, 1.2124823508556823m, 10.14906639309747m },
                    { new Guid("be8c81b2-6524-4029-b864-b00fe69eddb5"), "Porsche", "Vlada", "Marisela", 45.275549215170642, 19.878672958375621, null, 1.692150219149442m, 4.292175821808732m },
                    { new Guid("bf973366-76c0-40e0-9808-9f094d0f1831"), "RAM", "Renata", "Yadi", 45.296758424609912, 19.847822587069356, null, 1.5933840239464465m, 3.1678197529395926m },
                    { new Guid("c0d20491-9f8e-45c4-9d59-9184821281b8"), "MAZDA", "Megpg", "Eunice", 45.219490140494258, 19.798772403836473, null, 1.3455814143383005m, 9.776292871306692m },
                    { new Guid("c21adf28-b39d-4178-a90f-9f60afe021b0"), "Lamborghini", "Letizia", "Kerry", 45.281638953906281, 19.813600296747204, null, 1.099366625884517m, 1.3295397945411715m },
                    { new Guid("c259e9fc-616a-49a8-9a4d-d95a3f281efc"), "Ford", "Leif", "Nalini", 45.281617289392479, 19.841755384683445, null, 1.0236099738160866m, 2.7658329456040622m },
                    { new Guid("c2813caf-3f33-482b-bcda-ea7e2c68d0d5"), "MASERATI", "Vartan", "Rhee", 45.298049374458131, 19.878864637212104, null, 1.5393415373611448m, 6.559482220099541m },
                    { new Guid("c3b2d051-4bea-430a-ba2c-6237385a6323"), "Audi", "Marc", "Erin", 45.262776103747605, 19.866401987510415, null, 1.0237952565130846m, 1.8608874905715336m },
                    { new Guid("c6da2802-7b31-4df1-b625-fa210b67b98a"), "Honda", "Marin", "Jesus", 45.296192164092709, 19.814406778655229, null, 1.308227287026685m, 3.9326792288937376m },
                    { new Guid("c738c12a-4816-4bb3-8566-6fff586a0d02"), "Roush", "Bernardino", "Danel", 45.262091751738382, 19.836733731194897, null, 1.685522127629019m, 5.239149409686604m },
                    { new Guid("c8f23b56-ec03-4e04-841b-10d67679d917"), "Aston Martin Lagonda Ltd", "Oracio", "Richie", 45.224688333074994, 19.83919841648629, null, 1.385540803473964m, 9.910185805400143m },
                    { new Guid("c99d0695-ee18-43bd-b3de-17507a6a7212"), "Volvo", "Jessa", "Tetiana", 45.228208563610373, 19.864794930227959, null, 1.4501630881251706m, 4.989849053623997m },
                    { new Guid("cbde1468-fd2b-4e7a-9451-fd9bf7f1247e"), "Subaru", "Lombardet", "Casandra", 45.250568287681887, 19.824187873005126, null, 1.6563058877839092m, 10.512932624252946m },
                    { new Guid("cc58a4e5-6cd1-452b-804e-7170b7f5e4c3"), "Land Rover", "Maurits", "Anurag", 45.253925064457675, 19.828862737626718, null, 1.7104501368390608m, 4.2596837052732415m },
                    { new Guid("cd2cd1f0-ee88-4995-ad0d-c38a45295d00"), "Mitsubishi Motors Corporation", "Bechmann", "Maikol", 45.279071426502327, 19.862370160619843, null, 1.324328579217307m, 4.565442360558393m },
                    { new Guid("cee32e4f-69ac-4e7d-89b4-884b4468bf95"), "Acura", "Jasmine", "Dorothy", 45.209423511503424, 19.81749485016757, null, 1.3610869109414416m, 7.115251420780801m },
                    { new Guid("cf73b305-7718-4c06-b775-13ce02988ef4"), "McLaren", "Flora", "Allesdandro", 45.250220306572913, 19.80629652423562, null, 1.6560543096854814m, 9.747141997226342m },
                    { new Guid("d02c5986-3109-47a4-9c2a-b694c0828c88"), "TOYOTA", "Aden", "Eliza", 45.268648133812405, 19.831866095348715, null, 1.391490893102681m, 8.095125839709704m },
                    { new Guid("d062333d-fe6f-4d92-8a85-d8907fad8c6f"), "MASERATI", "Residencia", "Casper", 45.229981095425153, 19.837153864471194, null, 1.554999380283847m, 9.574431191837565m },
                    { new Guid("d2e13c47-8287-4061-8ff0-55c3fb329f4f"), "INFINITI", "Bici", "Travis", 45.201686751190202, 19.802496053471067, null, 1.2016309984417113m, 10.491378188758173m },
                    { new Guid("d522e051-53fb-40ab-9e9f-068ce3fe5a4c"), "Audi", "Beata", "Salome", 45.29945492843008, 19.844297003241515, null, 1.0417866558859206m, 1.2473101141077794m },
                    { new Guid("d5c7c579-4e95-4787-aa91-fb35268240ce"), "INFINITI", "Deepti", "Devara", 45.275913260410107, 19.85081695839504, null, 1.6342564595450453m, 10.57353943753355m },
                    { new Guid("d852fa79-8ede-4f2d-8468-4c751f3563e6"), "Lincoln", "Delair", "Meredith", 45.252036208353331, 19.868004870058986, null, 1.6143386734417438m, 6.054391760371328m },
                    { new Guid("d906ebce-c7bc-4cc4-a0a1-f5594d458ab8"), "Roush", "Iva", "Sloane", 45.218399244374908, 19.792091597548286, null, 1.6978977180498203m, 8.769920005723455m },
                    { new Guid("dad66d14-6ba1-4f54-92d9-8802800f8a0b"), "SCION", "Vanessa", "Moran", 45.243401442719865, 19.845486901252453, null, 1.766625245740726m, 1.5974547157697985m },
                    { new Guid("db7fce03-8c7c-4cbc-b3e3-5b8672cc9a33"), "Aston Martin Lagonda Ltd", "Knox", "Lorrie", 45.264656353292338, 19.837986673820598, null, 1.536456046701279m, 4.863201684677997m },
                    { new Guid("db885804-d3fa-417a-bb6e-4bb57791ddba"), "Audi", "Marc", "Erin", 45.262776103747605, 19.866401987510415, null, 1.0237952565130846m, 1.8608874905715336m },
                    { new Guid("dd44f5bd-9909-4e06-8571-6107bc150d54"), "Acura", "Anais", "Johnna", 45.287676498702332, 19.843019007354567, null, 1.1278655668254658m, 10.710397156830041m },
                    { new Guid("dd85533d-f31c-4c65-ba44-df9aee6ab00b"), "INFINITI", "Jastinder", "Homero", 45.269815899190036, 19.810080082882855, null, 1.5244558202271907m, 1.9469998885842523m },
                    { new Guid("dd917af0-2b32-4b19-918d-090d072a9e38"), "LEXUS", "Raina", "Lula", 45.223453054301878, 19.830829334577729, null, 1.0164590921625576m, 6.269772816844689m },
                    { new Guid("ddf9b38e-6a40-448c-9680-66c99ad9ec1f"), "Chevrolet", "Krizia", "Brusovanik", 45.267957633744437, 19.799666210958843, null, 1.6786208486121708m, 7.342233447742731m },
                    { new Guid("de673212-bcd9-488d-91b1-05a58255a1a4"), "Mini", "Jerildy", "Tzipora", 45.26373409468961, 19.820524995264094, null, 1.6770837896990307m, 3.156359811608757m },
                    { new Guid("deff0900-d12a-4d20-b7b2-78943da301b6"), "Jaguar", "Dilini", "Joy", 45.204205166231176, 19.821658287825695, null, 1.5632855538691586m, 9.828321299882433m },
                    { new Guid("e0b54961-c13b-4610-ba02-b19fad7e52ea"), "Jaguar", "Mannix", "Gisella", 45.296266247572717, 19.804770086487757, null, 1.6910908453429156m, 3.2823166597464395m },
                    { new Guid("e2fd1e97-26a8-4f50-bcb5-edad4e2bb6bc"), "Mini", "Larae", "Lindsey", 45.288988349342716, 19.869009669621189, null, 1.2705361960792216m, 3.7409616159613304m }
                });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Driver_ID", "Brand", "FirstName", "LastName", "Latitude", "Longitude", "PassengerId", "PricePerKM", "StartPrice" },
                values: new object[,]
                {
                    { new Guid("e3891920-093b-4505-8d88-3edfd71af174"), "Porsche", "Chrissy", "Tanyia", 45.279449168518042, 19.785822522191463, null, 1.4492458808602435m, 2.028265801352166m },
                    { new Guid("e390432e-6166-4b2a-82eb-d34dbfe2f05b"), "Mitsubishi Motors Corporation", "Yev", "Leeann", 45.243827207876294, 19.795146332823769, null, 1.4038353529833358m, 7.1267708754257715m },
                    { new Guid("e5d1195b-0a31-421a-9298-bd488c872b73"), "INFINITI", "Haas", "Chad", 45.288022877311491, 19.874835733268696, null, 1.5866952090365798m, 8.087357945507915m },
                    { new Guid("e747edbe-54c7-461f-a981-1cfdb0aa51db"), "Roush", "Iva", "Sloane", 45.218399244374908, 19.792091597548286, null, 1.6978977180498203m, 8.769920005723455m },
                    { new Guid("e751d6c3-c2f3-4b7e-bf5d-ce29643e65a5"), "Bentley", "Liliya", "Yeliz", 45.278508705345807, 19.806480944684065, null, 1.7553152421709535m, 4.360324081230656m },
                    { new Guid("e8a4de0f-3585-4101-88db-0b05bf83c859"), "INFINITI", "Bici", "Travis", 45.201686751190202, 19.802496053471067, null, 1.2016309984417113m, 10.491378188758173m },
                    { new Guid("e8bc8f61-37f5-434d-8323-66edc2a2b5bd"), "Mercedes-Benz", "Fernanda", "Berry", 45.284341031601357, 19.88214656986014, null, 1.228808543535298m, 2.642344591342897m },
                    { new Guid("e913be81-e033-4fbf-9449-e0eb4d3e4a59"), "Mini", "Jerildy", "Tzipora", 45.26373409468961, 19.820524995264094, null, 1.6770837896990307m, 3.156359811608757m },
                    { new Guid("ea16ab2f-22b2-4191-9d38-42aaab2ea8f9"), "RAM", "Welch", "Vaishali", 45.226846241954064, 19.839414266674314, null, 1.3494145070278685m, 3.1034505930423064m },
                    { new Guid("ea4b884f-1c9b-469a-8a54-7a393cbeec1c"), "Rolls-Royce Motor Cars Limited", "Henrik", "Edwin", 45.260099746320648, 19.846618295659582, null, 1.452835505779086m, 8.383483200020429m },
                    { new Guid("ea8ce5e9-d20a-4761-bf8d-cb75bc6620f8"), "Volvo", "Emma", "Tasha", 45.285854370015166, 19.866548271059557, null, 1.0566431268333218m, 8.509215393598028m },
                    { new Guid("eab31a7f-c00b-46da-b417-f1ccdeed11d7"), "Dodge", "Construccion", "Petty", 45.227061274337601, 19.836243969656948, null, 1.0452853161733882m, 3.69863700318812m },
                    { new Guid("eb60d9db-333c-416a-8770-f9d964de8353"), "TOYOTA", "Dang", "Erskine", 45.217855950352465, 19.834207010840032, null, 1.7497987535854724m, 4.824188848962091m },
                    { new Guid("ecce5250-ae16-4fe9-80e9-73645ab2ae05"), "MASERATI", "Residencia", "Casper", 45.229981095425153, 19.837153864471194, null, 1.554999380283847m, 9.574431191837565m },
                    { new Guid("eebb9390-17e9-43f2-8dce-f95891abba9b"), "Lincoln", "Geri", "Miii", 45.240326613759379, 19.856313447907667, null, 1.7338599905115184m, 10.732414512171566m },
                    { new Guid("f0061663-8156-4aad-82ec-42d4f28abede"), "Bentley", "Ann", "Canosa", 45.204344318934922, 19.835281956415212, null, 1.476499130995161m, 3.3429406521108387m },
                    { new Guid("f14f1d44-bbc0-47a3-ac24-c5fb75a776c3"), "MAZDA", "Megpg", "Eunice", 45.219490140494258, 19.798772403836473, null, 1.3455814143383005m, 9.776292871306692m },
                    { new Guid("f1e8ce6a-3012-44a0-bcac-703b92e9d7a2"), "Roush", "Bernardino", "Danel", 45.262091751738382, 19.836733731194897, null, 1.685522127629019m, 5.239149409686604m },
                    { new Guid("f21126e4-e5cc-4299-bf9e-ad8871fd906c"), "Chrysler", "Ibrahim", "Alina", 45.2993118675817, 19.796265612687975, null, 1.1089619486674978m, 10.521486246480235m },
                    { new Guid("f406a48d-f033-4c48-bf69-92edaef31766"), "MAZDA", "Rafal", "Monserrat", 45.282153330425473, 19.800982908909283, null, 1.0444604099295751m, 6.848472092200129m },
                    { new Guid("f47f00b3-31f5-451b-ac73-0448dcf217d7"), "Land Rover", "Oja", "Chin", 45.256914630896212, 19.858970871427317, null, 1.26487632045056m, 10.747802492089736m },
                    { new Guid("f5231102-80c8-463c-b764-4337e59c033a"), "Mercedes-Benz", "Osvando", "Nicolaios", 45.216763399661289, 19.839646217936401, null, 1.390698997245516m, 2.4629580725247315m },
                    { new Guid("f6a1daa0-a792-4ed1-9d8a-860375a0d4fa"), "ALFA ROMEO", "Allison", "Royden", 45.295945743171906, 19.857674174593402, null, 1.5237046745427651m, 10.405094574404158m },
                    { new Guid("f6b354a5-2fc3-4251-ba89-eefd48b1755f"), "RAM", "Renata", "Yadi", 45.296758424609912, 19.847822587069356, null, 1.5933840239464465m, 3.1678197529395926m },
                    { new Guid("f7c9c2b0-9244-470b-b794-a33b438877de"), "Aston Martin Lagonda Ltd", "Knox", "Lorrie", 45.264656353292338, 19.837986673820598, null, 1.536456046701279m, 4.863201684677997m },
                    { new Guid("f902a86c-17ec-47f9-8b7a-bd2fbe70feac"), "CHEVROLET", "Edouard", "Jehan", 45.210031240196187, 19.819412677818654, null, 1.2289611665909137m, 10.316446613551822m },
                    { new Guid("fb6fa24d-b205-4bba-bda9-d20514a1d6eb"), "Honda", "Talbot", "Carwen", 45.250169050776421, 19.794775524085665, null, 1.4473141471090796m, 4.881600711969098m },
                    { new Guid("fb9c9b08-bf08-4219-87dc-13e076234d69"), "Mercedes-Benz", "Marielle", "Orzai", 45.247779667723108, 19.842528794842231, null, 1.1929093189440756m, 4.356274892567532m },
                    { new Guid("fc83164f-fe5d-4ecf-a0a7-e9c511c3c624"), "MASERATI", "Vartan", "Rhee", 45.298049374458131, 19.878864637212104, null, 1.5393415373611448m, 6.559482220099541m },
                    { new Guid("fe7feb69-7ecd-4bd2-b3cb-fc03095d0ef2"), "GMC", "Brehan", "Leonardo", 45.284932615672936, 19.861347707346106, null, 1.0165564995215457m, 10.543527811952874m },
                    { new Guid("fe9d6d97-a9f5-4f13-a507-deeafd24ee1d"), "Cadillac", "Olga", "Kristen", 45.29340112834867, 19.822498825540769, null, 1.6875309773099558m, 6.45756305740285m },
                    { new Guid("feb41b55-5596-43fe-8e3c-17c5bb402cb3"), "Lamborghini", "Ilhan", "Reserved", 45.269939911723235, 19.805821814574692, null, 1.7714084180476508m, 8.149353140401365m }
                });

            migrationBuilder.InsertData(
                table: "Passengers",
                columns: new[] { "PassengerId", "Birthday", "Driver_ID", "Email", "PassengerLastname", "PassengerName", "PassengersLatitude", "PassengersLongitude" },
                values: new object[,]
                {
                    { new Guid("06775d5a-abc9-45a6-b72d-389a960875b5"), new DateTime(1992, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), "jelena@example.com", "Jankovic", "Jelena", 44.012793528768192, 20.91142273005126 },
                    { new Guid("2428420c-6bd0-4fc6-a52b-7f29c070d023"), new DateTime(1994, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), "marija@example.com", "Maric", "Marija", 44.01652128768189, 21.00585973005126 },
                    { new Guid("bedb1cbd-42ce-486a-bb9e-6a865239934a"), new DateTime(1990, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), "marko@example.com", "Petrovic", "Marko", 43.32090222876819, 21.895758973005126 },
                    { new Guid("c7423a0c-aef3-4057-9329-32c4c1171330"), new DateTime(1993, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), "raca93@gmail.com", "Bjelic", "Radivoje", 45.290568287681893, 19.924187873005128 },
                    { new Guid("d6ecccc1-13e7-4b8b-8fa0-e2a93e77977e"), new DateTime(1987, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), "ana@example.com", "Ivanovic", "Ana", 44.786568287681888, 20.448921673005128 },
                    { new Guid("dc2b9d70-c09e-47cd-b17c-d6b12f080b40"), new DateTime(1985, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), "nikola@example.com", "Nikolic", "Nikola", 45.26713522876819, 19.833549673005127 }
                });

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
                name: "Rides");

            migrationBuilder.DropTable(
                name: "Drivers");

            migrationBuilder.DropTable(
                name: "Rating");

            migrationBuilder.DropTable(
                name: "Passengers");
        }
    }
}
