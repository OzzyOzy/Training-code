namespace RRModels
{
    public class Review
    {
        public int Id { get; set; }
        public int Rating { get; set; }
        public int RestId { get; set; }
        public Restaurant Restaurant { get; set; }
    }
}