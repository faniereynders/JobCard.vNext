using System.Net.Http;
using FunctionMonkey.Abstractions;
using FunctionMonkey.Abstractions.Builders;
using FunctionMonkey.FluentValidation;
using JobcardCloud.CustomerManagement.Commands;
using JobcardCloud.CustomerManagement.Handlers;
using Microsoft.Extensions.DependencyInjection;
using JobcardCloud.CustomerManagement.Validators;
using FluentValidation;
using Microsoft.Azure.WebJobs;
using Microsoft.WindowsAzure.Storage.Table;
using Microsoft.WindowsAzure.Storage;
using Microsoft.Extensions.Configuration;

public class FunctionAppConfiguration : IFunctionAppConfiguration
{
    public void Build(IFunctionHostBuilder builder)
    {
        builder
            .Setup((serviceCollection, commandRegistry) =>
            {
                serviceCollection
                    .AddSingleton<ExecutionContext>()
                    .AddSingleton<IConfiguration>((services) =>
                    {
                        var context = services.GetRequiredService<ExecutionContext>();
                        var config = new ConfigurationBuilder()
                            //.SetBasePath(context.FunctionAppDirectory)
                            .AddJsonFile("local.settings.json", optional: true, reloadOnChange: true)
                            .AddEnvironmentVariables()
                            .Build();
                            return config;
                    })
                    .AddSingleton<CloudTableClient>((services) =>
                    {
                        var config = services.GetRequiredService<IConfiguration>();
                        var storageAccount = CloudStorageAccount.Parse("UseDevelopmentStorage=true");

                        return storageAccount.CreateCloudTableClient();

                    })
                    .AddTransient<IValidator<CreatePersonCustomerCommand>, CreatePersonCustomerCommandValidator>();
                commandRegistry.Register<CreatePersonCustomerCommandHandler>();
            })
            .AddFluentValidation()
            .Functions(functions => functions
                .HttpRoute("/api/customers", route => route
                    .HttpFunction<CreatePersonCustomerCommand>(HttpMethod.Post)
                    .Options(o => o.AddHeaderMapping(c => c.TenantId, "X-TenantId"))
                )
                .Storage("AzureWebJobsStorage", storage =>
                {

                })

            )
            ;
        // .ProxiesEnabled(false);
    }
}