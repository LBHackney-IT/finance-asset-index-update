using Microsoft.EntityFrameworkCore;

namespace AssetIndexUpdateApi.V1.Infrastructure
{

    public class DatabaseContext : DbContext
    {
        //TODO: rename DatabaseContext to reflect the data source it is representing. eg. MosaicContext.
        //Guidance on the context class can be found here https://github.com/LBHackney-IT/lbh-asset-index-update-api/wiki/DatabaseContext
        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<DatabaseEntity> DatabaseEntities { get; set; }
    }
}
