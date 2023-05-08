using System.Collections.Generic;

namespace Madlibs.Models
{
    public class Words
    {
        public string Noun {get; set;}
        public string Verb {get; set;}
        public string Adjective { get; set; }
        public string Adverb {get; set;}
        public string Name {get; set;}
        public string[] Id {get; set;}
        public Dictionary<string[], string> Options { get; set; } = new Dictionary< string[], string> () {};

    }
}