# Ar-Project
“ZamanYolculugu_AR” projesi, artırılmış gerçeklik (AR) teknolojisini kullanarak çocuklara tarihsel dönemleri interaktif bir şekilde deneyimletmeyi amaçlayan mobil bir eğitim uygulamasıdır. Kullanıcılar, geçmişteki üç farklı tarihi döneme ait 3D modelleri fiziksel alanlarına yerleştirip inceleyebilir, etkileşimli görevlerle öğrenmeyi eğlenceli hale getirebilirler. Uygulama, öğrenmeyi oyunlaştırarak tarih bilgisini artırmayı ve merak uyandırmayı hedeflemektedir.

# Proje Dokümanları ve Dosyalar / Project Documents and Files
Bu projede kullanılan kaynaklara ve dosyalara aşağıdaki bağlantılardan ulaşabilirsiniz.

# Dokümanlar / Documents
•![ZamanYolculugu_AR_ClassDiagram](https://github.com/user-attachments/assets/f8b44053-2b6a-4d44-9c2e-787871e83d12) •![usecase](https://github.com/user-attachments/assets/dc6dcdc5-721f-4794-b69b-2cd4223b4b31) •![gant](https://github.com/user-attachments/assets/528a4561-5d98-4ddc-aa8b-655adc9fe638) •[SAAS Analizi (1).pdf](https://github.com/user-attachments/files/19826661/SAAS.Analizi.1.pdf) •[Swot Analizi.pdf](https://github.com/user-attachments/files/19826687/Swot.Analizi.pdf) •[(THS) 7.pdf](https://github.com/user-attachments/files/19826730/THS.7.pdf)




# Görseller / Images
•![Antik Mısır](https://github.com/user-attachments/assets/cbd558a3-9855-4d7f-9e3f-3cb327d90309)

# Haftalık İlerleme / Weekly Progress
# Hafta 1
Trello panosu oluşturuldu => https://trello.com/b/ym2doliA/ar-project Github repoları oluşturuldu => https://github.com/zegumi/Ar-Project 
Proje Başlangıcı ve Altyapı Kurulumu
Unity Hub üzerinden yeni bir 3D proje oluşturuldu.
Proje adı: ZamanYolculugu_AR.
Gerekli AR paketleri yüklendi:
AR Foundation
ARCore XR Plugin (Android için)
ARKit XR Plugin (iOS için)
Unity sahnesine AR Session ve AR Session Origin eklendi.
AR Raycast Manager ve AR Plane Manager bileşenleri kuruldu.

# Hafta 2
Sketchfab üzerinden .fbx formatında piramit modeli indirildi.
Unity projesine Assets/Models klasörü oluşturularak model eklendi.
PyramidSpawner GameObject'i oluşturuldu.
PlaceOnPlane script'i yazıldı ve PyramidSpawner objesine eklendi.
AR sahnesinde dokunulan düzleme piramit modeli başarıyla yerleştirildi.


# Hafta 3
Unity'de bir Canvas oluşturuldu.
Canvas içerisine Panel, Text ve Button objeleri yerleştirildi.
Panel adı: InfoPanel (başlangıçta deaktif).
UIManager script'i yazıldı:
ShowInfo() ve CloseInfo() fonksiyonları tanımlandı.
Butonun OnClick() olayına ShowInfo() fonksiyonu bağlandı.
Bilgi paneli, kullanıcı etkileşimiyle görünür hale getirildi.



# Hafta 4
Antik Mısır dönemine ait sahne oluşturuldu.
Piramit modeli sahneye yerleştirildi.
Piramit üzerine bilgi paneli eklendi:
Panelde piramidin adı ve kısa açıklaması yer aldı.
Sahne, kullanıcıların Antik Mısır dönemini deneyimleyebileceği şekilde düzenlendi.


# Hafta 5
Kullanıcının sahnedeki objelerle etkileşime geçebilmesi için dokunma olayları eklendi.
Belirli objelere tıklanıldığında bilgi panelleri gösterildi.
Kullanıcılara yönelik basit görevler tanımlandı:
Örneğin, belirli bir objeyi bulma veya belirli bir bilgiye ulaşma.



# Hafta 6
Uygulama farklı Android cihazlarda test edildi.
Kullanıcı deneyimi testleri yapıldı.
Toplanan geri bildirimler doğrultusunda UI düzenlemeleri yapıldı.
Performans iyileştirmeleri gerçekleştirildi.


# Hafta 7
Projenin son hali GitHub'a yüklendi.
Haftalık ilerleme raporları GitHub üzerinde dökümante edildi.
Proje dosyaları düzenlendi ve gereksiz dosyalar temizlendi.
Son testler yapılarak proje tamamlandı.
