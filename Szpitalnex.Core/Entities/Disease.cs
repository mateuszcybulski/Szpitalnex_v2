﻿using System.ComponentModel.DataAnnotations;
using Szpitalnex.Database.Entities.Base;

namespace Szpitalnex.Database.Entities
{
    public class Disease : BaseEntity
    {
        public string Chapter { get; set; }
        public string Chapter_Desc { get; set; }
        public string Code { get; set; }
        public string Group_Desc { get; set; }
        public string Group_Code { get; set; }
        public string Subgroup { get; set; }
        public string Subgroup_Code { get; set; }
        public string Subgroup2 { get; set; }
        public string Subgroup2_Code { get; set; }
        public string ICD_3_Code { get; set; }
        public string ICD_3_Code_Desc { get; set; }
        public string ICD_10_Code { get; set; }
        public string ICD_10_Code_Desc { get; set; }
    }
}
