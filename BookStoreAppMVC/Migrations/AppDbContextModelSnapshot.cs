﻿// <auto-generated />
using BookStoreAppMVC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookStoreAppMVC.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookStoreAppMVC.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 1,
                            Name = "Action"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            Name = "SciFi"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = 3,
                            Name = "History"
                        },
                        new
                        {
                            Id = 4,
                            DisplayOrder = 4,
                            Name = "Fantasy"
                        });
                });

            modelBuilder.Entity("BookStoreAppMVC.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "George R. R. Martin",
                            CategoryId = 4,
                            Description = "Westeros hét királyságát egykor a sárkánykirályok uralták. Vérrel és tűzzel teli uralmuknak Robert Baratheon vetett véget, aki letaszította a Vastrónról az utolsó, őrült Targaryen királyt. Azonban Robertet külső és belső ellenségek fenyegetik, és amikor jobbkeze, a hűséges Jon Arryn váratlanul meghal, legrégebbi barátjához és fegyvertársához, a hideg Északot kormányzó Eddard Starkhoz fordul segítségért. Deres végletekig hűséges, egyenes és merev ura egyedül találja magát a királyi udvarban, ahol senki és semmi sem az, aminek látszik, és egyre erősödik benne a gyanú, hogy Jon Arryn halála nem volt véletlen. Egy kontinenssel arrébb az utolsó sárkányherceg húgát bocsájtja áruba, hogy visszaszerezze a trónt, ám Robert legveszélyesebb ellenségei sokkal közelebb rejtőznek. Miközben az ambiciózus nagyurak és mindenre elszánt trónkövetelők dögkeselyűként köröznek a Vastrón körül, az emberek világát védő Falon túl feltámadnak a hideg szelek, és egy ősi fenyegetés kel újra életre. Westeros hosszú nyara véget érőben van; közeleg a tél. George R. R. Martin elsöprő sikerű könyvsorozata, A tűz és jég dala forradalmasította a fantasy műfaját, és a 21. század egyik legnépszerűbb tévésorozata született belőle.",
                            ISBN = "9789635826414",
                            ImageUrl = "https://www.szukits.hu/storage/images/cache/data/2023.10./tronok_harca_b1_2023-max1920-max1080.jpg",
                            Price = 4799.0,
                            Title = "Trónok harca"
                        },
                        new
                        {
                            Id = 2,
                            Author = "George R. R. Martin",
                            CategoryId = 4,
                            Description = "Westeros földjére ősz borul, az eget kettészelő üstökös vérontást és nyomorúságot jósol. Sárkánykő komor falaitól egészen Deres rideg földjéig seregek gyülekeznek; céljuk a Vastrón és a hét királyság fölötti uralom megszerzése. A Starkok bosszúra szomjaznak, ám a Lannisterek elsöprő vagyonával és haderejével kell szembenézniük, míg a Baratheon-házban fivér fordul fivér ellen. A fegyverek zajától távol több évszázad óta először újra sárkányüvöltés visszhangzik a világban. Daenerys Targaryennek ki kell vezetnie népe maradékát a sivatagból, és meg kell óvnia gyermekeit, a három sárkányfiókát, akik az egész történelem menetét megfordíthatják. Eközben a mindenki által elfeledett és cserben hagyott Éjjeli Őrség maradék erejét összeszedve a Falon túlra indul, hogy szembenézzen a kietlen északi pusztákon rejtőzködő fenyegetéssel; az Őrség ifjú felderítője, Havas Jon útja sötétségbe és hidegbe vezet. George R. R. Martin elsöprő sikerű könyvsorozata, A tűz és jég dala második része a kortárs fantasztikus irodalom egyik csúcsteljesítménye.",
                            ISBN = "9789634478430",
                            ImageUrl = "https://www.szukits.hu/storage/images/cache/data/Kiadok/alexandra/kiralyok_csataja-rate_bg400-rate_bg600.jpg",
                            Price = 3999.0,
                            Title = "Királyok csatája"
                        },
                        new
                        {
                            Id = 3,
                            Author = "George R. R. Martin",
                            CategoryId = 4,
                            Description = "Eső áztatja Westeros felégetett földjét és a temetetlen holtakat. Az öt király háborúja a végéhez közeledik: a megsemmisítő vereséget szenvedett Stannis Baratheon Sárkánykőn várja a kegyelemdöfést, míg a kölyökkirály, Joffrey Baratheon Királyvárban ül diadalt. A minden egyes csatáját megnyerő, ám családja ősi székhelyét elvesztő Ifjú Farkas, Robb Stark Zúgóban gyűjti az erejét, miközben a többi Stark gyermek a szélrózsa minden irányába szétszóródva próbálja túlélni a káoszt és a pusztítást. Messze Északon a Falat évezredek óta nem látott veszély fenyegeti, ám az elfoglalására induló vadak seregét egy még halálosabb ellenség űzi az üvöltő hóviharban. A testvéreitől elszakadt Havas Jonnak választania kell a kötelesség és a boldogság között, és döntése egész Észak sorsát megpecsételheti. A Sárkányok Anyja vér és homok között tör előre jussa, a Vastrón felé, útja azonban váratlan kitérőkkel és áldozatokkal teli. Sárkányai révén élet és halál ura, ám sokkal könnyebb halált osztani, mint életet adni. George R. R. Martin elsöprő sikerű könyvsorozata, A tűz és jég dala harmadik része egy percre sem engedi fellélegezni olvasóját; kíméletlen, megdöbbentő fordulatokkal és csúcspontokkal teli, letehetetlen olvasmány.",
                            ISBN = "9789634478461",
                            ImageUrl = "https://www.szukits.hu/storage/images/cache/data/Kiadok/alexandra/kardok-vihara-b-rate_bg400-rate_bg600.jpg",
                            Price = 4499.0,
                            Title = "Kardok vihara"
                        },
                        new
                        {
                            Id = 4,
                            Author = "George R. R. Martin",
                            CategoryId = 4,
                            Description = "Csalóka béke honol Westeros sokat szenvedett földjén. A Lannister-ház minden ellenlábasát szétzúzta, ám a győzelemért szörnyű árat fizetett. A gyásztól csak még elszántabbá és ádázabbá váló Cersei uralma ingatag. Az anyakirálynő mindenhol ellenséget lát, és már élete egyetlen biztos pontjában, ikertestvérében és szerelmében sem bízik. A meggyengült Lannisterek körül ragadozók köröznek: a vasemberek Westeros partjait dúlják, míg Dorne hercege egyre közelebb jut lassan két évtizede dédelgetett bosszúvágya beteljesítéséhez. Samwell Tarly a Fal ifjú parancsnoka utasítására Óvárosba indul, hogy elnyerje a mesterek láncát. A Fellegvár azonban rengeteg veszélyes titkot őriz: köztük talán a Mások legyőzésének kulcsát... és a sárkányok rejtélyes kipusztulásának okát. Tarth-i Brienne az eltűnt Stark sarjak nyomába ered, ám Folyóvidék romjai között nála veszélyesebb vadászok leselkednek. Eközben Westeros kikötőiben a tengerészek a sárkánykirálynőről és három sárkányáról regélnek... George R. R. Martin elsöprő sikerű könyvsorozata, A tűz és jég dala negyedik része újra a hatalmasok könyörtelen játszmájába veti az olvasót, ahol csak győzelem és halál létezik.",
                            ISBN = "9789634478492",
                            ImageUrl = "https://www.szukits.hu/storage/images/cache/data/Kiadok/alexandra/varjak_lakomaja-max1920-max1080.jpg",
                            Price = 3999.0,
                            Title = "Varjak lakomája"
                        },
                        new
                        {
                            Id = 5,
                            Author = "George R. R. Martin",
                            CategoryId = 4,
                            Description = "Közeleg a tél. A hideg szelek feltámadtak a sokat szenvedett Hét Királyságban, ahol az öt király háborúja után a túlélőknek most az éhínséggel kell szembenézniük. Az emberek birodalmát védelmező Fal ifjú parancsnoka, Havas Jon a Mások elleni reménytelen küzdelemre készíti fel a szétzüllött Éjjeli Őrséget, ám rá kell döbbennie, hogy ellenségei jóval közelebb vannak hozzá, mint gondolná. Stannis Baratheon Észak uralmáért vív elkeseredett harcot a Boltonokkal, miközben Királyvárban a Lannister-ház próbálja megerősíteni Tommen, a gyermekkirály törékeny uralmát a kivérzett Hét Királyság fölött. A Keskeny-tenger másik oldalán Tyrion Lannister, a megvetett és üldözött rokongyilkos sárkányvadászatra indul, ám útja veszélyekkel és váratlan kitérőkkel teli. A világ eközben az ősi városra, Meereenre figyel, ahol Viharbanszületett Daeneryst, Westeros jog szerinti uralkodóját minden oldalról ellenségei szorongatják. Hogy arathat diadalt a Sárkányok Anyja, ha három gyermekére sem számíthat? A végkifejlet csak tűz és vér lehet, ám ki éli túl a sárkányok táncát? George R. R. Martin elsöprő sikerű könyvsorozata, A tűz és jég dala ötödik része szinte mindegyik oldala új fordulatokat, titkokat és drámai összecsapásokat tartogat.",
                            ISBN = "9789634478522",
                            ImageUrl = "https://www.szukits.hu/storage/images/cache/data/Kiadok/alexandra/sarkanyok-tanca-max1920-max1080.jpg",
                            Price = 3999.0,
                            Title = "Sárkányok tánca"
                        });
                });

            modelBuilder.Entity("BookStoreAppMVC.Models.Product", b =>
                {
                    b.HasOne("BookStoreAppMVC.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
