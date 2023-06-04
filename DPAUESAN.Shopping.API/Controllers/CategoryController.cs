﻿using DPAUESAN.Shopping.DOMAIN.Core.Entities;
using DPAUESAN.Shopping.DOMAIN.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DPAUESAN.Shopping.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        //private readonly ICategoryRepository _categoryRepository;
        //public CategoryController(ICategoryRepository categoryRepository)
        //{
        //    _categoryRepository = categoryRepository;
        //}
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _categoryService.GetAll();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _categoryService.GetById(id);
            if (result == null) 
                return NotFound();

            return Ok(result);
        }

        //[HttpPost]
        //public async Task<IActionResult> Insert([FromBody] Category category)
        //{
        //    var result = await _categoryRepository.Insert(category);
        //    if (!result)
        //        return BadRequest(result);

        //    return Ok(result);
        //}
        //[HttpPut]
        //public async Task<IActionResult> Update([FromBody] Category category)
        //{
        //    var result = await _categoryRepository.Update(category);
        //    if (!result)
        //        return BadRequest(result);

        //    return Ok(result);

        //}
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> Delete(int id)
        //{
        //    var result = await _categoryRepository.Delete(id);
        //    if (!result)
        //        return NotFound(result);

        //    return Ok(result);
        //}




    }
}
