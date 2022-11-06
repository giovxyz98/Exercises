using System;

namespace Musica
{
    public abstract class StreamingPlatform : IPlayer
    {

        public Song[] song;
        Song playing;
        public virtual void Play(int songIndex)
        {

            if (songIndex >= 0 && songIndex <= song.Length - 1)
            {
                playing = song[songIndex];
                playing.position = songIndex + 1;
            }
            else
            {
                playing = song[0];
                playing.position = 1;
            }
            showPlaying();

        }
        public void play()
        {
            if (playing is null)
            { playing = song[0];
                playing.position = 0;
            }
            showPlaying();
        }
        public void showPlaying()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Playing now : - Postion: {playing.position} - {playing._title.ToUpper()}");
            Console.ResetColor();
        }
        public void stop()
        {
            playing.state = 0;
        }
        public void pause()

        {
            playing.state = 2;

        }
 
        public void forward()
        {
            int next = Array.FindIndex(song, i => i._title == playing._title);
            Play(next + 1);
        }
        public void backward()
        {
            int next = Array.FindIndex(song, i => i._title == playing._title);
            Play(next - 1);
        }
        public virtual void ListSongs()
            
        {
            Console.WriteLine("La lista dei brani che puoi ascoltare sono:\n");
            for (int i = 0; i < song.Length; i++)
            {
                Console.WriteLine($"{i + 1} -   {song[i]._title} ");
            }

        }

    }
    }


      
