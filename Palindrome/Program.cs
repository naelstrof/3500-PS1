/* Palindrome/Program.cs
*
* Copyright (C) 2016: Dalton Nell u0876710
*
* This file is part of PS1.
*
* PS1 is free software: you can redistribute it and/or modify
* it under the terms of the GNU General Public License as published by
* the Free Software Foundation, either version 3 of the License, or
* (at your option) any later version.
*
* Maim is distributed in the hope that it will be useful,
* but WITHOUT ANY WARRANTY; without even the implied warranty of
* MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
* GNU General Public License for more details.
*
* You should have received a copy of the GNU General Public License
* along with PS1.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using System.Collections.Generic;

    /// <summary>
    /// Takes an input stream, tokenizes it, and outputs tokens that happen to also be palindromes
    /// delimited by new lines.
    /// </summary>
namespace Palindrome {
	class MainClass {
		public static void Main (string[] args) {
            // Read stdin
            List<string> input = new List<string>();
            string line;
            while ( ( line = Console.ReadLine() ) != null) {
                input.Add(line);
            }
            // Check for palindromes
            foreach ( string palindrome in input ) {
                if ( palindrome.Length <= 0 ) {
                    continue;
                }
                char[] foo = palindrome.ToCharArray();
                Array.Reverse( foo );
                // Why 'new string(foo)'? Because casting is hard in C# ok???
                // .ToString() didn't work, maybe it's unimplemented in mono i donno lmao
                if ( String.Compare( new string(foo), palindrome ) == 0 ) {
                    // Print
                    Console.WriteLine( palindrome );
                }
            }
            // Done!
		}
	}
}
