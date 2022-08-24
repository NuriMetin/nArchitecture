﻿using Application.Features.Commands.CreateBrand;
using Application.Features.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : BaseController
    {
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateBrandCommand createBrandCommand)
        {
            CeratedBrandDto result = await Mediator.Send(createBrandCommand);

            return Created("", result);
        }
    }
}