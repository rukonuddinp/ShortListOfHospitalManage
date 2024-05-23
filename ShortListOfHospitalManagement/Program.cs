using Microsoft.EntityFrameworkCore;
using ShortListOfHospitalManagement.Context;
using ShortListOfHospitalManagement.Models;
using ShortListOfHospitalManagement.Repository.Manager;
using ShortListOfHospitalManagement.Repository.Service.Interface;
using ShortListOfHospitalManagement.Repository.Service.RepoService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<HospitalContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped<IPatientRepository, PatientRepository>();
builder.Services.AddScoped<IDiseaseRepository, DiseaseRepository>();
builder.Services.AddScoped<IGenericRepository<NCD>, NCDRepository>();
builder.Services.AddScoped<IGenericRepository<Allergy>, AllergyRepository>();
builder.Services.AddScoped<IGenericRepository<NCD_Detail>, NCDDetailRepository>();
builder.Services.AddScoped<IGenericRepository<Allergies_Detail>, AllergyDetailRepository>();
builder.Services.AddControllersWithViews();

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
    pattern: "{controller=Patient}/{action=Patient_View}/{id?}");

app.Run();
