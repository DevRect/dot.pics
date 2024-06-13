namespace dotpics
{
    public class Image
    {
        public string? URL { get; set; }
        public string? ThumbnailUrl { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string[]? Tags { get; set; }
    }

    public class Album
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public Image[]? Images { get; set; }

    }
}