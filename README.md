# 📦 Stok ve Satış Takip Uygulaması

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Windows Forms](https://img.shields.io/badge/Windows%20Forms-0078D6?style=for-the-badge&logo=windows&logoColor=white)

Kullanıcıların sisteme ürün, stok ve fiyat bilgisi ekleyebildiği, anlık stok analizlerini görüntüleyebildiği ve satış işlemleriyle stokları dinamik olarak güncelleyebildiği **C# Windows Forms** masaüstü uygulamasıdır.

---

## 🖥️ Uygulama Görselleri

### 1. Ürünler Sekmesi (Ürün Ekleme & İstatistikler)
Kullanıcı ürün adı, stok adedi ve birim fiyat bilgilerini girerek sisteme yeni ürün ekler. Sağ taraftaki bilgi panelinde toplam ürün sayısı, ortalama ürün fiyatı, en ucuz/en pahalı ürünler ve stok durumu en az/en fazla olan ürünler anlık olarak hesaplanıp listelenir.

<p align="center">
  <img src="urunler.png" alt="Ürünler ve İstatistik Ekranı" width="700">
</p>

### 2. İşlemler Sekmesi (Satış & Güncel Stok Takibi)
Kullanıcı açılır listeden mevcut bir ürünü seçip satış adedini belirleyerek **Sat** butonuna tıkladığında, satılan miktar mevcut stoktan düşülür ve sağ taraftaki listede tüm ürünlerin güncel stok durumu anında yenilenir.

<p align="center">
  <img src="islemler.png" alt="Satış İşlemleri ve Güncel Stok Ekranı" width="700">
</p>

---

## ✨ Özellikler

* **Ürün ve Envanter Yönetimi:** Ürün adı, stok miktarı ve fiyat girişi ile dinamik kayıt oluşturma.
* **Anlık Envanter Analizi:** Eklenen ürünler üzerinden otomatik olarak;
  * Toplam ürün çeşidi sayısını,
  * Ürünlerin ortalama fiyatını,
  * En ucuz ve en pahalı ürünleri,
  * Stok adedi en az ve en fazla olan ürünleri hesaplama.
* **Dinamik Satış ve Stok Düşümü:** Seçilen ürün ve satış adedine göre stok güncellemesi ve güncel stok listesinin eşzamanlı yenilenmesi.

---

## 🛠️ Kullanılan Teknolojiler

* **Dil:** C#
* **Arayüz:** Windows Forms (WinForms)
* **Geliştirme Ortamı:** Visual Studio
