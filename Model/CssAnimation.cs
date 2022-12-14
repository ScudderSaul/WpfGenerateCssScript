using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace CssSimpleWpfApplication.Model
{
    [Table("CssAnimation")]
    public partial class CssAnimation
    {
        public CssAnimation()
        {
            CssStyleItems = new HashSet<CssStyleItem>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        [Required]
        public string AnimationName { get; set; } = string.Empty;   

        public string AnimationDuration { get; set; } = string.Empty;

        public string AnimationTimingFunction { get; set; } = string.Empty;

        public string AnimationDelay { get; set; } = string.Empty;

        public string AnimationIterationCount { get; set; } = string.Empty;

        public string AnimationDirection { get; set; }=string.Empty;

        public string AnimationPlayState { get; set; }= string.Empty;

        public string AnimationFillMode { get; set; } =string.Empty;

        public virtual ICollection<CssStyleItem> CssStyleItems { get; set; } = new HashSet<CssStyleItem>();
    }
}
