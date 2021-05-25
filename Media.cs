using System.Collections.Generic;

namespace ClassExample_20210525
{
    public class Media
    {
        public string Title;
        public string Creator;
        public List<string> CoCreators;

        public Media(string title, string creator) {
            this.Title = title;
            this.Creator = creator;
            this.CoCreators = new List<string>();
        }

        public Media(string title, string creator, List<string> coCreators) {
            this.Title = title;
            this.Creator = creator;
            this.CoCreators = coCreators;
        }
    }
}