﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace EF_ReverseEngineer_and_CodeFirst
{
    public partial class InspectionTypes
    {
        public InspectionTypes()
        {
            Inspections = new HashSet<Inspections>();
        }

        public int Id { get; set; }
        public string InspectionName { get; set; }

        public virtual ICollection<Inspections> Inspections { get; set; }
    }
}