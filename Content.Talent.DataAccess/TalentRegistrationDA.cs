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
    public class TalentRegistrationDA: IRegistrationApiController
    {
        private const string spAddTalent = @"dbo.AddTalent";
        private const string spAddBioTalent = @"dbo.AddBioTalentDetails";
        private const string spAddSocialTalent = @"dbo.AddSocialTalentDetails";
        private const string spAddProjectTalent = @"dbo.AddProjectTalentDetails";

        protected IRepository _dbContext;
        public TalentRegistrationDA(IRepository dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult AddTalent(TalentRequestDetails data)
        {
            TalentRequestDetails db_data = new TalentRequestDetails();
            bool isSuccess = false;
            Guid talentId = Guid.NewGuid();
            if (data.ConatctDetails != null)
            {
               // bool isSuccess = false;


                try
                {
                    //  _dbContext.ExecuteSQLCommand(spUpdateUser);
                    IList<IDataParameter> parameters = new List<IDataParameter>();

                    parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.Guid, ParameterName = "@talentId", Value = talentId });
                    parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@firstname", Value = data.ConatctDetails.FirstName });
                    parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@lastname", Value = data.ConatctDetails.LastName });
                    parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@emailaddress", Value = data.ConatctDetails.EmailAddress });
                    parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@primaryskill", Value = data.ConatctDetails.PrimarySkill });
                    parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@personalwebsite", Value = data.ConatctDetails.PersonalWebsiteUrl });
                    parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@phonenumber", Value = data.ConatctDetails.PhoneNumber });
                    parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@location", Value = data.ConatctDetails.Location });
                    parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@timezone", Value = data.ConatctDetails.TimeZone });
                    parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@contenlyprofileUrl", Value = data.ConatctDetails.ContentlyPortifolioURl });
                    parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@profile_photo", Value = data.ConatctDetails.ProfilePhoto });

                    isSuccess = _dbContext.ExecuteStoredProcedure(spAddTalent, parameters) == 0 ? false : true;
                   // return new ObjectResult(isSuccess);
                }
                catch (Exception ex)
                {
                    return new ObjectResult(false);
                }
            }
            if (data.BioDetails != null)
            {
                //bool isSuccess = false;


                try
                {
                    //  _dbContext.ExecuteSQLCommand(spUpdateUser);
                    IList<IDataParameter> parameters = new List<IDataParameter>();

                    parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.Guid, ParameterName = "@talentId", Value = talentId });
                    parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@title", Value = data.BioDetails.Title });
                    parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@bio", Value = data.BioDetails.Bio });
                    parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@fluentLanguages", Value = data.BioDetails.FluentLanguage });
                    
                    isSuccess = _dbContext.ExecuteStoredProcedure(spAddBioTalent, parameters) == 0 ? false : true;
                    //return new ObjectResult(isSuccess);
                }
                catch (Exception ex)
                {
                    return new ObjectResult(false);
                }
            }
            if (data.SocialDetails != null)
            {
                //bool isSuccess = false;


                try
                {
                    //  _dbContext.ExecuteSQLCommand(spUpdateUser);
                    IList<IDataParameter> parameters = new List<IDataParameter>();

                    parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.Guid, ParameterName = "@talentId", Value = talentId });
                    parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@facebook", Value = data.SocialDetails.Facebook });
                    parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@twitter", Value = data.SocialDetails.Twitter });
                    parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@linkedin", Value = data.SocialDetails.Linkedin });
                    parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@tumblr", Value = data.SocialDetails.Tumblr });
                    parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@instagram", Value = data.SocialDetails.Instagram });
                    parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@google", Value = data.SocialDetails.Google });
                    
                    isSuccess = _dbContext.ExecuteStoredProcedure(spAddSocialTalent, parameters) == 0 ? false : true;
                    //return new ObjectResult(isSuccess);
                }
                catch (Exception ex)
                {
                    return new ObjectResult(false);
                }
            }
            if (data.ProjectDetails != null)
            {
               // bool isSuccess = false;


                try
                {
                    //  _dbContext.ExecuteSQLCommand(spUpdateUser);
                    IList<IDataParameter> parameters = new List<IDataParameter>();

                    parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.Guid, ParameterName = "@talentId", Value = talentId });
                    parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@name", Value = data.ProjectDetails.Name });
                    parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@publishedon", Value = data.ProjectDetails.PublishedOn });
                    parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@createdon", Value = data.ProjectDetails.CreatedOn });
                    parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@modifiedon", Value = data.ProjectDetails.ModifiedOn });
                    parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@url", Value = data.ProjectDetails.Url });
                    parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@fields", Value = data.ProjectDetails.Fields.ToString() });
                    parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@covers", Value = data.ProjectDetails.Covers.ToString() });
                    parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@maturecontent", Value = data.ProjectDetails.MatureContent });
                    parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@owners", Value = data.ProjectDetails.Owners.ToString() });
                    parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@stats", Value = data.ProjectDetails.Stats.ToString() });

                    isSuccess = _dbContext.ExecuteStoredProcedure(spAddProjectTalent, parameters) == 0 ? false : true;
                    //return new ObjectResult(isSuccess);
                }
                catch (Exception ex)
                {
                    return new ObjectResult(false);
                }
            }
            return new ObjectResult(isSuccess); 
           // return OK(null);
        }

        public IActionResult TalentId(TalentRequestDetails data,string dtalentId)
        {
            bool isSuccess = false;
            Guid talentId =new Guid(dtalentId);
            if (data.ConatctDetails != null)
            {
                // bool isSuccess = false;


                try
                {
                    //  _dbContext.ExecuteSQLCommand(spUpdateUser);
                    IList<IDataParameter> parameters = new List<IDataParameter>();

                    parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.Guid, ParameterName = "@talentId", Value = talentId });
                    parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@firstname", Value = data.ConatctDetails.FirstName });
                    parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@lastname", Value = data.ConatctDetails.LastName });
                    parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@emailaddress", Value = data.ConatctDetails.EmailAddress });
                    parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@primaryskill", Value = data.ConatctDetails.PrimarySkill });
                    parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@personalwebsite", Value = data.ConatctDetails.PersonalWebsiteUrl });
                    parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@phonenumber", Value = data.ConatctDetails.PhoneNumber });
                    parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@location", Value = data.ConatctDetails.Location });
                    parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@timezone", Value = data.ConatctDetails.TimeZone });
                    parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@contenlyprofileUrl", Value = data.ConatctDetails.ContentlyPortifolioURl });
                    parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@profile_photo", Value = data.ConatctDetails.ProfilePhoto });

                    isSuccess = _dbContext.ExecuteStoredProcedure(spAddTalent, parameters) == 0 ? false : true;
                    // return new ObjectResult(isSuccess);
                }
                catch (Exception ex)
                {
                    return new ObjectResult(false);
                }
            }
            if (data.BioDetails != null)
            {
                //bool isSuccess = false;


                try
                {
                    //  _dbContext.ExecuteSQLCommand(spUpdateUser);
                    IList<IDataParameter> parameters = new List<IDataParameter>();

                    parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.Guid, ParameterName = "@talentId", Value = talentId });
                    parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@title", Value = data.BioDetails.Title });
                    parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@bio", Value = data.BioDetails.Bio });
                    parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@fluentLanguages", Value = data.BioDetails.FluentLanguage });

                    isSuccess = _dbContext.ExecuteStoredProcedure(spAddBioTalent, parameters) == 0 ? false : true;
                    //return new ObjectResult(isSuccess);
                }
                catch (Exception ex)
                {
                    return new ObjectResult(false);
                }
            }
            if (data.SocialDetails != null)
            {
                //bool isSuccess = false;


                try
                {
                    //  _dbContext.ExecuteSQLCommand(spUpdateUser);
                    IList<IDataParameter> parameters = new List<IDataParameter>();

                    parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.Guid, ParameterName = "@talentId", Value = talentId });
                    parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@facebook", Value = data.SocialDetails.Facebook });
                    parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@twitter", Value = data.SocialDetails.Twitter });
                    parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@linkedin", Value = data.SocialDetails.Linkedin });
                    parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@tumblr", Value = data.SocialDetails.Tumblr });
                    parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@instagram", Value = data.SocialDetails.Instagram });
                    parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@google", Value = data.SocialDetails.Google });

                    isSuccess = _dbContext.ExecuteStoredProcedure(spAddSocialTalent, parameters) == 0 ? false : true;
                    //return new ObjectResult(isSuccess);
                }
                catch (Exception ex)
                {
                    return new ObjectResult(false);
                }
            }
            if (data.ProjectDetails != null)
            {
                // bool isSuccess = false;


                try
                {
                    //  _dbContext.ExecuteSQLCommand(spUpdateUser);
                    IList<IDataParameter> parameters = new List<IDataParameter>();

                    parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.Guid, ParameterName = "@talentId", Value = talentId });
                    parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@name", Value = data.ProjectDetails.Name });
                    parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@publishedon", Value = data.ProjectDetails.PublishedOn });
                    parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@createdon", Value = data.ProjectDetails.CreatedOn });
                    parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@modifiedon", Value = data.ProjectDetails.ModifiedOn });
                    parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@url", Value = data.ProjectDetails.Url });
                    parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@fields", Value = data.ProjectDetails.Fields.ToString() });
                    parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@covers", Value = data.ProjectDetails.Covers.ToString() });
                    parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@maturecontent", Value = data.ProjectDetails.MatureContent });
                    parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@owners", Value = data.ProjectDetails.Owners.ToString() });
                    parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, DbType = DbType.String, ParameterName = "@stats", Value = data.ProjectDetails.Stats.ToString() });

                    isSuccess = _dbContext.ExecuteStoredProcedure(spAddProjectTalent, parameters) == 0 ? false : true;
                    //return new ObjectResult(isSuccess);
                }
                catch (Exception ex)
                {
                    return new ObjectResult(false);
                }
            }
            return new ObjectResult(isSuccess);
        }

        public IActionResult TalentRegistrationTalentIdDelete(string talentId)
        {
            return null;
        }
    }
}
