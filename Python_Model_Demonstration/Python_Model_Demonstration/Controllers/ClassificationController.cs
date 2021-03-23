using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Python_Model_Demonstration.Models;

namespace Python_Model_Demonstration.Controllers
{
    public class ClassificationController : Controller
    {
        public IActionResult Index()
        {
            FetalHealthInput input = new FetalHealthInput();
            ViewData["Input"] = input;
            ViewData["Message"] = 0;
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> RetrieveOutcome(FetalHealthInput predModel)
        {
            // if the model contains the correct user input
            if (ModelState.IsValid)
            {
                using (var client = new System.Net.Http.HttpClient())
                {

                    string xValue = predModel.ToString();

                    // send a GET request to the server uri with the data and get the response as HttpResponseMessage object
                    System.Net.Http.HttpResponseMessage res = await client.GetAsync("http://127.0.0.1:5000/random_forest_classification?x=" + xValue);

                    // Return the result from the server if the status code is 200 (everything is OK)
                    // should raise exception or error if it's not
                    if (res.IsSuccessStatusCode)
                    {
                        // pass the result by setting the Viewdata property
                        // have to read as string for the data in response.body
                        ViewData["Input"] = predModel;
                        ViewData["Message"] = res.Content.ReadAsStringAsync().Result;
                        return View("Index");
                    }
                    else
                    {
                        return View("Error");
                    }

                }
            }
            else
            {
                return View();
            }

        }
    }
}
