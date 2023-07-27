using DAL.Entities;
using DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using ServiceLayer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<PatientDBcontext>(
    options => options.UseSqlServer( 
        builder.Configuration.GetConnectionString("narasimha")
        ));
builder.Services.AddScoped<IPatientRepository, PatientRepository>();
builder.Services.AddScoped<IPatientServiceLayer,PatientServiceLayer>();
builder.Services.AddScoped<IBillRepository1, BillRepository>();
builder.Services.AddScoped<IBillService, BillService>();
var app = builder.Build();



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
  //  pattern: "{controller=Patient}/{action=GetAllPatients}/{id?}");
pattern: "{controller=Bill}/{action=GetBillList}/{id?}");


app.Run();
