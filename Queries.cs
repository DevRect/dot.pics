namespace dotpics
{
    public class Queries
    {
        public Image GetImage(int id) =>
            new Image
            {
                URL = "example.com/images/example.jpg",
                ThumbnailUrl = "example.com/thumnails/example.jpg",
                Title = "Example Image Title",
                Description = "Example image description...",
                Tags = ["Tag 1", "Tag 2"]
            };
        
        public Album GetAlbum(int id) =>
            new Album
            {
                Title = "Example Album Title",
                Description = "Exanple album description...",
                Images = [GetImage(0), GetImage(1), GetImage(2)]
            };
        
        public Image[] SearchImagesByTag() =>
            [GetImage(0), GetImage(1)];
    }
}