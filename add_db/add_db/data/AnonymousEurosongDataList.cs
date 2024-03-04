using add_db.Data;
using add_db.model;

namespace add_db.data
{
     public class AnonymousEurosongDataList : IAnonymousEurosongDataContext
 {
   List<Song> songs = new List<Song>();
 
   public void AddSong(Song song)
   {
     songs.Add(song);
   }

   public IEnumerable<Song> GetSongs()
   {
     return songs;
   }

   public Song? GetSongById(int i)
   {
        return null;
   }
}
}