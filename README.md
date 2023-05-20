# Restorant Projesi

Bu proje, Asp.net Core MVC kullanılarak geliştirilen bir restorant  uygulamasıdır. Uygulama kapsamında restorant hakkında bilgiler verirken aynı zamanda dinamik yapısı sayesinde CRUD işlemlerin yapılmasına olanak sağlar. Ayrıca menü güncelleme, rezervasyon alma vb kısımlarda mevcuttur. 

## Proje Yapısı

Proje, aşağıdaki temel bileşenlerden oluşmaktadır:

- **Controllers**: MVC uygulamasının denetleyicilerini içeren bu klasör, HTTP isteklerini işleyerek ilgili veri ve görünümlerle etkileşime geçer.
- **Models**: Veritabanı tablolarının ve iş mantığının modellerini içeren bu klasörde yer alan sınıflar, Entity Framework Core tarafından kullanılır.
- **Views**: Kullanıcı arayüzünün HTML templatelerini içeren bu klasörde yer alan dosyalar, sunucu tarafından oluşturulan içeriği kullanıcılara gösterir.


## Başlangıç

Aşağıdaki adımları izleyerek projeyi yerel bir geliştirme ortamında çalıştırabilirsiniz:

1. Proje deposunu yerel makinenize klonlayın.
2. MSSQL veritabanınıza DataBase Clone klasöründe yer alan veritabanını ekleyin.
3.`Model/Entity` dosyasında, veritabanı bağlantı dizesini güncelleyin.
4. Proje klasöründe terminali açın ve `dotnet restore` komutunu çalıştırın.
5. `dotnet ef database update` komutunu kullanarak veritabanınızı güncelleyin.
6. `dotnet run` komutunu çalıştırarak projeyi başlatın.

## Katkıda Bulunma

Eğer projeye katkıda bulunmak isterseniz, aşağıdaki adımları takip edebilirsiniz:

1. Bu repo'yı fork edin.
2. Yeni bir branch oluşturun: `git checkout -b feature/your-feature-name`.
3. Yaptığınız değişiklikleri commit edin: `git commit -am 'Add some feature'`.
4. Branch'inize push yapın: `git push origin feature/your-feature-name`.
5. Bir pull request açın.

## Proje Görselleri

![Ekran görüntüsü 2023-05-20 175758](https://github.com/samettuzuner/Restaurant_Project.Mvc/assets/23364666/219aea9e-fd41-4fa1-a15f-89497497074d)
![Ekran görüntüsü 2023-05-20 175821](https://github.com/samettuzuner/Restaurant_Project.Mvc/assets/23364666/a511d71b-55fa-4eed-8086-ce09858b6cb2)
![Ekran görüntüsü 2023-05-20 175839](https://github.com/samettuzuner/Restaurant_Project.Mvc/assets/23364666/ae6bbfd4-cd23-4d6a-b84a-27630145fbe1)
![Ekran görüntüsü 2023-05-20 175859](https://github.com/samettuzuner/Restaurant_Project.Mvc/assets/23364666/4d5d7d3c-3d63-4821-89da-345c41e88524)
![Ekran görüntüsü 2023-05-20 175920](https://github.com/samettuzuner/Restaurant_Project.Mvc/assets/23364666/7c797bf4-9c8d-4f2b-82df-bf873612b56b)
![Ekran görüntüsü 2023-05-20 175936](https://github.com/samettuzuner/Restaurant_Project.Mvc/assets/23364666/f5a31cf5-4f38-469f-a85c-056fd8b921e9)
![Ekran görüntüsü 2023-05-20 175951](https://github.com/samettuzuner/Restaurant_Project.Mvc/assets/23364666/31e59ea2-f4af-466d-8067-7e4e7dd98f4b)

## Admin Giriş Paneli

![Ekran görüntüsü 2023-05-20 175543](https://github.com/samettuzuner/Restaurant_Project.Mvc/assets/23364666/da49b0f3-4521-4780-95ba-79fcbb0f1cf8)

## Admin Menüsü

Bu menü sayesinde web sitesinde yer alan bilgileri ekleyip, silip, güncelleme yaptığımız kısımdır. Sadece admin kişileri tarafından girilir.

![1](https://github.com/samettuzuner/Restaurant_Project.Mvc/assets/23364666/fac2e12f-d18f-47e4-87fd-430871c464cc)
![2](https://github.com/samettuzuner/Restaurant_Project.Mvc/assets/23364666/1be4d04b-feba-4cbe-b031-2f9053a06798)
![3](https://github.com/samettuzuner/Restaurant_Project.Mvc/assets/23364666/7dc677be-3a9d-41ba-b97b-3a42e3f841dd)
![4](https://github.com/samettuzuner/Restaurant_Project.Mvc/assets/23364666/22e656ce-ff54-46ef-b860-c5b28065ebf6)
![5](https://github.com/samettuzuner/Restaurant_Project.Mvc/assets/23364666/49f4cbd7-5cfa-47b4-9338-4a4fa0c4af0c)
![6](https://github.com/samettuzuner/Restaurant_Project.Mvc/assets/23364666/760ae16d-56df-4210-a81c-c7719557e5f4)
![7](https://github.com/samettuzuner/Restaurant_Project.Mvc/assets/23364666/12f9564b-6db4-457f-8e89-b82a5d37d750)
![8](https://github.com/samettuzuner/Restaurant_Project.Mvc/assets/23364666/76a52708-d5c7-4cfc-8286-bcacfeb80e68)




