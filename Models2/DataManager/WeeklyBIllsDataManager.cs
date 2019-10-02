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
    public class WeeklyBIllsDataManager: IDataRepository<WeeklyBIllsDataManager, WeeklyBIllsDTO>
    {
        public WeeklyBills Get(long id)
        {
            _MonthlyBillsWebAppTR_dbContext.ChangeTracker.LazyLoadingEnabled = false;
            var weeklybill = _MonthlyBillsWebAppTR_dbContext.WeeklyBills
                .SingleOrDefault(b => b.id == id);

            if(weeklybill == null)
            {
                return null;
            }

            return weeklybill;

        }
    }
}
