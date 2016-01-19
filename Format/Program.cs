/* Format/Program.cs
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

namespace Format
{
    /// <summary>
    /// It uh, takes a single argument integer n that it uses to print the input stream's
    /// tokens. It prints them n-tokens at a time. n defaults to 1 if unspecified.
    /// </summary>
	class MainClass {
		public static void Main (string[] args) {
            int n = 1;
            if ( args.Length == 1 ) {
                n = Int32.Parse( args[0] );
            }
            // Read stdin
            string input = "";
            string line;
            while ( ( line = Console.ReadLine() ) != null ) {
                input += line + '\n';
            }
            // Tokenize
            char[] delimiters = { ' ', '\t', '\n' };
            List<string> tokens = new List<string>( input.Split( delimiters ) );
            // Print
            int m = 0;
            foreach ( string token in tokens ) {
                Console.Write( token );
                if ( ++m >= n ) {
                    Console.WriteLine();
                    m = 0;
                // gotta be PRETTY
                } else {
                    Console.Write( " " );
                }
            }
            if ( m != 0 ) {
                Console.WriteLine();
            }
            // Done!
		}
	}
}
