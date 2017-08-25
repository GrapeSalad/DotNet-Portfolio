using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DotNet_Portfolio.Models;
using Newtonsoft.Json.Linq;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace DotNet_Portfolio.Controllers
{
    public class ProjectsController : Controller
    {
        // GET: /<controller>/
        public IActionResult GitStars()
        {
            //Github.TestGitAPI();//works
            //Github.GetGitRepos();//works, returns a JArray of 30 repos
            JObject githubRepos = Github.GetStarredRepos();
            return View(githubRepos);
        }
        public IActionResult DigitalEase()
        {
            return View();
        }
    }
}
