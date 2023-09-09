using BigBrotherAPI.Entities;
using BigBrotherAPI.Repositories.Motherfuckers;
using BigBrotherAPI.Services.Dtos.Motherfuckers;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Entities;

namespace BigBrotherAPI.Services.Motherfuckers
{
    public class MotherfuckerAppService : ApplicationService

    {
        private readonly IMotherfuckerRepository _motherfuckerRepository;

        public MotherfuckerAppService(IMotherfuckerRepository motherfuckerRepository)
        {
            _motherfuckerRepository = motherfuckerRepository;
        }
        #region Methods

        [HttpGet]
        [Route("/api/v1/motherfuckers")]
        public async Task<List<MotherfuckerOutputDto>> GetListAsync()
        {
            try
            { var result = await _motherfuckerRepository.GetAllAsync();
            return result.Select(it => new MotherfuckerOutputDto
            {
                Id = it.Id,
                Name = it.Name,
                Email = it.Email,
                IsEliminated = it.IsEliminated
            }).ToList();

            }catch (Exception ex)
            {
                throw new Exception();
            }
        }

        [HttpPost]
        [Route("/api/v1/motherfuckers")]
        public async Task<Motherfucker> CreateAsync(MotherfuckerInputDto motherfuckerInputDto)
        {
            var inputDto = await _motherfuckerRepository.AddAsync(motherfuckerInputDto);
            return new Motherfucker
            {
                Name = inputDto.Name,
                Email = inputDto.Email,
                HasVoted = inputDto.HasVoted,
                IsEliminated = inputDto.IsEliminated,
            };
        }

        [HttpDelete]
        [Route("/api/v1/motherfuckers/{id}")]
        public async Task DeleteAsync(Guid id)
        {
            await _motherfuckerRepository.DeleteAsync(id);
        }

        [HttpGet]
        [Route("/api/v1/motherfuckers/{id}")]
        public async Task<MotherfuckerOutputDto> GetByIdAsync(Guid id)
        {
            var motherfucker = await _motherfuckerRepository.GetByIdAsync(id);

            if(motherfucker == null)
            {
                throw new EntityNotFoundException(typeof(Motherfucker), id);
            }

            return ObjectMapper.Map<Motherfucker, MotherfuckerOutputDto>(motherfucker);
        }

        #endregion
    }
}
