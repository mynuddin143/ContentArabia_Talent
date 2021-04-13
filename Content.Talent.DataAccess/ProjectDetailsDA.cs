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
    public class ProjectDetailsDA: IPoritfolioDetailsApiController
    {
        protected IRepository _dbContext;
        private const string spGetProjectTalent = @"dbo.GetProjectDetails";
        private const string spAddProjectTalent = @"dbo.AddProjectTalentDetails";
        public ProjectDetailsDA(IRepository dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult TalentProjectDetailsTalentIdDelete(string dtalentId)
        {
            bool isSuccess = false;
            Guid talentId = new Guid(dtalentId);
            try
            {
                //  _dbContext.ExecuteSQLCommand(spUpdateUser);

                isSuccess = _dbContext.ExecuteNonQuery("update ProjectDetails set is_delete='true' where talent_id='" + talentId + "'") == 0 ? false : true; ;
                return new ObjectResult(isSuccess);
            }
            catch (Exception ex)
            {
                return new ObjectResult(false);
            }
        }

        public IActionResult TalentProjectDetailsTalentIdGet(string dtalentId)
        {
            IList<ProjectDetailsResponse> data = new List<ProjectDetailsResponse>();
            Guid talentId = new Guid(dtalentId);
            try
            {
                IList<IDataParameter> parameters = new List<IDataParameter>();

                parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.Guid, ParameterName = "@talentId", Value = talentId });

                data = _dbContext.ExecuteSQLQuery<ProjectDetailsResponse>(spGetProjectTalent, parameters);

                return new ObjectResult(data[0]);
            }
            catch (Exception ex)
            {
                return null;
            }
            // return null;
        }

        public IActionResult TalentProjectDetailsTalentIdPut(ProjectDetails data, string dtalentId)
        {
            bool isSuccess = false;
            Guid talentId = new Guid(dtalentId);
            try
            {
                //  _dbContext.ExecuteSQLCommand(spUpdateUser);
                IList<IDataParameter> parameters = new List<IDataParameter>();

                parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.Guid, ParameterName = "@talentId", Value = talentId });
                parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@name", Value = data.Name });
                parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@publishedon", Value = data.PublishedOn });
                parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@createdon", Value = data.CreatedOn });
                parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@modifiedon", Value = data.ModifiedOn });
                parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@url", Value = data.Url });
                parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@fields", Value = data.Fields.ToString() });
                parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@covers", Value = data.Covers.ToString() });
                parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@maturecontent", Value = data.MatureContent });
                parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@owners", Value = data.Owners.ToString() });
                parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@stats", Value = data.Stats.ToString() });

                isSuccess = _dbContext.ExecuteStoredProcedure(spAddProjectTalent, parameters) == 0 ? false : true;
                return new ObjectResult(isSuccess);
            }
            catch (Exception ex)
            {
                return new ObjectResult(false);
            }
        }
    }
}
