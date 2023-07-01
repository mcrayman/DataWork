using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {

        [HttpGet]
        public IActionResult GetStockStatus()
        {
            var stockStatus = new Dictionary<string, Dictionary<string, int>>()
            {
                { "Label", new Dictionary<string, int>()
                    {
                        { "Last WK", 4876 },
                        { "2wk ago", 4876 },
                        { "3wk ago", 4900 },
                        { "4wk ago", 5052 }
                    }
                },
                { "On Hand Units", new Dictionary<string, int>()
                    {
                        { "Last WK", 4876 },
                        { "2wk ago", 4876 },
                        { "3wk ago", 4900 },
                        { "4wk ago", 5052 }
                    }
                },
                { "On Order Units", new Dictionary<string, int>()
                    {
                        { "Last WK", 0 },
                        { "2wk ago", 0 },
                        { "3wk ago", 0 },
                        { "4wk ago", 0 }
                    }
                },
                { "In - Transit", new Dictionary<string, int>()
                    {
                        { "Last WK", 0 },
                        { "2wk ago", 0 },
                        { "3wk ago", 0 },
                        { "4wk ago", 0 }
                    }
                },
                { "Holdout", new Dictionary<string, int>()
                    {
                        { "Last WK", 0 },
                        { "2wk ago", 0 },
                        { "3wk ago", 0 },
                        { "4wk ago", 0 }
                    }
                },
                { "Allocated", new Dictionary<string, int>()
                    {
                        { "Last WK", 270 },
                        { "2wk ago", 270 },
                        { "3wk ago", 402 },
                        { "4wk ago", 270 }
                    }
                },
                { "Reserved", new Dictionary<string, int>()
                    {
                        { "Last WK", 0 },
                        { "2wk ago", 0 },
                        { "3wk ago", 0 },
                        { "4wk ago", 0 }
                    }
                },
                { "Overstock (current loc)", new Dictionary<string, int>()
                    {
                        { "Last WK", 0 },
                        { "2wk ago", 1078 },
                        { "3wk ago", 1228 },
                        { "4wk ago", 1374 }
                    }
                },
                { "Overstock (stores)", new Dictionary<string, int>()
                    {
                        { "Last WK", 0 },
                        { "2wk ago", 1078 },
                        { "3wk ago", 1228 },
                        { "4wk ago", 1374 }
                    }
                },
                { "# Overstocked Stores", new Dictionary<string, int>()
                    {
                        { "Last WK", 0 },
                        { "2wk ago", 1 },
                        { "3wk ago", 1 },
                        { "4wk ago", 1 }
                    }
                },
                { "Available Units", new Dictionary<string, int>()
                    {
                        { "Last WK", 4616 },
                        { "2wk ago", 4606 },
                        { "3wk ago", 4630 },
                        { "4wk ago", 4650 }
                    }
                }
            };

            return Ok(stockStatus);
        }

        [HttpPost]
        public IActionResult UpdateStockStatus([FromBody] Dictionary<string, Dictionary<string, int>> stockData)
        {
            return Ok();
        }

    }
}

