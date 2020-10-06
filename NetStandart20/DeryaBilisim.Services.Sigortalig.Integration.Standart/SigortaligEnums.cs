using System.ComponentModel.DataAnnotations;

namespace DeryaBilisim.Services.Sigortalig.Integration.Standart
{
    public enum Gender : int
    {
        /// <summary>
        /// Erkek
        /// </summary>
        Male = 1,
        /// <summary>
        /// Kadın
        /// </summary>
        Female = 2
    }

    public enum ApartmentUsedType : int
    {
        /// <summary>
        /// Mesken
        /// </summary>
        Residential = 1,
        /// <summary>
        /// Ricarethane
        /// </summary>
        Business = 2
    }

    public enum InsuranceUsedType : int
    {
        /// <summary>
        /// Bireysel
        /// </summary>
        Individual = 1,
        /// <summary>
        /// Kurumsal
        /// </summary>
        Corporate = 2
    }

    public enum CityEnum : int
    {
        ADANA = 1,
        ADIYAMAN = 2,
        AFYONKARAHISAR = 3,
        AGRI = 4,
        AMASYA = 5,
        ANKARA = 6,
        ANTALYA = 7,
        ARTVIN = 8,
        AYDIN = 9,
        BALIKESIR = 10,
        BILECIKK = 11,
        BINGOL = 12,
        BITLIS = 13,
        BOLU = 14,
        BURDUR = 15,
        BURSA = 16,
        CANAKKALE = 17,
        CANKIRI = 18,
        CORUM = 19,
        DENIZLI = 20,
        DIYARBAKIR = 21,
        EDIRNE = 22,
        ELAZIG = 23,
        ERZINCAN = 24,
        ERZURUM = 25,
        ESKISEHIR = 26,
        GAZIANTEP = 27,
        GIRESUN = 28,
        GUMUSHANE = 29,
        HAKKARI = 30,
        HATAY = 31,
        ISPARTA = 32,
        MERSIN = 33,
        ISTANBUL = 34,
        IZMIR = 35,
        KARS = 36,
        KASTAMONU = 37,
        KAYSERI = 38,
        KIRKLARELI = 39,
        KIRSEHIR = 40,
        KOCAELI = 41,
        KONYA = 42,
        KUTAHYA = 43,
        MALATYA = 44,
        MANISA = 45,
        KAHRAMANMARAS = 46,
        MARDIN = 47,
        MUGLA = 48,
        MUS = 49,
        NEVSEHIR = 50,
        NIGDE = 51,
        ORDU = 52,
        RIZE = 53,
        SAKARYA = 54,
        SAMSUN = 55,
        SIIRT = 56,
        SINOP = 57,
        SIVAS = 58,
        TEKIRDAG = 59,
        TOKAT = 60,
        TRABZON = 61,
        TUNCELI = 62,
        SANLIURFA = 63,
        USAK = 64,
        VAN = 65,
        YOZGAT = 66,
        ZONGULDAK = 67,
        AKSARAY = 68,
        BAYBURT = 69,
        KARAMAN = 70,
        KIRIKKALE = 71,
        BATMAN = 72,
        SIRNAK = 73,
        BARTIN = 74,
        ARDAHAN = 75,
        IGDIR = 76,
        YALOVA = 77,
        KARABUK = 78,
        KILIS = 79,
        OSMANIYE = 80,
        DUZCE = 81
    }

    public enum InsuranceType:int
    {
        /// <summary>
        /// Kasko sigortası
        /// </summary>
        [Display(Name = "Kasko")]
        ComprehensiveInsurance = 1,
        //[Display(Name = "Tamamlayıcı Sağlık Sigortası")]
        //CollateralInsurance = 2,
        /// <summary>
        /// Zorunlu Trafik sigortası
        /// </summary>
        [Display(Name = "Trafik Sigortası")]
        CarInsurance = 3,
        /// <summary>
        /// Yangın sigortası
        /// </summary>
        [Display(Name = "Yangın")]
        FireInsurance = 4,
        /// <summary>
        /// Sağlık sigortası
        /// </summary>
        [Display(Name = "Sağlık Sigortası")]
        HealtInsurance = 5,
        /// <summary>
        /// Deprem Sigortası DASK
        /// </summary>
        [Display(Name = "DASK")]
        EarthquakeInsurance = 6,
        /// <summary>
        /// Bireysel emeklilik
        /// </summary>
        [Display(Name = "BES")]
        BESInsurance = 7,
        /// <summary>
        /// Konut sigortası
        /// </summary>
        [Display(Name = "Konut Sigortası")]
        HouseInsurance = 8,
        /// <summary>
        /// İşyeri sigortası
        /// </summary>
        [Display(Name = "İşyeri Sigortası")]
        WorkPlaceInsurance = 9,
        /// <summary>
        /// Tarım Sigortası
        /// </summary>
        [Display(Name = "Tarım Sigortası")]
        AgricultureInsurance = 10,
        /// <summary>
        /// Oto Dışı kaza sigortası
        /// </summary>
        [Display(Name = "Oto Dışı Kaza")]
        NoneAutoInsurance = 11,
        /// <summary>
        /// Oto Diğer kaza sigortası
        /// </summary>
        [Display(Name = "Oto Diğer")]
        AutoOtherInsurance = 12,
        /// <summary>
        /// İnşaat all sigorta
        /// </summary>
        [Display(Name = "İnşaat All")]
        ConstructionAllInsurance = 13,
        /// <summary>
        /// Tamamlayıcı Trafik Sigortası
        /// </summary>
        [Display(Name = "Tamamlayıcı Trafik")]
        ComplementaryTrafficInsurance = 14,
        /// <summary>
        /// Hayata Devam Sigortası
        /// </summary>
        [Display(Name = "Hayata Devam Sigortası")]
        SurvivalInsurance = 15,
        /// <summary>
        /// Hayat Sigortası
        /// </summary>
        [Display(Name = "Hayat Sigortası")]
        LifeInsurance = 16,
        /// <summary>
        /// Ferdi Kaza Sigortası
        /// </summary>
        [Display(Name = "Ferdi Kaza")]
        PersonalAccidentInsurance = 17,
        /// <summary>
        /// NAkliye Sigortası
        /// </summary>
        [Display(Name = "Nakliye Sigortası")]
        TransportationInsurance = 18,
        /// <summary>
        /// Mühendislik
        /// </summary>
        [Display(Name = "Mühendislik Sigortası")]
        EngineerInsurance = 19,
        /// <summary>
        /// Sorumluluk
        /// </summary>
        [Display(Name = "Sorumluluk Sigortası")]
        ResponsibleInsurance = 20,
        /// <summary>
        /// Yabancı Sağlık sigortası
        /// </summary>
        [Display(Name = "Yabancı Sağlık")]
        ForeignHealthInsurance = 21,
        /// <summary>
        /// Ortak lan sigortası
        /// </summary>
        [Display(Name = "Ortak Alan")]
        PublicAreaInsurance = 22,
        /// <summary>
        /// Siber koruma sigortası
        /// </summary>
        [Display(Name = "Siber Koruma")]
        CyberProtectionInsurance = 23,
        /// <summary>
        /// Dijital güvenlik sigortası
        /// </summary>
        [Display(Name = "Dijital Güvenlik")]
        DigitalSecurityInsurance = 24
    }
}
