using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypto.Pages
{
    public class Alfabet
    {
        public static Dictionary<string, string> polishExtended = new Dictionary<string, string>(){
            { "61", "a" },
            { "C485", "ą" },
            { "62", "b" },
            { "63", "c" },
            { "C487", "ć" },
            { "64", "d" },
            { "65", "e" },
            { "C499", "ę" },
            { "66", "f" },
            { "67", "g" },
            { "68", "h" },
            { "69", "i" },
            { "6A", "j" },
            { "6B", "k" },
            { "6C", "l" },
            { "C582", "ł" },
            { "6D", "m" },
            { "6E", "n" },
            { "C584", "ń" },
            { "6F", "o" },
            { "C3B3", "ó" },
            { "70", "p" },
            { "71", "q" },
            { "72", "r" },
            { "73", "s" },
            { "C59b", "ś" },
            { "74", "t" },
            { "75", "u" },
            { "76", "v" },
            { "77", "w" },
            { "78", "x" },
            { "79", "y" },
            { "7A", "z" },
            { "C5BA", "ź" },
            { "C5BC", "ż" }
        };

        public static Dictionary<string, string> utfDictionary = new Dictionary<string, string>() { };
    }
}
