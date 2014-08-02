#region License
//
// HapticEffect.cs
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

using System.Runtime.InteropServices;

namespace OpenTK.Input
{
    [StructLayout(LayoutKind.Explicit)]
    public struct HapticEffect
    {
        [FieldOffset(0)]
        public HapticEffectType Type;
        [FieldOffset(4)]
        public HapticEffectVibration Vibration;

        public HapticEffect(HapticEffectVibration vibration)
        {
            Type = HapticEffectType.Vibration;
            Vibration = vibration;
        }
    }

    public enum HapticEffectType
    {
        None = 0,
        Vibration
    }

    public struct HapticEffectVibration
    {
        public float LargeMotor { get; set; }
        public float SmallMotor { get; set; }

        public HapticEffectVibration(float large, float small)
            : this()
        {
            LargeMotor = large;
            SmallMotor = small;
        }
    }
}
