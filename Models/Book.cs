using System.ComponentModel.DataAnnotations;

namespace Book_manager.Models
{
    public class Book : IValidatableObject
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Author { get; set; }
        public required string Genre { get; set; }
        public required int Pages { get; set; }
        public DateOnly PublicationDate { get; set; }
        public required string Summary { get; set; }

        [Display(Name = "Cover URL")]
        public required string CoverImageUrl { get; set; }
        public int? Rating { get; set; }
        public int? Progress { get; set; }
        public DateTime? StartedDate { get; set; }
        public DateTime? FinishedDate { get; set; }

        [Display(Name = "Review")]
        public string? RatingDescription { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Rating.HasValue && (Rating < 1 || Rating > 5))
            {
                yield return new ValidationResult("Rating must be between 1 and 5.", new[] { nameof(Rating) });
            }
            if (Progress < 0)
            {
                yield return new ValidationResult("Progress cannot be negative.", new[] { nameof(Progress) });
            }
            if (Progress > Pages)
            {
                yield return new ValidationResult("Progress cannot exceed total pages.", new[] { nameof(Progress), nameof(Pages) });
            }
            if (StartedDate.HasValue && FinishedDate.HasValue && StartedDate > FinishedDate)
            {
                yield return new ValidationResult("Started Date cannot be later than Finished Date.", new[] { nameof(StartedDate), nameof(FinishedDate) });
            }
        }
    }
}
