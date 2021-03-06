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
    /// EshopSale
    /// </summary>
    [DataContract]
        public partial class EshopSale :  IEquatable<EshopSale>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EshopSale" /> class.
        /// </summary>
        /// <param name="docDateTime">docDateTime.</param>
        /// <param name="isRetail">isRetail.</param>
        /// <param name="vatStatus">vatStatus.</param>
        /// <param name="refDocCode">refDocCode.</param>
        /// <param name="docNum">docNum.</param>
        /// <param name="paymentMethod">paymentMethod.</param>
        /// <param name="paymentCreditCardName">paymentCreditCardName.</param>
        /// <param name="paymentBankAccName">paymentBankAccName.</param>
        /// <param name="custName">custName.</param>
        /// <param name="custTIN">custTIN.</param>
        /// <param name="custStreet">custStreet.</param>
        /// <param name="custStreet">custStreet.</param>
        /// <param name="custCity">custCity.</param>
        /// <param name="custPostalCode">custPostalCode.</param>
        /// <param name="custCountry">custCountry.</param>
        /// <param name="custEmail">custEmail.</param>
        /// <param name="custPhone1">custPhone1.</param>
        /// <param name="extraCharges">extraCharges.</param>
        /// <param name="justification">justification.</param>
        /// <param name="comments">comments.</param>
        /// <param name="userDefText01">userDefText01.</param>
        /// <param name="userDefText02">userDefText02.</param>
        /// <param name="userDefText03">userDefText03.</param>
        /// <param name="userDefText04">userDefText04.</param>
        /// <param name="userDefText05">userDefText05.</param>
        /// <param name="lines">lines.</param>
        public EshopSale(DateTime? docDateTime = default(DateTime?), int? isRetail = default(int?), EshopVatStatus vatStatus = default(EshopVatStatus), string refDocCode = default(string), long? docNum = default(long?), EshopPaymentMethod paymentMethod = default(EshopPaymentMethod), string paymentCreditCardName = default(string), string paymentBankAccName = default(string), string custName = default(string), string custTIN = default(string), string custStreet = default(string), string custStreet = default(string), string custCity = default(string), string custPostalCode = default(string), string custCountry = default(string), string custEmail = default(string), string custPhone1 = default(string), double? extraCharges = default(double?), string justification = default(string), string comments = default(string), string userDefText01 = default(string), string userDefText02 = default(string), string userDefText03 = default(string), string userDefText04 = default(string), string userDefText05 = default(string), List<EshopItemLine> lines = default(List<EshopItemLine>))
        {
            this.DocDateTime = docDateTime;
            this.IsRetail = isRetail;
            this.VatStatus = vatStatus;
            this.RefDocCode = refDocCode;
            this.DocNum = docNum;
            this.PaymentMethod = paymentMethod;
            this.PaymentCreditCardName = paymentCreditCardName;
            this.PaymentBankAccName = paymentBankAccName;
            this.CustName = custName;
            this.CustTIN = custTIN;
            this.CustStreet = custStreet;
            this.CustStreet = custStreet;
            this.CustCity = custCity;
            this.CustPostalCode = custPostalCode;
            this.CustCountry = custCountry;
            this.CustEmail = custEmail;
            this.CustPhone1 = custPhone1;
            this.ExtraCharges = extraCharges;
            this.Justification = justification;
            this.Comments = comments;
            this.UserDefText01 = userDefText01;
            this.UserDefText02 = userDefText02;
            this.UserDefText03 = userDefText03;
            this.UserDefText04 = userDefText04;
            this.UserDefText05 = userDefText05;
            this.Lines = lines;
        }
        
        /// <summary>
        /// Gets or Sets DocDateTime
        /// </summary>
        [DataMember(Name="DocDateTime", EmitDefaultValue=false)]
        public DateTime? DocDateTime { get; set; }

        /// <summary>
        /// Gets or Sets IsRetail
        /// </summary>
        [DataMember(Name="IsRetail", EmitDefaultValue=false)]
        public int? IsRetail { get; set; }

        /// <summary>
        /// Gets or Sets VatStatus
        /// </summary>
        [DataMember(Name="VatStatus", EmitDefaultValue=false)]
        public EshopVatStatus VatStatus { get; set; }

        /// <summary>
        /// Gets or Sets RefDocCode
        /// </summary>
        [DataMember(Name="RefDocCode", EmitDefaultValue=false)]
        public string RefDocCode { get; set; }

        /// <summary>
        /// Gets or Sets DocNum
        /// </summary>
        [DataMember(Name="DocNum", EmitDefaultValue=false)]
        public long? DocNum { get; set; }

        /// <summary>
        /// Gets or Sets PaymentMethod
        /// </summary>
        [DataMember(Name="PaymentMethod", EmitDefaultValue=false)]
        public EshopPaymentMethod PaymentMethod { get; set; }

        /// <summary>
        /// Gets or Sets PaymentCreditCardName
        /// </summary>
        [DataMember(Name="PaymentCreditCardName", EmitDefaultValue=false)]
        public string PaymentCreditCardName { get; set; }

        /// <summary>
        /// Gets or Sets PaymentBankAccName
        /// </summary>
        [DataMember(Name="PaymentBankAccName", EmitDefaultValue=false)]
        public string PaymentBankAccName { get; set; }

        /// <summary>
        /// Gets or Sets CustName
        /// </summary>
        [DataMember(Name="CustName", EmitDefaultValue=false)]
        public string CustName { get; set; }

        /// <summary>
        /// Gets or Sets CustTIN
        /// </summary>
        [DataMember(Name="CustTIN", EmitDefaultValue=false)]
        public string CustTIN { get; set; }

        /// <summary>
        /// Gets or Sets CustStreet
        /// </summary>
        [DataMember(Name="CustStreet", EmitDefaultValue=false)]
        public string CustStreet { get; set; }

        /// <summary>
        /// Gets or Sets CustStreet
        /// </summary>
        [DataMember(Name="CustStreet????", EmitDefaultValue=false)]
        public string CustStreet { get; set; }

        /// <summary>
        /// Gets or Sets CustCity
        /// </summary>
        [DataMember(Name="CustCity", EmitDefaultValue=false)]
        public string CustCity { get; set; }

        /// <summary>
        /// Gets or Sets CustPostalCode
        /// </summary>
        [DataMember(Name="CustPostalCode", EmitDefaultValue=false)]
        public string CustPostalCode { get; set; }

        /// <summary>
        /// Gets or Sets CustCountry
        /// </summary>
        [DataMember(Name="CustCountry", EmitDefaultValue=false)]
        public string CustCountry { get; set; }

        /// <summary>
        /// Gets or Sets CustEmail
        /// </summary>
        [DataMember(Name="CustEmail", EmitDefaultValue=false)]
        public string CustEmail { get; set; }

        /// <summary>
        /// Gets or Sets CustPhone1
        /// </summary>
        [DataMember(Name="CustPhone1", EmitDefaultValue=false)]
        public string CustPhone1 { get; set; }

        /// <summary>
        /// Gets or Sets ExtraCharges
        /// </summary>
        [DataMember(Name="ExtraCharges", EmitDefaultValue=false)]
        public double? ExtraCharges { get; set; }

        /// <summary>
        /// Gets or Sets Justification
        /// </summary>
        [DataMember(Name="Justification", EmitDefaultValue=false)]
        public string Justification { get; set; }

        /// <summary>
        /// Gets or Sets Comments
        /// </summary>
        [DataMember(Name="Comments", EmitDefaultValue=false)]
        public string Comments { get; set; }

        /// <summary>
        /// Gets or Sets UserDefText01
        /// </summary>
        [DataMember(Name="UserDefText01", EmitDefaultValue=false)]
        public string UserDefText01 { get; set; }

        /// <summary>
        /// Gets or Sets UserDefText02
        /// </summary>
        [DataMember(Name="UserDefText02", EmitDefaultValue=false)]
        public string UserDefText02 { get; set; }

        /// <summary>
        /// Gets or Sets UserDefText03
        /// </summary>
        [DataMember(Name="UserDefText03", EmitDefaultValue=false)]
        public string UserDefText03 { get; set; }

        /// <summary>
        /// Gets or Sets UserDefText04
        /// </summary>
        [DataMember(Name="UserDefText04", EmitDefaultValue=false)]
        public string UserDefText04 { get; set; }

        /// <summary>
        /// Gets or Sets UserDefText05
        /// </summary>
        [DataMember(Name="UserDefText05", EmitDefaultValue=false)]
        public string UserDefText05 { get; set; }

        /// <summary>
        /// Gets or Sets Lines
        /// </summary>
        [DataMember(Name="Lines", EmitDefaultValue=false)]
        public List<EshopItemLine> Lines { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EshopSale {\n");
            sb.Append("  DocDateTime: ").Append(DocDateTime).Append("\n");
            sb.Append("  IsRetail: ").Append(IsRetail).Append("\n");
            sb.Append("  VatStatus: ").Append(VatStatus).Append("\n");
            sb.Append("  RefDocCode: ").Append(RefDocCode).Append("\n");
            sb.Append("  DocNum: ").Append(DocNum).Append("\n");
            sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
            sb.Append("  PaymentCreditCardName: ").Append(PaymentCreditCardName).Append("\n");
            sb.Append("  PaymentBankAccName: ").Append(PaymentBankAccName).Append("\n");
            sb.Append("  CustName: ").Append(CustName).Append("\n");
            sb.Append("  CustTIN: ").Append(CustTIN).Append("\n");
            sb.Append("  CustStreet: ").Append(CustStreet).Append("\n");
            sb.Append("  CustStreet: ").Append(CustStreet).Append("\n");
            sb.Append("  CustCity: ").Append(CustCity).Append("\n");
            sb.Append("  CustPostalCode: ").Append(CustPostalCode).Append("\n");
            sb.Append("  CustCountry: ").Append(CustCountry).Append("\n");
            sb.Append("  CustEmail: ").Append(CustEmail).Append("\n");
            sb.Append("  CustPhone1: ").Append(CustPhone1).Append("\n");
            sb.Append("  ExtraCharges: ").Append(ExtraCharges).Append("\n");
            sb.Append("  Justification: ").Append(Justification).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  UserDefText01: ").Append(UserDefText01).Append("\n");
            sb.Append("  UserDefText02: ").Append(UserDefText02).Append("\n");
            sb.Append("  UserDefText03: ").Append(UserDefText03).Append("\n");
            sb.Append("  UserDefText04: ").Append(UserDefText04).Append("\n");
            sb.Append("  UserDefText05: ").Append(UserDefText05).Append("\n");
            sb.Append("  Lines: ").Append(Lines).Append("\n");
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
            return this.Equals(input as EshopSale);
        }

        /// <summary>
        /// Returns true if EshopSale instances are equal
        /// </summary>
        /// <param name="input">Instance of EshopSale to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EshopSale input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DocDateTime == input.DocDateTime ||
                    (this.DocDateTime != null &&
                    this.DocDateTime.Equals(input.DocDateTime))
                ) && 
                (
                    this.IsRetail == input.IsRetail ||
                    (this.IsRetail != null &&
                    this.IsRetail.Equals(input.IsRetail))
                ) && 
                (
                    this.VatStatus == input.VatStatus ||
                    (this.VatStatus != null &&
                    this.VatStatus.Equals(input.VatStatus))
                ) && 
                (
                    this.RefDocCode == input.RefDocCode ||
                    (this.RefDocCode != null &&
                    this.RefDocCode.Equals(input.RefDocCode))
                ) && 
                (
                    this.DocNum == input.DocNum ||
                    (this.DocNum != null &&
                    this.DocNum.Equals(input.DocNum))
                ) && 
                (
                    this.PaymentMethod == input.PaymentMethod ||
                    (this.PaymentMethod != null &&
                    this.PaymentMethod.Equals(input.PaymentMethod))
                ) && 
                (
                    this.PaymentCreditCardName == input.PaymentCreditCardName ||
                    (this.PaymentCreditCardName != null &&
                    this.PaymentCreditCardName.Equals(input.PaymentCreditCardName))
                ) && 
                (
                    this.PaymentBankAccName == input.PaymentBankAccName ||
                    (this.PaymentBankAccName != null &&
                    this.PaymentBankAccName.Equals(input.PaymentBankAccName))
                ) && 
                (
                    this.CustName == input.CustName ||
                    (this.CustName != null &&
                    this.CustName.Equals(input.CustName))
                ) && 
                (
                    this.CustTIN == input.CustTIN ||
                    (this.CustTIN != null &&
                    this.CustTIN.Equals(input.CustTIN))
                ) && 
                (
                    this.CustStreet == input.CustStreet ||
                    (this.CustStreet != null &&
                    this.CustStreet.Equals(input.CustStreet))
                ) && 
                (
                    this.CustStreet == input.CustStreet ||
                    (this.CustStreet != null &&
                    this.CustStreet.Equals(input.CustStreet))
                ) && 
                (
                    this.CustCity == input.CustCity ||
                    (this.CustCity != null &&
                    this.CustCity.Equals(input.CustCity))
                ) && 
                (
                    this.CustPostalCode == input.CustPostalCode ||
                    (this.CustPostalCode != null &&
                    this.CustPostalCode.Equals(input.CustPostalCode))
                ) && 
                (
                    this.CustCountry == input.CustCountry ||
                    (this.CustCountry != null &&
                    this.CustCountry.Equals(input.CustCountry))
                ) && 
                (
                    this.CustEmail == input.CustEmail ||
                    (this.CustEmail != null &&
                    this.CustEmail.Equals(input.CustEmail))
                ) && 
                (
                    this.CustPhone1 == input.CustPhone1 ||
                    (this.CustPhone1 != null &&
                    this.CustPhone1.Equals(input.CustPhone1))
                ) && 
                (
                    this.ExtraCharges == input.ExtraCharges ||
                    (this.ExtraCharges != null &&
                    this.ExtraCharges.Equals(input.ExtraCharges))
                ) && 
                (
                    this.Justification == input.Justification ||
                    (this.Justification != null &&
                    this.Justification.Equals(input.Justification))
                ) && 
                (
                    this.Comments == input.Comments ||
                    (this.Comments != null &&
                    this.Comments.Equals(input.Comments))
                ) && 
                (
                    this.UserDefText01 == input.UserDefText01 ||
                    (this.UserDefText01 != null &&
                    this.UserDefText01.Equals(input.UserDefText01))
                ) && 
                (
                    this.UserDefText02 == input.UserDefText02 ||
                    (this.UserDefText02 != null &&
                    this.UserDefText02.Equals(input.UserDefText02))
                ) && 
                (
                    this.UserDefText03 == input.UserDefText03 ||
                    (this.UserDefText03 != null &&
                    this.UserDefText03.Equals(input.UserDefText03))
                ) && 
                (
                    this.UserDefText04 == input.UserDefText04 ||
                    (this.UserDefText04 != null &&
                    this.UserDefText04.Equals(input.UserDefText04))
                ) && 
                (
                    this.UserDefText05 == input.UserDefText05 ||
                    (this.UserDefText05 != null &&
                    this.UserDefText05.Equals(input.UserDefText05))
                ) && 
                (
                    this.Lines == input.Lines ||
                    this.Lines != null &&
                    input.Lines != null &&
                    this.Lines.SequenceEqual(input.Lines)
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
                if (this.DocDateTime != null)
                    hashCode = hashCode * 59 + this.DocDateTime.GetHashCode();
                if (this.IsRetail != null)
                    hashCode = hashCode * 59 + this.IsRetail.GetHashCode();
                if (this.VatStatus != null)
                    hashCode = hashCode * 59 + this.VatStatus.GetHashCode();
                if (this.RefDocCode != null)
                    hashCode = hashCode * 59 + this.RefDocCode.GetHashCode();
                if (this.DocNum != null)
                    hashCode = hashCode * 59 + this.DocNum.GetHashCode();
                if (this.PaymentMethod != null)
                    hashCode = hashCode * 59 + this.PaymentMethod.GetHashCode();
                if (this.PaymentCreditCardName != null)
                    hashCode = hashCode * 59 + this.PaymentCreditCardName.GetHashCode();
                if (this.PaymentBankAccName != null)
                    hashCode = hashCode * 59 + this.PaymentBankAccName.GetHashCode();
                if (this.CustName != null)
                    hashCode = hashCode * 59 + this.CustName.GetHashCode();
                if (this.CustTIN != null)
                    hashCode = hashCode * 59 + this.CustTIN.GetHashCode();
                if (this.CustStreet != null)
                    hashCode = hashCode * 59 + this.CustStreet.GetHashCode();
                if (this.CustStreet != null)
                    hashCode = hashCode * 59 + this.CustStreet.GetHashCode();
                if (this.CustCity != null)
                    hashCode = hashCode * 59 + this.CustCity.GetHashCode();
                if (this.CustPostalCode != null)
                    hashCode = hashCode * 59 + this.CustPostalCode.GetHashCode();
                if (this.CustCountry != null)
                    hashCode = hashCode * 59 + this.CustCountry.GetHashCode();
                if (this.CustEmail != null)
                    hashCode = hashCode * 59 + this.CustEmail.GetHashCode();
                if (this.CustPhone1 != null)
                    hashCode = hashCode * 59 + this.CustPhone1.GetHashCode();
                if (this.ExtraCharges != null)
                    hashCode = hashCode * 59 + this.ExtraCharges.GetHashCode();
                if (this.Justification != null)
                    hashCode = hashCode * 59 + this.Justification.GetHashCode();
                if (this.Comments != null)
                    hashCode = hashCode * 59 + this.Comments.GetHashCode();
                if (this.UserDefText01 != null)
                    hashCode = hashCode * 59 + this.UserDefText01.GetHashCode();
                if (this.UserDefText02 != null)
                    hashCode = hashCode * 59 + this.UserDefText02.GetHashCode();
                if (this.UserDefText03 != null)
                    hashCode = hashCode * 59 + this.UserDefText03.GetHashCode();
                if (this.UserDefText04 != null)
                    hashCode = hashCode * 59 + this.UserDefText04.GetHashCode();
                if (this.UserDefText05 != null)
                    hashCode = hashCode * 59 + this.UserDefText05.GetHashCode();
                if (this.Lines != null)
                    hashCode = hashCode * 59 + this.Lines.GetHashCode();
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
