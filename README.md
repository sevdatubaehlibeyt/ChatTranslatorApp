🤖 GroqSharp: Ultra-Fast C# Desktop Chatbot GroqSharp, C# Windows Forms mimarisi üzerine inşa edilmiş, dünyanın en hızlı çıkarım motoru olan Groq LPU™ kullanan modern bir masaüstü yapay zeka geliştirmesidir. Bu uygulama, bulut tabanlı bir LLM (Large Language Model) ile yerel bir masaüstü dağıtımını kusursuz bir şekilde birleştirir.

✨ Öne Çıkan Özellikler ⚡ Işık Hızında Yanıtlar: Groq'un özel donanımı sayesinde seçkin kelime (token) üretim hızı.

🧠 Zeki Modeller: Meta'nın en gelişmiş açık kaynaklı modeli olan llama-3.3-70b-versatile Özet.

🌐 Kesintisiz İletişim: HttpClient ve JSON tabanlı asenkron veri aktarımı.

🛡️ Güvenli Mimari: async/await yapısı ile ana iş parçasıcığını (UI thread) dondurmadan arka planda işlem yapma.

📉 Düşük Kaynak Tüketimi: Model bulutta büyük başarı elde etmek için düşük donanımlı bilgisayarlarda bile yüksek performans.

🛠️ Teknik Altyapı Dil: C# (.NET Framework / .NET 8.0)

Arayüz: Windows Forms (WinForms)

Veri İşleme: Newtonsoft.Json

API Sağlayıcı: Groq Cloud

🚀 Başlangıç

Hazırlık Visual Studio üzerinde Newtonsoft.Json NuGet paketlerini projenize dahil edin.

API Yapılandırması Groq Console üzerinden ücretsiz bir API anahtarı alın ve koddaki ilgili alana açılır:

C#

özel const string ApiKey = "gsk_your_api_key_here"; 3. Derleme Projeyi F5 ile başlatma ve yapay zeka ile sohbet etmeye başlayın!

📋 Proje Yapısı Form1.cs: Ana uygulama mantığı ve API iletişimi.

Form1.Designer.cs: Görsel olarak (TextBox, Button, ListBox) tanımları.

App.config: Uygulama ayarları ayarları.
