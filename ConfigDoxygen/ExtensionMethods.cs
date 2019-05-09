/*
ConfigDoxyGen - An humble GUI front-end for editing configure doxygen files.
Copyright (c) 2019 Francesco Paolo Lezza (francescoprogrammer.com)

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.

*/

using System;
using System.Linq;

namespace ConfigDoxygen {
    /// <summary>
    /// A static class which extends some objects method
    /// <list type="Method">
    ///     <item> Contains() for Objects; </item>
    ///     <item> ... </item>
    /// </list>
    /// </summary>
    public static class ExtensionMethods {
        /// <summary>
        /// The In<T>() method takes a series of parameters to
        /// verify if a particular object is contained in
        /// a set of object
        /// </summary>
        /// <typeparam name="T">This method takes only generic types</typeparam>
        /// <param name="obj">The object which represents what you want to search</param>
        /// <param name="args">Represents a set of object that can grown dinamically
        ///                    according to the number of object in input
        /// </param>
        /// <returns>Returns true/false depending on if the taken object is in the set or not.</returns>
        public static Boolean In<T>(this T obj, params T[] args) {
            return args.Contains(obj);
        }
    }
}
