using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RadivojeBjelic_DeltaDrive_Delta.Migrations
{
    public partial class Remodelovanje : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    PricePerKM = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.Driver_ID);
                });

            migrationBuilder.CreateTable(
                name: "Passengers",
                columns: table => new
                {
                    PassengerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PassengerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PassengerLastname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PassengersLatitude = table.Column<double>(type: "float", nullable: false),
                    PassengersLongitude = table.Column<double>(type: "float", nullable: false),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Driver_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Driver_ID1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passengers", x => x.PassengerId);
                    table.ForeignKey(
                        name: "FK_Passengers_Drivers_Driver_ID1",
                        column: x => x.Driver_ID1,
                        principalTable: "Drivers",
                        principalColumn: "Driver_ID");
                });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Driver_ID", "Brand", "FirstName", "LastName", "Latitude", "Longitude", "PricePerKM", "StartPrice" },
                values: new object[,]
                {
                    { new Guid("004f8065-741c-42d8-a485-f4273b57279b"), "Honda", "Marin", "Jesus", 45.296192164092709, 19.814406778655229, 1.308227287026685m, 3.9326792288937376m },
                    { new Guid("00ed8c46-ffa3-4c22-a409-1f305083babd"), "Roush", "Evangeline", "Granados", 45.255782205655841, 19.854106076392526, 1.7553795014338474m, 6.146249025698085m },
                    { new Guid("02b06b4a-0970-44fa-a501-c47e99763c9d"), "MAZDA", "Callaghan", "Aiden", 45.215384546791014, 19.846282477003452, 1.7442378744022409m, 4.395966844983313m },
                    { new Guid("049beddc-c35c-45eb-97c4-7c8db57faee9"), "Aston Martin Lagonda Ltd", "Knox", "Lorrie", 45.264656353292338, 19.837986673820598, 1.536456046701279m, 4.863201684677997m },
                    { new Guid("05d4fc4b-82f1-4379-a57f-d71fcc94b4ff"), "LEXUS", "Raina", "Lula", 45.223453054301878, 19.830829334577729, 1.0164590921625576m, 6.269772816844689m },
                    { new Guid("06c5426d-5c5a-42ba-ad94-eb6d163f0c54"), "CHEVROLET", "Edouard", "Jehan", 45.210031240196187, 19.819412677818654, 1.2289611665909137m, 10.316446613551822m },
                    { new Guid("06f5b20c-bdc1-486b-9ad7-c49ba597ea12"), "McLaren", "Flora", "Allesdandro", 45.250220306572913, 19.80629652423562, 1.6560543096854814m, 9.747141997226342m },
                    { new Guid("07447853-826c-4106-a0be-26265b9bc28d"), "Volvo", "Zena", "Kirstein", 45.238319779725494, 19.810359597732457, 1.7020772550670218m, 10.79799094974425m },
                    { new Guid("08e73432-0a78-4048-aff7-06cea714f543"), "MAZDA", "Rafal", "Monserrat", 45.282153330425473, 19.800982908909283, 1.0444604099295751m, 6.848472092200129m },
                    { new Guid("0bbd6798-1646-4315-844b-15555b3de3d7"), "Pagani Automobili S.p.A.", "Morrissey", "Kellie", 45.274651670577768, 19.791858685850482, 1.3417230653533827m, 2.18234253206158m },
                    { new Guid("0bdb282d-8dc3-4f04-ba4d-91594732c427"), "Volvo", "Emma", "Tasha", 45.285854370015166, 19.866548271059557, 1.0566431268333218m, 8.509215393598028m },
                    { new Guid("0e5e2c58-456c-4ece-9ddb-bebefead92d1"), "Chevrolet", "Jerome", "Hoj", 45.26187929944556, 19.852975472519034, 1.332259599316662m, 4.833445837024005m },
                    { new Guid("0f2e37a7-ced4-440e-aeca-59bb1225cad8"), "Bentley", "Liliya", "Yeliz", 45.278508705345807, 19.806480944684065, 1.7553152421709535m, 4.360324081230656m },
                    { new Guid("0f6e6cdb-f2a7-481d-a41d-9e51c682e476"), "Porsche", "Jen", "Shar", 45.210580578767569, 19.787137195434291, 1.7006360867551042m, 9.781009068780087m },
                    { new Guid("1062708d-0f1e-4306-886b-c4d614580702"), "Lamborghini", "Letizia", "Kerry", 45.281638953906281, 19.813600296747204, 1.099366625884517m, 1.3295397945411715m },
                    { new Guid("1194288c-31fb-477d-b391-14e72a689524"), "CHEVROLET", "Edouard", "Jehan", 45.210031240196187, 19.819412677818654, 1.2289611665909137m, 10.316446613551822m },
                    { new Guid("11cf873e-c3b9-4ca6-ae6a-aceb4d0c375a"), "TOYOTA", "Aden", "Eliza", 45.268648133812405, 19.831866095348715, 1.391490893102681m, 8.095125839709704m },
                    { new Guid("129a25cc-b3e8-403b-9fdd-ee8ae521583b"), "MAZDA", "Callaghan", "Aiden", 45.215384546791014, 19.846282477003452, 1.7442378744022409m, 4.395966844983313m },
                    { new Guid("14c8a248-1387-4c3c-87fc-a7141c2e5b94"), "Audi", "Carling", "Angeles", 45.256456267336631, 19.839344022449293, 1.2919937229218867m, 3.8797762168830876m },
                    { new Guid("160e8582-8601-4fe3-b4ca-1a0a93cf1c12"), "BMW", "Alessandro", "Ame", 45.213878946434399, 19.83500906624565, 1.1394055188065981m, 10.629290075265152m },
                    { new Guid("17185874-f9ac-4c5d-ae10-37dfb677c83b"), "Lamborghini", "Aparna", "Segundo", 45.225215199148884, 19.883468373193303, 1.2154110733189056m, 3.652480026698223m },
                    { new Guid("1783f8ec-65b1-49ad-8d32-b32e8ca55836"), "Acura", "Jasmine", "Dorothy", 45.209423511503424, 19.81749485016757, 1.3610869109414416m, 7.115251420780801m },
                    { new Guid("17af9d25-b076-479c-8067-a7eb35beb4b1"), "Mini", "Rue", "Henrik", 45.234728393171295, 19.822851909980773, 1.1939296054078634m, 1.7459564675100006m },
                    { new Guid("18737044-2853-4641-995d-e7c3dc8199b6"), "Ford", "Leif", "Nalini", 45.281617289392479, 19.841755384683445, 1.0236099738160866m, 2.7658329456040622m },
                    { new Guid("1c7c79f8-0d24-4433-b67e-11f1d48d959c"), "Roush", "Dahlia", "Pandora", 45.222647874969191, 19.786655808995068, 1.0651228912043087m, 7.807872207177916m },
                    { new Guid("1dbf0f27-0f20-47b7-b767-07dc6c238682"), "Mini", "Larae", "Lindsey", 45.288988349342716, 19.869009669621189, 1.2705361960792216m, 3.7409616159613304m },
                    { new Guid("1e5572bb-4cde-462b-a2f5-f5c475909b5c"), "Lincoln", "Geri", "Miii", 45.240326613759379, 19.856313447907667, 1.7338599905115184m, 10.732414512171566m },
                    { new Guid("1e6f4371-9a29-46c5-b7fa-5942346673e9"), "Volvo", "Lluvia", "Judd", 45.244554013188768, 19.872895707350001, 1.253412375617725m, 5.882144460892146m },
                    { new Guid("1ed9a879-5c07-4acf-8556-0fec3d4fc5e8"), "INFINITI", "Deepti", "Devara", 45.275913260410107, 19.85081695839504, 1.6342564595450453m, 10.57353943753355m },
                    { new Guid("1ee63e78-b3f5-4bcd-9ae5-b3a2a327ebd8"), "Mitsubishi Motors Corporation", "Yev", "Leeann", 45.243827207876294, 19.795146332823769, 1.4038353529833358m, 7.1267708754257715m },
                    { new Guid("1f75dd9c-ae53-4a95-95af-6c3cb4521034"), "Cadillac", "Olga", "Kristen", 45.29340112834867, 19.822498825540769, 1.6875309773099558m, 6.45756305740285m },
                    { new Guid("1f9012c8-c693-43f7-a27e-db5df7e629af"), "FIAT", "Harold", "Karl", 45.286324628710155, 19.859015812248142, 1.7153672461915734m, 9.684974884213723m },
                    { new Guid("1f95bcb6-4a61-4aad-848f-206ddab5f6ef"), "MASERATI", "Residencia", "Casper", 45.229981095425153, 19.837153864471194, 1.554999380283847m, 9.574431191837565m },
                    { new Guid("1fe83549-acb6-4b69-9775-c412beaed7fb"), "Subaru", "Lombardet", "Casandra", 45.250568287681887, 19.824187873005126, 1.6563058877839092m, 10.512932624252946m },
                    { new Guid("1ffe09e2-17b2-4429-9654-980caec3c1a1"), "Pagani Automobili S.p.A.", "Jamison", "Ash", 45.278270343256636, 19.852105063006313, 1.3374700364494403m, 8.12755415792042m },
                    { new Guid("2248aa70-296b-4fef-ae1a-6a3c2faac544"), "CHEVROLET", "Construccion", "Rossi", 45.287037867075718, 19.853352110430713, 1.1262567197952467m, 4.052167523478899m },
                    { new Guid("232f9be4-85e6-4760-8ad7-57eeb939e69d"), "Jaguar", "Dilini", "Joy", 45.204205166231176, 19.821658287825695, 1.5632855538691586m, 9.828321299882433m },
                    { new Guid("25beea4f-0993-4160-a8ee-d7e32898a6d1"), "Mercedes-Benz", "Osvando", "Nicolaios", 45.216763399661289, 19.839646217936401, 1.390698997245516m, 2.4629580725247315m },
                    { new Guid("25c41ca6-9718-41ba-87f6-ad04f1683c32"), "Audi", "Carling", "Angeles", 45.256456267336631, 19.839344022449293, 1.2919937229218867m, 3.8797762168830876m },
                    { new Guid("25c4950a-f6ad-479b-b42a-d32327389a07"), "Mercedes-Benz", "Marielle", "Orzai", 45.247779667723108, 19.842528794842231, 1.1929093189440756m, 4.356274892567532m },
                    { new Guid("27018c47-1d13-4f78-9d77-8bc26d32fadd"), "Chrysler", "Ibrahim", "Alina", 45.2993118675817, 19.796265612687975, 1.1089619486674978m, 10.521486246480235m },
                    { new Guid("275747aa-e0e0-4ef5-9876-0f69d3830422"), "Mini", "Dianna", "Michal", 45.247323100321054, 19.842409377101806, 1.0397465494006515m, 5.223227457896003m }
                });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Driver_ID", "Brand", "FirstName", "LastName", "Latitude", "Longitude", "PricePerKM", "StartPrice" },
                values: new object[,]
                {
                    { new Guid("27fd59ac-d347-49a6-a6e5-776e05dfb800"), "Chevrolet", "Jerome", "Hoj", 45.26187929944556, 19.852975472519034, 1.332259599316662m, 4.833445837024005m },
                    { new Guid("29a951aa-9c60-47e6-b702-da80a93558a1"), "Chevrolet", "Krizia", "Brusovanik", 45.267957633744437, 19.799666210958843, 1.6786208486121708m, 7.342233447742731m },
                    { new Guid("2a09445a-d8e3-4f0c-b7e5-925bb792cff1"), "Aston Martin Lagonda Ltd", "Leonard", "Emerald", 45.2572972194831, 19.855507893571811, 1.2124823508556823m, 10.14906639309747m },
                    { new Guid("2c3a4a08-68c9-456b-bcdc-a2321d3ee6df"), "INFINITI", "Haas", "Chad", 45.288022877311491, 19.874835733268696, 1.5866952090365798m, 8.087357945507915m },
                    { new Guid("2c798ef9-021d-4356-85c3-5e064738b6a6"), "Honda", "Talbot", "Carwen", 45.250169050776421, 19.794775524085665, 1.4473141471090796m, 4.881600711969098m },
                    { new Guid("2ea4c2d1-ba88-49c7-b891-d6101e41ec6d"), "Jaguar", "Mannix", "Gisella", 45.296266247572717, 19.804770086487757, 1.6910908453429156m, 3.2823166597464395m },
                    { new Guid("2edec98c-4caa-4af2-9f81-4e0ab657a19e"), "Chrysler", "Ibrahim", "Alina", 45.2993118675817, 19.796265612687975, 1.1089619486674978m, 10.521486246480235m },
                    { new Guid("2f39e627-71d0-4476-88ae-cef5dcdbdb4c"), "Aston Martin Lagonda Ltd", "Oracio", "Richie", 45.224688333074994, 19.83919841648629, 1.385540803473964m, 9.910185805400143m },
                    { new Guid("2ff486c2-9f30-4e85-8092-b84b2984139c"), "Ford", "Leif", "Nalini", 45.281617289392479, 19.841755384683445, 1.0236099738160866m, 2.7658329456040622m },
                    { new Guid("30b2a683-5a45-423a-8ab0-83f36dd32454"), "Lincoln", "Javid", "Tranta", 45.216149699839988, 19.853299911074188, 1.214353703785661m, 4.696927726796888m },
                    { new Guid("331f51d6-26a6-4496-9f7b-0c5ea14e8cb7"), "Dodge", "Construccion", "Petty", 45.227061274337601, 19.836243969656948, 1.0452853161733882m, 3.69863700318812m },
                    { new Guid("356bbd30-4d05-4aa5-a498-e625b3f528c2"), "Cadillac", "Misael", "Gizelle", 45.260938791275308, 19.796892550971364, 1.0686156356587282m, 4.528765037827812m },
                    { new Guid("3658c7b4-07fa-4fed-8e6d-cbea815121c4"), "Volvo", "Lluvia", "Judd", 45.244554013188768, 19.872895707350001, 1.253412375617725m, 5.882144460892146m },
                    { new Guid("38db4659-0861-4450-9774-d44a26ddcaa3"), "Roush", "Bernardino", "Danel", 45.262091751738382, 19.836733731194897, 1.685522127629019m, 5.239149409686604m },
                    { new Guid("39056de4-7733-4124-a4a1-c96782d4979f"), "Jeep", "Jurg", "Colleen", 45.27947091909018, 19.803280137550804, 1.0642568736345543m, 1.1178482649382784m },
                    { new Guid("39c24b9e-1ddb-49c7-bd19-8057639d1a11"), "Lincoln", "Gert", "Andres", 45.279225594403293, 19.790054798757847, 1.1643840016635394m, 1.328847558195744m },
                    { new Guid("39f89afa-55cf-4ee1-9b7d-3f7f537c9eed"), "Cadillac", "Misael", "Gizelle", 45.260938791275308, 19.796892550971364, 1.0686156356587282m, 4.528765037827812m },
                    { new Guid("3d835d11-bd1d-4f58-a9cb-19b628341843"), "Chevrolet", "Trace", "Gerry", 45.290891491829363, 19.828444245832451, 1.6389965205075372m, 8.368466873577997m },
                    { new Guid("3ed4518b-c31a-4aa1-ba3b-a8a495fd5d87"), "Roush", "Bernardino", "Danel", 45.262091751738382, 19.836733731194897, 1.685522127629019m, 5.239149409686604m },
                    { new Guid("40d545f8-7efa-402a-9380-174d4c1a166d"), "Porsche", "Vlada", "Marisela", 45.275549215170642, 19.878672958375621, 1.692150219149442m, 4.292175821808732m },
                    { new Guid("4194f64a-7219-4e79-b1b2-4833170f4761"), "Honda", "Talbot", "Carwen", 45.250169050776421, 19.794775524085665, 1.4473141471090796m, 4.881600711969098m },
                    { new Guid("43615c9a-26ce-479f-bc8f-b13951a4d159"), "MASERATI", "Residencia", "Casper", 45.229981095425153, 19.837153864471194, 1.554999380283847m, 9.574431191837565m },
                    { new Guid("44f7d60c-3de8-4a86-ae66-252fa0e800a5"), "MASERATI", "Vartan", "Rhee", 45.298049374458131, 19.878864637212104, 1.5393415373611448m, 6.559482220099541m },
                    { new Guid("456a7d1b-7746-459a-a1ae-ffea5698a11d"), "Aston Martin Lagonda Ltd", "Elliot", "Loiselin", 45.222723321894421, 19.793603471598757, 1.5879618679964944m, 2.4186214661952135m },
                    { new Guid("46867f9b-6fd2-4fec-9400-41aedee06cff"), "INFINITI", "Haas", "Chad", 45.288022877311491, 19.874835733268696, 1.5866952090365798m, 8.087357945507915m },
                    { new Guid("494238bb-e11c-448c-88ef-f96e91909610"), "Mini", "Maurits", "Paulien", 45.296887928208001, 19.858852384808518, 1.7376903735062375m, 4.928084949383901m },
                    { new Guid("494922b3-7609-4670-8437-cb6dd3f87704"), "Porsche", "Chrissy", "Tanyia", 45.279449168518042, 19.785822522191463, 1.4492458808602435m, 2.028265801352166m },
                    { new Guid("49749ce2-f409-4189-952c-3f3b83d0f077"), "Bentley", "Lupita", "Bennet", 45.280486776875811, 19.844408581896609, 1.1702439175398553m, 10.496768111188889m },
                    { new Guid("4b387812-0212-4e57-b648-097e43713591"), "Volvo", "Taryn", "Bener", 45.230507721803349, 19.8096740775133, 1.58709815212918m, 10.487772005185393m },
                    { new Guid("506d7857-c454-4f42-bc68-695bc4bd2029"), "Lincoln", "Javid", "Tranta", 45.216149699839988, 19.853299911074188, 1.214353703785661m, 4.696927726796888m },
                    { new Guid("51455cca-569f-43a3-aeb0-f096d2ff904f"), "Lincoln", "Delair", "Meredith", 45.252036208353331, 19.868004870058986, 1.6143386734417438m, 6.054391760371328m },
                    { new Guid("564ea24b-e16c-4333-a23d-95b62425db09"), "GMC", "Brehan", "Leonardo", 45.284932615672936, 19.861347707346106, 1.0165564995215457m, 10.543527811952874m },
                    { new Guid("57f51d25-b3fe-4fe3-937f-7a9470e979c8"), "SCION", "Vanessa", "Moran", 45.243401442719865, 19.845486901252453, 1.766625245740726m, 1.5974547157697985m },
                    { new Guid("584dcfaf-bd1d-41af-810c-ced36f351e93"), "INFINITI", "Jastinder", "Homero", 45.269815899190036, 19.810080082882855, 1.5244558202271907m, 1.9469998885842523m },
                    { new Guid("585f6190-1600-4991-976d-9cd490026e19"), "Mini", "Jerildy", "Tzipora", 45.26373409468961, 19.820524995264094, 1.6770837896990307m, 3.156359811608757m },
                    { new Guid("59909f93-9942-469c-a01c-0c7f1537e342"), "Acura", "Anais", "Johnna", 45.287676498702332, 19.843019007354567, 1.1278655668254658m, 10.710397156830041m },
                    { new Guid("5a7fe07e-df81-401a-9e19-715715b5e7c0"), "Porsche", "Lily", "Eugenia", 45.257195153791159, 19.808529545036901, 1.7101176770777686m, 2.275882597440534m },
                    { new Guid("5a82e0bc-098d-44fa-b391-4ea63393fc10"), "INFINITI", "Bici", "Travis", 45.201686751190202, 19.802496053471067, 1.2016309984417113m, 10.491378188758173m },
                    { new Guid("5edd37f6-e50f-49c1-8b0b-88272e6d6800"), "MAZDA", "Megpg", "Eunice", 45.219490140494258, 19.798772403836473, 1.3455814143383005m, 9.776292871306692m },
                    { new Guid("617518ce-558e-45cc-bbee-75d9e08aa325"), "INFINITI", "Deepti", "Devara", 45.275913260410107, 19.85081695839504, 1.6342564595450453m, 10.57353943753355m },
                    { new Guid("62e7fac2-0433-4218-9664-824cd048a54e"), "RAM", "Renata", "Yadi", 45.296758424609912, 19.847822587069356, 1.5933840239464465m, 3.1678197529395926m },
                    { new Guid("6397731d-cdb3-4e9b-ba85-7331ef651772"), "Mitsubishi Motors Corporation", "Bechmann", "Maikol", 45.279071426502327, 19.862370160619843, 1.324328579217307m, 4.565442360558393m }
                });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Driver_ID", "Brand", "FirstName", "LastName", "Latitude", "Longitude", "PricePerKM", "StartPrice" },
                values: new object[,]
                {
                    { new Guid("645b43f5-7df5-40b1-bf13-48e5ef5481d5"), "Roush", "Iva", "Sloane", 45.218399244374908, 19.792091597548286, 1.6978977180498203m, 8.769920005723455m },
                    { new Guid("650da44e-796e-4181-86e7-63d617c6dde2"), "Chrysler", "Russell", "Rune", 45.223988703409404, 19.821203339044121, 1.669900944787707m, 7.442289794627493m },
                    { new Guid("6539d2b0-d6fa-40dc-8b24-8cc59a287592"), "Volvo", "Jessa", "Tetiana", 45.228208563610373, 19.864794930227959, 1.4501630881251706m, 4.989849053623997m },
                    { new Guid("65543524-2ba8-47c0-b78b-f5ae90a67519"), "Roush", "Rossane", "Jessica", 45.266559868005444, 19.829707954977223, 1.504112436608676m, 9.364469311550952m },
                    { new Guid("65bb1ac3-aee6-435e-b55d-3d11c03739ad"), "SCION", "Vanessa", "Moran", 45.243401442719865, 19.845486901252453, 1.766625245740726m, 1.5974547157697985m },
                    { new Guid("66f0b517-f7c8-491c-9986-330aa3b98552"), "Mercedes-Benz", "Marielle", "Orzai", 45.247779667723108, 19.842528794842231, 1.1929093189440756m, 4.356274892567532m },
                    { new Guid("68bb7bc8-be0d-4eac-8188-0de22e93dd76"), "Rolls-Royce Motor Cars Limited", "Henrik", "Edwin", 45.260099746320648, 19.846618295659582, 1.452835505779086m, 8.383483200020429m },
                    { new Guid("69192feb-4384-4d56-be24-288ac1ce2e82"), "Subaru", "Lombardet", "Casandra", 45.250568287681887, 19.824187873005126, 1.6563058877839092m, 10.512932624252946m },
                    { new Guid("6af9cdc2-f940-43ad-88ac-cc1ff5b77ed9"), "Audi", "Beata", "Salome", 45.29945492843008, 19.844297003241515, 1.0417866558859206m, 1.2473101141077794m },
                    { new Guid("6b48548b-6db8-4a8a-8309-f3c6c4cd03be"), "Acura", "Jasmine", "Dorothy", 45.209423511503424, 19.81749485016757, 1.3610869109414416m, 7.115251420780801m },
                    { new Guid("6bbb0c6b-1e5d-4f64-a2a2-4b1d72d2ffe6"), "NISSAN", "Rasika", "Raimundo", 45.291779211384224, 19.800023095935906, 1.0891868325268717m, 4.793560726767151m },
                    { new Guid("6f83c842-8391-4b95-bf3d-abbd60edfcd8"), "Jeep", "Jurg", "Colleen", 45.27947091909018, 19.803280137550804, 1.0642568736345543m, 1.1178482649382784m },
                    { new Guid("70e6035a-4dee-480a-9638-7126a83809a5"), "LEXUS", "Raina", "Lula", 45.223453054301878, 19.830829334577729, 1.0164590921625576m, 6.269772816844689m },
                    { new Guid("753f2925-74b3-4249-98a0-40a8078ab2e3"), "INFINITI", "Jastinder", "Homero", 45.269815899190036, 19.810080082882855, 1.5244558202271907m, 1.9469998885842523m },
                    { new Guid("76b5f07c-7843-4eb5-92f7-2c5d0582a177"), "Buick", "Edie", "Maeve", 45.204068043710627, 19.850483415082969, 1.2435787993749734m, 1.5525301188205578m },
                    { new Guid("76c5443c-3061-4bb5-afb2-ccf85b848931"), "TOYOTA", "Henry", "Violoncella", 45.220604547812769, 19.860464073132178, 1.6549856762871982m, 8.414841851640341m },
                    { new Guid("7824ddab-da6e-4589-a03c-d872fabb8446"), "Roush", "Rossane", "Jessica", 45.266559868005444, 19.829707954977223, 1.504112436608676m, 9.364469311550952m },
                    { new Guid("794c882e-1db7-4bea-b6f2-ce37ee43993b"), "Bentley", "Ann", "Canosa", 45.204344318934922, 19.835281956415212, 1.476499130995161m, 3.3429406521108387m },
                    { new Guid("795010f8-0342-4eb1-989f-105a941a5a40"), "MASERATI", "Magali", "Vibeke", 45.21619104847931, 19.788370458607901, 1.6719496977709882m, 4.795675055141949m },
                    { new Guid("7a110831-cb63-4fb9-b1d7-361ff7135db3"), "TOYOTA", "Henry", "Violoncella", 45.220604547812769, 19.860464073132178, 1.6549856762871982m, 8.414841851640341m },
                    { new Guid("7ac50c2b-3cb8-49c2-b09c-b2b219c50e41"), "MASERATI", "Magali", "Vibeke", 45.21619104847931, 19.788370458607901, 1.6719496977709882m, 4.795675055141949m },
                    { new Guid("7b7d56b4-0dd8-4995-8178-d723606918dd"), "Volvo", "Zena", "Kirstein", 45.238319779725494, 19.810359597732457, 1.7020772550670218m, 10.79799094974425m },
                    { new Guid("7c2ded8b-df82-4ce0-9748-ace51010bead"), "ALFA ROMEO", "Allison", "Royden", 45.295945743171906, 19.857674174593402, 1.5237046745427651m, 10.405094574404158m },
                    { new Guid("7de58d18-60c7-4028-8d5a-df9af1907d48"), "Jeep", "Iya", "Jhonatan", 45.276139257770936, 19.843919556371958, 1.6328898520108956m, 7.314957794295983m },
                    { new Guid("7e28c8db-7f33-4c48-9206-38b2e6e1d73d"), "Jeep", "Greening", "Brockie", 45.275815226573968, 19.811590339120048, 1.1547939566454073m, 4.416711302958615m },
                    { new Guid("7e576aed-b897-444a-969e-b1da9d3ad95e"), "Aston Martin Lagonda Ltd", "Oracio", "Richie", 45.224688333074994, 19.83919841648629, 1.385540803473964m, 9.910185805400143m },
                    { new Guid("7f30358d-fdcf-4f09-bab5-1e9f8609b89b"), "Mercedes-Benz", "Osvando", "Nicolaios", 45.216763399661289, 19.839646217936401, 1.390698997245516m, 2.4629580725247315m },
                    { new Guid("7fdde197-1eb4-4c44-9e51-cafbdd4d622d"), "MASERATI", "Vartan", "Rhee", 45.298049374458131, 19.878864637212104, 1.5393415373611448m, 6.559482220099541m },
                    { new Guid("815cf79b-f5cf-4c6d-850b-d38275208a05"), "Chevrolet", "Trace", "Gerry", 45.290891491829363, 19.828444245832451, 1.6389965205075372m, 8.368466873577997m },
                    { new Guid("81725eca-bf91-44ba-a666-cb28f3aca14e"), "Bentley", "Brandy", "Eleanor", 45.299538969878988, 19.880643245594662, 1.6281722977710191m, 5.728713211147051m },
                    { new Guid("823d041e-0c2e-473a-b620-1c9491a83229"), "TOYOTA", "Aden", "Eliza", 45.268648133812405, 19.831866095348715, 1.391490893102681m, 8.095125839709704m },
                    { new Guid("82bef847-e914-46e9-a206-056cfc05eb72"), "Chevrolet", "Krizia", "Brusovanik", 45.267957633744437, 19.799666210958843, 1.6786208486121708m, 7.342233447742731m },
                    { new Guid("82e65307-8ecd-43f6-99ce-8d9d481bb847"), "Honda", "Libbey", "Ernest", 45.282891901118944, 19.876434018077504, 1.2475192510221107m, 5.449373131830329m },
                    { new Guid("8388b74e-1fe6-4afe-a720-3eb434faf04f"), "Honda", "Libbey", "Ernest", 45.282891901118944, 19.876434018077504, 1.2475192510221107m, 5.449373131830329m },
                    { new Guid("83a09a3c-7d37-44d4-a0fe-203075edec9f"), "Mini", "Dianna", "Michal", 45.247323100321054, 19.842409377101806, 1.0397465494006515m, 5.223227457896003m },
                    { new Guid("843ce6a8-cbe6-4514-b9ca-1de609ca2d2b"), "Land Rover", "Maurits", "Anurag", 45.253925064457675, 19.828862737626718, 1.7104501368390608m, 4.2596837052732415m },
                    { new Guid("85756391-17df-4194-a24f-2b9b36e27288"), "Audi", "Marc", "Erin", 45.262776103747605, 19.866401987510415, 1.0237952565130846m, 1.8608874905715336m },
                    { new Guid("8602f474-7af7-4e28-bf7c-7448ea9c61c1"), "Mercedes-Benz", "Fernanda", "Berry", 45.284341031601357, 19.88214656986014, 1.228808543535298m, 2.642344591342897m },
                    { new Guid("86ed6231-0487-4491-8ff4-876948059104"), "Lamborghini", "Ilhan", "Reserved", 45.269939911723235, 19.805821814574692, 1.7714084180476508m, 8.149353140401365m },
                    { new Guid("88c42ff0-4574-44b1-ab37-549003dc713d"), "RAM", "Welch", "Vaishali", 45.226846241954064, 19.839414266674314, 1.3494145070278685m, 3.1034505930423064m },
                    { new Guid("89b4aa9c-f31a-4d25-93ee-303763bd75e1"), "McLaren", "Flora", "Allesdandro", 45.250220306572913, 19.80629652423562, 1.6560543096854814m, 9.747141997226342m },
                    { new Guid("8a888e51-d289-4afc-815d-51e45c3e8ecb"), "GMC", "Brehan", "Leonardo", 45.284932615672936, 19.861347707346106, 1.0165564995215457m, 10.543527811952874m }
                });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Driver_ID", "Brand", "FirstName", "LastName", "Latitude", "Longitude", "PricePerKM", "StartPrice" },
                values: new object[,]
                {
                    { new Guid("8aaf6785-8199-4bea-a62b-fba974da05ab"), "Porsche", "Lily", "Eugenia", 45.257195153791159, 19.808529545036901, 1.7101176770777686m, 2.275882597440534m },
                    { new Guid("8c189fa0-4c92-4adb-87bd-1db9a9122160"), "Pagani Automobili S.p.A.", "Jamison", "Ash", 45.278270343256636, 19.852105063006313, 1.3374700364494403m, 8.12755415792042m },
                    { new Guid("909fd388-272e-41c6-a9bf-7d9fced34691"), "INFINITI", "Bici", "Travis", 45.201686751190202, 19.802496053471067, 1.2016309984417113m, 10.491378188758173m },
                    { new Guid("94a1a6b4-40f2-4118-9dd9-c93eb954517d"), "Volvo", "Emma", "Tasha", 45.285854370015166, 19.866548271059557, 1.0566431268333218m, 8.509215393598028m },
                    { new Guid("95da0622-43a9-4b72-84d7-885b5fbf88e6"), "RAM", "Welch", "Vaishali", 45.226846241954064, 19.839414266674314, 1.3494145070278685m, 3.1034505930423064m },
                    { new Guid("96f0e248-5548-43c3-9e66-c83e44e740ad"), "Acura", "Anais", "Johnna", 45.287676498702332, 19.843019007354567, 1.1278655668254658m, 10.710397156830041m },
                    { new Guid("97fc57b1-f1de-4b96-ba5c-38aa6fd42e06"), "Buick", "Edie", "Maeve", 45.204068043710627, 19.850483415082969, 1.2435787993749734m, 1.5525301188205578m },
                    { new Guid("9904ec14-3a06-41df-ba75-3272832fc3d8"), "Pagani Automobili S.p.A.", "Morrissey", "Kellie", 45.274651670577768, 19.791858685850482, 1.3417230653533827m, 2.18234253206158m },
                    { new Guid("99192910-4ac8-4221-a84a-ee0f5893bf8c"), "BMW", "Jacques", "Lane", 45.213790253612132, 19.79774102895696, 1.7987752163597301m, 4.055436177433148m },
                    { new Guid("996c7174-0e4a-449f-95c9-4fa7c09d9a05"), "Porsche", "Jen", "Shar", 45.210580578767569, 19.787137195434291, 1.7006360867551042m, 9.781009068780087m },
                    { new Guid("9b42c480-d45f-46f8-b1a0-54d8cb4c9302"), "Dodge", "Andreas", "Adolfo", 45.265939837651047, 19.832946913832068, 1.7380170039298m, 8.510688070544214m },
                    { new Guid("9bcf9e97-850e-4dde-ae92-e0a7b91ed97d"), "Porsche", "Walker", "Maruk", 45.217759832566678, 19.812095479197652, 1.0201468787267918m, 8.987330756776993m },
                    { new Guid("9e637408-7f55-4bd3-8b38-01980a9da7ff"), "TOYOTA", "Dang", "Erskine", 45.217855950352465, 19.834207010840032, 1.7497987535854724m, 4.824188848962091m },
                    { new Guid("9ec52e95-d76e-4015-91b7-130c84988c06"), "Roush", "Iva", "Sloane", 45.218399244374908, 19.792091597548286, 1.6978977180498203m, 8.769920005723455m },
                    { new Guid("9f80a974-6245-4d0e-bf09-98eec6dc932c"), "Land Rover", "Maurits", "Anurag", 45.253925064457675, 19.828862737626718, 1.7104501368390608m, 4.2596837052732415m },
                    { new Guid("a02883ab-afe2-4546-99f5-9700ca57055c"), "Porsche", "Walker", "Maruk", 45.217759832566678, 19.812095479197652, 1.0201468787267918m, 8.987330756776993m },
                    { new Guid("a0c7d282-9b41-4dcc-99ec-9dde8a5ebea4"), "MAZDA", "Megpg", "Eunice", 45.219490140494258, 19.798772403836473, 1.3455814143383005m, 9.776292871306692m },
                    { new Guid("a34d507d-22cc-433f-ad47-d97d8bba3c88"), "Mitsubishi Motors Corporation", "Bechmann", "Maikol", 45.279071426502327, 19.862370160619843, 1.324328579217307m, 4.565442360558393m },
                    { new Guid("a449ce22-ca17-4d81-9a55-be975d35bc69"), "FIAT", "Harold", "Karl", 45.286324628710155, 19.859015812248142, 1.7153672461915734m, 9.684974884213723m },
                    { new Guid("a582e657-0c6d-469c-a2c2-a0b3dd58a66e"), "Aston Martin Lagonda Ltd", "Elliot", "Loiselin", 45.222723321894421, 19.793603471598757, 1.5879618679964944m, 2.4186214661952135m },
                    { new Guid("a6bc149d-8268-4864-923e-9e753a350589"), "BMW", "Alessandro", "Ame", 45.213878946434399, 19.83500906624565, 1.1394055188065981m, 10.629290075265152m },
                    { new Guid("a6e2999c-9738-4788-9338-7062817a8027"), "Aston Martin Lagonda Ltd", "Leonard", "Emerald", 45.2572972194831, 19.855507893571811, 1.2124823508556823m, 10.14906639309747m },
                    { new Guid("a84c0553-3ee3-4c31-9203-cc5d1c243799"), "Lincoln", "Gert", "Andres", 45.279225594403293, 19.790054798757847, 1.1643840016635394m, 1.328847558195744m },
                    { new Guid("ab71bdea-34ec-4c60-88f0-91453fec7055"), "Chrysler", "Russell", "Rune", 45.223988703409404, 19.821203339044121, 1.669900944787707m, 7.442289794627493m },
                    { new Guid("ae3be646-4553-483f-bfc7-e8a9cd5b8d3f"), "Mini", "Larae", "Lindsey", 45.288988349342716, 19.869009669621189, 1.2705361960792216m, 3.7409616159613304m },
                    { new Guid("af0bfd5b-e879-47f0-959d-9989b653beb9"), "Volkswagen", "Werner", "Inde", 45.221608244262498, 19.819591497862248, 1.3967480906659557m, 4.545871705956596m },
                    { new Guid("af2e6713-71d7-4759-abe6-4ab800792431"), "Jeep", "Iya", "Jhonatan", 45.276139257770936, 19.843919556371958, 1.6328898520108956m, 7.314957794295983m },
                    { new Guid("af8a4c35-1078-45ce-a800-86dc42960ca7"), "Land Rover", "Oja", "Chin", 45.256914630896212, 19.858970871427317, 1.26487632045056m, 10.747802492089736m },
                    { new Guid("b1069697-6230-42f4-85ad-cfe72e4d8189"), "Aston Martin Lagonda Ltd", "Pauline", "Gunnar", 45.216454140074177, 19.848281178208055, 1.7036066928092553m, 4.427610056630678m },
                    { new Guid("b1119d0f-9962-4e21-a364-9ee962dbbe58"), "Honda", "Marin", "Jesus", 45.296192164092709, 19.814406778655229, 1.308227287026685m, 3.9326792288937376m },
                    { new Guid("b2c8e29b-d300-4bcd-92a3-0a9016d9a5fa"), "Land Rover", "Oja", "Chin", 45.256914630896212, 19.858970871427317, 1.26487632045056m, 10.747802492089736m },
                    { new Guid("b4c4c3d6-dd3d-4cb2-a74d-884efa1972e3"), "Cadillac", "Olga", "Kristen", 45.29340112834867, 19.822498825540769, 1.6875309773099558m, 6.45756305740285m },
                    { new Guid("b56e7fd3-a052-4b0f-bd12-abc8bfc957f6"), "Volvo", "Taryn", "Bener", 45.230507721803349, 19.8096740775133, 1.58709815212918m, 10.487772005185393m },
                    { new Guid("b9694197-a3f1-494a-8c44-f44547a2dabb"), "Roush", "Dahlia", "Pandora", 45.222647874969191, 19.786655808995068, 1.0651228912043087m, 7.807872207177916m },
                    { new Guid("bcb2c0ed-0d10-4463-97ef-75fcfc52f973"), "Dodge", "Construccion", "Petty", 45.227061274337601, 19.836243969656948, 1.0452853161733882m, 3.69863700318812m },
                    { new Guid("bd3ed94c-bfe0-4556-b71c-7cbe9415206f"), "TOYOTA", "Dang", "Erskine", 45.217855950352465, 19.834207010840032, 1.7497987535854724m, 4.824188848962091m },
                    { new Guid("bdfe0504-8b03-45c0-a7f7-4c06ba8fe396"), "Rolls-Royce Motor Cars Limited", "Henrik", "Edwin", 45.260099746320648, 19.846618295659582, 1.452835505779086m, 8.383483200020429m },
                    { new Guid("bfc0dfc1-aaac-40f0-bba4-241886c0d970"), "Jaguar", "Dilini", "Joy", 45.204205166231176, 19.821658287825695, 1.5632855538691586m, 9.828321299882433m },
                    { new Guid("c2eeb620-da07-4361-b9b8-cf006e54110c"), "Lincoln", "Delair", "Meredith", 45.252036208353331, 19.868004870058986, 1.6143386734417438m, 6.054391760371328m },
                    { new Guid("c6ec06ad-5f53-4b89-b32c-df6c8a42e975"), "Mini", "Rue", "Henrik", 45.234728393171295, 19.822851909980773, 1.1939296054078634m, 1.7459564675100006m },
                    { new Guid("c710b4d5-0cb0-4d54-bfaa-5301faac4846"), "Volvo", "Jessa", "Tetiana", 45.228208563610373, 19.864794930227959, 1.4501630881251706m, 4.989849053623997m },
                    { new Guid("cd0c6d63-3019-4723-a676-7cc9613a8930"), "ALFA ROMEO", "Allison", "Royden", 45.295945743171906, 19.857674174593402, 1.5237046745427651m, 10.405094574404158m }
                });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Driver_ID", "Brand", "FirstName", "LastName", "Latitude", "Longitude", "PricePerKM", "StartPrice" },
                values: new object[,]
                {
                    { new Guid("cf2dd2cc-5161-40be-9b4a-ca957b46b0b2"), "Aston Martin Lagonda Ltd", "Pauline", "Gunnar", 45.216454140074177, 19.848281178208055, 1.7036066928092553m, 4.427610056630678m },
                    { new Guid("d034cdfc-5c24-4897-aab3-0ab5e3c390f9"), "Aston Martin Lagonda Ltd", "Knox", "Lorrie", 45.264656353292338, 19.837986673820598, 1.536456046701279m, 4.863201684677997m },
                    { new Guid("d4b591e9-4887-4d2c-9bc8-7be812819dcf"), "Mitsubishi Motors Corporation", "Yev", "Leeann", 45.243827207876294, 19.795146332823769, 1.4038353529833358m, 7.1267708754257715m },
                    { new Guid("d50299d6-c0aa-4817-a63c-bc95d35ffb50"), "Subaru", "Luz", "Jacqui", 45.282357438284876, 19.870750281402625, 1.3275739312198804m, 7.389799555041893m },
                    { new Guid("d830ab2c-ef79-4fbe-b1ea-9b05130b6073"), "RAM", "Renata", "Yadi", 45.296758424609912, 19.847822587069356, 1.5933840239464465m, 3.1678197529395926m },
                    { new Guid("dae8ec37-2023-435e-b511-2c085cce7027"), "Volkswagen", "Werner", "Inde", 45.221608244262498, 19.819591497862248, 1.3967480906659557m, 4.545871705956596m },
                    { new Guid("dc70d3f2-a97d-4018-a70e-0f3e6d398a5f"), "Mercedes-Benz", "Fernanda", "Berry", 45.284341031601357, 19.88214656986014, 1.228808543535298m, 2.642344591342897m },
                    { new Guid("dcd474d4-db13-4c8b-ba97-1e338fdb8ba1"), "Lincoln", "Geri", "Miii", 45.240326613759379, 19.856313447907667, 1.7338599905115184m, 10.732414512171566m },
                    { new Guid("e14cb5eb-716f-4a44-9cc0-c7d3a4d15427"), "Mini", "Jerildy", "Tzipora", 45.26373409468961, 19.820524995264094, 1.6770837896990307m, 3.156359811608757m },
                    { new Guid("e3b874ec-ae18-48d5-a012-a4ca282c9193"), "Bentley", "Ann", "Canosa", 45.204344318934922, 19.835281956415212, 1.476499130995161m, 3.3429406521108387m },
                    { new Guid("e6ef7321-5b06-49e7-b778-1d7e3c1d80e6"), "Ford", "Cora", "Otra", 45.278586743787962, 19.802530466611248, 1.7253447233445418m, 10.91510684753183m },
                    { new Guid("e70b2e1a-c1fd-479e-957e-d3bc526cc850"), "Bentley", "Lupita", "Bennet", 45.280486776875811, 19.844408581896609, 1.1702439175398553m, 10.496768111188889m },
                    { new Guid("e9ec0873-45ee-482d-abb0-87dca2354ff4"), "Lamborghini", "Ilhan", "Reserved", 45.269939911723235, 19.805821814574692, 1.7714084180476508m, 8.149353140401365m },
                    { new Guid("e9eee959-3410-4886-8867-1274d66ba489"), "MAZDA", "Rafal", "Monserrat", 45.282153330425473, 19.800982908909283, 1.0444604099295751m, 6.848472092200129m },
                    { new Guid("ea631645-a188-46b7-ad11-804eb682938b"), "Lamborghini", "Letizia", "Kerry", 45.281638953906281, 19.813600296747204, 1.099366625884517m, 1.3295397945411715m },
                    { new Guid("eb6dd92c-0e2d-4ad2-9c10-137331cd712d"), "BMW", "Jacques", "Lane", 45.213790253612132, 19.79774102895696, 1.7987752163597301m, 4.055436177433148m },
                    { new Guid("ed4055f6-8166-4eb6-9467-392ad2239f2b"), "Jeep", "Greening", "Brockie", 45.275815226573968, 19.811590339120048, 1.1547939566454073m, 4.416711302958615m },
                    { new Guid("edcf7be0-2012-40b3-8c0f-b454bac1c4d8"), "Subaru", "Luz", "Jacqui", 45.282357438284876, 19.870750281402625, 1.3275739312198804m, 7.389799555041893m },
                    { new Guid("ef309194-c2da-4a0f-a829-0f89674730b6"), "CHEVROLET", "Construccion", "Rossi", 45.287037867075718, 19.853352110430713, 1.1262567197952467m, 4.052167523478899m },
                    { new Guid("f0f47380-a3ed-4dd4-8941-f3b67fcc0204"), "NISSAN", "Rasika", "Raimundo", 45.291779211384224, 19.800023095935906, 1.0891868325268717m, 4.793560726767151m },
                    { new Guid("f0fd270e-b7f5-4abf-8ba0-2bcabd5cea67"), "Dodge", "Andreas", "Adolfo", 45.265939837651047, 19.832946913832068, 1.7380170039298m, 8.510688070544214m },
                    { new Guid("f10d9963-db15-4bf2-8992-671eb138416e"), "Bentley", "Liliya", "Yeliz", 45.278508705345807, 19.806480944684065, 1.7553152421709535m, 4.360324081230656m },
                    { new Guid("f30c26dc-9b06-4aaf-ac96-cc6e80312b7d"), "Mini", "Maurits", "Paulien", 45.296887928208001, 19.858852384808518, 1.7376903735062375m, 4.928084949383901m },
                    { new Guid("f43f18ed-b2fe-4ddd-91c2-ab0979f7e94b"), "Lamborghini", "Aparna", "Segundo", 45.225215199148884, 19.883468373193303, 1.2154110733189056m, 3.652480026698223m },
                    { new Guid("f60df109-eb79-4805-a87e-3b1e41d6ddba"), "Ford", "Cora", "Otra", 45.278586743787962, 19.802530466611248, 1.7253447233445418m, 10.91510684753183m },
                    { new Guid("f79ec518-140b-4288-b28f-44e64c45d961"), "Roush", "Evangeline", "Granados", 45.255782205655841, 19.854106076392526, 1.7553795014338474m, 6.146249025698085m },
                    { new Guid("f7de4e7c-1c80-4b92-aa42-c16094ab5338"), "Audi", "Beata", "Salome", 45.29945492843008, 19.844297003241515, 1.0417866558859206m, 1.2473101141077794m },
                    { new Guid("f9495d9f-5e65-44dc-bac3-eaddc4203a60"), "Bentley", "Brandy", "Eleanor", 45.299538969878988, 19.880643245594662, 1.6281722977710191m, 5.728713211147051m },
                    { new Guid("f94ae6c6-a8be-4c35-afc5-2d9b390b1aac"), "Porsche", "Chrissy", "Tanyia", 45.279449168518042, 19.785822522191463, 1.4492458808602435m, 2.028265801352166m },
                    { new Guid("fcefcc10-db2f-491f-bee5-c2eb99586f45"), "Porsche", "Vlada", "Marisela", 45.275549215170642, 19.878672958375621, 1.692150219149442m, 4.292175821808732m },
                    { new Guid("fd1af75f-26c4-4a6f-8fec-fbc4c5159597"), "Jaguar", "Mannix", "Gisella", 45.296266247572717, 19.804770086487757, 1.6910908453429156m, 3.2823166597464395m },
                    { new Guid("fdd4900f-851b-46cc-99a6-cb31f4152161"), "Audi", "Marc", "Erin", 45.262776103747605, 19.866401987510415, 1.0237952565130846m, 1.8608874905715336m }
                });

            migrationBuilder.InsertData(
                table: "Passengers",
                columns: new[] { "PassengerId", "Birthday", "Driver_ID", "Driver_ID1", "Email", "PassengerLastname", "PassengerName", "PassengersLatitude", "PassengersLongitude" },
                values: new object[,]
                {
                    { new Guid("211614f6-afb0-44c2-a381-f9031ba507b0"), new DateTime(1993, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), null, "raca93@gmail.com", "Bjelic", "Radivoje", 45.290568287681893, 19.924187873005128 },
                    { new Guid("3313ee16-7511-4517-bf92-d40dcb54fc79"), new DateTime(1985, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), null, "nikola@example.com", "Nikolic", "Nikola", 45.26713522876819, 19.833549673005127 },
                    { new Guid("3e6212c8-8521-4a34-b761-cb57f546f8a0"), new DateTime(1992, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), null, "jelena@example.com", "Jankovic", "Jelena", 44.012793528768192, 20.91142273005126 },
                    { new Guid("967af880-b452-4a64-a91b-fd8425c680f4"), new DateTime(1994, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), null, "marija@example.com", "Maric", "Marija", 44.01652128768189, 21.00585973005126 },
                    { new Guid("e37657bc-84c5-4e24-b0b1-cfe8084c4e21"), new DateTime(1987, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), null, "ana@example.com", "Ivanovic", "Ana", 44.786568287681888, 20.448921673005128 },
                    { new Guid("e7b2a0ea-3f8d-4972-b206-2a50be00e20e"), new DateTime(1990, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), null, "marko@example.com", "Petrovic", "Marko", 43.32090222876819, 21.895758973005126 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Passengers_Driver_ID1",
                table: "Passengers",
                column: "Driver_ID1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Passengers");

            migrationBuilder.DropTable(
                name: "Drivers");
        }
    }
}
