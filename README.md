\# Endless Runner



\## Proje Hakkında



Endless Runner, Unity oyun motoru ve C# programlama dili kullanılarak geliştirilen 3 boyutlu bir koşu oyunudur. Oyuncu sürekli ileri hareket ederken üç şerit arasında geçiş yapabilir, zıplayabilir ve eğilebilir. Yol üzerindeki coinleri toplayarak skorunu artırırken engellerden kaçınmaya çalışır. Oyuncunun canı tükendiğinde veya oyun sonu bölgesine ulaştığında oyun sona erer ve Game Over ekranı gösterilir.



\---



\## Özellikler



\- 3 şeritli karakter hareketi

\- Sürekli ileri hareket

\- Zıplama

\- Eğilme (Slide)

\- Coin toplama sistemi

\- Skor sistemi

\- Can sistemi

\- Hasar alma sistemi

\- Hasar alındığında görsel geri bildirim (Blink)

\- Dönen coin animasyonu

\- Kamera takip sistemi

\- Game Over ekranı

\- Oyunu yeniden başlatma (Restart)



\---



\# Proje Mimarisi



Proje, Unity'nin Component-Based Architecture (Bileşen Tabanlı Mimari) yaklaşımı kullanılarak geliştirilmiştir. Her oyun mekaniği ayrı bir MonoBehaviour scripti içerisinde yönetilmektedir.



\## Scriptler



\### PlayerController

Oyuncu karakterinin temel hareketlerini yönetir.



\- Sürekli ileri hareket

\- Şerit değiştirme

\- Zıplama

\- Eğilme (Slide)



\---



\### CameraController



Kameranın oyuncuyu takip etmesini sağlar.



\- Oyuncuya belirlenen mesafeyi korur.

\- Kameranın yalnızca gerekli eksenlerde hareket etmesini sağlar.



\---



\### ScoreManager



Oyuncunun skor bilgisini yönetir.



\- Coin toplandığında skoru artırır.

\- Güncel skoru kullanıcı arayüzünde gösterir.



\---



\### CoinManager



Coin ile oyuncu arasındaki etkileşimi yönetir.



\- Coin toplama

\- ScoreManager'ı tetikleme

\- Toplanan coin'i sahneden kaldırma



\---



\### HealthManager



Oyuncunun can sistemini yönetir.



\- Hasar alma

\- Kalp göstergelerini güncelleme

\- Hasar sonrası görsel geri bildirim (Blink)

\- Can bittiğinde Game Over sistemini çalıştırma



\---



\### EngelController



Oyuncunun engeller ile çarpışmasını kontrol eder.



\- Çarpışma algılama

\- Oyuncunun hasar almasını sağlama



\---



\### RotateController



Sahnedeki nesnelerin sürekli dönmesini sağlar.



\- Coin döndürme

\- Döndürülmesi gereken diğer objeleri hareket ettirme



\---



\### GameManager



Oyunun genel akışını yönetir.



\- Game Over ekranını açma

\- Oyunu durdurma

\- Oyunu yeniden başlatma



\---



\### TriggerController



Oyun sonu tetikleyicisini kontrol eder.



\- Oyuncu tetikleyiciye ulaştığında Game Over ekranını açar.



\---



\# Kullanılan Teknolojiler



\- Unity 6

\- C#

\- Unity UI

\- TextMesh Pro

\- Unity Physics

\- Git

\- GitHub



\---



\# Tasarım Yaklaşımı



Bu projede belirli bir Design Pattern uygulanmamıştır.



Proje, Unity'nin Component-Based Architecture yaklaşımına uygun olarak geliştirilmiştir. Oyun mekanikleri birbirinden bağımsız MonoBehaviour scriptleri içerisinde yönetilmektedir.



\---



\# Projeyi Çalıştırma



1\. Depoyu klonlayın.



```bash

git clone https://github.com/BeratMuhammedFirat/EndlessRunner.git

```



2\. Unity Hub üzerinden projeyi açın.



3\. Gerekli paketlerin yüklenmesini bekleyin.



4\. Proje sahnesini açın.



5\. Play butonuna basarak oyunu çalıştırın.



\---



\# Kontroller



| Tuş | İşlev |

|------|--------|

| A | Sol şeride geç |

| D | Sağ şeride geç |

| Space | Zıpla |

| S | Eğil (Slide) |



\---



\# Geliştirici



\*\*Berat Muhammed Fırat\*\*

