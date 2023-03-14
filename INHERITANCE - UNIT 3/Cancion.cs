using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INHERITANCE___UNIT_3
{
    public class Cancion
    {
        protected string name;
        protected string duration;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Duration
        {
            get { return duration; }
            set { duration = value; }
        }
        public Cancion()
        {
            name = String.Empty;
            duration = String.Empty;
        }
        public Cancion(String name, String Duration)
        {
            this.name = name;
            this.duration = duration;
        }
        public Cancion(string name, string duration,string artist) : this (name, duration)
        {
        }
        public override string ToString()
        {
            return name.ToString() + " " + duration;
        }

    }
}
