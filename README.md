# 🏃 Endless Runner

Unity ve C# kullanılarak geliştirilen 3 boyutlu Endless Runner oyunu.

---

# 📑 İçindekiler

- [Proje Hakkında](#-proje-hakkında)
- [Özellikler](#-özellikler)
- [Proje Mimarisi](#-proje-mimarisi)
- [Kullanılan Teknolojiler](#-kullanılan-teknolojiler)
- [Tasarım Yaklaşımı](#-tasarım-yaklaşımı)
- [Kurulum](#-kurulum)
- [Kontroller](#-kontroller)

---

# 📖 Proje Hakkında

Oyuncu sürekli ileri hareket ederken üç şerit arasında geçiş yapabilir, zıplayabilir ve eğilebilir. Yol üzerindeki coinleri toplayarak skorunu artırır, engellere çarptığında can kaybeder ve canı bittiğinde oyun sona erer.

---

# ✨ Özellikler

- ✅ 3 şeritli hareket
- ✅ Sürekli ileri hareket
- ✅ Zıplama
- ✅ Eğilme (Slide)
- ✅ Coin toplama
- ✅ Skor sistemi
- ✅ Can sistemi
- ✅ Hasar alma efekti
- ✅ Kamera takip sistemi
- ✅ Game Over ekranı
- ✅ Restart sistemi

---

# 🏗️ Proje Mimarisi

| Script | Görevi |
|---------|--------|
| PlayerController | Karakter hareketlerini yönetir. |
| CameraController | Kameranın oyuncuyu takip etmesini sağlar. |
| ScoreManager | Skor bilgisini yönetir. |
| CoinManager | Coin toplama işlemlerini gerçekleştirir. |
| HealthManager | Can sistemini yönetir. |
| EngelController | Çarpışmaları kontrol eder. |
| RotateController | Coinlerin dönmesini sağlar. |
| GameManager | Game Over ve Restart işlemlerini yönetir. |
| TriggerController | Oyun sonu tetikleyicisini kontrol eder. |

---

# 🛠️ Kullanılan Teknolojiler

| Teknoloji | Açıklama |
|-----------|----------|
| Unity 6 | Oyun Motoru |
| C# | Programlama Dili |
| TextMesh Pro | Arayüz Metinleri |
| Unity UI | Kullanıcı Arayüzü |
| Git | Sürüm Kontrol |
| GitHub | Proje Yönetimi |

---

# 📐 Tasarım Yaklaşımı

Bu projede belirli bir Design Pattern kullanılmamıştır.

Oyun, Unity'nin **Component-Based Architecture** yapısına uygun olarak geliştirilmiştir.

---

# 🚀 Kurulum

```bash
git clone https://github.com/BeratMuhammedFirat/EndlessRunner.git
```

Unity Hub üzerinden projeyi açın ve Play tuşuna basarak çalıştırın.

---

# 🎮 Kontroller

| Tuş | İşlev |
|------|-------|
| A | Sol şerit |
| D | Sağ şerit |
| Space | Zıplama |
| S | Eğilme |

---

# 👨‍💻 Geliştirici

**Berat Muhammed Fırat**