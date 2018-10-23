using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectPastelV2.Models
{
    public class SponsoredProject
    {
        // SPONSOR ENTERS THESE DETAILS
        public int SponsoredProjectId { get; set; }
        [Display(Name = "Project Date")]
        public string ProjectDate { get; set; }
        [Display(Name = "Sponsor Name")]
        public string SponsorName { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Contacts { get; set; }
        [Display(Name = "In Scope")]
        public string InScope { get; set; }
        [Display(Name = "Out of Scope")]
        public string OutOfScope { get; set; }
        [Display(Name = "Skill Requirements")]
        public string SkillRequirements { get; set; }
        [Display(Name = "Related Projects")]
        public string RelatedProjects { get; set; }
        [Display(Name = "Team Size")]
        public string TeamSize { get; set; }
        public string Duration { get; set; }

        // FOR PROJECT SELECTION
        public bool IsAllocated { get; set; }                   // For easier allocation maybe, if Admin wants to manually allocate
        public List<Preference> GroupPreferences { get; set; }  // List of groups and which preference this project is for that group
    }

    // PREFERENCE CLASS - each project has a list of these, for selection choice
    public class Preference
    {
        public int PreferenceId { get; set; }
        public string GroupName { get; set; }
        public DateTime PreferenceDate { get; set; }
        public int PreferenceNumber { get; set; }
    }
}
