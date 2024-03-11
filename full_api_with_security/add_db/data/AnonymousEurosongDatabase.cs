using add_db.Data;
using add_db.model;
using LiteDB;

public class AnonymousEurosongDatabase : IAnonymousEurosongDataContext
{
    LiteDatabase db = new LiteDatabase(@"data.db");
    private const string _SONGS = "Songs";

  
  public void AddSong(Song song)
  {
    db.GetCollection<Song>("Songs").Insert(song);
  }
 
  public IEnumerable<Song> GetSongs()
  {
    return db.GetCollection<Song>("Songs").FindAll();
  }

  public Song GetSongById(int id)
  {

            return db.GetCollection<Song>(_SONGS).FindById(id);
  }

public void AddArtist(Artist artist)
{
    db.GetCollection<Artist>("Artists").Insert(artist);
}

public  IEnumerable<Artist> GetArtist()
{
    return db.GetCollection<Artist>("Artists").FindAll();
}
public Artist GetArtistById(int id)
{
    return db.GetCollection<Artist>("Artists").FindById(id);
}
public List<Song> getSongsByArtistID(int Artistid)
{
    return db.GetCollection<Song>("Songs").Find(x => x.Artist_ID == Artistid).ToList();
}

public void AddVote(Vote vote)
{
    db.GetCollection<Vote>("Votes").Insert(vote);
}

public IEnumerable<Vote> GetVote()
{
    return db.GetCollection<Vote>("Votes").FindAll();
}
public Vote GetVoteBySongId(int songid)
{
    return db.GetCollection<Vote>("Votes").FindById(songid);
}

public List<Vote> getVoteBySongID(int songid)
{
    throw new NotImplementedException();
    // the implementation should look like this:
    // return db.GetCollection<Vote>("Votes").FindById(songid).GetVotes();

}
}