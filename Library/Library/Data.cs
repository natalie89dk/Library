using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public static class Data
    {
        public static List<LibraryItem> testData = new List<LibraryItem>();

        public static void GenerateTestData()
        {
            List<String> authors = new List<string>();
            authors.Add("J.K.Rowling");
            Book HarryPotter1Hardback = new Book("Harry Potter 1", 111111, authors, 323, "Gyldendal", 2001);
            Media HPeBoook = new Media(222222, "Harry Potter 1", GetfictiveTracks(32), "ebook");
            Media HitsForKids2020 = new Media(333333, "Hits For Kids 2020", GetfictiveTracks(11), "CD");
            Media JurassicParkdvd = new Media(333333, "Jurrasic Park", GetfictiveTracks(3), "DVD");
            Media JurassicParkBluRay = new Media(444444, "Jurrasic Park", GetfictiveTracks(3), "DBlue-rayVD");
            testData.Add(HarryPotter1Hardback);
            testData.Add(HPeBoook);
            testData.Add(HitsForKids2020);
            testData.Add(JurassicParkdvd);
            testData.Add(JurassicParkBluRay);
        }

        public static List<LibraryItem> GetTestData() 
        {
            return testData;
        }

        private static List<Track> GetfictiveTracks(int nuberOfTracks)
        {
            List<Track> tracks = new List<Track>();
            for (int i = 0; i < 10; i++)
            {
                Object audioOrvideo = new Object();
                String TrackTitle = RandomString(nuberOfTracks);
                List<string> Authors = new List<string>() { "author1", "author2" };
                Track track = new Track(audioOrvideo, TrackTitle, Authors, 142);
            }
            return tracks;
        }

        //Reference:https://stackoverflow.com/questions/1344221/how-can-i-generate-random-alphanumeric-strings
        public static string RandomString(int length)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
