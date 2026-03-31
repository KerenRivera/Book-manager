namespace Book_manager.Models
{
    public class Book
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Author { get; set; }
        public required string Genre { get; set; }
        public required int Pages { get; set; }
        public DateOnly PublicationDate { get; set; }
        public required string Summary { get; set; }
        public required string CoverImageUrl { get; set; }
        public int? Rating { get; set; }
        public int? Progress { get; set; }
        public DateTime? StartedDate { get; set; }
        public DateTime? FinishedDate { get; set; }
        public string? RatingDescription { get; set; }

    }
}
