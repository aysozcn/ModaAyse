using Microsoft.EntityFrameworkCore;
using ModaAyse.Repository;
using System.Reflection;

namespace ModaAyse.API
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.

			builder.Services.AddControllers();

			#region Magration "DB i�lemleri"

			builder.Services.AddDbContext<AppDbContext>(x =>
			{
				x.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection"), option =>
				{
					//option.MigrationsAssembly("ModaAyse.Repository"); //migration katman�nda db tan�ml� ise o katmandan yaz�l�r.
					//bunun yerine Reflection yap�s� ile appdbcontext in oldugu katman� bulup ismini �ektim.
					option.MigrationsAssembly(Assembly.GetAssembly(typeof(AppDbContext)).GetName().Name);
				});
			});

			#endregion
			var app = builder.Build();

			// Configure the HTTP request pipeline.
			//orta katman 
			app.UseAuthorization();


			app.MapControllers();

			app.Run();
		}
	}
}
