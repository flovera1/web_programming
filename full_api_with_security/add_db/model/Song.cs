namespace add_db.model
{
public class Song
{
  public int ID { get; private set; }
  public required string Title { get; set; }
  public required string Artist { get; set; }
  public required string Spotify { get; set; }
  public int Artist_ID { get; internal set; }
}
}

