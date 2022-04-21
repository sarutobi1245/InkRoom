using System.Threading.Tasks;
using INK_API._Repositories.Interface;
using INK_API.Data;
using INK_API.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using INK_API.DTO;
using System.Collections.Generic;

namespace INK_API._Repositories.Repositories
{
    public class WorkPlanMasterRepository : ECRepository<WorkPlanMaster>, IWorkPlanMasterRepository
    {
        private readonly DataContext _context;
        public WorkPlanMasterRepository(DataContext context) : base(context)
        {
            _context = context;
        }

     
        //Login khi them repo
    }
}