var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); //hem controller hem viewsleri bir arada kullanmak i�in gerekli olan servisleri ekleriz.


var app = builder.Build();

app.UseStaticFiles(); //wwwroot kullan�laca�� i�in. yani static dosyalar kullanaca��m�z i�in



app.MapControllerRoute(
    
    name:"default",
    pattern:"{controller=Home}/{action=Index}"
    );

app.Run();


//Model:Veri eri�iminin ger�ekle�ti�i i� mant���n�n olu�turuldu�u b�l�md�r.�rne�in classlar burada bulunur.

//View: Projede kullan�c� aray�zlerinin olu�turuldu�u b�l�md�r. Modelden al�nan verileri kullan�c�ya g�sterir. Ayn� zamanda kullan�c�dan al�nan istekleri controllera iletmektedir.


//Controller:View ile model aras�ndaki ba�lant�n�n kuruldu�u b�l�md�r.Kullan�c�dan viewler arac�l���yla al�nan requestler controllerda de�erlendirilir ve kullan�c�ya hangi viewin response edilece�i belirtilir. 

//Action:Controllerlar i�erisinde tan�mlanan methodlard�r.

//Razor:ASP.NET Core ve ASP.NET MVC gibi Microsoft'un web geli�tirme platformlar�nda kullan�lan --bir �ablonlama motorudur--. Razor, sunucu taraf�nda �al��an dinamik web sayfalar� olu�turmak i�in HTML i�aretleme diliyle birlikte C# veya VB.NET kodlar�n� bir araya getirir. Razor dosyalar� genellikle .cshtml (C# ile) veya .vbhtml (VB.NET ile) uzant�s�na sahiptir.

//RazorView:Razor View, ASP.NET Core MVC veya ASP.NET MVC uygulamalar�nda, kullan�c�ya sunulacak olan HTML tabanl� i�erikleri dinamik olarak olu�turmak i�in kullan�lan bir �ablon dosyas�d�r. Razor View'ler, Razor �ablonlama motoru kullan�larak yaz�l�r ve --**genellikle .cshtml dosya uzant�s�na sahiptir.--**

//wwwroot:static dosyalar� tuttu�umuz klas�rd�r

//builder.Build():builder.Build() metodu, ASP.NET Core uygulamas�n�n ba�lat�lmas� i�in gerekli olan yap�land�rmay� tamamlay�p, uygulama nesnesini (WebApplication) olu�turur. --**Bu a�amadan sonra uygulama, HTTP isteklerini i�lemek �zere haz�r hale gelir.--**

//app.Run():app.Run(), ASP.NET Core'da gelen HTTP isteklerine verilen yan�t� �retmek ve iste�i sonland�rmak i�in kullan�lan bir metottur. Bu metod genellikle middleware zincirinin sonunda kullan�l�r ve istek i�leme s�recini sonland�r�r.
