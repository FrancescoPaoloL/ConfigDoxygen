﻿/*
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

namespace ConfigDoxygen {
    /// <summary>
    /// A class which represents the informations
    /// about doxygen config file.
    /// The "Description" is just a comment, an explain
    /// about what a particular tag means.
    /// </summary>
    public class DefinitionTag {
        public String Tag { get; set; }
        public String Value { get; set; }
        public String Description { get; set; }
    }
}
