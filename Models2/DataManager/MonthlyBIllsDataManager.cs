using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MonthlyBillsWebAPI.Models2.Repository;
using System.Linq;
//using MonthlyBillsWebAPI.Models2.DTO;

namespace MonthlyBillsWebAPI.Models2.DataManager
{
    public class MonthlyBIllsDataManager: IDataRepository<MonthlyBills, MonthlyBillsDTO>
    {

        public IEnumerable<MonthlyBills> GetAll()
        {
            return _MonthlyBillsWebAppTR_dbContext.MonthlyBills
                .ToList();
        }
    }
}
