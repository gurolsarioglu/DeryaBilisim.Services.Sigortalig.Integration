using System;

namespace DeryaBilisim.Services.Sigortalig.Integration.Standart
{
    public interface IInsuranceModel
    {

    }

    public abstract class InsuranceBase : IInsuranceModel
    {
        /// <summary>
        /// Müşteri Adı
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Müşteri Soyadı
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Müşteri Mail adresi
        /// </summary>
        public string Mail { get; set; }

        /// <summary>
        /// Müşteri Telefon numarası
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Müşteri TC Numarası
        /// </summary>
        public string TCKN { get; set; }

        /// <summary>
        /// Özellik
        /// </summary>
        public Guid? CustomAttributeId { get; set; }

        /// <summary>
        /// KVKK Onayı
        /// </summary>
        public bool IsKVKKApproved { get; set; }

        /// <summary>
        /// Pazarlama izni onayı
        /// </summary>
        public bool IsMarketingApproved { get; set; }

        /// <summary>
        /// Müşterinin sigorta talebinde bulunduğu acenta bilgisi
        /// </summary>
        public Guid? OwnerAgencyId { get; set; }

        /// <summary>
        /// BiBayim entegrasyon referans bayi kodu
        /// </summary>
        public string ReferalCode { get; set; }

        /// <summary>
        /// BiBayim entegsrayon ürün id si
        /// </summary>
        public string ProductId { get; set; }
    }

    public partial class NewHealtRequestInsurance : InsuranceBase
    {
        /// <summary>
        /// Cinsiyet
        /// </summary>
        public Gender Gender { get; set; }
        /// <summary>
        /// Açık adres
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// Boy cm. Örneğin 165,180 vb.
        /// </summary>
        public int? Tall { get; set; }
        /// <summary>
        /// Kilo tam sayı olarak ekledin. 70,71 gibi gidebilir.
        /// </summary>
        public int? Weight { get; set; }
        /// <summary>
        /// Doğum günü
        /// </summary>
        public DateTime? BirthDate { get; set; }
    }

    public partial class NewEarthquakeRequestInsurance : InsuranceBase
    {
        /// <summary>
        /// DASK yapılacak evin adresi
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// Kullanım tipi. Mesken / Ticarethane
        /// </summary>
        public ApartmentUsedType UsedType { get; set; }
        /// <summary>
        /// Bürüt metrekare
        /// </summary>
        public int GrossSquareMeter { get; set; }
        /// <summary>
        /// Kat
        /// </summary>
        public int Floor { get; set; }
        /// <summary>
        /// Bina no
        /// </summary>
        public int StructureNo { get; set; }
        /// <summary>
        /// İnşa yılı
        /// </summary>
        public int BuildYear { get; set; }
        /// <summary>
        /// Toplam kat sayısı
        /// </summary>
        public int StructureFloorCount { get; set; }
        /// <summary>
        /// Daire no
        /// </summary>
        public int ApartmentNo { get; set; }
    }

    public partial class NewCarRequestInsurance : InsuranceBase
    {
        /// <summary>
        /// Kullanım tipi bireysel / kurumsal
        /// </summary>
        public InsuranceUsedType UsedType { get; set; }
        /// <summary>
        /// Araç plakası
        /// </summary>
        public string Plate { get; set; }
        /// <summary>
        /// Şase no
        /// </summary>
        public string IdentityNumber { get; set; }
        /// <summary>
        /// Belge seri no
        /// </summary>
        public string DocumentSerieNumber { get; set; }
        /// <summary>
        /// Araç tipi
        /// </summary>
        public string CarType { get; set; }
        /// <summary>
        /// Araç markası
        /// </summary>
        public string CarBrand { get; set; }
        /// <summary>
        /// Araç motor bilgisi
        /// </summary>
        public string CarEngine { get; set; }
        /// <summary>
        /// Model yılı
        /// </summary>
        public int CarModelYear { get; set; }
        /// <summary>
        /// İMM
        /// </summary>
        public int IMM { get; set; }
        /// <summary>
        /// Aksesuar
        /// </summary>
        public string Accessory { get; set; }
        /// <summary>
        /// Meslek
        /// </summary>
        public string Profession { get; set; }
        /// <summary>
        /// Anahtar Kaybı + İkame:
        /// </summary>
        public bool CourtesyCar { get; set; }
        /// <summary>
        /// <see cref="InsuranceUsedType.Corporate"/> ise vergi kimlik numarası doldurulmalıdır.
        /// </summary>
        public string TaxNumber { get; set; }
    }

    public partial class NewComprehensiveRequestInsurance : InsuranceBase
    {
        /// <summary>
        /// Kullanım tipi bireysel / kurumsal
        /// </summary>
        public InsuranceUsedType UsedType { get; set; }
        /// <summary>
        /// Araç plakası
        /// </summary>
        public string Plate { get; set; }
        /// <summary>
        /// Şase no
        /// </summary>
        public string IdentityNumber { get; set; }
        /// <summary>
        /// Belge seri no
        /// </summary>
        public string DocumentSerieNumber { get; set; }
        /// <summary>
        /// Araç tipi
        /// </summary>
        public string CarType { get; set; }
        /// <summary>
        /// Araç markası
        /// </summary>
        public string CarBrand { get; set; }
        /// <summary>
        /// Araç motor bilgisi
        /// </summary>
        public string CarEngine { get; set; }
        /// <summary>
        /// Model yılı
        /// </summary>
        public int CarModelYear { get; set; }
        /// <summary>
        /// İMM
        /// </summary>
        public int IMM { get; set; }
        /// <summary>
        /// Aksesuar
        /// </summary>
        public string Accessory { get; set; }
        /// <summary>
        /// Meslek
        /// </summary>
        public string Profession { get; set; }
        /// <summary>
        /// Anahtar Kaybı + İkame:
        /// </summary>
        public bool CourtesyCar { get; set; }
        /// <summary>
        /// <see cref="InsuranceUsedType.Corporate"/> ise vergi kimlik numarası doldurulmalıdır.
        /// </summary>
        public string TaxNumber { get; set; }
    }

    public partial class NewFireRequestInsurance : InsuranceBase
    {
        /// <summary>
        /// DASK yapılacak evin adresi
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// Kullanım tipi. Mesken / Ticarethane
        /// </summary>
        public ApartmentUsedType UsedType { get; set; }
        /// <summary>
        /// Bürüt metrekare
        /// </summary>
        public int GrossSquareMeter { get; set; }
        /// <summary>
        /// Kat
        /// </summary>
        public int Floor { get; set; }
        /// <summary>
        /// Bina no
        /// </summary>
        public int StructureNo { get; set; }
        /// <summary>
        /// İnşa yılı
        /// </summary>
        public int BuildYear { get; set; }
        /// <summary>
        /// Toplam kat sayısı
        /// </summary>
        public int StructureFloorCount { get; set; }
        /// <summary>
        /// Daire no
        /// </summary>
        public int ApartmentNo { get; set; }
    }

    public partial class NewHouseRequestInsurance : InsuranceBase
    {
        /// <summary>
        /// Konut poliçesiniz varmı?
        /// </summary>
        public bool ExistHomePoicy { get; set; }
        /// <summary>
        /// Şehir plakası
        /// </summary>
        public CityEnum City { get; set; }
        /// <summary>
        /// Devam eden konut poliçesi varsa onun bitiş tarihi
        /// </summary>
        public DateTime? ExistHomePoicyEndDate { get; set; }
    }

    public partial class NewWorkPlaceRequestInsurance : InsuranceBase
    {
        /// <summary>
        /// Kullanım tipi, Mesken/Ticarethane
        /// </summary>
        public ApartmentUsedType UsedType { get; set; }
        /// <summary>
        /// Adres
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// Bürüt metrekare
        /// </summary>
        public int GrossSquareMeter { get; set; }
        /// <summary>
        /// Faturalı eşyalar
        /// </summary>
        public string InvoicedWare { get; set; }
        /// <summary>
        /// Eşyaların bedeli
        /// </summary>
        public int InvoicedWareAmount { get; set; }
        /// <summary>
        /// DEmirbaş
        /// </summary>
        public string Fixture { get; set; }
        /// <summary>
        /// CAm tutarı
        /// </summary>
        public int GlassAmount { get; set; }
        /// <summary>
        /// Elektronik cihaz
        /// </summary>
        public string ElectronicDevice { get; set; }
        /// <summary>
        /// <see cref="ApartmentUsedType.Business"/> ise vergi kimlik numarası doldurulmalıdır.
        /// </summary>
        public string TaxNumber { get; set; }
    }

    public partial class NewBesRequestInsurance : InsuranceBase
    {
        /// <summary>
        /// Doğum tarihi
        /// </summary>
        public DateTime BirthDate { get; set; }
    }
}
