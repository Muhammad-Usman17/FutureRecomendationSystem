//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FutureRecomendationSystem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UniversityDegree
    {
        public int id { get; set; }
        public int degree { get; set; }
        public decimal percentage { get; set; }
        public int preDegree { get; set; }
        public int age { get; set; }
        public int uniId { get; set; }
    
        public virtual Degree Degree1 { get; set; }
        public virtual PreDegree PreDegree1 { get; set; }
        public virtual University University { get; set; }
        public virtual UniversityDegreeFee UniversityDegreeFee { get; set; }
    }
}
