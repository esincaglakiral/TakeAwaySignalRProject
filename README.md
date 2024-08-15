# SignalR ile Gerçek Zamanlı Sipariş Takip Sistemi
### Proje Tanıtımı: 
- Bu proje, .NET 6.0 teknolojisi ve SignalR kullanarak geliştirilmiş bir mini projedir. Amaç, SignalR'in gerçek zamanlı veri iletişimi yeteneklerini öğrenmek ve uygulamaktır. Proje, iki ana katmandan oluşmaktadır: WebApi ve WebUI.
### Proje Mimarisi:
- WebApi Katmanı: Bu katman, veri erişimini sağlayan ve iş mantığını barındıran servisleri içermektedir. Veri modeli olarak bir teslimat (Delivery) sınıfı tanımlanmıştır. Teslimatların toplam sayısı ve durumlarına göre sayıları gibi bilgiler bu katman üzerinden sağlanmaktadır.
- WebUI Katmanı: Bu katman, kullanıcı arayüzünü ve SignalR hub'ı üzerinden gerçek zamanlı veri güncellemelerini barındırmaktadır. Kullanıcılar, sipariş durumlarını ve detaylarını anlık olarak bu arayüz üzerinden takip edebilmektedir.

### Teknik Detaylar:
- SignalR Kullanımı: SignalR, sunucu ile istemci arasında iki yönlü iletişim kurmayı sağlayan bir kütüphanedir. Bu projede, teslimatların durumu ve toplam sayısı gibi bilgileri gerçek zamanlı olarak kullanıcıya iletmek için kullanılmıştır. İlgili SignalR Hub sınıfı, bu bilgileri tüm bağlı istemcilere göndermektedir.

- Veri Modelleri:
- - Delivery (Teslimat): Teslimat kimliği, ürün adı, durumu, miktarı, fiyatı ve toplam fiyatı gibi özellikler içermektedir.
 
- WebApi Controller'ları:
- - TotalDeliveryCount: Toplam teslimat sayısını döndürür.
- - TotalDeliveryCountStatusByYolda: Yolda olan teslimatların sayısını döndürür.
- - TotalDeliveryCountStatusByHazirlaniyor: Hazırlanan teslimatların sayısını döndürür.
 
### Kullanıcı Arayüzü

- Anasayfa (Index View): Kullanıcılara, toplam sipariş sayısı, yoldaki sipariş sayısı, hazırlanmakta olan sipariş sayısı ve teslim edilen sipariş sayısı gibi bilgiler sunulmaktadır. Bu veriler her saniyede bir güncellenir.

![1](https://github.com/user-attachments/assets/6aa09ebd-9f17-4aaf-9fa5-0c0e717c61d0)

------------------------------------------------------------------------------------------------
- Sipariş Listesi (DeliveryList View): Tüm teslimatların listesi tablo formatında gösterilmektedir. Bu liste, her beş saniyede bir güncellenerek kullanıcılara en güncel veriler sunulmaktadır.
![2](https://github.com/user-attachments/assets/c2c2f0ff-35ef-4437-9fa9-5fb6244fed9b)


=> Bu proje, SignalR teknolojisinin nasıl kullanılacağını ve .NET tabanlı bir uygulamada gerçek zamanlı veri iletişiminin nasıl sağlanabileceğini göstermektedir. Gerçek zamanlı sipariş takip sistemi gibi uygulamalarda SignalR'in potansiyel gücünü etkili bir şekilde ortaya koymaktadır.



### Projeye ait görseller:


![3](https://github.com/user-attachments/assets/0f5eee46-8d7d-4021-bd55-f1c2f7536a3c)

![5](https://github.com/user-attachments/assets/8de1bc9e-90d7-4c98-bc32-b3bb47176017)

![7](https://github.com/user-attachments/assets/3de087da-d073-417c-ae8f-0b2f912179d4)

![6](https://github.com/user-attachments/assets/6ab12bbe-19f5-46dd-82d2-5ad482eab917)

![8](https://github.com/user-attachments/assets/3f585098-533b-4763-9ea2-9443ba500cfe)

![9](https://github.com/user-attachments/assets/18cce141-6779-4201-a8df-478d505b6f93)

![10](https://github.com/user-attachments/assets/e722819a-8f80-4d76-9663-becc2b6c4209)






