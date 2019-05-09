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
using System.Runtime.InteropServices;

namespace ConfigDoxygen {
    /// <summary>
    /// A static class which provides to call methods exported from an unmanaged shared library.
    /// </summary>

    /// <summary>
    /// This method calls two API of Windows USER (32 bit) aka user32.dll that provides core functionality 
    /// for building simple user interfaces. In this case SendMessage() and ReleaseCapture().
    /// 
    /// See: https://stackoverflow.com/questions/13590447/move-p-invokes-to-nativemethods-classbecause-it-is-a-p-invoke-method-message
    /// </summary>
    public static class NativeMethods {
        [DllImportAttribute("user32.dll")]
        public static extern Int32 SendMessage(IntPtr hWnd, Int32 Msg, Int32 wParam, Int32 lParam);

        [DllImportAttribute("user32.dll")]
        public static extern Boolean ReleaseCapture();
    }
}
