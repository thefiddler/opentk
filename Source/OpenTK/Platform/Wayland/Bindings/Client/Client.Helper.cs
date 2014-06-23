#region License
//
// Client.Helper.cs
//
// Author:
//       Stefanos A. <stapostol@gmail.com>
//
// Copyright (c) 2006-2014 Stefanos Apostolopoulos
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//
#endregion

using System;
using System.Runtime.InteropServices;

namespace OpenTK.Platform.Wayland
{
    partial class Client : BindingsBase
    {
        const string Library = "libwayland-client.so.1";
        static readonly object sync = new object();
        static readonly byte[] EntryPointNames;
        static readonly int[] EntryPointNameOffsets;
        static readonly IntPtr[] EntryPoints;

        protected override object SyncRoot
        {
            get
            {
                return sync;
            }
        }

        internal override void LoadEntryPoints()
        {
        }

        protected override IntPtr GetAddress(string funcname)
        {
            return IntPtr.Zero;
        }
    }

    //[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    //delegate void LogCallback();

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    delegate int DispatcherCallback(IntPtr user_data, IntPtr target, int opcode, ref WaylandMessage message, [Out] WaylandArgument[] replies);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    delegate IntPtr ListenerCallback(IntPtr data, ref WaylandInterface callback, int time);

    struct WaylandArgument
    {
        IntPtr value;

        public int I { get { return value.ToInt32(); } }
        public uint U { get { return unchecked((uint)value.ToInt32()); } }
        public int F { get { return value.ToInt32(); } }
        public string S { get { unsafe { return new string((sbyte*)value); } } }
        public WaylandObject O { get { unsafe { return *(WaylandObject*)value; } } }
        public uint N { get { return unchecked((uint)value.ToInt32()); } }
        public WaylandArray A { get { unsafe { return *(WaylandArray*)value; } } }
        public int H { get { return value.ToInt32(); } }
    }

    struct WaylandArray
    {
        IntPtr size;
        IntPtr alloc;
        IntPtr data;
    }

    struct WaylandInterface
    {
        IntPtr name;
        int version;
        int method_count;
        unsafe WaylandMessage *methods;
        int event_count;
        unsafe WaylandMessage *events;
    }

    struct WaylandMessage
    {
        IntPtr name;
        IntPtr signature;
        unsafe WaylandInterface* types;
    }

    struct WaylandObject
    {
        public WaylandInterface Interface;
        IntPtr Implementation;
        int Id;
    }
}

