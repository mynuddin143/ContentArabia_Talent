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
    public class BioDetailsApiController : ControllerBase
    {
        private readonly IBioDetailsApiController _iBioDetailsApiController;
        public BioDetailsApiController(IBioDetailsApiController iBioDetailsApiController)
        {

            _iBioDetailsApiController = iBioDetailsApiController;
        }
        /// <summary>
        /// Remove BioDetails project
        /// </summary>
        /// <remarks>Remove BioDetails project</remarks>
        /// <param name="talentId">delete talaent project</param>
        /// <response code="200">Success</response>
        /// <response code="400">Request had bad syntax or was impossible to fulfill.</response>
        /// <response code="401">Unauthorized. Missing valid authentication credentials for the target resource.</response>
        /// <response code="404">The specified resource was not found.</response>
        [HttpDelete]
        [Route("/talentBioDetails/{talentId}")]
        [ValidateModelState]
        [SwaggerOperation("TalentBioDetailsTalentIdDelete")]
        [SwaggerResponse(statusCode: 400, type: typeof(Error), description: "Request had bad syntax or was impossible to fulfill.")]
        [SwaggerResponse(statusCode: 401, type: typeof(Error), description: "Unauthorized. Missing valid authentication credentials for the target resource.")]
        [SwaggerResponse(statusCode: 404, type: typeof(Error), description: "The specified resource was not found.")]
        public virtual IActionResult TalentBioDetailsTalentIdDelete([FromRoute][Required]long? talentId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(Error));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(Error));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(Error));

            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets an talent bio details
        /// </summary>
        /// <remarks>Gets an Talnet bio details to the system</remarks>
        /// <param name="talentId">talent ID</param>
        /// <response code="200">Success</response>
        /// <response code="400">Request had bad syntax or was impossible to fulfill.</response>
        /// <response code="401">Unauthorized. Missing valid authentication credentials for the target resource.</response>
        /// <response code="404">The specified resource was not found.</response>
        /// <response code="405">Invalid input</response>
        [HttpGet]
        [Route("/talentBioDetails/{talentId}")]
        [ValidateModelState]
        [SwaggerOperation("TalentBioDetailsTalentIdGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(BioDetails), description: "Success")]
        [SwaggerResponse(statusCode: 400, type: typeof(Error), description: "Request had bad syntax or was impossible to fulfill.")]
        [SwaggerResponse(statusCode: 401, type: typeof(Error), description: "Unauthorized. Missing valid authentication credentials for the target resource.")]
        [SwaggerResponse(statusCode: 404, type: typeof(Error), description: "The specified resource was not found.")]
        public virtual IActionResult TalentBioDetailsTalentIdGet([FromRoute][Required]long? talentId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(BioDetails));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(Error));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(Error));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(Error));

            //TODO: Uncomment the next line to return response 405 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(405);
            string exampleJson = null;
            exampleJson = "{\n  \"bio\" : \"bio brief\",\n  \"fluentLanguage\" : \"hindi,english\",\n  \"title\" : \"UX designer\"\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<BioDetails>(exampleJson)
                        : default(BioDetails);            //TODO: Change the data returned
            return new ObjectResult(_iBioDetailsApiController.TalentBioDetailsTalentIdGet(talentId));
        }

        /// <summary>
        /// Gets an talent BioDetails item
        /// </summary>
        /// <remarks>Gets an Talnet BioDetails to the system</remarks>
        /// <param name="talentId">talent ID</param>
        /// <response code="200">Success</response>
        /// <response code="400">Request had bad syntax or was impossible to fulfill.</response>
        /// <response code="401">Unauthorized. Missing valid authentication credentials for the target resource.</response>
        /// <response code="404">The specified resource was not found.</response>
        /// <response code="405">Invalid input</response>
        [HttpPut]
        [Route("/talentBioDetails/{talentId}")]
        [ValidateModelState]
        [SwaggerOperation("TalentBioDetailsTalentIdPut")]
        [SwaggerResponse(statusCode: 200, type: typeof(BioDetails), description: "Success")]
        [SwaggerResponse(statusCode: 400, type: typeof(Error), description: "Request had bad syntax or was impossible to fulfill.")]
        [SwaggerResponse(statusCode: 401, type: typeof(Error), description: "Unauthorized. Missing valid authentication credentials for the target resource.")]
        [SwaggerResponse(statusCode: 404, type: typeof(Error), description: "The specified resource was not found.")]
        public virtual IActionResult TalentBioDetailsTalentIdPut([FromRoute][Required]long? talentId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(BioDetails));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(Error));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(Error));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(Error));

            //TODO: Uncomment the next line to return response 405 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(405);
            string exampleJson = null;
            exampleJson = "{\n  \"bio\" : \"bio brief\",\n  \"fluentLanguage\" : \"hindi,english\",\n  \"title\" : \"UX designer\"\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<BioDetails>(exampleJson)
                        : default(BioDetails);            //TODO: Change the data returned
            return new ObjectResult(_iBioDetailsApiController.TalentBioDetailsTalentIdPut(talentId));
        }
    }
}