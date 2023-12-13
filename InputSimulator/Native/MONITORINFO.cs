﻿using System.Runtime.InteropServices;

namespace InputSimulator.Native
{
    [StructLayout(LayoutKind.Sequential)]
    public struct MONITORINFO
    {
        #region Constructor
        public MONITORINFO() { }
        #endregion Constructor

        #region Fields
        /// <summary>
        /// The size of the structure, in bytes.
        /// </summary>
        public readonly uint cbSize = unchecked((uint)Marshal.SizeOf(typeof(MONITORINFO)));
        /// <summary>
        /// A RECT structure that specifies the display monitor rectangle, expressed in virtual-screen coordinates.
        /// Note that if the monitor is not the primary display monitor, some of the rectangle's coordinates may be negative values.
        /// </summary>
        public RECT rcMonitor;
        /// <summary>
        /// A RECT structure that specifies the work area rectangle of the display monitor, expressed in virtual-screen coordinates.
        /// Note that if the monitor is not the primary display monitor, some of the rectangle's coordinates may be negative values.
        /// </summary>
        public RECT rcWork;
        /// <summary>
        /// A set of flags that represent attributes of the display monitor.
        /// </summary>
        public Flags dwFlags;
        #endregion Fields

        #region (Enum) Flags
        public enum Flags : uint
        {
            MONITORINFOF_PRIMARY = 1,
        }
        #endregion (Enum) Flags
    }
}
