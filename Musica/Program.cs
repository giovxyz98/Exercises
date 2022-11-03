using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.SymbolStore;
using System.Security.Cryptography.X509Certificates;

namespace Musica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Song song1 = new Song("Mademoiselle", "Sfera Ebbasta");
            StreamingPlatform GiovanniSound = new StreamingPlatform();
            GiovanniSound.addSong(song1);;
            song1.play();
            song1.stop();
            song1.resume();
            song1.pause();
            GiovanniSound.modifyState(song1);

        }
    }
    public class Song : IPlayer

    {
        public string _title { get; set; }
        public string _artist { get; set; }
        double _rate { get; set; }
        public int state { get; set; }
        public Song(string title, string artist)
        {
            _title = title;
            _artist = artist;
            _rate = 1.00;
            state = 0;
        }
        public void play()
        {
            state = 1;
            Console.WriteLine($"La canzone è in riproduzione, stato: {state}");
        }
        public void stop()
        {
            state = 0;
            Console.WriteLine($"La canzone è in stop, stato: {state}");
        }
        public void pause()

        {
            state = 2;

            Console.WriteLine($"La canzone è in pausa, stato: {state}");
        }
        public void resume()
        {
            state = 1;

            Console.WriteLine($"La canzone è in riproduzione, stato: {state}");
        }
        public void incRate()
        {
            _rate += 0.25;
        }
        public void decRate()
        {
            _rate -= 0.25;
        }
        public void forward()
        {

        }
        public void backward()
        {

        }

    }
    public class StreamingPlatform
    {
        List<string> _song = new List<string>();
        public void addSong(Song song)
        {
            _song.Add(song._title);

        }
        public void dicitura() 
        { Console.WriteLine("digita:\n0 stopparla\n1 per fare play\n2 per metterla in pausa\n5 per aumentare la velocità,9 per diminuire la velocità");

        }

        public void modifyState(Song song)
        {
            Console.WriteLine($"\nLa canzone si trova allo stato {song.state}:");
            dicitura();
        
            var i = Console.ReadLine();
            try
            {
                int a = int.Parse(i);

                if (a == 1)

                {
                    song.play();
                }

                else if (a == 0)
                {

                    song.stop();

                }
                else if (a == 2)
                {


                    song.pause();

                }
                else if (a == 1)
                {

                    song.resume();

                }
                else if (a == 5)
                {
                    song.incRate();
                }
                else if (a == 9)
                {
                    song.decRate();
                }
                else
                    dicitura();
            }

            catch
            { dicitura(); }
        }
    }
        public interface IPlayer
        {
            public abstract void play();
            public abstract void stop();
            public abstract void pause();
            public abstract void resume();
            public abstract void incRate();
            public abstract void decRate();
            public abstract void forward();
            public abstract void backward();

        }
    } 
