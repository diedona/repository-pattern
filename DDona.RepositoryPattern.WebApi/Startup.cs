﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DDona.RepositoryPattern.Domain.Interfaces;
using DDona.RepositoryPattern.Domain.Interfaces.Repositories;
using DDona.RepositoryPattern.Domain.Interfaces.Services;
using DDona.RepositoryPattern.Domain.Mapping;
using DDona.RepositoryPattern.Infra.Contexts;
using DDona.RepositoryPattern.Infra.Repositories;
using DDona.RepositoryPattern.Infra.UoW;
using DDona.RepositoryPattern.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace DDona.RepositoryPattern.WebApi
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
            AddDbContext(services);
            AddRepositories(services);
            AddServices(services);
            AddAutomapper(services);
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }

        private void AddDbContext(IServiceCollection services)
        {
            services.AddDbContext<RepositoryPatternDbContext>(opt => opt.UseSqlServer(Configuration.GetConnectionString("Default")));
        }

        private void AddRepositories(IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }

        private void AddServices(IServiceCollection services)
        {
            services.AddScoped<IPersonService, PersonService>();
        }

        private void AddAutomapper(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(EntityToDTOMapper));
        }
    }
}
