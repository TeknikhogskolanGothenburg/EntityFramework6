namespace MovieApp.Domain
{
    public class Quote
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public Actor Actor { get; set; }
        public int ActorId { get; set; }
    }
}
