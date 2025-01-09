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

			#region Magration "DB iþlemleri"

			builder.Services.AddDbContext<AppDbContext>(x =>
			{
				x.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection"), option =>
				{
					//option.MigrationsAssembly("ModaAyse.Repository"); //migration katmanýnda db tanýmlý ise o katmandan yazýlýr.
					//bunun yerine Reflection yapýsý ile appdbcontext in oldugu katmaný bulup ismini çektim.
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
