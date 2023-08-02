using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public class Messages
    {
        
        public static string MaintenanceTime = "Sistem Bakımda.";
        public static string CarsListed = "Arabalar Listelendi.";
        public static string CarAdded = "Araba eklendi.";
        public static string CarNotAdded = "Araba Eklenemedi.";
        public static string CarDeleted = "Araba Silindi.";
        public static string CarByIdListed = "İstenilen Araba Bilgisi.";
        public static string CarUpdate = "Araba Güncellendi";

        public static string ColorAdded="Renk Eklendi.";
        public static string ColorDeleted = "Renk Silindi.";
        public static string ColorsListed = "Renkler Listelendi";
        public static string ColorByIdListed = "İstenilen renk Bilgisi.";
        public static string ColorUpdate = "Renk Güncellendi.";
        public static string ColorNotAdded = "Renk Eklenemedi.";
    
        public static string BrandAdded = "Marka Eklendi.";
        public static string BrandDeleted = "Marka silindi.";
        public static string BrandsListed = "Markalar Listelendi.";
        public static string BrandByIdListed = "İstenilen marka Bilgisi.";
        public static string BrandUpdate = "Marka Güncellendi.";
      
        public static string RentalAdded = "Araç Kiralanmıştır.";
        public static string RentalDeleted = "Kiralama Kaldırıldı.";
        public static string RentalListed = "Kiralanma Bilgileri Listelendi";
        public static string RentalUpdate = "Kiralama Güncellendi";
        public static string RentalByIdListed = "Seçilen Kiralama Bilgisi";
        public static string RentalNotAdded = "Kiralama işlemi Başarısız.";
        public static string RentalCarHired = "Araç halen kullanımdadır, teslim edilmemiş.";


        public static string UserDeleted = "Kullanıcı Silindi";
        public static string UserAdded = "Kullanıcı Eklendi";
        public static string UserUpdate = "Kullanıcı Bilgileri Güncellendi";
        public static string UserListed = "Kullanıcılar Listelendi";
        public static string UserByIdListed = "İstenilen müşteri bilgileri";
        public static string UserNotAdded = "Kullanıcı Eklenemedi";

        public static string CustomerAdded = "Müşteri Eklendi.";
        public static string CustomerDeleted = "Müşteri Silindi.";
        public static string CustomerUpdate = "Müşteri Bilgileri Güncellendi.";
        public static string CustomerByIdListed = "Seçilen Müşteri Bilgisi.";

        public static string CarImageAdded = "Araç resmi başarıyla yüklendi";
        public static string CarImageDeleted = "Araç resmi başarıyla silindi.";
        public static string CarImagesListed = "Araç resimleri başarıyla listelendi.";
        public static string CarImageUpdated = "Araç resmi güncellendi.";
        public static string AuthorizationDenied="Yetkilendirme yok.";
        public static string UserRegistered="Kayıt oluşturuldu";
        public static string UserNotFound="Kullanıcı bulunamadı.";
        public static string PasswordError="Şifre hatası";
        public static string SuccessfulLogin="Login başarılı";
        public static string UserAlreadyExists="Kullanıcı zaten var.";
        public static string AccessTokenCreated="Token oluşturuldu";
        public static string UserUpdated="Kullanıcı güncellendi";
    }
}
