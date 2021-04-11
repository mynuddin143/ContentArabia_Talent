using IO.Swagger.Controllers;
using IO.Swagger.Models;
using Microsoft.AspNetCore.Mvc;
using SE.CAF.CC.Persistance;
using System;
using System.Collections.Generic;
using System.Text;

namespace Content.Talent.DataAccess
{
    public class TalentRegistrationDA: IRegistrationApiController
    {
        private const string spGetUsers = @"dbo.GetUsers";
        private const string spGetUsersById = @"dbo.GetUsersById";
        private const string spUpdateUser = @"dbo.UpdateUser";

        protected IRepository _dbContext;
        public TalentRegistrationDA(IRepository dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult AddTalent(TalentRequestDetails data)
        {
            return null;
           // return OK(null);
        }

        public IActionResult TalentId(TalentRequestDetails body)
        {
            return null;
        }

        public IActionResult TalentRegistrationTalentIdDelete(long? talentId)
        {
            return null;
        }
    }
}
