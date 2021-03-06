using BlazorMVVMToDo.ViewModels;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

// https://www.syncfusion.com/blogs/post/mvvm-pattern-in-blazor-for-state-management.aspx/amp

namespace BlazorMVVMToDo
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped<IToDoViewModel, ToDoBasicViewModel>();

            await builder.Build().RunAsync();
        }
    }
}
