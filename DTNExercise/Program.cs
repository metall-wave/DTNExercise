using DTNExercise.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DTNExercise
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            ServiceCollection services = new ServiceCollection();
            services.AddTransient<IFileService, FileService>();
            services.AddTransient<IMyJsonConverterService, MyJsonConverterService>();
            services.AddTransient<IResourceService, ResourceService>();
            services.AddTransient<ICoordinatesConverterService, CoordinatesConverterService>();

            using ServiceProvider provider = services.BuildServiceProvider();

            Application.Run(new MainApplicationForm(provider.GetService<IResourceService>(),
                provider.GetService<ICoordinatesConverterService>()));
        }
    }
}