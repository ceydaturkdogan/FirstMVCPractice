var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); //hem controller hem viewsleri bir arada kullanmak için gerekli olan servisleri ekleriz.


var app = builder.Build();

app.UseStaticFiles(); //wwwroot kullanýlacaðý için. yani static dosyalar kullanacaðýmýz için



app.MapControllerRoute(
    
    name:"default",
    pattern:"{controller=Home}/{action=Index}"
    );

app.Run();


//Model:Veri eriþiminin gerçekleþtiði iþ mantýðýnýn oluþturulduðu bölümdür.Örneðin classlar burada bulunur.

//View: Projede kullanýcý arayüzlerinin oluþturulduðu bölümdür. Modelden alýnan verileri kullanýcýya gösterir. Ayný zamanda kullanýcýdan alýnan istekleri controllera iletmektedir.


//Controller:View ile model arasýndaki baðlantýnýn kurulduðu bölümdür.Kullanýcýdan viewler aracýlýðýyla alýnan requestler controllerda deðerlendirilir ve kullanýcýya hangi viewin response edileceði belirtilir. 

//Action:Controllerlar içerisinde tanýmlanan methodlardýr.

//Razor:ASP.NET Core ve ASP.NET MVC gibi Microsoft'un web geliþtirme platformlarýnda kullanýlan --bir þablonlama motorudur--. Razor, sunucu tarafýnda çalýþan dinamik web sayfalarý oluþturmak için HTML iþaretleme diliyle birlikte C# veya VB.NET kodlarýný bir araya getirir. Razor dosyalarý genellikle .cshtml (C# ile) veya .vbhtml (VB.NET ile) uzantýsýna sahiptir.

//RazorView:Razor View, ASP.NET Core MVC veya ASP.NET MVC uygulamalarýnda, kullanýcýya sunulacak olan HTML tabanlý içerikleri dinamik olarak oluþturmak için kullanýlan bir þablon dosyasýdýr. Razor View'ler, Razor þablonlama motoru kullanýlarak yazýlýr ve --**genellikle .cshtml dosya uzantýsýna sahiptir.--**

//wwwroot:static dosyalarý tuttuðumuz klasördür

//builder.Build():builder.Build() metodu, ASP.NET Core uygulamasýnýn baþlatýlmasý için gerekli olan yapýlandýrmayý tamamlayýp, uygulama nesnesini (WebApplication) oluþturur. --**Bu aþamadan sonra uygulama, HTTP isteklerini iþlemek üzere hazýr hale gelir.--**

//app.Run():app.Run(), ASP.NET Core'da gelen HTTP isteklerine verilen yanýtý üretmek ve isteði sonlandýrmak için kullanýlan bir metottur. Bu metod genellikle middleware zincirinin sonunda kullanýlýr ve istek iþleme sürecini sonlandýrýr.
