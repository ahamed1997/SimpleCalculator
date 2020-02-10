// <copyright file="HomeController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace SimpleCalculator.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using SimpleCalculator.Models;

    /// <summary>
    /// Default Controller.
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// Index Method.
        /// </summary>
        /// <returns>Returns view.</returns>
        public IActionResult Index()
        {
            return this.View();
        }

        /// <summary>
        /// Action Result privacy.
        /// </summary>
        /// <returns>Returns view.</returns>
        public IActionResult Privacy()
        {
            return this.View();
        }

        /// <summary>
        /// ActionResult Index.
        /// </summary>
        /// <returns>returns error view.</returns>
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
