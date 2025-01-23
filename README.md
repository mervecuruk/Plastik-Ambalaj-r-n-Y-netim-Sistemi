# Plastik Ambalaj Ürün Yönetim Sistemi

Bu proje, plastik ambalaj ürünlerinin çevrimiçi yönetimi, sipariş süreçlerinin takibi, müşteri ilişkileri ve içerik yönetimi gibi temel işlevleri sağlamak için geliştirilmiş bir **ASP.NET Core API** uygulamasıdır.

## 🎯 Proje Amacı
Plastik ambalaj sektörü için şu işlevleri sunmayı amaçlar:
- Ürün kataloglama ve fiyat teklifi yönetimi
- Sipariş yönetimi ve sipariş aşaması takibi
- Müşteri içerik ve iletişim yönetimi
- Blog içeriği yayınlayarak sektörel bilgi sağlama
- Yönetim paneli üzerinden detaylı raporlama ve denetim

Proje, **Onion Architecture** prensiplerine uygun olarak tasarlanmıştır ve **Clean Code** ile modüler bir yapıdadır.

## 🚀 Kullanılan Teknolojiler
- **Backend Framework:** ASP.NET Core 7.0
- **Veritabanı:** Microsoft SQL Server
- **ORM:** Entity Framework Core
- **Kimlik Doğrulama:** JWT (JSON Web Token)
- **Dokümentasyon:** Swagger / OpenAPI
- **CI/CD:** Azure Pipelines
- **Loglama:** Serilog

## 🛠️ Proje Yapısı

Proje, **Onion Architecture** prensiplerine uygun olarak dört ana katmandan oluşmaktadır:

1. **DomainLayer:**
   - Uygulamanın temel iş kurallarını ve nesnelerini tanımlar.
   - "Entities", "Value Objects" ve "Interfaces" barındırır.

2. **ApplicationLayer:**
   - Uygulama mantığı ve servisleri içerir.
   - CQRS mimarisi uygulanmıştır.

3. **InfrastructureLayer:**
   - Veri erişim katmanı (EF Core ile Repository Pattern kullanılmıştır).
   - E-posta gönderimi, dosya yükleme gibi altyapı bağımlılıkları burada yer alır.

4. **API:**
   - Kullanıcıların sisteme erişim sağladığı HTTP API'lerdir.

## ✨ Özellikler

- **Admin Paneli:**
  - Sipariş durum takibi
  - Müşteri ve blog yönetimi
  - Satış raporları (günlük, haftalık, aylık)

- **Müşteri Portalı:**
  - Ürünler için fiyat teklifi alabilme
  - Sipariş durumunu görüntüleme

## 🛠️ Kurulum

### 1. Gereksinimler
- **.NET 7 SDK**
- **SQL Server**
- **Visual Studio 2022** (veya uyumlu bir IDE)

### 2. Projenin Kopyalanması
```bash
git clone <repository-url>
cd Bitirme-Projesi-API


##  3.Veritabanı Yapılandırılması
"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER;Database=YOUR_DATABASE;User ID=YOUR_USER;Password=YOUR_PASSWORD;"
}

## 4.Migration işlemleri için adımlar:
### 1. add-migration InitialCreate
### 2. update-database


##  API, varsayılan olarak https://localhost:5001 adresinde çalışır.

##  5. Swagger Kullanımı
https://localhost:5001/swagger adresini ziyaret ederek API'yi test edebilirsiniz.
📚 API Endpointleri
HTTP Metodu	Endpoint	Açıklama
GET	/api/products	Tüm ürünleri listele
POST	/api/products	Yeni bir ürün ekle
PUT	/api/products/{id}	Mevcut bir ürünü güncelle
DELETE	/api/products/{id}	Bir ürünü sil
GET	/api/orders	Siparişleri listele
POST	/api/orders	Yeni bir sipariş oluştur



🤝 Katkılar
Projeye katkıda bulunmak için bir pull request oluşturabilirsiniz.

📝 Lisans
Bu proje MIT Lisansı altında sunulmaktadır.
