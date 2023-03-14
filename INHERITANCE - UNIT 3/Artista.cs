using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INHERITANCE___UNIT_3
{
    public class Artista : Cancion
    {
        protected string artist;

        public string ARTIST
        {
            get { return artist; }
            set { artist = value; }
        }
        public Artista():base()
        {
            artist = string.Empty;
        }
        public Artista(string name, string duration,string artist) : base (name, duration, artist)
        {
            this.artist = artist;
        }
        public override string ToString()
        {
            return base.ToString() + " " + artist;
        }

    }
}
