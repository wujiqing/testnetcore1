using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MySite.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        { 
                var text = $"====test{DateTime.Now.ToString("yyyyMMddHHmmss") }========";
                var path = "/logs/mysite/";

                if (!System.IO.Directory.Exists(path))
                {
                    System.IO.Directory.CreateDirectory(path);
                }

                var filePath = path + DateTime.Now.ToString("yyyyMMdd") + ".log";
                System.IO.File.WriteAllText(filePath, text);
                  
        }
    }
}
