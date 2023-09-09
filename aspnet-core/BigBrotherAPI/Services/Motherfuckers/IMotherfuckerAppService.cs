using BigBrotherAPI.Entities;
using BigBrotherAPI.Services.Dtos.Motherfuckers;

namespace BigBrotherAPI.Services.Motherfuckers
{
    public interface IMotherfuckerAppService
    {
        Task<Motherfucker> CreateAsync(MotherfuckerInputDto inputDto);
        Task<Motherfucker> GetAsync(MotherfuckerOutputDto outputDto);
        Task DeleteAsync(Guid id);
    }
}
