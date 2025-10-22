using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Song
    {
        public string artist;
        public string title;
        public int duration;
        // 'static' allow to create one parameter for class (not for  object)
        // because 'static' is a parameter of class then
        //      you shouldnt add it to constructor of object
        public static int songCount = 0;

        public Song(string aTitle, string aArtist, int aDuration)
        {
            title = aTitle;
            artist = aArtist;
            duration = aDuration;
            // you can use static variable and change in function
            songCount++;
        }
    }
}