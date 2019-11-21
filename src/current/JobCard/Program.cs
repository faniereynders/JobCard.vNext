﻿using CefSharp;
using CefSharp.WinForms;
using Jobcard.Data;
using JobCard.Security;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Reytec.Data.Connection;
using Reytec.JobCard.Core;
using Reytec.JobCard.DAL;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobCard
{
    static class Program
    {

        public static Process LoginProxy;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();


            serviceCollection
                .AddSingleton(sp => new Main(sp))
                .AddSingleton<frmConnection>()
                .AddSingleton<JobCardCompany>()
                .AddSingleton(Reytec.JobCard.Core.ConnectionInfo.GlobalConnection)
                .AddSingleton<ICompanyConnectionRepository, CompanyConnectionRepository>();

            var serviceProvider = serviceCollection.BuildServiceProvider();






            AppDomain.CurrentDomain.AssemblyResolve += Resolver;
            Application.ApplicationExit += Application_ApplicationExit;

            LoadApp();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var mainForm = serviceProvider.GetService<Main>();
            Task.Factory.StartNew(() => CreateWebHostBuilder(args).Build().Run());
            Application.Run(mainForm);
            
        }


        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            .Configure(app =>
            {
                app.Run(async (context) =>
                {

                    if (context.Request.Path == "/auth")
                    {
                        ApplicationState.AuthorizationCallbackUri = new Uri(context.Request.GetEncodedUrl());
                        await context.Response.WriteAsync("OK!");
                        AzureLoginCustomWebUi.CloseWindow(ApplicationState.LoginWindowHandle);
                    }


                });
            });


        private static void Application_ApplicationExit(object sender, EventArgs e)
        {
            if (LoginProxy != null)
            {
                LoginProxy.Kill();
            }
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        private static void LoadApp()
        {
            var settings = new CefSettings();

            // Set BrowserSubProcessPath based on app bitness at runtime
            settings.BrowserSubprocessPath = Path.Combine(AppDomain.CurrentDomain.SetupInformation.ApplicationBase,
                                                   Environment.Is64BitProcess ? "x64" : "x86",
                                                   "CefSharp.BrowserSubprocess.exe");

            // Make sure you set performDependencyCheck false
            Cef.Initialize(settings, performDependencyCheck: false, browserProcessHandler: null);


        }

        private static Assembly Resolver(object sender, ResolveEventArgs args)
        {
            if (args.Name.StartsWith("CefSharp"))
            {
                string assemblyName = args.Name.Split(new[] { ',' }, 2)[0] + ".dll";
                string archSpecificPath = Path.Combine(AppDomain.CurrentDomain.SetupInformation.ApplicationBase,
                                                       Environment.Is64BitProcess ? "x64" : "x86",
                                                       assemblyName);

                return File.Exists(archSpecificPath)
                           ? Assembly.LoadFile(archSpecificPath)
                           : null;
            }

            return null;
        }
    }
}
