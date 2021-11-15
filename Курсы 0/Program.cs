using System;

namespace Курсы_0
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    class VideoFiles:File,IAddition
    {
        public VideoFiles(string extensionVideo) : base(extensionVideo) { }
        public void result() => Console.WriteLine(Extension);
    }
    class Pictures: File,IAddition
    {
        public Pictures(string extensionPicture) : base(extensionPicture) { }
        public void result() => Console.WriteLine(Extension);
    }
    class Song : File, IAddition
{
        public Song(string extensionSong) : base(extensionSong) { }
        public void result() => Console.WriteLine(Extension);
    }
}
