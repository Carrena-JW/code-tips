

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace CodeTips.Configuration
{
    internal class AppSettingInConsole
    {
        internal void Init()
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            // 서비스 제공자를 빌드합니다.
            var serviceProvider = serviceCollection.BuildServiceProvider();

            // AppSettings 인스턴스를 가져옵니다.
            var appSettings = serviceProvider.GetRequiredService<IOptions<SettingValues>>().Value;
        }

        private  void ConfigureServices(IServiceCollection services)
        {
            // IConfigurationBuilder를 사용하여 구성 설정을 빌드합니다.
            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();



            services.Configure<SettingValues>((x) =>
            {
                configuration.GetSection("asd");
            });
               
        }

        internal void Example1()
        {

        }
    }


    public class SettingValues
    {
        public string ExportPath { get; set; } = string.Empty;
        public string ImportPath { get; set; } = string.Empty;
    }
}
