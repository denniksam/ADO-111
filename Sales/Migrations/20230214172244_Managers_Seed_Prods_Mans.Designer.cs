﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sales.EfContext;

#nullable disable

namespace Sales.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230214172244_Managers_Seed_Prods_Mans")]
    partial class Managers_Seed_Prods_Mans
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Sales.EfContext.Department", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d3c376e4-bce3-4d85-aba4-e3cf49612c94"),
                            Name = "IT отдел"
                        },
                        new
                        {
                            Id = new Guid("131ef84b-f06e-494b-848f-bb4bc0604266"),
                            Name = "Бухгалтерия"
                        },
                        new
                        {
                            Id = new Guid("8dcc3969-1d93-47a9-8b79-a30c738db9b4"),
                            Name = "Служба безопасности"
                        },
                        new
                        {
                            Id = new Guid("d2469412-0e4b-46f7-80ec-8c522364d099"),
                            Name = "Отдел кадров"
                        },
                        new
                        {
                            Id = new Guid("1ef7268c-43a8-488c-b761-90982b31df4e"),
                            Name = "Канцелярия"
                        },
                        new
                        {
                            Id = new Guid("415b36d9-2d82-4a92-a313-48312f8e18c6"),
                            Name = "Отдел продаж"
                        },
                        new
                        {
                            Id = new Guid("624b3bb5-0f2c-42b6-a416-099aab799546"),
                            Name = "Юридическая служба"
                        });
                });

            modelBuilder.Entity("Sales.EfContext.Manager", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdChief")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdMainDep")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdSecDep")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Secname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Managers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("743c93f2-4717-4e81-a093-69903476e176"),
                            IdMainDep = new Guid("131ef84b-f06e-494b-848f-bb4bc0604266"),
                            Name = "Орест",
                            Secname = "Ярославович",
                            Surname = "Носков"
                        },
                        new
                        {
                            Id = new Guid("63531753-4d76-4a93-ad15-c727ffeca6ab"),
                            IdChief = new Guid("3618d1d1-32de-40b5-b823-9f82924a3caf"),
                            IdMainDep = new Guid("d2469412-0e4b-46f7-80ec-8c522364d099"),
                            Name = "Станислав",
                            Secname = "Брониславович",
                            Surname = "Никитин"
                        },
                        new
                        {
                            Id = new Guid("cde086e1-d25c-4251-a234-10727818ee28"),
                            IdMainDep = new Guid("d2469412-0e4b-46f7-80ec-8c522364d099"),
                            IdSecDep = new Guid("131ef84b-f06e-494b-848f-bb4bc0604266"),
                            Name = "Александр",
                            Secname = "Леонидович",
                            Surname = "Воронов"
                        },
                        new
                        {
                            Id = new Guid("0b2be83a-7fb4-403b-8ce8-37be257b038c"),
                            IdMainDep = new Guid("d2469412-0e4b-46f7-80ec-8c522364d099"),
                            Name = "Клим",
                            Secname = "Викторович",
                            Surname = "Евдокимов"
                        },
                        new
                        {
                            Id = new Guid("7585d790-6e5a-4f73-a85c-4f9bd883d811"),
                            IdMainDep = new Guid("415b36d9-2d82-4a92-a313-48312f8e18c6"),
                            Name = "Влад",
                            Secname = "Виталиевич",
                            Surname = "Жуков"
                        },
                        new
                        {
                            Id = new Guid("45489fe7-86c8-4fa1-9d79-a82197566bf3"),
                            IdMainDep = new Guid("d3c376e4-bce3-4d85-aba4-e3cf49612c94"),
                            IdSecDep = new Guid("131ef84b-f06e-494b-848f-bb4bc0604266"),
                            Name = "Максим",
                            Secname = "Вадимович",
                            Surname = "Кулагин"
                        },
                        new
                        {
                            Id = new Guid("0017aaae-3e22-462d-9031-4276a9788d51"),
                            IdChief = new Guid("fea65ee4-a8a0-425b-8f11-3896c1e2197e"),
                            IdMainDep = new Guid("d2469412-0e4b-46f7-80ec-8c522364d099"),
                            Name = "Зигмунд",
                            Secname = "Владимирович",
                            Surname = "Журавлёв"
                        },
                        new
                        {
                            Id = new Guid("521c07be-6fbd-411f-bccb-93e2672bd50e"),
                            IdMainDep = new Guid("d3c376e4-bce3-4d85-aba4-e3cf49612c94"),
                            Name = "Нестор",
                            Secname = "Юхимович",
                            Surname = "Соболев"
                        },
                        new
                        {
                            Id = new Guid("381c2888-1cb0-41fa-9650-48b953f31ef6"),
                            IdChief = new Guid("663c3142-1c9d-4957-800d-f6c6824b9c88"),
                            IdMainDep = new Guid("624b3bb5-0f2c-42b6-a416-099aab799546"),
                            Name = "Олег",
                            Secname = "Грегориевич",
                            Surname = "Беляков"
                        },
                        new
                        {
                            Id = new Guid("e1ac29ad-122e-474d-926a-f93ac636f605"),
                            IdChief = new Guid("3e229eb8-e99a-455f-8af3-5871337a092c"),
                            IdMainDep = new Guid("415b36d9-2d82-4a92-a313-48312f8e18c6"),
                            IdSecDep = new Guid("1ef7268c-43a8-488c-b761-90982b31df4e"),
                            Name = "Конрад",
                            Secname = "Леонидович",
                            Surname = "Моисеев"
                        },
                        new
                        {
                            Id = new Guid("39d57dfb-8da7-49c9-ae8d-464509618f02"),
                            IdMainDep = new Guid("8dcc3969-1d93-47a9-8b79-a30c738db9b4"),
                            Name = "Семён",
                            Secname = "Юхимович",
                            Surname = "Гуляев"
                        },
                        new
                        {
                            Id = new Guid("542cb2c1-a8e3-42db-97fa-b3c79b12a1a9"),
                            IdMainDep = new Guid("131ef84b-f06e-494b-848f-bb4bc0604266"),
                            IdSecDep = new Guid("624b3bb5-0f2c-42b6-a416-099aab799546"),
                            Name = "Сергей",
                            Secname = "Платонович",
                            Surname = "Назаров"
                        },
                        new
                        {
                            Id = new Guid("fe7e578e-5fc8-4d80-ad6b-500ddf2506c4"),
                            IdChief = new Guid("7a88b1b9-0216-4259-8ba6-c123abb3c6a8"),
                            IdMainDep = new Guid("d2469412-0e4b-46f7-80ec-8c522364d099"),
                            Name = "Радислав",
                            Secname = "Дмитриевич",
                            Surname = "Рожков"
                        },
                        new
                        {
                            Id = new Guid("7b8219fc-9fd2-431e-985c-7caa6e9bd013"),
                            IdChief = new Guid("3e229eb8-e99a-455f-8af3-5871337a092c"),
                            IdMainDep = new Guid("d2469412-0e4b-46f7-80ec-8c522364d099"),
                            IdSecDep = new Guid("d3c376e4-bce3-4d85-aba4-e3cf49612c94"),
                            Name = "Лука",
                            Secname = "Грегориевич",
                            Surname = "Герасимов"
                        },
                        new
                        {
                            Id = new Guid("23d52416-d994-4564-a106-1fdf5fecef25"),
                            IdChief = new Guid("23dbe38c-0ed4-4e90-8bc7-f168134e8674"),
                            IdMainDep = new Guid("d2469412-0e4b-46f7-80ec-8c522364d099"),
                            IdSecDep = new Guid("624b3bb5-0f2c-42b6-a416-099aab799546"),
                            Name = "Заур",
                            Secname = "Иванович",
                            Surname = "Куликов"
                        },
                        new
                        {
                            Id = new Guid("ee860ee3-6cca-4ea3-a2f1-fb79f4fc823a"),
                            IdChief = new Guid("676d8ed4-8307-4196-9776-107c40c1df84"),
                            IdMainDep = new Guid("415b36d9-2d82-4a92-a313-48312f8e18c6"),
                            Name = "Ярослав",
                            Secname = "Романович",
                            Surname = "Корнилов"
                        },
                        new
                        {
                            Id = new Guid("dd860e7e-c2f0-47a6-ba29-165be015e5a2"),
                            IdMainDep = new Guid("415b36d9-2d82-4a92-a313-48312f8e18c6"),
                            IdSecDep = new Guid("624b3bb5-0f2c-42b6-a416-099aab799546"),
                            Name = "Клим",
                            Secname = "Эдуардович",
                            Surname = "Князев"
                        },
                        new
                        {
                            Id = new Guid("267f7528-2d4b-4063-a2c8-98e8f19fb6ee"),
                            IdChief = new Guid("207cdcf2-89ad-49a5-a669-a082fa9cccba"),
                            IdMainDep = new Guid("131ef84b-f06e-494b-848f-bb4bc0604266"),
                            IdSecDep = new Guid("415b36d9-2d82-4a92-a313-48312f8e18c6"),
                            Name = "Герасим",
                            Secname = "Анатолиевич",
                            Surname = "Кириллов"
                        },
                        new
                        {
                            Id = new Guid("fea65ee4-a8a0-425b-8f11-3896c1e2197e"),
                            IdMainDep = new Guid("415b36d9-2d82-4a92-a313-48312f8e18c6"),
                            IdSecDep = new Guid("624b3bb5-0f2c-42b6-a416-099aab799546"),
                            Name = "Пётр",
                            Secname = "Максимович",
                            Surname = "Галкин"
                        },
                        new
                        {
                            Id = new Guid("d13f3cca-b9f8-4bc1-96f4-c80583928e55"),
                            IdChief = new Guid("dc268b00-1727-4381-9878-6da1bfef2701"),
                            IdMainDep = new Guid("1ef7268c-43a8-488c-b761-90982b31df4e"),
                            Name = "Люций",
                            Secname = "Львович",
                            Surname = "Бородай"
                        },
                        new
                        {
                            Id = new Guid("5fe63a0f-c1ae-44be-9397-0f7db0b95c1f"),
                            IdChief = new Guid("29219db8-16a0-4046-a7e1-6e455b0559cd"),
                            IdMainDep = new Guid("d3c376e4-bce3-4d85-aba4-e3cf49612c94"),
                            IdSecDep = new Guid("415b36d9-2d82-4a92-a313-48312f8e18c6"),
                            Name = "Оливер",
                            Secname = "Иванович",
                            Surname = "Спивак"
                        },
                        new
                        {
                            Id = new Guid("dc268b00-1727-4381-9878-6da1bfef2701"),
                            IdChief = new Guid("868f6394-3ca3-4700-90bb-6b73ec6719a7"),
                            IdMainDep = new Guid("d2469412-0e4b-46f7-80ec-8c522364d099"),
                            Name = "Владлен",
                            Secname = "Богданович",
                            Surname = "Ершов"
                        },
                        new
                        {
                            Id = new Guid("2fa70965-5bce-44f0-b6dd-2af6072eb8b0"),
                            IdMainDep = new Guid("624b3bb5-0f2c-42b6-a416-099aab799546"),
                            Name = "Адриан",
                            Secname = "Петрович",
                            Surname = "Комаров"
                        },
                        new
                        {
                            Id = new Guid("1166ecdd-63c8-42fc-a68a-c292176a7b04"),
                            IdChief = new Guid("c5f771fb-a645-4ba1-8155-f3f5002b2b89"),
                            IdMainDep = new Guid("1ef7268c-43a8-488c-b761-90982b31df4e"),
                            IdSecDep = new Guid("624b3bb5-0f2c-42b6-a416-099aab799546"),
                            Name = "Роберт",
                            Secname = "Евгеньевич",
                            Surname = "Веселов"
                        },
                        new
                        {
                            Id = new Guid("0989e3a2-3d6d-4bc3-a538-c4055f9a09dd"),
                            IdChief = new Guid("23dbe38c-0ed4-4e90-8bc7-f168134e8674"),
                            IdMainDep = new Guid("d3c376e4-bce3-4d85-aba4-e3cf49612c94"),
                            Name = "Добрыня",
                            Secname = "Львович",
                            Surname = "Данилов"
                        },
                        new
                        {
                            Id = new Guid("6cbea09e-e3e4-4dd3-a6c5-ed9ccd986bc0"),
                            IdMainDep = new Guid("415b36d9-2d82-4a92-a313-48312f8e18c6"),
                            Name = "Аким",
                            Secname = "Петрович",
                            Surname = "Журавлёв"
                        },
                        new
                        {
                            Id = new Guid("676d8ed4-8307-4196-9776-107c40c1df84"),
                            IdChief = new Guid("7b8219fc-9fd2-431e-985c-7caa6e9bd013"),
                            IdMainDep = new Guid("1ef7268c-43a8-488c-b761-90982b31df4e"),
                            IdSecDep = new Guid("624b3bb5-0f2c-42b6-a416-099aab799546"),
                            Name = "Кристиан",
                            Secname = "Евгеньевич",
                            Surname = "Ерёменко"
                        },
                        new
                        {
                            Id = new Guid("ff559ae5-64b6-459e-9771-cb36130b3b75"),
                            IdChief = new Guid("435eee28-e5ea-4ec9-9f01-de884dfd6292"),
                            IdMainDep = new Guid("1ef7268c-43a8-488c-b761-90982b31df4e"),
                            Name = "Станислав",
                            Secname = "Михайлович",
                            Surname = "Туров"
                        },
                        new
                        {
                            Id = new Guid("1a930de7-647b-4a32-ad3b-0caf4528b356"),
                            IdMainDep = new Guid("8dcc3969-1d93-47a9-8b79-a30c738db9b4"),
                            IdSecDep = new Guid("624b3bb5-0f2c-42b6-a416-099aab799546"),
                            Name = "Абрам",
                            Secname = "Романович",
                            Surname = "Шумейко"
                        },
                        new
                        {
                            Id = new Guid("3618d1d1-32de-40b5-b823-9f82924a3caf"),
                            IdMainDep = new Guid("131ef84b-f06e-494b-848f-bb4bc0604266"),
                            IdSecDep = new Guid("1ef7268c-43a8-488c-b761-90982b31df4e"),
                            Name = "Всеволод",
                            Secname = "Ярославович",
                            Surname = "Бобылёв"
                        },
                        new
                        {
                            Id = new Guid("66034616-24e5-4e90-815f-476eb0cbb6b1"),
                            IdChief = new Guid("fea65ee4-a8a0-425b-8f11-3896c1e2197e"),
                            IdMainDep = new Guid("624b3bb5-0f2c-42b6-a416-099aab799546"),
                            Name = "Антонина",
                            Secname = "Евгеньевна",
                            Surname = "Гурьева"
                        },
                        new
                        {
                            Id = new Guid("c5f771fb-a645-4ba1-8155-f3f5002b2b89"),
                            IdChief = new Guid("8939ed0c-bbdb-435e-923e-68158d2153c6"),
                            IdMainDep = new Guid("415b36d9-2d82-4a92-a313-48312f8e18c6"),
                            IdSecDep = new Guid("1ef7268c-43a8-488c-b761-90982b31df4e"),
                            Name = "Ника",
                            Secname = "Эдуардовна",
                            Surname = "Павлик"
                        },
                        new
                        {
                            Id = new Guid("15f36ecc-ef25-495f-adff-169db3339b88"),
                            IdChief = new Guid("05e31241-7274-43b5-8b59-9a62d725e54f"),
                            IdMainDep = new Guid("8dcc3969-1d93-47a9-8b79-a30c738db9b4"),
                            Name = "Екатерина",
                            Secname = "Дмитриевна",
                            Surname = "Копылова"
                        },
                        new
                        {
                            Id = new Guid("101be2b1-c0af-493e-bbf2-c8d8e4eb826c"),
                            IdChief = new Guid("2b3170c4-3063-43e6-985d-a38d9e45af09"),
                            IdMainDep = new Guid("d2469412-0e4b-46f7-80ec-8c522364d099"),
                            Name = "Нина",
                            Secname = "Платоновна",
                            Surname = "Корнейчук"
                        },
                        new
                        {
                            Id = new Guid("868f6394-3ca3-4700-90bb-6b73ec6719a7"),
                            IdMainDep = new Guid("1ef7268c-43a8-488c-b761-90982b31df4e"),
                            IdSecDep = new Guid("d2469412-0e4b-46f7-80ec-8c522364d099"),
                            Name = "Капитолина",
                            Secname = "Станиславовна",
                            Surname = "Гордеева"
                        },
                        new
                        {
                            Id = new Guid("05e31241-7274-43b5-8b59-9a62d725e54f"),
                            IdChief = new Guid("e1ac29ad-122e-474d-926a-f93ac636f605"),
                            IdMainDep = new Guid("d2469412-0e4b-46f7-80ec-8c522364d099"),
                            Name = "Алёна",
                            Secname = "Александровна",
                            Surname = "Майборода"
                        },
                        new
                        {
                            Id = new Guid("1adc048c-e346-47c3-8c35-7ad4fdaa6eb7"),
                            IdMainDep = new Guid("624b3bb5-0f2c-42b6-a416-099aab799546"),
                            IdSecDep = new Guid("d3c376e4-bce3-4d85-aba4-e3cf49612c94"),
                            Name = "Екатерина",
                            Secname = "Викторовна",
                            Surname = "Шубина"
                        },
                        new
                        {
                            Id = new Guid("435eee28-e5ea-4ec9-9f01-de884dfd6292"),
                            IdMainDep = new Guid("624b3bb5-0f2c-42b6-a416-099aab799546"),
                            IdSecDep = new Guid("1ef7268c-43a8-488c-b761-90982b31df4e"),
                            Name = "Вера",
                            Secname = "Евгеньевна",
                            Surname = "Лазарева"
                        },
                        new
                        {
                            Id = new Guid("0889c51e-7728-4abd-9987-3588d48b54a9"),
                            IdChief = new Guid("542cb2c1-a8e3-42db-97fa-b3c79b12a1a9"),
                            IdMainDep = new Guid("131ef84b-f06e-494b-848f-bb4bc0604266"),
                            IdSecDep = new Guid("8dcc3969-1d93-47a9-8b79-a30c738db9b4"),
                            Name = "Полина",
                            Secname = "Львовна",
                            Surname = "Кобзар"
                        },
                        new
                        {
                            Id = new Guid("46d73a48-3906-44f4-a4b4-e29f1cc40b4f"),
                            IdChief = new Guid("435eee28-e5ea-4ec9-9f01-de884dfd6292"),
                            IdMainDep = new Guid("d3c376e4-bce3-4d85-aba4-e3cf49612c94"),
                            Name = "Инна",
                            Secname = "Эдуардовна",
                            Surname = "Милославска"
                        },
                        new
                        {
                            Id = new Guid("efef5433-7e26-43a3-a737-3bb032d7d88a"),
                            IdChief = new Guid("63531753-4d76-4a93-ad15-c727ffeca6ab"),
                            IdMainDep = new Guid("8dcc3969-1d93-47a9-8b79-a30c738db9b4"),
                            Name = "Нина",
                            Secname = "Михайловна",
                            Surname = "Степанова"
                        },
                        new
                        {
                            Id = new Guid("55ff549e-1489-4b4a-9482-b843cd70c546"),
                            IdMainDep = new Guid("415b36d9-2d82-4a92-a313-48312f8e18c6"),
                            IdSecDep = new Guid("624b3bb5-0f2c-42b6-a416-099aab799546"),
                            Name = "Любовь",
                            Secname = "Ивановна",
                            Surname = "Ялова"
                        },
                        new
                        {
                            Id = new Guid("79679ed4-0ccd-480a-8d5b-4a68287de6c4"),
                            IdChief = new Guid("0b2be83a-7fb4-403b-8ce8-37be257b038c"),
                            IdMainDep = new Guid("624b3bb5-0f2c-42b6-a416-099aab799546"),
                            Name = "Полина",
                            Secname = "Васильевна",
                            Surname = "Макарова"
                        },
                        new
                        {
                            Id = new Guid("29219db8-16a0-4046-a7e1-6e455b0559cd"),
                            IdMainDep = new Guid("131ef84b-f06e-494b-848f-bb4bc0604266"),
                            IdSecDep = new Guid("d2469412-0e4b-46f7-80ec-8c522364d099"),
                            Name = "Альбина",
                            Secname = "Ивановна",
                            Surname = "Дементьева"
                        },
                        new
                        {
                            Id = new Guid("13ded219-a580-4ff8-8211-90a408b0afa6"),
                            IdChief = new Guid("1166ecdd-63c8-42fc-a68a-c292176a7b04"),
                            IdMainDep = new Guid("131ef84b-f06e-494b-848f-bb4bc0604266"),
                            Name = "Ярослава",
                            Secname = "Романовна",
                            Surname = "Егорова"
                        },
                        new
                        {
                            Id = new Guid("2b3170c4-3063-43e6-985d-a38d9e45af09"),
                            IdMainDep = new Guid("131ef84b-f06e-494b-848f-bb4bc0604266"),
                            IdSecDep = new Guid("d3c376e4-bce3-4d85-aba4-e3cf49612c94"),
                            Name = "Ольга",
                            Secname = "Владимировна",
                            Surname = "Коваленко"
                        },
                        new
                        {
                            Id = new Guid("3e229eb8-e99a-455f-8af3-5871337a092c"),
                            IdMainDep = new Guid("131ef84b-f06e-494b-848f-bb4bc0604266"),
                            Name = "Валерия",
                            Secname = "Петровна",
                            Surname = "Белоусова"
                        },
                        new
                        {
                            Id = new Guid("5319fd22-9bde-48e5-819d-fe884b70afd8"),
                            IdChief = new Guid("39d57dfb-8da7-49c9-ae8d-464509618f02"),
                            IdMainDep = new Guid("d2469412-0e4b-46f7-80ec-8c522364d099"),
                            Name = "Ирина",
                            Secname = "Ивановна",
                            Surname = "Бердник"
                        },
                        new
                        {
                            Id = new Guid("8939ed0c-bbdb-435e-923e-68158d2153c6"),
                            IdChief = new Guid("743c93f2-4717-4e81-a093-69903476e176"),
                            IdMainDep = new Guid("415b36d9-2d82-4a92-a313-48312f8e18c6"),
                            Name = "Нелли",
                            Secname = "Ярославовна",
                            Surname = "Красинец"
                        },
                        new
                        {
                            Id = new Guid("663c3142-1c9d-4957-800d-f6c6824b9c88"),
                            IdChief = new Guid("0017aaae-3e22-462d-9031-4276a9788d51"),
                            IdMainDep = new Guid("d3c376e4-bce3-4d85-aba4-e3cf49612c94"),
                            Name = "Флорентина",
                            Secname = "Брониславовна",
                            Surname = "Баранова"
                        },
                        new
                        {
                            Id = new Guid("239450eb-a92f-4093-a74f-eaa38f8adbe2"),
                            IdChief = new Guid("23d52416-d994-4564-a106-1fdf5fecef25"),
                            IdMainDep = new Guid("415b36d9-2d82-4a92-a313-48312f8e18c6"),
                            Name = "Анжелика",
                            Secname = "Борисовна",
                            Surname = "Толочко"
                        },
                        new
                        {
                            Id = new Guid("23dbe38c-0ed4-4e90-8bc7-f168134e8674"),
                            IdChief = new Guid("3e229eb8-e99a-455f-8af3-5871337a092c"),
                            IdMainDep = new Guid("8dcc3969-1d93-47a9-8b79-a30c738db9b4"),
                            IdSecDep = new Guid("415b36d9-2d82-4a92-a313-48312f8e18c6"),
                            Name = "Эльвира",
                            Secname = "Фёдоровна",
                            Surname = "Родионова"
                        },
                        new
                        {
                            Id = new Guid("7a88b1b9-0216-4259-8ba6-c123abb3c6a8"),
                            IdMainDep = new Guid("415b36d9-2d82-4a92-a313-48312f8e18c6"),
                            IdSecDep = new Guid("1ef7268c-43a8-488c-b761-90982b31df4e"),
                            Name = "Инга",
                            Secname = "Артёмовна",
                            Surname = "Трясило"
                        },
                        new
                        {
                            Id = new Guid("789a53ab-a54d-4af7-94a5-dd288428a37c"),
                            IdChief = new Guid("dc268b00-1727-4381-9878-6da1bfef2701"),
                            IdMainDep = new Guid("624b3bb5-0f2c-42b6-a416-099aab799546"),
                            Name = "Клара",
                            Secname = "Даниловна",
                            Surname = "Гуляева"
                        },
                        new
                        {
                            Id = new Guid("a93a1b20-155a-43bd-acee-87a6088c969e"),
                            IdMainDep = new Guid("1ef7268c-43a8-488c-b761-90982b31df4e"),
                            Name = "Марта",
                            Secname = "Борисовна",
                            Surname = "Исаева"
                        },
                        new
                        {
                            Id = new Guid("e56f5de6-a1d3-4c3e-a09a-a9b9fa96c9b3"),
                            IdChief = new Guid("dd860e7e-c2f0-47a6-ba29-165be015e5a2"),
                            IdMainDep = new Guid("624b3bb5-0f2c-42b6-a416-099aab799546"),
                            IdSecDep = new Guid("d2469412-0e4b-46f7-80ec-8c522364d099"),
                            Name = "Зинаида",
                            Secname = "Евгеньевна",
                            Surname = "Одинцова"
                        },
                        new
                        {
                            Id = new Guid("207cdcf2-89ad-49a5-a669-a082fa9cccba"),
                            IdMainDep = new Guid("1ef7268c-43a8-488c-b761-90982b31df4e"),
                            Name = "Флорентина",
                            Secname = "Виталиевна",
                            Surname = "Соловьёва"
                        },
                        new
                        {
                            Id = new Guid("c5ee780a-4d53-40fb-a592-c35cfc9455f2"),
                            IdMainDep = new Guid("8dcc3969-1d93-47a9-8b79-a30c738db9b4"),
                            Name = "Рада",
                            Secname = "Сергеевна",
                            Surname = "Мирна"
                        },
                        new
                        {
                            Id = new Guid("d3fcc76b-09a2-4578-a72c-34468da36c45"),
                            IdChief = new Guid("1a930de7-647b-4a32-ad3b-0caf4528b356"),
                            IdMainDep = new Guid("624b3bb5-0f2c-42b6-a416-099aab799546"),
                            IdSecDep = new Guid("415b36d9-2d82-4a92-a313-48312f8e18c6"),
                            Name = "Мальвина",
                            Secname = "Дмитриевна",
                            Surname = "Одинцова"
                        },
                        new
                        {
                            Id = new Guid("6fb5bca3-2cae-4450-aab5-e0184fd45be9"),
                            IdMainDep = new Guid("415b36d9-2d82-4a92-a313-48312f8e18c6"),
                            Name = "Альбина",
                            Secname = "Викторовна",
                            Surname = "Ткаченко"
                        });
                });

            modelBuilder.Entity("Sales.EfContext.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("da1e17bb-a90d-4c79-b801-5462fb070f57"),
                            Name = "Гвоздь 100мм",
                            Price = 10.5
                        },
                        new
                        {
                            Id = new Guid("a8e6be17-5447-4804-ab61-f31abf5a76d3"),
                            Name = "Шуруп 4х35",
                            Price = 4.25
                        },
                        new
                        {
                            Id = new Guid("21b0f444-2e4f-47d8-80c1-e69bf1c34ca8"),
                            Name = "Гайка М4",
                            Price = 6.5
                        },
                        new
                        {
                            Id = new Guid("2dca5e44-b06d-4613-bb6a-d3bc91430bfe"),
                            Name = "Гровер М4",
                            Price = 5.9900000000000002
                        },
                        new
                        {
                            Id = new Guid("64a4df8a-0733-4be9-aaba-c01b4ec3612a"),
                            Name = "Болт 4х60",
                            Price = 9.9800000000000004
                        },
                        new
                        {
                            Id = new Guid("b6d20749-b495-4b1a-ba1c-80b88e78b7cd"),
                            Name = "Гвоздь 80мм",
                            Price = 19.98
                        },
                        new
                        {
                            Id = new Guid("7b08197b-c55f-4389-891f-bf12a575dffb"),
                            Name = "Отвертка PZ2",
                            Price = 35.5
                        },
                        new
                        {
                            Id = new Guid("870da1a9-44f4-4018-b7fc-727a2058faf0"),
                            Name = "Шуруповерт",
                            Price = 799.0
                        },
                        new
                        {
                            Id = new Guid("8ff90e21-dcdb-4d55-a557-7c6d57dbb029"),
                            Name = "Молоток",
                            Price = 216.5
                        },
                        new
                        {
                            Id = new Guid("f7f1e576-af8d-4749-869e-4a794fe69d42"),
                            Name = "Набор 'Новосел'",
                            Price = 52.399999999999999
                        },
                        new
                        {
                            Id = new Guid("bb29f63d-1261-41f2-89e8-88f44d5ec409"),
                            Name = "Сверло 6х80",
                            Price = 39.979999999999997
                        },
                        new
                        {
                            Id = new Guid("d17a4442-0a71-4673-b450-36929048adef"),
                            Name = "Шуруп 5х45",
                            Price = 5.9800000000000004
                        },
                        new
                        {
                            Id = new Guid("69b125d7-99cc-42d6-a6fa-46687f333749"),
                            Name = "Винт 'потай' 3х16",
                            Price = 3.98
                        },
                        new
                        {
                            Id = new Guid("94bc671a-a6b6-417a-bc9f-8ae4871a58ec"),
                            Name = "Дюбель 6х60",
                            Price = 5.5
                        },
                        new
                        {
                            Id = new Guid("efc6578a-00b7-4766-a7e3-79cdba8c294b"),
                            Name = "Органайзер для шурупов",
                            Price = 199.0
                        },
                        new
                        {
                            Id = new Guid("9654271b-ab52-4225-a30c-d75054b1733f"),
                            Name = "Лазерный дальномер",
                            Price = 1950.0
                        },
                        new
                        {
                            Id = new Guid("f2585221-1aca-4efe-a5e8-c2f4534d1f92"),
                            Name = "Дрель электрическая",
                            Price = 990.0
                        },
                        new
                        {
                            Id = new Guid("4a550d3b-d1f2-40ef-ae4e-963612c6713a"),
                            Name = "Сварочный аппарат",
                            Price = 2099.0
                        },
                        new
                        {
                            Id = new Guid("17db11d1-f50e-4cf4-9c54-cf1bd45802ea"),
                            Name = "Электроды 3мм",
                            Price = 49.979999999999997
                        },
                        new
                        {
                            Id = new Guid("7264d33a-16b9-4e22-b3f1-63d6dae60078"),
                            Name = "Паяльник 40 Вт",
                            Price = 199.97999999999999
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
