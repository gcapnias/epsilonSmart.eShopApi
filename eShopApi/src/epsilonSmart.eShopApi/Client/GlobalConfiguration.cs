/* 
 * EpsilonSmart Eshop API
 *
 * This is the EspilonSmart API descriptor. The particular definition of the API provides API endpoints related to e-shop operations. </br>  All the following actions require Authorization token. Http request should contain a header having key: 'Authorization' and value: 'Bearer {Jwt Token value}'.   If the request lacks Authorization header or the token is invalid, each action responds with status 401 Unauthorized.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Reflection;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace epsilonSmart.eShopApi.Client
{
    /// <summary>
    /// <see cref="GlobalConfiguration"/> provides a compile-time extension point for globally configuring
    /// API Clients.
    /// </summary>
    /// <remarks>
    /// A customized implementation via partial class may reside in another file and may
    /// be excluded from automatic generation via a .swagger-codegen-ignore file.
    /// </remarks>
    public partial class GlobalConfiguration : Configuration
    {

    }
}