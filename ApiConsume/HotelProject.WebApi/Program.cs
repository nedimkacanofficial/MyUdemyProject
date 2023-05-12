using HotelProject.BusinessLayer.Abstract;
using HotelProject.BusinessLayer.Concrete;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Burada injection işlemi yaptık aşağıda hem context sınıfını hemde scope ile hangi interface hangi
// sınfı çağıracak bunların hepsini yazdık.Örneğin burada room dal interfacesi ef room dal sınıfını getirecek.
builder.Services.AddDbContext<Context>();

builder.Services.AddScoped<IRoomDal, EfRoomDal>();
builder.Services.AddScoped<IRoomService,RoomManager>();

builder.Services.AddScoped<IServiceDal, EfServiceDal>();
builder.Services.AddScoped<IServiceService, ServiceManager>();

builder.Services.AddScoped<IStaffDal, EfStaffDal>();
builder.Services.AddScoped<IStaffService, StaffManager>();

builder.Services.AddScoped<ISubscribeDal, EfSubscribeDal>();
builder.Services.AddScoped<ISubscribeService, SubscribeManager>();

builder.Services.AddScoped<ITestimonialDal, EfTestimonialDal>();
builder.Services.AddScoped<ITestimonialService, TestimonialManager>();
/*
 * Burada cors ayarı yaptık ve bu cors ayarı tarayıcıların güvenlik politikası gereği bir apiden gelen değerleri 
 * kimin karşılayacağı ve tarayıcının güvenlik izni vermesi için kullanırız.
 * 
 * CORS, web sayfalarının bir kaynağa (örneğin, bir API) erişmesine izin verirken, 
 * kaynağın aynı kök etki alanı dışındaki web sayfalarının erişimini engellemek için 
 * kullanılan bir güvenlik mekanizmasıdır. Örneğin, bir JavaScript uygulamasının bir 
 * API'ye HTTP isteği yapması istendiğinde, tarayıcı öncelikle API'nin CORS politikalarına 
 * bakar ve istekin yapılacağı kök etki alanının (origin) API'nin izin verdiği etki alanları 
 * listesinde olup olmadığını kontrol eder. Eğer listede yoksa, tarayıcı isteği engeller.
 * Yukarıdaki kod, "OtelApiCors" adında bir CORS politikası ekler. Bu politika, tüm etki alanlarından 
 * (herhangi bir kök etki alanına izin verir), tüm başlıklardan ve tüm HTTP metodlarından istekleri kabul eder. 
 * Bu, API'nin herhangi bir kaynaktan erişilebilir olmasını sağlar. Ancak, gerçek bir uygulamada, 
 * daha sıkı CORS politikaları uygulanması gerekebilir.
 * 
 * Ayrıca burada istersek sadece belli kaynaklarada izin verebiliriz. Örneğin bir sadece kendi frontend projemiz
 * istekler atsın diyebiliriz. Bunun içinde aşağıdaki gibi bir kod kullanabiliriz.
 * 
*/
builder.Services.AddCors(options =>
{
    options.AddPolicy("OtelApiCors", builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyHeader()
               .AllowAnyMethod();
    });
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

// Aşağıdaki usecors methodu ise bu projenin kullanması gereken cors ayarlarını işaret ediyor yani yukarıdaki
// cors ayalarımızı referans alması için bildiriyoruz.
app.UseCors("OtelApiCors");

app.MapControllers();

app.Run();
