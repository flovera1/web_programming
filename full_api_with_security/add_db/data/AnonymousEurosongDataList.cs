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

        public void AddArtist(Artist artist)
        {
            throw new NotImplementedException();
        }

        public  IEnumerable<Artist> GetArtist()
        {
            throw new NotImplementedException();
        }
        public Artist GetArtistById(int id)
        {
            throw new NotImplementedException();
        }
        public List<Song> getSongsByArtistID(int Artistid)
        {
            throw new NotImplementedException();
        }

        public void AddVote(Vote vote)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<Vote> GetVote()
        {
            throw new NotImplementedException();
        }
        public Vote GetVoteBySongId(int songid)
        {
            throw new NotImplementedException();
        }

        public List<Vote> getVoteBySongID(int songid)
        {
            throw new NotImplementedException();
        }
    }
}