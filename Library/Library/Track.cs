using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Track
    {
        //If i had more time I would make it work with this name space https://docs.microsoft.com/en-us/dotnet/api/audiotoolbox?view=xamarin-ios-sdk-12
        public Object audioOrVideo;
        public string trackTitle;
        public List<String> trackAuthors;
        public int durationInSeconds;

        public Track(Object audioOrVideo, string trackTitle, List<String> trackAuthors, int durationInSeconds)
        {
            this.audioOrVideo = audioOrVideo;
            this.trackTitle = trackTitle;
            this.trackAuthors = trackAuthors;
            this.durationInSeconds = durationInSeconds;
        }
    }
}
