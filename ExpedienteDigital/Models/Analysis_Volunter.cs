using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExpedienteDigital.Models
{
    public class Analysis_Volunter
    {

        public int AnalysisID { get; set; }
        public string PhysicalDiseases { get; set; }
        public string Psychological { get; set; }
        public string FamilyHistory { get; set; }
        public string PersonalHistory { get; set; }
        public string MentalExam { get; set; }
        public string MotiveAffiliation { get; set; }
        public string PsychologicalTest { get; set; }
        public string Commissions { get; set; }
        public string Observations { get; set; }

    }
}