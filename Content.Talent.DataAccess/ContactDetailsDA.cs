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
    public class ContactDetailsDA: IContactDetailsApiController
    {
        protected IRepository _dbContext;
        private const string spGetContactTalent = @"dbo.GetContactDetails";
        private const string spAddContatcTalent = @"dbo.AddTalent";
        public ContactDetailsDA(IRepository dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult TalentContactDetailsTalentIdDelete(string dtalentId)
        {
            bool isSuccess = false;
            Guid talentId = new Guid(dtalentId);
            try
            {
                //  _dbContext.ExecuteSQLCommand(spUpdateUser);

                isSuccess = _dbContext.ExecuteNonQuery("update ConatctDetails set is_delete='true' where talent_id='" + talentId + "'") == 0 ? false : true; ;
                return new ObjectResult(isSuccess);
            }
            catch (Exception ex)
            {
                return new ObjectResult(false);
            }
        }

        public IActionResult TalentContactDetailsTalentIdGet(string dtalentId)
        {
            IList<ContactDetailsResponse> data = new List<ContactDetailsResponse>();
            Guid talentId = new Guid(dtalentId);
            try
            {
                IList<IDataParameter> parameters = new List<IDataParameter>();

                parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.Guid, ParameterName = "@talentId", Value = talentId });

                data = _dbContext.ExecuteSQLQuery<ContactDetailsResponse>(spGetContactTalent, parameters);

                return new ObjectResult(data[0]);
            }
            catch (Exception ex)
            {
                return null;
            }
            // return null;
        }

        public IActionResult TalentContactDetailsTalentIdPut(ConatctDetails data, string dtalentId)
        {
            bool isSuccess = false;
            Guid talentId = new Guid(dtalentId);
            try
            {
                //  _dbContext.ExecuteSQLCommand(spUpdateUser);
                IList<IDataParameter> parameters = new List<IDataParameter>();

                parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.Guid, ParameterName = "@talentId", Value = talentId });
                parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@firstname", Value = data.FirstName });
                parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@lastname", Value = data.LastName });
                parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@emailaddress", Value = data.EmailAddress });
                parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@primaryskill", Value = data.PrimarySkill });
                parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@personalwebsite", Value = data.PersonalWebsiteUrl });
                parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@phonenumber", Value = data.PhoneNumber });
                parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@location", Value = data.Location });
                parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@timezone", Value = data.TimeZone });
                parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@contenlyprofileUrl", Value = data.ContentlyPortifolioURl });
                parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@profile_photo", Value = data.ProfilePhoto });

                isSuccess = _dbContext.ExecuteStoredProcedure(spAddContatcTalent, parameters) == 0 ? false : true;
                return new ObjectResult(isSuccess);
            }
            catch (Exception ex)
            {
                return new ObjectResult(false);
            }
        }
    }
}
