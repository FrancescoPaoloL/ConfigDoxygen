///-----------------------------------------------------------------
///   Namespace:      ConfigDoxygen
///   Class:          ExtensionMethods
///   Description:    <Description>
///   Author:         Francesco Paolo Lezza         Date: 08/08/2018
///   Notes:          <Notes>
///   
///   Revision History:
///   Name:           Date:        Description:
///-----------------------------------------------------------------
///
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
