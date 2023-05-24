var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Bunu http isteklerini kullanabilmek için ilgili arayüzün dependency injection ile inject edilmesini sağlamak içindir.
/*
 * AddHttpClient() metodu, HttpClient sınıfının Dependency Injection (DI) tarafından yönetilmesini sağlar. 
 * Bu yöntem, HttpClient kullanarak uzak bir kaynağa (örneğin, bir API'ya) HTTP istekleri göndermek için 
 * kullanılan bir HttpMessageHandler örneği oluşturur ve yapılandırır. 
 * Bu metot aynı zamanda, IHttpClientFactory arayüzü üzerinden HttpClient örneği oluşturmak için de kullanılır. 
 * Bu, HttpClient örneği oluşturma ve yönetim işlemlerini kolaylaştırır. Örneğin, HttpClient nesnelerinin çok sayıda 
 * istemci tarafından paylaşılmasını kolaylaştırır ve bunları özelleştirmek için daha kolay bir yol sağlar. 
 */
builder.Services.AddHttpClient();

builder.Services.AddAutoMapper(typeof(Program));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
