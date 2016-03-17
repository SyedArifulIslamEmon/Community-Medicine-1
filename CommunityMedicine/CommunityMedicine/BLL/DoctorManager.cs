using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CommunityMedicine.DAL;
using CommunityMedicine.Model;

namespace CommunityMedicine.BLL
{
    public class DoctorManager
    {
        DoctorGateway doctorGateway=new DoctorGateway();
        public string SaveDoctor(Doctor doctor)
        {
            Doctor aDoctor = doctorGateway.IsExist(doctor);
            if (aDoctor==null)
            {
                int rowAffected = doctorGateway.SaveDoctor(doctor);
                if (rowAffected>0)
                {
                    return "Save Successfully";
                }
                else
                {
                    return "Save Failed";
                }
            }
            else
            {
                return "please input a doctor name";
            }
        }
    }
}