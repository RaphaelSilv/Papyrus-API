using System;

namespace Papyrus_API
{
    public class BookNote
    {
        public int Id { get; set; }
        public int ImageId { get; set; }
        public DateTime LastTimeEdited { get; set; }
        public string Content { get; set; }
        public string Title { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }

    }
}
