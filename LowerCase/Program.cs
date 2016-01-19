/* LowerCase/Program.cs
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
    /// This one is dumb and doesn't actually stream the data, it saves it all to memory first.
    /// It then finally lowercases the entire stream, and outputs each token line by line.
    /// The fact that it saves the entire string is BAAAD, but it works and there were no
    /// specifications otherwise so uuHHH-- :)
    /// It takes no arguments, input is a string, output is a tokenized lowercase string delimited
    /// by newlines.
    /// </summary>
namespace LowerCase {
	class MainClass {
		public static void Main (string[] args) {
            // Read stdin
            string input = "";
            string line;
            while ( ( line = Console.ReadLine() ) != null) {
                // input.Concat( line ); duuur
                input += line;
            }
            // Lowercase
            input.ToLower();
            // Tokenize
            char[] delimiters = { ' ', '\t', '\n' };
            List<string> tokens = new List<string>( input.Split( delimiters ) );
            // Print
            foreach ( string token in tokens ) {
                Console.WriteLine( token );
            }
            // Done!
		}
	}
}
