///-----------------------------------------------------------------
///   Namespace:      ConfigDoxygen
///   Class:          DefinitionTag
///   Description:    <Description>
///   Author:         Francesco Paolo Lezza         Date: 08/08/2018
///   Notes:          <Notes>
///   
///   Revision History:
///   Name:           Date:        Description:
///-----------------------------------------------------------------

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
