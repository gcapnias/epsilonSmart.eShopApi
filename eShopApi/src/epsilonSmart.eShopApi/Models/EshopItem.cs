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
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = epsilonSmart.eShopApi.Client.SwaggerDateConverter;

namespace epsilonSmart.eShopApi.Models
{
    /// <summary>
    /// EshopItem
    /// </summary>
    [DataContract]
        public partial class EshopItem :  IEquatable<EshopItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EshopItem" /> class.
        /// </summary>
        /// <param name="iD">iD.</param>
        /// <param name="name">name.</param>
        /// <param name="code">code.</param>
        /// <param name="scanCode">scanCode.</param>
        /// <param name="domain">domain.</param>
        /// <param name="normalVATPercent">normalVATPercent.</param>
        /// <param name="reducedVATPercent">reducedVATPercent.</param>
        /// <param name="measurementUnit">measurementUnit.</param>
        /// <param name="measurementUnitShortcut">measurementUnitShortcut.</param>
        /// <param name="category">category.</param>
        /// <param name="retailCategory">retailCategory.</param>
        /// <param name="retailCategoryInnerCode">retailCategoryInnerCode.</param>
        /// <param name="wholesalePrice">wholesalePrice.</param>
        /// <param name="retailPrice">retailPrice.</param>
        /// <param name="remarks">remarks.</param>
        /// <param name="userDefinedText01">userDefinedText01.</param>
        /// <param name="userDefinedText02">userDefinedText02.</param>
        /// <param name="userDefinedText03">userDefinedText03.</param>
        /// <param name="userDefinedText04">userDefinedText04.</param>
        /// <param name="userDefinedText05">userDefinedText05.</param>
        /// <param name="revisionNumber">revisionNumber.</param>
        public EshopItem(string iD = default(string), string name = default(string), string code = default(string), string scanCode = default(string), int? domain = default(int?), double? normalVATPercent = default(double?), double? reducedVATPercent = default(double?), string measurementUnit = default(string), string measurementUnitShortcut = default(string), string category = default(string), string retailCategory = default(string), string retailCategoryInnerCode = default(string), double? wholesalePrice = default(double?), double? retailPrice = default(double?), string remarks = default(string), string userDefinedText01 = default(string), string userDefinedText02 = default(string), string userDefinedText03 = default(string), string userDefinedText04 = default(string), string userDefinedText05 = default(string), long? revisionNumber = default(long?))
        {
            this.ID = iD;
            this.Name = name;
            this.Code = code;
            this.ScanCode = scanCode;
            this.Domain = domain;
            this.NormalVATPercent = normalVATPercent;
            this.ReducedVATPercent = reducedVATPercent;
            this.MeasurementUnit = measurementUnit;
            this.MeasurementUnitShortcut = measurementUnitShortcut;
            this.Category = category;
            this.RetailCategory = retailCategory;
            this.RetailCategoryInnerCode = retailCategoryInnerCode;
            this.WholesalePrice = wholesalePrice;
            this.RetailPrice = retailPrice;
            this.Remarks = remarks;
            this.UserDefinedText01 = userDefinedText01;
            this.UserDefinedText02 = userDefinedText02;
            this.UserDefinedText03 = userDefinedText03;
            this.UserDefinedText04 = userDefinedText04;
            this.UserDefinedText05 = userDefinedText05;
            this.RevisionNumber = revisionNumber;
        }
        
        /// <summary>
        /// Gets or Sets ID
        /// </summary>
        [DataMember(Name="ID", EmitDefaultValue=false)]
        public string ID { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name="Code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets ScanCode
        /// </summary>
        [DataMember(Name="ScanCode", EmitDefaultValue=false)]
        public string ScanCode { get; set; }

        /// <summary>
        /// Gets or Sets Domain
        /// </summary>
        [DataMember(Name="Domain", EmitDefaultValue=false)]
        public int? Domain { get; set; }

        /// <summary>
        /// Gets or Sets NormalVATPercent
        /// </summary>
        [DataMember(Name="NormalVATPercent", EmitDefaultValue=false)]
        public double? NormalVATPercent { get; set; }

        /// <summary>
        /// Gets or Sets ReducedVATPercent
        /// </summary>
        [DataMember(Name="ReducedVATPercent", EmitDefaultValue=false)]
        public double? ReducedVATPercent { get; set; }

        /// <summary>
        /// Gets or Sets MeasurementUnit
        /// </summary>
        [DataMember(Name="MeasurementUnit", EmitDefaultValue=false)]
        public string MeasurementUnit { get; set; }

        /// <summary>
        /// Gets or Sets MeasurementUnitShortcut
        /// </summary>
        [DataMember(Name="MeasurementUnitShortcut", EmitDefaultValue=false)]
        public string MeasurementUnitShortcut { get; set; }

        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name="Category", EmitDefaultValue=false)]
        public string Category { get; set; }

        /// <summary>
        /// Gets or Sets RetailCategory
        /// </summary>
        [DataMember(Name="RetailCategory", EmitDefaultValue=false)]
        public string RetailCategory { get; set; }

        /// <summary>
        /// Gets or Sets RetailCategoryInnerCode
        /// </summary>
        [DataMember(Name="RetailCategoryInnerCode", EmitDefaultValue=false)]
        public string RetailCategoryInnerCode { get; set; }

        /// <summary>
        /// Gets or Sets WholesalePrice
        /// </summary>
        [DataMember(Name="WholesalePrice", EmitDefaultValue=false)]
        public double? WholesalePrice { get; set; }

        /// <summary>
        /// Gets or Sets RetailPrice
        /// </summary>
        [DataMember(Name="RetailPrice", EmitDefaultValue=false)]
        public double? RetailPrice { get; set; }

        /// <summary>
        /// Gets or Sets Remarks
        /// </summary>
        [DataMember(Name="Remarks", EmitDefaultValue=false)]
        public string Remarks { get; set; }

        /// <summary>
        /// Gets or Sets UserDefinedText01
        /// </summary>
        [DataMember(Name="UserDefinedText01", EmitDefaultValue=false)]
        public string UserDefinedText01 { get; set; }

        /// <summary>
        /// Gets or Sets UserDefinedText02
        /// </summary>
        [DataMember(Name="UserDefinedText02", EmitDefaultValue=false)]
        public string UserDefinedText02 { get; set; }

        /// <summary>
        /// Gets or Sets UserDefinedText03
        /// </summary>
        [DataMember(Name="UserDefinedText03", EmitDefaultValue=false)]
        public string UserDefinedText03 { get; set; }

        /// <summary>
        /// Gets or Sets UserDefinedText04
        /// </summary>
        [DataMember(Name="UserDefinedText04", EmitDefaultValue=false)]
        public string UserDefinedText04 { get; set; }

        /// <summary>
        /// Gets or Sets UserDefinedText05
        /// </summary>
        [DataMember(Name="UserDefinedText05", EmitDefaultValue=false)]
        public string UserDefinedText05 { get; set; }

        /// <summary>
        /// Gets or Sets RevisionNumber
        /// </summary>
        [DataMember(Name="RevisionNumber", EmitDefaultValue=false)]
        public long? RevisionNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EshopItem {\n");
            sb.Append("  ID: ").Append(ID).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  ScanCode: ").Append(ScanCode).Append("\n");
            sb.Append("  Domain: ").Append(Domain).Append("\n");
            sb.Append("  NormalVATPercent: ").Append(NormalVATPercent).Append("\n");
            sb.Append("  ReducedVATPercent: ").Append(ReducedVATPercent).Append("\n");
            sb.Append("  MeasurementUnit: ").Append(MeasurementUnit).Append("\n");
            sb.Append("  MeasurementUnitShortcut: ").Append(MeasurementUnitShortcut).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  RetailCategory: ").Append(RetailCategory).Append("\n");
            sb.Append("  RetailCategoryInnerCode: ").Append(RetailCategoryInnerCode).Append("\n");
            sb.Append("  WholesalePrice: ").Append(WholesalePrice).Append("\n");
            sb.Append("  RetailPrice: ").Append(RetailPrice).Append("\n");
            sb.Append("  Remarks: ").Append(Remarks).Append("\n");
            sb.Append("  UserDefinedText01: ").Append(UserDefinedText01).Append("\n");
            sb.Append("  UserDefinedText02: ").Append(UserDefinedText02).Append("\n");
            sb.Append("  UserDefinedText03: ").Append(UserDefinedText03).Append("\n");
            sb.Append("  UserDefinedText04: ").Append(UserDefinedText04).Append("\n");
            sb.Append("  UserDefinedText05: ").Append(UserDefinedText05).Append("\n");
            sb.Append("  RevisionNumber: ").Append(RevisionNumber).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as EshopItem);
        }

        /// <summary>
        /// Returns true if EshopItem instances are equal
        /// </summary>
        /// <param name="input">Instance of EshopItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EshopItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ID == input.ID ||
                    (this.ID != null &&
                    this.ID.Equals(input.ID))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.ScanCode == input.ScanCode ||
                    (this.ScanCode != null &&
                    this.ScanCode.Equals(input.ScanCode))
                ) && 
                (
                    this.Domain == input.Domain ||
                    (this.Domain != null &&
                    this.Domain.Equals(input.Domain))
                ) && 
                (
                    this.NormalVATPercent == input.NormalVATPercent ||
                    (this.NormalVATPercent != null &&
                    this.NormalVATPercent.Equals(input.NormalVATPercent))
                ) && 
                (
                    this.ReducedVATPercent == input.ReducedVATPercent ||
                    (this.ReducedVATPercent != null &&
                    this.ReducedVATPercent.Equals(input.ReducedVATPercent))
                ) && 
                (
                    this.MeasurementUnit == input.MeasurementUnit ||
                    (this.MeasurementUnit != null &&
                    this.MeasurementUnit.Equals(input.MeasurementUnit))
                ) && 
                (
                    this.MeasurementUnitShortcut == input.MeasurementUnitShortcut ||
                    (this.MeasurementUnitShortcut != null &&
                    this.MeasurementUnitShortcut.Equals(input.MeasurementUnitShortcut))
                ) && 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.RetailCategory == input.RetailCategory ||
                    (this.RetailCategory != null &&
                    this.RetailCategory.Equals(input.RetailCategory))
                ) && 
                (
                    this.RetailCategoryInnerCode == input.RetailCategoryInnerCode ||
                    (this.RetailCategoryInnerCode != null &&
                    this.RetailCategoryInnerCode.Equals(input.RetailCategoryInnerCode))
                ) && 
                (
                    this.WholesalePrice == input.WholesalePrice ||
                    (this.WholesalePrice != null &&
                    this.WholesalePrice.Equals(input.WholesalePrice))
                ) && 
                (
                    this.RetailPrice == input.RetailPrice ||
                    (this.RetailPrice != null &&
                    this.RetailPrice.Equals(input.RetailPrice))
                ) && 
                (
                    this.Remarks == input.Remarks ||
                    (this.Remarks != null &&
                    this.Remarks.Equals(input.Remarks))
                ) && 
                (
                    this.UserDefinedText01 == input.UserDefinedText01 ||
                    (this.UserDefinedText01 != null &&
                    this.UserDefinedText01.Equals(input.UserDefinedText01))
                ) && 
                (
                    this.UserDefinedText02 == input.UserDefinedText02 ||
                    (this.UserDefinedText02 != null &&
                    this.UserDefinedText02.Equals(input.UserDefinedText02))
                ) && 
                (
                    this.UserDefinedText03 == input.UserDefinedText03 ||
                    (this.UserDefinedText03 != null &&
                    this.UserDefinedText03.Equals(input.UserDefinedText03))
                ) && 
                (
                    this.UserDefinedText04 == input.UserDefinedText04 ||
                    (this.UserDefinedText04 != null &&
                    this.UserDefinedText04.Equals(input.UserDefinedText04))
                ) && 
                (
                    this.UserDefinedText05 == input.UserDefinedText05 ||
                    (this.UserDefinedText05 != null &&
                    this.UserDefinedText05.Equals(input.UserDefinedText05))
                ) && 
                (
                    this.RevisionNumber == input.RevisionNumber ||
                    (this.RevisionNumber != null &&
                    this.RevisionNumber.Equals(input.RevisionNumber))
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
                int hashCode = 41;
                if (this.ID != null)
                    hashCode = hashCode * 59 + this.ID.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.ScanCode != null)
                    hashCode = hashCode * 59 + this.ScanCode.GetHashCode();
                if (this.Domain != null)
                    hashCode = hashCode * 59 + this.Domain.GetHashCode();
                if (this.NormalVATPercent != null)
                    hashCode = hashCode * 59 + this.NormalVATPercent.GetHashCode();
                if (this.ReducedVATPercent != null)
                    hashCode = hashCode * 59 + this.ReducedVATPercent.GetHashCode();
                if (this.MeasurementUnit != null)
                    hashCode = hashCode * 59 + this.MeasurementUnit.GetHashCode();
                if (this.MeasurementUnitShortcut != null)
                    hashCode = hashCode * 59 + this.MeasurementUnitShortcut.GetHashCode();
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.RetailCategory != null)
                    hashCode = hashCode * 59 + this.RetailCategory.GetHashCode();
                if (this.RetailCategoryInnerCode != null)
                    hashCode = hashCode * 59 + this.RetailCategoryInnerCode.GetHashCode();
                if (this.WholesalePrice != null)
                    hashCode = hashCode * 59 + this.WholesalePrice.GetHashCode();
                if (this.RetailPrice != null)
                    hashCode = hashCode * 59 + this.RetailPrice.GetHashCode();
                if (this.Remarks != null)
                    hashCode = hashCode * 59 + this.Remarks.GetHashCode();
                if (this.UserDefinedText01 != null)
                    hashCode = hashCode * 59 + this.UserDefinedText01.GetHashCode();
                if (this.UserDefinedText02 != null)
                    hashCode = hashCode * 59 + this.UserDefinedText02.GetHashCode();
                if (this.UserDefinedText03 != null)
                    hashCode = hashCode * 59 + this.UserDefinedText03.GetHashCode();
                if (this.UserDefinedText04 != null)
                    hashCode = hashCode * 59 + this.UserDefinedText04.GetHashCode();
                if (this.UserDefinedText05 != null)
                    hashCode = hashCode * 59 + this.UserDefinedText05.GetHashCode();
                if (this.RevisionNumber != null)
                    hashCode = hashCode * 59 + this.RevisionNumber.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}