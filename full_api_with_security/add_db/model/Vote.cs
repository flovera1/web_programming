namespace add_db.model{
    public class Vote
    {
        public int ID { get; set; }
        public required string IP { get; set; }
        public int Song_ID { get; set; }
        public int Points { get; set; }
    }
}
