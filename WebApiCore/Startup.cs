using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Mvc.Formatters;
using Newtonsoft.Json.Serialization;

namespace WebApiCore
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

      //services.AddMvc()
      //  .AddJsonOptions(o =>
      //  {
      //    if (o.SerializerSettings.ContractResolver != null)
      //    {
      //      var castedResolver = o.SerializerSettings.ContractResolver as DefaultContractResolver;

      //      // Altera o "case" (camel case, etc...) das propriedades JSON.
      //      castedResolver.NamingStrategy = null;
      //    }
      //  });

      services.AddMvc(setupAction =>
      {
        setupAction.ReturnHttpNotAcceptable = true;
        setupAction.OutputFormatters.Add(new XmlDataContractSerializerOutputFormatter());
      });
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IHostingEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }

      // Middleware
      app.UseMvc();

      // Exibe os códigos de erro na página, que uma vez eram ocultos pelo modo debug
      app.UseStatusCodePages();

      //app.Run((context) =>
      //{
      //  throw new Exception("Example exception");
      //});

      //app.Run(async (context) => { });
    }
  }
}
