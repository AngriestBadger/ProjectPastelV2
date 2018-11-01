using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectPastelV2.Models
{
    public class SponsoredProject
    {
        // Required
        public int SponsoredProjectId { get; set; }

        // Sponsor enters the following details
        [Display(Name = "Project Date")]
        public string ProjectDate { get; set; }
        [Required(ErrorMessage = "Enter sponsor name.")]
        [Display(Name = "Sponsor Name")]
        public string SponsorName { get; set; }
        [Required(ErrorMessage = "Enter project title.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Enter project description.")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Enter contact information.")]
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

        // For manual allocation of projects
        public bool IsAllocated { get; set; }
    }

    public class Preference
    {
        // Required
        public int PreferenceId { get; set; }

        // Group details
        [Display(Name = "Preference Date")]
        public string PreferenceDate { get; set; }
        [Required(ErrorMessage = "Please enter Team name.")]
        [Display(Name = "Group Name")]
        public string GroupName { get; set; }
        public int GroupSize { get; set; }      // = GroupMembers.Count(); 
        [Display(Name = "Group Members - Separate each ID by a comma (,)")]
        public List<string> GroupMembers { get; set; }

        // Retrieve list of projects from database
        public List<SponsoredProject> ProjectList { get; set; }

        // Selecting preferences
        [Required(ErrorMessage = "Please select a project.")]
        [Display(Name = "Option 1")]
        public string Preference1 { get; set; }
        [Required(ErrorMessage = "Please select a project.")]
        [Display(Name = "Option 2")]
        public string Preference2 { get; set; }
        [Required(ErrorMessage = "Please select a project.")]
        [Display(Name = "Option 3")]
        public string Preference3 { get; set; }
    }
}
