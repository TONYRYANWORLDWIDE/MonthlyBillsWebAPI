using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MonthlyBillsWebAPI.Models;
using Dapper;
using MonthlyBillsWebAPI.Services;
using System.Data;
using Microsoft.AspNetCore.Authorization;

namespace MonthlyBillsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[ModelVerify]
    public class TransactionsCMPController : ControllerBase
    {
        private readonly IDapper _dapper;

        public TransactionsCMPController(IDapper dapper)
        {
            _dapper = dapper;
        }

        //api/TransactionsCMP?Transaction_Id=94Y6DE9o1Bsr3oZvKAzAiwvpgrkYVgfdE8Yyo
        //or
        //api/TransactionsCMP?@Account_id=XydAgkM6LNsVqL5a0eQKFoy6YJVn8PT4VMb9R&Transaction_Id=94Y6DE9o1Bsr3oZvKAzAiwvpgrkYVgfdE8Yyo
        //or 
        //api/TransactionsCMP? @Account_id = XydAgkM6LNsVqL5a0eQKFoy6YJVn8PT4VMb9R
        //[HttpGet("id")]
        [Authorize]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TransactionsCMP>>> GetByIdName(string Account_Id, string Transaction_Id, string Start_Date,string End_Date)
        {

            var dbPara = new DynamicParameters();
            dbPara.Add("account_id", Account_Id);
            dbPara.Add("transaction_id", Transaction_Id);
            dbPara.Add("startDate" , Start_Date);
            dbPara.Add("endDate", End_Date);
            var get_trans = await Task.FromResult(_dapper.GetAll<TransactionsCMP>("[billsapi].[getCMPTransactionsById]",
                                dbPara, commandType: CommandType.StoredProcedure));
            return get_trans;
        }

        [HttpPut]
        public Task<TransactionsCMP> Update(TransactionsCMP data)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("account_Id", data.Account_Id);
            dbPara.Add("account_Owner", data.Account_Owner);
            dbPara.Add("amount", data.Amount);
            dbPara.Add("authorized_Date", data.Authorized_Date);
            dbPara.Add("category", data.Category);
            dbPara.Add("category_id", data.Category_Id);
            dbPara.Add("date", data.Date);
            dbPara.Add("iso_Currency_Code", data.Iso_Currency_Code);
            dbPara.Add("location", data.Location);
            dbPara.Add("name", data.Name);
            dbPara.Add("payment_Channel", data.Payment_Channel);
            dbPara.Add("payment_Meta", data.Payment_Meta);
            dbPara.Add("pending", data.Pending);
            dbPara.Add("pending_Transaction_Id", data.Pending_Transaction_Id);
            dbPara.Add("transaction_Id", data.Transaction_Id);
            dbPara.Add("transaction_Type", data.Transaction_Type);
            dbPara.Add("unofficial_Currency_Code", data.Unofficial_Currency_Code);
            dbPara.Add("transaction_Code", data.Transaction_Code);
            dbPara.Add("merchant_Name", data.Merchant_Name);

            var updatetrans = Task.FromResult(_dapper.Update<TransactionsCMP>("[billsapi].[updateCMPTransactions]",
            dbPara, commandType: CommandType.StoredProcedure));
            return updatetrans;
        }
    }
}
