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
using System.IO;
using System.Reflection;

namespace ConfigDoxygen {
    internal class Parameters {
        //Read-only variables
#if DEBUG
        private readonly String prop_pathDoxyFile = @"E:\SORGENTI\APPs\ConfigDoxygen\src\ConfigDoxygen\bin\Debug\Doxyfile";
#else
        private readonly String prop_pathDoxyFile = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\Doxyfile";
#endif
        //Read-only variables -- end

        //define read-only properties
        public String pathDoxyFile { get { return prop_pathDoxyFile; } }
        //...
        //define read-only properties -- end
    }
}
