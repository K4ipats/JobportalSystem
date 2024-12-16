using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Try_.Controllers
{
    public class JobControllers : Controller
    {
        private readonly YourDbContext _context;

        public JobControllers(YourDbContext context)
        {
            _context = context;
        }

        // View Applicants for a Specific Job
        public ActionResult ViewApplicants(int jobId)
        {
            var applicants = _context.Applications
                .Where(a => a.JobId == jobId)
                .Select(a => new
                {
                    a.Applicant.Name,
                    a.Applicant.Email,
                    a.Applicant.PhoneNumber,
                    a.AppliedDate
                }).ToList();

            if (applicants == null || !applicants.Any())
            {
                return HttpNotFound();
            }

            return View(applicants);
        }
    }
}