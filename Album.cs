using System.Collections.Generic;

namespace ClassExample_20210525
{
    public class Album : Media
    {
        public List<Song> Tracks;

        public Album(string title, string creator, List<string> coCreators, List<Song> tracks) : base(title, creator, coCreators) {
            this.Tracks = tracks;
        }

        public Album(string title, string creator, List<Song> tracks) : base(title, creator) {
            this.Tracks = tracks;
        }

        public uint GetAlbumRunTime() {
            uint total = 0;

            foreach(Song song in this.Tracks) {
                total += song.RunTime;
            }

            return total;
        }
    }
}