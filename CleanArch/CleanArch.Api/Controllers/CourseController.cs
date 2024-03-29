﻿using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArch.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseServiec;

        public CourseController(ICourseService courseServiec)
        {
            _courseServiec = courseServiec;
        }


        [HttpPost]
        public IActionResult CreateCourse ([FromBody] CourseViewModel courseViewModel)
        {
            _courseServiec.CreateCourse(courseViewModel);

            return Ok(courseViewModel);
        }
    }
}
