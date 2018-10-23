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

        public bool IsAllocated { get; set; }
        public List<Preference> GroupPreferences { get; set; }
    }

    public class Preference
    {
        public int PreferenceId { get; set; }
        public string PreferenceDate { get; set; }
        public string GroupName { get; set; }
        public int PreferenceNo { get; set; }
    }
}
