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
    public class SocialDetailsDA: ISocialDetailsApiController
    {
        protected IRepository _dbContext;
        private const string spGetSocialTalent = @"dbo.GetSocialdetails";
        private const string spAddSocialTalent = @"dbo.AddSocialTalentDetails";
        public SocialDetailsDA(IRepository dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult TalentSocialDetailsTalentIdDelete(string dtalentId)
        {
            bool isSuccess = false;
            Guid talentId = new Guid(dtalentId);
            try
            {
                //  _dbContext.ExecuteSQLCommand(spUpdateUser);

                isSuccess = _dbContext.ExecuteNonQuery("update Socialdetails set is_delete='true' where talent_id='" + talentId + "'") == 0 ? false : true; ;
                return new ObjectResult(isSuccess);
            }
            catch (Exception ex)
            {
                return new ObjectResult(false);
            }
        }

        public IActionResult TalentSocialDetailsTalentIdGet(string dtalentId)
        {
            IList<SocialDetailsResponse> data = new List<SocialDetailsResponse>();
            Guid talentId = new Guid(dtalentId);
            try
            {
                IList<IDataParameter> parameters = new List<IDataParameter>();

                parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.Guid, ParameterName = "@talentId", Value = talentId });

                data = _dbContext.ExecuteSQLQuery<SocialDetailsResponse>(spGetSocialTalent, parameters);

                return new ObjectResult(data[0]);
            }
            catch (Exception ex)
            {
                return null;
            }
            // return null;
        }

        public IActionResult TalentSocialDetailsTalentIdPut(SocialDetails data, string dtalentId)
        {
            bool isSuccess = false;
            Guid talentId = new Guid(dtalentId);
            try
            {
                //  _dbContext.ExecuteSQLCommand(spUpdateUser);
                IList<IDataParameter> parameters = new List<IDataParameter>();

                parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.Guid, ParameterName = "@talentId", Value = talentId });
                parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@facebook", Value = data.Facebook });
                parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@twitter", Value = data.Twitter });
                parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@linkedin", Value = data.Linkedin });
                parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@tumblr", Value = data.Tumblr });
                parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@instagram", Value = data.Instagram });
                parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@google", Value = data.Google });

                isSuccess = _dbContext.ExecuteStoredProcedure(spAddSocialTalent, parameters) == 0 ? false : true;
                return new ObjectResult(isSuccess);
            }
            catch (Exception ex)
            {
                return new ObjectResult(false);
            }
        }
    }
}
