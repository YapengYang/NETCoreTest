using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using NETCore.DB;
using NLog.Extensions.Logging;
using NLog.Web;

namespace NETCoreTest
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            // 注意：一定要加 sslmode = none
            var connection = Configuration.GetConnectionString("Default");
            services.AddDbContext<NETCoreDBContext>(options => options.UseMySQL(connection));


            //添加Swagger文档生成参数配置
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new Swashbuckle.AspNetCore.Swagger.Info
                {
                    Title = "SwaggerTest接口文档",
                    Version = "1.0.0"
                });
                options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, "NETCoreTest.xml"));
            });

            #region AutoFac DI

            //实例化 AutoFac  容器   
            var builder = new ContainerBuilder();
            var businessServices = Assembly.Load("NETCoreTest.BusinessCore.wmw");
            builder.RegisterAssemblyTypes(businessServices)
                .Where(t => t.Name.EndsWith("Manager"))
                .AsSelf().InstancePerLifetimeScope();
            //将services填充到Autofac容器生成器中
            builder.Populate(services);
            //使用已进行的组件登记创建新容器
            var ApplicationContainer = builder.Build();

            #endregion

            return new AutofacServiceProvider(ApplicationContainer);//第三方IOC接管 core内置DI容器
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();

            //添加NLog  
            loggerFactory.AddNLog();
            //读取Nlog配置文件 
            env.ConfigureNLog("nlog.config");

            //Swagger显示控制
            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "NETCoreTest");
                options.InjectJavascript("/Scripts/swagger.js");
            });

            app.Run(ctx =>
            {
                ctx.Response.Redirect("/swagger/"); //可以支持虚拟路径或者index.html这类起始页.
                return Task.FromResult(0);
            });
        }
    }
}
