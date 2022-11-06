namespace Musica
{
    public sealed class Spotify : StreamingPlatform
    {
        public Spotify()
        {
            song = new SpotifyMusic[] {
                new SpotifyMusic(){ _title ="Extasi"},
                new SpotifyMusic(){ _title ="Via di qua"},
                new SpotifyMusic(){ _title ="La dolcevita", },
                new SpotifyMusic(){ _title ="Dove si balla"}

                };
        }
        private class SpotifyMusic : Song
        {
            public SpotifyMusic()
            {
            }
        }
    }
}

      
