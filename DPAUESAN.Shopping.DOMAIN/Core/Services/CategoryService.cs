using DPAUESAN.Shopping.DOMAIN.Core.DTO;
using DPAUESAN.Shopping.DOMAIN.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPAUESAN.Shopping.DOMAIN.Core.Services
{
    public class CategoryService : ICategoryService
    {
        private ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<IEnumerable<CategoryDescriptionDTO>> GetAll()
        {
            var categories = await _categoryRepository.GetAll();
            var categoriesDTO = new List<CategoryDescriptionDTO>();

            foreach (var category in categories)
            {
                var categoryDTO = new CategoryDescriptionDTO();
                categoryDTO.Id = category.Id;
                categoryDTO.Description = category.Description;
                categoriesDTO.Add(categoryDTO);
            }
            return categoriesDTO;
        }

        public async Task<CategoryDescriptionDTO> GetById(int id)
        {
            var category = await _categoryRepository.GetById(id);
            var categoryDTO = new CategoryDescriptionDTO();

            categoryDTO.Id = category.Id;
            categoryDTO.Description = category.Description;

            return categoryDTO;
        }

    }
}
