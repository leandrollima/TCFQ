using Microsoft.EntityFrameworkCore;
using TCFQ.Domain;
using TCFQ.Repository.Context;

namespace TCFQ.WF.Util
{
    internal class Database
    {
        private readonly AppDbContext _dbContext;

        public Database(AppDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public async Task<bool> TestConnectionDB()
        {
            bool connected = false;
            try
            {
                _dbContext.Database.SetCommandTimeout(2);
                await _dbContext.Database.OpenConnectionAsync();
                connected = true;
            }
            catch (Exception ex)
            {
            }
            finally
            {
                _dbContext.Database.CloseConnection();
            }

            return connected;
        }

        public bool SaveResult(Result result)
        {
            try
            {
                _dbContext.Add(result);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<ICollection<Result>> GetAllResults()
        {
           return await _dbContext.Results
               .Include(x => x.Answers)
               .ToListAsync();
        }
    }
}
