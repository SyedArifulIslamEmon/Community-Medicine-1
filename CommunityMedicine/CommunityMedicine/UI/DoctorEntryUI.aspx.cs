using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CommunityMedicine.BLL;
using CommunityMedicine.Model;

namespace CommunityMedicine.UI
{
    public partial class DoctorEntryUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveDoctorButton_Click(object sender, EventArgs e)
        {
            string name = doctorNameTextBox.Text;
            string degree = degreeTextBox.Text;
            string specialization = specializationTextBox.Text;

            Doctor doctor = new Doctor(name, degree, specialization);
            DoctorManager doctorManager=new DoctorManager();
            messageLabel.Text = doctorManager.SaveDoctor(doctor);

        }
    }
}