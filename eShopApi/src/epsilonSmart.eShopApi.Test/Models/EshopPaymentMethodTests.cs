/* 
 * EpsilonSmart Eshop API
 *
 * This is the EspilonSmart API descriptor. The particular definition of the API provides API endpoints related to e-shop operations. </br>  All the following actions require Authorization token. Http request should contain a header having key: 'Authorization' and value: 'Bearer {Jwt Token value}'.   If the request lacks Authorization header or the token is invalid, each action responds with status 401 Unauthorized.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using epsilonSmart.eShopApi.Api;
using epsilonSmart.eShopApi.Models;
using epsilonSmart.eShopApi.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace epsilonSmart.eShopApi.Test
{
    /// <summary>
    ///  Class for testing EshopPaymentMethod
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class EshopPaymentMethodTests
    {
        // TODO uncomment below to declare an instance variable for EshopPaymentMethod
        //private EshopPaymentMethod instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of EshopPaymentMethod
            //instance = new EshopPaymentMethod();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of EshopPaymentMethod
        /// </summary>
        [Test]
        public void EshopPaymentMethodInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" EshopPaymentMethod
            //Assert.IsInstanceOfType<EshopPaymentMethod> (instance, "variable 'instance' is a EshopPaymentMethod");
        }



    }

}