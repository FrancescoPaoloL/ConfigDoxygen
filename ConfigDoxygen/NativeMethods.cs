///-----------------------------------------------------------------
///   Namespace:      ConfigDoxygen
///   Class:          NativeMethods
///   Description:    <Description>
///   Author:         Francesco Paolo Lezza         Date: 08/08/2018
///   Notes:          <Notes>
///   
///   Revision History:
///   Name:           Date:        Description:
///-----------------------------------------------------------------
///

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
