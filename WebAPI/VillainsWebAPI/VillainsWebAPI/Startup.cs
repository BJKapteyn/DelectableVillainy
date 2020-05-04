using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using VillainsWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace VillainsWebAPI
{
  public class Startup
  {
    public IConfiguration Configuration;
    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;

    }

    //Map test
    public static void HandleMapTest(IApplicationBuilder app)
    {
      app.Run(async context =>
      {
        await context.Response.WriteAsync("You made it");
      });
    }

    //Attack request
    public static void HandleAttack(IApplicationBuilder app)
    {
      app.Run(async context =>
      {
        string attackPowerRequest = context.Request.Query["attack"].ToString();
        int attackDamage = 0;
        int mass = 0;
        bool didParse = int.TryParse(attackPowerRequest, out mass);

        if (didParse && mass > 0)
        {
          attackDamage = StatCalculator.Attack(mass, 4);
          string youDidThisMuchDamage = $"You did {attackDamage.ToString()} damage";
          await context.Response.WriteAsync(youDidThisMuchDamage);
        }
        else
        {
          await context.Response.WriteAsync("You're a shrimp, kid.");
        }
      });
    }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
      //Allow Cors access from front end
      services.AddCors(options =>
      {
        options.AddPolicy(name: "AllowSpecificOrigins",
                          builder =>
                          {
                            builder.WithOrigins("http://localhost:4200").AllowAnyHeader();
                          });
      });
      //"Server=LAPTOP-T6VP6L6I\SQLEXPRESS;Database=DelectableVillainy;Trusted_Connection=True;"
      services.AddSingleton<IConfiguration>(Configuration);
      services.AddDbContext<DelectableVillainyContext>(options =>
        options.UseSqlServer(Configuration.GetConnectionString("VillainDBConnectionString")));
      services.AddControllers();
      //add Json format support
      services.AddControllers().AddNewtonsoftJson();
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
 
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      //map HandleMapTest
      app.Map("/maptest", HandleMapTest);
      //DEMO ONLY, TODO: move to villain controller
      //app.MapWhen(context =>
      //  context.Request.Query.ContainsKey("attack"), HandleAttack
      //);

      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }
      //middleware pipeline order, order is important for security

      //redirects http requests to https automatically
      app.UseHttpsRedirection();

      //use routing defined by the app
      app.UseRouting();

      //use the allowspecificorigins defined in the configureservices
      app.UseCors("AllowSpecificOrigins");

      //authorize user
      app.UseAuthorization();

      //my defined endpoints ex. endpoints.MapRazorPages() added for an MVC app.
      app.UseEndpoints(endpoints =>
      {
        endpoints.MapControllers();
        //endpoints.MapDefaultControllerRoute();
        //endpoints.MapControllerRoute(name: "villain", pattern: "{controller=Villain}/{action=Attack}/{mass?}");
      });
    }
  }
}
