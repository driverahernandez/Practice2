using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    public interface IPlayable
    {
        public void Play();
        public void Pause();

    }
    public class MusicPlayer : IPlayable
    {
        public void Play() => Console.WriteLine("Playing music...");
        public void Pause() => Console.WriteLine("Music has been paused.");
    }
    public class VideoPlayer : IPlayable
    {
        public void Play() => Console.WriteLine("Playing video...");
        public void Pause() => Console.WriteLine("Video has been paused.");
    }
}
