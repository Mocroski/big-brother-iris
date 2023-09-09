using BigBrotherAPI.Data;
using BigBrotherAPI.Entities;
using BigBrotherAPI.Services.Dtos.Motherfuckers;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace BigBrotherAPI.Repositories.Motherfuckers
{
    public class MotherfuckerRepository : EfCoreRepository<BigBrotherAPIDbContext, Motherfucker, Guid>, IMotherfuckerRepository
    {
        public MotherfuckerRepository(IDbContextProvider<BigBrotherAPIDbContext> dbContextProvider) : base(dbContextProvider) { }

        public async Task<Motherfucker> AddAsync(MotherfuckerInputDto motherfuckerDto)
        {
            var dbContext = await GetDbContextAsync();
            var motherfucker = new Motherfucker
            {
                Name = motherfuckerDto.Name,
                Email = motherfuckerDto.Email,
            };

            var entityEntry = await dbContext.Set<Motherfucker>().AddAsync(motherfucker);

            await dbContext.SaveChangesAsync();

            return entityEntry.Entity;
        }

        public async Task DeleteAsync(Guid id)
        {

            var mothefuckerToDelete = await DbContext.Set<Motherfucker>().FindAsync(id);
            if(mothefuckerToDelete != null)
            {
                DbContext.Set<Motherfucker>().Remove(mothefuckerToDelete);
                 await DbContext.SaveChangesAsync();
            }
        }

        public async Task<List<Motherfucker>> GetAllAsync()
        {
            var query = await GetQueryableAsync();
            return await query.ToListAsync();
        }

        public async Task<Motherfucker> GetByIdAsync(Guid id)
        {
            var query = await GetQueryableAsync();
            return await query.FirstOrDefaultAsync(it => it.Id == id);                
        }
    }
}
