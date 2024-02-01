using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class PromenaModelaIDodavanjeRideControlleraSaMetodama : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rides_Rating_PassengerRatingRatingId",
                table: "Rides");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rating",
                table: "Rating");

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("020de484-1ae1-4eec-9287-f6294da32718"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("022ee03f-ea35-41e4-9906-8f3fa23a7591"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("038cfdb2-dea0-48ae-a8f0-a12e8426f425"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("04272bd8-b9b9-42bb-9265-745db2e54c79"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("092cb1f4-d4c4-45e9-8e82-fea8e4b0272a"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("09d4e34c-fb70-4586-aad8-6b34b7606b0c"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("0be4f955-06d5-49ee-9e9b-10ec9e8c1c4e"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("0ca7b03e-b326-48a7-ad7b-b4de4701f362"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("0cabf5a6-f7cd-442a-896a-cae57ffcdb65"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("11befd47-32c8-433a-962f-754543de958d"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("13195401-75a8-4825-8145-1ed94f2c537c"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("13c75b92-4854-4dca-b09a-8188c7fbb135"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("157e42c4-7b78-405c-b228-6e9c46479912"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("15b131be-f967-437f-b710-bbb9f20fa658"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("16def8c9-4c32-45ec-a236-70079d5eca61"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("18daedd2-cbe2-4b8e-959e-1a8de42e42ae"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("1a4626b1-8acd-445f-845b-96da0777f2ee"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("1af79f7b-fae2-4697-a3e6-3907db1615a6"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("1e55e414-b097-4c4b-9ea4-e328cb3c4d65"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("1f00978c-ed67-438a-a729-b45d7b254c5f"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("203fba9c-c106-4f3f-97f6-6130eef4c0aa"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("2107be5f-18d7-4e24-9bcb-f346b2060f7c"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("21b022df-fe57-44be-8151-5988a2721e02"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("267ea390-c9f0-4969-9ef3-4bcdfa803676"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("268a7bca-f213-461b-9993-edaffd4e3b73"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("298a6277-0919-474d-b624-c53130a5a997"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("2a399653-4051-42a4-be1d-2f2de7827cec"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("2be9326e-7bb0-41bd-af84-a3f26f795ad5"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("2c6d74f4-9de7-405c-aa64-ce824adbc9e0"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("2e0faf59-e076-41c7-a6b3-7b1f450939af"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("2f42015e-9846-491d-9cc7-13720ab6a3a4"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("31af3617-c44e-4c3c-9cf4-8fa859cb832a"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("32853743-ff3d-4c8f-b74e-ba03d16fe22a"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("32b5f6d1-4cbe-49b7-89b4-b26ceca7b7c0"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("32e6b1f9-3d03-4f39-86df-50992263a5fc"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("349b803e-9718-40c3-9619-ccc9b4670b81"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("34c46dc3-2cf4-4de9-806f-04a03e5b6ac0"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("35618346-491d-4c51-943d-be1f0b05062f"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("3827bbb5-6cfd-4dee-b053-4154834c02e5"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("38af677e-9c29-4532-bacb-6d78a57e478f"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("39f4252d-7a97-442d-ba04-cab30d27d809"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("3c41329b-af7a-4c53-ae15-1e5e6320dbdc"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("3f25423b-61c0-456f-b9c4-b208edb563c8"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("3f5e72a8-7809-4e90-a874-aa1b0087a3d4"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("40e5532f-83d6-41c9-81f9-8927e8d941ad"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("410b56fd-a434-482a-b803-f1b745007293"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("42a6430f-08a3-436c-8fb4-173b72475981"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("43534da5-70e3-4a66-b34b-f99f76c11da3"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("4bd6675f-89b9-4992-841c-68389d6f0e00"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("4d154d85-14b5-45fa-915d-fad8c18d3f03"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("4dfbfca4-11d4-408f-973d-fae7bd5fe4bc"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("4e51818c-5a76-46f1-8fca-c9cdfddb0710"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("4f2a2a9f-0645-4d66-8ce6-0d4ae581ab0e"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("504e8ed9-fc07-4f93-b1f0-7d64adbf9d24"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("50e5c4e7-066b-4a67-b045-8aee58336e18"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("518e4e6f-c4d7-4735-87c2-b783ac9ce8f9"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("5500e850-703c-47e1-b105-c1b680ed1e49"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("55526ce3-9d88-48f4-9d6d-28161daa1f8b"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("561c8e66-fa80-458a-a4e2-aa9b50212024"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("56df2523-b098-4d52-9fec-13c23d810d15"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("57b409cf-8a21-4bd1-ac8b-a3c5c9021ec0"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("57f60b33-4fc9-4828-98fd-2f57fe68840a"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("59cba95c-771a-4337-9403-7898516a343b"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("5a08cd45-1efb-4e22-9eed-f2c335e6fa85"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("5b2eecbb-1eec-40c9-b63e-456382acff1a"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("5b485ee0-227a-46be-823a-52da9a90516c"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("5cb6b713-ca74-4ffd-b806-ed7917127b85"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("5d20c3eb-e644-4bb4-9e66-320ae317caa7"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("5fd2366b-2b67-48fb-a66f-37a2dcf74c4c"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("6027db2a-6921-4515-ad9e-7ffd3e0e190b"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("605c618e-754a-48a4-98a6-f63bc16aab50"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("61131876-f78f-453e-bcd2-e090c181c81e"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("63e2d6a4-43cb-47f8-bdfe-e5b01abcb2c4"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("640e1016-17be-4283-b159-1eac44e14b62"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("66aa5277-0f16-4665-9a28-6006ca71ce5c"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("67f7d525-8b61-4b14-8df8-e8eba2f2ebfc"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("68675f0b-fb93-46ce-aa61-40fdffb952f8"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("6975e463-d56d-4178-b03b-12eaf17994e9"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("6d609ecc-b0f7-4f88-b00a-32539f5bb021"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("6e6078df-cefb-4c81-9145-5375d669fc7d"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("6ee1331c-462c-4986-935b-f0a8e7041c4b"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("6f08cea2-4f44-4380-a770-7013ed304f68"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("6f16f067-29ef-42be-9a32-425afabbf674"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("70a98fd7-34dd-4ef5-a69b-3dffca622600"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("71a830bd-b0a8-4303-94dd-60778ed66b63"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("71dadfe6-3b0a-4639-aa12-efb7b39581f4"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("734a20f6-161b-469f-88c6-65e09e5ebeca"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("74a62213-9628-42d4-96a0-1766d2ae2bfc"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("750bff57-29e3-457d-8cc1-a8c09c8f04d8"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("75b76349-292f-4d9a-aebd-ca293d6b6b53"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("763b3c4e-f0ff-40eb-a048-c1aa604ace9c"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("76b38482-b60a-4e1b-9eee-7017564297a2"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("7727980a-98d3-476b-b981-a29b7e2adb73"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("779d55f6-24cb-4306-9a76-a8e2855fdc9c"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("8088811f-21d9-4587-9eb9-9ee260982cc8"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("8182c746-6cb6-4a19-866d-4c4a8ffee485"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("81d42277-ed87-4888-847e-2870d412154d"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("81deb4e5-9c68-4134-abc9-3b0db878d6c4"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("81e03b22-e214-4ce8-8b5a-3c8a973f2768"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("832d12ac-4183-4d5e-b870-bbe08e8591c3"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("842c1ca6-0f91-4136-941b-2aaa1c2b355d"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("8531fade-03e5-4c7e-8c77-ef4e7ec168f3"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("869fc6ff-34f1-420c-97ca-8660c89a7db2"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("8a73869b-e68e-40c8-aff5-82850caac111"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("8e6a101d-57ef-457d-b4c5-c54f699a5f5c"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("8e89102c-a16a-40ad-b814-9274433f9907"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("8feef69a-689a-4d56-9e22-ba6c47ce1a31"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("90333bae-053b-4c53-b23b-8f136574bd85"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("920c915e-654d-4d96-8dac-54520cdcd0ba"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("95d52176-402a-4e99-9df8-ac5294a4b12e"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("9876cd6f-9376-4006-9344-1e1cfa221aee"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("9c4e2499-8720-4fdb-85e1-e4efd9ff5486"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("9c6405ea-666f-444d-a01c-8cc95b13442d"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("9d307f11-3951-4215-b68a-d547d83877be"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("9d3b5e31-c787-41ea-a145-d2675839d3f8"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("9d52021b-e650-4780-a581-8e3528c4960f"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("9dcb0194-cb97-4d6a-9cab-f5e367670087"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("9ef093c8-3c42-4a9d-8e6d-36dfb1c90898"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("a0c2d9bf-0706-4fcc-9357-b9a1d2f16bef"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("a1ff0676-2809-448c-92f7-ae9e34fc32d3"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("a7ec04d4-cc17-4a45-b8c5-3005aa06c787"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("a8afe785-2119-4d9e-83f1-44f5b9814f50"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("ac6450ab-15f2-4fe7-a53c-36f47e780347"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("add8504b-39e1-47ef-89cb-4c0291cc94b2"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("af511470-b696-44ea-82f1-51743e019bfc"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("af565f3f-e01f-4de8-8f5f-17ba9f90b76e"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("af5d2c60-5446-4c48-903c-7717dfb7c100"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("aff53317-a398-4e33-8c95-ce9e62a9a316"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("b19e7ff2-7cb1-498c-b822-92f8d2e46060"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("b40921a2-1a78-4159-b006-23f8a0f9abac"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("b4a87f91-aaa7-42ef-bb79-2ed1705f44fc"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("b7350d18-fd53-4d7f-b126-a67c6ac2c9cd"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("b8352a80-2261-4f00-b68c-9cb3a5650959"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("bbd6a48b-61b2-436b-a1b2-8f76c24ee3f4"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("be4daf4e-0cba-4087-93ea-72b5f3a056c4"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("bf1fab92-ec01-4ca1-98c0-ce3f4380ced0"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("c0030c02-1eab-41cb-a799-164a8d35ced9"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("c19b0f96-5928-4ca2-bbfd-84ddfccd94d8"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("c2047d7f-5553-43ee-b447-0183274c5ca8"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("c3b26e51-dbe6-46bc-8680-c6f2315961f0"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("c3da9ec9-664c-4898-ac89-0894b73fcfc0"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("c58cd1b2-b179-4807-a617-d96c207d3651"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("c63e4c79-0a37-49d9-b7c5-423f6bf7fd50"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("c6751013-e979-4b60-9570-33362990c04d"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("c700d926-b99c-4650-be72-4f88d9f7c0d9"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("c778021b-a4d1-4c61-a4f2-6aa1758f0097"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("c78af650-b34c-47b8-a7e5-dffbd15973c1"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("c7e837b2-8d10-4e43-a3bb-d400252c5f6b"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("ca03e5ce-a3bc-41c4-8840-8d6dc94f94d2"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("cb826b9a-65ef-44b7-9740-45ffd7f1530e"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("cbad7c41-f0fe-4773-aacd-174532e71c48"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("ce8e4569-03b2-4b46-8181-54269b561137"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("ceba7c8c-2e00-4e65-88fc-353367156534"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("cf39afbb-c124-4076-a863-fa971e6c4976"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("cf7fc401-e44f-4b9b-8e60-ffbb76626002"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("cfe04c65-4bbb-4153-9cbf-90e8c7f25b4e"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("cfef5d9c-093b-4bc5-9957-0509c512656e"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("d034b92b-18b6-4ba4-ab47-2205aaa4802f"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("d04c1b15-ed54-433b-9a69-c0aee24923eb"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("d0d243a5-2968-4d89-9a7e-757f0976fccd"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("d0deaa6b-543b-4682-886f-c0ef258b35fd"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("d30712e5-b597-4de8-8901-f1a8ab82d647"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("d3655f52-2de5-48f0-8d6d-b31f182e80c5"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("d594f79d-072a-41ba-967b-94eb5e26a223"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("d8a87052-ca79-4f72-a9a0-e1d8cb170a76"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("d98b2369-e3c1-44cc-8d03-4a4a74d64647"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("dc0c19e0-2678-48c0-841f-94a979a4aa91"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("dc201edd-67ff-4028-856f-256a4f7aac6c"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("dd5f7647-9fd6-414d-9050-cf4cc31d94e5"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("ddcb8aea-6c1e-4e95-b13d-f8087c5315d7"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("de9fbe7a-b98e-46ec-aefd-c69f3ffbd276"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("e00b179b-7546-436b-b246-ea724b570276"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("e1c5ce9f-3529-41e7-a56a-97b3e3bb24b4"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("e2bd45f3-a4d7-4041-9f0c-3e09194f9385"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("e2e3ec14-3875-4f13-918f-68554f741194"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("e3362b46-55b3-4ebd-aa7f-4b2941304863"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("e52718c5-ab86-482e-bc77-268ce1342aa7"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("e532877c-e84e-401f-bd35-2dfa3014ac91"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("e5c1ffd8-3bce-4277-9fa5-bf05e2b2a075"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("e7a14d82-7bac-43f7-a8a6-5c5e00be1723"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("e858bbc2-d341-46b0-9391-51087e849d25"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("e9070f03-dfc0-4ea5-88d7-736ef9776144"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("e99bf370-5d7f-4f39-97e6-f74a0170cc0e"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("ea17d42b-e6c7-499e-a958-bea15cfd92ea"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("ec8c7177-b49d-4080-82ba-1f3478ca55a7"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("ee8fedf4-bcc2-4b2a-b35d-5899d63e4d68"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("f0109842-ccd2-4754-bd48-1ed92692cf27"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("f0f48005-a875-43c1-8339-4af93560e86b"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("f43d43ec-01d3-400f-a585-56d589eb01ba"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("f45ccff0-2d4f-4ca9-8bc4-1069748dff53"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("f486bf9e-fa05-440e-af17-aeaada3ffb27"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("f6043b76-ed6b-4ca7-979a-556179870a65"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("f77172ac-dfa1-4363-af95-286ed2efe603"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("f7bc5e85-3664-4456-9672-1a53901240be"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("f7cc36a9-f198-4785-8621-61e8f00f763c"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("f86873d4-05f8-4d6c-a2ca-f05996ab2e68"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("f8bf001c-e596-4bd7-8bab-4f1213a50c21"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("f8caca75-e311-404c-92e9-d206b6436eba"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("fdfac433-73bc-456f-a39d-133064b9ae85"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("ff18b965-fea6-4823-9e9e-6895f151e688"));

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "PassengerId",
                keyValue: new Guid("1a145da1-9ddf-482b-8602-eb611dd2bad7"));

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "PassengerId",
                keyValue: new Guid("6a44d2e9-a554-4f5e-aff3-2c7147227fe3"));

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "PassengerId",
                keyValue: new Guid("af3c7fe9-89e9-4c0a-bb17-644320c49d7e"));

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "PassengerId",
                keyValue: new Guid("b11b8b0a-6ed2-4e40-b8ce-149af7fef4f0"));

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "PassengerId",
                keyValue: new Guid("b7eed1ed-11fa-47b8-9374-70a7f65f776a"));

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "PassengerId",
                keyValue: new Guid("f4ced285-67fd-4e7a-b0e9-f3897c7ac5db"));

            migrationBuilder.RenameTable(
                name: "Rating",
                newName: "Ratings");

            migrationBuilder.AlterColumn<string>(
                name: "PassengerName",
                table: "Passengers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PassengerLastname",
                table: "Passengers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Drivers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Drivers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Brand",
                table: "Drivers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Comment",
                table: "Ratings",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ratings",
                table: "Ratings",
                column: "RatingId");

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Driver_ID", "Brand", "DriverStatus", "FirstName", "LastName", "Latitude", "Longitude", "PassengerId", "PricePerKM", "StartPrice" },
                values: new object[,]
                {
                    { new Guid("0066ec63-9628-4504-b8c7-652322e70b11"), "Audi", 0, "Beata", "Salome", 45.29945492843008, 19.844297003241515, null, 1.0417866558859206m, 1.2473101141077794m },
                    { new Guid("0258e3df-7fd7-4d88-b28d-dfe396649ce1"), "SCION", 0, "Vanessa", "Moran", 45.243401442719865, 19.845486901252453, null, 1.766625245740726m, 1.5974547157697985m },
                    { new Guid("025afc0d-aa91-4dae-933e-0cd285a7a1dd"), "Porsche", 0, "Chrissy", "Tanyia", 45.279449168518042, 19.785822522191463, null, 1.4492458808602435m, 2.028265801352166m },
                    { new Guid("040bcb05-44dc-4d18-80ea-20faac78bf44"), "Porsche", 0, "Chrissy", "Tanyia", 45.279449168518042, 19.785822522191463, null, 1.4492458808602435m, 2.028265801352166m },
                    { new Guid("040e3720-ccdb-4ed2-bcc9-16e0d31d0683"), "Ford", 0, "Cora", "Otra", 45.278586743787962, 19.802530466611248, null, 1.7253447233445418m, 10.91510684753183m },
                    { new Guid("0547e03b-7b0d-4bae-914e-8afc24e3ce91"), "Land Rover", 0, "Oja", "Chin", 45.256914630896212, 19.858970871427317, null, 1.26487632045056m, 10.747802492089736m },
                    { new Guid("05a1a237-3917-42a2-acad-ce429942aa26"), "Chrysler", 0, "Russell", "Rune", 45.223988703409404, 19.821203339044121, null, 1.669900944787707m, 7.442289794627493m },
                    { new Guid("06fd05ed-aee1-480f-8fe9-01344234bffc"), "BMW", 0, "Jacques", "Lane", 45.213790253612132, 19.79774102895696, null, 1.7987752163597301m, 4.055436177433148m },
                    { new Guid("0805ea1d-06c2-40e0-83a1-54a4e10c7034"), "Aston Martin Lagonda Ltd", 0, "Knox", "Lorrie", 45.264656353292338, 19.837986673820598, null, 1.536456046701279m, 4.863201684677997m },
                    { new Guid("0971d37b-b215-4db8-98f0-c4dd1fb765f5"), "Aston Martin Lagonda Ltd", 0, "Knox", "Lorrie", 45.264656353292338, 19.837986673820598, null, 1.536456046701279m, 4.863201684677997m },
                    { new Guid("0aab4918-859e-4147-8e73-8f8e6607f613"), "Mini", 0, "Dianna", "Michal", 45.247323100321054, 19.842409377101806, null, 1.0397465494006515m, 5.223227457896003m },
                    { new Guid("0b3eb4f1-b1c1-4e05-a333-b5b5c53d9907"), "Lamborghini", 0, "Ilhan", "Reserved", 45.269939911723235, 19.805821814574692, null, 1.7714084180476508m, 8.149353140401365m },
                    { new Guid("0c49f275-2d8d-4779-af6e-42b34bdf4428"), "Jeep", 0, "Jurg", "Colleen", 45.27947091909018, 19.803280137550804, null, 1.0642568736345543m, 1.1178482649382784m },
                    { new Guid("0ed7b80b-0046-46c4-adac-db88fc73eb9b"), "Chevrolet", 0, "Krizia", "Brusovanik", 45.267957633744437, 19.799666210958843, null, 1.6786208486121708m, 7.342233447742731m },
                    { new Guid("0f77fca6-5075-4b8e-b54d-9afaa48e62c6"), "Bentley", 0, "Liliya", "Yeliz", 45.278508705345807, 19.806480944684065, null, 1.7553152421709535m, 4.360324081230656m },
                    { new Guid("0fc512d9-fc2b-413a-a2da-e9746776703e"), "ALFA ROMEO", 0, "Allison", "Royden", 45.295945743171906, 19.857674174593402, null, 1.5237046745427651m, 10.405094574404158m },
                    { new Guid("12674d44-f35a-4e69-b5dd-073f94db79a3"), "Jaguar", 0, "Dilini", "Joy", 45.204205166231176, 19.821658287825695, null, 1.5632855538691586m, 9.828321299882433m },
                    { new Guid("14e4628c-592c-48b3-b16e-64ca70739a16"), "Cadillac", 0, "Misael", "Gizelle", 45.260938791275308, 19.796892550971364, null, 1.0686156356587282m, 4.528765037827812m },
                    { new Guid("161a6b3a-765b-4251-8328-53fa489d7ca2"), "Porsche", 0, "Jen", "Shar", 45.210580578767569, 19.787137195434291, null, 1.7006360867551042m, 9.781009068780087m },
                    { new Guid("16693e8c-4567-49a7-956e-2421735b133e"), "Pagani Automobili S.p.A.", 0, "Morrissey", "Kellie", 45.274651670577768, 19.791858685850482, null, 1.3417230653533827m, 2.18234253206158m },
                    { new Guid("18b185a4-e174-4974-8df0-93d2140ad910"), "Lincoln", 0, "Delair", "Meredith", 45.252036208353331, 19.868004870058986, null, 1.6143386734417438m, 6.054391760371328m },
                    { new Guid("1a16ace8-d9ef-4ac6-8084-650d0fa7c08b"), "Roush", 0, "Iva", "Sloane", 45.218399244374908, 19.792091597548286, null, 1.6978977180498203m, 8.769920005723455m },
                    { new Guid("1a713d0b-4672-47ee-baed-23b16b57885b"), "Jaguar", 0, "Mannix", "Gisella", 45.296266247572717, 19.804770086487757, null, 1.6910908453429156m, 3.2823166597464395m },
                    { new Guid("1afbb7ef-d60b-4996-9b5b-4229ec262f35"), "Subaru", 0, "Luz", "Jacqui", 45.282357438284876, 19.870750281402625, null, 1.3275739312198804m, 7.389799555041893m },
                    { new Guid("1bdd960f-71b3-4f70-a442-b39248159f4d"), "Volvo", 0, "Zena", "Kirstein", 45.238319779725494, 19.810359597732457, null, 1.7020772550670218m, 10.79799094974425m },
                    { new Guid("1c0568db-2c2d-4d4d-9c04-cbbecf5b9f7e"), "Porsche", 0, "Walker", "Maruk", 45.217759832566678, 19.812095479197652, null, 1.0201468787267918m, 8.987330756776993m },
                    { new Guid("1c951d4a-0e3d-443f-9c88-9872280aa68b"), "GMC", 0, "Brehan", "Leonardo", 45.284932615672936, 19.861347707346106, null, 1.0165564995215457m, 10.543527811952874m },
                    { new Guid("1d927993-d41a-4004-8899-932a645c5abf"), "Porsche", 0, "Jen", "Shar", 45.210580578767569, 19.787137195434291, null, 1.7006360867551042m, 9.781009068780087m },
                    { new Guid("1db3d084-538f-4f31-8f2e-33145b573a0a"), "Aston Martin Lagonda Ltd", 0, "Elliot", "Loiselin", 45.222723321894421, 19.793603471598757, null, 1.5879618679964944m, 2.4186214661952135m },
                    { new Guid("1fa23c06-bc6a-4721-9695-8521d5be177e"), "Mini", 0, "Larae", "Lindsey", 45.288988349342716, 19.869009669621189, null, 1.2705361960792216m, 3.7409616159613304m },
                    { new Guid("2159b23d-8c58-4392-9334-3aef5c6a83cb"), "Lincoln", 0, "Javid", "Tranta", 45.216149699839988, 19.853299911074188, null, 1.214353703785661m, 4.696927726796888m },
                    { new Guid("232af038-5ad2-4322-b2f6-26b064e382bf"), "Audi", 0, "Marc", "Erin", 45.262776103747605, 19.866401987510415, null, 1.0237952565130846m, 1.8608874905715336m },
                    { new Guid("2333e0ee-bf35-46c5-95d1-e743af403f70"), "LEXUS", 0, "Raina", "Lula", 45.223453054301878, 19.830829334577729, null, 1.0164590921625576m, 6.269772816844689m },
                    { new Guid("23e54317-9e38-4747-96d4-46872a6f314b"), "Aston Martin Lagonda Ltd", 0, "Oracio", "Richie", 45.224688333074994, 19.83919841648629, null, 1.385540803473964m, 9.910185805400143m },
                    { new Guid("243a914d-e40a-4ec4-8987-006600853fda"), "Land Rover", 0, "Maurits", "Anurag", 45.253925064457675, 19.828862737626718, null, 1.7104501368390608m, 4.2596837052732415m },
                    { new Guid("24f153c2-79d0-45ec-999f-41892a379fa6"), "Lamborghini", 0, "Ilhan", "Reserved", 45.269939911723235, 19.805821814574692, null, 1.7714084180476508m, 8.149353140401365m },
                    { new Guid("251d05ec-b35b-4dc5-94fd-7c2a30dc79a3"), "Jeep", 0, "Iya", "Jhonatan", 45.276139257770936, 19.843919556371958, null, 1.6328898520108956m, 7.314957794295983m },
                    { new Guid("2854ebe6-20d2-47fb-8b21-60201d7cf83d"), "Roush", 0, "Rossane", "Jessica", 45.266559868005444, 19.829707954977223, null, 1.504112436608676m, 9.364469311550952m },
                    { new Guid("2bc128f4-792a-4901-a20b-b9a4cce71c88"), "LEXUS", 0, "Raina", "Lula", 45.223453054301878, 19.830829334577729, null, 1.0164590921625576m, 6.269772816844689m },
                    { new Guid("2bdc441f-11d2-4f7d-bc05-0e82e2e103e8"), "MASERATI", 0, "Vartan", "Rhee", 45.298049374458131, 19.878864637212104, null, 1.5393415373611448m, 6.559482220099541m },
                    { new Guid("2be6f0af-c785-48c9-a651-3839d62c98e6"), "Dodge", 0, "Andreas", "Adolfo", 45.265939837651047, 19.832946913832068, null, 1.7380170039298m, 8.510688070544214m },
                    { new Guid("2dd74447-4596-4a1b-b56d-4f3218d76f7c"), "MASERATI", 0, "Magali", "Vibeke", 45.21619104847931, 19.788370458607901, null, 1.6719496977709882m, 4.795675055141949m }
                });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Driver_ID", "Brand", "DriverStatus", "FirstName", "LastName", "Latitude", "Longitude", "PassengerId", "PricePerKM", "StartPrice" },
                values: new object[,]
                {
                    { new Guid("32b864f6-aba2-4889-b428-9a4d65fa5ad2"), "Audi", 0, "Carling", "Angeles", 45.256456267336631, 19.839344022449293, null, 1.2919937229218867m, 3.8797762168830876m },
                    { new Guid("34864dda-c0af-497e-b962-0bed45e9d35f"), "Lamborghini", 0, "Letizia", "Kerry", 45.281638953906281, 19.813600296747204, null, 1.099366625884517m, 1.3295397945411715m },
                    { new Guid("353987b1-fdec-40f8-8d62-a482ebaf0718"), "Aston Martin Lagonda Ltd", 0, "Leonard", "Emerald", 45.2572972194831, 19.855507893571811, null, 1.2124823508556823m, 10.14906639309747m },
                    { new Guid("39932776-0274-4624-a644-963b405ab22e"), "Jeep", 0, "Greening", "Brockie", 45.275815226573968, 19.811590339120048, null, 1.1547939566454073m, 4.416711302958615m },
                    { new Guid("3b377eed-e987-46b6-bfc0-ff8c90da271c"), "Lincoln", 0, "Geri", "Miii", 45.240326613759379, 19.856313447907667, null, 1.7338599905115184m, 10.732414512171566m },
                    { new Guid("3c1c5e98-3a6e-4e9a-88b4-3bbae3ba2330"), "Buick", 0, "Edie", "Maeve", 45.204068043710627, 19.850483415082969, null, 1.2435787993749734m, 1.5525301188205578m },
                    { new Guid("3d81822f-cff5-4fc1-819a-80e1619263b2"), "Bentley", 0, "Ann", "Canosa", 45.204344318934922, 19.835281956415212, null, 1.476499130995161m, 3.3429406521108387m },
                    { new Guid("3db31d78-21a0-4994-b0f7-7d02e9bc6d57"), "Lamborghini", 0, "Letizia", "Kerry", 45.281638953906281, 19.813600296747204, null, 1.099366625884517m, 1.3295397945411715m },
                    { new Guid("3f443c30-00be-4319-81f2-ffa07dd57efe"), "NISSAN", 0, "Rasika", "Raimundo", 45.291779211384224, 19.800023095935906, null, 1.0891868325268717m, 4.793560726767151m },
                    { new Guid("3f86e86c-8453-4042-94c3-0c78ed8aa047"), "MAZDA", 0, "Callaghan", "Aiden", 45.215384546791014, 19.846282477003452, null, 1.7442378744022409m, 4.395966844983313m },
                    { new Guid("40328d89-232e-415b-a7ef-7506ae6980ee"), "Lincoln", 0, "Gert", "Andres", 45.279225594403293, 19.790054798757847, null, 1.1643840016635394m, 1.328847558195744m },
                    { new Guid("4038404a-22ce-458e-aebf-afc839792418"), "Mitsubishi Motors Corporation", 0, "Yev", "Leeann", 45.243827207876294, 19.795146332823769, null, 1.4038353529833358m, 7.1267708754257715m },
                    { new Guid("4067947b-177d-45ec-a028-63744aae9dbd"), "SCION", 0, "Vanessa", "Moran", 45.243401442719865, 19.845486901252453, null, 1.766625245740726m, 1.5974547157697985m },
                    { new Guid("40d7f7a7-6aea-4ef2-9def-3aa3026a022e"), "MASERATI", 0, "Vartan", "Rhee", 45.298049374458131, 19.878864637212104, null, 1.5393415373611448m, 6.559482220099541m },
                    { new Guid("42b7d257-d1ef-496b-a3e3-88c13ac9fa5e"), "Dodge", 0, "Andreas", "Adolfo", 45.265939837651047, 19.832946913832068, null, 1.7380170039298m, 8.510688070544214m },
                    { new Guid("431d697a-1964-42dc-8939-e504d30eaa0f"), "Pagani Automobili S.p.A.", 0, "Jamison", "Ash", 45.278270343256636, 19.852105063006313, null, 1.3374700364494403m, 8.12755415792042m },
                    { new Guid("4427dbdc-8fd7-4942-a3ba-1113e064d5cd"), "Roush", 0, "Bernardino", "Danel", 45.262091751738382, 19.836733731194897, null, 1.685522127629019m, 5.239149409686604m },
                    { new Guid("4554d2f7-10bc-4a43-b24f-0435d0f93344"), "NISSAN", 0, "Rasika", "Raimundo", 45.291779211384224, 19.800023095935906, null, 1.0891868325268717m, 4.793560726767151m },
                    { new Guid("46198c96-31ec-4e11-b2cb-9767b50af9b5"), "Chevrolet", 0, "Trace", "Gerry", 45.290891491829363, 19.828444245832451, null, 1.6389965205075372m, 8.368466873577997m },
                    { new Guid("46d7785c-99c3-4752-94d3-3fdd5ef3f417"), "TOYOTA", 0, "Dang", "Erskine", 45.217855950352465, 19.834207010840032, null, 1.7497987535854724m, 4.824188848962091m },
                    { new Guid("470ce054-c0bb-480b-933a-36b3e3ecf4d4"), "Cadillac", 0, "Olga", "Kristen", 45.29340112834867, 19.822498825540769, null, 1.6875309773099558m, 6.45756305740285m },
                    { new Guid("471b1a58-085e-4a50-84ee-eb2282cdf0b6"), "Volvo", 0, "Emma", "Tasha", 45.285854370015166, 19.866548271059557, null, 1.0566431268333218m, 8.509215393598028m },
                    { new Guid("4a47dc11-47d6-4902-baa1-e278a932c585"), "RAM", 0, "Welch", "Vaishali", 45.226846241954064, 19.839414266674314, null, 1.3494145070278685m, 3.1034505930423064m },
                    { new Guid("4c04d6a1-a153-4425-9a41-12c9921482d8"), "Chrysler", 0, "Russell", "Rune", 45.223988703409404, 19.821203339044121, null, 1.669900944787707m, 7.442289794627493m },
                    { new Guid("4c3d822c-496d-44c1-abc1-82ee3e2f4b50"), "Lamborghini", 0, "Aparna", "Segundo", 45.225215199148884, 19.883468373193303, null, 1.2154110733189056m, 3.652480026698223m },
                    { new Guid("4cf6b208-e619-4103-a654-ed8c98501577"), "Acura", 0, "Anais", "Johnna", 45.287676498702332, 19.843019007354567, null, 1.1278655668254658m, 10.710397156830041m },
                    { new Guid("4f7973ac-0317-48e0-a2c3-c7f6df1adaeb"), "Volvo", 0, "Jessa", "Tetiana", 45.228208563610373, 19.864794930227959, null, 1.4501630881251706m, 4.989849053623997m },
                    { new Guid("50e86477-77d3-4af2-880c-b5b18202aae7"), "MASERATI", 0, "Magali", "Vibeke", 45.21619104847931, 19.788370458607901, null, 1.6719496977709882m, 4.795675055141949m },
                    { new Guid("5171ddb9-2992-4fe9-a1fc-729823f0586f"), "Volvo", 0, "Lluvia", "Judd", 45.244554013188768, 19.872895707350001, null, 1.253412375617725m, 5.882144460892146m },
                    { new Guid("517f43d9-5d11-4afa-8115-fee3a57ecfb2"), "Jeep", 0, "Greening", "Brockie", 45.275815226573968, 19.811590339120048, null, 1.1547939566454073m, 4.416711302958615m },
                    { new Guid("534cd425-5781-4696-a68f-32985b99ca62"), "Roush", 0, "Evangeline", "Granados", 45.255782205655841, 19.854106076392526, null, 1.7553795014338474m, 6.146249025698085m },
                    { new Guid("548fbdcb-ce26-4265-9d46-222156650daa"), "Mitsubishi Motors Corporation", 0, "Yev", "Leeann", 45.243827207876294, 19.795146332823769, null, 1.4038353529833358m, 7.1267708754257715m },
                    { new Guid("54da33e6-81d7-4bd3-9bef-b38f023767d7"), "Lamborghini", 0, "Aparna", "Segundo", 45.225215199148884, 19.883468373193303, null, 1.2154110733189056m, 3.652480026698223m },
                    { new Guid("55c43d7c-7b8f-4c15-a43d-9f88287f48b0"), "Bentley", 0, "Lupita", "Bennet", 45.280486776875811, 19.844408581896609, null, 1.1702439175398553m, 10.496768111188889m },
                    { new Guid("56df2ff0-4e8e-421f-bf5c-26b6e9b0601a"), "McLaren", 0, "Flora", "Allesdandro", 45.250220306572913, 19.80629652423562, null, 1.6560543096854814m, 9.747141997226342m },
                    { new Guid("575584cb-1697-4f68-a4a0-81c4f4599469"), "McLaren", 0, "Flora", "Allesdandro", 45.250220306572913, 19.80629652423562, null, 1.6560543096854814m, 9.747141997226342m },
                    { new Guid("59d87c1f-19b4-441e-b466-1791e61f36ea"), "GMC", 0, "Brehan", "Leonardo", 45.284932615672936, 19.861347707346106, null, 1.0165564995215457m, 10.543527811952874m },
                    { new Guid("5aa2a404-5a0f-45ed-83fd-8736b25f86b0"), "Volkswagen", 0, "Werner", "Inde", 45.221608244262498, 19.819591497862248, null, 1.3967480906659557m, 4.545871705956596m },
                    { new Guid("5adf484f-0e30-4018-a7c9-815934a98e28"), "Honda", 0, "Libbey", "Ernest", 45.282891901118944, 19.876434018077504, null, 1.2475192510221107m, 5.449373131830329m },
                    { new Guid("5e442831-c454-460f-9277-aab708ff1387"), "Mini", 0, "Rue", "Henrik", 45.234728393171295, 19.822851909980773, null, 1.1939296054078634m, 1.7459564675100006m },
                    { new Guid("5f80baf3-e44a-4056-9a20-e4c962430de6"), "Jeep", 0, "Jurg", "Colleen", 45.27947091909018, 19.803280137550804, null, 1.0642568736345543m, 1.1178482649382784m },
                    { new Guid("60ce85d8-b2e6-42f0-81ad-1dd4aae5eb1d"), "Jaguar", 0, "Dilini", "Joy", 45.204205166231176, 19.821658287825695, null, 1.5632855538691586m, 9.828321299882433m }
                });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Driver_ID", "Brand", "DriverStatus", "FirstName", "LastName", "Latitude", "Longitude", "PassengerId", "PricePerKM", "StartPrice" },
                values: new object[,]
                {
                    { new Guid("60eeae69-f9e1-4746-a5c3-655c6a2ab5eb"), "Subaru", 0, "Lombardet", "Casandra", 45.250568287681887, 19.824187873005126, null, 1.6563058877839092m, 10.512932624252946m },
                    { new Guid("6493b24a-779a-4853-a87f-2dfe0fbe6515"), "TOYOTA", 0, "Aden", "Eliza", 45.268648133812405, 19.831866095348715, null, 1.391490893102681m, 8.095125839709704m },
                    { new Guid("661f44fb-353a-40db-a9d4-31b77de042f2"), "TOYOTA", 0, "Henry", "Violoncella", 45.220604547812769, 19.860464073132178, null, 1.6549856762871982m, 8.414841851640341m },
                    { new Guid("66c4c437-0db5-438f-95b5-c08ce424d3db"), "Buick", 0, "Edie", "Maeve", 45.204068043710627, 19.850483415082969, null, 1.2435787993749734m, 1.5525301188205578m },
                    { new Guid("66c573e0-676d-43a5-ada2-455a899d1ab2"), "Porsche", 0, "Lily", "Eugenia", 45.257195153791159, 19.808529545036901, null, 1.7101176770777686m, 2.275882597440534m },
                    { new Guid("678103cb-1f5e-433b-9cbc-2cb99afb00a7"), "Roush", 0, "Evangeline", "Granados", 45.255782205655841, 19.854106076392526, null, 1.7553795014338474m, 6.146249025698085m },
                    { new Guid("69407854-62ab-4ec1-9f06-508a5fb32918"), "Volvo", 0, "Lluvia", "Judd", 45.244554013188768, 19.872895707350001, null, 1.253412375617725m, 5.882144460892146m },
                    { new Guid("6a23090a-c32f-423d-8e09-f18d12173335"), "Ford", 0, "Leif", "Nalini", 45.281617289392479, 19.841755384683445, null, 1.0236099738160866m, 2.7658329456040622m },
                    { new Guid("6c96cdb2-1a6c-4be9-b4ce-19336dcc1433"), "Bentley", 0, "Brandy", "Eleanor", 45.299538969878988, 19.880643245594662, null, 1.6281722977710191m, 5.728713211147051m },
                    { new Guid("6cc32323-d72b-437f-8c69-7e766d94af0e"), "ALFA ROMEO", 0, "Allison", "Royden", 45.295945743171906, 19.857674174593402, null, 1.5237046745427651m, 10.405094574404158m },
                    { new Guid("6d597bb4-b955-4427-b2bf-898a00332903"), "Subaru", 0, "Lombardet", "Casandra", 45.250568287681887, 19.824187873005126, null, 1.6563058877839092m, 10.512932624252946m },
                    { new Guid("6d960114-1de5-40ee-95d6-4a4993bf143b"), "Mini", 0, "Jerildy", "Tzipora", 45.26373409468961, 19.820524995264094, null, 1.6770837896990307m, 3.156359811608757m },
                    { new Guid("6dd924bf-24cd-4899-8ccd-2b9fe8aed2ac"), "Jeep", 0, "Iya", "Jhonatan", 45.276139257770936, 19.843919556371958, null, 1.6328898520108956m, 7.314957794295983m },
                    { new Guid("6fe5b1e2-c864-4c06-91da-d81fda86f2c8"), "CHEVROLET", 0, "Construccion", "Rossi", 45.287037867075718, 19.853352110430713, null, 1.1262567197952467m, 4.052167523478899m },
                    { new Guid("707d541a-eaca-4570-b5a1-856374d49dc4"), "Chevrolet", 0, "Trace", "Gerry", 45.290891491829363, 19.828444245832451, null, 1.6389965205075372m, 8.368466873577997m },
                    { new Guid("725324ce-3982-44a5-b3ea-b4c8846efc02"), "MAZDA", 0, "Rafal", "Monserrat", 45.282153330425473, 19.800982908909283, null, 1.0444604099295751m, 6.848472092200129m },
                    { new Guid("7320a62a-c9ff-403e-9066-2c6b8216e7f3"), "Honda", 0, "Talbot", "Carwen", 45.250169050776421, 19.794775524085665, null, 1.4473141471090796m, 4.881600711969098m },
                    { new Guid("7475ba57-6772-4abf-b2e9-e099d9a16bc2"), "Acura", 0, "Jasmine", "Dorothy", 45.209423511503424, 19.81749485016757, null, 1.3610869109414416m, 7.115251420780801m },
                    { new Guid("767ab78a-3595-4460-ab33-aa6bc1bad8b8"), "Volvo", 0, "Jessa", "Tetiana", 45.228208563610373, 19.864794930227959, null, 1.4501630881251706m, 4.989849053623997m },
                    { new Guid("770ecc28-26a0-4760-bf41-165d72879af0"), "Honda", 0, "Talbot", "Carwen", 45.250169050776421, 19.794775524085665, null, 1.4473141471090796m, 4.881600711969098m },
                    { new Guid("77179794-f6fa-4cbe-a28c-54c01873ca60"), "Chrysler", 0, "Ibrahim", "Alina", 45.2993118675817, 19.796265612687975, null, 1.1089619486674978m, 10.521486246480235m },
                    { new Guid("78624947-635f-49c8-8255-ac97290d4a1d"), "Mini", 0, "Larae", "Lindsey", 45.288988349342716, 19.869009669621189, null, 1.2705361960792216m, 3.7409616159613304m },
                    { new Guid("7b6caea7-8a41-4954-b1f6-0d52dccd1644"), "Chevrolet", 0, "Krizia", "Brusovanik", 45.267957633744437, 19.799666210958843, null, 1.6786208486121708m, 7.342233447742731m },
                    { new Guid("7d8d973f-9bde-4cda-b6df-c5e93b9ea956"), "Audi", 0, "Marc", "Erin", 45.262776103747605, 19.866401987510415, null, 1.0237952565130846m, 1.8608874905715336m },
                    { new Guid("8102f40c-0736-496a-bc61-649d298e5d43"), "INFINITI", 0, "Haas", "Chad", 45.288022877311491, 19.874835733268696, null, 1.5866952090365798m, 8.087357945507915m },
                    { new Guid("83f0c63a-14fe-446e-99b8-cc3c87c715a1"), "Lincoln", 0, "Geri", "Miii", 45.240326613759379, 19.856313447907667, null, 1.7338599905115184m, 10.732414512171566m },
                    { new Guid("862a759a-0e67-4b7b-9bea-0e23969ba4b6"), "Volvo", 0, "Emma", "Tasha", 45.285854370015166, 19.866548271059557, null, 1.0566431268333218m, 8.509215393598028m },
                    { new Guid("86dbb142-d8b3-465c-b7de-bfd6806beb1e"), "Rolls-Royce Motor Cars Limited", 0, "Henrik", "Edwin", 45.260099746320648, 19.846618295659582, null, 1.452835505779086m, 8.383483200020429m },
                    { new Guid("87b50dad-0f6b-48e7-b863-3e389cef9f12"), "TOYOTA", 0, "Henry", "Violoncella", 45.220604547812769, 19.860464073132178, null, 1.6549856762871982m, 8.414841851640341m },
                    { new Guid("87fe1f34-25b1-4040-a8a2-f7123519126c"), "Aston Martin Lagonda Ltd", 0, "Pauline", "Gunnar", 45.216454140074177, 19.848281178208055, null, 1.7036066928092553m, 4.427610056630678m },
                    { new Guid("88e0b5c9-c559-452a-bb6e-54979324b49e"), "Ford", 0, "Leif", "Nalini", 45.281617289392479, 19.841755384683445, null, 1.0236099738160866m, 2.7658329456040622m },
                    { new Guid("8ac123d5-0145-4b69-9dae-9c2bb5413a3d"), "Rolls-Royce Motor Cars Limited", 0, "Henrik", "Edwin", 45.260099746320648, 19.846618295659582, null, 1.452835505779086m, 8.383483200020429m },
                    { new Guid("8b6faa94-bc0c-40e4-ad0f-f4967de03e8f"), "Subaru", 0, "Luz", "Jacqui", 45.282357438284876, 19.870750281402625, null, 1.3275739312198804m, 7.389799555041893m },
                    { new Guid("8b87dd1b-237a-43fa-bc64-373233e67600"), "Cadillac", 0, "Olga", "Kristen", 45.29340112834867, 19.822498825540769, null, 1.6875309773099558m, 6.45756305740285m },
                    { new Guid("8c3599b6-fa48-4917-ba3c-8ad0317ae665"), "Land Rover", 0, "Maurits", "Anurag", 45.253925064457675, 19.828862737626718, null, 1.7104501368390608m, 4.2596837052732415m },
                    { new Guid("8c3b9eaa-d12b-4e5a-bc33-e31875a53d95"), "Bentley", 0, "Liliya", "Yeliz", 45.278508705345807, 19.806480944684065, null, 1.7553152421709535m, 4.360324081230656m },
                    { new Guid("8f2873f1-fa27-409a-a07e-c2015c0920c9"), "CHEVROLET", 0, "Edouard", "Jehan", 45.210031240196187, 19.819412677818654, null, 1.2289611665909137m, 10.316446613551822m },
                    { new Guid("91a73ac2-0b46-4a9b-ba7d-51c1d3e2487e"), "Mitsubishi Motors Corporation", 0, "Bechmann", "Maikol", 45.279071426502327, 19.862370160619843, null, 1.324328579217307m, 4.565442360558393m },
                    { new Guid("9222566e-9a44-46d5-b41b-b799b190e8b7"), "Dodge", 0, "Construccion", "Petty", 45.227061274337601, 19.836243969656948, null, 1.0452853161733882m, 3.69863700318812m },
                    { new Guid("979d94fe-3ee7-4820-9423-f2f8f70474f9"), "Mercedes-Benz", 0, "Osvando", "Nicolaios", 45.216763399661289, 19.839646217936401, null, 1.390698997245516m, 2.4629580725247315m },
                    { new Guid("997a4c65-83fa-44da-9744-5947da98f847"), "BMW", 0, "Alessandro", "Ame", 45.213878946434399, 19.83500906624565, null, 1.1394055188065981m, 10.629290075265152m },
                    { new Guid("9f087455-fc77-4d44-81d7-f57f547004e4"), "Volvo", 0, "Taryn", "Bener", 45.230507721803349, 19.8096740775133, null, 1.58709815212918m, 10.487772005185393m }
                });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Driver_ID", "Brand", "DriverStatus", "FirstName", "LastName", "Latitude", "Longitude", "PassengerId", "PricePerKM", "StartPrice" },
                values: new object[,]
                {
                    { new Guid("9f827d38-a05a-488d-a566-10655e02bc42"), "MAZDA", 0, "Megpg", "Eunice", 45.219490140494258, 19.798772403836473, null, 1.3455814143383005m, 9.776292871306692m },
                    { new Guid("a00db26a-188c-47d2-8416-6eda5220682e"), "Mercedes-Benz", 0, "Fernanda", "Berry", 45.284341031601357, 19.88214656986014, null, 1.228808543535298m, 2.642344591342897m },
                    { new Guid("a059cfd6-86da-4d39-87aa-07e0c6493900"), "Pagani Automobili S.p.A.", 0, "Jamison", "Ash", 45.278270343256636, 19.852105063006313, null, 1.3374700364494403m, 8.12755415792042m },
                    { new Guid("a06c03f3-7f5a-46ed-8f44-50aa66704cd6"), "INFINITI", 0, "Jastinder", "Homero", 45.269815899190036, 19.810080082882855, null, 1.5244558202271907m, 1.9469998885842523m },
                    { new Guid("a1ffde08-cef8-4cdb-9706-1103d15beb6c"), "MAZDA", 0, "Callaghan", "Aiden", 45.215384546791014, 19.846282477003452, null, 1.7442378744022409m, 4.395966844983313m },
                    { new Guid("a23d7550-7036-4db0-917d-8e065742c091"), "MAZDA", 0, "Megpg", "Eunice", 45.219490140494258, 19.798772403836473, null, 1.3455814143383005m, 9.776292871306692m },
                    { new Guid("a4f93a79-314d-4bcf-b1b4-dd66ea0312e7"), "Honda", 0, "Marin", "Jesus", 45.296192164092709, 19.814406778655229, null, 1.308227287026685m, 3.9326792288937376m },
                    { new Guid("a63c9b6a-da29-47dc-aad7-ced5a19e8a2d"), "MASERATI", 0, "Residencia", "Casper", 45.229981095425153, 19.837153864471194, null, 1.554999380283847m, 9.574431191837565m },
                    { new Guid("a69259f7-8714-481b-b4f3-31d69c5edd66"), "Land Rover", 0, "Oja", "Chin", 45.256914630896212, 19.858970871427317, null, 1.26487632045056m, 10.747802492089736m },
                    { new Guid("a732ad84-595a-4c23-a345-330ca3b12b08"), "BMW", 0, "Jacques", "Lane", 45.213790253612132, 19.79774102895696, null, 1.7987752163597301m, 4.055436177433148m },
                    { new Guid("a85b09e8-86b7-4571-be28-fc4ef9b452f8"), "Mitsubishi Motors Corporation", 0, "Bechmann", "Maikol", 45.279071426502327, 19.862370160619843, null, 1.324328579217307m, 4.565442360558393m },
                    { new Guid("a861656c-18d0-40fa-bcb2-33642de289e2"), "Honda", 0, "Marin", "Jesus", 45.296192164092709, 19.814406778655229, null, 1.308227287026685m, 3.9326792288937376m },
                    { new Guid("a95bc6b7-5ac1-4f6f-8e15-41c002542c84"), "Chevrolet", 0, "Jerome", "Hoj", 45.26187929944556, 19.852975472519034, null, 1.332259599316662m, 4.833445837024005m },
                    { new Guid("a981bc76-cb03-4e22-8a17-6a3f1efe73b1"), "Roush", 0, "Rossane", "Jessica", 45.266559868005444, 19.829707954977223, null, 1.504112436608676m, 9.364469311550952m },
                    { new Guid("aa62f4b1-0af3-434d-8856-ba31bce8bb6a"), "Audi", 0, "Beata", "Salome", 45.29945492843008, 19.844297003241515, null, 1.0417866558859206m, 1.2473101141077794m },
                    { new Guid("ab3da1a1-da5e-42ae-911c-a7c26e68861a"), "Mini", 0, "Dianna", "Michal", 45.247323100321054, 19.842409377101806, null, 1.0397465494006515m, 5.223227457896003m },
                    { new Guid("aca3439b-4f76-4e6d-8c95-89d370af10e2"), "Mercedes-Benz", 0, "Fernanda", "Berry", 45.284341031601357, 19.88214656986014, null, 1.228808543535298m, 2.642344591342897m },
                    { new Guid("ae332a89-bd5b-4037-a15a-a7ef4066f03e"), "Dodge", 0, "Construccion", "Petty", 45.227061274337601, 19.836243969656948, null, 1.0452853161733882m, 3.69863700318812m },
                    { new Guid("b31df2f7-89af-456d-80d6-a7399b8a778b"), "Roush", 0, "Iva", "Sloane", 45.218399244374908, 19.792091597548286, null, 1.6978977180498203m, 8.769920005723455m },
                    { new Guid("b6511769-998e-4071-b006-a8b4fdd05b19"), "Mini", 0, "Maurits", "Paulien", 45.296887928208001, 19.858852384808518, null, 1.7376903735062375m, 4.928084949383901m },
                    { new Guid("b69f8aa7-3da6-402c-aaad-db781dbb6779"), "Lincoln", 0, "Javid", "Tranta", 45.216149699839988, 19.853299911074188, null, 1.214353703785661m, 4.696927726796888m },
                    { new Guid("b892acbe-1bfc-4be1-8df4-e21dac91a7d0"), "Porsche", 0, "Lily", "Eugenia", 45.257195153791159, 19.808529545036901, null, 1.7101176770777686m, 2.275882597440534m },
                    { new Guid("b9ed40bc-adfa-4394-bd42-0ee95effea76"), "Bentley", 0, "Ann", "Canosa", 45.204344318934922, 19.835281956415212, null, 1.476499130995161m, 3.3429406521108387m },
                    { new Guid("bc27da2b-6737-42ae-87a7-5d16ddb14e43"), "Bentley", 0, "Lupita", "Bennet", 45.280486776875811, 19.844408581896609, null, 1.1702439175398553m, 10.496768111188889m },
                    { new Guid("bdf44d64-7a81-435c-8998-9943c50da1d5"), "Lincoln", 0, "Gert", "Andres", 45.279225594403293, 19.790054798757847, null, 1.1643840016635394m, 1.328847558195744m },
                    { new Guid("bf5132a8-bc53-4879-92e0-44bf81ab3948"), "RAM", 0, "Renata", "Yadi", 45.296758424609912, 19.847822587069356, null, 1.5933840239464465m, 3.1678197529395926m },
                    { new Guid("c0f0a64c-a12d-428b-9001-13e8685416b6"), "Ford", 0, "Cora", "Otra", 45.278586743787962, 19.802530466611248, null, 1.7253447233445418m, 10.91510684753183m },
                    { new Guid("c1d5d0e4-49fe-408e-85fb-cd79e7fd4f3e"), "Audi", 0, "Carling", "Angeles", 45.256456267336631, 19.839344022449293, null, 1.2919937229218867m, 3.8797762168830876m },
                    { new Guid("c2d180df-17d5-4147-85be-f948908119a7"), "Porsche", 0, "Vlada", "Marisela", 45.275549215170642, 19.878672958375621, null, 1.692150219149442m, 4.292175821808732m },
                    { new Guid("c40bd391-fccf-49e9-9479-c85957794e9a"), "Porsche", 0, "Vlada", "Marisela", 45.275549215170642, 19.878672958375621, null, 1.692150219149442m, 4.292175821808732m },
                    { new Guid("c6b0fbf9-5758-4302-90b1-6e7cf78fc66e"), "Chrysler", 0, "Ibrahim", "Alina", 45.2993118675817, 19.796265612687975, null, 1.1089619486674978m, 10.521486246480235m },
                    { new Guid("c727575d-bf77-4df0-8e9a-ebe666d95183"), "RAM", 0, "Welch", "Vaishali", 45.226846241954064, 19.839414266674314, null, 1.3494145070278685m, 3.1034505930423064m },
                    { new Guid("ca605851-56a7-4abd-8d63-50e9753df178"), "Aston Martin Lagonda Ltd", 0, "Leonard", "Emerald", 45.2572972194831, 19.855507893571811, null, 1.2124823508556823m, 10.14906639309747m },
                    { new Guid("caa96ab7-4d08-4166-b4d5-674b05a6877b"), "INFINITI", 0, "Bici", "Travis", 45.201686751190202, 19.802496053471067, null, 1.2016309984417113m, 10.491378188758173m },
                    { new Guid("cc42d942-2f6d-44e5-a3dd-6161fbcba2f0"), "Roush", 0, "Dahlia", "Pandora", 45.222647874969191, 19.786655808995068, null, 1.0651228912043087m, 7.807872207177916m },
                    { new Guid("cc663c85-7fc4-46e0-be84-b0be08e748ed"), "TOYOTA", 0, "Dang", "Erskine", 45.217855950352465, 19.834207010840032, null, 1.7497987535854724m, 4.824188848962091m },
                    { new Guid("ce280eb8-6329-4919-b70a-ab033726bc04"), "RAM", 0, "Renata", "Yadi", 45.296758424609912, 19.847822587069356, null, 1.5933840239464465m, 3.1678197529395926m },
                    { new Guid("d05c778c-0fbd-41cc-9453-077d27c5fa6b"), "Roush", 0, "Bernardino", "Danel", 45.262091751738382, 19.836733731194897, null, 1.685522127629019m, 5.239149409686604m },
                    { new Guid("d0919ec7-a367-4e8e-96a9-75a58215dc3d"), "BMW", 0, "Alessandro", "Ame", 45.213878946434399, 19.83500906624565, null, 1.1394055188065981m, 10.629290075265152m },
                    { new Guid("d2aeb253-235c-4ecf-b7c5-128d7c5b2ae3"), "INFINITI", 0, "Deepti", "Devara", 45.275913260410107, 19.85081695839504, null, 1.6342564595450453m, 10.57353943753355m },
                    { new Guid("d7dd738b-f287-49df-b7f9-c89ebde6fdf5"), "Mini", 0, "Rue", "Henrik", 45.234728393171295, 19.822851909980773, null, 1.1939296054078634m, 1.7459564675100006m },
                    { new Guid("d8c8ae25-46ce-44bd-b948-5f47fb0b2404"), "Volvo", 0, "Taryn", "Bener", 45.230507721803349, 19.8096740775133, null, 1.58709815212918m, 10.487772005185393m }
                });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Driver_ID", "Brand", "DriverStatus", "FirstName", "LastName", "Latitude", "Longitude", "PassengerId", "PricePerKM", "StartPrice" },
                values: new object[,]
                {
                    { new Guid("dbbe238f-8246-4e02-b5a9-bc9e5dc115e2"), "FIAT", 0, "Harold", "Karl", 45.286324628710155, 19.859015812248142, null, 1.7153672461915734m, 9.684974884213723m },
                    { new Guid("dc04f0ce-6b5f-48ac-8fd7-be3aeb3023ca"), "Roush", 0, "Dahlia", "Pandora", 45.222647874969191, 19.786655808995068, null, 1.0651228912043087m, 7.807872207177916m },
                    { new Guid("dd6132ab-9433-4c44-bc19-d75722d2e8ed"), "TOYOTA", 0, "Aden", "Eliza", 45.268648133812405, 19.831866095348715, null, 1.391490893102681m, 8.095125839709704m },
                    { new Guid("e06a41df-2984-4661-8e17-b3dc5cdee12a"), "Cadillac", 0, "Misael", "Gizelle", 45.260938791275308, 19.796892550971364, null, 1.0686156356587282m, 4.528765037827812m },
                    { new Guid("e0a75085-9842-41fe-b5d1-d09034dec5f5"), "Volkswagen", 0, "Werner", "Inde", 45.221608244262498, 19.819591497862248, null, 1.3967480906659557m, 4.545871705956596m },
                    { new Guid("e0ae0c3e-4a1a-4bee-a367-c3a514ecd99f"), "Aston Martin Lagonda Ltd", 0, "Pauline", "Gunnar", 45.216454140074177, 19.848281178208055, null, 1.7036066928092553m, 4.427610056630678m },
                    { new Guid("e0b24de3-deb9-4ae0-852a-0a3b6ff5176f"), "Honda", 0, "Libbey", "Ernest", 45.282891901118944, 19.876434018077504, null, 1.2475192510221107m, 5.449373131830329m },
                    { new Guid("e3f1cc7a-7a1b-41c9-86c2-d8fa2170d478"), "Acura", 0, "Anais", "Johnna", 45.287676498702332, 19.843019007354567, null, 1.1278655668254658m, 10.710397156830041m },
                    { new Guid("e4404b99-d319-49a6-aa0d-435bcadc1ed4"), "Volvo", 0, "Zena", "Kirstein", 45.238319779725494, 19.810359597732457, null, 1.7020772550670218m, 10.79799094974425m },
                    { new Guid("e53888c2-4926-48e3-afe8-87859f335b89"), "MAZDA", 0, "Rafal", "Monserrat", 45.282153330425473, 19.800982908909283, null, 1.0444604099295751m, 6.848472092200129m },
                    { new Guid("e57d77b3-f93c-4326-903c-f7d78ddb43d0"), "INFINITI", 0, "Jastinder", "Homero", 45.269815899190036, 19.810080082882855, null, 1.5244558202271907m, 1.9469998885842523m },
                    { new Guid("e6fc886c-1628-4e2d-ad28-3e6c8ee622dd"), "INFINITI", 0, "Haas", "Chad", 45.288022877311491, 19.874835733268696, null, 1.5866952090365798m, 8.087357945507915m },
                    { new Guid("e74c7c77-5a8f-498f-8d7c-4d7fdbe787f0"), "INFINITI", 0, "Bici", "Travis", 45.201686751190202, 19.802496053471067, null, 1.2016309984417113m, 10.491378188758173m },
                    { new Guid("e784cc76-1fc1-4919-beeb-cecc71ae7bec"), "Mini", 0, "Maurits", "Paulien", 45.296887928208001, 19.858852384808518, null, 1.7376903735062375m, 4.928084949383901m },
                    { new Guid("e7c32fa4-fec4-4995-aa4b-c72336f6a72b"), "Chevrolet", 0, "Jerome", "Hoj", 45.26187929944556, 19.852975472519034, null, 1.332259599316662m, 4.833445837024005m },
                    { new Guid("e7cbc951-2f3e-472b-b664-d653a98402fd"), "Porsche", 0, "Walker", "Maruk", 45.217759832566678, 19.812095479197652, null, 1.0201468787267918m, 8.987330756776993m },
                    { new Guid("eadc11ef-3aaf-4160-8ae2-5401d15c45de"), "Mercedes-Benz", 0, "Osvando", "Nicolaios", 45.216763399661289, 19.839646217936401, null, 1.390698997245516m, 2.4629580725247315m },
                    { new Guid("ed7df03a-a06d-4a36-95e2-39de7b1c2a65"), "Bentley", 0, "Brandy", "Eleanor", 45.299538969878988, 19.880643245594662, null, 1.6281722977710191m, 5.728713211147051m },
                    { new Guid("ee61b692-a531-47aa-80c0-ccbea47d4f53"), "Pagani Automobili S.p.A.", 0, "Morrissey", "Kellie", 45.274651670577768, 19.791858685850482, null, 1.3417230653533827m, 2.18234253206158m },
                    { new Guid("ef2b8cda-e294-44d2-89b1-f55932775706"), "Jaguar", 0, "Mannix", "Gisella", 45.296266247572717, 19.804770086487757, null, 1.6910908453429156m, 3.2823166597464395m },
                    { new Guid("f150061e-45de-49eb-bcfa-32921868f73b"), "Acura", 0, "Jasmine", "Dorothy", 45.209423511503424, 19.81749485016757, null, 1.3610869109414416m, 7.115251420780801m },
                    { new Guid("f15a44dd-6b48-4c64-af91-98f44671c71d"), "MASERATI", 0, "Residencia", "Casper", 45.229981095425153, 19.837153864471194, null, 1.554999380283847m, 9.574431191837565m },
                    { new Guid("f1e2bc24-1c6d-45de-ad46-c2f4111ddd4b"), "Mini", 0, "Jerildy", "Tzipora", 45.26373409468961, 19.820524995264094, null, 1.6770837896990307m, 3.156359811608757m },
                    { new Guid("f2101a2b-de77-43ad-8ada-91a22094f7d2"), "INFINITI", 0, "Deepti", "Devara", 45.275913260410107, 19.85081695839504, null, 1.6342564595450453m, 10.57353943753355m },
                    { new Guid("f23f2620-38e5-41a5-b57e-e93e8fcd8957"), "CHEVROLET", 0, "Edouard", "Jehan", 45.210031240196187, 19.819412677818654, null, 1.2289611665909137m, 10.316446613551822m },
                    { new Guid("f360dcf5-5612-450a-a277-f5736aaa4272"), "CHEVROLET", 0, "Construccion", "Rossi", 45.287037867075718, 19.853352110430713, null, 1.1262567197952467m, 4.052167523478899m },
                    { new Guid("f52de665-b996-44ca-a2f1-0bd95d3e00ba"), "FIAT", 0, "Harold", "Karl", 45.286324628710155, 19.859015812248142, null, 1.7153672461915734m, 9.684974884213723m },
                    { new Guid("f5881dd6-9653-4dfd-9467-a01138225eff"), "Mercedes-Benz", 0, "Marielle", "Orzai", 45.247779667723108, 19.842528794842231, null, 1.1929093189440756m, 4.356274892567532m },
                    { new Guid("f5fb6912-ccbd-4305-b216-8a4191765a78"), "Aston Martin Lagonda Ltd", 0, "Oracio", "Richie", 45.224688333074994, 19.83919841648629, null, 1.385540803473964m, 9.910185805400143m },
                    { new Guid("f6da5eba-e0f7-4d5b-858f-a9268ceb8fcf"), "Mercedes-Benz", 0, "Marielle", "Orzai", 45.247779667723108, 19.842528794842231, null, 1.1929093189440756m, 4.356274892567532m },
                    { new Guid("f75f040b-5689-4f2e-8070-fba72e64c1e6"), "Aston Martin Lagonda Ltd", 0, "Elliot", "Loiselin", 45.222723321894421, 19.793603471598757, null, 1.5879618679964944m, 2.4186214661952135m },
                    { new Guid("f8f18cc1-b6b9-4860-b9b9-fb1b6bd409aa"), "Lincoln", 0, "Delair", "Meredith", 45.252036208353331, 19.868004870058986, null, 1.6143386734417438m, 6.054391760371328m }
                });

            migrationBuilder.InsertData(
                table: "Passengers",
                columns: new[] { "PassengerId", "Birthday", "Email", "PassengerLastname", "PassengerName", "PassengersLatitude", "PassengersLongitude" },
                values: new object[,]
                {
                    { new Guid("074924b7-3e06-4a0c-9af2-fe9ec4c0915c"), new DateTime(1993, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "raca93@gmail.com", "Bjelic", "Radivoje", 45.290568287681893, 19.924187873005128 },
                    { new Guid("0c02c988-0752-4518-959a-f2cd350f560a"), new DateTime(1990, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "marko@example.com", "Petrovic", "Marko", 43.32090222876819, 21.895758973005126 },
                    { new Guid("4213f27b-e23b-4752-bc4c-087ee5726e7f"), new DateTime(1992, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "jelena@example.com", "Jankovic", "Jelena", 44.012793528768192, 20.91142273005126 },
                    { new Guid("57f765ee-3a8f-49ab-a375-6fc6300673ce"), new DateTime(1985, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "nikola@example.com", "Nikolic", "Nikola", 45.26713522876819, 19.833549673005127 },
                    { new Guid("d7d78755-9640-44db-ae12-579aebfdce44"), new DateTime(1994, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "marija@example.com", "Maric", "Marija", 44.01652128768189, 21.00585973005126 },
                    { new Guid("e8a6ce68-acf4-4fda-a04c-df098b75415d"), new DateTime(1987, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "ana@example.com", "Ivanovic", "Ana", 44.786568287681888, 20.448921673005128 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Rides_Ratings_PassengerRatingRatingId",
                table: "Rides",
                column: "PassengerRatingRatingId",
                principalTable: "Ratings",
                principalColumn: "RatingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rides_Ratings_PassengerRatingRatingId",
                table: "Rides");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ratings",
                table: "Ratings");

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("0066ec63-9628-4504-b8c7-652322e70b11"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("0258e3df-7fd7-4d88-b28d-dfe396649ce1"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("025afc0d-aa91-4dae-933e-0cd285a7a1dd"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("040bcb05-44dc-4d18-80ea-20faac78bf44"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("040e3720-ccdb-4ed2-bcc9-16e0d31d0683"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("0547e03b-7b0d-4bae-914e-8afc24e3ce91"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("05a1a237-3917-42a2-acad-ce429942aa26"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("06fd05ed-aee1-480f-8fe9-01344234bffc"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("0805ea1d-06c2-40e0-83a1-54a4e10c7034"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("0971d37b-b215-4db8-98f0-c4dd1fb765f5"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("0aab4918-859e-4147-8e73-8f8e6607f613"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("0b3eb4f1-b1c1-4e05-a333-b5b5c53d9907"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("0c49f275-2d8d-4779-af6e-42b34bdf4428"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("0ed7b80b-0046-46c4-adac-db88fc73eb9b"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("0f77fca6-5075-4b8e-b54d-9afaa48e62c6"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("0fc512d9-fc2b-413a-a2da-e9746776703e"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("12674d44-f35a-4e69-b5dd-073f94db79a3"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("14e4628c-592c-48b3-b16e-64ca70739a16"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("161a6b3a-765b-4251-8328-53fa489d7ca2"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("16693e8c-4567-49a7-956e-2421735b133e"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("18b185a4-e174-4974-8df0-93d2140ad910"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("1a16ace8-d9ef-4ac6-8084-650d0fa7c08b"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("1a713d0b-4672-47ee-baed-23b16b57885b"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("1afbb7ef-d60b-4996-9b5b-4229ec262f35"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("1bdd960f-71b3-4f70-a442-b39248159f4d"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("1c0568db-2c2d-4d4d-9c04-cbbecf5b9f7e"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("1c951d4a-0e3d-443f-9c88-9872280aa68b"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("1d927993-d41a-4004-8899-932a645c5abf"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("1db3d084-538f-4f31-8f2e-33145b573a0a"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("1fa23c06-bc6a-4721-9695-8521d5be177e"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("2159b23d-8c58-4392-9334-3aef5c6a83cb"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("232af038-5ad2-4322-b2f6-26b064e382bf"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("2333e0ee-bf35-46c5-95d1-e743af403f70"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("23e54317-9e38-4747-96d4-46872a6f314b"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("243a914d-e40a-4ec4-8987-006600853fda"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("24f153c2-79d0-45ec-999f-41892a379fa6"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("251d05ec-b35b-4dc5-94fd-7c2a30dc79a3"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("2854ebe6-20d2-47fb-8b21-60201d7cf83d"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("2bc128f4-792a-4901-a20b-b9a4cce71c88"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("2bdc441f-11d2-4f7d-bc05-0e82e2e103e8"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("2be6f0af-c785-48c9-a651-3839d62c98e6"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("2dd74447-4596-4a1b-b56d-4f3218d76f7c"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("32b864f6-aba2-4889-b428-9a4d65fa5ad2"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("34864dda-c0af-497e-b962-0bed45e9d35f"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("353987b1-fdec-40f8-8d62-a482ebaf0718"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("39932776-0274-4624-a644-963b405ab22e"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("3b377eed-e987-46b6-bfc0-ff8c90da271c"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("3c1c5e98-3a6e-4e9a-88b4-3bbae3ba2330"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("3d81822f-cff5-4fc1-819a-80e1619263b2"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("3db31d78-21a0-4994-b0f7-7d02e9bc6d57"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("3f443c30-00be-4319-81f2-ffa07dd57efe"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("3f86e86c-8453-4042-94c3-0c78ed8aa047"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("40328d89-232e-415b-a7ef-7506ae6980ee"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("4038404a-22ce-458e-aebf-afc839792418"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("4067947b-177d-45ec-a028-63744aae9dbd"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("40d7f7a7-6aea-4ef2-9def-3aa3026a022e"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("42b7d257-d1ef-496b-a3e3-88c13ac9fa5e"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("431d697a-1964-42dc-8939-e504d30eaa0f"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("4427dbdc-8fd7-4942-a3ba-1113e064d5cd"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("4554d2f7-10bc-4a43-b24f-0435d0f93344"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("46198c96-31ec-4e11-b2cb-9767b50af9b5"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("46d7785c-99c3-4752-94d3-3fdd5ef3f417"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("470ce054-c0bb-480b-933a-36b3e3ecf4d4"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("471b1a58-085e-4a50-84ee-eb2282cdf0b6"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("4a47dc11-47d6-4902-baa1-e278a932c585"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("4c04d6a1-a153-4425-9a41-12c9921482d8"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("4c3d822c-496d-44c1-abc1-82ee3e2f4b50"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("4cf6b208-e619-4103-a654-ed8c98501577"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("4f7973ac-0317-48e0-a2c3-c7f6df1adaeb"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("50e86477-77d3-4af2-880c-b5b18202aae7"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("5171ddb9-2992-4fe9-a1fc-729823f0586f"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("517f43d9-5d11-4afa-8115-fee3a57ecfb2"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("534cd425-5781-4696-a68f-32985b99ca62"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("548fbdcb-ce26-4265-9d46-222156650daa"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("54da33e6-81d7-4bd3-9bef-b38f023767d7"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("55c43d7c-7b8f-4c15-a43d-9f88287f48b0"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("56df2ff0-4e8e-421f-bf5c-26b6e9b0601a"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("575584cb-1697-4f68-a4a0-81c4f4599469"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("59d87c1f-19b4-441e-b466-1791e61f36ea"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("5aa2a404-5a0f-45ed-83fd-8736b25f86b0"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("5adf484f-0e30-4018-a7c9-815934a98e28"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("5e442831-c454-460f-9277-aab708ff1387"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("5f80baf3-e44a-4056-9a20-e4c962430de6"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("60ce85d8-b2e6-42f0-81ad-1dd4aae5eb1d"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("60eeae69-f9e1-4746-a5c3-655c6a2ab5eb"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("6493b24a-779a-4853-a87f-2dfe0fbe6515"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("661f44fb-353a-40db-a9d4-31b77de042f2"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("66c4c437-0db5-438f-95b5-c08ce424d3db"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("66c573e0-676d-43a5-ada2-455a899d1ab2"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("678103cb-1f5e-433b-9cbc-2cb99afb00a7"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("69407854-62ab-4ec1-9f06-508a5fb32918"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("6a23090a-c32f-423d-8e09-f18d12173335"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("6c96cdb2-1a6c-4be9-b4ce-19336dcc1433"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("6cc32323-d72b-437f-8c69-7e766d94af0e"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("6d597bb4-b955-4427-b2bf-898a00332903"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("6d960114-1de5-40ee-95d6-4a4993bf143b"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("6dd924bf-24cd-4899-8ccd-2b9fe8aed2ac"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("6fe5b1e2-c864-4c06-91da-d81fda86f2c8"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("707d541a-eaca-4570-b5a1-856374d49dc4"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("725324ce-3982-44a5-b3ea-b4c8846efc02"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("7320a62a-c9ff-403e-9066-2c6b8216e7f3"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("7475ba57-6772-4abf-b2e9-e099d9a16bc2"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("767ab78a-3595-4460-ab33-aa6bc1bad8b8"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("770ecc28-26a0-4760-bf41-165d72879af0"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("77179794-f6fa-4cbe-a28c-54c01873ca60"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("78624947-635f-49c8-8255-ac97290d4a1d"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("7b6caea7-8a41-4954-b1f6-0d52dccd1644"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("7d8d973f-9bde-4cda-b6df-c5e93b9ea956"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("8102f40c-0736-496a-bc61-649d298e5d43"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("83f0c63a-14fe-446e-99b8-cc3c87c715a1"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("862a759a-0e67-4b7b-9bea-0e23969ba4b6"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("86dbb142-d8b3-465c-b7de-bfd6806beb1e"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("87b50dad-0f6b-48e7-b863-3e389cef9f12"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("87fe1f34-25b1-4040-a8a2-f7123519126c"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("88e0b5c9-c559-452a-bb6e-54979324b49e"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("8ac123d5-0145-4b69-9dae-9c2bb5413a3d"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("8b6faa94-bc0c-40e4-ad0f-f4967de03e8f"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("8b87dd1b-237a-43fa-bc64-373233e67600"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("8c3599b6-fa48-4917-ba3c-8ad0317ae665"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("8c3b9eaa-d12b-4e5a-bc33-e31875a53d95"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("8f2873f1-fa27-409a-a07e-c2015c0920c9"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("91a73ac2-0b46-4a9b-ba7d-51c1d3e2487e"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("9222566e-9a44-46d5-b41b-b799b190e8b7"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("979d94fe-3ee7-4820-9423-f2f8f70474f9"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("997a4c65-83fa-44da-9744-5947da98f847"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("9f087455-fc77-4d44-81d7-f57f547004e4"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("9f827d38-a05a-488d-a566-10655e02bc42"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("a00db26a-188c-47d2-8416-6eda5220682e"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("a059cfd6-86da-4d39-87aa-07e0c6493900"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("a06c03f3-7f5a-46ed-8f44-50aa66704cd6"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("a1ffde08-cef8-4cdb-9706-1103d15beb6c"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("a23d7550-7036-4db0-917d-8e065742c091"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("a4f93a79-314d-4bcf-b1b4-dd66ea0312e7"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("a63c9b6a-da29-47dc-aad7-ced5a19e8a2d"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("a69259f7-8714-481b-b4f3-31d69c5edd66"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("a732ad84-595a-4c23-a345-330ca3b12b08"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("a85b09e8-86b7-4571-be28-fc4ef9b452f8"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("a861656c-18d0-40fa-bcb2-33642de289e2"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("a95bc6b7-5ac1-4f6f-8e15-41c002542c84"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("a981bc76-cb03-4e22-8a17-6a3f1efe73b1"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("aa62f4b1-0af3-434d-8856-ba31bce8bb6a"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("ab3da1a1-da5e-42ae-911c-a7c26e68861a"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("aca3439b-4f76-4e6d-8c95-89d370af10e2"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("ae332a89-bd5b-4037-a15a-a7ef4066f03e"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("b31df2f7-89af-456d-80d6-a7399b8a778b"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("b6511769-998e-4071-b006-a8b4fdd05b19"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("b69f8aa7-3da6-402c-aaad-db781dbb6779"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("b892acbe-1bfc-4be1-8df4-e21dac91a7d0"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("b9ed40bc-adfa-4394-bd42-0ee95effea76"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("bc27da2b-6737-42ae-87a7-5d16ddb14e43"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("bdf44d64-7a81-435c-8998-9943c50da1d5"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("bf5132a8-bc53-4879-92e0-44bf81ab3948"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("c0f0a64c-a12d-428b-9001-13e8685416b6"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("c1d5d0e4-49fe-408e-85fb-cd79e7fd4f3e"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("c2d180df-17d5-4147-85be-f948908119a7"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("c40bd391-fccf-49e9-9479-c85957794e9a"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("c6b0fbf9-5758-4302-90b1-6e7cf78fc66e"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("c727575d-bf77-4df0-8e9a-ebe666d95183"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("ca605851-56a7-4abd-8d63-50e9753df178"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("caa96ab7-4d08-4166-b4d5-674b05a6877b"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("cc42d942-2f6d-44e5-a3dd-6161fbcba2f0"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("cc663c85-7fc4-46e0-be84-b0be08e748ed"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("ce280eb8-6329-4919-b70a-ab033726bc04"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("d05c778c-0fbd-41cc-9453-077d27c5fa6b"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("d0919ec7-a367-4e8e-96a9-75a58215dc3d"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("d2aeb253-235c-4ecf-b7c5-128d7c5b2ae3"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("d7dd738b-f287-49df-b7f9-c89ebde6fdf5"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("d8c8ae25-46ce-44bd-b948-5f47fb0b2404"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("dbbe238f-8246-4e02-b5a9-bc9e5dc115e2"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("dc04f0ce-6b5f-48ac-8fd7-be3aeb3023ca"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("dd6132ab-9433-4c44-bc19-d75722d2e8ed"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("e06a41df-2984-4661-8e17-b3dc5cdee12a"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("e0a75085-9842-41fe-b5d1-d09034dec5f5"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("e0ae0c3e-4a1a-4bee-a367-c3a514ecd99f"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("e0b24de3-deb9-4ae0-852a-0a3b6ff5176f"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("e3f1cc7a-7a1b-41c9-86c2-d8fa2170d478"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("e4404b99-d319-49a6-aa0d-435bcadc1ed4"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("e53888c2-4926-48e3-afe8-87859f335b89"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("e57d77b3-f93c-4326-903c-f7d78ddb43d0"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("e6fc886c-1628-4e2d-ad28-3e6c8ee622dd"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("e74c7c77-5a8f-498f-8d7c-4d7fdbe787f0"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("e784cc76-1fc1-4919-beeb-cecc71ae7bec"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("e7c32fa4-fec4-4995-aa4b-c72336f6a72b"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("e7cbc951-2f3e-472b-b664-d653a98402fd"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("eadc11ef-3aaf-4160-8ae2-5401d15c45de"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("ed7df03a-a06d-4a36-95e2-39de7b1c2a65"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("ee61b692-a531-47aa-80c0-ccbea47d4f53"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("ef2b8cda-e294-44d2-89b1-f55932775706"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("f150061e-45de-49eb-bcfa-32921868f73b"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("f15a44dd-6b48-4c64-af91-98f44671c71d"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("f1e2bc24-1c6d-45de-ad46-c2f4111ddd4b"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("f2101a2b-de77-43ad-8ada-91a22094f7d2"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("f23f2620-38e5-41a5-b57e-e93e8fcd8957"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("f360dcf5-5612-450a-a277-f5736aaa4272"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("f52de665-b996-44ca-a2f1-0bd95d3e00ba"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("f5881dd6-9653-4dfd-9467-a01138225eff"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("f5fb6912-ccbd-4305-b216-8a4191765a78"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("f6da5eba-e0f7-4d5b-858f-a9268ceb8fcf"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("f75f040b-5689-4f2e-8070-fba72e64c1e6"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Driver_ID",
                keyValue: new Guid("f8f18cc1-b6b9-4860-b9b9-fb1b6bd409aa"));

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "PassengerId",
                keyValue: new Guid("074924b7-3e06-4a0c-9af2-fe9ec4c0915c"));

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "PassengerId",
                keyValue: new Guid("0c02c988-0752-4518-959a-f2cd350f560a"));

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "PassengerId",
                keyValue: new Guid("4213f27b-e23b-4752-bc4c-087ee5726e7f"));

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "PassengerId",
                keyValue: new Guid("57f765ee-3a8f-49ab-a375-6fc6300673ce"));

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "PassengerId",
                keyValue: new Guid("d7d78755-9640-44db-ae12-579aebfdce44"));

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "PassengerId",
                keyValue: new Guid("e8a6ce68-acf4-4fda-a04c-df098b75415d"));

            migrationBuilder.RenameTable(
                name: "Ratings",
                newName: "Rating");

            migrationBuilder.AlterColumn<string>(
                name: "PassengerName",
                table: "Passengers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "PassengerLastname",
                table: "Passengers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Brand",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Comment",
                table: "Rating",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rating",
                table: "Rating",
                column: "RatingId");

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Driver_ID", "Brand", "DriverStatus", "FirstName", "LastName", "Latitude", "Longitude", "PassengerId", "PricePerKM", "StartPrice" },
                values: new object[,]
                {
                    { new Guid("020de484-1ae1-4eec-9287-f6294da32718"), "TOYOTA", 0, "Dang", "Erskine", 45.217855950352465, 19.834207010840032, null, 1.7497987535854724m, 4.824188848962091m },
                    { new Guid("022ee03f-ea35-41e4-9906-8f3fa23a7591"), "Subaru", 0, "Lombardet", "Casandra", 45.250568287681887, 19.824187873005126, null, 1.6563058877839092m, 10.512932624252946m },
                    { new Guid("038cfdb2-dea0-48ae-a8f0-a12e8426f425"), "Pagani Automobili S.p.A.", 0, "Jamison", "Ash", 45.278270343256636, 19.852105063006313, null, 1.3374700364494403m, 8.12755415792042m },
                    { new Guid("04272bd8-b9b9-42bb-9265-745db2e54c79"), "MAZDA", 0, "Callaghan", "Aiden", 45.215384546791014, 19.846282477003452, null, 1.7442378744022409m, 4.395966844983313m },
                    { new Guid("092cb1f4-d4c4-45e9-8e82-fea8e4b0272a"), "INFINITI", 0, "Bici", "Travis", 45.201686751190202, 19.802496053471067, null, 1.2016309984417113m, 10.491378188758173m },
                    { new Guid("09d4e34c-fb70-4586-aad8-6b34b7606b0c"), "ALFA ROMEO", 0, "Allison", "Royden", 45.295945743171906, 19.857674174593402, null, 1.5237046745427651m, 10.405094574404158m },
                    { new Guid("0be4f955-06d5-49ee-9e9b-10ec9e8c1c4e"), "Lamborghini", 0, "Ilhan", "Reserved", 45.269939911723235, 19.805821814574692, null, 1.7714084180476508m, 8.149353140401365m },
                    { new Guid("0ca7b03e-b326-48a7-ad7b-b4de4701f362"), "Cadillac", 0, "Olga", "Kristen", 45.29340112834867, 19.822498825540769, null, 1.6875309773099558m, 6.45756305740285m },
                    { new Guid("0cabf5a6-f7cd-442a-896a-cae57ffcdb65"), "Jaguar", 0, "Dilini", "Joy", 45.204205166231176, 19.821658287825695, null, 1.5632855538691586m, 9.828321299882433m },
                    { new Guid("11befd47-32c8-433a-962f-754543de958d"), "Mercedes-Benz", 0, "Fernanda", "Berry", 45.284341031601357, 19.88214656986014, null, 1.228808543535298m, 2.642344591342897m },
                    { new Guid("13195401-75a8-4825-8145-1ed94f2c537c"), "Lincoln", 0, "Javid", "Tranta", 45.216149699839988, 19.853299911074188, null, 1.214353703785661m, 4.696927726796888m },
                    { new Guid("13c75b92-4854-4dca-b09a-8188c7fbb135"), "TOYOTA", 0, "Aden", "Eliza", 45.268648133812405, 19.831866095348715, null, 1.391490893102681m, 8.095125839709704m },
                    { new Guid("157e42c4-7b78-405c-b228-6e9c46479912"), "Pagani Automobili S.p.A.", 0, "Jamison", "Ash", 45.278270343256636, 19.852105063006313, null, 1.3374700364494403m, 8.12755415792042m },
                    { new Guid("15b131be-f967-437f-b710-bbb9f20fa658"), "Volvo", 0, "Jessa", "Tetiana", 45.228208563610373, 19.864794930227959, null, 1.4501630881251706m, 4.989849053623997m },
                    { new Guid("16def8c9-4c32-45ec-a236-70079d5eca61"), "Bentley", 0, "Lupita", "Bennet", 45.280486776875811, 19.844408581896609, null, 1.1702439175398553m, 10.496768111188889m },
                    { new Guid("18daedd2-cbe2-4b8e-959e-1a8de42e42ae"), "Mini", 0, "Jerildy", "Tzipora", 45.26373409468961, 19.820524995264094, null, 1.6770837896990307m, 3.156359811608757m },
                    { new Guid("1a4626b1-8acd-445f-845b-96da0777f2ee"), "INFINITI", 0, "Deepti", "Devara", 45.275913260410107, 19.85081695839504, null, 1.6342564595450453m, 10.57353943753355m },
                    { new Guid("1af79f7b-fae2-4697-a3e6-3907db1615a6"), "Roush", 0, "Evangeline", "Granados", 45.255782205655841, 19.854106076392526, null, 1.7553795014338474m, 6.146249025698085m },
                    { new Guid("1e55e414-b097-4c4b-9ea4-e328cb3c4d65"), "Audi", 0, "Beata", "Salome", 45.29945492843008, 19.844297003241515, null, 1.0417866558859206m, 1.2473101141077794m },
                    { new Guid("1f00978c-ed67-438a-a729-b45d7b254c5f"), "Cadillac", 0, "Misael", "Gizelle", 45.260938791275308, 19.796892550971364, null, 1.0686156356587282m, 4.528765037827812m },
                    { new Guid("203fba9c-c106-4f3f-97f6-6130eef4c0aa"), "Aston Martin Lagonda Ltd", 0, "Knox", "Lorrie", 45.264656353292338, 19.837986673820598, null, 1.536456046701279m, 4.863201684677997m },
                    { new Guid("2107be5f-18d7-4e24-9bcb-f346b2060f7c"), "Chevrolet", 0, "Trace", "Gerry", 45.290891491829363, 19.828444245832451, null, 1.6389965205075372m, 8.368466873577997m },
                    { new Guid("21b022df-fe57-44be-8151-5988a2721e02"), "MAZDA", 0, "Megpg", "Eunice", 45.219490140494258, 19.798772403836473, null, 1.3455814143383005m, 9.776292871306692m },
                    { new Guid("267ea390-c9f0-4969-9ef3-4bcdfa803676"), "Chevrolet", 0, "Trace", "Gerry", 45.290891491829363, 19.828444245832451, null, 1.6389965205075372m, 8.368466873577997m },
                    { new Guid("268a7bca-f213-461b-9993-edaffd4e3b73"), "Mini", 0, "Dianna", "Michal", 45.247323100321054, 19.842409377101806, null, 1.0397465494006515m, 5.223227457896003m },
                    { new Guid("298a6277-0919-474d-b624-c53130a5a997"), "Subaru", 0, "Lombardet", "Casandra", 45.250568287681887, 19.824187873005126, null, 1.6563058877839092m, 10.512932624252946m },
                    { new Guid("2a399653-4051-42a4-be1d-2f2de7827cec"), "SCION", 0, "Vanessa", "Moran", 45.243401442719865, 19.845486901252453, null, 1.766625245740726m, 1.5974547157697985m },
                    { new Guid("2be9326e-7bb0-41bd-af84-a3f26f795ad5"), "Porsche", 0, "Walker", "Maruk", 45.217759832566678, 19.812095479197652, null, 1.0201468787267918m, 8.987330756776993m },
                    { new Guid("2c6d74f4-9de7-405c-aa64-ce824adbc9e0"), "Audi", 0, "Beata", "Salome", 45.29945492843008, 19.844297003241515, null, 1.0417866558859206m, 1.2473101141077794m },
                    { new Guid("2e0faf59-e076-41c7-a6b3-7b1f450939af"), "Ford", 0, "Leif", "Nalini", 45.281617289392479, 19.841755384683445, null, 1.0236099738160866m, 2.7658329456040622m },
                    { new Guid("2f42015e-9846-491d-9cc7-13720ab6a3a4"), "CHEVROLET", 0, "Edouard", "Jehan", 45.210031240196187, 19.819412677818654, null, 1.2289611665909137m, 10.316446613551822m },
                    { new Guid("31af3617-c44e-4c3c-9cf4-8fa859cb832a"), "Aston Martin Lagonda Ltd", 0, "Oracio", "Richie", 45.224688333074994, 19.83919841648629, null, 1.385540803473964m, 9.910185805400143m },
                    { new Guid("32853743-ff3d-4c8f-b74e-ba03d16fe22a"), "MASERATI", 0, "Vartan", "Rhee", 45.298049374458131, 19.878864637212104, null, 1.5393415373611448m, 6.559482220099541m },
                    { new Guid("32b5f6d1-4cbe-49b7-89b4-b26ceca7b7c0"), "Volvo", 0, "Taryn", "Bener", 45.230507721803349, 19.8096740775133, null, 1.58709815212918m, 10.487772005185393m },
                    { new Guid("32e6b1f9-3d03-4f39-86df-50992263a5fc"), "Aston Martin Lagonda Ltd", 0, "Oracio", "Richie", 45.224688333074994, 19.83919841648629, null, 1.385540803473964m, 9.910185805400143m },
                    { new Guid("349b803e-9718-40c3-9619-ccc9b4670b81"), "Buick", 0, "Edie", "Maeve", 45.204068043710627, 19.850483415082969, null, 1.2435787993749734m, 1.5525301188205578m },
                    { new Guid("34c46dc3-2cf4-4de9-806f-04a03e5b6ac0"), "Mitsubishi Motors Corporation", 0, "Bechmann", "Maikol", 45.279071426502327, 19.862370160619843, null, 1.324328579217307m, 4.565442360558393m },
                    { new Guid("35618346-491d-4c51-943d-be1f0b05062f"), "Chrysler", 0, "Russell", "Rune", 45.223988703409404, 19.821203339044121, null, 1.669900944787707m, 7.442289794627493m },
                    { new Guid("3827bbb5-6cfd-4dee-b053-4154834c02e5"), "INFINITI", 0, "Jastinder", "Homero", 45.269815899190036, 19.810080082882855, null, 1.5244558202271907m, 1.9469998885842523m },
                    { new Guid("38af677e-9c29-4532-bacb-6d78a57e478f"), "Aston Martin Lagonda Ltd", 0, "Pauline", "Gunnar", 45.216454140074177, 19.848281178208055, null, 1.7036066928092553m, 4.427610056630678m },
                    { new Guid("39f4252d-7a97-442d-ba04-cab30d27d809"), "Jaguar", 0, "Mannix", "Gisella", 45.296266247572717, 19.804770086487757, null, 1.6910908453429156m, 3.2823166597464395m },
                    { new Guid("3c41329b-af7a-4c53-ae15-1e5e6320dbdc"), "Roush", 0, "Iva", "Sloane", 45.218399244374908, 19.792091597548286, null, 1.6978977180498203m, 8.769920005723455m }
                });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Driver_ID", "Brand", "DriverStatus", "FirstName", "LastName", "Latitude", "Longitude", "PassengerId", "PricePerKM", "StartPrice" },
                values: new object[,]
                {
                    { new Guid("3f25423b-61c0-456f-b9c4-b208edb563c8"), "Jeep", 0, "Greening", "Brockie", 45.275815226573968, 19.811590339120048, null, 1.1547939566454073m, 4.416711302958615m },
                    { new Guid("3f5e72a8-7809-4e90-a874-aa1b0087a3d4"), "CHEVROLET", 0, "Construccion", "Rossi", 45.287037867075718, 19.853352110430713, null, 1.1262567197952467m, 4.052167523478899m },
                    { new Guid("40e5532f-83d6-41c9-81f9-8927e8d941ad"), "Honda", 0, "Libbey", "Ernest", 45.282891901118944, 19.876434018077504, null, 1.2475192510221107m, 5.449373131830329m },
                    { new Guid("410b56fd-a434-482a-b803-f1b745007293"), "Land Rover", 0, "Maurits", "Anurag", 45.253925064457675, 19.828862737626718, null, 1.7104501368390608m, 4.2596837052732415m },
                    { new Guid("42a6430f-08a3-436c-8fb4-173b72475981"), "Lincoln", 0, "Delair", "Meredith", 45.252036208353331, 19.868004870058986, null, 1.6143386734417438m, 6.054391760371328m },
                    { new Guid("43534da5-70e3-4a66-b34b-f99f76c11da3"), "Ford", 0, "Cora", "Otra", 45.278586743787962, 19.802530466611248, null, 1.7253447233445418m, 10.91510684753183m },
                    { new Guid("4bd6675f-89b9-4992-841c-68389d6f0e00"), "Mini", 0, "Maurits", "Paulien", 45.296887928208001, 19.858852384808518, null, 1.7376903735062375m, 4.928084949383901m },
                    { new Guid("4d154d85-14b5-45fa-915d-fad8c18d3f03"), "Volvo", 0, "Lluvia", "Judd", 45.244554013188768, 19.872895707350001, null, 1.253412375617725m, 5.882144460892146m },
                    { new Guid("4dfbfca4-11d4-408f-973d-fae7bd5fe4bc"), "Mini", 0, "Maurits", "Paulien", 45.296887928208001, 19.858852384808518, null, 1.7376903735062375m, 4.928084949383901m },
                    { new Guid("4e51818c-5a76-46f1-8fca-c9cdfddb0710"), "Jaguar", 0, "Dilini", "Joy", 45.204205166231176, 19.821658287825695, null, 1.5632855538691586m, 9.828321299882433m },
                    { new Guid("4f2a2a9f-0645-4d66-8ce6-0d4ae581ab0e"), "Mini", 0, "Larae", "Lindsey", 45.288988349342716, 19.869009669621189, null, 1.2705361960792216m, 3.7409616159613304m },
                    { new Guid("504e8ed9-fc07-4f93-b1f0-7d64adbf9d24"), "Mini", 0, "Rue", "Henrik", 45.234728393171295, 19.822851909980773, null, 1.1939296054078634m, 1.7459564675100006m },
                    { new Guid("50e5c4e7-066b-4a67-b045-8aee58336e18"), "LEXUS", 0, "Raina", "Lula", 45.223453054301878, 19.830829334577729, null, 1.0164590921625576m, 6.269772816844689m },
                    { new Guid("518e4e6f-c4d7-4735-87c2-b783ac9ce8f9"), "Porsche", 0, "Walker", "Maruk", 45.217759832566678, 19.812095479197652, null, 1.0201468787267918m, 8.987330756776993m },
                    { new Guid("5500e850-703c-47e1-b105-c1b680ed1e49"), "MAZDA", 0, "Callaghan", "Aiden", 45.215384546791014, 19.846282477003452, null, 1.7442378744022409m, 4.395966844983313m },
                    { new Guid("55526ce3-9d88-48f4-9d6d-28161daa1f8b"), "Porsche", 0, "Chrissy", "Tanyia", 45.279449168518042, 19.785822522191463, null, 1.4492458808602435m, 2.028265801352166m },
                    { new Guid("561c8e66-fa80-458a-a4e2-aa9b50212024"), "Chevrolet", 0, "Jerome", "Hoj", 45.26187929944556, 19.852975472519034, null, 1.332259599316662m, 4.833445837024005m },
                    { new Guid("56df2523-b098-4d52-9fec-13c23d810d15"), "Volvo", 0, "Emma", "Tasha", 45.285854370015166, 19.866548271059557, null, 1.0566431268333218m, 8.509215393598028m },
                    { new Guid("57b409cf-8a21-4bd1-ac8b-a3c5c9021ec0"), "Roush", 0, "Rossane", "Jessica", 45.266559868005444, 19.829707954977223, null, 1.504112436608676m, 9.364469311550952m },
                    { new Guid("57f60b33-4fc9-4828-98fd-2f57fe68840a"), "Bentley", 0, "Brandy", "Eleanor", 45.299538969878988, 19.880643245594662, null, 1.6281722977710191m, 5.728713211147051m },
                    { new Guid("59cba95c-771a-4337-9403-7898516a343b"), "McLaren", 0, "Flora", "Allesdandro", 45.250220306572913, 19.80629652423562, null, 1.6560543096854814m, 9.747141997226342m },
                    { new Guid("5a08cd45-1efb-4e22-9eed-f2c335e6fa85"), "GMC", 0, "Brehan", "Leonardo", 45.284932615672936, 19.861347707346106, null, 1.0165564995215457m, 10.543527811952874m },
                    { new Guid("5b2eecbb-1eec-40c9-b63e-456382acff1a"), "Roush", 0, "Bernardino", "Danel", 45.262091751738382, 19.836733731194897, null, 1.685522127629019m, 5.239149409686604m },
                    { new Guid("5b485ee0-227a-46be-823a-52da9a90516c"), "Chevrolet", 0, "Jerome", "Hoj", 45.26187929944556, 19.852975472519034, null, 1.332259599316662m, 4.833445837024005m },
                    { new Guid("5cb6b713-ca74-4ffd-b806-ed7917127b85"), "Lincoln", 0, "Gert", "Andres", 45.279225594403293, 19.790054798757847, null, 1.1643840016635394m, 1.328847558195744m },
                    { new Guid("5d20c3eb-e644-4bb4-9e66-320ae317caa7"), "RAM", 0, "Renata", "Yadi", 45.296758424609912, 19.847822587069356, null, 1.5933840239464465m, 3.1678197529395926m },
                    { new Guid("5fd2366b-2b67-48fb-a66f-37a2dcf74c4c"), "Rolls-Royce Motor Cars Limited", 0, "Henrik", "Edwin", 45.260099746320648, 19.846618295659582, null, 1.452835505779086m, 8.383483200020429m },
                    { new Guid("6027db2a-6921-4515-ad9e-7ffd3e0e190b"), "Acura", 0, "Anais", "Johnna", 45.287676498702332, 19.843019007354567, null, 1.1278655668254658m, 10.710397156830041m },
                    { new Guid("605c618e-754a-48a4-98a6-f63bc16aab50"), "Lincoln", 0, "Geri", "Miii", 45.240326613759379, 19.856313447907667, null, 1.7338599905115184m, 10.732414512171566m },
                    { new Guid("61131876-f78f-453e-bcd2-e090c181c81e"), "RAM", 0, "Renata", "Yadi", 45.296758424609912, 19.847822587069356, null, 1.5933840239464465m, 3.1678197529395926m },
                    { new Guid("63e2d6a4-43cb-47f8-bdfe-e5b01abcb2c4"), "Bentley", 0, "Ann", "Canosa", 45.204344318934922, 19.835281956415212, null, 1.476499130995161m, 3.3429406521108387m },
                    { new Guid("640e1016-17be-4283-b159-1eac44e14b62"), "GMC", 0, "Brehan", "Leonardo", 45.284932615672936, 19.861347707346106, null, 1.0165564995215457m, 10.543527811952874m },
                    { new Guid("66aa5277-0f16-4665-9a28-6006ca71ce5c"), "Lamborghini", 0, "Ilhan", "Reserved", 45.269939911723235, 19.805821814574692, null, 1.7714084180476508m, 8.149353140401365m },
                    { new Guid("67f7d525-8b61-4b14-8df8-e8eba2f2ebfc"), "LEXUS", 0, "Raina", "Lula", 45.223453054301878, 19.830829334577729, null, 1.0164590921625576m, 6.269772816844689m },
                    { new Guid("68675f0b-fb93-46ce-aa61-40fdffb952f8"), "Mercedes-Benz", 0, "Marielle", "Orzai", 45.247779667723108, 19.842528794842231, null, 1.1929093189440756m, 4.356274892567532m },
                    { new Guid("6975e463-d56d-4178-b03b-12eaf17994e9"), "Aston Martin Lagonda Ltd", 0, "Pauline", "Gunnar", 45.216454140074177, 19.848281178208055, null, 1.7036066928092553m, 4.427610056630678m },
                    { new Guid("6d609ecc-b0f7-4f88-b00a-32539f5bb021"), "Bentley", 0, "Ann", "Canosa", 45.204344318934922, 19.835281956415212, null, 1.476499130995161m, 3.3429406521108387m },
                    { new Guid("6e6078df-cefb-4c81-9145-5375d669fc7d"), "MAZDA", 0, "Rafal", "Monserrat", 45.282153330425473, 19.800982908909283, null, 1.0444604099295751m, 6.848472092200129m },
                    { new Guid("6ee1331c-462c-4986-935b-f0a8e7041c4b"), "MAZDA", 0, "Rafal", "Monserrat", 45.282153330425473, 19.800982908909283, null, 1.0444604099295751m, 6.848472092200129m },
                    { new Guid("6f08cea2-4f44-4380-a770-7013ed304f68"), "Dodge", 0, "Construccion", "Petty", 45.227061274337601, 19.836243969656948, null, 1.0452853161733882m, 3.69863700318812m },
                    { new Guid("6f16f067-29ef-42be-9a32-425afabbf674"), "Volkswagen", 0, "Werner", "Inde", 45.221608244262498, 19.819591497862248, null, 1.3967480906659557m, 4.545871705956596m },
                    { new Guid("70a98fd7-34dd-4ef5-a69b-3dffca622600"), "Roush", 0, "Dahlia", "Pandora", 45.222647874969191, 19.786655808995068, null, 1.0651228912043087m, 7.807872207177916m }
                });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Driver_ID", "Brand", "DriverStatus", "FirstName", "LastName", "Latitude", "Longitude", "PassengerId", "PricePerKM", "StartPrice" },
                values: new object[,]
                {
                    { new Guid("71a830bd-b0a8-4303-94dd-60778ed66b63"), "MAZDA", 0, "Megpg", "Eunice", 45.219490140494258, 19.798772403836473, null, 1.3455814143383005m, 9.776292871306692m },
                    { new Guid("71dadfe6-3b0a-4639-aa12-efb7b39581f4"), "Porsche", 0, "Lily", "Eugenia", 45.257195153791159, 19.808529545036901, null, 1.7101176770777686m, 2.275882597440534m },
                    { new Guid("734a20f6-161b-469f-88c6-65e09e5ebeca"), "Jeep", 0, "Jurg", "Colleen", 45.27947091909018, 19.803280137550804, null, 1.0642568736345543m, 1.1178482649382784m },
                    { new Guid("74a62213-9628-42d4-96a0-1766d2ae2bfc"), "Chevrolet", 0, "Krizia", "Brusovanik", 45.267957633744437, 19.799666210958843, null, 1.6786208486121708m, 7.342233447742731m },
                    { new Guid("750bff57-29e3-457d-8cc1-a8c09c8f04d8"), "MASERATI", 0, "Magali", "Vibeke", 45.21619104847931, 19.788370458607901, null, 1.6719496977709882m, 4.795675055141949m },
                    { new Guid("75b76349-292f-4d9a-aebd-ca293d6b6b53"), "Chrysler", 0, "Russell", "Rune", 45.223988703409404, 19.821203339044121, null, 1.669900944787707m, 7.442289794627493m },
                    { new Guid("763b3c4e-f0ff-40eb-a048-c1aa604ace9c"), "Jeep", 0, "Greening", "Brockie", 45.275815226573968, 19.811590339120048, null, 1.1547939566454073m, 4.416711302958615m },
                    { new Guid("76b38482-b60a-4e1b-9eee-7017564297a2"), "Honda", 0, "Talbot", "Carwen", 45.250169050776421, 19.794775524085665, null, 1.4473141471090796m, 4.881600711969098m },
                    { new Guid("7727980a-98d3-476b-b981-a29b7e2adb73"), "INFINITI", 0, "Haas", "Chad", 45.288022877311491, 19.874835733268696, null, 1.5866952090365798m, 8.087357945507915m },
                    { new Guid("779d55f6-24cb-4306-9a76-a8e2855fdc9c"), "Bentley", 0, "Liliya", "Yeliz", 45.278508705345807, 19.806480944684065, null, 1.7553152421709535m, 4.360324081230656m },
                    { new Guid("8088811f-21d9-4587-9eb9-9ee260982cc8"), "Volvo", 0, "Lluvia", "Judd", 45.244554013188768, 19.872895707350001, null, 1.253412375617725m, 5.882144460892146m },
                    { new Guid("8182c746-6cb6-4a19-866d-4c4a8ffee485"), "Audi", 0, "Marc", "Erin", 45.262776103747605, 19.866401987510415, null, 1.0237952565130846m, 1.8608874905715336m },
                    { new Guid("81d42277-ed87-4888-847e-2870d412154d"), "Lincoln", 0, "Gert", "Andres", 45.279225594403293, 19.790054798757847, null, 1.1643840016635394m, 1.328847558195744m },
                    { new Guid("81deb4e5-9c68-4134-abc9-3b0db878d6c4"), "INFINITI", 0, "Bici", "Travis", 45.201686751190202, 19.802496053471067, null, 1.2016309984417113m, 10.491378188758173m },
                    { new Guid("81e03b22-e214-4ce8-8b5a-3c8a973f2768"), "MASERATI", 0, "Residencia", "Casper", 45.229981095425153, 19.837153864471194, null, 1.554999380283847m, 9.574431191837565m },
                    { new Guid("832d12ac-4183-4d5e-b870-bbe08e8591c3"), "Aston Martin Lagonda Ltd", 0, "Elliot", "Loiselin", 45.222723321894421, 19.793603471598757, null, 1.5879618679964944m, 2.4186214661952135m },
                    { new Guid("842c1ca6-0f91-4136-941b-2aaa1c2b355d"), "Cadillac", 0, "Misael", "Gizelle", 45.260938791275308, 19.796892550971364, null, 1.0686156356587282m, 4.528765037827812m },
                    { new Guid("8531fade-03e5-4c7e-8c77-ef4e7ec168f3"), "Honda", 0, "Marin", "Jesus", 45.296192164092709, 19.814406778655229, null, 1.308227287026685m, 3.9326792288937376m },
                    { new Guid("869fc6ff-34f1-420c-97ca-8660c89a7db2"), "CHEVROLET", 0, "Edouard", "Jehan", 45.210031240196187, 19.819412677818654, null, 1.2289611665909137m, 10.316446613551822m },
                    { new Guid("8a73869b-e68e-40c8-aff5-82850caac111"), "Audi", 0, "Marc", "Erin", 45.262776103747605, 19.866401987510415, null, 1.0237952565130846m, 1.8608874905715336m },
                    { new Guid("8e6a101d-57ef-457d-b4c5-c54f699a5f5c"), "Lamborghini", 0, "Aparna", "Segundo", 45.225215199148884, 19.883468373193303, null, 1.2154110733189056m, 3.652480026698223m },
                    { new Guid("8e89102c-a16a-40ad-b814-9274433f9907"), "Chrysler", 0, "Ibrahim", "Alina", 45.2993118675817, 19.796265612687975, null, 1.1089619486674978m, 10.521486246480235m },
                    { new Guid("8feef69a-689a-4d56-9e22-ba6c47ce1a31"), "TOYOTA", 0, "Henry", "Violoncella", 45.220604547812769, 19.860464073132178, null, 1.6549856762871982m, 8.414841851640341m },
                    { new Guid("90333bae-053b-4c53-b23b-8f136574bd85"), "Aston Martin Lagonda Ltd", 0, "Leonard", "Emerald", 45.2572972194831, 19.855507893571811, null, 1.2124823508556823m, 10.14906639309747m },
                    { new Guid("920c915e-654d-4d96-8dac-54520cdcd0ba"), "Honda", 0, "Marin", "Jesus", 45.296192164092709, 19.814406778655229, null, 1.308227287026685m, 3.9326792288937376m },
                    { new Guid("95d52176-402a-4e99-9df8-ac5294a4b12e"), "Bentley", 0, "Liliya", "Yeliz", 45.278508705345807, 19.806480944684065, null, 1.7553152421709535m, 4.360324081230656m },
                    { new Guid("9876cd6f-9376-4006-9344-1e1cfa221aee"), "NISSAN", 0, "Rasika", "Raimundo", 45.291779211384224, 19.800023095935906, null, 1.0891868325268717m, 4.793560726767151m },
                    { new Guid("9c4e2499-8720-4fdb-85e1-e4efd9ff5486"), "CHEVROLET", 0, "Construccion", "Rossi", 45.287037867075718, 19.853352110430713, null, 1.1262567197952467m, 4.052167523478899m },
                    { new Guid("9c6405ea-666f-444d-a01c-8cc95b13442d"), "Honda", 0, "Talbot", "Carwen", 45.250169050776421, 19.794775524085665, null, 1.4473141471090796m, 4.881600711969098m },
                    { new Guid("9d307f11-3951-4215-b68a-d547d83877be"), "Ford", 0, "Leif", "Nalini", 45.281617289392479, 19.841755384683445, null, 1.0236099738160866m, 2.7658329456040622m },
                    { new Guid("9d3b5e31-c787-41ea-a145-d2675839d3f8"), "BMW", 0, "Jacques", "Lane", 45.213790253612132, 19.79774102895696, null, 1.7987752163597301m, 4.055436177433148m },
                    { new Guid("9d52021b-e650-4780-a581-8e3528c4960f"), "Volvo", 0, "Jessa", "Tetiana", 45.228208563610373, 19.864794930227959, null, 1.4501630881251706m, 4.989849053623997m },
                    { new Guid("9dcb0194-cb97-4d6a-9cab-f5e367670087"), "MASERATI", 0, "Magali", "Vibeke", 45.21619104847931, 19.788370458607901, null, 1.6719496977709882m, 4.795675055141949m },
                    { new Guid("9ef093c8-3c42-4a9d-8e6d-36dfb1c90898"), "Mini", 0, "Rue", "Henrik", 45.234728393171295, 19.822851909980773, null, 1.1939296054078634m, 1.7459564675100006m },
                    { new Guid("a0c2d9bf-0706-4fcc-9357-b9a1d2f16bef"), "Acura", 0, "Anais", "Johnna", 45.287676498702332, 19.843019007354567, null, 1.1278655668254658m, 10.710397156830041m },
                    { new Guid("a1ff0676-2809-448c-92f7-ae9e34fc32d3"), "Porsche", 0, "Jen", "Shar", 45.210580578767569, 19.787137195434291, null, 1.7006360867551042m, 9.781009068780087m },
                    { new Guid("a7ec04d4-cc17-4a45-b8c5-3005aa06c787"), "INFINITI", 0, "Haas", "Chad", 45.288022877311491, 19.874835733268696, null, 1.5866952090365798m, 8.087357945507915m },
                    { new Guid("a8afe785-2119-4d9e-83f1-44f5b9814f50"), "Volkswagen", 0, "Werner", "Inde", 45.221608244262498, 19.819591497862248, null, 1.3967480906659557m, 4.545871705956596m },
                    { new Guid("ac6450ab-15f2-4fe7-a53c-36f47e780347"), "Jeep", 0, "Jurg", "Colleen", 45.27947091909018, 19.803280137550804, null, 1.0642568736345543m, 1.1178482649382784m },
                    { new Guid("add8504b-39e1-47ef-89cb-4c0291cc94b2"), "Mercedes-Benz", 0, "Fernanda", "Berry", 45.284341031601357, 19.88214656986014, null, 1.228808543535298m, 2.642344591342897m },
                    { new Guid("af511470-b696-44ea-82f1-51743e019bfc"), "McLaren", 0, "Flora", "Allesdandro", 45.250220306572913, 19.80629652423562, null, 1.6560543096854814m, 9.747141997226342m },
                    { new Guid("af565f3f-e01f-4de8-8f5f-17ba9f90b76e"), "Aston Martin Lagonda Ltd", 0, "Knox", "Lorrie", 45.264656353292338, 19.837986673820598, null, 1.536456046701279m, 4.863201684677997m }
                });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Driver_ID", "Brand", "DriverStatus", "FirstName", "LastName", "Latitude", "Longitude", "PassengerId", "PricePerKM", "StartPrice" },
                values: new object[,]
                {
                    { new Guid("af5d2c60-5446-4c48-903c-7717dfb7c100"), "Lincoln", 0, "Javid", "Tranta", 45.216149699839988, 19.853299911074188, null, 1.214353703785661m, 4.696927726796888m },
                    { new Guid("aff53317-a398-4e33-8c95-ce9e62a9a316"), "NISSAN", 0, "Rasika", "Raimundo", 45.291779211384224, 19.800023095935906, null, 1.0891868325268717m, 4.793560726767151m },
                    { new Guid("b19e7ff2-7cb1-498c-b822-92f8d2e46060"), "Cadillac", 0, "Olga", "Kristen", 45.29340112834867, 19.822498825540769, null, 1.6875309773099558m, 6.45756305740285m },
                    { new Guid("b40921a2-1a78-4159-b006-23f8a0f9abac"), "Land Rover", 0, "Oja", "Chin", 45.256914630896212, 19.858970871427317, null, 1.26487632045056m, 10.747802492089736m },
                    { new Guid("b4a87f91-aaa7-42ef-bb79-2ed1705f44fc"), "Mini", 0, "Larae", "Lindsey", 45.288988349342716, 19.869009669621189, null, 1.2705361960792216m, 3.7409616159613304m },
                    { new Guid("b7350d18-fd53-4d7f-b126-a67c6ac2c9cd"), "INFINITI", 0, "Jastinder", "Homero", 45.269815899190036, 19.810080082882855, null, 1.5244558202271907m, 1.9469998885842523m },
                    { new Guid("b8352a80-2261-4f00-b68c-9cb3a5650959"), "Subaru", 0, "Luz", "Jacqui", 45.282357438284876, 19.870750281402625, null, 1.3275739312198804m, 7.389799555041893m },
                    { new Guid("bbd6a48b-61b2-436b-a1b2-8f76c24ee3f4"), "Honda", 0, "Libbey", "Ernest", 45.282891901118944, 19.876434018077504, null, 1.2475192510221107m, 5.449373131830329m },
                    { new Guid("be4daf4e-0cba-4087-93ea-72b5f3a056c4"), "TOYOTA", 0, "Dang", "Erskine", 45.217855950352465, 19.834207010840032, null, 1.7497987535854724m, 4.824188848962091m },
                    { new Guid("bf1fab92-ec01-4ca1-98c0-ce3f4380ced0"), "ALFA ROMEO", 0, "Allison", "Royden", 45.295945743171906, 19.857674174593402, null, 1.5237046745427651m, 10.405094574404158m },
                    { new Guid("c0030c02-1eab-41cb-a799-164a8d35ced9"), "Roush", 0, "Dahlia", "Pandora", 45.222647874969191, 19.786655808995068, null, 1.0651228912043087m, 7.807872207177916m },
                    { new Guid("c19b0f96-5928-4ca2-bbfd-84ddfccd94d8"), "Mini", 0, "Jerildy", "Tzipora", 45.26373409468961, 19.820524995264094, null, 1.6770837896990307m, 3.156359811608757m },
                    { new Guid("c2047d7f-5553-43ee-b447-0183274c5ca8"), "Pagani Automobili S.p.A.", 0, "Morrissey", "Kellie", 45.274651670577768, 19.791858685850482, null, 1.3417230653533827m, 2.18234253206158m },
                    { new Guid("c3b26e51-dbe6-46bc-8680-c6f2315961f0"), "BMW", 0, "Jacques", "Lane", 45.213790253612132, 19.79774102895696, null, 1.7987752163597301m, 4.055436177433148m },
                    { new Guid("c3da9ec9-664c-4898-ac89-0894b73fcfc0"), "TOYOTA", 0, "Aden", "Eliza", 45.268648133812405, 19.831866095348715, null, 1.391490893102681m, 8.095125839709704m },
                    { new Guid("c58cd1b2-b179-4807-a617-d96c207d3651"), "Mitsubishi Motors Corporation", 0, "Yev", "Leeann", 45.243827207876294, 19.795146332823769, null, 1.4038353529833358m, 7.1267708754257715m },
                    { new Guid("c63e4c79-0a37-49d9-b7c5-423f6bf7fd50"), "Aston Martin Lagonda Ltd", 0, "Leonard", "Emerald", 45.2572972194831, 19.855507893571811, null, 1.2124823508556823m, 10.14906639309747m },
                    { new Guid("c6751013-e979-4b60-9570-33362990c04d"), "Acura", 0, "Jasmine", "Dorothy", 45.209423511503424, 19.81749485016757, null, 1.3610869109414416m, 7.115251420780801m },
                    { new Guid("c700d926-b99c-4650-be72-4f88d9f7c0d9"), "Chevrolet", 0, "Krizia", "Brusovanik", 45.267957633744437, 19.799666210958843, null, 1.6786208486121708m, 7.342233447742731m },
                    { new Guid("c778021b-a4d1-4c61-a4f2-6aa1758f0097"), "Porsche", 0, "Vlada", "Marisela", 45.275549215170642, 19.878672958375621, null, 1.692150219149442m, 4.292175821808732m },
                    { new Guid("c78af650-b34c-47b8-a7e5-dffbd15973c1"), "Acura", 0, "Jasmine", "Dorothy", 45.209423511503424, 19.81749485016757, null, 1.3610869109414416m, 7.115251420780801m },
                    { new Guid("c7e837b2-8d10-4e43-a3bb-d400252c5f6b"), "MASERATI", 0, "Residencia", "Casper", 45.229981095425153, 19.837153864471194, null, 1.554999380283847m, 9.574431191837565m },
                    { new Guid("ca03e5ce-a3bc-41c4-8840-8d6dc94f94d2"), "RAM", 0, "Welch", "Vaishali", 45.226846241954064, 19.839414266674314, null, 1.3494145070278685m, 3.1034505930423064m },
                    { new Guid("cb826b9a-65ef-44b7-9740-45ffd7f1530e"), "Mitsubishi Motors Corporation", 0, "Yev", "Leeann", 45.243827207876294, 19.795146332823769, null, 1.4038353529833358m, 7.1267708754257715m },
                    { new Guid("cbad7c41-f0fe-4773-aacd-174532e71c48"), "Pagani Automobili S.p.A.", 0, "Morrissey", "Kellie", 45.274651670577768, 19.791858685850482, null, 1.3417230653533827m, 2.18234253206158m },
                    { new Guid("ce8e4569-03b2-4b46-8181-54269b561137"), "BMW", 0, "Alessandro", "Ame", 45.213878946434399, 19.83500906624565, null, 1.1394055188065981m, 10.629290075265152m },
                    { new Guid("ceba7c8c-2e00-4e65-88fc-353367156534"), "Buick", 0, "Edie", "Maeve", 45.204068043710627, 19.850483415082969, null, 1.2435787993749734m, 1.5525301188205578m },
                    { new Guid("cf39afbb-c124-4076-a863-fa971e6c4976"), "Dodge", 0, "Andreas", "Adolfo", 45.265939837651047, 19.832946913832068, null, 1.7380170039298m, 8.510688070544214m },
                    { new Guid("cf7fc401-e44f-4b9b-8e60-ffbb76626002"), "Chrysler", 0, "Ibrahim", "Alina", 45.2993118675817, 19.796265612687975, null, 1.1089619486674978m, 10.521486246480235m },
                    { new Guid("cfe04c65-4bbb-4153-9cbf-90e8c7f25b4e"), "Volvo", 0, "Emma", "Tasha", 45.285854370015166, 19.866548271059557, null, 1.0566431268333218m, 8.509215393598028m },
                    { new Guid("cfef5d9c-093b-4bc5-9957-0509c512656e"), "Roush", 0, "Bernardino", "Danel", 45.262091751738382, 19.836733731194897, null, 1.685522127629019m, 5.239149409686604m },
                    { new Guid("d034b92b-18b6-4ba4-ab47-2205aaa4802f"), "Mercedes-Benz", 0, "Osvando", "Nicolaios", 45.216763399661289, 19.839646217936401, null, 1.390698997245516m, 2.4629580725247315m },
                    { new Guid("d04c1b15-ed54-433b-9a69-c0aee24923eb"), "Roush", 0, "Rossane", "Jessica", 45.266559868005444, 19.829707954977223, null, 1.504112436608676m, 9.364469311550952m },
                    { new Guid("d0d243a5-2968-4d89-9a7e-757f0976fccd"), "Audi", 0, "Carling", "Angeles", 45.256456267336631, 19.839344022449293, null, 1.2919937229218867m, 3.8797762168830876m },
                    { new Guid("d0deaa6b-543b-4682-886f-c0ef258b35fd"), "Dodge", 0, "Construccion", "Petty", 45.227061274337601, 19.836243969656948, null, 1.0452853161733882m, 3.69863700318812m },
                    { new Guid("d30712e5-b597-4de8-8901-f1a8ab82d647"), "Bentley", 0, "Lupita", "Bennet", 45.280486776875811, 19.844408581896609, null, 1.1702439175398553m, 10.496768111188889m },
                    { new Guid("d3655f52-2de5-48f0-8d6d-b31f182e80c5"), "Mitsubishi Motors Corporation", 0, "Bechmann", "Maikol", 45.279071426502327, 19.862370160619843, null, 1.324328579217307m, 4.565442360558393m },
                    { new Guid("d594f79d-072a-41ba-967b-94eb5e26a223"), "Jaguar", 0, "Mannix", "Gisella", 45.296266247572717, 19.804770086487757, null, 1.6910908453429156m, 3.2823166597464395m },
                    { new Guid("d8a87052-ca79-4f72-a9a0-e1d8cb170a76"), "Lincoln", 0, "Delair", "Meredith", 45.252036208353331, 19.868004870058986, null, 1.6143386734417438m, 6.054391760371328m },
                    { new Guid("d98b2369-e3c1-44cc-8d03-4a4a74d64647"), "Porsche", 0, "Vlada", "Marisela", 45.275549215170642, 19.878672958375621, null, 1.692150219149442m, 4.292175821808732m },
                    { new Guid("dc0c19e0-2678-48c0-841f-94a979a4aa91"), "Lamborghini", 0, "Letizia", "Kerry", 45.281638953906281, 19.813600296747204, null, 1.099366625884517m, 1.3295397945411715m },
                    { new Guid("dc201edd-67ff-4028-856f-256a4f7aac6c"), "BMW", 0, "Alessandro", "Ame", 45.213878946434399, 19.83500906624565, null, 1.1394055188065981m, 10.629290075265152m }
                });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Driver_ID", "Brand", "DriverStatus", "FirstName", "LastName", "Latitude", "Longitude", "PassengerId", "PricePerKM", "StartPrice" },
                values: new object[,]
                {
                    { new Guid("dd5f7647-9fd6-414d-9050-cf4cc31d94e5"), "Land Rover", 0, "Maurits", "Anurag", 45.253925064457675, 19.828862737626718, null, 1.7104501368390608m, 4.2596837052732415m },
                    { new Guid("ddcb8aea-6c1e-4e95-b13d-f8087c5315d7"), "Ford", 0, "Cora", "Otra", 45.278586743787962, 19.802530466611248, null, 1.7253447233445418m, 10.91510684753183m },
                    { new Guid("de9fbe7a-b98e-46ec-aefd-c69f3ffbd276"), "Rolls-Royce Motor Cars Limited", 0, "Henrik", "Edwin", 45.260099746320648, 19.846618295659582, null, 1.452835505779086m, 8.383483200020429m },
                    { new Guid("e00b179b-7546-436b-b246-ea724b570276"), "Bentley", 0, "Brandy", "Eleanor", 45.299538969878988, 19.880643245594662, null, 1.6281722977710191m, 5.728713211147051m },
                    { new Guid("e1c5ce9f-3529-41e7-a56a-97b3e3bb24b4"), "Jeep", 0, "Iya", "Jhonatan", 45.276139257770936, 19.843919556371958, null, 1.6328898520108956m, 7.314957794295983m },
                    { new Guid("e2bd45f3-a4d7-4041-9f0c-3e09194f9385"), "Lincoln", 0, "Geri", "Miii", 45.240326613759379, 19.856313447907667, null, 1.7338599905115184m, 10.732414512171566m },
                    { new Guid("e2e3ec14-3875-4f13-918f-68554f741194"), "Mini", 0, "Dianna", "Michal", 45.247323100321054, 19.842409377101806, null, 1.0397465494006515m, 5.223227457896003m },
                    { new Guid("e3362b46-55b3-4ebd-aa7f-4b2941304863"), "Porsche", 0, "Jen", "Shar", 45.210580578767569, 19.787137195434291, null, 1.7006360867551042m, 9.781009068780087m },
                    { new Guid("e52718c5-ab86-482e-bc77-268ce1342aa7"), "Volvo", 0, "Zena", "Kirstein", 45.238319779725494, 19.810359597732457, null, 1.7020772550670218m, 10.79799094974425m },
                    { new Guid("e532877c-e84e-401f-bd35-2dfa3014ac91"), "Lamborghini", 0, "Letizia", "Kerry", 45.281638953906281, 19.813600296747204, null, 1.099366625884517m, 1.3295397945411715m },
                    { new Guid("e5c1ffd8-3bce-4277-9fa5-bf05e2b2a075"), "Mercedes-Benz", 0, "Osvando", "Nicolaios", 45.216763399661289, 19.839646217936401, null, 1.390698997245516m, 2.4629580725247315m },
                    { new Guid("e7a14d82-7bac-43f7-a8a6-5c5e00be1723"), "TOYOTA", 0, "Henry", "Violoncella", 45.220604547812769, 19.860464073132178, null, 1.6549856762871982m, 8.414841851640341m },
                    { new Guid("e858bbc2-d341-46b0-9391-51087e849d25"), "Roush", 0, "Evangeline", "Granados", 45.255782205655841, 19.854106076392526, null, 1.7553795014338474m, 6.146249025698085m },
                    { new Guid("e9070f03-dfc0-4ea5-88d7-736ef9776144"), "Porsche", 0, "Lily", "Eugenia", 45.257195153791159, 19.808529545036901, null, 1.7101176770777686m, 2.275882597440534m },
                    { new Guid("e99bf370-5d7f-4f39-97e6-f74a0170cc0e"), "Dodge", 0, "Andreas", "Adolfo", 45.265939837651047, 19.832946913832068, null, 1.7380170039298m, 8.510688070544214m },
                    { new Guid("ea17d42b-e6c7-499e-a958-bea15cfd92ea"), "Porsche", 0, "Chrissy", "Tanyia", 45.279449168518042, 19.785822522191463, null, 1.4492458808602435m, 2.028265801352166m },
                    { new Guid("ec8c7177-b49d-4080-82ba-1f3478ca55a7"), "SCION", 0, "Vanessa", "Moran", 45.243401442719865, 19.845486901252453, null, 1.766625245740726m, 1.5974547157697985m },
                    { new Guid("ee8fedf4-bcc2-4b2a-b35d-5899d63e4d68"), "FIAT", 0, "Harold", "Karl", 45.286324628710155, 19.859015812248142, null, 1.7153672461915734m, 9.684974884213723m },
                    { new Guid("f0109842-ccd2-4754-bd48-1ed92692cf27"), "Mercedes-Benz", 0, "Marielle", "Orzai", 45.247779667723108, 19.842528794842231, null, 1.1929093189440756m, 4.356274892567532m },
                    { new Guid("f0f48005-a875-43c1-8339-4af93560e86b"), "MASERATI", 0, "Vartan", "Rhee", 45.298049374458131, 19.878864637212104, null, 1.5393415373611448m, 6.559482220099541m },
                    { new Guid("f43d43ec-01d3-400f-a585-56d589eb01ba"), "Aston Martin Lagonda Ltd", 0, "Elliot", "Loiselin", 45.222723321894421, 19.793603471598757, null, 1.5879618679964944m, 2.4186214661952135m },
                    { new Guid("f45ccff0-2d4f-4ca9-8bc4-1069748dff53"), "Land Rover", 0, "Oja", "Chin", 45.256914630896212, 19.858970871427317, null, 1.26487632045056m, 10.747802492089736m },
                    { new Guid("f486bf9e-fa05-440e-af17-aeaada3ffb27"), "Subaru", 0, "Luz", "Jacqui", 45.282357438284876, 19.870750281402625, null, 1.3275739312198804m, 7.389799555041893m },
                    { new Guid("f6043b76-ed6b-4ca7-979a-556179870a65"), "Jeep", 0, "Iya", "Jhonatan", 45.276139257770936, 19.843919556371958, null, 1.6328898520108956m, 7.314957794295983m },
                    { new Guid("f77172ac-dfa1-4363-af95-286ed2efe603"), "INFINITI", 0, "Deepti", "Devara", 45.275913260410107, 19.85081695839504, null, 1.6342564595450453m, 10.57353943753355m },
                    { new Guid("f7bc5e85-3664-4456-9672-1a53901240be"), "Volvo", 0, "Zena", "Kirstein", 45.238319779725494, 19.810359597732457, null, 1.7020772550670218m, 10.79799094974425m },
                    { new Guid("f7cc36a9-f198-4785-8621-61e8f00f763c"), "Roush", 0, "Iva", "Sloane", 45.218399244374908, 19.792091597548286, null, 1.6978977180498203m, 8.769920005723455m },
                    { new Guid("f86873d4-05f8-4d6c-a2ca-f05996ab2e68"), "RAM", 0, "Welch", "Vaishali", 45.226846241954064, 19.839414266674314, null, 1.3494145070278685m, 3.1034505930423064m },
                    { new Guid("f8bf001c-e596-4bd7-8bab-4f1213a50c21"), "Lamborghini", 0, "Aparna", "Segundo", 45.225215199148884, 19.883468373193303, null, 1.2154110733189056m, 3.652480026698223m },
                    { new Guid("f8caca75-e311-404c-92e9-d206b6436eba"), "FIAT", 0, "Harold", "Karl", 45.286324628710155, 19.859015812248142, null, 1.7153672461915734m, 9.684974884213723m },
                    { new Guid("fdfac433-73bc-456f-a39d-133064b9ae85"), "Volvo", 0, "Taryn", "Bener", 45.230507721803349, 19.8096740775133, null, 1.58709815212918m, 10.487772005185393m },
                    { new Guid("ff18b965-fea6-4823-9e9e-6895f151e688"), "Audi", 0, "Carling", "Angeles", 45.256456267336631, 19.839344022449293, null, 1.2919937229218867m, 3.8797762168830876m }
                });

            migrationBuilder.InsertData(
                table: "Passengers",
                columns: new[] { "PassengerId", "Birthday", "Email", "PassengerLastname", "PassengerName", "PassengersLatitude", "PassengersLongitude" },
                values: new object[,]
                {
                    { new Guid("1a145da1-9ddf-482b-8602-eb611dd2bad7"), new DateTime(1994, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "marija@example.com", "Maric", "Marija", 44.01652128768189, 21.00585973005126 },
                    { new Guid("6a44d2e9-a554-4f5e-aff3-2c7147227fe3"), new DateTime(1987, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "ana@example.com", "Ivanovic", "Ana", 44.786568287681888, 20.448921673005128 },
                    { new Guid("af3c7fe9-89e9-4c0a-bb17-644320c49d7e"), new DateTime(1990, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "marko@example.com", "Petrovic", "Marko", 43.32090222876819, 21.895758973005126 },
                    { new Guid("b11b8b0a-6ed2-4e40-b8ce-149af7fef4f0"), new DateTime(1993, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "raca93@gmail.com", "Bjelic", "Radivoje", 45.290568287681893, 19.924187873005128 },
                    { new Guid("b7eed1ed-11fa-47b8-9374-70a7f65f776a"), new DateTime(1985, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "nikola@example.com", "Nikolic", "Nikola", 45.26713522876819, 19.833549673005127 },
                    { new Guid("f4ced285-67fd-4e7a-b0e9-f3897c7ac5db"), new DateTime(1992, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "jelena@example.com", "Jankovic", "Jelena", 44.012793528768192, 20.91142273005126 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Rides_Rating_PassengerRatingRatingId",
                table: "Rides",
                column: "PassengerRatingRatingId",
                principalTable: "Rating",
                principalColumn: "RatingId");
        }
    }
}
