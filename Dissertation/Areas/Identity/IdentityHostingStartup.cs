using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(Dissertation.Areas.Identity.IdentityHostingStartup))]
namespace Dissertation.Areas.Identity
{
    public class IdentityHostingStartup:IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}