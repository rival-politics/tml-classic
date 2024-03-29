﻿// <auto-generated />
using KeklandBankSystem.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace KeklandBankSystem.Migrations
{
    [DbContext(typeof(BankContext))]
    [Migration("20220814160128_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("KeklandBankSystem.Infrastructure.Ads", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CreatorId")
                        .HasColumnType("integer");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("text");

                    b.Property<string>("Url")
                        .HasColumnType("text");

                    b.Property<int>("View")
                        .HasColumnType("integer");

                    b.Property<bool>("isBigger")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("Ads");
                });

            modelBuilder.Entity("KeklandBankSystem.Infrastructure.Articles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<long>("Date")
                        .HasColumnType("bigint");

                    b.Property<string>("HtmlText")
                        .HasColumnType("text");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("text");

                    b.Property<string>("MiniText")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("KeklandBankSystem.Infrastructure.BankTransaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("BankId1")
                        .HasColumnType("integer");

                    b.Property<int>("BankId2")
                        .HasColumnType("integer");

                    b.Property<long>("Date")
                        .HasColumnType("bigint");

                    b.Property<int>("Id1")
                        .HasColumnType("integer");

                    b.Property<int>("Id2")
                        .HasColumnType("integer");

                    b.Property<string>("Text")
                        .HasColumnType("text");

                    b.Property<int>("Value")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("BankTransactions");
                });

            modelBuilder.Entity("KeklandBankSystem.Infrastructure.CasinoWin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<float>("Count")
                        .HasColumnType("real");

                    b.Property<long>("Date")
                        .HasColumnType("bigint");

                    b.Property<int>("WinnerId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("CasinoWins");
                });

            modelBuilder.Entity("KeklandBankSystem.Infrastructure.Deposit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Money")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Deposits");
                });

            modelBuilder.Entity("KeklandBankSystem.Infrastructure.EntityTicketGoverment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("BGUrl")
                        .HasColumnType("text");

                    b.Property<int>("CreatorId")
                        .HasColumnType("integer");

                    b.Property<string>("FlagUrl")
                        .HasColumnType("text");

                    b.Property<string>("Information")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("VKUrl")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("EntityTicketGoverments");
                });

            modelBuilder.Entity("KeklandBankSystem.Infrastructure.EntityTicketInformation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("AdminInformation")
                        .HasColumnType("text");

                    b.Property<long>("Date")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsItemConf")
                        .HasColumnType("boolean");

                    b.Property<string>("Status")
                        .HasColumnType("text");

                    b.Property<string>("Text")
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("EntityTicketInformations");
                });

            modelBuilder.Entity("KeklandBankSystem.Infrastructure.EntityTicketOrganization", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CreatorId")
                        .HasColumnType("integer");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("text");

                    b.Property<string>("Information")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("VKUrl")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("EntityTicketOrganizations");
                });

            modelBuilder.Entity("KeklandBankSystem.Infrastructure.EntityTicketProject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CreatorId")
                        .HasColumnType("integer");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("text");

                    b.Property<string>("Information")
                        .HasColumnType("text");

                    b.Property<string>("ProjectName")
                        .HasColumnType("text");

                    b.Property<int>("Target")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("EntityTicketProjects");
                });

            modelBuilder.Entity("KeklandBankSystem.Infrastructure.GovermentPolitical", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AllOrganizationBalance")
                        .HasColumnType("integer");

                    b.Property<int>("DaysGovermentTaxes")
                        .HasColumnType("integer");

                    b.Property<int>("FreeOrganizationCreateCount")
                        .HasColumnType("integer");

                    b.Property<string>("ImageCoverUrl")
                        .HasColumnType("text");

                    b.Property<string>("ImageFlagUrl")
                        .HasColumnType("text");

                    b.Property<string>("Information")
                        .HasColumnType("text");

                    b.Property<int>("LeaderId")
                        .HasColumnType("integer");

                    b.Property<int>("MainOrganizationGovermentId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("TaxesForOrganization")
                        .HasColumnType("integer");

                    b.Property<string>("VKurl")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Goverments");
                });

            modelBuilder.Entity("KeklandBankSystem.Infrastructure.ImageSystem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("GenerateName")
                        .HasColumnType("text");

                    b.Property<string>("MainPath")
                        .HasColumnType("text");

                    b.Property<string>("ScreePath")
                        .HasColumnType("text");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("ImageSystems");
                });

            modelBuilder.Entity("KeklandBankSystem.Infrastructure.ItemStatistic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("BuyCount")
                        .HasColumnType("integer");

                    b.Property<long>("Date")
                        .HasColumnType("bigint");

                    b.Property<int>("ShopItemId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("ItemStatistics");
                });

            modelBuilder.Entity("KeklandBankSystem.Infrastructure.News", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("MiniInformation")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("Rare")
                        .HasColumnType("integer");

                    b.Property<int>("ShowsDays")
                        .HasColumnType("integer");

                    b.Property<string>("Type")
                        .HasColumnType("text");

                    b.Property<string>("Url")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("News");
                });

            modelBuilder.Entity("KeklandBankSystem.Infrastructure.Organization", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AdminId")
                        .HasColumnType("integer");

                    b.Property<int>("Balance")
                        .HasColumnType("integer");

                    b.Property<int>("GovermentId")
                        .HasColumnType("integer");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("text");

                    b.Property<int>("Influence")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Short_Desc")
                        .HasColumnType("text");

                    b.Property<string>("SpecialId")
                        .HasColumnType("text");

                    b.Property<string>("Status")
                        .HasColumnType("text");

                    b.Property<string>("VkUrl")
                        .HasColumnType("text");

                    b.Property<int>("Zam1Name")
                        .HasColumnType("integer");

                    b.Property<int>("Zam2Name")
                        .HasColumnType("integer");

                    b.Property<bool>("isBuy")
                        .HasColumnType("boolean");

                    b.Property<bool>("isZacrep")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("Organizations");
                });

            modelBuilder.Entity("KeklandBankSystem.Infrastructure.OrgJob", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("OrganizationId")
                        .HasColumnType("integer");

                    b.Property<int>("PayDay")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("OrgJobs");
                });

            modelBuilder.Entity("KeklandBankSystem.Infrastructure.OrgJobUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("OrgJobId")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("OrgJobUser");
                });

            modelBuilder.Entity("KeklandBankSystem.Infrastructure.PassCode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Code")
                        .HasColumnType("text");

                    b.Property<int>("Count")
                        .HasColumnType("integer");

                    b.Property<string>("Type")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("PassCodes");
                });

            modelBuilder.Entity("KeklandBankSystem.Infrastructure.PermissionAdmin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("AddItemUser")
                        .HasColumnType("boolean");

                    b.Property<int>("AdminId")
                        .HasColumnType("integer");

                    b.Property<bool>("ChangeOrganizationEconomy")
                        .HasColumnType("boolean");

                    b.Property<bool>("ChangeOrganizationInfo")
                        .HasColumnType("boolean");

                    b.Property<bool>("ChangeUserDeposit")
                        .HasColumnType("boolean");

                    b.Property<bool>("ChangeUserEconomy")
                        .HasColumnType("boolean");

                    b.Property<bool>("ChangeUserInfo")
                        .HasColumnType("boolean");

                    b.Property<bool>("CheckGoverments")
                        .HasColumnType("boolean");

                    b.Property<bool>("CheckItems")
                        .HasColumnType("boolean");

                    b.Property<bool>("CheckNews")
                        .HasColumnType("boolean");

                    b.Property<bool>("CheckOrganization")
                        .HasColumnType("boolean");

                    b.Property<bool>("CheckProjects")
                        .HasColumnType("boolean");

                    b.Property<bool>("CheckTickets")
                        .HasColumnType("boolean");

                    b.Property<bool>("CreateArticles")
                        .HasColumnType("boolean");

                    b.Property<bool>("CreateGoverment")
                        .HasColumnType("boolean");

                    b.Property<bool>("CreateItemOrg")
                        .HasColumnType("boolean");

                    b.Property<bool>("CreateOrganization")
                        .HasColumnType("boolean");

                    b.Property<bool>("CreateProject")
                        .HasColumnType("boolean");

                    b.Property<bool>("CreatePromoCode")
                        .HasColumnType("boolean");

                    b.Property<bool>("DeleteItem")
                        .HasColumnType("boolean");

                    b.Property<bool>("DeleteOrganization")
                        .HasColumnType("boolean");

                    b.Property<bool>("DeleteTransaction")
                        .HasColumnType("boolean");

                    b.Property<bool>("EconomyPanel")
                        .HasColumnType("boolean");

                    b.Property<bool>("EditGoverment")
                        .HasColumnType("boolean");

                    b.Property<bool>("EditItem")
                        .HasColumnType("boolean");

                    b.Property<bool>("EditZamOrg")
                        .HasColumnType("boolean");

                    b.Property<bool>("GenerateRegCodes")
                        .HasColumnType("boolean");

                    b.Property<bool>("GetStatistics")
                        .HasColumnType("boolean");

                    b.Property<bool>("JobSettings")
                        .HasColumnType("boolean");

                    b.Property<bool>("ShowAdminStatistics")
                        .HasColumnType("boolean");

                    b.Property<bool>("ShowAllOrgOrUserTransaction")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("PermissionAdmins");
                });

            modelBuilder.Entity("KeklandBankSystem.Infrastructure.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("integer");

                    b.Property<int>("Balance")
                        .HasColumnType("integer");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("text");

                    b.Property<string>("Info")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("Target")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("KeklandBankSystem.Infrastructure.ProjectSender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<long>("Date")
                        .HasColumnType("bigint");

                    b.Property<int>("Money")
                        .HasColumnType("integer");

                    b.Property<int>("ProjectId")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("ProjectSenders");
                });

            modelBuilder.Entity("KeklandBankSystem.Infrastructure.RegCode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Code")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("RegCodes");
                });

            modelBuilder.Entity("KeklandBankSystem.Infrastructure.ShopItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("integer");

                    b.Property<int>("CreateNum")
                        .HasColumnType("integer");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("OrgId")
                        .HasColumnType("integer");

                    b.Property<int>("Price")
                        .HasColumnType("integer");

                    b.Property<int>("RarePoint")
                        .HasColumnType("integer");

                    b.Property<int>("RareType")
                        .HasColumnType("integer");

                    b.Property<string>("Short_Desc")
                        .HasColumnType("text");

                    b.Property<string>("Type")
                        .HasColumnType("text");

                    b.Property<int>("Value")
                        .HasColumnType("integer");

                    b.Property<bool>("isActived")
                        .HasColumnType("boolean");

                    b.Property<bool>("isCaseItem")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("ShopItems");
                });

            modelBuilder.Entity("KeklandBankSystem.Infrastructure.ShopItemUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ShopItemId")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<int>("Value")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("ShopItemUser");
                });

            modelBuilder.Entity("KeklandBankSystem.Infrastructure.Statistic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<long>("Date")
                        .HasColumnType("bigint");

                    b.Property<int>("Recd")
                        .HasColumnType("integer");

                    b.Property<int>("Spent")
                        .HasColumnType("integer");

                    b.Property<int>("SpentMoneyAll")
                        .HasColumnType("integer");

                    b.Property<int>("UniqUser")
                        .HasColumnType("integer");

                    b.Property<int>("ViewUser")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Statistics");
                });

            modelBuilder.Entity("KeklandBankSystem.Infrastructure.SystemMain", b =>
                {
                    b.Property<int>("Key")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Key"));

                    b.Property<bool>("CasesIsOn")
                        .HasColumnType("boolean");

                    b.Property<bool>("CasinoIsOn")
                        .HasColumnType("boolean");

                    b.Property<int>("MoneyFromLike")
                        .HasColumnType("integer");

                    b.Property<float>("Nalog_Item")
                        .HasColumnType("real");

                    b.Property<int>("Nalog_Project")
                        .HasColumnType("integer");

                    b.Property<string>("PresidentName")
                        .HasColumnType("text");

                    b.Property<bool>("SiteIsOn")
                        .HasColumnType("boolean");

                    b.Property<int>("Skrutka")
                        .HasColumnType("integer");

                    b.Property<float>("Stavka")
                        .HasColumnType("real");

                    b.Property<float>("Stavka_Nalog")
                        .HasColumnType("real");

                    b.Property<float>("Stavka_Vlojen")
                        .HasColumnType("real");

                    b.Property<int>("UserGetMoneyProject")
                        .HasColumnType("integer");

                    b.HasKey("Key");

                    b.ToTable("SystemMain");
                });

            modelBuilder.Entity("KeklandBankSystem.Infrastructure.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("AdminComment")
                        .HasColumnType("text");

                    b.Property<long>("Date")
                        .HasColumnType("bigint");

                    b.Property<string>("Images")
                        .HasColumnType("text");

                    b.Property<string>("Status")
                        .HasColumnType("text");

                    b.Property<string>("Text")
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<int>("Value")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("KeklandBankSystem.Infrastructure.TradeItemShop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("AddedInformation")
                        .HasColumnType("text");

                    b.Property<int>("Count")
                        .HasColumnType("integer");

                    b.Property<int>("SellerId")
                        .HasColumnType("integer");

                    b.Property<int>("ShopItemId")
                        .HasColumnType("integer");

                    b.Property<int>("newSum")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("TradeItems");
                });

            modelBuilder.Entity("KeklandBankSystem.Infrastructure.Transaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<long>("Date")
                        .HasColumnType("bigint");

                    b.Property<int>("Id1")
                        .HasColumnType("integer");

                    b.Property<int>("Id2")
                        .HasColumnType("integer");

                    b.Property<string>("Text")
                        .HasColumnType("text");

                    b.Property<int>("Value")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("KeklandBankSystem.Infrastructure.UsedPassCode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("PassCodeId")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("UsedPassCodes");
                });

            modelBuilder.Entity("KeklandBankSystem.Infrastructure.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<float>("Coins")
                        .HasColumnType("real");

                    b.Property<bool>("HaveLegendary")
                        .HasColumnType("boolean");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("text");

                    b.Property<bool>("IsArrested")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsUniqView")
                        .HasColumnType("boolean");

                    b.Property<int>("Money")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<bool>("NonViewTrans")
                        .HasColumnType("boolean");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<int>("PremiumDay")
                        .HasColumnType("integer");

                    b.Property<long>("VKUniqId")
                        .HasColumnType("bigint");

                    b.Property<int>("Welfare")
                        .HasColumnType("integer");

                    b.Property<int>("WelfareItem")
                        .HasColumnType("integer");

                    b.Property<int>("newViewEntity")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("KeklandBankSystem.Infrastructure.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("RoleName")
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("KeklandBankSystem.Infrastructure.WeithLevel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("WeithLevel");
                });
#pragma warning restore 612, 618
        }
    }
}
