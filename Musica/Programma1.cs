using System;
using System.Globalization;

namespace Musica
{

        public static class Programma { 
                public static void Start()
                {
                    Spotify spotify = new Spotify();
                    spotify.ListSongs();
                    Console.WriteLine("selezionane una: ");
                    var i = CharUnicodeInfo.GetDecimalDigitValue(Console.ReadKey().KeyChar);
                    var input = char.ToUpper(Console.ReadKey().KeyChar);
                    spotify.Play(i - 1);
                    do
                    {
                        Console.WriteLine("Per andare avanti clicca f");
                        Console.WriteLine("Per andare indietro clicca b ");
                        Console.WriteLine("Per stoppare clicca s");
                        Console.WriteLine("Per mettere in pausa clicca p");

                        Console.WriteLine("Per uscire clicca E: ");

                        input = char.ToUpper(Console.ReadKey().KeyChar);

                        Console.WriteLine();

                        switch (input)
                        {
                            case 'F':
                                spotify.forward();
                                break;
                            case 'B':
                                spotify.backward();
                                break;
                            case 'S':
                                spotify.stop();
                                break;
                            case 'P':
                                spotify.pause();
                                break;
                        }

                    } while (input != 'E');
                }
            }


        
}

      
