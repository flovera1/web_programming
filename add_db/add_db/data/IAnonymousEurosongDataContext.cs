using add_db.model;

namespace add_db.Data{

public interface IAnonymousEurosongDataContext
{         
  void AddSong(Song song);
  IEnumerable<Song> GetSongs();
  Song GetSongById(int id);
  

}
}
