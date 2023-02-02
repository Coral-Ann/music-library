using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MusicLibrary.Comptrollers;
using MusicLibrary.Models;
using MusicLibrary.Repositories;

namespace MusicLibrary.DependencyInjection
{
	public class HostBuilder
	{
		public IHost host { get; private set; }

		public HostBuilder()
		{
            // see the microsoft example this was based on here: https://learn.microsoft.com/en-us/dotnet/core/extensions/dependency-injection-usage
            host = Host.CreateDefaultBuilder()
				.ConfigureServices(services =>
				{
					services.AddSingleton<IRepository<Artist>, FakeArtistRepository>();
					services.AddTransient<ArtistsComptroller>();
				})
				.Build();
		}

		public void useBuiltService()
		{
			using IServiceScope serviceScope = host.Services.CreateScope();
			var serviceProvider = serviceScope.ServiceProvider;
			var artistComptroller = serviceProvider.GetRequiredService<ArtistsComptroller>();

			artistComptroller.DisplayAllArtists();
        }
    }
}

