/*
 *  CAPD 1 - Talent Registration
 *
 * This document contains the specification of the Talent Registration API
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
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
    public class TalentDetailsApiController : ControllerBase
    { 
        /// <summary>
        /// Gets an talent item
        /// </summary>
        /// <remarks>Gets an Talnet to the system</remarks>
        /// <response code="200">Success</response>
        /// <response code="400">Request had bad syntax or was impossible to fulfill.</response>
        /// <response code="401">Unauthorized. Missing valid authentication credentials for the target resource.</response>
        /// <response code="404">The specified resource was not found.</response>
        /// <response code="405">Invalid input</response>
        [HttpGet]
        [Route("/talentDetails")]
        [ValidateModelState]
        [SwaggerOperation("GetTalent")]
        [SwaggerResponse(statusCode: 200, type: typeof(TalentRequestDetails), description: "Success")]
        [SwaggerResponse(statusCode: 400, type: typeof(Error), description: "Request had bad syntax or was impossible to fulfill.")]
        [SwaggerResponse(statusCode: 401, type: typeof(Error), description: "Unauthorized. Missing valid authentication credentials for the target resource.")]
        [SwaggerResponse(statusCode: 404, type: typeof(Error), description: "The specified resource was not found.")]
        public virtual IActionResult GetTalent()
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(TalentRequestDetails));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(Error));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(Error));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(Error));

            //TODO: Uncomment the next line to return response 405 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(405);
            string exampleJson = null;
            exampleJson = "{\n  \"ProjectDetails\" : {\n    \"modifiedOn\" : \"23012021\",\n    \"stats\" : [ \"http://behance.vo.\", \"Product Design\" ],\n    \"name\" : \"jhon\",\n    \"publishedOn\" : \"23012021\",\n    \"matureContent\" : \"http://www.behance.net/gallery\",\n    \"owners\" : [ \"http://behance.vo.\", \"Product Design\" ],\n    \"id\" : 33423,\n    \"fields\" : [ \"Branding\", \"Product Design\" ],\n    \"createdOn\" : \"23012021\",\n    \"url\" : \"http://www.behance.net/gallery\",\n    \"covers\" : [ \"http://behance.vo.\", \"Product Design\" ]\n  },\n  \"SocialDetails\" : {\n    \"twitter\" : \"twitter.com\",\n    \"facebook\" : \"facebook.com\",\n    \"tumblr\" : \"tumblr.com\",\n    \"google\" : \"google.com\",\n    \"linkedin\" : \"linkedin.com\",\n    \"instagram\" : \"instagram.com\"\n  },\n  \"ConatctDetails\" : {\n    \"firstName\" : \"John\",\n    \"lastName\" : \"Cena\",\n    \"emailAddress\" : \"abcxyz@gmail.com\",\n    \"phoneNumber\" : \"9876543210\",\n    \"profilePhoto\" : \"profilePhoto\",\n    \"contentlyPortifolioURl\" : \"username.contenly.com\",\n    \"primarySkill\" : \"sql, react\",\n    \"personalWebsiteUrl\" : \"personalWebsiteUrl\",\n    \"timeZone\" : \"INdia(East)05:30\",\n    \"location\" : \"India,Dubai\"\n  },\n  \"BioDetails\" : {\n    \"bio\" : \"bio brief\",\n    \"fluentLanguage\" : \"hindi,english\",\n    \"title\" : \"UX designer\"\n  }\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<TalentRequestDetails>(exampleJson)
                        : default(TalentRequestDetails);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Gets an talent client item
        /// </summary>
        /// <remarks>Gets an Talnet client to the system</remarks>
        /// <param name="talentId">talent ID</param>
        /// <response code="200">Success</response>
        /// <response code="400">Request had bad syntax or was impossible to fulfill.</response>
        /// <response code="401">Unauthorized. Missing valid authentication credentials for the target resource.</response>
        /// <response code="404">The specified resource was not found.</response>
        /// <response code="405">Invalid input</response>
        [HttpGet]
        [Route("/talentClientDetails/{talentId}")]
        [ValidateModelState]
        [SwaggerOperation("TalentClientDetailsTalentIdGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(TalentRequestDetails), description: "Success")]
        [SwaggerResponse(statusCode: 400, type: typeof(Error), description: "Request had bad syntax or was impossible to fulfill.")]
        [SwaggerResponse(statusCode: 401, type: typeof(Error), description: "Unauthorized. Missing valid authentication credentials for the target resource.")]
        [SwaggerResponse(statusCode: 404, type: typeof(Error), description: "The specified resource was not found.")]
        public virtual IActionResult TalentClientDetailsTalentIdGet([FromRoute][Required]string talentId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(TalentRequestDetails));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(Error));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(Error));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(Error));

            //TODO: Uncomment the next line to return response 405 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(405);
            string exampleJson = null;
            exampleJson = "{\n  \"ProjectDetails\" : {\n    \"modifiedOn\" : \"23012021\",\n    \"stats\" : [ \"http://behance.vo.\", \"Product Design\" ],\n    \"name\" : \"jhon\",\n    \"publishedOn\" : \"23012021\",\n    \"matureContent\" : \"http://www.behance.net/gallery\",\n    \"owners\" : [ \"http://behance.vo.\", \"Product Design\" ],\n    \"id\" : 33423,\n    \"fields\" : [ \"Branding\", \"Product Design\" ],\n    \"createdOn\" : \"23012021\",\n    \"url\" : \"http://www.behance.net/gallery\",\n    \"covers\" : [ \"http://behance.vo.\", \"Product Design\" ]\n  },\n  \"SocialDetails\" : {\n    \"twitter\" : \"twitter.com\",\n    \"facebook\" : \"facebook.com\",\n    \"tumblr\" : \"tumblr.com\",\n    \"google\" : \"google.com\",\n    \"linkedin\" : \"linkedin.com\",\n    \"instagram\" : \"instagram.com\"\n  },\n  \"ConatctDetails\" : {\n    \"firstName\" : \"John\",\n    \"lastName\" : \"Cena\",\n    \"emailAddress\" : \"abcxyz@gmail.com\",\n    \"phoneNumber\" : \"9876543210\",\n    \"profilePhoto\" : \"profilePhoto\",\n    \"contentlyPortifolioURl\" : \"username.contenly.com\",\n    \"primarySkill\" : \"sql, react\",\n    \"personalWebsiteUrl\" : \"personalWebsiteUrl\",\n    \"timeZone\" : \"INdia(East)05:30\",\n    \"location\" : \"India,Dubai\"\n  },\n  \"BioDetails\" : {\n    \"bio\" : \"bio brief\",\n    \"fluentLanguage\" : \"hindi,english\",\n    \"title\" : \"UX designer\"\n  }\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<TalentRequestDetails>(exampleJson)
                        : default(TalentRequestDetails);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Gets an talent skills item
        /// </summary>
        /// <remarks>Gets an Talnet skills to the system</remarks>
        /// <param name="talentId">talent ID</param>
        /// <response code="200">Success</response>
        /// <response code="400">Request had bad syntax or was impossible to fulfill.</response>
        /// <response code="401">Unauthorized. Missing valid authentication credentials for the target resource.</response>
        /// <response code="404">The specified resource was not found.</response>
        /// <response code="405">Invalid input</response>
        [HttpGet]
        [Route("/talentSkillDetails/{talentId}")]
        [ValidateModelState]
        [SwaggerOperation("TalentSkillDetailsTalentIdGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(TalentRequestDetails), description: "Success")]
        [SwaggerResponse(statusCode: 400, type: typeof(Error), description: "Request had bad syntax or was impossible to fulfill.")]
        [SwaggerResponse(statusCode: 401, type: typeof(Error), description: "Unauthorized. Missing valid authentication credentials for the target resource.")]
        [SwaggerResponse(statusCode: 404, type: typeof(Error), description: "The specified resource was not found.")]
        public virtual IActionResult TalentSkillDetailsTalentIdGet([FromRoute][Required]string talentId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(TalentRequestDetails));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(Error));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(Error));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(Error));

            //TODO: Uncomment the next line to return response 405 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(405);
            string exampleJson = null;
            exampleJson = "{\n  \"ProjectDetails\" : {\n    \"modifiedOn\" : \"23012021\",\n    \"stats\" : [ \"http://behance.vo.\", \"Product Design\" ],\n    \"name\" : \"jhon\",\n    \"publishedOn\" : \"23012021\",\n    \"matureContent\" : \"http://www.behance.net/gallery\",\n    \"owners\" : [ \"http://behance.vo.\", \"Product Design\" ],\n    \"id\" : 33423,\n    \"fields\" : [ \"Branding\", \"Product Design\" ],\n    \"createdOn\" : \"23012021\",\n    \"url\" : \"http://www.behance.net/gallery\",\n    \"covers\" : [ \"http://behance.vo.\", \"Product Design\" ]\n  },\n  \"SocialDetails\" : {\n    \"twitter\" : \"twitter.com\",\n    \"facebook\" : \"facebook.com\",\n    \"tumblr\" : \"tumblr.com\",\n    \"google\" : \"google.com\",\n    \"linkedin\" : \"linkedin.com\",\n    \"instagram\" : \"instagram.com\"\n  },\n  \"ConatctDetails\" : {\n    \"firstName\" : \"John\",\n    \"lastName\" : \"Cena\",\n    \"emailAddress\" : \"abcxyz@gmail.com\",\n    \"phoneNumber\" : \"9876543210\",\n    \"profilePhoto\" : \"profilePhoto\",\n    \"contentlyPortifolioURl\" : \"username.contenly.com\",\n    \"primarySkill\" : \"sql, react\",\n    \"personalWebsiteUrl\" : \"personalWebsiteUrl\",\n    \"timeZone\" : \"INdia(East)05:30\",\n    \"location\" : \"India,Dubai\"\n  },\n  \"BioDetails\" : {\n    \"bio\" : \"bio brief\",\n    \"fluentLanguage\" : \"hindi,english\",\n    \"title\" : \"UX designer\"\n  }\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<TalentRequestDetails>(exampleJson)
                        : default(TalentRequestDetails);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Gets an talent topics item
        /// </summary>
        /// <remarks>Gets an Talnet topics to the system</remarks>
        /// <param name="talentId">talent ID</param>
        /// <response code="200">Success</response>
        /// <response code="400">Request had bad syntax or was impossible to fulfill.</response>
        /// <response code="401">Unauthorized. Missing valid authentication credentials for the target resource.</response>
        /// <response code="404">The specified resource was not found.</response>
        /// <response code="405">Invalid input</response>
        [HttpGet]
        [Route("/talentTopicsDetails/{talentId}")]
        [ValidateModelState]
        [SwaggerOperation("TalentTopicsDetailsTalentIdGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(TalentRequestDetails), description: "Success")]
        [SwaggerResponse(statusCode: 400, type: typeof(Error), description: "Request had bad syntax or was impossible to fulfill.")]
        [SwaggerResponse(statusCode: 401, type: typeof(Error), description: "Unauthorized. Missing valid authentication credentials for the target resource.")]
        [SwaggerResponse(statusCode: 404, type: typeof(Error), description: "The specified resource was not found.")]
        public virtual IActionResult TalentTopicsDetailsTalentIdGet([FromRoute][Required]string talentId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(TalentRequestDetails));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(Error));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(Error));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(Error));

            //TODO: Uncomment the next line to return response 405 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(405);
            string exampleJson = null;
            exampleJson = "{\n  \"ProjectDetails\" : {\n    \"modifiedOn\" : \"23012021\",\n    \"stats\" : [ \"http://behance.vo.\", \"Product Design\" ],\n    \"name\" : \"jhon\",\n    \"publishedOn\" : \"23012021\",\n    \"matureContent\" : \"http://www.behance.net/gallery\",\n    \"owners\" : [ \"http://behance.vo.\", \"Product Design\" ],\n    \"id\" : 33423,\n    \"fields\" : [ \"Branding\", \"Product Design\" ],\n    \"createdOn\" : \"23012021\",\n    \"url\" : \"http://www.behance.net/gallery\",\n    \"covers\" : [ \"http://behance.vo.\", \"Product Design\" ]\n  },\n  \"SocialDetails\" : {\n    \"twitter\" : \"twitter.com\",\n    \"facebook\" : \"facebook.com\",\n    \"tumblr\" : \"tumblr.com\",\n    \"google\" : \"google.com\",\n    \"linkedin\" : \"linkedin.com\",\n    \"instagram\" : \"instagram.com\"\n  },\n  \"ConatctDetails\" : {\n    \"firstName\" : \"John\",\n    \"lastName\" : \"Cena\",\n    \"emailAddress\" : \"abcxyz@gmail.com\",\n    \"phoneNumber\" : \"9876543210\",\n    \"profilePhoto\" : \"profilePhoto\",\n    \"contentlyPortifolioURl\" : \"username.contenly.com\",\n    \"primarySkill\" : \"sql, react\",\n    \"personalWebsiteUrl\" : \"personalWebsiteUrl\",\n    \"timeZone\" : \"INdia(East)05:30\",\n    \"location\" : \"India,Dubai\"\n  },\n  \"BioDetails\" : {\n    \"bio\" : \"bio brief\",\n    \"fluentLanguage\" : \"hindi,english\",\n    \"title\" : \"UX designer\"\n  }\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<TalentRequestDetails>(exampleJson)
                        : default(TalentRequestDetails);            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
