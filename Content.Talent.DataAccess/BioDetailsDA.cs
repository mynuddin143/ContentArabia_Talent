using Content.Talent.DTO;
using IO.Swagger.Controllers;
using IO.Swagger.Models;
using Microsoft.AspNetCore.Mvc;
using SE.CAF.CC.Persistance;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Content.Talent.DataAccess
{
    public class BioDetailsDA: IBioDetailsApiController
    {
        protected IRepository _dbContext;
        private const string spGetBioTalent = @"dbo.GetBioDetails";
        private const string spAddBioTalent = @"dbo.AddBioTalentDetails";
        public BioDetailsDA(IRepository dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult TalentBioDetailsTalentIdDelete(string dtalentId)
        {
            bool isSuccess = false;
            Guid talentId = new Guid(dtalentId);
            try
            {
                //  _dbContext.ExecuteSQLCommand(spUpdateUser);

                isSuccess= _dbContext.ExecuteNonQuery("update BioDetails set is_delete='true' where talent_id='"+ talentId+"'") == 0 ? false : true; ; 
                return new ObjectResult(isSuccess);
            }
            catch (Exception ex)
            {
                return new ObjectResult(false);
            }
        }

        public IActionResult TalentBioDetailsTalentIdGet(string dtalentId)
        {
            IList<BioDetailsResponse> data = new List<BioDetailsResponse>();
            Guid talentId = new Guid(dtalentId);
            try
            {
                IList<IDataParameter> parameters = new List<IDataParameter>();

                parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.Guid, ParameterName = "@talentId", Value = talentId });

                data = _dbContext.ExecuteSQLQuery<BioDetailsResponse>(spGetBioTalent, parameters);

                return new ObjectResult(data[0]);
            }
            catch (Exception ex)
            {
                return null;
            }
           // return null;
        }

        public IActionResult TalentBioDetailsTalentIdPut(BioDetails data,string dtalentId)
        {
            bool isSuccess = false;
            Guid talentId = new Guid(dtalentId);
            try
            {
                //  _dbContext.ExecuteSQLCommand(spUpdateUser);
                IList<IDataParameter> parameters = new List<IDataParameter>();

                parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.Guid, ParameterName = "@talentId", Value = talentId });
                parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@title", Value = data.Title });
                parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@bio", Value = data.Bio });
                parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@fluentLanguages", Value = data.FluentLanguage });

                isSuccess = _dbContext.ExecuteStoredProcedure(spAddBioTalent, parameters) == 0 ? false : true;
                return new ObjectResult(isSuccess);
            }
            catch (Exception ex)
            {
                return new ObjectResult(false);
            }
        }
    }
}
