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
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{ 
    /// <summary>
    /// to get all Talent socail details.
    /// </summary>
    [DataContract]
    public partial class SocialDetails : IEquatable<SocialDetails>
    { 
        /// <summary>
        /// Gets or Sets Facebook
        /// </summary>
        [DataMember(Name="facebook")]
        public string Facebook { get; set; }

        /// <summary>
        /// Gets or Sets Twitter
        /// </summary>
        [DataMember(Name="twitter")]
        public string Twitter { get; set; }

        /// <summary>
        /// Gets or Sets Linkedin
        /// </summary>
        [DataMember(Name="linkedin")]
        public string Linkedin { get; set; }

        /// <summary>
        /// Gets or Sets Tumblr
        /// </summary>
        [DataMember(Name="tumblr")]
        public string Tumblr { get; set; }

        /// <summary>
        /// Gets or Sets Instagram
        /// </summary>
        [DataMember(Name="instagram")]
        public string Instagram { get; set; }

        /// <summary>
        /// Gets or Sets Google
        /// </summary>
        [DataMember(Name="google")]
        public string Google { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SocialDetails {\n");
            sb.Append("  Facebook: ").Append(Facebook).Append("\n");
            sb.Append("  Twitter: ").Append(Twitter).Append("\n");
            sb.Append("  Linkedin: ").Append(Linkedin).Append("\n");
            sb.Append("  Tumblr: ").Append(Tumblr).Append("\n");
            sb.Append("  Instagram: ").Append(Instagram).Append("\n");
            sb.Append("  Google: ").Append(Google).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((SocialDetails)obj);
        }

        /// <summary>
        /// Returns true if SocialDetails instances are equal
        /// </summary>
        /// <param name="other">Instance of SocialDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SocialDetails other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Facebook == other.Facebook ||
                    Facebook != null &&
                    Facebook.Equals(other.Facebook)
                ) && 
                (
                    Twitter == other.Twitter ||
                    Twitter != null &&
                    Twitter.Equals(other.Twitter)
                ) && 
                (
                    Linkedin == other.Linkedin ||
                    Linkedin != null &&
                    Linkedin.Equals(other.Linkedin)
                ) && 
                (
                    Tumblr == other.Tumblr ||
                    Tumblr != null &&
                    Tumblr.Equals(other.Tumblr)
                ) && 
                (
                    Instagram == other.Instagram ||
                    Instagram != null &&
                    Instagram.Equals(other.Instagram)
                ) && 
                (
                    Google == other.Google ||
                    Google != null &&
                    Google.Equals(other.Google)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Facebook != null)
                    hashCode = hashCode * 59 + Facebook.GetHashCode();
                    if (Twitter != null)
                    hashCode = hashCode * 59 + Twitter.GetHashCode();
                    if (Linkedin != null)
                    hashCode = hashCode * 59 + Linkedin.GetHashCode();
                    if (Tumblr != null)
                    hashCode = hashCode * 59 + Tumblr.GetHashCode();
                    if (Instagram != null)
                    hashCode = hashCode * 59 + Instagram.GetHashCode();
                    if (Google != null)
                    hashCode = hashCode * 59 + Google.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SocialDetails left, SocialDetails right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SocialDetails left, SocialDetails right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
