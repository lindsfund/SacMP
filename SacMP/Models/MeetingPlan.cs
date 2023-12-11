using System.ComponentModel.DataAnnotations;

namespace SacMP.Models
{
    public class MeetingPlan
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Meeting Date")]
        [DataType(DataType.DateTime)]
        public DateTime MeetingDate { get; set; }

        [StringLength(50)]
        [Display(Name = "Conducting")]
        public string? ConductingLeader { get; set; }

        [StringLength(50)]
        [Display(Name = "Presiding")]
        public string? PresidingLeader { get; set; }

        
        [Display(Name = "Opening Hymn)")]
        public string? OpeningHymn { get; set; }

        [StringLength(50)]
        [Display(Name = "Opening Prayer")]
        public string? OpeningPrayer { get; set; }

        
        [Display(Name = "Sacrament Hymn")]
        public string? SacramentHymn { get; set; }

        [StringLength(100)]
        [Display(Name = "Speaker w/ Topic")]
        public string? speakerOne { get; set; }

        [Display(Name = "Speaker w/ Topic")]
        [StringLength(100)]
        public string? speakerTwo { get; set; }

        
        [Display(Name = "Musical Number (optional)")]
        public string? MusicalNumber { get; set; }

        [Display(Name = "Speaker w/ Topic")]
        [StringLength(100)]
        public string? speakerThree { get; set; }

        [Display(Name = "Speaker w/ Topic")]
        [StringLength(100)]
        public string? speakerFour { get; set; }

        
        [Display(Name = "Closing Hymn")]
        public string? ClosingHymn { get; set; }

        [StringLength(50)]
        [Display(Name = "Closing Prayer")]
        public string? ClosingPrayer { get; set; }
    }
}
