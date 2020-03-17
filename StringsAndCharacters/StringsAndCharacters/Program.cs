using System;

namespace StringsAndCharacters
{
    class Program
    {
        //Page 39 - 40
        //String and Characters
        static void Main(string[] args)
        {
            char c = 'A'; // Simple character

            //Scape Secuences
            //char newLine = '\n';
            //char backSlash = '\\';

            //The \u(or \x) escape sequence lets you specify any Unicode character via its fourdigit hexadecimal code:
            char copyrightSymbol = '\u00A9';
            char omegaSymbol = '\u03A9';
            char newLine = '\u000A';

        }
    }
}
