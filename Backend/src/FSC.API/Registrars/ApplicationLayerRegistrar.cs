// using DE.Application.Commands.Master.CostCenters;
using DE.Application.Services.Helper;
using DE.Application.Services.UnitOfWork;
using DE.Infrastructure.HTTP;

namespace DE.API.Registrars
{
    public class ApplicationLayerRegistrar : IWebApplicationBuilderRegistrar
    {
        public void RegisterServices(WebApplicationBuilder builder)
        {
            builder.Services.AddSession(options =>
            {
                options.IOTimeout = TimeSpan.FromMinutes(10);
            });
            
            builder.WebHost.ConfigureKestrel(k =>
            {
                k.Limits.MaxRequestHeadersTotalSize = 64 * 1024;
                k.Limits.MaxRequestBufferSize = 64 * 1024;

                //removes the 'Server' header from responses
                k.AddServerHeader = false;
            });
            
            // builder.Services.AddMediatR(typeof(CreateCostCenter));
            // builder.Services.AddAutoMapper(typeof(Program), typeof(CreateCostCenter));

            // application layer DI  
            builder.Services.AddScoped<IHttpService, HttpService>();
            builder.Services.AddHttpClient<IIdentityService, IdentityService>();
            builder.Services.AddScoped<IIdentityService, IdentityService>();
            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
            builder.Services.AddScoped<IEmailSender, EmailSenderService>();
            builder.Services.AddScoped<IFileStorageService, LocalFileStorageService>();
            builder.Services.AddScoped<UserService, UserService>();
            //builder.Services.AddScoped<UserActivityFilter>();
        }
    }
}
