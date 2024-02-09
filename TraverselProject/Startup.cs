using BusinessLayer.Container;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.IO;
using TraverselProject.CQRS.Handlers.DestinationHandlers;
using TraverselProject.Models;

namespace TraverselProject
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			//cqrs
			services.AddScoped<GetAllDestinationQueryHandler>();
			services.AddScoped<GetDestinationByIDQueryHandler>();
			services.AddScoped<CreateDestinationCommandHandler>();
			services.AddScoped<RemoveDestinationCommandHandler>();
			services.AddScoped<UpdateDestinationCommandHandler>();

			//mediatR
			services.AddMediatR(typeof(Startup));

			//loglama i�in
			services.AddLogging(x =>
			{
				x.ClearProviders();
				x.SetMinimumLevel(LogLevel.Debug);
				x.AddDebug();
			});

			//identity i�in
			//identity error i�in
			services.AddDbContext<Context>();
			services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<Context>()
				.AddErrorDescriber<CustomIdentityValidator>()
				.AddEntityFrameworkStores<Context>();


			//api configuration
			services.AddHttpClient();

			services.ContainerDependencies();

			services.AddAutoMapper(typeof(Startup));

			services.CustomValidator();

			services.AddControllersWithViews().AddFluentValidation();

			//identity i�in (proje seviyesi authentication)
			services.AddMvc(config =>
			{
				var policy = new AuthorizationPolicyBuilder()
				.RequireAuthenticatedUser()
				.Build();
				config.Filters.Add(new AuthorizeFilter(policy));
			});

			services.AddMvc();

			services.ConfigureApplicationCookie(options =>
			{
				options.LoginPath = "/Login/SingIn";
			});
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
		{
			//loglama file
			var path = Directory.GetCurrentDirectory();
			loggerFactory.AddFile($"{path}\\Logs\\Log1.txt");

			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler("/Home/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}

			app.UseStatusCodePagesWithReExecute("/ErrorPage/Error404", "?code={0}");

			app.UseHttpsRedirection();
			app.UseStaticFiles();

			//identity i�in
			app.UseAuthentication();

			app.UseRouting();

			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllerRoute(
					name: "default",
					pattern: "{controller=Destination}/{action=Index}/{id?}");
			});

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                  name: "areas",
                  pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );
            });
        }
	}
}
