# TraversalTwo

Seyahat/tur rezervasyon sitesi. ASP.NET Core ile N-Tier mimari kullanılarak geliştirildi; Identity tabanlı kullanıcı girişi, hedef (destination) listeleme ve detay sayfaları, iletişim/bülten formları gibi bir seyahat acentesi sitesinin temel akışlarını içerir.

## Teknoloji Stack

- ASP.NET Core
- Entity Framework Core (Code-First migrations)
- ASP.NET Core Identity (kullanıcı girişi/kaydı)
- MSSQL
- Repository Pattern / N-Tier mimari
- FluentValidation tarzı validator sınıfları (ValidationRules)

## Proje Yapısı

```
TraversalTwo/
├── EntityLayer/          # Domain modelleri (Destination, About, Feature, Guide, Testimonial, ...)
├── DataAccessLayer/      # DbContext, Repository implementasyonları, migrations
├── BusinessLayer/        # Servisler, validator'lar, DI kayıtları
└── TraversalTwo/          # Web (Controllers, Views, ViewComponents, wwwroot)
```

## Mimari Kararlar

- **N-Tier Architecture**: Entity, DataAccess, Business ve Web katmanları birbirinden ayrıldı.
- **Repository Pattern**: Veri erişimi `GenericRepository` üzerinden soyutlandı.
- **ViewComponent tabanlı anasayfa**: Slider, Feature, PopularDestination, Stats, SubAbout, Testimonial gibi bölümler ayrı ViewComponent'ler olarak kurgulandı.

## Arayüz Şablonları Hakkında

`wwwroot` altındaki `Login_v1`, `Traversal-Liberty` ve `colorlib-regform-26` klasörleri, bir Udemy kursuyla birlikte sağlanan üçüncü taraf tasarım şablonlarıdır (giriş/kayıt ekranları ve ana site teması). Backend mimarisi ve iş mantığı bu projeye ait özgün çalışmadır; arayüz şablonları `.gitattributes` üzerinden `linguist-vendored` olarak işaretlenmiştir.

## Kurulum

```bash
git clone https://github.com/ridvancomez/TraversalTwo.git
cd TraversalTwo
dotnet restore
dotnet ef database update --project DataAccessLayer --startup-project TraversalTwo
dotnet run --project TraversalTwo
```

## Durum

🚧 Aktif geliştirme aşamasında.
