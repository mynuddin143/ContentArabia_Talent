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
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using IO.Swagger.Attributes;
using IO.Swagger.Models;
using Swashbuckle.Swagger.Annotations;

namespace IO.Swagger.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class SocialDetailsApiController : ControllerBase
    {
        private readonly ISocialDetailsApiController _iSocialDetailsApiController;
        public SocialDetailsApiController(ISocialDetailsApiController iSocialDetailsApiController)
        {

            _iSocialDetailsApiController = iSocialDetailsApiController;
        }
        /// <summary>
        /// Remove SocialDetails project
        /// </summary>
        /// <remarks>Remove SocialDetails project</remarks>
        /// <param name="talentId">delete talaent project</param>
        /// <response code="200">Success</response>
        /// <response code="400">Request had bad syntax or was impossible to fulfill.</response>
        /// <response code="401">Unauthorized. Missing valid authentication credentials for the target resource.</response>
        /// <response code="404">The specified resource was not found.</response>
        [HttpDelete]
        [Route("/talentSocialDetails/{talentId}")]
        [ValidateModelState]
        [SwaggerOperation("TalentSocialDetailsTalentIdDelete")]
        [SwaggerResponse(statusCode: 400, type: typeof(Error), description: "Request had bad syntax or was impossible to fulfill.")]
        [SwaggerResponse(statusCode: 401, type: typeof(Error), description: "Unauthorized. Missing valid authentication credentials for the target resource.")]
        [SwaggerResponse(statusCode: 404, type: typeof(Error), description: "The specified resource was not found.")]
        public virtual IActionResult TalentSocialDetailsTalentIdDelete([FromRoute][Required]string talentId)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(Error));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(Error));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(Error));

            return new ObjectResult(_iSocialDetailsApiController.TalentSocialDetailsTalentIdDelete(talentId));
        }

        /// <summary>
        /// Gets an talent SocialDetails
        /// </summary>
        /// <remarks>Gets an Talnet SocialDetails to the system</remarks>
        /// <param name="talentId">talent ID</param>
        /// <response code="200">Success</response>
        /// <response code="400">Request had bad syntax or was impossible to fulfill.</response>
        /// <response code="401">Unauthorized. Missing valid authentication credentials for the target resource.</response>
        /// <response code="404">The specified resource was not found.</response>
        /// <response code="405">Invalid input</response>
        [HttpGet]
        [Route("/talentSocialDetails/{talentId}")]
        [ValidateModelState]
        [SwaggerOperation("TalentSocialDetailsTalentIdGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(SocialDetails), description: "Success")]
        [SwaggerResponse(statusCode: 400, type: typeof(Error), description: "Request had bad syntax or was impossible to fulfill.")]
        [SwaggerResponse(statusCode: 401, type: typeof(Error), description: "Unauthorized. Missing valid authentication credentials for the target resource.")]
        [SwaggerResponse(statusCode: 404, type: typeof(Error), description: "The specified resource was not found.")]
        public virtual IActionResult TalentSocialDetailsTalentIdGet([FromRoute][Required]string talentId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(SocialDetails));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(Error));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(Error));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(Error));

            //TODO: Uncomment the next line to return response 405 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(405);
            string exampleJson = null;
            exampleJson = "{\n  \"twitter\" : \"twitter.com\",\n  \"facebook\" : \"facebook.com\",\n  \"tumblr\" : \"tumblr.com\",\n  \"google\" : \"google.com\",\n  \"linkedin\" : \"linkedin.com\",\n  \"instagram\" : \"instagram.com\"\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<SocialDetails>(exampleJson)
                        : default(SocialDetails);            //TODO: Change the data returned
            return new ObjectResult(_iSocialDetailsApiController.TalentSocialDetailsTalentIdGet(talentId));
        }

        /// <summary>
        /// Gets an talent SocialDetails item
        /// </summary>
        /// <remarks>Gets an Talnet SocialDetails to the system</remarks>
        /// <param name="talentId">talent ID</param>
        /// <response code="200">Success</response>
        /// <response code="400">Request had bad syntax or was impossible to fulfill.</response>
        /// <response code="401">Unauthorized. Missing valid authentication credentials for the target resource.</response>
        /// <response code="404">The specified resource was not found.</response>
        /// <response code="405">Invalid input</response>
        [HttpPut]
        [Route("/talentSocialDetails/{talentId}")]
        [ValidateModelState]
        [SwaggerOperation("TalentSocialDetailsTalentIdPut")]
        [SwaggerResponse(statusCode: 200, type: typeof(SocialDetails), description: "Success")]
        [SwaggerResponse(statusCode: 400, type: typeof(Error), description: "Request had bad syntax or was impossible to fulfill.")]
        [SwaggerResponse(statusCode: 401, type: typeof(Error), description: "Unauthorized. Missing valid authentication credentials for the target resource.")]
        [SwaggerResponse(statusCode: 404, type: typeof(Error), description: "The specified resource was not found.")]
        public virtual IActionResult TalentSocialDetailsTalentIdPut([FromBody]SocialDetails body, [FromRoute][Required]string talentId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(SocialDetails));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(Error));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(Error));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(Error));

            //TODO: Uncomment the next line to return response 405 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(405);
            string exampleJson = null;
            exampleJson = "{\n  \"twitter\" : \"twitter.com\",\n  \"facebook\" : \"facebook.com\",\n  \"tumblr\" : \"tumblr.com\",\n  \"google\" : \"google.com\",\n  \"linkedin\" : \"linkedin.com\",\n  \"instagram\" : \"instagram.com\"\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<SocialDetails>(exampleJson)
                        : default(SocialDetails);            //TODO: Change the data returned
            return new ObjectResult(_iSocialDetailsApiController.TalentSocialDetailsTalentIdPut(body,talentId));
        }
    }
}
