﻿using AutoMapper;
using Jobcard.Data;
using JobCard.Application.UI;
using JobCard.Infrastructure.MappingProfiles;
using JobCard.Security;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Graph;
using Reytec.JobCard.Core;
using Reytec.JobCard.DAL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace JobCard
{
    public class Startup
    {
  
        public void ConfigureServices(IServiceCollection serviceCollection)
        {
            serviceCollection
                //.AddSingleton(sp => new Main(sp))
                .AddAutoMapper(typeof(MappingProfile))
                .AddSingleton<Main>()
                .AddSingleton<AzureLoginForm>()
                .AddSingleton<AzureLoginCustomWebUi>()
                .AddSingleton<frmConnection>()
                .AddSingleton<JobCardCompany>()
                .AddSingleton(Reytec.JobCard.Core.ConnectionInfo.GlobalConnection)
                .AddSingleton<GraphServiceClient>()
                .AddSingleton<IAuthenticationFlow, AzureADAuthenticationFlow>()
                .AddSingleton<IAuthenticationProvider, AzureADAuthenticationProvider>()
                .AddSingleton<ICompanyConnectionRepository, CompanyConnectionRepository>();
        }
        public void Configure(IApplicationBuilder app, IApplicationLifetime lifetime, Main mainForm)
        {
            
            lifetime.ApplicationStarted.Register(()=>
            {


                System.Windows.Forms.Application.ApplicationExit += (sender,e)=>
                {
                    lifetime.StopApplication();
                };
                ApplicationState.MainForm = mainForm;
                System.Windows.Forms.Application.Run(mainForm);
            });

            app.Run(async (context) =>
            {

                if (context.Request.Path == "/auth")
                {
                    ApplicationState.AuthorizationCallbackUri = new Uri(context.Request.GetEncodedUrl());
                    await context.Response.WriteAsync("OK!").ConfigureAwait(false);
                    AzureLoginCustomWebUi.CloseWindow(ApplicationState.LoginWindowHandle);
                }


            });

        }
    
    }
}
