/*
 * home-iot-api
 *
 * The API for the EatBacon IOT project
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

namespace Calc.Test.Models
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class MathCalcBody : IEquatable<MathCalcBody>
    {

        public MathCalcBody()
        {

        }

        public MathCalcBody(int num1,int num2)
        {
            Num1 = num1;
            Num2 = num2;
        }
        /// <summary>
        /// Gets or Sets Num1
        /// </summary>

        [DataMember(Name="num1")]
        public decimal? Num1 { get; set; }

        /// <summary>
        /// Gets or Sets Num2
        /// </summary>

        [DataMember(Name="num2")]
        public decimal? Num2 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MathCalcBody {\n");
            sb.Append("  Num1: ").Append(Num1).Append("\n");
            sb.Append("  Num2: ").Append(Num2).Append("\n");
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
            return obj.GetType() == GetType() && Equals((MathCalcBody)obj);
        }

        /// <summary>
        /// Returns true if MathCalcBody instances are equal
        /// </summary>
        /// <param name="other">Instance of MathCalcBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MathCalcBody other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Num1 == other.Num1 ||
                    Num1 != null &&
                    Num1.Equals(other.Num1)
                ) && 
                (
                    Num2 == other.Num2 ||
                    Num2 != null &&
                    Num2.Equals(other.Num2)
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
                    if (Num1 != null)
                    hashCode = hashCode * 59 + Num1.GetHashCode();
                    if (Num2 != null)
                    hashCode = hashCode * 59 + Num2.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(MathCalcBody left, MathCalcBody right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(MathCalcBody left, MathCalcBody right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}