using add_db.model;

namespace add_db.Data{

public interface IAnonymousEurosongDataContext
{         
  void AddSong(Song song);
  IEnumerable<Song> GetSongs();
  Song GetSongById(int id);

  /*
  
  this is new code
  
  */
  List<Vote> getVoteBySongID(int songid);

  
  //v
  void AddVote(Vote vote);
  IEnumerable<Vote> GetVote();
  Vote GetVoteBySongId(int songid);

  //a
  void AddArtist(Artist artist);
  IEnumerable<Artist> GetArtist();
  Artist GetArtistById(int id);

  //get songs by artist id
  List<Song> getSongsByArtistID(int Artistid);

}
}
