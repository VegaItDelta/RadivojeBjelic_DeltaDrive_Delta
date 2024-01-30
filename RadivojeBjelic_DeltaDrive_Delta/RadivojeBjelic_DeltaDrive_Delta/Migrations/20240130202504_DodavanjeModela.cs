using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RadivojeBjelic_DeltaDrive_Delta.Migrations
{
    public partial class DodavanjeModela : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Passengers_Drivers_Driver_ID1",
                table: "Passengers");

            migrationBuilder.DropIndex(
                name: "IX_Passengers_Driver_ID1",
                table: "Passengers");

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("004f8065-741c-42d8-a485-f4273b57279b"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("00ed8c46-ffa3-4c22-a409-1f305083babd"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("02b06b4a-0970-44fa-a501-c47e99763c9d"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("049beddc-c35c-45eb-97c4-7c8db57faee9"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("05d4fc4b-82f1-4379-a57f-d71fcc94b4ff"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("06c5426d-5c5a-42ba-ad94-eb6d163f0c54"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("06f5b20c-bdc1-486b-9ad7-c49ba597ea12"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("07447853-826c-4106-a0be-26265b9bc28d"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("08e73432-0a78-4048-aff7-06cea714f543"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("0bbd6798-1646-4315-844b-15555b3de3d7"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("0bdb282d-8dc3-4f04-ba4d-91594732c427"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("0e5e2c58-456c-4ece-9ddb-bebefead92d1"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("0f2e37a7-ced4-440e-aeca-59bb1225cad8"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("0f6e6cdb-f2a7-481d-a41d-9e51c682e476"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("1062708d-0f1e-4306-886b-c4d614580702"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("1194288c-31fb-477d-b391-14e72a689524"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("11cf873e-c3b9-4ca6-ae6a-aceb4d0c375a"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("129a25cc-b3e8-403b-9fdd-ee8ae521583b"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("14c8a248-1387-4c3c-87fc-a7141c2e5b94"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("160e8582-8601-4fe3-b4ca-1a0a93cf1c12"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("17185874-f9ac-4c5d-ae10-37dfb677c83b"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("1783f8ec-65b1-49ad-8d32-b32e8ca55836"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("17af9d25-b076-479c-8067-a7eb35beb4b1"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("18737044-2853-4641-995d-e7c3dc8199b6"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("1c7c79f8-0d24-4433-b67e-11f1d48d959c"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("1dbf0f27-0f20-47b7-b767-07dc6c238682"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("1e5572bb-4cde-462b-a2f5-f5c475909b5c"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("1e6f4371-9a29-46c5-b7fa-5942346673e9"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("1ed9a879-5c07-4acf-8556-0fec3d4fc5e8"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("1ee63e78-b3f5-4bcd-9ae5-b3a2a327ebd8"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("1f75dd9c-ae53-4a95-95af-6c3cb4521034"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("1f9012c8-c693-43f7-a27e-db5df7e629af"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("1f95bcb6-4a61-4aad-848f-206ddab5f6ef"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("1fe83549-acb6-4b69-9775-c412beaed7fb"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("1ffe09e2-17b2-4429-9654-980caec3c1a1"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("2248aa70-296b-4fef-ae1a-6a3c2faac544"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("232f9be4-85e6-4760-8ad7-57eeb939e69d"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("25beea4f-0993-4160-a8ee-d7e32898a6d1"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("25c41ca6-9718-41ba-87f6-ad04f1683c32"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("25c4950a-f6ad-479b-b42a-d32327389a07"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("27018c47-1d13-4f78-9d77-8bc26d32fadd"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("275747aa-e0e0-4ef5-9876-0f69d3830422"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("27fd59ac-d347-49a6-a6e5-776e05dfb800"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("29a951aa-9c60-47e6-b702-da80a93558a1"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("2a09445a-d8e3-4f0c-b7e5-925bb792cff1"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("2c3a4a08-68c9-456b-bcdc-a2321d3ee6df"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("2c798ef9-021d-4356-85c3-5e064738b6a6"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("2ea4c2d1-ba88-49c7-b891-d6101e41ec6d"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("2edec98c-4caa-4af2-9f81-4e0ab657a19e"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("2f39e627-71d0-4476-88ae-cef5dcdbdb4c"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("2ff486c2-9f30-4e85-8092-b84b2984139c"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("30b2a683-5a45-423a-8ab0-83f36dd32454"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("331f51d6-26a6-4496-9f7b-0c5ea14e8cb7"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("356bbd30-4d05-4aa5-a498-e625b3f528c2"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("3658c7b4-07fa-4fed-8e6d-cbea815121c4"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("38db4659-0861-4450-9774-d44a26ddcaa3"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("39056de4-7733-4124-a4a1-c96782d4979f"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("39c24b9e-1ddb-49c7-bd19-8057639d1a11"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("39f89afa-55cf-4ee1-9b7d-3f7f537c9eed"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("3d835d11-bd1d-4f58-a9cb-19b628341843"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("3ed4518b-c31a-4aa1-ba3b-a8a495fd5d87"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("40d545f8-7efa-402a-9380-174d4c1a166d"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("4194f64a-7219-4e79-b1b2-4833170f4761"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("43615c9a-26ce-479f-bc8f-b13951a4d159"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("44f7d60c-3de8-4a86-ae66-252fa0e800a5"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("456a7d1b-7746-459a-a1ae-ffea5698a11d"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("46867f9b-6fd2-4fec-9400-41aedee06cff"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("494238bb-e11c-448c-88ef-f96e91909610"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("494922b3-7609-4670-8437-cb6dd3f87704"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("49749ce2-f409-4189-952c-3f3b83d0f077"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("4b387812-0212-4e57-b648-097e43713591"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("506d7857-c454-4f42-bc68-695bc4bd2029"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("51455cca-569f-43a3-aeb0-f096d2ff904f"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("564ea24b-e16c-4333-a23d-95b62425db09"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("57f51d25-b3fe-4fe3-937f-7a9470e979c8"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("584dcfaf-bd1d-41af-810c-ced36f351e93"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("585f6190-1600-4991-976d-9cd490026e19"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("59909f93-9942-469c-a01c-0c7f1537e342"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("5a7fe07e-df81-401a-9e19-715715b5e7c0"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("5a82e0bc-098d-44fa-b391-4ea63393fc10"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("5edd37f6-e50f-49c1-8b0b-88272e6d6800"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("617518ce-558e-45cc-bbee-75d9e08aa325"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("62e7fac2-0433-4218-9664-824cd048a54e"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("6397731d-cdb3-4e9b-ba85-7331ef651772"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("645b43f5-7df5-40b1-bf13-48e5ef5481d5"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("650da44e-796e-4181-86e7-63d617c6dde2"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("6539d2b0-d6fa-40dc-8b24-8cc59a287592"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("65543524-2ba8-47c0-b78b-f5ae90a67519"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("65bb1ac3-aee6-435e-b55d-3d11c03739ad"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("66f0b517-f7c8-491c-9986-330aa3b98552"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("68bb7bc8-be0d-4eac-8188-0de22e93dd76"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("69192feb-4384-4d56-be24-288ac1ce2e82"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("6af9cdc2-f940-43ad-88ac-cc1ff5b77ed9"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("6b48548b-6db8-4a8a-8309-f3c6c4cd03be"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("6bbb0c6b-1e5d-4f64-a2a2-4b1d72d2ffe6"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("6f83c842-8391-4b95-bf3d-abbd60edfcd8"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("70e6035a-4dee-480a-9638-7126a83809a5"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("753f2925-74b3-4249-98a0-40a8078ab2e3"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("76b5f07c-7843-4eb5-92f7-2c5d0582a177"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("76c5443c-3061-4bb5-afb2-ccf85b848931"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("7824ddab-da6e-4589-a03c-d872fabb8446"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("794c882e-1db7-4bea-b6f2-ce37ee43993b"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("795010f8-0342-4eb1-989f-105a941a5a40"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("7a110831-cb63-4fb9-b1d7-361ff7135db3"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("7ac50c2b-3cb8-49c2-b09c-b2b219c50e41"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("7b7d56b4-0dd8-4995-8178-d723606918dd"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("7c2ded8b-df82-4ce0-9748-ace51010bead"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("7de58d18-60c7-4028-8d5a-df9af1907d48"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("7e28c8db-7f33-4c48-9206-38b2e6e1d73d"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("7e576aed-b897-444a-969e-b1da9d3ad95e"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("7f30358d-fdcf-4f09-bab5-1e9f8609b89b"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("7fdde197-1eb4-4c44-9e51-cafbdd4d622d"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("815cf79b-f5cf-4c6d-850b-d38275208a05"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("81725eca-bf91-44ba-a666-cb28f3aca14e"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("823d041e-0c2e-473a-b620-1c9491a83229"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("82bef847-e914-46e9-a206-056cfc05eb72"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("82e65307-8ecd-43f6-99ce-8d9d481bb847"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("8388b74e-1fe6-4afe-a720-3eb434faf04f"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("83a09a3c-7d37-44d4-a0fe-203075edec9f"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("843ce6a8-cbe6-4514-b9ca-1de609ca2d2b"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("85756391-17df-4194-a24f-2b9b36e27288"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("8602f474-7af7-4e28-bf7c-7448ea9c61c1"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("86ed6231-0487-4491-8ff4-876948059104"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("88c42ff0-4574-44b1-ab37-549003dc713d"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("89b4aa9c-f31a-4d25-93ee-303763bd75e1"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("8a888e51-d289-4afc-815d-51e45c3e8ecb"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("8aaf6785-8199-4bea-a62b-fba974da05ab"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("8c189fa0-4c92-4adb-87bd-1db9a9122160"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("909fd388-272e-41c6-a9bf-7d9fced34691"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("94a1a6b4-40f2-4118-9dd9-c93eb954517d"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("95da0622-43a9-4b72-84d7-885b5fbf88e6"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("96f0e248-5548-43c3-9e66-c83e44e740ad"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("97fc57b1-f1de-4b96-ba5c-38aa6fd42e06"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("9904ec14-3a06-41df-ba75-3272832fc3d8"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("99192910-4ac8-4221-a84a-ee0f5893bf8c"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("996c7174-0e4a-449f-95c9-4fa7c09d9a05"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("9b42c480-d45f-46f8-b1a0-54d8cb4c9302"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("9bcf9e97-850e-4dde-ae92-e0a7b91ed97d"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("9e637408-7f55-4bd3-8b38-01980a9da7ff"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("9ec52e95-d76e-4015-91b7-130c84988c06"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("9f80a974-6245-4d0e-bf09-98eec6dc932c"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("a02883ab-afe2-4546-99f5-9700ca57055c"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("a0c7d282-9b41-4dcc-99ec-9dde8a5ebea4"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("a34d507d-22cc-433f-ad47-d97d8bba3c88"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("a449ce22-ca17-4d81-9a55-be975d35bc69"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("a582e657-0c6d-469c-a2c2-a0b3dd58a66e"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("a6bc149d-8268-4864-923e-9e753a350589"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("a6e2999c-9738-4788-9338-7062817a8027"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("a84c0553-3ee3-4c31-9203-cc5d1c243799"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("ab71bdea-34ec-4c60-88f0-91453fec7055"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("ae3be646-4553-483f-bfc7-e8a9cd5b8d3f"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("af0bfd5b-e879-47f0-959d-9989b653beb9"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("af2e6713-71d7-4759-abe6-4ab800792431"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("af8a4c35-1078-45ce-a800-86dc42960ca7"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("b1069697-6230-42f4-85ad-cfe72e4d8189"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("b1119d0f-9962-4e21-a364-9ee962dbbe58"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("b2c8e29b-d300-4bcd-92a3-0a9016d9a5fa"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("b4c4c3d6-dd3d-4cb2-a74d-884efa1972e3"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("b56e7fd3-a052-4b0f-bd12-abc8bfc957f6"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("b9694197-a3f1-494a-8c44-f44547a2dabb"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("bcb2c0ed-0d10-4463-97ef-75fcfc52f973"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("bd3ed94c-bfe0-4556-b71c-7cbe9415206f"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("bdfe0504-8b03-45c0-a7f7-4c06ba8fe396"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("bfc0dfc1-aaac-40f0-bba4-241886c0d970"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("c2eeb620-da07-4361-b9b8-cf006e54110c"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("c6ec06ad-5f53-4b89-b32c-df6c8a42e975"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("c710b4d5-0cb0-4d54-bfaa-5301faac4846"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("cd0c6d63-3019-4723-a676-7cc9613a8930"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("cf2dd2cc-5161-40be-9b4a-ca957b46b0b2"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("d034cdfc-5c24-4897-aab3-0ab5e3c390f9"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("d4b591e9-4887-4d2c-9bc8-7be812819dcf"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("d50299d6-c0aa-4817-a63c-bc95d35ffb50"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("d830ab2c-ef79-4fbe-b1ea-9b05130b6073"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("dae8ec37-2023-435e-b511-2c085cce7027"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("dc70d3f2-a97d-4018-a70e-0f3e6d398a5f"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("dcd474d4-db13-4c8b-ba97-1e338fdb8ba1"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("e14cb5eb-716f-4a44-9cc0-c7d3a4d15427"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("e3b874ec-ae18-48d5-a012-a4ca282c9193"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("e6ef7321-5b06-49e7-b778-1d7e3c1d80e6"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("e70b2e1a-c1fd-479e-957e-d3bc526cc850"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("e9ec0873-45ee-482d-abb0-87dca2354ff4"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("e9eee959-3410-4886-8867-1274d66ba489"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("ea631645-a188-46b7-ad11-804eb682938b"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("eb6dd92c-0e2d-4ad2-9c10-137331cd712d"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("ed4055f6-8166-4eb6-9467-392ad2239f2b"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("edcf7be0-2012-40b3-8c0f-b454bac1c4d8"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("ef309194-c2da-4a0f-a829-0f89674730b6"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("f0f47380-a3ed-4dd4-8941-f3b67fcc0204"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("f0fd270e-b7f5-4abf-8ba0-2bcabd5cea67"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("f10d9963-db15-4bf2-8992-671eb138416e"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("f30c26dc-9b06-4aaf-ac96-cc6e80312b7d"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("f43f18ed-b2fe-4ddd-91c2-ab0979f7e94b"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("f60df109-eb79-4805-a87e-3b1e41d6ddba"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("f79ec518-140b-4288-b28f-44e64c45d961"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("f7de4e7c-1c80-4b92-aa42-c16094ab5338"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("f9495d9f-5e65-44dc-bac3-eaddc4203a60"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("f94ae6c6-a8be-4c35-afc5-2d9b390b1aac"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("fcefcc10-db2f-491f-bee5-c2eb99586f45"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("fd1af75f-26c4-4a6f-8fec-fbc4c5159597"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("fdd4900f-851b-46cc-99a6-cb31f4152161"));

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "PassengerId",
                keyValue: new Guid("211614f6-afb0-44c2-a381-f9031ba507b0"));

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "PassengerId",
                keyValue: new Guid("3313ee16-7511-4517-bf92-d40dcb54fc79"));

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "PassengerId",
                keyValue: new Guid("3e6212c8-8521-4a34-b761-cb57f546f8a0"));

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "PassengerId",
                keyValue: new Guid("967af880-b452-4a64-a91b-fd8425c680f4"));

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "PassengerId",
                keyValue: new Guid("e37657bc-84c5-4e24-b0b1-cfe8084c4e21"));

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "PassengerId",
                keyValue: new Guid("e7b2a0ea-3f8d-4972-b206-2a50be00e20e"));

            migrationBuilder.DropColumn(
                name: "Driver_ID1",
                table: "Passengers");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Passengers",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<Guid>(
                name: "PassengerId",
                table: "Drivers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Driver_ID", "Brand", "FirstName", "LastName", "Latitude", "Longitude", "PassengerId", "PricePerKM", "StartPrice" },
                values: new object[,]
                {
                    { new Guid("00e9de7e-01ad-4fe1-ae68-ca1efee0ad0e"), "Bentley", "Ann", "Canosa", 45.204344318934922, 19.835281956415212, null, 1.476499130995161m, 3.3429406521108387m },
                    { new Guid("00f36e47-547d-485f-9db1-17b014167e92"), "Lincoln", "Gert", "Andres", 45.279225594403293, 19.790054798757847, null, 1.1643840016635394m, 1.328847558195744m },
                    { new Guid("01620c9e-6033-431c-93c1-6eb16fd9c00c"), "Bentley", "Lupita", "Bennet", 45.280486776875811, 19.844408581896609, null, 1.1702439175398553m, 10.496768111188889m },
                    { new Guid("01650031-749f-4d48-ba9f-71487925857a"), "Chrysler", "Ibrahim", "Alina", 45.2993118675817, 19.796265612687975, null, 1.1089619486674978m, 10.521486246480235m },
                    { new Guid("0228aa27-9626-4b9c-81e5-b2b9f38d5dd4"), "Honda", "Talbot", "Carwen", 45.250169050776421, 19.794775524085665, null, 1.4473141471090796m, 4.881600711969098m },
                    { new Guid("0309b046-4098-475e-93aa-3f6825730291"), "Ford", "Cora", "Otra", 45.278586743787962, 19.802530466611248, null, 1.7253447233445418m, 10.91510684753183m },
                    { new Guid("03b51e50-4289-4b2f-9d13-053401ce0960"), "SCION", "Vanessa", "Moran", 45.243401442719865, 19.845486901252453, null, 1.766625245740726m, 1.5974547157697985m },
                    { new Guid("03e12f6f-5a7e-4be8-8ffe-84a721ed50f1"), "Honda", "Marin", "Jesus", 45.296192164092709, 19.814406778655229, null, 1.308227287026685m, 3.9326792288937376m },
                    { new Guid("048566d9-ec66-47ac-93fd-0919ce488b22"), "Buick", "Edie", "Maeve", 45.204068043710627, 19.850483415082969, null, 1.2435787993749734m, 1.5525301188205578m },
                    { new Guid("074f30cd-b949-452f-b5f4-fc9af2d61113"), "GMC", "Brehan", "Leonardo", 45.284932615672936, 19.861347707346106, null, 1.0165564995215457m, 10.543527811952874m },
                    { new Guid("09ead8ea-9b20-4a33-b39a-c500710bb1ad"), "Mini", "Larae", "Lindsey", 45.288988349342716, 19.869009669621189, null, 1.2705361960792216m, 3.7409616159613304m },
                    { new Guid("0acf1bc0-983d-47c1-99b6-61546f9f8bbe"), "Rolls-Royce Motor Cars Limited", "Henrik", "Edwin", 45.260099746320648, 19.846618295659582, null, 1.452835505779086m, 8.383483200020429m },
                    { new Guid("0d7c0645-56d2-4f73-af79-31733fc84783"), "BMW", "Jacques", "Lane", 45.213790253612132, 19.79774102895696, null, 1.7987752163597301m, 4.055436177433148m },
                    { new Guid("0e3dab34-bfad-4baf-b00d-61908a7f4eba"), "Lincoln", "Javid", "Tranta", 45.216149699839988, 19.853299911074188, null, 1.214353703785661m, 4.696927726796888m },
                    { new Guid("0fed1142-3102-48af-921d-609e970436ac"), "Chevrolet", "Krizia", "Brusovanik", 45.267957633744437, 19.799666210958843, null, 1.6786208486121708m, 7.342233447742731m },
                    { new Guid("11060d5b-2ee7-4f61-81cd-1f7bb5f5adba"), "Mini", "Dianna", "Michal", 45.247323100321054, 19.842409377101806, null, 1.0397465494006515m, 5.223227457896003m },
                    { new Guid("13b0f3c4-0426-4170-91da-65eeb5815908"), "Roush", "Bernardino", "Danel", 45.262091751738382, 19.836733731194897, null, 1.685522127629019m, 5.239149409686604m },
                    { new Guid("141c0a05-3806-4631-921e-3b987f397aae"), "Porsche", "Chrissy", "Tanyia", 45.279449168518042, 19.785822522191463, null, 1.4492458808602435m, 2.028265801352166m },
                    { new Guid("153c3042-d33e-4a19-b19a-37c4bf5f429f"), "CHEVROLET", "Construccion", "Rossi", 45.287037867075718, 19.853352110430713, null, 1.1262567197952467m, 4.052167523478899m },
                    { new Guid("166eb87f-a37e-4713-aa7e-999907a07933"), "INFINITI", "Deepti", "Devara", 45.275913260410107, 19.85081695839504, null, 1.6342564595450453m, 10.57353943753355m },
                    { new Guid("1815919b-ab44-444b-b895-ea5312196c4c"), "FIAT", "Harold", "Karl", 45.286324628710155, 19.859015812248142, null, 1.7153672461915734m, 9.684974884213723m },
                    { new Guid("1830f0a3-2b15-4201-bfa8-fb55f3366587"), "Subaru", "Luz", "Jacqui", 45.282357438284876, 19.870750281402625, null, 1.3275739312198804m, 7.389799555041893m },
                    { new Guid("18d2bd5b-0d61-4f2f-a64f-2049016da2c0"), "LEXUS", "Raina", "Lula", 45.223453054301878, 19.830829334577729, null, 1.0164590921625576m, 6.269772816844689m },
                    { new Guid("195491c7-26b6-408d-b8b4-1a23a08c6625"), "INFINITI", "Jastinder", "Homero", 45.269815899190036, 19.810080082882855, null, 1.5244558202271907m, 1.9469998885842523m },
                    { new Guid("1a879c4c-96b4-4357-9b71-aa87805a8a18"), "Honda", "Libbey", "Ernest", 45.282891901118944, 19.876434018077504, null, 1.2475192510221107m, 5.449373131830329m },
                    { new Guid("1bddddbd-76cd-456f-90e9-d246e17a54ca"), "NISSAN", "Rasika", "Raimundo", 45.291779211384224, 19.800023095935906, null, 1.0891868325268717m, 4.793560726767151m },
                    { new Guid("1ed1b074-858d-41ad-9766-65211a9143a1"), "Lincoln", "Geri", "Miii", 45.240326613759379, 19.856313447907667, null, 1.7338599905115184m, 10.732414512171566m },
                    { new Guid("21d350ef-dc04-4d51-b514-613c0a41a967"), "TOYOTA", "Aden", "Eliza", 45.268648133812405, 19.831866095348715, null, 1.391490893102681m, 8.095125839709704m },
                    { new Guid("22a2adf5-0177-4619-992a-15ec3248f76d"), "MASERATI", "Magali", "Vibeke", 45.21619104847931, 19.788370458607901, null, 1.6719496977709882m, 4.795675055141949m },
                    { new Guid("22d8150c-8b54-4973-b1d3-774371dfa8f9"), "Volvo", "Emma", "Tasha", 45.285854370015166, 19.866548271059557, null, 1.0566431268333218m, 8.509215393598028m },
                    { new Guid("267a100b-7f65-453b-8ce2-4420d97aa193"), "Audi", "Beata", "Salome", 45.29945492843008, 19.844297003241515, null, 1.0417866558859206m, 1.2473101141077794m },
                    { new Guid("29c474ae-70e4-42cb-83bb-9d36345cfc7f"), "Lincoln", "Geri", "Miii", 45.240326613759379, 19.856313447907667, null, 1.7338599905115184m, 10.732414512171566m },
                    { new Guid("2a5accb3-554f-4b5b-9840-8fdcf7e9641f"), "Land Rover", "Maurits", "Anurag", 45.253925064457675, 19.828862737626718, null, 1.7104501368390608m, 4.2596837052732415m },
                    { new Guid("2c3ee8fc-84c9-40f8-b7f9-aa2ac826b9ec"), "Porsche", "Walker", "Maruk", 45.217759832566678, 19.812095479197652, null, 1.0201468787267918m, 8.987330756776993m },
                    { new Guid("2cac01f6-fffd-4a59-8cde-835a8b3c5648"), "SCION", "Vanessa", "Moran", 45.243401442719865, 19.845486901252453, null, 1.766625245740726m, 1.5974547157697985m },
                    { new Guid("2cb73476-c832-4aca-b2b9-1f67f210a9c4"), "Chevrolet", "Jerome", "Hoj", 45.26187929944556, 19.852975472519034, null, 1.332259599316662m, 4.833445837024005m },
                    { new Guid("2cb89d66-085d-4ebd-b8eb-e71e10820950"), "Audi", "Marc", "Erin", 45.262776103747605, 19.866401987510415, null, 1.0237952565130846m, 1.8608874905715336m },
                    { new Guid("309ce93c-bc04-485f-abdf-231b33fb98a2"), "Jeep", "Greening", "Brockie", 45.275815226573968, 19.811590339120048, null, 1.1547939566454073m, 4.416711302958615m },
                    { new Guid("30e6b365-4041-48d8-af73-993f58d18b55"), "Porsche", "Vlada", "Marisela", 45.275549215170642, 19.878672958375621, null, 1.692150219149442m, 4.292175821808732m },
                    { new Guid("3106ae8d-68c5-4466-bec4-dbe565911d22"), "INFINITI", "Deepti", "Devara", 45.275913260410107, 19.85081695839504, null, 1.6342564595450453m, 10.57353943753355m },
                    { new Guid("31b5c3f8-353e-4b66-945c-284ea6ccff06"), "Subaru", "Lombardet", "Casandra", 45.250568287681887, 19.824187873005126, null, 1.6563058877839092m, 10.512932624252946m },
                    { new Guid("3455cfd7-3fb5-48af-ad16-65746bfade41"), "Volvo", "Zena", "Kirstein", 45.238319779725494, 19.810359597732457, null, 1.7020772550670218m, 10.79799094974425m }
                });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Driver_ID", "Brand", "FirstName", "LastName", "Latitude", "Longitude", "PassengerId", "PricePerKM", "StartPrice" },
                values: new object[,]
                {
                    { new Guid("35286419-204b-460b-be3f-084d5a38451d"), "Volvo", "Jessa", "Tetiana", 45.228208563610373, 19.864794930227959, null, 1.4501630881251706m, 4.989849053623997m },
                    { new Guid("35384791-5da2-4c5d-b336-a31de15aca19"), "Roush", "Dahlia", "Pandora", 45.222647874969191, 19.786655808995068, null, 1.0651228912043087m, 7.807872207177916m },
                    { new Guid("35a58572-2450-43b0-b466-b3e8c5f3ae1f"), "MASERATI", "Residencia", "Casper", 45.229981095425153, 19.837153864471194, null, 1.554999380283847m, 9.574431191837565m },
                    { new Guid("3629de8b-98f9-4100-83c3-e31cfcc5a6c0"), "Mercedes-Benz", "Fernanda", "Berry", 45.284341031601357, 19.88214656986014, null, 1.228808543535298m, 2.642344591342897m },
                    { new Guid("367e8cac-aeee-4b12-adf5-4c5eb94be68d"), "McLaren", "Flora", "Allesdandro", 45.250220306572913, 19.80629652423562, null, 1.6560543096854814m, 9.747141997226342m },
                    { new Guid("37ec0fe2-0be8-49cd-bb01-b8fd77aec34f"), "Aston Martin Lagonda Ltd", "Knox", "Lorrie", 45.264656353292338, 19.837986673820598, null, 1.536456046701279m, 4.863201684677997m },
                    { new Guid("39258377-e38f-4201-87f2-18d08e455d04"), "RAM", "Renata", "Yadi", 45.296758424609912, 19.847822587069356, null, 1.5933840239464465m, 3.1678197529395926m },
                    { new Guid("3a1d3b8e-8acb-457b-bfe8-7ce6af5684e2"), "Audi", "Marc", "Erin", 45.262776103747605, 19.866401987510415, null, 1.0237952565130846m, 1.8608874905715336m },
                    { new Guid("3afed86b-5ad0-4702-ace5-cb2e6ee951fb"), "Mini", "Rue", "Henrik", 45.234728393171295, 19.822851909980773, null, 1.1939296054078634m, 1.7459564675100006m },
                    { new Guid("3b23797d-d899-42c1-aeff-0393ec9c8cfc"), "Porsche", "Vlada", "Marisela", 45.275549215170642, 19.878672958375621, null, 1.692150219149442m, 4.292175821808732m },
                    { new Guid("3f18daef-7697-44fb-96ca-2ff56fc13ad1"), "Aston Martin Lagonda Ltd", "Elliot", "Loiselin", 45.222723321894421, 19.793603471598757, null, 1.5879618679964944m, 2.4186214661952135m },
                    { new Guid("3f47f161-82d8-48d1-b7bc-d5bd8f3e83bc"), "Honda", "Libbey", "Ernest", 45.282891901118944, 19.876434018077504, null, 1.2475192510221107m, 5.449373131830329m },
                    { new Guid("4045b6a8-fc43-4fe9-b1f5-a5949c16164f"), "Land Rover", "Maurits", "Anurag", 45.253925064457675, 19.828862737626718, null, 1.7104501368390608m, 4.2596837052732415m },
                    { new Guid("4177a539-5fae-424b-bf5c-afb8087a9a3e"), "Porsche", "Chrissy", "Tanyia", 45.279449168518042, 19.785822522191463, null, 1.4492458808602435m, 2.028265801352166m },
                    { new Guid("41be70b9-6c47-4671-9794-d43294ba8491"), "BMW", "Alessandro", "Ame", 45.213878946434399, 19.83500906624565, null, 1.1394055188065981m, 10.629290075265152m },
                    { new Guid("41c332cf-fcf3-411a-9b24-994ebb5e1131"), "MASERATI", "Magali", "Vibeke", 45.21619104847931, 19.788370458607901, null, 1.6719496977709882m, 4.795675055141949m },
                    { new Guid("43a2ea07-b03f-4d70-a859-398f54cd8b30"), "Pagani Automobili S.p.A.", "Morrissey", "Kellie", 45.274651670577768, 19.791858685850482, null, 1.3417230653533827m, 2.18234253206158m },
                    { new Guid("4446bb12-4de4-4cef-971b-cc06fc17b06d"), "Volvo", "Lluvia", "Judd", 45.244554013188768, 19.872895707350001, null, 1.253412375617725m, 5.882144460892146m },
                    { new Guid("45fb1944-0c72-4da9-8779-d05e73b133b2"), "BMW", "Alessandro", "Ame", 45.213878946434399, 19.83500906624565, null, 1.1394055188065981m, 10.629290075265152m },
                    { new Guid("47dc1779-00cd-46ed-9ac9-89098a1598e2"), "ALFA ROMEO", "Allison", "Royden", 45.295945743171906, 19.857674174593402, null, 1.5237046745427651m, 10.405094574404158m },
                    { new Guid("4913826c-0b59-4a0f-8ac4-e93530c77ace"), "Mini", "Maurits", "Paulien", 45.296887928208001, 19.858852384808518, null, 1.7376903735062375m, 4.928084949383901m },
                    { new Guid("491ff64d-816d-4224-b721-ec20ccc554b9"), "Pagani Automobili S.p.A.", "Jamison", "Ash", 45.278270343256636, 19.852105063006313, null, 1.3374700364494403m, 8.12755415792042m },
                    { new Guid("4967b5c2-3354-4a52-bb81-3fefe0c7a369"), "Roush", "Dahlia", "Pandora", 45.222647874969191, 19.786655808995068, null, 1.0651228912043087m, 7.807872207177916m },
                    { new Guid("4a87fbe6-03e2-4468-b1fa-1f66f4da2982"), "MAZDA", "Callaghan", "Aiden", 45.215384546791014, 19.846282477003452, null, 1.7442378744022409m, 4.395966844983313m },
                    { new Guid("4b6c1444-659c-4b45-876d-8f49602e1df8"), "Porsche", "Walker", "Maruk", 45.217759832566678, 19.812095479197652, null, 1.0201468787267918m, 8.987330756776993m },
                    { new Guid("4d45cd7b-6926-4072-a1b8-9511a9a0b1ff"), "INFINITI", "Bici", "Travis", 45.201686751190202, 19.802496053471067, null, 1.2016309984417113m, 10.491378188758173m },
                    { new Guid("4d7af739-2d4e-4a30-add2-ec1cdf2b6148"), "Bentley", "Lupita", "Bennet", 45.280486776875811, 19.844408581896609, null, 1.1702439175398553m, 10.496768111188889m },
                    { new Guid("4e593572-1663-49d9-a58d-e0fdd0ffc950"), "Jaguar", "Dilini", "Joy", 45.204205166231176, 19.821658287825695, null, 1.5632855538691586m, 9.828321299882433m },
                    { new Guid("4e73e2d7-d499-438a-8ed4-5a6547909569"), "Bentley", "Brandy", "Eleanor", 45.299538969878988, 19.880643245594662, null, 1.6281722977710191m, 5.728713211147051m },
                    { new Guid("5068bf27-cf2f-4c37-b30a-6c4a6f882c47"), "Buick", "Edie", "Maeve", 45.204068043710627, 19.850483415082969, null, 1.2435787993749734m, 1.5525301188205578m },
                    { new Guid("52881991-d721-4904-8cbc-1a57cefdbc11"), "Aston Martin Lagonda Ltd", "Leonard", "Emerald", 45.2572972194831, 19.855507893571811, null, 1.2124823508556823m, 10.14906639309747m },
                    { new Guid("52feceb9-1f4c-4d33-88af-a61561e74be0"), "Chevrolet", "Krizia", "Brusovanik", 45.267957633744437, 19.799666210958843, null, 1.6786208486121708m, 7.342233447742731m },
                    { new Guid("576dbb55-a5be-4dea-b95f-75faabf88386"), "Lamborghini", "Ilhan", "Reserved", 45.269939911723235, 19.805821814574692, null, 1.7714084180476508m, 8.149353140401365m },
                    { new Guid("583e4baa-3ae8-48cc-84c4-6dd3df43eaf2"), "Aston Martin Lagonda Ltd", "Oracio", "Richie", 45.224688333074994, 19.83919841648629, null, 1.385540803473964m, 9.910185805400143m },
                    { new Guid("58d2578c-0734-41d9-92e2-c19375597e0a"), "Aston Martin Lagonda Ltd", "Elliot", "Loiselin", 45.222723321894421, 19.793603471598757, null, 1.5879618679964944m, 2.4186214661952135m },
                    { new Guid("58fbbb89-cf48-4982-bec4-111cbb7bb110"), "Lamborghini", "Aparna", "Segundo", 45.225215199148884, 19.883468373193303, null, 1.2154110733189056m, 3.652480026698223m },
                    { new Guid("59f960e2-8446-404c-9eba-c31ab33a6e15"), "Porsche", "Jen", "Shar", 45.210580578767569, 19.787137195434291, null, 1.7006360867551042m, 9.781009068780087m },
                    { new Guid("5b12e337-d815-4cf2-9fdb-5f45a8d0ea96"), "Lamborghini", "Ilhan", "Reserved", 45.269939911723235, 19.805821814574692, null, 1.7714084180476508m, 8.149353140401365m },
                    { new Guid("5ce941c9-9738-40ab-8ee7-b511ea58d6cb"), "Bentley", "Liliya", "Yeliz", 45.278508705345807, 19.806480944684065, null, 1.7553152421709535m, 4.360324081230656m },
                    { new Guid("5d030eac-6267-4016-9983-1c3437bfa99b"), "NISSAN", "Rasika", "Raimundo", 45.291779211384224, 19.800023095935906, null, 1.0891868325268717m, 4.793560726767151m },
                    { new Guid("5d903d94-7bd4-4b7d-8518-c6e00a4e8cb5"), "Chevrolet", "Trace", "Gerry", 45.290891491829363, 19.828444245832451, null, 1.6389965205075372m, 8.368466873577997m },
                    { new Guid("5f06e4ea-879e-4178-aa20-33a11e46a063"), "Pagani Automobili S.p.A.", "Morrissey", "Kellie", 45.274651670577768, 19.791858685850482, null, 1.3417230653533827m, 2.18234253206158m }
                });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Driver_ID", "Brand", "FirstName", "LastName", "Latitude", "Longitude", "PassengerId", "PricePerKM", "StartPrice" },
                values: new object[,]
                {
                    { new Guid("6065e47e-d656-403e-993a-9ff22cde2d75"), "Volkswagen", "Werner", "Inde", 45.221608244262498, 19.819591497862248, null, 1.3967480906659557m, 4.545871705956596m },
                    { new Guid("6207ac64-008b-473c-877d-9ad9582d664f"), "Rolls-Royce Motor Cars Limited", "Henrik", "Edwin", 45.260099746320648, 19.846618295659582, null, 1.452835505779086m, 8.383483200020429m },
                    { new Guid("646c7fc0-37d4-4f8a-9130-ad3eb836d745"), "RAM", "Welch", "Vaishali", 45.226846241954064, 19.839414266674314, null, 1.3494145070278685m, 3.1034505930423064m },
                    { new Guid("648dc39c-e41c-48aa-ba1a-53bd29d00bf0"), "Mercedes-Benz", "Fernanda", "Berry", 45.284341031601357, 19.88214656986014, null, 1.228808543535298m, 2.642344591342897m },
                    { new Guid("6539c264-c862-4d4b-9c29-f337943066a4"), "INFINITI", "Bici", "Travis", 45.201686751190202, 19.802496053471067, null, 1.2016309984417113m, 10.491378188758173m },
                    { new Guid("656ddb69-869d-4f7b-94ca-b9361d379d3b"), "Audi", "Beata", "Salome", 45.29945492843008, 19.844297003241515, null, 1.0417866558859206m, 1.2473101141077794m },
                    { new Guid("66671b2b-1e61-4663-8ca0-963bdf4daa2a"), "Lincoln", "Javid", "Tranta", 45.216149699839988, 19.853299911074188, null, 1.214353703785661m, 4.696927726796888m },
                    { new Guid("66766657-2612-4529-84c9-49113b974fb4"), "Honda", "Marin", "Jesus", 45.296192164092709, 19.814406778655229, null, 1.308227287026685m, 3.9326792288937376m },
                    { new Guid("693c9edf-414d-40d9-b77f-a5a97b95b338"), "GMC", "Brehan", "Leonardo", 45.284932615672936, 19.861347707346106, null, 1.0165564995215457m, 10.543527811952874m },
                    { new Guid("6b2ecc34-a97b-400b-ac4f-22775e733779"), "MAZDA", "Megpg", "Eunice", 45.219490140494258, 19.798772403836473, null, 1.3455814143383005m, 9.776292871306692m },
                    { new Guid("6dc06fe4-8ff5-4a53-b9a8-f8d28d7f11c4"), "Aston Martin Lagonda Ltd", "Leonard", "Emerald", 45.2572972194831, 19.855507893571811, null, 1.2124823508556823m, 10.14906639309747m },
                    { new Guid("6e6e07bf-8703-4c38-bb3c-79ec48a7e0ff"), "Pagani Automobili S.p.A.", "Jamison", "Ash", 45.278270343256636, 19.852105063006313, null, 1.3374700364494403m, 8.12755415792042m },
                    { new Guid("6ea8ae57-b863-4587-a0ca-8e458ff15282"), "MASERATI", "Vartan", "Rhee", 45.298049374458131, 19.878864637212104, null, 1.5393415373611448m, 6.559482220099541m },
                    { new Guid("71469497-07cc-4a5a-a1e1-9f3c113cbda3"), "Dodge", "Construccion", "Petty", 45.227061274337601, 19.836243969656948, null, 1.0452853161733882m, 3.69863700318812m },
                    { new Guid("76b48731-3f3d-4d17-b1ad-614a395fc01f"), "Aston Martin Lagonda Ltd", "Pauline", "Gunnar", 45.216454140074177, 19.848281178208055, null, 1.7036066928092553m, 4.427610056630678m },
                    { new Guid("7ab6b4d1-7eb5-43c2-bf80-f00200eb02f0"), "INFINITI", "Haas", "Chad", 45.288022877311491, 19.874835733268696, null, 1.5866952090365798m, 8.087357945507915m },
                    { new Guid("7ea976f7-f34b-434e-90fc-c2886ae57766"), "Dodge", "Construccion", "Petty", 45.227061274337601, 19.836243969656948, null, 1.0452853161733882m, 3.69863700318812m },
                    { new Guid("7ec644a7-b6f1-4196-a9fd-587edb031269"), "CHEVROLET", "Construccion", "Rossi", 45.287037867075718, 19.853352110430713, null, 1.1262567197952467m, 4.052167523478899m },
                    { new Guid("8071a27f-0ce6-4c0c-8ab7-00c78b688343"), "Roush", "Evangeline", "Granados", 45.255782205655841, 19.854106076392526, null, 1.7553795014338474m, 6.146249025698085m },
                    { new Guid("8079735d-03e2-4de3-b40c-9b9ab53d4a26"), "Chrysler", "Ibrahim", "Alina", 45.2993118675817, 19.796265612687975, null, 1.1089619486674978m, 10.521486246480235m },
                    { new Guid("812ab794-821b-4737-b94c-e669acd96a39"), "CHEVROLET", "Edouard", "Jehan", 45.210031240196187, 19.819412677818654, null, 1.2289611665909137m, 10.316446613551822m },
                    { new Guid("84d6b46d-384d-4674-812f-32d246bc0232"), "Cadillac", "Olga", "Kristen", 45.29340112834867, 19.822498825540769, null, 1.6875309773099558m, 6.45756305740285m },
                    { new Guid("85278c00-2202-4b71-8376-8a3c3d793d34"), "Porsche", "Jen", "Shar", 45.210580578767569, 19.787137195434291, null, 1.7006360867551042m, 9.781009068780087m },
                    { new Guid("87e1ebc3-9fce-495b-8430-49f08fd0c6a1"), "Acura", "Jasmine", "Dorothy", 45.209423511503424, 19.81749485016757, null, 1.3610869109414416m, 7.115251420780801m },
                    { new Guid("88ca5672-f45e-453c-bc3e-64e613ec7238"), "Jeep", "Jurg", "Colleen", 45.27947091909018, 19.803280137550804, null, 1.0642568736345543m, 1.1178482649382784m },
                    { new Guid("891101dd-8baf-43b7-aa45-3949992e9498"), "Aston Martin Lagonda Ltd", "Pauline", "Gunnar", 45.216454140074177, 19.848281178208055, null, 1.7036066928092553m, 4.427610056630678m },
                    { new Guid("8915991e-1eed-473d-9a11-39f9ca4dcd43"), "Mitsubishi Motors Corporation", "Bechmann", "Maikol", 45.279071426502327, 19.862370160619843, null, 1.324328579217307m, 4.565442360558393m },
                    { new Guid("894e9767-da3a-4097-93d5-a634faec4edb"), "Mercedes-Benz", "Osvando", "Nicolaios", 45.216763399661289, 19.839646217936401, null, 1.390698997245516m, 2.4629580725247315m },
                    { new Guid("8977c442-d997-43f4-a810-c0b5de78ffda"), "Jaguar", "Mannix", "Gisella", 45.296266247572717, 19.804770086487757, null, 1.6910908453429156m, 3.2823166597464395m },
                    { new Guid("8c3da618-170c-477c-ba9e-b6cb68bea74b"), "Aston Martin Lagonda Ltd", "Knox", "Lorrie", 45.264656353292338, 19.837986673820598, null, 1.536456046701279m, 4.863201684677997m },
                    { new Guid("8debf956-a0fd-4486-8a1d-71dd4b6feedd"), "Volvo", "Zena", "Kirstein", 45.238319779725494, 19.810359597732457, null, 1.7020772550670218m, 10.79799094974425m },
                    { new Guid("91261ca7-ba96-410c-bd05-4adc0bed5050"), "Lamborghini", "Letizia", "Kerry", 45.281638953906281, 19.813600296747204, null, 1.099366625884517m, 1.3295397945411715m },
                    { new Guid("91ac2a70-5aca-496d-ba72-46ba55708b3b"), "Dodge", "Andreas", "Adolfo", 45.265939837651047, 19.832946913832068, null, 1.7380170039298m, 8.510688070544214m },
                    { new Guid("92c98223-0f08-40fb-b954-a9c4dc20694c"), "Volkswagen", "Werner", "Inde", 45.221608244262498, 19.819591497862248, null, 1.3967480906659557m, 4.545871705956596m },
                    { new Guid("937ddec7-17d3-420b-a27a-6c0fe6c2b1b9"), "TOYOTA", "Dang", "Erskine", 45.217855950352465, 19.834207010840032, null, 1.7497987535854724m, 4.824188848962091m },
                    { new Guid("9539603c-b37e-45db-a1af-4c1f02c500dd"), "Jaguar", "Mannix", "Gisella", 45.296266247572717, 19.804770086487757, null, 1.6910908453429156m, 3.2823166597464395m },
                    { new Guid("96b6eedb-d231-42ec-92d1-e5e9af33ba80"), "INFINITI", "Jastinder", "Homero", 45.269815899190036, 19.810080082882855, null, 1.5244558202271907m, 1.9469998885842523m },
                    { new Guid("96d902cb-c46e-4aba-bbd5-8febb1ef3e3e"), "Jaguar", "Dilini", "Joy", 45.204205166231176, 19.821658287825695, null, 1.5632855538691586m, 9.828321299882433m },
                    { new Guid("96e95cb3-71a0-4aca-8ed0-f14761048394"), "Mitsubishi Motors Corporation", "Yev", "Leeann", 45.243827207876294, 19.795146332823769, null, 1.4038353529833358m, 7.1267708754257715m },
                    { new Guid("984bcb82-c9dc-4031-b64b-6fc0dfca265c"), "Mercedes-Benz", "Marielle", "Orzai", 45.247779667723108, 19.842528794842231, null, 1.1929093189440756m, 4.356274892567532m },
                    { new Guid("98f3ee4b-c0c3-47ca-a7e6-fc27c93eb1d8"), "BMW", "Jacques", "Lane", 45.213790253612132, 19.79774102895696, null, 1.7987752163597301m, 4.055436177433148m },
                    { new Guid("997ab992-5066-4baa-b82d-ae292016553d"), "Subaru", "Luz", "Jacqui", 45.282357438284876, 19.870750281402625, null, 1.3275739312198804m, 7.389799555041893m }
                });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Driver_ID", "Brand", "FirstName", "LastName", "Latitude", "Longitude", "PassengerId", "PricePerKM", "StartPrice" },
                values: new object[,]
                {
                    { new Guid("9ad3462d-3972-480c-b1f8-51b3bb95beaa"), "Aston Martin Lagonda Ltd", "Oracio", "Richie", 45.224688333074994, 19.83919841648629, null, 1.385540803473964m, 9.910185805400143m },
                    { new Guid("9e78b0f1-c53c-4223-be9a-466603b09158"), "Honda", "Talbot", "Carwen", 45.250169050776421, 19.794775524085665, null, 1.4473141471090796m, 4.881600711969098m },
                    { new Guid("a11df2e0-b647-4bc9-86c1-f761f5b92b88"), "Land Rover", "Oja", "Chin", 45.256914630896212, 19.858970871427317, null, 1.26487632045056m, 10.747802492089736m },
                    { new Guid("a13bf185-73dd-466d-998c-ba93294ed128"), "Mitsubishi Motors Corporation", "Bechmann", "Maikol", 45.279071426502327, 19.862370160619843, null, 1.324328579217307m, 4.565442360558393m },
                    { new Guid("a30fe068-f862-41b5-bc4d-7a586c45897e"), "Acura", "Jasmine", "Dorothy", 45.209423511503424, 19.81749485016757, null, 1.3610869109414416m, 7.115251420780801m },
                    { new Guid("a329b795-dada-40e9-a7e2-e1c6c8c9a11c"), "Mini", "Maurits", "Paulien", 45.296887928208001, 19.858852384808518, null, 1.7376903735062375m, 4.928084949383901m },
                    { new Guid("a3639fca-4cb6-4c15-a66b-d1e34cd5356c"), "Dodge", "Andreas", "Adolfo", 45.265939837651047, 19.832946913832068, null, 1.7380170039298m, 8.510688070544214m },
                    { new Guid("a3d9b81d-b768-4637-8c6b-f3665158ede4"), "MAZDA", "Callaghan", "Aiden", 45.215384546791014, 19.846282477003452, null, 1.7442378744022409m, 4.395966844983313m },
                    { new Guid("a4ff609e-10e8-427d-9493-2a52c9083083"), "Bentley", "Brandy", "Eleanor", 45.299538969878988, 19.880643245594662, null, 1.6281722977710191m, 5.728713211147051m },
                    { new Guid("a54c59e9-9b29-4bc0-a20b-3cd9c4a40861"), "Cadillac", "Olga", "Kristen", 45.29340112834867, 19.822498825540769, null, 1.6875309773099558m, 6.45756305740285m },
                    { new Guid("a5ec5a1a-0149-4efb-93d8-b5a01945aa09"), "Chrysler", "Russell", "Rune", 45.223988703409404, 19.821203339044121, null, 1.669900944787707m, 7.442289794627493m },
                    { new Guid("a5fb38e9-e955-47b4-a725-56be07b97035"), "Lincoln", "Delair", "Meredith", 45.252036208353331, 19.868004870058986, null, 1.6143386734417438m, 6.054391760371328m },
                    { new Guid("a7b4d3bf-7d9c-4d41-9aa7-cca06a6dcd21"), "MASERATI", "Residencia", "Casper", 45.229981095425153, 19.837153864471194, null, 1.554999380283847m, 9.574431191837565m },
                    { new Guid("a7dee342-5478-4d4f-99a9-882864ee8a82"), "Chevrolet", "Jerome", "Hoj", 45.26187929944556, 19.852975472519034, null, 1.332259599316662m, 4.833445837024005m },
                    { new Guid("a95f522c-0697-4fb2-b04f-e4f2d6d41fa6"), "Audi", "Carling", "Angeles", 45.256456267336631, 19.839344022449293, null, 1.2919937229218867m, 3.8797762168830876m },
                    { new Guid("ad6b8a65-ebc3-488b-8663-5c014e634ace"), "Bentley", "Liliya", "Yeliz", 45.278508705345807, 19.806480944684065, null, 1.7553152421709535m, 4.360324081230656m },
                    { new Guid("afb42415-adb7-4c19-9a9f-018ab212d5ae"), "Roush", "Rossane", "Jessica", 45.266559868005444, 19.829707954977223, null, 1.504112436608676m, 9.364469311550952m },
                    { new Guid("b040e4ce-3e7d-40e7-9286-d97021032966"), "Porsche", "Lily", "Eugenia", 45.257195153791159, 19.808529545036901, null, 1.7101176770777686m, 2.275882597440534m },
                    { new Guid("b0bb0e4b-ae7a-4419-a031-1d43715a99d7"), "Roush", "Bernardino", "Danel", 45.262091751738382, 19.836733731194897, null, 1.685522127629019m, 5.239149409686604m },
                    { new Guid("b13af779-1c15-4627-95f8-c71840dedb8c"), "Ford", "Cora", "Otra", 45.278586743787962, 19.802530466611248, null, 1.7253447233445418m, 10.91510684753183m },
                    { new Guid("b2618d19-f2cf-4542-9645-46a7e2c38c5c"), "INFINITI", "Haas", "Chad", 45.288022877311491, 19.874835733268696, null, 1.5866952090365798m, 8.087357945507915m },
                    { new Guid("b70c7b8e-d09f-4fcf-b520-f40fad1d4623"), "Roush", "Evangeline", "Granados", 45.255782205655841, 19.854106076392526, null, 1.7553795014338474m, 6.146249025698085m },
                    { new Guid("b8285177-7c0c-4dd9-b07b-f94dfdc15352"), "Subaru", "Lombardet", "Casandra", 45.250568287681887, 19.824187873005126, null, 1.6563058877839092m, 10.512932624252946m },
                    { new Guid("ba3126a8-42f0-4521-8c50-31f91ac0a9c4"), "TOYOTA", "Henry", "Violoncella", 45.220604547812769, 19.860464073132178, null, 1.6549856762871982m, 8.414841851640341m },
                    { new Guid("bf1eb7e5-2b2a-4e3f-9e85-15bb646b2f51"), "Audi", "Carling", "Angeles", 45.256456267336631, 19.839344022449293, null, 1.2919937229218867m, 3.8797762168830876m },
                    { new Guid("bf6e933d-4fb0-4c36-9595-ad374b4416e7"), "Ford", "Leif", "Nalini", 45.281617289392479, 19.841755384683445, null, 1.0236099738160866m, 2.7658329456040622m },
                    { new Guid("c0d03660-f8de-41e6-89f6-52877715e74e"), "Lincoln", "Gert", "Andres", 45.279225594403293, 19.790054798757847, null, 1.1643840016635394m, 1.328847558195744m },
                    { new Guid("c109f5a7-526c-4427-9a44-9d0e06fb582a"), "Volvo", "Taryn", "Bener", 45.230507721803349, 19.8096740775133, null, 1.58709815212918m, 10.487772005185393m },
                    { new Guid("c28a1bf4-6a8b-4936-b203-a4e51771ea1d"), "FIAT", "Harold", "Karl", 45.286324628710155, 19.859015812248142, null, 1.7153672461915734m, 9.684974884213723m },
                    { new Guid("c2a19d0a-6148-4998-b151-5a7a2ca6370b"), "Lincoln", "Delair", "Meredith", 45.252036208353331, 19.868004870058986, null, 1.6143386734417438m, 6.054391760371328m },
                    { new Guid("c395b0e6-0935-4e6a-bf36-e92d9089bd01"), "Jeep", "Iya", "Jhonatan", 45.276139257770936, 19.843919556371958, null, 1.6328898520108956m, 7.314957794295983m },
                    { new Guid("cb6b8445-c635-4297-9fa6-45b8ab99a28d"), "Chevrolet", "Trace", "Gerry", 45.290891491829363, 19.828444245832451, null, 1.6389965205075372m, 8.368466873577997m },
                    { new Guid("cc27ae7a-86c7-4137-b310-4a854897f195"), "Mercedes-Benz", "Osvando", "Nicolaios", 45.216763399661289, 19.839646217936401, null, 1.390698997245516m, 2.4629580725247315m },
                    { new Guid("ce0f9e4d-9b46-4191-8636-005be66daf2a"), "Roush", "Rossane", "Jessica", 45.266559868005444, 19.829707954977223, null, 1.504112436608676m, 9.364469311550952m },
                    { new Guid("ce40fc29-cf54-4c95-9798-ca5fd877e17b"), "Roush", "Iva", "Sloane", 45.218399244374908, 19.792091597548286, null, 1.6978977180498203m, 8.769920005723455m },
                    { new Guid("d0490c0c-ecf7-4aa1-a58a-245012e0cebb"), "Mini", "Jerildy", "Tzipora", 45.26373409468961, 19.820524995264094, null, 1.6770837896990307m, 3.156359811608757m },
                    { new Guid("d109c598-2357-4009-b2f6-c4e3ef56d6c0"), "RAM", "Renata", "Yadi", 45.296758424609912, 19.847822587069356, null, 1.5933840239464465m, 3.1678197529395926m },
                    { new Guid("d2ba7dda-80e7-48b3-8f36-37bd7bd12aec"), "Cadillac", "Misael", "Gizelle", 45.260938791275308, 19.796892550971364, null, 1.0686156356587282m, 4.528765037827812m },
                    { new Guid("d3073d26-0531-4988-9dc2-4ca1a6ff3aca"), "MAZDA", "Megpg", "Eunice", 45.219490140494258, 19.798772403836473, null, 1.3455814143383005m, 9.776292871306692m },
                    { new Guid("d59a0239-8bc2-499c-99bb-a0355ae6ad65"), "Mini", "Jerildy", "Tzipora", 45.26373409468961, 19.820524995264094, null, 1.6770837896990307m, 3.156359811608757m },
                    { new Guid("d5d13f31-c0ca-47e2-af55-d1ee2a6807f8"), "Volvo", "Lluvia", "Judd", 45.244554013188768, 19.872895707350001, null, 1.253412375617725m, 5.882144460892146m },
                    { new Guid("d666e16c-fdc7-4680-938c-3fc3401608da"), "Acura", "Anais", "Johnna", 45.287676498702332, 19.843019007354567, null, 1.1278655668254658m, 10.710397156830041m }
                });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Driver_ID", "Brand", "FirstName", "LastName", "Latitude", "Longitude", "PassengerId", "PricePerKM", "StartPrice" },
                values: new object[,]
                {
                    { new Guid("d941c82e-d1fa-459c-9f91-5558388e86d0"), "Mitsubishi Motors Corporation", "Yev", "Leeann", 45.243827207876294, 19.795146332823769, null, 1.4038353529833358m, 7.1267708754257715m },
                    { new Guid("d98aadef-0d80-4fb6-856a-2be6ca3afe5f"), "McLaren", "Flora", "Allesdandro", 45.250220306572913, 19.80629652423562, null, 1.6560543096854814m, 9.747141997226342m },
                    { new Guid("dac16f56-9145-497f-aba9-4ad2c137414f"), "MASERATI", "Vartan", "Rhee", 45.298049374458131, 19.878864637212104, null, 1.5393415373611448m, 6.559482220099541m },
                    { new Guid("dbbb4e11-e65f-456b-97be-214f8743dabb"), "Jeep", "Iya", "Jhonatan", 45.276139257770936, 19.843919556371958, null, 1.6328898520108956m, 7.314957794295983m },
                    { new Guid("dc734401-ca8e-40e9-906c-46e08e3a641c"), "Mercedes-Benz", "Marielle", "Orzai", 45.247779667723108, 19.842528794842231, null, 1.1929093189440756m, 4.356274892567532m },
                    { new Guid("de432a44-b0e7-445c-80bd-872193c4be61"), "Mini", "Larae", "Lindsey", 45.288988349342716, 19.869009669621189, null, 1.2705361960792216m, 3.7409616159613304m },
                    { new Guid("de6c6379-9c3d-4169-9ef4-3c321e414eb2"), "LEXUS", "Raina", "Lula", 45.223453054301878, 19.830829334577729, null, 1.0164590921625576m, 6.269772816844689m },
                    { new Guid("dfc8ba79-3ddd-4113-b4bd-a7d0731c7ed1"), "Jeep", "Jurg", "Colleen", 45.27947091909018, 19.803280137550804, null, 1.0642568736345543m, 1.1178482649382784m },
                    { new Guid("e260ffa1-b102-498d-9006-d2fbb79b83a5"), "TOYOTA", "Dang", "Erskine", 45.217855950352465, 19.834207010840032, null, 1.7497987535854724m, 4.824188848962091m },
                    { new Guid("e291af4d-57ad-45db-b14c-1e03bc1867ad"), "RAM", "Welch", "Vaishali", 45.226846241954064, 19.839414266674314, null, 1.3494145070278685m, 3.1034505930423064m },
                    { new Guid("e2eb940b-61ff-476d-bd41-424622932150"), "MAZDA", "Rafal", "Monserrat", 45.282153330425473, 19.800982908909283, null, 1.0444604099295751m, 6.848472092200129m },
                    { new Guid("e32ec928-dc39-4a0f-a4d9-30f0902a1fcf"), "Jeep", "Greening", "Brockie", 45.275815226573968, 19.811590339120048, null, 1.1547939566454073m, 4.416711302958615m },
                    { new Guid("e33f8a9f-771a-4d47-9efd-ad4a5e190ef1"), "Acura", "Anais", "Johnna", 45.287676498702332, 19.843019007354567, null, 1.1278655668254658m, 10.710397156830041m },
                    { new Guid("e42f9496-a8f5-4b06-8e4f-bc918e4994ab"), "Mini", "Rue", "Henrik", 45.234728393171295, 19.822851909980773, null, 1.1939296054078634m, 1.7459564675100006m },
                    { new Guid("e5ca6948-cc08-456b-9eb4-b5222871af52"), "Lamborghini", "Letizia", "Kerry", 45.281638953906281, 19.813600296747204, null, 1.099366625884517m, 1.3295397945411715m },
                    { new Guid("e6037c58-f922-446c-8688-124f45546878"), "Volvo", "Taryn", "Bener", 45.230507721803349, 19.8096740775133, null, 1.58709815212918m, 10.487772005185393m },
                    { new Guid("eb47f9a7-b5aa-4ada-a53f-4f92d00ebb05"), "CHEVROLET", "Edouard", "Jehan", 45.210031240196187, 19.819412677818654, null, 1.2289611665909137m, 10.316446613551822m },
                    { new Guid("ed4244ac-e606-4038-aab1-1ede08f9e60d"), "Land Rover", "Oja", "Chin", 45.256914630896212, 19.858970871427317, null, 1.26487632045056m, 10.747802492089736m },
                    { new Guid("ef3a4d60-5e8d-47c0-9af1-5d4445ac1135"), "ALFA ROMEO", "Allison", "Royden", 45.295945743171906, 19.857674174593402, null, 1.5237046745427651m, 10.405094574404158m },
                    { new Guid("f13fca95-a11b-403d-839e-dfafcb3366cb"), "Roush", "Iva", "Sloane", 45.218399244374908, 19.792091597548286, null, 1.6978977180498203m, 8.769920005723455m },
                    { new Guid("f5ea7d8d-21e3-40bf-a301-97f52c946799"), "Porsche", "Lily", "Eugenia", 45.257195153791159, 19.808529545036901, null, 1.7101176770777686m, 2.275882597440534m },
                    { new Guid("f67f9291-17d7-43c5-af40-c16ca74663c3"), "Volvo", "Jessa", "Tetiana", 45.228208563610373, 19.864794930227959, null, 1.4501630881251706m, 4.989849053623997m },
                    { new Guid("f697baf1-aa85-4a02-85ab-db8d84732c00"), "Mini", "Dianna", "Michal", 45.247323100321054, 19.842409377101806, null, 1.0397465494006515m, 5.223227457896003m },
                    { new Guid("f71c42f8-e9ba-402b-b962-0598027dc89d"), "TOYOTA", "Aden", "Eliza", 45.268648133812405, 19.831866095348715, null, 1.391490893102681m, 8.095125839709704m },
                    { new Guid("f7b8d1c4-72cc-4bde-bee8-32e4f3ec7492"), "Cadillac", "Misael", "Gizelle", 45.260938791275308, 19.796892550971364, null, 1.0686156356587282m, 4.528765037827812m },
                    { new Guid("f7c4f713-1456-4cd4-93ac-15d43c88bd52"), "Ford", "Leif", "Nalini", 45.281617289392479, 19.841755384683445, null, 1.0236099738160866m, 2.7658329456040622m },
                    { new Guid("f8646a71-4c8d-4258-a0fd-dbc7ce059060"), "Lamborghini", "Aparna", "Segundo", 45.225215199148884, 19.883468373193303, null, 1.2154110733189056m, 3.652480026698223m },
                    { new Guid("f9a9814a-7eba-4569-8f29-ea3a28739e2a"), "Volvo", "Emma", "Tasha", 45.285854370015166, 19.866548271059557, null, 1.0566431268333218m, 8.509215393598028m },
                    { new Guid("fae6871b-c2c7-460f-84a7-82ff53d8e3b7"), "Chrysler", "Russell", "Rune", 45.223988703409404, 19.821203339044121, null, 1.669900944787707m, 7.442289794627493m },
                    { new Guid("fae6a646-6782-4856-8674-5efa7825806c"), "TOYOTA", "Henry", "Violoncella", 45.220604547812769, 19.860464073132178, null, 1.6549856762871982m, 8.414841851640341m },
                    { new Guid("fc6109f3-3d4b-407d-a307-6d7e09fe59a7"), "MAZDA", "Rafal", "Monserrat", 45.282153330425473, 19.800982908909283, null, 1.0444604099295751m, 6.848472092200129m },
                    { new Guid("fea13385-9b96-4558-a640-579902b05124"), "Bentley", "Ann", "Canosa", 45.204344318934922, 19.835281956415212, null, 1.476499130995161m, 3.3429406521108387m }
                });

            migrationBuilder.InsertData(
                table: "Passengers",
                columns: new[] { "PassengerId", "Birthday", "Driver_ID", "Email", "PassengerLastname", "PassengerName", "PassengersLatitude", "PassengersLongitude" },
                values: new object[,]
                {
                    { new Guid("2f79f77d-8681-4b34-8d5e-4f62c25c7f85"), new DateTime(1985, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), "nikola@example.com", "Nikolic", "Nikola", 45.26713522876819, 19.833549673005127 },
                    { new Guid("7a50e23c-b736-47c1-b09b-b7c36f4fe84e"), new DateTime(1987, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), "ana@example.com", "Ivanovic", "Ana", 44.786568287681888, 20.448921673005128 },
                    { new Guid("7bec83e1-f904-4bf5-a739-907e3ecd22e8"), new DateTime(1992, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), "jelena@example.com", "Jankovic", "Jelena", 44.012793528768192, 20.91142273005126 },
                    { new Guid("85a1a848-9d5b-4442-b2da-c6887d3c49d0"), new DateTime(1994, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), "marija@example.com", "Maric", "Marija", 44.01652128768189, 21.00585973005126 },
                    { new Guid("b069aeae-a2cd-4e8c-a541-27cf3c9643a2"), new DateTime(1993, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), "raca93@gmail.com", "Bjelic", "Radivoje", 45.290568287681893, 19.924187873005128 },
                    { new Guid("d01fdb60-c21a-4516-a043-319f5bb7ee6e"), new DateTime(1990, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), "marko@example.com", "Petrovic", "Marko", 43.32090222876819, 21.895758973005126 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Passengers_Email",
                table: "Passengers",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Drivers_PassengerId",
                table: "Drivers",
                column: "PassengerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Drivers_Passengers_PassengerId",
                table: "Drivers",
                column: "PassengerId",
                principalTable: "Passengers",
                principalColumn: "PassengerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Drivers_Passengers_PassengerId",
                table: "Drivers");

            migrationBuilder.DropIndex(
                name: "IX_Passengers_Email",
                table: "Passengers");

            migrationBuilder.DropIndex(
                name: "IX_Drivers_PassengerId",
                table: "Drivers");

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("00e9de7e-01ad-4fe1-ae68-ca1efee0ad0e"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("00f36e47-547d-485f-9db1-17b014167e92"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("01620c9e-6033-431c-93c1-6eb16fd9c00c"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("01650031-749f-4d48-ba9f-71487925857a"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("0228aa27-9626-4b9c-81e5-b2b9f38d5dd4"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("0309b046-4098-475e-93aa-3f6825730291"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("03b51e50-4289-4b2f-9d13-053401ce0960"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("03e12f6f-5a7e-4be8-8ffe-84a721ed50f1"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("048566d9-ec66-47ac-93fd-0919ce488b22"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("074f30cd-b949-452f-b5f4-fc9af2d61113"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("09ead8ea-9b20-4a33-b39a-c500710bb1ad"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("0acf1bc0-983d-47c1-99b6-61546f9f8bbe"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("0d7c0645-56d2-4f73-af79-31733fc84783"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("0e3dab34-bfad-4baf-b00d-61908a7f4eba"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("0fed1142-3102-48af-921d-609e970436ac"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("11060d5b-2ee7-4f61-81cd-1f7bb5f5adba"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("13b0f3c4-0426-4170-91da-65eeb5815908"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("141c0a05-3806-4631-921e-3b987f397aae"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("153c3042-d33e-4a19-b19a-37c4bf5f429f"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("166eb87f-a37e-4713-aa7e-999907a07933"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("1815919b-ab44-444b-b895-ea5312196c4c"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("1830f0a3-2b15-4201-bfa8-fb55f3366587"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("18d2bd5b-0d61-4f2f-a64f-2049016da2c0"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("195491c7-26b6-408d-b8b4-1a23a08c6625"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("1a879c4c-96b4-4357-9b71-aa87805a8a18"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("1bddddbd-76cd-456f-90e9-d246e17a54ca"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("1ed1b074-858d-41ad-9766-65211a9143a1"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("21d350ef-dc04-4d51-b514-613c0a41a967"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("22a2adf5-0177-4619-992a-15ec3248f76d"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("22d8150c-8b54-4973-b1d3-774371dfa8f9"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("267a100b-7f65-453b-8ce2-4420d97aa193"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("29c474ae-70e4-42cb-83bb-9d36345cfc7f"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("2a5accb3-554f-4b5b-9840-8fdcf7e9641f"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("2c3ee8fc-84c9-40f8-b7f9-aa2ac826b9ec"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("2cac01f6-fffd-4a59-8cde-835a8b3c5648"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("2cb73476-c832-4aca-b2b9-1f67f210a9c4"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("2cb89d66-085d-4ebd-b8eb-e71e10820950"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("309ce93c-bc04-485f-abdf-231b33fb98a2"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("30e6b365-4041-48d8-af73-993f58d18b55"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("3106ae8d-68c5-4466-bec4-dbe565911d22"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("31b5c3f8-353e-4b66-945c-284ea6ccff06"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("3455cfd7-3fb5-48af-ad16-65746bfade41"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("35286419-204b-460b-be3f-084d5a38451d"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("35384791-5da2-4c5d-b336-a31de15aca19"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("35a58572-2450-43b0-b466-b3e8c5f3ae1f"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("3629de8b-98f9-4100-83c3-e31cfcc5a6c0"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("367e8cac-aeee-4b12-adf5-4c5eb94be68d"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("37ec0fe2-0be8-49cd-bb01-b8fd77aec34f"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("39258377-e38f-4201-87f2-18d08e455d04"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("3a1d3b8e-8acb-457b-bfe8-7ce6af5684e2"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("3afed86b-5ad0-4702-ace5-cb2e6ee951fb"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("3b23797d-d899-42c1-aeff-0393ec9c8cfc"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("3f18daef-7697-44fb-96ca-2ff56fc13ad1"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("3f47f161-82d8-48d1-b7bc-d5bd8f3e83bc"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("4045b6a8-fc43-4fe9-b1f5-a5949c16164f"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("4177a539-5fae-424b-bf5c-afb8087a9a3e"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("41be70b9-6c47-4671-9794-d43294ba8491"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("41c332cf-fcf3-411a-9b24-994ebb5e1131"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("43a2ea07-b03f-4d70-a859-398f54cd8b30"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("4446bb12-4de4-4cef-971b-cc06fc17b06d"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("45fb1944-0c72-4da9-8779-d05e73b133b2"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("47dc1779-00cd-46ed-9ac9-89098a1598e2"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("4913826c-0b59-4a0f-8ac4-e93530c77ace"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("491ff64d-816d-4224-b721-ec20ccc554b9"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("4967b5c2-3354-4a52-bb81-3fefe0c7a369"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("4a87fbe6-03e2-4468-b1fa-1f66f4da2982"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("4b6c1444-659c-4b45-876d-8f49602e1df8"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("4d45cd7b-6926-4072-a1b8-9511a9a0b1ff"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("4d7af739-2d4e-4a30-add2-ec1cdf2b6148"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("4e593572-1663-49d9-a58d-e0fdd0ffc950"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("4e73e2d7-d499-438a-8ed4-5a6547909569"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("5068bf27-cf2f-4c37-b30a-6c4a6f882c47"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("52881991-d721-4904-8cbc-1a57cefdbc11"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("52feceb9-1f4c-4d33-88af-a61561e74be0"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("576dbb55-a5be-4dea-b95f-75faabf88386"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("583e4baa-3ae8-48cc-84c4-6dd3df43eaf2"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("58d2578c-0734-41d9-92e2-c19375597e0a"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("58fbbb89-cf48-4982-bec4-111cbb7bb110"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("59f960e2-8446-404c-9eba-c31ab33a6e15"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("5b12e337-d815-4cf2-9fdb-5f45a8d0ea96"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("5ce941c9-9738-40ab-8ee7-b511ea58d6cb"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("5d030eac-6267-4016-9983-1c3437bfa99b"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("5d903d94-7bd4-4b7d-8518-c6e00a4e8cb5"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("5f06e4ea-879e-4178-aa20-33a11e46a063"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("6065e47e-d656-403e-993a-9ff22cde2d75"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("6207ac64-008b-473c-877d-9ad9582d664f"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("646c7fc0-37d4-4f8a-9130-ad3eb836d745"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("648dc39c-e41c-48aa-ba1a-53bd29d00bf0"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("6539c264-c862-4d4b-9c29-f337943066a4"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("656ddb69-869d-4f7b-94ca-b9361d379d3b"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("66671b2b-1e61-4663-8ca0-963bdf4daa2a"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("66766657-2612-4529-84c9-49113b974fb4"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("693c9edf-414d-40d9-b77f-a5a97b95b338"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("6b2ecc34-a97b-400b-ac4f-22775e733779"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("6dc06fe4-8ff5-4a53-b9a8-f8d28d7f11c4"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("6e6e07bf-8703-4c38-bb3c-79ec48a7e0ff"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("6ea8ae57-b863-4587-a0ca-8e458ff15282"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("71469497-07cc-4a5a-a1e1-9f3c113cbda3"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("76b48731-3f3d-4d17-b1ad-614a395fc01f"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("7ab6b4d1-7eb5-43c2-bf80-f00200eb02f0"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("7ea976f7-f34b-434e-90fc-c2886ae57766"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("7ec644a7-b6f1-4196-a9fd-587edb031269"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("8071a27f-0ce6-4c0c-8ab7-00c78b688343"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("8079735d-03e2-4de3-b40c-9b9ab53d4a26"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("812ab794-821b-4737-b94c-e669acd96a39"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("84d6b46d-384d-4674-812f-32d246bc0232"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("85278c00-2202-4b71-8376-8a3c3d793d34"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("87e1ebc3-9fce-495b-8430-49f08fd0c6a1"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("88ca5672-f45e-453c-bc3e-64e613ec7238"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("891101dd-8baf-43b7-aa45-3949992e9498"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("8915991e-1eed-473d-9a11-39f9ca4dcd43"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("894e9767-da3a-4097-93d5-a634faec4edb"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("8977c442-d997-43f4-a810-c0b5de78ffda"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("8c3da618-170c-477c-ba9e-b6cb68bea74b"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("8debf956-a0fd-4486-8a1d-71dd4b6feedd"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("91261ca7-ba96-410c-bd05-4adc0bed5050"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("91ac2a70-5aca-496d-ba72-46ba55708b3b"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("92c98223-0f08-40fb-b954-a9c4dc20694c"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("937ddec7-17d3-420b-a27a-6c0fe6c2b1b9"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("9539603c-b37e-45db-a1af-4c1f02c500dd"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("96b6eedb-d231-42ec-92d1-e5e9af33ba80"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("96d902cb-c46e-4aba-bbd5-8febb1ef3e3e"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("96e95cb3-71a0-4aca-8ed0-f14761048394"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("984bcb82-c9dc-4031-b64b-6fc0dfca265c"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("98f3ee4b-c0c3-47ca-a7e6-fc27c93eb1d8"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("997ab992-5066-4baa-b82d-ae292016553d"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("9ad3462d-3972-480c-b1f8-51b3bb95beaa"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("9e78b0f1-c53c-4223-be9a-466603b09158"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("a11df2e0-b647-4bc9-86c1-f761f5b92b88"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("a13bf185-73dd-466d-998c-ba93294ed128"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("a30fe068-f862-41b5-bc4d-7a586c45897e"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("a329b795-dada-40e9-a7e2-e1c6c8c9a11c"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("a3639fca-4cb6-4c15-a66b-d1e34cd5356c"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("a3d9b81d-b768-4637-8c6b-f3665158ede4"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("a4ff609e-10e8-427d-9493-2a52c9083083"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("a54c59e9-9b29-4bc0-a20b-3cd9c4a40861"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("a5ec5a1a-0149-4efb-93d8-b5a01945aa09"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("a5fb38e9-e955-47b4-a725-56be07b97035"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("a7b4d3bf-7d9c-4d41-9aa7-cca06a6dcd21"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("a7dee342-5478-4d4f-99a9-882864ee8a82"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("a95f522c-0697-4fb2-b04f-e4f2d6d41fa6"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("ad6b8a65-ebc3-488b-8663-5c014e634ace"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("afb42415-adb7-4c19-9a9f-018ab212d5ae"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("b040e4ce-3e7d-40e7-9286-d97021032966"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("b0bb0e4b-ae7a-4419-a031-1d43715a99d7"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("b13af779-1c15-4627-95f8-c71840dedb8c"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("b2618d19-f2cf-4542-9645-46a7e2c38c5c"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("b70c7b8e-d09f-4fcf-b520-f40fad1d4623"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("b8285177-7c0c-4dd9-b07b-f94dfdc15352"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("ba3126a8-42f0-4521-8c50-31f91ac0a9c4"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("bf1eb7e5-2b2a-4e3f-9e85-15bb646b2f51"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("bf6e933d-4fb0-4c36-9595-ad374b4416e7"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("c0d03660-f8de-41e6-89f6-52877715e74e"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("c109f5a7-526c-4427-9a44-9d0e06fb582a"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("c28a1bf4-6a8b-4936-b203-a4e51771ea1d"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("c2a19d0a-6148-4998-b151-5a7a2ca6370b"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("c395b0e6-0935-4e6a-bf36-e92d9089bd01"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("cb6b8445-c635-4297-9fa6-45b8ab99a28d"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("cc27ae7a-86c7-4137-b310-4a854897f195"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("ce0f9e4d-9b46-4191-8636-005be66daf2a"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("ce40fc29-cf54-4c95-9798-ca5fd877e17b"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("d0490c0c-ecf7-4aa1-a58a-245012e0cebb"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("d109c598-2357-4009-b2f6-c4e3ef56d6c0"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("d2ba7dda-80e7-48b3-8f36-37bd7bd12aec"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("d3073d26-0531-4988-9dc2-4ca1a6ff3aca"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("d59a0239-8bc2-499c-99bb-a0355ae6ad65"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("d5d13f31-c0ca-47e2-af55-d1ee2a6807f8"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("d666e16c-fdc7-4680-938c-3fc3401608da"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("d941c82e-d1fa-459c-9f91-5558388e86d0"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("d98aadef-0d80-4fb6-856a-2be6ca3afe5f"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("dac16f56-9145-497f-aba9-4ad2c137414f"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("dbbb4e11-e65f-456b-97be-214f8743dabb"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("dc734401-ca8e-40e9-906c-46e08e3a641c"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("de432a44-b0e7-445c-80bd-872193c4be61"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("de6c6379-9c3d-4169-9ef4-3c321e414eb2"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("dfc8ba79-3ddd-4113-b4bd-a7d0731c7ed1"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("e260ffa1-b102-498d-9006-d2fbb79b83a5"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("e291af4d-57ad-45db-b14c-1e03bc1867ad"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("e2eb940b-61ff-476d-bd41-424622932150"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("e32ec928-dc39-4a0f-a4d9-30f0902a1fcf"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("e33f8a9f-771a-4d47-9efd-ad4a5e190ef1"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("e42f9496-a8f5-4b06-8e4f-bc918e4994ab"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("e5ca6948-cc08-456b-9eb4-b5222871af52"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("e6037c58-f922-446c-8688-124f45546878"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("eb47f9a7-b5aa-4ada-a53f-4f92d00ebb05"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("ed4244ac-e606-4038-aab1-1ede08f9e60d"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("ef3a4d60-5e8d-47c0-9af1-5d4445ac1135"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("f13fca95-a11b-403d-839e-dfafcb3366cb"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("f5ea7d8d-21e3-40bf-a301-97f52c946799"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("f67f9291-17d7-43c5-af40-c16ca74663c3"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("f697baf1-aa85-4a02-85ab-db8d84732c00"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("f71c42f8-e9ba-402b-b962-0598027dc89d"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("f7b8d1c4-72cc-4bde-bee8-32e4f3ec7492"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("f7c4f713-1456-4cd4-93ac-15d43c88bd52"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("f8646a71-4c8d-4258-a0fd-dbc7ce059060"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("f9a9814a-7eba-4569-8f29-ea3a28739e2a"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("fae6871b-c2c7-460f-84a7-82ff53d8e3b7"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("fae6a646-6782-4856-8674-5efa7825806c"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("fc6109f3-3d4b-407d-a307-6d7e09fe59a7"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("fea13385-9b96-4558-a640-579902b05124"));

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "PassengerId",
                keyValue: new Guid("2f79f77d-8681-4b34-8d5e-4f62c25c7f85"));

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "PassengerId",
                keyValue: new Guid("7a50e23c-b736-47c1-b09b-b7c36f4fe84e"));

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "PassengerId",
                keyValue: new Guid("7bec83e1-f904-4bf5-a739-907e3ecd22e8"));

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "PassengerId",
                keyValue: new Guid("85a1a848-9d5b-4442-b2da-c6887d3c49d0"));

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "PassengerId",
                keyValue: new Guid("b069aeae-a2cd-4e8c-a541-27cf3c9643a2"));

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "PassengerId",
                keyValue: new Guid("d01fdb60-c21a-4516-a043-319f5bb7ee6e"));

            migrationBuilder.DropColumn(
                name: "PassengerId",
                table: "Drivers");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Passengers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<Guid>(
                name: "Driver_ID1",
                table: "Passengers",
                type: "uniqueidentifier",
                nullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Passengers_Drivers_Driver_ID1",
                table: "Passengers",
                column: "Driver_ID1",
                principalTable: "Drivers",
                principalColumn: "Driver_ID");
        }
    }
}
