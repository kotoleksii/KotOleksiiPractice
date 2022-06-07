using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KotOleksiiPractice.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly IConfiguration Configuration;

        public PrivacyModel(IConfiguration _configuration)
        {
            Configuration = _configuration;
        }

        // Добавил свойство
        public string Message1 { get; set; }
        public string Message2 { get; set; }

        public void OnGet()
        {
            string appName = Configuration.GetSection("AppSettings")["AppName"];
            string site = Configuration.GetSection("AppSettings")["Site"];

            Message1 = appName;
            Message2 = site;
        }
    }
}
