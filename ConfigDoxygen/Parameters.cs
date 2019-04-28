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
