public interface IAnonymousEurosongDataContext
{         
  void AddSong(Song song);
  IEnumerable<Song> GetSongs();
}