/*
 *  CAPD 1 - Talent Registration
 *
 * This document contains the specification of the Talent Registration API
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using IO.Swagger.Models;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    public interface IContactDetailsApiController
    { 
        /// <summary>
        /// Remove ContactDetails project
        /// </summary>
        /// <remarks>Remove ContactDetails project</remarks>
        /// <param name="talentId">delete talaent project</param>
        /// <response code="200">Success</response>
        /// <response code="400">Request had bad syntax or was impossible to fulfill.</response>
        /// <response code="401">Unauthorized. Missing valid authentication credentials for the target resource.</response>
        /// <response code="404">The specified resource was not found.</response>
        IActionResult TalentContactDetailsTalentIdDelete([FromRoute][Required]string talentId);

        /// <summary>
        /// Gets an talent ContactDetails
        /// </summary>
        /// <remarks>Gets an Talnet ContactDetails to the system</remarks>
        /// <param name="talentId">talent ID</param>
        /// <response code="200">Success</response>
        /// <response code="400">Request had bad syntax or was impossible to fulfill.</response>
        /// <response code="401">Unauthorized. Missing valid authentication credentials for the target resource.</response>
        /// <response code="404">The specified resource was not found.</response>
        /// <response code="405">Invalid input</response>
        IActionResult TalentContactDetailsTalentIdGet([FromRoute][Required]string talentId);

        /// <summary>
        /// Gets an talent ContactDetails item
        /// </summary>
        /// <remarks>Gets an Talnet ContactDetails to the system</remarks>
        /// <param name="talentId">talent ID</param>
        /// <response code="200">Success</response>
        /// <response code="400">Request had bad syntax or was impossible to fulfill.</response>
        /// <response code="401">Unauthorized. Missing valid authentication credentials for the target resource.</response>
        /// <response code="404">The specified resource was not found.</response>
        /// <response code="405">Invalid input</response>
        IActionResult TalentContactDetailsTalentIdPut([FromBody]ConatctDetails body,[FromRoute][Required]string talentId);
    }
}
