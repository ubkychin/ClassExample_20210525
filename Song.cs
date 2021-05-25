using System.Collections.Generic;

namespace ClassExample_20210525
{
    public class Song : Media
    {
        public uint RunTime;

        public Song(string title, string creator, List<string> coCreators, uint runTime) : base(title, creator, coCreators) {
            this.RunTime = runTime;
        }

        public Song(string title, string creator, uint runTime) : base(title, creator) {
            this.RunTime = runTime;
        }  

    }
}