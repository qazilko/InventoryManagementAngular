using InventoryManagementAngular.Repository;
using InventoryManagementAngular.Service;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddCors(options =>
{
    options.AddPolicy("CORSPolicy",
        builder => builder
        .AllowAnyMethod()
        .AllowAnyHeader()
        .AllowCredentials()
        .SetIsOriginAllowed((hosts) => true));
});

// Add services to the container.
builder.Services.AddScoped<IDapperService, DapperService>();
builder.Services.AddScoped<ISupplierRepository, SupplierRepository>();
builder.Services.AddScoped<IPurchaseRepository , PurchaseRepository >();
builder.Services.AddScoped<IItemRepository, Itemrepository>();
builder.Services.AddScoped<IcityRepository, cityrepository>();
builder.Services.AddScoped<IregistrationRepository, registrationrepository>();
builder.Services.AddScoped<ICheckBalRepository, CheckBalrepository>();
builder.Services.AddScoped<ItransactionRepository, transactionrepository>();
builder.Services.AddScoped<IusersRepository, usersrepository>();
builder.Services.AddScoped<ILoginRepository, Loginrepository>();
builder.Services.AddDbContext<InventoryManagementAngular.DataContext.AppContext>();

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

app.UseCors("CORSPolicy");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
