#region License
//
// TouchFingerEventArgs.cs
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
using OpenTK.Input;

namespace OpenTK
{
    /// <summary>
    /// Defines the event data for touch events.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Do not cache instances of this type outside their event handler.
    /// If necessary, you can clone a <see cref="TouchFingerEventArgs"/> instance using the 
    /// <see cref="TouchFingerEventArgs(TouchFingerEventArgs)"/> constructor.
    /// </para>
    /// </remarks>
    public class FingerEventArgs : EventArgs
    {
        public TouchType Type { get; internal set; }
        public TouchFinger Finger { get; internal set; }

        #region Constructors

        /// <summary>
        /// Constructs a new <see cref="TouchFingerEventArgs"/> instance.
        /// </summary>
        public FingerEventArgs()
        {
        }

        /// <summary>
        /// Constructs a new <see cref="TouchFingerEventArgs"/> instance.
        /// </summary>
        /// <param name="args">An existing <see cref="TouchFingerEventArgs"/> instance to clone.</param>
        public FingerEventArgs(FingerEventArgs args)
        {
            Finger = args.Finger;
            Type = args.Type;
        }

        #endregion
    }
}

