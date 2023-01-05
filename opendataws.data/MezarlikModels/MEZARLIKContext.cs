using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace opendataws.data.MezarlikModels
{
    public partial class MEZARLIKContext : DbContext
    {
        public MEZARLIKContext()
        {
        }

        public MEZARLIKContext(DbContextOptions<MEZARLIKContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AileMezarlik> AileMezarliks { get; set; } = null!;
        public virtual DbSet<Duyurular> Duyurulars { get; set; } = null!;
        public virtual DbSet<EPostaAyarlari> EPostaAyarlaris { get; set; } = null!;
        public virtual DbSet<EskiKayitlar> EskiKayitlars { get; set; } = null!;
        public virtual DbSet<EskiKayitlar03072017> EskiKayitlar03072017s { get; set; } = null!;
        public virtual DbSet<EskiKayitlar16052017> EskiKayitlar16052017s { get; set; } = null!;
        public virtual DbSet<EskiKayitlar22072019> EskiKayitlar22072019s { get; set; } = null!;
        public virtual DbSet<Ilceler> Ilcelers { get; set; } = null!;
        public virtual DbSet<Iller> Illers { get; set; } = null!;
        public virtual DbSet<KisiYakinlari> KisiYakinlaris { get; set; } = null!;
        public virtual DbSet<Kisiler> Kisilers { get; set; } = null!;
        public virtual DbSet<Kolonlar> Kolonlars { get; set; } = null!;
        public virtual DbSet<Kullanicilar> Kullanicilars { get; set; } = null!;
        public virtual DbSet<Mahalleler> Mahallelers { get; set; } = null!;
        public virtual DbSet<MenuYetki> MenuYetkis { get; set; } = null!;
        public virtual DbSet<Menuler> Menulers { get; set; } = null!;
        public virtual DbSet<MezarlikDeneme21092121> MezarlikDeneme21092121s { get; set; } = null!;
        public virtual DbSet<MezarlikYetki> MezarlikYetkis { get; set; } = null!;
        public virtual DbSet<Mezarliklar> Mezarliklars { get; set; } = null!;
        public virtual DbSet<ObsAktarim> ObsAktarims { get; set; } = null!;
        public virtual DbSet<ObsHaritum> ObsHarita { get; set; } = null!;
        public virtual DbSet<OlumSebepleri> OlumSebepleris { get; set; } = null!;
        public virtual DbSet<OnayKaldirmaNedenleri> OnayKaldirmaNedenleris { get; set; } = null!;
        public virtual DbSet<PostaGonderimListesi> PostaGonderimListesis { get; set; } = null!;
        public virtual DbSet<TaziyeEviPlanlama> TaziyeEviPlanlamas { get; set; } = null!;
        public virtual DbSet<TaziyeEvleri> TaziyeEvleris { get; set; } = null!;
        public virtual DbSet<TekilMezarlik> TekilMezarliks { get; set; } = null!;
        public virtual DbSet<TestView> TestViews { get; set; } = null!;
        public virtual DbSet<TumKayitlarView> TumKayitlarViews { get; set; } = null!;
        public virtual DbSet<TumKayitlarYeniView> TumKayitlarYeniViews { get; set; } = null!;
        public virtual DbSet<Ulkeler> Ulkelers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=10.1.1.27;Database=MEZARLIK;User Id=sa;Password=[msm5141];");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("Turkish_CI_AS");

            modelBuilder.Entity<AileMezarlik>(entity =>
            {
                entity.ToTable("AILE_MEZARLIK");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(500)
                    .HasColumnName("ACIKLAMA");

                entity.Property(e => e.Ada)
                    .HasMaxLength(4)
                    .HasColumnName("ADA");

                entity.Property(e => e.Adet).HasColumnName("ADET");

                entity.Property(e => e.Adi)
                    .HasMaxLength(50)
                    .HasColumnName("ADI");

                entity.Property(e => e.Aktif)
                    .HasColumnName("AKTIF")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Bedeli)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("BEDELI");

                entity.Property(e => e.Cadde)
                    .HasMaxLength(50)
                    .HasColumnName("CADDE");

                entity.Property(e => e.DefinSayisi)
                    .HasColumnName("DEFIN_SAYISI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DogumTarihi)
                    .HasColumnType("date")
                    .HasColumnName("DOGUM_TARIHI");

                entity.Property(e => e.Dolu)
                    .HasColumnName("DOLU")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EklemeTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("EKLEME_TARIHI");

                entity.Property(e => e.Ekleyen).HasColumnName("EKLEYEN");

                entity.Property(e => e.EskiId).HasColumnName("ESKI_ID");

                entity.Property(e => e.Gecit)
                    .HasMaxLength(50)
                    .HasColumnName("GECIT");

                entity.Property(e => e.GuncellemeTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("GUNCELLEME_TARIHI");

                entity.Property(e => e.Guncelleyen).HasColumnName("GUNCELLEYEN");

                entity.Property(e => e.IslemCinsi)
                    .HasMaxLength(25)
                    .HasColumnName("ISLEM_CINSI");

                entity.Property(e => e.IslemNo)
                    .HasMaxLength(2)
                    .HasColumnName("ISLEM_NO");

                entity.Property(e => e.Latlng1)
                    .HasMaxLength(50)
                    .HasColumnName("LATLNG1");

                entity.Property(e => e.Latlng2)
                    .HasMaxLength(50)
                    .HasColumnName("LATLNG2");

                entity.Property(e => e.Latlng3)
                    .HasMaxLength(50)
                    .HasColumnName("LATLNG3");

                entity.Property(e => e.Latlng4)
                    .HasMaxLength(50)
                    .HasColumnName("LATLNG4");

                entity.Property(e => e.Mahalle)
                    .HasMaxLength(100)
                    .HasColumnName("MAHALLE");

                entity.Property(e => e.MakbuzNo)
                    .HasMaxLength(20)
                    .HasColumnName("MAKBUZ_NO");

                entity.Property(e => e.MakbuzTarihi)
                    .HasColumnType("date")
                    .HasColumnName("MAKBUZ_TARIHI");

                entity.Property(e => e.MezarliklarId).HasColumnName("MEZARLIKLAR_ID");

                entity.Property(e => e.Path)
                    .HasMaxLength(5)
                    .HasColumnName("PATH");

                entity.Property(e => e.SiraNo).HasColumnName("SIRA_NO");

                entity.Property(e => e.Soyadi)
                    .HasMaxLength(50)
                    .HasColumnName("SOYADI");

                entity.Property(e => e.TcKimlikNo)
                    .HasMaxLength(20)
                    .HasColumnName("TC_KIMLIK_NO");

                entity.Property(e => e.Telefon)
                    .HasMaxLength(20)
                    .HasColumnName("TELEFON");

                entity.Property(e => e.Ucretsiz)
                    .HasColumnName("UCRETSIZ")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Mezarliklar)
                    .WithMany(p => p.AileMezarliks)
                    .HasForeignKey(d => d.MezarliklarId)
                    .HasConstraintName("FK_AILE_MEZARLIK_MEZARLIKLAR");
            });

            modelBuilder.Entity<Duyurular>(entity =>
            {
                entity.ToTable("DUYURULAR");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Aktif)
                    .HasColumnName("AKTIF")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Baslik)
                    .HasMaxLength(150)
                    .HasColumnName("BASLIK");

                entity.Property(e => e.EklemeTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("EKLEME_TARIHI");

                entity.Property(e => e.Ekleyen).HasColumnName("EKLEYEN");

                entity.Property(e => e.GuncellemeTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("GUNCELLEME_TARIHI");

                entity.Property(e => e.Guncelleyen).HasColumnName("GUNCELLEYEN");

                entity.Property(e => e.Icerik).HasColumnName("ICERIK");

                entity.Property(e => e.YayinlanmaTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("YAYINLANMA_TARIHI");
            });

            modelBuilder.Entity<EPostaAyarlari>(entity =>
            {
                entity.ToTable("E_POSTA_AYARLARI");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Aktif).HasColumnName("AKTIF");

                entity.Property(e => e.EklemeTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("EKLEME_TARIHI");

                entity.Property(e => e.Ekleyen).HasColumnName("EKLEYEN");

                entity.Property(e => e.Eposta)
                    .HasMaxLength(250)
                    .HasColumnName("EPOSTA")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.GuncellemeTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("GUNCELLEME_TARIHI");

                entity.Property(e => e.Guncelleyen).HasColumnName("GUNCELLEYEN");

                entity.Property(e => e.Parola)
                    .HasMaxLength(150)
                    .HasColumnName("PAROLA")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Port).HasColumnName("PORT");

                entity.Property(e => e.SmtpAdres)
                    .HasMaxLength(150)
                    .HasColumnName("SMTP_ADRES")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Ssl).HasColumnName("SSL");
            });

            modelBuilder.Entity<EskiKayitlar>(entity =>
            {
                entity.ToTable("ESKI_KAYITLAR");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(500)
                    .HasColumnName("ACIKLAMA");

                entity.Property(e => e.AdaNo)
                    .HasMaxLength(50)
                    .HasColumnName("ADA_NO");

                entity.Property(e => e.Adi)
                    .HasMaxLength(50)
                    .HasColumnName("ADI");

                entity.Property(e => e.AileMezarNo)
                    .HasMaxLength(10)
                    .HasColumnName("AILE_MEZAR_NO");

                entity.Property(e => e.AileSiraNo)
                    .HasMaxLength(50)
                    .HasColumnName("AILE_SIRA_NO");

                entity.Property(e => e.Aktif).HasColumnName("AKTIF");

                entity.Property(e => e.AnaAdi)
                    .HasMaxLength(50)
                    .HasColumnName("ANA_ADI");

                entity.Property(e => e.BabaAdi)
                    .HasMaxLength(50)
                    .HasColumnName("BABA_ADI");

                entity.Property(e => e.BildirimAdi)
                    .HasMaxLength(50)
                    .HasColumnName("BILDIRIM_ADI");

                entity.Property(e => e.BildirimAdres)
                    .HasMaxLength(500)
                    .HasColumnName("BILDIRIM_ADRES");

                entity.Property(e => e.BildirimDogumTarihi)
                    .HasMaxLength(50)
                    .HasColumnName("BILDIRIM_DOGUM_TARIHI");

                entity.Property(e => e.BildirimSoyadi)
                    .HasMaxLength(50)
                    .HasColumnName("BILDIRIM_SOYADI");

                entity.Property(e => e.BildirimTcKimlikNo)
                    .HasMaxLength(50)
                    .HasColumnName("BILDIRIM_TC_KIMLIK_NO");

                entity.Property(e => e.BildirimTelefonu)
                    .HasMaxLength(50)
                    .HasColumnName("BILDIRIM_TELEFONU");

                entity.Property(e => e.BireySiraNo)
                    .HasMaxLength(50)
                    .HasColumnName("BIREY_SIRA_NO");

                entity.Property(e => e.CiltNo)
                    .HasMaxLength(50)
                    .HasColumnName("CILT_NO");

                entity.Property(e => e.Cinsiyet)
                    .HasMaxLength(15)
                    .HasColumnName("CINSIYET");

                entity.Property(e => e.Din)
                    .HasMaxLength(50)
                    .HasColumnName("DIN");

                entity.Property(e => e.DogumTarihi)
                    .HasMaxLength(15)
                    .HasColumnName("DOGUM_TARIHI");

                entity.Property(e => e.DogumTarihiYaziIle)
                    .HasMaxLength(50)
                    .HasColumnName("DOGUM_TARIHI_YAZI_ILE");

                entity.Property(e => e.DogumYeri)
                    .HasMaxLength(50)
                    .HasColumnName("DOGUM_YERI");

                entity.Property(e => e.EklemeTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("EKLEME_TARIHI");

                entity.Property(e => e.Ekleyen).HasColumnName("EKLEYEN");

                entity.Property(e => e.GuncellemeTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("GUNCELLEME_TARIHI");

                entity.Property(e => e.Guncelleyen).HasColumnName("GUNCELLEYEN");

                entity.Property(e => e.Hatasiz).HasColumnName("HATASIZ");

                entity.Property(e => e.HekimAdi)
                    .HasMaxLength(100)
                    .HasColumnName("HEKIM_ADI");

                entity.Property(e => e.IslemYapilanMezarlik)
                    .HasMaxLength(50)
                    .HasColumnName("ISLEM_YAPILAN_MEZARLIK");

                entity.Property(e => e.KurumAdi)
                    .HasMaxLength(500)
                    .HasColumnName("KURUM_ADI");

                entity.Property(e => e.Latlng1)
                    .HasMaxLength(50)
                    .HasColumnName("LATLNG1");

                entity.Property(e => e.Latlng2)
                    .HasMaxLength(50)
                    .HasColumnName("LATLNG2");

                entity.Property(e => e.Latlng3)
                    .HasMaxLength(50)
                    .HasColumnName("LATLNG3");

                entity.Property(e => e.Latlng4)
                    .HasMaxLength(50)
                    .HasColumnName("LATLNG4");

                entity.Property(e => e.Mahallesi)
                    .HasMaxLength(150)
                    .HasColumnName("MAHALLESI");

                entity.Property(e => e.MakbuzNo)
                    .HasMaxLength(50)
                    .HasColumnName("MAKBUZ_NO");

                entity.Property(e => e.MakbuzTarihi)
                    .HasMaxLength(15)
                    .HasColumnName("MAKBUZ_TARIHI");

                entity.Property(e => e.MedeniHal)
                    .HasMaxLength(50)
                    .HasColumnName("MEDENI_HAL");

                entity.Property(e => e.MezarliklarId).HasColumnName("MEZARLIKLAR_ID");

                entity.Property(e => e.NufusIlce)
                    .HasMaxLength(50)
                    .HasColumnName("NUFUS_ILCE");

                entity.Property(e => e.NufusIlceKodu)
                    .HasMaxLength(4)
                    .HasColumnName("NUFUS_ILCE_KODU");

                entity.Property(e => e.NufusMahalle)
                    .HasMaxLength(50)
                    .HasColumnName("NUFUS_MAHALLE");

                entity.Property(e => e.OlumSebebi)
                    .HasMaxLength(150)
                    .HasColumnName("OLUM_SEBEBI");

                entity.Property(e => e.OlumTarihi)
                    .HasMaxLength(15)
                    .HasColumnName("OLUM_TARIHI");

                entity.Property(e => e.OlumTarihiYaziIle)
                    .HasMaxLength(50)
                    .HasColumnName("OLUM_TARIHI_YAZI_ILE");

                entity.Property(e => e.OlumYeri)
                    .HasMaxLength(50)
                    .HasColumnName("OLUM_YERI");

                entity.Property(e => e.Parsel)
                    .HasMaxLength(50)
                    .HasColumnName("PARSEL");

                entity.Property(e => e.RuhsatNo)
                    .HasMaxLength(50)
                    .HasColumnName("RUHSAT_NO");

                entity.Property(e => e.RuhsatTarihi)
                    .HasMaxLength(15)
                    .HasColumnName("RUHSAT_TARIHI");

                entity.Property(e => e.SiraNo)
                    .HasMaxLength(50)
                    .HasColumnName("SIRA_NO");

                entity.Property(e => e.Soyadi)
                    .HasMaxLength(50)
                    .HasColumnName("SOYADI");

                entity.Property(e => e.TcKimlikNo)
                    .HasMaxLength(11)
                    .HasColumnName("TC_KIMLIK_NO");

                entity.Property(e => e.Telefon)
                    .HasMaxLength(15)
                    .HasColumnName("TELEFON");

                entity.Property(e => e.TutanagiDuzenleyeninAdi)
                    .HasMaxLength(50)
                    .HasColumnName("TUTANAGI_DUZENLEYENIN_ADI");

                entity.Property(e => e.TutanagiDuzenleyeninSoyadi)
                    .HasMaxLength(50)
                    .HasColumnName("TUTANAGI_DUZENLEYENIN_SOYADI");

                entity.Property(e => e.TutanagiDuzenleyeninUnvani)
                    .HasMaxLength(50)
                    .HasColumnName("TUTANAGI_DUZENLEYENIN_UNVANI");

                entity.Property(e => e.TutanakOlusturuldu)
                    .HasColumnName("TUTANAK_OLUSTURULDU")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UmumiSiraNo)
                    .HasMaxLength(50)
                    .HasColumnName("UMUMI_SIRA_NO");

                entity.Property(e => e.Yol)
                    .HasMaxLength(50)
                    .HasColumnName("YOL");
            });

            modelBuilder.Entity<EskiKayitlar03072017>(entity =>
            {
                entity.ToTable("ESKI_KAYITLAR_03072017");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(500)
                    .HasColumnName("ACIKLAMA");

                entity.Property(e => e.AdaNo)
                    .HasMaxLength(50)
                    .HasColumnName("ADA_NO");

                entity.Property(e => e.Adi)
                    .HasMaxLength(50)
                    .HasColumnName("ADI");

                entity.Property(e => e.AileMezarNo)
                    .HasMaxLength(10)
                    .HasColumnName("AILE_MEZAR_NO");

                entity.Property(e => e.Aktif).HasColumnName("AKTIF");

                entity.Property(e => e.AnaAdi)
                    .HasMaxLength(50)
                    .HasColumnName("ANA_ADI");

                entity.Property(e => e.BabaAdi)
                    .HasMaxLength(50)
                    .HasColumnName("BABA_ADI");

                entity.Property(e => e.Cinsiyet)
                    .HasMaxLength(15)
                    .HasColumnName("CINSIYET");

                entity.Property(e => e.DogumTarihi)
                    .HasMaxLength(15)
                    .HasColumnName("DOGUM_TARIHI");

                entity.Property(e => e.EklemeTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("EKLEME_TARIHI");

                entity.Property(e => e.Ekleyen).HasColumnName("EKLEYEN");

                entity.Property(e => e.GuncellemeTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("GUNCELLEME_TARIHI");

                entity.Property(e => e.Guncelleyen).HasColumnName("GUNCELLEYEN");

                entity.Property(e => e.Hatasiz).HasColumnName("HATASIZ");

                entity.Property(e => e.HekimAdi)
                    .HasMaxLength(100)
                    .HasColumnName("HEKIM_ADI");

                entity.Property(e => e.KurumAdi)
                    .HasMaxLength(500)
                    .HasColumnName("KURUM_ADI");

                entity.Property(e => e.Mahallesi)
                    .HasMaxLength(150)
                    .HasColumnName("MAHALLESI");

                entity.Property(e => e.MakbuzNo)
                    .HasMaxLength(50)
                    .HasColumnName("MAKBUZ_NO");

                entity.Property(e => e.MakbuzTarihi)
                    .HasMaxLength(15)
                    .HasColumnName("MAKBUZ_TARIHI");

                entity.Property(e => e.MezarliklarId).HasColumnName("MEZARLIKLAR_ID");

                entity.Property(e => e.OlumSebebi)
                    .HasMaxLength(150)
                    .HasColumnName("OLUM_SEBEBI");

                entity.Property(e => e.OlumTarihi)
                    .HasColumnType("date")
                    .HasColumnName("OLUM_TARIHI");

                entity.Property(e => e.Parsel)
                    .HasMaxLength(50)
                    .HasColumnName("PARSEL");

                entity.Property(e => e.RuhsatNo)
                    .HasMaxLength(50)
                    .HasColumnName("RUHSAT_NO");

                entity.Property(e => e.RuhsatTarihi)
                    .HasMaxLength(15)
                    .HasColumnName("RUHSAT_TARIHI");

                entity.Property(e => e.SiraNo)
                    .HasMaxLength(50)
                    .HasColumnName("SIRA_NO");

                entity.Property(e => e.Soyadi)
                    .HasMaxLength(50)
                    .HasColumnName("SOYADI");

                entity.Property(e => e.Telefon)
                    .HasMaxLength(15)
                    .HasColumnName("TELEFON");

                entity.Property(e => e.UmumiSiraNo)
                    .HasMaxLength(50)
                    .HasColumnName("UMUMI_SIRA_NO");

                entity.Property(e => e.Yol)
                    .HasMaxLength(50)
                    .HasColumnName("YOL");
            });

            modelBuilder.Entity<EskiKayitlar16052017>(entity =>
            {
                entity.ToTable("ESKI_KAYITLAR_16052017");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(500)
                    .HasColumnName("ACIKLAMA")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.AdaNo)
                    .HasMaxLength(50)
                    .HasColumnName("ADA_NO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Adi)
                    .HasMaxLength(50)
                    .HasColumnName("ADI");

                entity.Property(e => e.AileMezarNo)
                    .HasMaxLength(10)
                    .HasColumnName("AILE_MEZAR_NO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Aktif)
                    .HasColumnName("AKTIF")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AnaAdi)
                    .HasMaxLength(50)
                    .HasColumnName("ANA_ADI");

                entity.Property(e => e.BabaAdi)
                    .HasMaxLength(50)
                    .HasColumnName("BABA_ADI");

                entity.Property(e => e.Cinsiyet)
                    .HasMaxLength(15)
                    .HasColumnName("CINSIYET");

                entity.Property(e => e.DogumTarihi)
                    .HasMaxLength(15)
                    .HasColumnName("DOGUM_TARIHI")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Hatasiz).HasColumnName("HATASIZ");

                entity.Property(e => e.HekimAdi)
                    .HasMaxLength(100)
                    .HasColumnName("HEKIM_ADI")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.KurumAdi)
                    .HasMaxLength(500)
                    .HasColumnName("KURUM_ADI")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Mahallesi)
                    .HasMaxLength(150)
                    .HasColumnName("MAHALLESI")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.MakbuzNo)
                    .HasMaxLength(50)
                    .HasColumnName("MAKBUZ_NO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.MakbuzTarihi)
                    .HasMaxLength(15)
                    .HasColumnName("MAKBUZ_TARIHI")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.MezarliklarId).HasColumnName("MEZARLIKLAR_ID");

                entity.Property(e => e.OlumSebebi)
                    .HasMaxLength(150)
                    .HasColumnName("OLUM_SEBEBI")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.OlumTarihi)
                    .HasMaxLength(15)
                    .HasColumnName("OLUM_TARIHI")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Parsel)
                    .HasMaxLength(50)
                    .HasColumnName("PARSEL")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RuhsatNo)
                    .HasMaxLength(50)
                    .HasColumnName("RUHSAT_NO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RuhsatTarihi)
                    .HasMaxLength(15)
                    .HasColumnName("RUHSAT_TARIHI")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.SiraNo)
                    .HasMaxLength(50)
                    .HasColumnName("SIRA_NO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Soyadi)
                    .HasMaxLength(50)
                    .HasColumnName("SOYADI");

                entity.Property(e => e.Telefon)
                    .HasMaxLength(15)
                    .HasColumnName("TELEFON")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UmumiSiraNo)
                    .HasMaxLength(50)
                    .HasColumnName("UMUMI_SIRA_NO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Yol)
                    .HasMaxLength(50)
                    .HasColumnName("YOL")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<EskiKayitlar22072019>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESKI_KAYITLAR_22072019");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(500)
                    .HasColumnName("ACIKLAMA");

                entity.Property(e => e.AdaNo)
                    .HasMaxLength(50)
                    .HasColumnName("ADA_NO");

                entity.Property(e => e.Adi)
                    .HasMaxLength(50)
                    .HasColumnName("ADI");

                entity.Property(e => e.AileMezarNo)
                    .HasMaxLength(10)
                    .HasColumnName("AILE_MEZAR_NO");

                entity.Property(e => e.AileSiraNo)
                    .HasMaxLength(50)
                    .HasColumnName("AILE_SIRA_NO");

                entity.Property(e => e.Aktif).HasColumnName("AKTIF");

                entity.Property(e => e.AnaAdi)
                    .HasMaxLength(50)
                    .HasColumnName("ANA_ADI");

                entity.Property(e => e.BabaAdi)
                    .HasMaxLength(50)
                    .HasColumnName("BABA_ADI");

                entity.Property(e => e.BildirimAdi)
                    .HasMaxLength(50)
                    .HasColumnName("BILDIRIM_ADI");

                entity.Property(e => e.BildirimAdres)
                    .HasMaxLength(500)
                    .HasColumnName("BILDIRIM_ADRES");

                entity.Property(e => e.BildirimDogumTarihi)
                    .HasMaxLength(50)
                    .HasColumnName("BILDIRIM_DOGUM_TARIHI");

                entity.Property(e => e.BildirimSoyadi)
                    .HasMaxLength(50)
                    .HasColumnName("BILDIRIM_SOYADI");

                entity.Property(e => e.BildirimTcKimlikNo)
                    .HasMaxLength(50)
                    .HasColumnName("BILDIRIM_TC_KIMLIK_NO");

                entity.Property(e => e.BildirimTelefonu)
                    .HasMaxLength(50)
                    .HasColumnName("BILDIRIM_TELEFONU");

                entity.Property(e => e.BireySiraNo)
                    .HasMaxLength(50)
                    .HasColumnName("BIREY_SIRA_NO");

                entity.Property(e => e.CiltNo)
                    .HasMaxLength(50)
                    .HasColumnName("CILT_NO");

                entity.Property(e => e.Cinsiyet)
                    .HasMaxLength(15)
                    .HasColumnName("CINSIYET");

                entity.Property(e => e.Din)
                    .HasMaxLength(50)
                    .HasColumnName("DIN");

                entity.Property(e => e.DogumTarihi)
                    .HasMaxLength(15)
                    .HasColumnName("DOGUM_TARIHI");

                entity.Property(e => e.DogumTarihiYaziIle)
                    .HasMaxLength(50)
                    .HasColumnName("DOGUM_TARIHI_YAZI_ILE");

                entity.Property(e => e.DogumYeri)
                    .HasMaxLength(50)
                    .HasColumnName("DOGUM_YERI");

                entity.Property(e => e.EklemeTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("EKLEME_TARIHI");

                entity.Property(e => e.Ekleyen).HasColumnName("EKLEYEN");

                entity.Property(e => e.GuncellemeTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("GUNCELLEME_TARIHI");

                entity.Property(e => e.Guncelleyen).HasColumnName("GUNCELLEYEN");

                entity.Property(e => e.Hatasiz).HasColumnName("HATASIZ");

                entity.Property(e => e.HekimAdi)
                    .HasMaxLength(100)
                    .HasColumnName("HEKIM_ADI");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.IslemYapilanMezarlik)
                    .HasMaxLength(50)
                    .HasColumnName("ISLEM_YAPILAN_MEZARLIK");

                entity.Property(e => e.KurumAdi)
                    .HasMaxLength(500)
                    .HasColumnName("KURUM_ADI");

                entity.Property(e => e.Mahallesi)
                    .HasMaxLength(150)
                    .HasColumnName("MAHALLESI");

                entity.Property(e => e.MakbuzNo)
                    .HasMaxLength(50)
                    .HasColumnName("MAKBUZ_NO");

                entity.Property(e => e.MakbuzTarihi)
                    .HasMaxLength(15)
                    .HasColumnName("MAKBUZ_TARIHI");

                entity.Property(e => e.MedeniHal)
                    .HasMaxLength(50)
                    .HasColumnName("MEDENI_HAL");

                entity.Property(e => e.MezarliklarId).HasColumnName("MEZARLIKLAR_ID");

                entity.Property(e => e.NufusIlce)
                    .HasMaxLength(50)
                    .HasColumnName("NUFUS_ILCE");

                entity.Property(e => e.NufusIlceKodu)
                    .HasMaxLength(4)
                    .HasColumnName("NUFUS_ILCE_KODU");

                entity.Property(e => e.NufusMahalle)
                    .HasMaxLength(50)
                    .HasColumnName("NUFUS_MAHALLE");

                entity.Property(e => e.OlumSebebi)
                    .HasMaxLength(150)
                    .HasColumnName("OLUM_SEBEBI");

                entity.Property(e => e.OlumTarihi)
                    .HasMaxLength(15)
                    .HasColumnName("OLUM_TARIHI");

                entity.Property(e => e.OlumTarihiYaziIle)
                    .HasMaxLength(50)
                    .HasColumnName("OLUM_TARIHI_YAZI_ILE");

                entity.Property(e => e.OlumYeri)
                    .HasMaxLength(50)
                    .HasColumnName("OLUM_YERI");

                entity.Property(e => e.Parsel)
                    .HasMaxLength(50)
                    .HasColumnName("PARSEL");

                entity.Property(e => e.RuhsatNo)
                    .HasMaxLength(50)
                    .HasColumnName("RUHSAT_NO");

                entity.Property(e => e.RuhsatTarihi)
                    .HasMaxLength(15)
                    .HasColumnName("RUHSAT_TARIHI");

                entity.Property(e => e.SiraNo)
                    .HasMaxLength(50)
                    .HasColumnName("SIRA_NO");

                entity.Property(e => e.Soyadi)
                    .HasMaxLength(50)
                    .HasColumnName("SOYADI");

                entity.Property(e => e.TcKimlikNo)
                    .HasMaxLength(11)
                    .HasColumnName("TC_KIMLIK_NO");

                entity.Property(e => e.Telefon)
                    .HasMaxLength(15)
                    .HasColumnName("TELEFON");

                entity.Property(e => e.TutanagiDuzenleyeninAdi)
                    .HasMaxLength(50)
                    .HasColumnName("TUTANAGI_DUZENLEYENIN_ADI");

                entity.Property(e => e.TutanagiDuzenleyeninSoyadi)
                    .HasMaxLength(50)
                    .HasColumnName("TUTANAGI_DUZENLEYENIN_SOYADI");

                entity.Property(e => e.TutanagiDuzenleyeninUnvani)
                    .HasMaxLength(50)
                    .HasColumnName("TUTANAGI_DUZENLEYENIN_UNVANI");

                entity.Property(e => e.TutanakOlusturuldu).HasColumnName("TUTANAK_OLUSTURULDU");

                entity.Property(e => e.UmumiSiraNo)
                    .HasMaxLength(50)
                    .HasColumnName("UMUMI_SIRA_NO");

                entity.Property(e => e.Yol)
                    .HasMaxLength(50)
                    .HasColumnName("YOL");
            });

            modelBuilder.Entity<Ilceler>(entity =>
            {
                entity.ToTable("ILCELER");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Aktif)
                    .HasColumnName("AKTIF")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.EklemeTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("EKLEME_TARIHI");

                entity.Property(e => e.Ekleyen).HasColumnName("EKLEYEN");

                entity.Property(e => e.GuncellemeTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("GUNCELLEME_TARIHI");

                entity.Property(e => e.Guncelleyen).HasColumnName("GUNCELLEYEN");

                entity.Property(e => e.IlId).HasColumnName("IL_ID");

                entity.Property(e => e.Kod)
                    .HasMaxLength(50)
                    .HasColumnName("KOD");

                entity.Property(e => e.Tanim)
                    .HasMaxLength(50)
                    .HasColumnName("TANIM");

                entity.HasOne(d => d.Il)
                    .WithMany(p => p.Ilcelers)
                    .HasForeignKey(d => d.IlId)
                    .HasConstraintName("FK_ILCELER_ILLER");
            });

            modelBuilder.Entity<Iller>(entity =>
            {
                entity.ToTable("ILLER");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Aktif)
                    .HasColumnName("AKTIF")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.EklemeTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("EKLEME_TARIHI");

                entity.Property(e => e.Ekleyen).HasColumnName("EKLEYEN");

                entity.Property(e => e.GuncellemeTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("GUNCELLEME_TARIHI");

                entity.Property(e => e.Guncelleyen).HasColumnName("GUNCELLEYEN");

                entity.Property(e => e.Tanim)
                    .HasMaxLength(50)
                    .HasColumnName("TANIM");
            });

            modelBuilder.Entity<KisiYakinlari>(entity =>
            {
                entity.ToTable("KISI_YAKINLARI");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Adi)
                    .HasMaxLength(50)
                    .HasColumnName("ADI");

                entity.Property(e => e.Aktif)
                    .HasColumnName("AKTIF")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.DogumTarihi)
                    .HasColumnType("date")
                    .HasColumnName("DOGUM_TARIHI");

                entity.Property(e => e.EklemeTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("EKLEME_TARIHI");

                entity.Property(e => e.Ekleyen).HasColumnName("EKLEYEN");

                entity.Property(e => e.GuncellemeTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("GUNCELLEME_TARIHI");

                entity.Property(e => e.Guncelleyen).HasColumnName("GUNCELLEYEN");

                entity.Property(e => e.KisiId).HasColumnName("KISI_ID");

                entity.Property(e => e.Soyadi)
                    .HasMaxLength(50)
                    .HasColumnName("SOYADI");

                entity.Property(e => e.TcKimlikNo)
                    .HasMaxLength(50)
                    .HasColumnName("TC_KIMLIK_NO");

                entity.Property(e => e.Telefon)
                    .HasMaxLength(50)
                    .HasColumnName("TELEFON");

                entity.Property(e => e.Yakinligi)
                    .HasMaxLength(50)
                    .HasColumnName("YAKINLIGI");

                entity.HasOne(d => d.Kisi)
                    .WithMany(p => p.KisiYakinlaris)
                    .HasForeignKey(d => d.KisiId)
                    .HasConstraintName("FK_KISI_YAKINLARI_KISILER");
            });

            modelBuilder.Entity<Kisiler>(entity =>
            {
                entity.ToTable("KISILER");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(500)
                    .HasColumnName("ACIKLAMA");

                entity.Property(e => e.AileMezarId).HasColumnName("AILE_MEZAR_ID");

                entity.Property(e => e.Aktif)
                    .HasColumnName("AKTIF")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.DefinTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("DEFIN_TARIHI");

                entity.Property(e => e.DefinYeri).HasColumnName("DEFIN_YERI");

                entity.Property(e => e.Durum).HasColumnName("DURUM");

                entity.Property(e => e.EklemeTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("EKLEME_TARIHI");

                entity.Property(e => e.Ekleyen).HasColumnName("EKLEYEN");

                entity.Property(e => e.GuncellemeTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("GUNCELLEME_TARIHI");

                entity.Property(e => e.Guncelleyen).HasColumnName("GUNCELLEYEN");

                entity.Property(e => e.IlId).HasColumnName("IL_ID");

                entity.Property(e => e.IlceId).HasColumnName("ILCE_ID");

                entity.Property(e => e.IslemYapilanMezarlik).HasColumnName("ISLEM_YAPILAN_MEZARLIK");

                entity.Property(e => e.MahalleId).HasColumnName("MAHALLE_ID");

                entity.Property(e => e.MezarliklarId).HasColumnName("MEZARLIKLAR_ID");

                entity.Property(e => e.ObsAktarimId).HasColumnName("OBS_AKTARIM_ID");

                entity.Property(e => e.OlumSebebi).HasColumnName("OLUM_SEBEBI");

                entity.Property(e => e.OlumSebebiId).HasColumnName("OLUM_SEBEBI_ID");

                entity.Property(e => e.Onay).HasColumnName("ONAY");

                entity.Property(e => e.TekilMezarId).HasColumnName("TEKIL_MEZAR_ID");

                entity.Property(e => e.UlkeId).HasColumnName("ULKE_ID");

                entity.Property(e => e.UmumiSiraNo).HasColumnName("UMUMI_SIRA_NO");

                entity.Property(e => e.WebSitesineAktarildi)
                    .HasColumnName("WEB_SITESINE_AKTARILDI")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.AileMezar)
                    .WithMany(p => p.Kisilers)
                    .HasForeignKey(d => d.AileMezarId)
                    .HasConstraintName("FK_KISILER_AILE_MEZARLIK");

                entity.HasOne(d => d.Il)
                    .WithMany(p => p.Kisilers)
                    .HasForeignKey(d => d.IlId)
                    .HasConstraintName("FK_KISILER_ILLER");

                entity.HasOne(d => d.Ilce)
                    .WithMany(p => p.Kisilers)
                    .HasForeignKey(d => d.IlceId)
                    .HasConstraintName("FK_KISILER_ILCELER");

                entity.HasOne(d => d.Mezarliklar)
                    .WithMany(p => p.Kisilers)
                    .HasForeignKey(d => d.MezarliklarId)
                    .HasConstraintName("FK_KISILER_MEZARLIKLAR");

                entity.HasOne(d => d.ObsAktarim)
                    .WithMany(p => p.Kisilers)
                    .HasForeignKey(d => d.ObsAktarimId)
                    .HasConstraintName("FK_KISILER_OBS_AKTARIM");

                entity.HasOne(d => d.OlumSebebiNavigation)
                    .WithMany(p => p.Kisilers)
                    .HasForeignKey(d => d.OlumSebebiId)
                    .HasConstraintName("FK_KISILER_OLUM_SEBEPLERI");

                entity.HasOne(d => d.TekilMezar)
                    .WithMany(p => p.Kisilers)
                    .HasForeignKey(d => d.TekilMezarId)
                    .HasConstraintName("FK_KISILER_TEKIL_MEZARLIK");

                entity.HasOne(d => d.Ulke)
                    .WithMany(p => p.Kisilers)
                    .HasForeignKey(d => d.UlkeId)
                    .HasConstraintName("FK_KISILER_ULKELER");
            });

            modelBuilder.Entity<Kolonlar>(entity =>
            {
                entity.ToTable("KOLONLAR");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Aktif).HasColumnName("AKTIF");

                entity.Property(e => e.EklemeTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("EKLEME_TARIHI");

                entity.Property(e => e.Ekleyen).HasColumnName("EKLEYEN");

                entity.Property(e => e.Genislik).HasColumnName("GENISLIK");

                entity.Property(e => e.Gorunurluk)
                    .HasColumnName("GORUNURLUK")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.GuncellemeTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("GUNCELLEME_TARIHI");

                entity.Property(e => e.Guncelleyen).HasColumnName("GUNCELLEYEN");

                entity.Property(e => e.KolonAdi)
                    .HasMaxLength(50)
                    .HasColumnName("KOLON_ADI");

                entity.Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");

                entity.Property(e => e.SiraNo).HasColumnName("SIRA_NO");

                entity.Property(e => e.TabloAdi)
                    .HasMaxLength(150)
                    .HasColumnName("TABLO_ADI");

                entity.HasOne(d => d.Kullanici)
                    .WithMany(p => p.Kolonlars)
                    .HasForeignKey(d => d.KullaniciId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KOLONLAR_KULLANICILAR");
            });

            modelBuilder.Entity<Kullanicilar>(entity =>
            {
                entity.ToTable("KULLANICILAR");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Adi)
                    .HasMaxLength(50)
                    .HasColumnName("ADI");

                entity.Property(e => e.Aktif)
                    .IsRequired()
                    .HasColumnName("AKTIF")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.EklemeTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("EKLEME_TARIHI");

                entity.Property(e => e.Ekleyen).HasColumnName("EKLEYEN");

                entity.Property(e => e.GuncellemeTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("GUNCELLEME_TARIHI");

                entity.Property(e => e.Guncelleyen).HasColumnName("GUNCELLEYEN");

                entity.Property(e => e.IlceId).HasColumnName("ILCE_ID");

                entity.Property(e => e.KullaniciAdi)
                    .HasMaxLength(50)
                    .HasColumnName("KULLANICI_ADI");

                entity.Property(e => e.MezarlikYetki)
                    .HasMaxLength(500)
                    .HasColumnName("MEZARLIK_YETKI");

                entity.Property(e => e.Parola)
                    .HasMaxLength(150)
                    .HasColumnName("PAROLA");

                entity.Property(e => e.Resim)
                    .HasColumnType("image")
                    .HasColumnName("RESIM");

                entity.Property(e => e.SonGirilenIp)
                    .HasMaxLength(50)
                    .HasColumnName("SON_GIRILEN_IP");

                entity.Property(e => e.Soyadi)
                    .HasMaxLength(50)
                    .HasColumnName("SOYADI");

                entity.Property(e => e.Telefon)
                    .HasMaxLength(20)
                    .HasColumnName("TELEFON");

                entity.HasOne(d => d.Ilce)
                    .WithMany(p => p.Kullanicilars)
                    .HasForeignKey(d => d.IlceId)
                    .HasConstraintName("FK_KULLANICILAR_ILCELER");
            });

            modelBuilder.Entity<Mahalleler>(entity =>
            {
                entity.ToTable("MAHALLELER");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Aktif)
                    .HasColumnName("AKTIF")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.EklemeTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("EKLEME_TARIHI");

                entity.Property(e => e.Ekleyen).HasColumnName("EKLEYEN");

                entity.Property(e => e.GuncellemeTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("GUNCELLEME_TARIHI");

                entity.Property(e => e.Guncelleyen).HasColumnName("GUNCELLEYEN");

                entity.Property(e => e.IlId).HasColumnName("IL_ID");

                entity.Property(e => e.IlceId).HasColumnName("ILCE_ID");

                entity.Property(e => e.Tanim)
                    .HasMaxLength(50)
                    .HasColumnName("TANIM");

                entity.HasOne(d => d.Il)
                    .WithMany(p => p.Mahallelers)
                    .HasForeignKey(d => d.IlId)
                    .HasConstraintName("FK_MAHALLELER_ILLER");

                entity.HasOne(d => d.Ilce)
                    .WithMany(p => p.Mahallelers)
                    .HasForeignKey(d => d.IlceId)
                    .HasConstraintName("FK_MAHALLELER_ILCELER");
            });

            modelBuilder.Entity<MenuYetki>(entity =>
            {
                entity.ToTable("MENU_YETKI");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Aktif).HasColumnName("AKTIF");

                entity.Property(e => e.EklemeTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("EKLEME_TARIHI");

                entity.Property(e => e.Ekleyen).HasColumnName("EKLEYEN");

                entity.Property(e => e.Gorunurluk).HasColumnName("GORUNURLUK");

                entity.Property(e => e.GuncellemeTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("GUNCELLEME_TARIHI");

                entity.Property(e => e.Guncelleyen).HasColumnName("GUNCELLEYEN");

                entity.Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");

                entity.Property(e => e.MenuId).HasColumnName("MENU_ID");

                entity.HasOne(d => d.Kullanici)
                    .WithMany(p => p.MenuYetkis)
                    .HasForeignKey(d => d.KullaniciId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MENU_YETKI_KULLANICILAR");

                entity.HasOne(d => d.Menu)
                    .WithMany(p => p.MenuYetkis)
                    .HasForeignKey(d => d.MenuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MENU_YETKI_MENULER");
            });

            modelBuilder.Entity<Menuler>(entity =>
            {
                entity.ToTable("MENULER");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Aktif).HasColumnName("AKTIF");

                entity.Property(e => e.EklemeTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("EKLEME_TARIHI");

                entity.Property(e => e.Ekleyen).HasColumnName("EKLEYEN");

                entity.Property(e => e.GuncellemeTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("GUNCELLEME_TARIHI");

                entity.Property(e => e.Guncelleyen).HasColumnName("GUNCELLEYEN");

                entity.Property(e => e.Icon)
                    .HasMaxLength(50)
                    .HasColumnName("ICON");

                entity.Property(e => e.IconRenk)
                    .HasMaxLength(50)
                    .HasColumnName("ICON_RENK");

                entity.Property(e => e.Link)
                    .HasMaxLength(50)
                    .HasColumnName("LINK");

                entity.Property(e => e.MenuAdi)
                    .HasMaxLength(50)
                    .HasColumnName("MENU_ADI");

                entity.Property(e => e.MenuTip).HasColumnName("MENU_TIP");

                entity.Property(e => e.SiraNo).HasColumnName("SIRA_NO");

                entity.Property(e => e.UstMenuId).HasColumnName("UST_MENU_ID");
            });

            modelBuilder.Entity<MezarlikDeneme21092121>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MEZARLIK_DENEME_21092121");

                entity.Property(e => e.Ad)
                    .HasMaxLength(50)
                    .HasColumnName("AD");

                entity.Property(e => e.AnaAdi)
                    .HasMaxLength(50)
                    .HasColumnName("ANA_ADI");

                entity.Property(e => e.BabaAdi)
                    .HasMaxLength(50)
                    .HasColumnName("BABA_ADI");

                entity.Property(e => e.Cinsiyet)
                    .HasMaxLength(50)
                    .HasColumnName("CINSIYET");

                entity.Property(e => e.DefinYeri)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("DEFIN_YERI");

                entity.Property(e => e.DogumTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("DOGUM_TARIHI");

                entity.Property(e => e.DogumYeri)
                    .HasMaxLength(50)
                    .HasColumnName("DOGUM_YERI");

                entity.Property(e => e.KisilerId).HasColumnName("KISILER_ID");

                entity.Property(e => e.MapX).HasColumnName("MAP_X");

                entity.Property(e => e.MapXa).HasColumnName("MAP_XA");

                entity.Property(e => e.MapY).HasColumnName("MAP_Y");

                entity.Property(e => e.MapYa).HasColumnName("MAP_YA");

                entity.Property(e => e.ObsAktarimId).HasColumnName("OBS_AKTARIM_ID");

                entity.Property(e => e.Soyad)
                    .HasMaxLength(50)
                    .HasColumnName("SOYAD");

                entity.Property(e => e.TcKimlikNo)
                    .HasMaxLength(50)
                    .HasColumnName("TC_KIMLIK_NO");
            });

            modelBuilder.Entity<MezarlikYetki>(entity =>
            {
                entity.ToTable("MEZARLIK_YETKI");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Aktif)
                    .HasColumnName("AKTIF")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.EklemeTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("EKLEME_TARIHI");

                entity.Property(e => e.Ekleyen).HasColumnName("EKLEYEN");

                entity.Property(e => e.GuncellemeTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("GUNCELLEME_TARIHI");

                entity.Property(e => e.Guncelleyen).HasColumnName("GUNCELLEYEN");

                entity.Property(e => e.IlceId).HasColumnName("ILCE_ID");

                entity.Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");

                entity.Property(e => e.MezarlikYetki1)
                    .HasMaxLength(500)
                    .HasColumnName("MEZARLIK_YETKI");

                entity.Property(e => e.Version)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("VERSION");
            });

            modelBuilder.Entity<Mezarliklar>(entity =>
            {
                entity.ToTable("MEZARLIKLAR");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Adres)
                    .HasMaxLength(500)
                    .HasColumnName("ADRES");

                entity.Property(e => e.Aktif)
                    .HasColumnName("AKTIF")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.EklemeTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("EKLEME_TARIHI");

                entity.Property(e => e.Ekleyen).HasColumnName("EKLEYEN");

                entity.Property(e => e.GuncellemeTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("GUNCELLEME_TARIHI");

                entity.Property(e => e.Guncelleyen).HasColumnName("GUNCELLEYEN");

                entity.Property(e => e.IlceId).HasColumnName("ILCE_ID");

                entity.Property(e => e.SorumluKullaniciId).HasColumnName("SORUMLU_KULLANICI_ID");

                entity.Property(e => e.Tanim)
                    .HasMaxLength(50)
                    .HasColumnName("TANIM");

                entity.Property(e => e.Telefon)
                    .HasMaxLength(20)
                    .HasColumnName("TELEFON");

                entity.HasOne(d => d.Ilce)
                    .WithMany(p => p.Mezarliklars)
                    .HasForeignKey(d => d.IlceId)
                    .HasConstraintName("FK_MEZARLIKLAR_ILCELER");

                entity.HasOne(d => d.SorumluKullanici)
                    .WithMany(p => p.Mezarliklars)
                    .HasForeignKey(d => d.SorumluKullaniciId)
                    .HasConstraintName("FK_MEZARLIKLAR_KULLANICILAR");
            });

            modelBuilder.Entity<ObsAktarim>(entity =>
            {
                entity.ToTable("OBS_AKTARIM");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ad)
                    .HasMaxLength(50)
                    .HasColumnName("AD");

                entity.Property(e => e.AileNo)
                    .HasMaxLength(50)
                    .HasColumnName("AILE_NO");

                entity.Property(e => e.AktaranKullaniciId).HasColumnName("AKTARAN_KULLANICI_ID");

                entity.Property(e => e.Aktarildi)
                    .HasColumnName("AKTARILDI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AktarimTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("AKTARIM_TARIHI");

                entity.Property(e => e.Aktif).HasColumnName("AKTIF");

                entity.Property(e => e.AnaAdi)
                    .HasMaxLength(50)
                    .HasColumnName("ANA_ADI");

                entity.Property(e => e.AramaTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("ARAMA_TARIHI");

                entity.Property(e => e.Arandi)
                    .HasColumnName("ARANDI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ArayanKullaniciId).HasColumnName("ARAYAN_KULLANICI_ID");

                entity.Property(e => e.BabaAdi)
                    .HasMaxLength(50)
                    .HasColumnName("BABA_ADI");

                entity.Property(e => e.BebekOlum)
                    .HasMaxLength(500)
                    .HasColumnName("BEBEK_OLUM");

                entity.Property(e => e.BilgiVerenAdSoyad)
                    .HasMaxLength(50)
                    .HasColumnName("BILGI_VEREN_AD_SOYAD");

                entity.Property(e => e.BilgiVerenAdres).HasColumnName("BILGI_VEREN_ADRES");

                entity.Property(e => e.BilgiVerenDogumTarih)
                    .HasMaxLength(50)
                    .HasColumnName("BILGI_VEREN_DOGUM_TARIH");

                entity.Property(e => e.BilgiVerenTc)
                    .HasMaxLength(50)
                    .HasColumnName("BILGI_VEREN_TC");

                entity.Property(e => e.BilgiVerenTelefon)
                    .HasMaxLength(50)
                    .HasColumnName("BILGI_VEREN_TELEFON");

                entity.Property(e => e.BilgiVerenYakinlik)
                    .HasMaxLength(50)
                    .HasColumnName("BILGI_VEREN_YAKINLIK");

                entity.Property(e => e.BireyNo)
                    .HasMaxLength(50)
                    .HasColumnName("BIREY_NO");

                entity.Property(e => e.CiltNo)
                    .HasMaxLength(50)
                    .HasColumnName("CILT_NO");

                entity.Property(e => e.Cinsiyet)
                    .HasMaxLength(50)
                    .HasColumnName("CINSIYET");

                entity.Property(e => e.Din)
                    .HasMaxLength(50)
                    .HasColumnName("DIN");

                entity.Property(e => e.DogumTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("DOGUM_TARIHI");

                entity.Property(e => e.DogumYeri)
                    .HasMaxLength(50)
                    .HasColumnName("DOGUM_YERI");

                entity.Property(e => e.DoktorKurumAdi).HasColumnName("DOKTOR_KURUM_ADI");

                entity.Property(e => e.EklemeTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("EKLEME_TARIHI");

                entity.Property(e => e.Ekleyen).HasColumnName("EKLEYEN");

                entity.Property(e => e.FormNo)
                    .HasMaxLength(50)
                    .HasColumnName("FORM_NO");

                entity.Property(e => e.GuncellemeTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("GUNCELLEME_TARIHI");

                entity.Property(e => e.Guncelleyen).HasColumnName("GUNCELLEYEN");

                entity.Property(e => e.HekimAdSoyad)
                    .HasMaxLength(500)
                    .HasColumnName("HEKIM_AD_SOYAD");

                entity.Property(e => e.KadinOlum)
                    .HasMaxLength(500)
                    .HasColumnName("KADIN_OLUM");

                entity.Property(e => e.KurumAdi)
                    .HasMaxLength(500)
                    .HasColumnName("KURUM_ADI");

                entity.Property(e => e.MedeniHal)
                    .HasMaxLength(50)
                    .HasColumnName("MEDENI_HAL");

                entity.Property(e => e.MernisCaddeSokak)
                    .HasMaxLength(50)
                    .HasColumnName("MERNIS_CADDE_SOKAK");

                entity.Property(e => e.MernisDisKapi)
                    .HasMaxLength(50)
                    .HasColumnName("MERNIS_DIS_KAPI");

                entity.Property(e => e.MernisIcKapi)
                    .HasMaxLength(50)
                    .HasColumnName("MERNIS_IC_KAPI");

                entity.Property(e => e.MernisIlKodu)
                    .HasMaxLength(50)
                    .HasColumnName("MERNIS_IL_KODU");

                entity.Property(e => e.MernisIlceKodu)
                    .HasMaxLength(50)
                    .HasColumnName("MERNIS_ILCE_KODU");

                entity.Property(e => e.MernisKoyMahalle)
                    .HasMaxLength(50)
                    .HasColumnName("MERNIS_KOY_MAHALLE");

                entity.Property(e => e.MernisSite)
                    .HasMaxLength(50)
                    .HasColumnName("MERNIS_SITE");

                entity.Property(e => e.Meslek)
                    .HasMaxLength(50)
                    .HasColumnName("MESLEK");

                entity.Property(e => e.NufusIl)
                    .HasMaxLength(50)
                    .HasColumnName("NUFUS_IL");

                entity.Property(e => e.NufusIlce)
                    .HasMaxLength(50)
                    .HasColumnName("NUFUS_ILCE");

                entity.Property(e => e.OluDogum)
                    .HasMaxLength(500)
                    .HasColumnName("OLU_DOGUM");

                entity.Property(e => e.OlumAdresKoy)
                    .HasMaxLength(50)
                    .HasColumnName("OLUM_ADRES_KOY");

                entity.Property(e => e.OlumTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("OLUM_TARIHI");

                entity.Property(e => e.OnKayit).HasColumnName("ON_KAYIT");

                entity.Property(e => e.RaporTarih)
                    .HasColumnType("datetime")
                    .HasColumnName("RAPOR_TARIH");

                entity.Property(e => e.Soyad)
                    .HasMaxLength(50)
                    .HasColumnName("SOYAD");

                entity.Property(e => e.TcKimlikNo)
                    .HasMaxLength(50)
                    .HasColumnName("TC_KIMLIK_NO");

                entity.Property(e => e.Uyruk)
                    .HasMaxLength(50)
                    .HasColumnName("UYRUK");
            });

            modelBuilder.Entity<ObsHaritum>(entity =>
            {
                entity.ToTable("OBS_HARITA");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AdresVarMi).HasColumnName("ADRES_VAR_MI");

                entity.Property(e => e.Aktif).HasColumnName("AKTIF");

                entity.Property(e => e.BinaKodu).HasColumnName("BINA_KODU");

                entity.Property(e => e.BinaNo).HasColumnName("BINA_NO");

                entity.Property(e => e.EklemeTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("EKLEME_TARIHI");

                entity.Property(e => e.Ekleyen).HasColumnName("EKLEYEN");

                entity.Property(e => e.GuncellemeTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("GUNCELLEME_TARIHI");

                entity.Property(e => e.Guncelleyen).HasColumnName("GUNCELLEYEN");

                entity.Property(e => e.KisiId).HasColumnName("KISI_ID");

                entity.Property(e => e.LatLng)
                    .HasMaxLength(50)
                    .HasColumnName("LAT_LNG");

                entity.HasOne(d => d.Kisi)
                    .WithMany(p => p.ObsHarita)
                    .HasForeignKey(d => d.KisiId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OBS_HARITA_KISILER");
            });

            modelBuilder.Entity<OlumSebepleri>(entity =>
            {
                entity.ToTable("OLUM_SEBEPLERI");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Aktif)
                    .HasColumnName("AKTIF")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.EklemeTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("EKLEME_TARIHI");

                entity.Property(e => e.Ekleyen).HasColumnName("EKLEYEN");

                entity.Property(e => e.GuncellemeTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("GUNCELLEME_TARIHI");

                entity.Property(e => e.Guncelleyen).HasColumnName("GUNCELLEYEN");

                entity.Property(e => e.Tanim)
                    .HasMaxLength(150)
                    .HasColumnName("TANIM");

                entity.Property(e => e.Version)
                    .HasColumnType("numeric(19, 0)")
                    .HasColumnName("VERSION");
            });

            modelBuilder.Entity<OnayKaldirmaNedenleri>(entity =>
            {
                entity.ToTable("ONAY_KALDIRMA_NEDENLERI");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(500)
                    .HasColumnName("ACIKLAMA");

                entity.Property(e => e.Aktif)
                    .HasColumnName("AKTIF")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.EklemeTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("EKLEME_TARIHI");

                entity.Property(e => e.Ekleyen).HasColumnName("EKLEYEN");

                entity.Property(e => e.GuncellemeTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("GUNCELLEME_TARIHI");

                entity.Property(e => e.Guncelleyen).HasColumnName("GUNCELLEYEN");

                entity.Property(e => e.KisiId).HasColumnName("KISI_ID");

                entity.HasOne(d => d.Kisi)
                    .WithMany(p => p.OnayKaldirmaNedenleris)
                    .HasForeignKey(d => d.KisiId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ONAY_KALDIRMA_NEDENLERI_KISILER");
            });

            modelBuilder.Entity<PostaGonderimListesi>(entity =>
            {
                entity.ToTable("POSTA_GONDERIM_LISTESI");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ad)
                    .HasMaxLength(50)
                    .HasColumnName("AD");

                entity.Property(e => e.Aktif).HasColumnName("AKTIF");

                entity.Property(e => e.EklemeTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("EKLEME_TARIHI");

                entity.Property(e => e.Ekleyen).HasColumnName("EKLEYEN");

                entity.Property(e => e.GuncellemeTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("GUNCELLEME_TARIHI");

                entity.Property(e => e.Guncelleyen).HasColumnName("GUNCELLEYEN");

                entity.Property(e => e.PostaAdresi)
                    .HasMaxLength(150)
                    .HasColumnName("POSTA_ADRESI");

                entity.Property(e => e.Soyad)
                    .HasMaxLength(50)
                    .HasColumnName("SOYAD");
            });

            modelBuilder.Entity<TaziyeEviPlanlama>(entity =>
            {
                entity.ToTable("TAZIYE_EVI_PLANLAMA");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Aciklama).HasColumnName("ACIKLAMA");

                entity.Property(e => e.Ad)
                    .HasMaxLength(50)
                    .HasColumnName("AD");

                entity.Property(e => e.Aktif)
                    .HasColumnName("AKTIF")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.BaslangicTarihi)
                    .HasColumnType("date")
                    .HasColumnName("BASLANGIC_TARIHI");

                entity.Property(e => e.BitisTarihi)
                    .HasColumnType("date")
                    .HasColumnName("BITIS_TARIHI");

                entity.Property(e => e.DogumTarihi)
                    .HasColumnType("date")
                    .HasColumnName("DOGUM_TARIHI");

                entity.Property(e => e.EklemeTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("EKLEME_TARIHI");

                entity.Property(e => e.Ekleyen).HasColumnName("EKLEYEN");

                entity.Property(e => e.GuncellemeTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("GUNCELLEME_TARIHI");

                entity.Property(e => e.Guncelleyen).HasColumnName("GUNCELLEYEN");

                entity.Property(e => e.Soyad)
                    .HasMaxLength(50)
                    .HasColumnName("SOYAD");

                entity.Property(e => e.TaziyeEviId).HasColumnName("TAZIYE_EVI_ID");

                entity.Property(e => e.TcKimlikNo)
                    .HasMaxLength(11)
                    .HasColumnName("TC_KIMLIK_NO");

                entity.Property(e => e.Telefon)
                    .HasMaxLength(20)
                    .HasColumnName("TELEFON");

                entity.Property(e => e.Version).HasColumnName("VERSION");

                entity.HasOne(d => d.TaziyeEvi)
                    .WithMany(p => p.TaziyeEviPlanlamas)
                    .HasForeignKey(d => d.TaziyeEviId)
                    .HasConstraintName("FK_TAZIYE_EVI_PLANLAMA_TAZIYE_EVLERI");
            });

            modelBuilder.Entity<TaziyeEvleri>(entity =>
            {
                entity.ToTable("TAZIYE_EVLERI");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Adres).HasColumnName("ADRES");

                entity.Property(e => e.Aktif)
                    .HasColumnName("AKTIF")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.EklemeTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("EKLEME_TARIHI");

                entity.Property(e => e.Ekleyen).HasColumnName("EKLEYEN");

                entity.Property(e => e.GuncellemeTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("GUNCELLEME_TARIHI");

                entity.Property(e => e.Guncelleyen).HasColumnName("GUNCELLEYEN");

                entity.Property(e => e.IlceId).HasColumnName("ILCE_ID");

                entity.Property(e => e.MahalleId).HasColumnName("MAHALLE_ID");

                entity.Property(e => e.Tanim)
                    .HasMaxLength(200)
                    .HasColumnName("TANIM");

                entity.Property(e => e.Telefon)
                    .HasMaxLength(20)
                    .HasColumnName("TELEFON");

                entity.Property(e => e.Version).HasColumnName("VERSION");

                entity.Property(e => e.Yetkili)
                    .HasMaxLength(20)
                    .HasColumnName("YETKILI");
            });

            modelBuilder.Entity<TekilMezarlik>(entity =>
            {
                entity.ToTable("TEKIL_MEZARLIK");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(500)
                    .HasColumnName("ACIKLAMA");

                entity.Property(e => e.Ada)
                    .HasMaxLength(4)
                    .HasColumnName("ADA");

                entity.Property(e => e.Adi)
                    .HasMaxLength(50)
                    .HasColumnName("ADI");

                entity.Property(e => e.Aktif)
                    .HasColumnName("AKTIF")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Bedel)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("BEDEL");

                entity.Property(e => e.Cadde)
                    .HasMaxLength(50)
                    .HasColumnName("CADDE");

                entity.Property(e => e.DefinId).HasColumnName("DEFIN_ID");

                entity.Property(e => e.DogumTarihi)
                    .HasColumnType("date")
                    .HasColumnName("DOGUM_TARIHI");

                entity.Property(e => e.Dolu)
                    .HasColumnName("DOLU")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EklemeTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("EKLEME_TARIHI");

                entity.Property(e => e.Ekleyen).HasColumnName("EKLEYEN");

                entity.Property(e => e.EskiId).HasColumnName("ESKI_ID");

                entity.Property(e => e.Gecit)
                    .HasMaxLength(50)
                    .HasColumnName("GECIT");

                entity.Property(e => e.GuncellemeTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("GUNCELLEME_TARIHI");

                entity.Property(e => e.Guncelleyen).HasColumnName("GUNCELLEYEN");

                entity.Property(e => e.KisilerId).HasColumnName("KISILER_ID");

                entity.Property(e => e.Latlng1)
                    .HasMaxLength(50)
                    .HasColumnName("LATLNG1");

                entity.Property(e => e.Latlng2)
                    .HasMaxLength(50)
                    .HasColumnName("LATLNG2");

                entity.Property(e => e.Latlng3)
                    .HasMaxLength(50)
                    .HasColumnName("LATLNG3");

                entity.Property(e => e.Latlng4)
                    .HasMaxLength(50)
                    .HasColumnName("LATLNG4");

                entity.Property(e => e.Mahalle)
                    .HasMaxLength(100)
                    .HasColumnName("MAHALLE");

                entity.Property(e => e.MakbuzNo)
                    .HasMaxLength(20)
                    .HasColumnName("MAKBUZ_NO");

                entity.Property(e => e.MakbuzTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("MAKBUZ_TARIHI");

                entity.Property(e => e.MezarliklarId).HasColumnName("MEZARLIKLAR_ID");

                entity.Property(e => e.Soyadi)
                    .HasMaxLength(50)
                    .HasColumnName("SOYADI");

                entity.Property(e => e.TcKimlikNo)
                    .HasMaxLength(50)
                    .HasColumnName("TC_KIMLIK_NO");

                entity.Property(e => e.Telefon)
                    .HasMaxLength(20)
                    .HasColumnName("TELEFON");

                entity.Property(e => e.Ucretsiz)
                    .HasColumnName("UCRETSIZ")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<TestView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TestView");

                entity.Property(e => e.Adi).HasMaxLength(50);

                entity.Property(e => e.C).HasMaxLength(50);

                entity.Property(e => e.OlumTarihi).HasColumnType("date");

                entity.Property(e => e.Soyadi).HasMaxLength(50);
            });

            modelBuilder.Entity<TumKayitlarView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TUM_KAYITLAR_VIEW");

                entity.Property(e => e.Adi)
                    .HasMaxLength(50)
                    .HasColumnName("ADI");

                entity.Property(e => e.Anaadi)
                    .HasMaxLength(50)
                    .HasColumnName("ANAADI");

                entity.Property(e => e.Babaadi)
                    .HasMaxLength(50)
                    .HasColumnName("BABAADI");

                entity.Property(e => e.C).HasMaxLength(50);

                entity.Property(e => e.DefinTarihi)
                    .HasMaxLength(30)
                    .HasColumnName("DEFIN_TARIHI");

                entity.Property(e => e.Dogumtar)
                    .HasMaxLength(30)
                    .HasColumnName("DOGUMTAR");

                entity.Property(e => e.Doktoru).HasColumnName("DOKTORU");

                entity.Property(e => e.Olumsebebi).HasColumnName("OLUMSEBEBI");

                entity.Property(e => e.Olumtar)
                    .HasColumnType("date")
                    .HasColumnName("OLUMTAR");

                entity.Property(e => e.Soyadi)
                    .HasMaxLength(50)
                    .HasColumnName("SOYADI");

                entity.Property(e => e.TcKimlikNo)
                    .HasMaxLength(50)
                    .HasColumnName("TC_KIMLIK_NO");

                entity.Property(e => e.Usirano)
                    .HasMaxLength(30)
                    .HasColumnName("USIRANO");
            });

            modelBuilder.Entity<TumKayitlarYeniView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TUM_KAYITLAR_YENI_VIEW");

                entity.Property(e => e.Adi)
                    .HasMaxLength(50)
                    .HasColumnName("ADI");

                entity.Property(e => e.AileMezarId)
                    .HasMaxLength(30)
                    .HasColumnName("AILE_MEZAR_ID");

                entity.Property(e => e.Anaadi)
                    .HasMaxLength(50)
                    .HasColumnName("ANAADI");

                entity.Property(e => e.Babaadi)
                    .HasMaxLength(50)
                    .HasColumnName("BABAADI");

                entity.Property(e => e.C).HasMaxLength(50);

                entity.Property(e => e.DefinTarihi)
                    .HasMaxLength(30)
                    .HasColumnName("DEFIN_TARIHI");

                entity.Property(e => e.DogumYeri)
                    .HasMaxLength(50)
                    .HasColumnName("DOGUM_YERI");

                entity.Property(e => e.Dogumtar)
                    .HasMaxLength(30)
                    .HasColumnName("DOGUMTAR");

                entity.Property(e => e.Doktoru).HasColumnName("DOKTORU");

                entity.Property(e => e.MezarliklarId).HasColumnName("MEZARLIKLAR_ID");

                entity.Property(e => e.Olumsebebi).HasColumnName("OLUMSEBEBI");

                entity.Property(e => e.Olumtar)
                    .HasColumnType("date")
                    .HasColumnName("OLUMTAR");

                entity.Property(e => e.Soyadi)
                    .HasMaxLength(50)
                    .HasColumnName("SOYADI");

                entity.Property(e => e.TcKimlikNo)
                    .HasMaxLength(50)
                    .HasColumnName("TC_KIMLIK_NO");

                entity.Property(e => e.Usirano)
                    .HasMaxLength(30)
                    .HasColumnName("USIRANO");
            });

            modelBuilder.Entity<Ulkeler>(entity =>
            {
                entity.ToTable("ULKELER");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Aktif).HasColumnName("AKTIF");

                entity.Property(e => e.EklemeTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("EKLEME_TARIHI");

                entity.Property(e => e.Ekleyen).HasColumnName("EKLEYEN");

                entity.Property(e => e.GuncellemeTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("GUNCELLEME_TARIHI");

                entity.Property(e => e.Guncelleyen).HasColumnName("GUNCELLEYEN");

                entity.Property(e => e.Tanim)
                    .HasMaxLength(100)
                    .HasColumnName("TANIM")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
