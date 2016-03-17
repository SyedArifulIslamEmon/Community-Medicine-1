using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CommunityMedicine.Model
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        public string Name { get; set; }
        public string Degree { get; set; }
        public string Specialization { get; set; }

        public Doctor(string name, string degree, string specialization):this()
        {
            Name = name;
            Degree = degree;
            Specialization = specialization;
        }

        public Doctor()
        {
            
        }
    }   
}