using Microsoft.EntityFrameworkCore;

namespace DMandBulkUpload.Data
{
    public class DataModellingandBulkuploadContext : DbContext
    {
        public DataModellingandBulkuploadContext(DbContextOptions<DataModellingandBulkuploadContext> options)
            :base(options)
        {
                
        }

        
    }
}
