using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Sales.Migrations
{
    /// <inheritdoc />
    public partial class Managers_Seed_Prods_Mans : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Managers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Secname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdMainDep = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSecDep = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdChief = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Managers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Managers",
                columns: new[] { "Id", "IdChief", "IdMainDep", "IdSecDep", "Name", "Secname", "Surname" },
                values: new object[,]
                {
                    { new Guid("0017aaae-3e22-462d-9031-4276a9788d51"), new Guid("fea65ee4-a8a0-425b-8f11-3896c1e2197e"), new Guid("d2469412-0e4b-46f7-80ec-8c522364d099"), null, "Зигмунд", "Владимирович", "Журавлёв" },
                    { new Guid("05e31241-7274-43b5-8b59-9a62d725e54f"), new Guid("e1ac29ad-122e-474d-926a-f93ac636f605"), new Guid("d2469412-0e4b-46f7-80ec-8c522364d099"), null, "Алёна", "Александровна", "Майборода" },
                    { new Guid("0889c51e-7728-4abd-9987-3588d48b54a9"), new Guid("542cb2c1-a8e3-42db-97fa-b3c79b12a1a9"), new Guid("131ef84b-f06e-494b-848f-bb4bc0604266"), new Guid("8dcc3969-1d93-47a9-8b79-a30c738db9b4"), "Полина", "Львовна", "Кобзар" },
                    { new Guid("0989e3a2-3d6d-4bc3-a538-c4055f9a09dd"), new Guid("23dbe38c-0ed4-4e90-8bc7-f168134e8674"), new Guid("d3c376e4-bce3-4d85-aba4-e3cf49612c94"), null, "Добрыня", "Львович", "Данилов" },
                    { new Guid("0b2be83a-7fb4-403b-8ce8-37be257b038c"), null, new Guid("d2469412-0e4b-46f7-80ec-8c522364d099"), null, "Клим", "Викторович", "Евдокимов" },
                    { new Guid("101be2b1-c0af-493e-bbf2-c8d8e4eb826c"), new Guid("2b3170c4-3063-43e6-985d-a38d9e45af09"), new Guid("d2469412-0e4b-46f7-80ec-8c522364d099"), null, "Нина", "Платоновна", "Корнейчук" },
                    { new Guid("1166ecdd-63c8-42fc-a68a-c292176a7b04"), new Guid("c5f771fb-a645-4ba1-8155-f3f5002b2b89"), new Guid("1ef7268c-43a8-488c-b761-90982b31df4e"), new Guid("624b3bb5-0f2c-42b6-a416-099aab799546"), "Роберт", "Евгеньевич", "Веселов" },
                    { new Guid("13ded219-a580-4ff8-8211-90a408b0afa6"), new Guid("1166ecdd-63c8-42fc-a68a-c292176a7b04"), new Guid("131ef84b-f06e-494b-848f-bb4bc0604266"), null, "Ярослава", "Романовна", "Егорова" },
                    { new Guid("15f36ecc-ef25-495f-adff-169db3339b88"), new Guid("05e31241-7274-43b5-8b59-9a62d725e54f"), new Guid("8dcc3969-1d93-47a9-8b79-a30c738db9b4"), null, "Екатерина", "Дмитриевна", "Копылова" },
                    { new Guid("1a930de7-647b-4a32-ad3b-0caf4528b356"), null, new Guid("8dcc3969-1d93-47a9-8b79-a30c738db9b4"), new Guid("624b3bb5-0f2c-42b6-a416-099aab799546"), "Абрам", "Романович", "Шумейко" },
                    { new Guid("1adc048c-e346-47c3-8c35-7ad4fdaa6eb7"), null, new Guid("624b3bb5-0f2c-42b6-a416-099aab799546"), new Guid("d3c376e4-bce3-4d85-aba4-e3cf49612c94"), "Екатерина", "Викторовна", "Шубина" },
                    { new Guid("207cdcf2-89ad-49a5-a669-a082fa9cccba"), null, new Guid("1ef7268c-43a8-488c-b761-90982b31df4e"), null, "Флорентина", "Виталиевна", "Соловьёва" },
                    { new Guid("239450eb-a92f-4093-a74f-eaa38f8adbe2"), new Guid("23d52416-d994-4564-a106-1fdf5fecef25"), new Guid("415b36d9-2d82-4a92-a313-48312f8e18c6"), null, "Анжелика", "Борисовна", "Толочко" },
                    { new Guid("23d52416-d994-4564-a106-1fdf5fecef25"), new Guid("23dbe38c-0ed4-4e90-8bc7-f168134e8674"), new Guid("d2469412-0e4b-46f7-80ec-8c522364d099"), new Guid("624b3bb5-0f2c-42b6-a416-099aab799546"), "Заур", "Иванович", "Куликов" },
                    { new Guid("23dbe38c-0ed4-4e90-8bc7-f168134e8674"), new Guid("3e229eb8-e99a-455f-8af3-5871337a092c"), new Guid("8dcc3969-1d93-47a9-8b79-a30c738db9b4"), new Guid("415b36d9-2d82-4a92-a313-48312f8e18c6"), "Эльвира", "Фёдоровна", "Родионова" },
                    { new Guid("267f7528-2d4b-4063-a2c8-98e8f19fb6ee"), new Guid("207cdcf2-89ad-49a5-a669-a082fa9cccba"), new Guid("131ef84b-f06e-494b-848f-bb4bc0604266"), new Guid("415b36d9-2d82-4a92-a313-48312f8e18c6"), "Герасим", "Анатолиевич", "Кириллов" },
                    { new Guid("29219db8-16a0-4046-a7e1-6e455b0559cd"), null, new Guid("131ef84b-f06e-494b-848f-bb4bc0604266"), new Guid("d2469412-0e4b-46f7-80ec-8c522364d099"), "Альбина", "Ивановна", "Дементьева" },
                    { new Guid("2b3170c4-3063-43e6-985d-a38d9e45af09"), null, new Guid("131ef84b-f06e-494b-848f-bb4bc0604266"), new Guid("d3c376e4-bce3-4d85-aba4-e3cf49612c94"), "Ольга", "Владимировна", "Коваленко" },
                    { new Guid("2fa70965-5bce-44f0-b6dd-2af6072eb8b0"), null, new Guid("624b3bb5-0f2c-42b6-a416-099aab799546"), null, "Адриан", "Петрович", "Комаров" },
                    { new Guid("3618d1d1-32de-40b5-b823-9f82924a3caf"), null, new Guid("131ef84b-f06e-494b-848f-bb4bc0604266"), new Guid("1ef7268c-43a8-488c-b761-90982b31df4e"), "Всеволод", "Ярославович", "Бобылёв" },
                    { new Guid("381c2888-1cb0-41fa-9650-48b953f31ef6"), new Guid("663c3142-1c9d-4957-800d-f6c6824b9c88"), new Guid("624b3bb5-0f2c-42b6-a416-099aab799546"), null, "Олег", "Грегориевич", "Беляков" },
                    { new Guid("39d57dfb-8da7-49c9-ae8d-464509618f02"), null, new Guid("8dcc3969-1d93-47a9-8b79-a30c738db9b4"), null, "Семён", "Юхимович", "Гуляев" },
                    { new Guid("3e229eb8-e99a-455f-8af3-5871337a092c"), null, new Guid("131ef84b-f06e-494b-848f-bb4bc0604266"), null, "Валерия", "Петровна", "Белоусова" },
                    { new Guid("435eee28-e5ea-4ec9-9f01-de884dfd6292"), null, new Guid("624b3bb5-0f2c-42b6-a416-099aab799546"), new Guid("1ef7268c-43a8-488c-b761-90982b31df4e"), "Вера", "Евгеньевна", "Лазарева" },
                    { new Guid("45489fe7-86c8-4fa1-9d79-a82197566bf3"), null, new Guid("d3c376e4-bce3-4d85-aba4-e3cf49612c94"), new Guid("131ef84b-f06e-494b-848f-bb4bc0604266"), "Максим", "Вадимович", "Кулагин" },
                    { new Guid("46d73a48-3906-44f4-a4b4-e29f1cc40b4f"), new Guid("435eee28-e5ea-4ec9-9f01-de884dfd6292"), new Guid("d3c376e4-bce3-4d85-aba4-e3cf49612c94"), null, "Инна", "Эдуардовна", "Милославска" },
                    { new Guid("521c07be-6fbd-411f-bccb-93e2672bd50e"), null, new Guid("d3c376e4-bce3-4d85-aba4-e3cf49612c94"), null, "Нестор", "Юхимович", "Соболев" },
                    { new Guid("5319fd22-9bde-48e5-819d-fe884b70afd8"), new Guid("39d57dfb-8da7-49c9-ae8d-464509618f02"), new Guid("d2469412-0e4b-46f7-80ec-8c522364d099"), null, "Ирина", "Ивановна", "Бердник" },
                    { new Guid("542cb2c1-a8e3-42db-97fa-b3c79b12a1a9"), null, new Guid("131ef84b-f06e-494b-848f-bb4bc0604266"), new Guid("624b3bb5-0f2c-42b6-a416-099aab799546"), "Сергей", "Платонович", "Назаров" },
                    { new Guid("55ff549e-1489-4b4a-9482-b843cd70c546"), null, new Guid("415b36d9-2d82-4a92-a313-48312f8e18c6"), new Guid("624b3bb5-0f2c-42b6-a416-099aab799546"), "Любовь", "Ивановна", "Ялова" },
                    { new Guid("5fe63a0f-c1ae-44be-9397-0f7db0b95c1f"), new Guid("29219db8-16a0-4046-a7e1-6e455b0559cd"), new Guid("d3c376e4-bce3-4d85-aba4-e3cf49612c94"), new Guid("415b36d9-2d82-4a92-a313-48312f8e18c6"), "Оливер", "Иванович", "Спивак" },
                    { new Guid("63531753-4d76-4a93-ad15-c727ffeca6ab"), new Guid("3618d1d1-32de-40b5-b823-9f82924a3caf"), new Guid("d2469412-0e4b-46f7-80ec-8c522364d099"), null, "Станислав", "Брониславович", "Никитин" },
                    { new Guid("66034616-24e5-4e90-815f-476eb0cbb6b1"), new Guid("fea65ee4-a8a0-425b-8f11-3896c1e2197e"), new Guid("624b3bb5-0f2c-42b6-a416-099aab799546"), null, "Антонина", "Евгеньевна", "Гурьева" },
                    { new Guid("663c3142-1c9d-4957-800d-f6c6824b9c88"), new Guid("0017aaae-3e22-462d-9031-4276a9788d51"), new Guid("d3c376e4-bce3-4d85-aba4-e3cf49612c94"), null, "Флорентина", "Брониславовна", "Баранова" },
                    { new Guid("676d8ed4-8307-4196-9776-107c40c1df84"), new Guid("7b8219fc-9fd2-431e-985c-7caa6e9bd013"), new Guid("1ef7268c-43a8-488c-b761-90982b31df4e"), new Guid("624b3bb5-0f2c-42b6-a416-099aab799546"), "Кристиан", "Евгеньевич", "Ерёменко" },
                    { new Guid("6cbea09e-e3e4-4dd3-a6c5-ed9ccd986bc0"), null, new Guid("415b36d9-2d82-4a92-a313-48312f8e18c6"), null, "Аким", "Петрович", "Журавлёв" },
                    { new Guid("6fb5bca3-2cae-4450-aab5-e0184fd45be9"), null, new Guid("415b36d9-2d82-4a92-a313-48312f8e18c6"), null, "Альбина", "Викторовна", "Ткаченко" },
                    { new Guid("743c93f2-4717-4e81-a093-69903476e176"), null, new Guid("131ef84b-f06e-494b-848f-bb4bc0604266"), null, "Орест", "Ярославович", "Носков" },
                    { new Guid("7585d790-6e5a-4f73-a85c-4f9bd883d811"), null, new Guid("415b36d9-2d82-4a92-a313-48312f8e18c6"), null, "Влад", "Виталиевич", "Жуков" },
                    { new Guid("789a53ab-a54d-4af7-94a5-dd288428a37c"), new Guid("dc268b00-1727-4381-9878-6da1bfef2701"), new Guid("624b3bb5-0f2c-42b6-a416-099aab799546"), null, "Клара", "Даниловна", "Гуляева" },
                    { new Guid("79679ed4-0ccd-480a-8d5b-4a68287de6c4"), new Guid("0b2be83a-7fb4-403b-8ce8-37be257b038c"), new Guid("624b3bb5-0f2c-42b6-a416-099aab799546"), null, "Полина", "Васильевна", "Макарова" },
                    { new Guid("7a88b1b9-0216-4259-8ba6-c123abb3c6a8"), null, new Guid("415b36d9-2d82-4a92-a313-48312f8e18c6"), new Guid("1ef7268c-43a8-488c-b761-90982b31df4e"), "Инга", "Артёмовна", "Трясило" },
                    { new Guid("7b8219fc-9fd2-431e-985c-7caa6e9bd013"), new Guid("3e229eb8-e99a-455f-8af3-5871337a092c"), new Guid("d2469412-0e4b-46f7-80ec-8c522364d099"), new Guid("d3c376e4-bce3-4d85-aba4-e3cf49612c94"), "Лука", "Грегориевич", "Герасимов" },
                    { new Guid("868f6394-3ca3-4700-90bb-6b73ec6719a7"), null, new Guid("1ef7268c-43a8-488c-b761-90982b31df4e"), new Guid("d2469412-0e4b-46f7-80ec-8c522364d099"), "Капитолина", "Станиславовна", "Гордеева" },
                    { new Guid("8939ed0c-bbdb-435e-923e-68158d2153c6"), new Guid("743c93f2-4717-4e81-a093-69903476e176"), new Guid("415b36d9-2d82-4a92-a313-48312f8e18c6"), null, "Нелли", "Ярославовна", "Красинец" },
                    { new Guid("a93a1b20-155a-43bd-acee-87a6088c969e"), null, new Guid("1ef7268c-43a8-488c-b761-90982b31df4e"), null, "Марта", "Борисовна", "Исаева" },
                    { new Guid("c5ee780a-4d53-40fb-a592-c35cfc9455f2"), null, new Guid("8dcc3969-1d93-47a9-8b79-a30c738db9b4"), null, "Рада", "Сергеевна", "Мирна" },
                    { new Guid("c5f771fb-a645-4ba1-8155-f3f5002b2b89"), new Guid("8939ed0c-bbdb-435e-923e-68158d2153c6"), new Guid("415b36d9-2d82-4a92-a313-48312f8e18c6"), new Guid("1ef7268c-43a8-488c-b761-90982b31df4e"), "Ника", "Эдуардовна", "Павлик" },
                    { new Guid("cde086e1-d25c-4251-a234-10727818ee28"), null, new Guid("d2469412-0e4b-46f7-80ec-8c522364d099"), new Guid("131ef84b-f06e-494b-848f-bb4bc0604266"), "Александр", "Леонидович", "Воронов" },
                    { new Guid("d13f3cca-b9f8-4bc1-96f4-c80583928e55"), new Guid("dc268b00-1727-4381-9878-6da1bfef2701"), new Guid("1ef7268c-43a8-488c-b761-90982b31df4e"), null, "Люций", "Львович", "Бородай" },
                    { new Guid("d3fcc76b-09a2-4578-a72c-34468da36c45"), new Guid("1a930de7-647b-4a32-ad3b-0caf4528b356"), new Guid("624b3bb5-0f2c-42b6-a416-099aab799546"), new Guid("415b36d9-2d82-4a92-a313-48312f8e18c6"), "Мальвина", "Дмитриевна", "Одинцова" },
                    { new Guid("dc268b00-1727-4381-9878-6da1bfef2701"), new Guid("868f6394-3ca3-4700-90bb-6b73ec6719a7"), new Guid("d2469412-0e4b-46f7-80ec-8c522364d099"), null, "Владлен", "Богданович", "Ершов" },
                    { new Guid("dd860e7e-c2f0-47a6-ba29-165be015e5a2"), null, new Guid("415b36d9-2d82-4a92-a313-48312f8e18c6"), new Guid("624b3bb5-0f2c-42b6-a416-099aab799546"), "Клим", "Эдуардович", "Князев" },
                    { new Guid("e1ac29ad-122e-474d-926a-f93ac636f605"), new Guid("3e229eb8-e99a-455f-8af3-5871337a092c"), new Guid("415b36d9-2d82-4a92-a313-48312f8e18c6"), new Guid("1ef7268c-43a8-488c-b761-90982b31df4e"), "Конрад", "Леонидович", "Моисеев" },
                    { new Guid("e56f5de6-a1d3-4c3e-a09a-a9b9fa96c9b3"), new Guid("dd860e7e-c2f0-47a6-ba29-165be015e5a2"), new Guid("624b3bb5-0f2c-42b6-a416-099aab799546"), new Guid("d2469412-0e4b-46f7-80ec-8c522364d099"), "Зинаида", "Евгеньевна", "Одинцова" },
                    { new Guid("ee860ee3-6cca-4ea3-a2f1-fb79f4fc823a"), new Guid("676d8ed4-8307-4196-9776-107c40c1df84"), new Guid("415b36d9-2d82-4a92-a313-48312f8e18c6"), null, "Ярослав", "Романович", "Корнилов" },
                    { new Guid("efef5433-7e26-43a3-a737-3bb032d7d88a"), new Guid("63531753-4d76-4a93-ad15-c727ffeca6ab"), new Guid("8dcc3969-1d93-47a9-8b79-a30c738db9b4"), null, "Нина", "Михайловна", "Степанова" },
                    { new Guid("fe7e578e-5fc8-4d80-ad6b-500ddf2506c4"), new Guid("7a88b1b9-0216-4259-8ba6-c123abb3c6a8"), new Guid("d2469412-0e4b-46f7-80ec-8c522364d099"), null, "Радислав", "Дмитриевич", "Рожков" },
                    { new Guid("fea65ee4-a8a0-425b-8f11-3896c1e2197e"), null, new Guid("415b36d9-2d82-4a92-a313-48312f8e18c6"), new Guid("624b3bb5-0f2c-42b6-a416-099aab799546"), "Пётр", "Максимович", "Галкин" },
                    { new Guid("ff559ae5-64b6-459e-9771-cb36130b3b75"), new Guid("435eee28-e5ea-4ec9-9f01-de884dfd6292"), new Guid("1ef7268c-43a8-488c-b761-90982b31df4e"), null, "Станислав", "Михайлович", "Туров" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("17db11d1-f50e-4cf4-9c54-cf1bd45802ea"), "Электроды 3мм", 49.979999999999997 },
                    { new Guid("21b0f444-2e4f-47d8-80c1-e69bf1c34ca8"), "Гайка М4", 6.5 },
                    { new Guid("2dca5e44-b06d-4613-bb6a-d3bc91430bfe"), "Гровер М4", 5.9900000000000002 },
                    { new Guid("4a550d3b-d1f2-40ef-ae4e-963612c6713a"), "Сварочный аппарат", 2099.0 },
                    { new Guid("64a4df8a-0733-4be9-aaba-c01b4ec3612a"), "Болт 4х60", 9.9800000000000004 },
                    { new Guid("69b125d7-99cc-42d6-a6fa-46687f333749"), "Винт 'потай' 3х16", 3.98 },
                    { new Guid("7264d33a-16b9-4e22-b3f1-63d6dae60078"), "Паяльник 40 Вт", 199.97999999999999 },
                    { new Guid("7b08197b-c55f-4389-891f-bf12a575dffb"), "Отвертка PZ2", 35.5 },
                    { new Guid("870da1a9-44f4-4018-b7fc-727a2058faf0"), "Шуруповерт", 799.0 },
                    { new Guid("8ff90e21-dcdb-4d55-a557-7c6d57dbb029"), "Молоток", 216.5 },
                    { new Guid("94bc671a-a6b6-417a-bc9f-8ae4871a58ec"), "Дюбель 6х60", 5.5 },
                    { new Guid("9654271b-ab52-4225-a30c-d75054b1733f"), "Лазерный дальномер", 1950.0 },
                    { new Guid("a8e6be17-5447-4804-ab61-f31abf5a76d3"), "Шуруп 4х35", 4.25 },
                    { new Guid("b6d20749-b495-4b1a-ba1c-80b88e78b7cd"), "Гвоздь 80мм", 19.98 },
                    { new Guid("bb29f63d-1261-41f2-89e8-88f44d5ec409"), "Сверло 6х80", 39.979999999999997 },
                    { new Guid("d17a4442-0a71-4673-b450-36929048adef"), "Шуруп 5х45", 5.9800000000000004 },
                    { new Guid("da1e17bb-a90d-4c79-b801-5462fb070f57"), "Гвоздь 100мм", 10.5 },
                    { new Guid("efc6578a-00b7-4766-a7e3-79cdba8c294b"), "Органайзер для шурупов", 199.0 },
                    { new Guid("f2585221-1aca-4efe-a5e8-c2f4534d1f92"), "Дрель электрическая", 990.0 },
                    { new Guid("f7f1e576-af8d-4749-869e-4a794fe69d42"), "Набор 'Новосел'", 52.399999999999999 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Managers");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("17db11d1-f50e-4cf4-9c54-cf1bd45802ea"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("21b0f444-2e4f-47d8-80c1-e69bf1c34ca8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2dca5e44-b06d-4613-bb6a-d3bc91430bfe"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4a550d3b-d1f2-40ef-ae4e-963612c6713a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("64a4df8a-0733-4be9-aaba-c01b4ec3612a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("69b125d7-99cc-42d6-a6fa-46687f333749"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7264d33a-16b9-4e22-b3f1-63d6dae60078"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7b08197b-c55f-4389-891f-bf12a575dffb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("870da1a9-44f4-4018-b7fc-727a2058faf0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8ff90e21-dcdb-4d55-a557-7c6d57dbb029"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("94bc671a-a6b6-417a-bc9f-8ae4871a58ec"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9654271b-ab52-4225-a30c-d75054b1733f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a8e6be17-5447-4804-ab61-f31abf5a76d3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b6d20749-b495-4b1a-ba1c-80b88e78b7cd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bb29f63d-1261-41f2-89e8-88f44d5ec409"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d17a4442-0a71-4673-b450-36929048adef"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("da1e17bb-a90d-4c79-b801-5462fb070f57"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("efc6578a-00b7-4766-a7e3-79cdba8c294b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f2585221-1aca-4efe-a5e8-c2f4534d1f92"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f7f1e576-af8d-4749-869e-4a794fe69d42"));
        }
    }
}
