using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AzureOps_SampleApp.Pages
{
    public class ServerErrorModel : PageModel
    {
        private readonly ILogger<ServerErrorModel> _logger;

        public ServerErrorModel(ILogger<ServerErrorModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            _logger.LogError("サーバーエラーを意図的に発生させます");
            // サーバーエラーを意図的に発生させます
            throw new Exception();

        }
    }
}