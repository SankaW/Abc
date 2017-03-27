using System;
using SW01.Data.ISW01Repository;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SW01.Data.SW01Repository;

namespace SW01.Data.SW01Repository
{
    public class CompanyRepository : GenericRepository<Company>, ICompanyReository
    {

        private bool disposed = false;

        public CompanyRepository(SW01Entities context)
            : base(context)
        {

        }



        #region Dispose Function

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    if (Context != null)
                        Context.Dispose();
                }
                disposed = true;
            }
        }

        #endregion
    }
}
