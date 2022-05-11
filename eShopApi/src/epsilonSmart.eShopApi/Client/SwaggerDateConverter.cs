/* 
 * EpsilonSmart Eshop API
 *
 * This is the EspilonSmart API descriptor. The particular definition of the API provides API endpoints related to e-shop operations. </br>  All the following actions require Authorization token. Http request should contain a header having key: 'Authorization' and value: 'Bearer {Jwt Token value}'.   If the request lacks Authorization header or the token is invalid, each action responds with status 401 Unauthorized.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using Newtonsoft.Json.Converters;

namespace epsilonSmart.eShopApi.Client
{
    /// <summary>
    /// Formatter for 'date' swagger formats ss defined by full-date - RFC3339
    /// see https://github.com/OAI/OpenAPI-Specification/blob/master/versions/2.0.md#data-types
    /// </summary>
    public class SwaggerDateConverter : IsoDateTimeConverter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SwaggerDateConverter" /> class.
        /// </summary>
        public SwaggerDateConverter()
        {
            // full-date   = date-fullyear "-" date-month "-" date-mday
            DateTimeFormat = "yyyy-MM-dd";
        }
    }
}
