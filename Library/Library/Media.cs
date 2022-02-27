using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Media : LibraryItem
    {
        private List<Track> tracks;
        private string mediaType; //ebook, CDs, DVD or Blue-ray

        public Media(int isbn, string title, List<Track> tracks, string mediaType)
        {
            this.isbn = isbn;
            this.title = title;
            this.tracks = tracks;
            this.mediaType = mediaType;
        }
    }
}
