using DSVBooking.Services;
using DSVBooking.Repository;

namespace DSVBooking
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddSingleton<IRoomRepository, RoomCollectionRepository>();
            builder.Services.AddSingleton<RoomService>(); // Add services to the container.
            builder.Services.AddSingleton<IBookRepository, BookCollectionRepository>();
            builder.Services.AddSingleton<BookService>(); // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddSingleton<IMovingRepository, MovingCollectionRepository>();
            builder.Services.AddSingleton<MovingService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}
