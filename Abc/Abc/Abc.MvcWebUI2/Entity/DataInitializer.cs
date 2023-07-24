using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Abc.MvcWebUI2.Entity
{
    public class DataInitializer:DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            // 1.list kategory yerine var yazabilirsin.
            List<Category> kategoriler = new List<Category>()
            {
                new Category(){Name="Kamera",Description="Kamera Ürünleri"},
                new Category(){Name="Bilgisayar",Description="Bilgisayar Ürünleri"},
                new Category(){Name="Elektronik Cihazlar",Description="Elektronik Ürünleri"},
                new Category(){Name="Telefon",Description="Telefon Ürünleri"},
                new Category(){Name="Beyaz eşya",Description="Beyaz Eşya Ürünleri"}

            };

            foreach(var kategori in kategoriler)
            {
                context.Categories.Add(kategori);
            }
            context.SaveChanges();



            List<Product> urunler = new List<Product>()
            {
                new Product(){Name="Canon Eos 1200D 18-55 mm Dc Profesyonel Dijital Fotograf Makinesi",Description="Ürün kullanımı kolay sağlam ve dayanıklıdır. Odak çok iyidir.",Price=7000, Stock= 10, IsApproved= true , CategoryId=1, IsHome=true, Image="1.jpg"},
                new Product(){Name="Canon Eos 100D 18-55 mm Dc Profesyonel Dijital Fotograf Makinesi",Description="Ürün taşınabilirliği kolaydır. En uzak noktaları bile rahat görmeyi sağlar",Price=8000 , Stock=30 , IsApproved= true , CategoryId=1, IsHome=true, Image="2.jpg"},
                new Product(){Name="Canon Eos 700D 18-55 Dc Profesyonel Dijital Fotograf Makinesi",Description="Ürün en küçük detayı bile çok net bir şekilde gösterir ve görüş mesafesi yüksektir.",Price=9000 , Stock=50 , IsApproved= false , CategoryId=1, IsHome=true, Image="3.jpg"},
                new Product(){Name="Canon Eos 100D 18-55 mm IS STM Kit DSLR  Fotograf Makinesi",Description="Ürünün ağırlığı çok hafiftir. Boyutu küçüktür. Geniş açı görünüm sağlar.Yüksek hassasiyetli netleme, nesnenizin keskinliğini kaybetmemesini sağlar",Price= 15000 , Stock=8 , IsApproved= true , CategoryId=1, IsHome = true, Image = "4.jpg"},
                new Product(){Name="Canon Eos 700D + 18-55  IS STM+Çanta+ 16 Hb Hafıza Kartı ",Description="Ürün panorama görüş açısı sağlar ve farklı mercekleri mevcuttur. taşınabilirliği kolay, kalitsi ise yüksektir.",Price= 6500, Stock=35 , IsApproved= true, CategoryId=1, Image="5.jpg"},


                new Product(){Name="Dell Inspiron 5567 Inel Core i5 7200U",Description="Hep hazır, hep şarjlı: Prize bağlı geçirdiğiniz süreyi azaltan pilinizi 60 dakikada %80'e kadar şarj eden ExpressCharge özelliğine sahiptir.",Price= 6800 , Stock=55 , IsApproved= true , CategoryId=2 , IsHome=true, Image="1.jpg"},
                new Product(){Name="Lenova Ideapad 310 Intel Core i7 7500U",Description="Mikro kenarlı ekran; daha büyük bir ekranı daha küçük bir çerçeveye sığdıran ve ultra inceliğiyle zar zor görülebilen bu çerçeve verimli tasarımıyla cihazınızın görünümünde çığır açıyor.",Price= 8000, Stock= 42, IsApproved= true , CategoryId=2, IsHome = true, Image = "2.jpg"},
                new Product(){Name="Asus UX310UQ-FB418T Intel Core i7 7200U",Description="Bu cihaz daha az yer kaplar ve üç adede kadar renk seçeneği ile her yerde güzel görünür. Güncellenen termal tasarımdan HD kameraya kadar bu dizüstü bilgisayar her şeye sahiptir",Price=8900 , Stock=32 , IsApproved= true , CategoryId=2, Image = "3.jpg"},
                new Product(){Name="Asus UX310UQ-FB418T Intel Core i7 7500U",Description="NVIDIA GeForce RTX 3050, GeForce RTX 3050 dizüstü bilgisayarlarla 2. nesil RTX gücüne ulaş; gücünü, DLSS gibi modern yapay zeka özelliklerini ve ışın izlemeli grafikleri kullanmak için yeni RT çekirdekler  Ampere mimarisinden alır",Price= 3400, Stock=61 , IsApproved= true , CategoryId=2, Image = "4.jpg"},
                new Product(){Name="Asus N580VD-DM160T Intel Core i7 7200U ",Description="Kablolu veya Kablosuz Ağ: Daha esnek kurulum için kameranızı Ethernet veya WiFi üzerinden ağa bağlayın.Güvenli Depolama: Bir microSD kartta 128 GB'a kadar 3MP videoyu yerel olarak depolar ve video çekimlerinize kolay erişim sağlar",Price= 4200, Stock= 43, IsApproved= true , CategoryId=2, Image = "5.jpg"},



                new Product(){Name="LG 49UH610V",Description=" LG Kameranın pili azaldığında, kimse yeniden şarj etmek için saatlerce beklemek istemez. cihazınızı fişe taktıktan sonra yaklaşık 30 dakika içinde 0'dan %50 şarj düzeyine ulaşırsınız.           ",Price= 7800 , Stock=32 , IsApproved= true , CategoryId=3, IsHome = true, Image = "1.jpg"},
                new Product(){Name="Vestel 49UB8300",Description=" Güvenli Depolama: Bir microSD kartta 128 GB'a kadar 3MP videoyu yerel olarak depolar ve video çekimlerinize kolay erişim sağlar.Gelişmiş Gece Görüşü: Tamamen karanlıkta bile 30m 'ye kadar görsel mesafe sağlar.",Price= 8300, Stock= 52, IsApproved= true , CategoryId=3, IsHome = true, Image = "2.jpg"},
                new Product(){Name="Samsung 55KU7500",Description="Wi-Fi, NFC ve  Connect uygulaması, Hassas Otomatik Odaklama, 3,0 fps ve DIGIC 4+ işleme özelliği.ZV-1F ile pil gücünün bitmesinden endişe etmeden hareket halinde çekimin keyfini çıkabilirsiniz",Price=9900 , Stock=12 , IsApproved= true , CategoryId=3, Image = "3.jpg"},
                new Product(){Name="LG 55UH7500",Description="",Price= 4400, Stock=51 , IsApproved= true , CategoryId=3, Image = "4.jpg"},
                new Product(){Name="Sony Kd-55Xd7005B",Description="4K Ultra HD (3840 x 2160) kayıt.5 eksenli Akıllı Aktif modlu Balanced Optical SteadyShot.26,8 mm geniş açılı ZEISS Vario-Sonnar T lens.20x optik zoom ve 30x/40x (4K/HD) Clear Image Zoom  ",Price= 7200, Stock= 33, IsApproved= true , CategoryId=3, Image = "5.jpg"},


                new Product(){Name="Canon AX10PKS",Description="Entegre belleğe sahip 20,1 milyon piksel Exmor RS 1.0 tipi yığın CMOS görüntü sensörü sayesinde ZV-1F, loş ışıklı konumlarda çekim yaparken bile net videolar yakalayabilir.Sadece LCD panele dokunarak tercih ettiğiniz görünümü kolayca zumlayabilirsiniz",Price= 1200 , Stock=85 , IsApproved= true , CategoryId=4, IsHome = true, Image = "1.jpg"},
                new Product(){Name="Apple iPhone SE",Description="Dayanıklı tasarım ve IP67 suya dayanıklılık derecesi.Güvenli kimlik doğrulama için Touch ID özellikli Ana Ekran düğmesi iPhone ile her zamankinden daha fazlasını yapmanızı sağlayan yeni özelliklerle dolu iOS 15",Price= 1500, Stock= 72, IsApproved= true , CategoryId=4, IsHome = true, Image = "iphonese.jpg"},
                new Product(){Name="Apple iPhone 11",Description="Portre modu, 4K video kaydı ve ağır çekim özelliklerine sahip 12 MP TrueDepth ön kamera. Güvenli kimlik doğrulama için Face ID. Üçüncü nesil Neural Engine birimine sahip A13 Bionic çip",Price=5400 , Stock=54 , IsApproved= true , CategoryId=4, Image = "iphone11.jpg"},
                new Product(){Name="Case 4U manyetik Mıknatıslı Araç içi Telefon Tutucu ",Description="Case 4U manyetik Mıknatıslı Araç içi Telefon Tutucu Kaymaz, İz bırakmaz. Otomatik kıskançlı ve açılır ayarlı uzayabilir tutucu. Renkleri ışığa dönüşür aydınlatma sağlar.",Price= 8500, Stock=8 , IsApproved= true , CategoryId=4, Image = "4.jpg"},
                new Product(){Name="Xiaomi Mi 11t Pro",Description="Çizilmeye karşı dayanıklı PC, telefonu hafif ve cep dostu tutar.Air Cushion Technology ile mil sınıfı sertifikalı düşme koruması.Xiaomi Mi 10T / Mi 10T Pro / Redmi K30s ile Uçtan Uca Mükemmel bir Özel Uyum Sağlar",Price= 3200, Stock= 57, IsApproved= true , CategoryId=2, Image = "xiaomi.jpg"}

            };

            foreach(var urun in urunler)
            {
                context.Products.Add(urun);

            }
            context.SaveChanges();




            base.Seed(context);
        }
    }
}