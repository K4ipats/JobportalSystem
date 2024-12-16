using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Try_.Models
{
    public class ViewJob
    {
        public int JobId { get; set; }
        public string JobTitle { get; set; }
        public ICollection<Application> Applications { get; set; } // Navigation Property
    }

    public class Applicant
    {
        public int ApplicantId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }

    public class Application
    {
        public int ApplicationId { get; set; }
        public int JobId { get; set; }
        public Job Job { get; set; } // Navigation Property
        public int ApplicantId { get; set; }
        public Applicant Applicant { get; set; } // Navigation Property
        public DateTime AppliedDate { get; set; }
    }
}