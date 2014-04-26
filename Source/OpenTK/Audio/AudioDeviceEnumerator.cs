#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2009 the Open Toolkit library.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to 
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//
#endregion

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;

using OpenTK.Audio.OpenAL;

namespace OpenTK.Audio
{
    enum AlcVersion
    {
        Alc1_0,
        Alc1_1
    }

    class AudioDeviceEnumerator
    {
        readonly List<string> available_playback_devices = new List<string>();
        readonly List<string> available_recording_devices = new List<string>();

        internal bool IsOpenALSupported { get; private set; }
        internal AlcVersion Version { get; private set; }

        internal int PlaybackDeviceCount { get { return available_playback_devices.Count; } }
        internal int RecordingDeviceCount { get { return available_recording_devices.Count; } }

        internal static string DefaultPlaybackDevice { get; private set; }
        internal static string DefaultRecordingDevice { get; private set; }

        internal string GetPlaybackDevice(int index)
        {
            if (index < 0 || index > PlaybackDeviceCount)
                throw new ArgumentOutOfRangeException();

            return available_playback_devices[index];
        }

        internal string GetRecordingDevice(int index)
        {
            if (index < 0 || index > RecordingDeviceCount)
                throw new ArgumentOutOfRangeException();

            return available_recording_devices[index];
        }

        internal AudioDeviceEnumerator()
        {
            Update();
        }

        internal void Update()
        {
            // Load all available audio devices into the available_*_devices lists.

            IntPtr dummy_device = IntPtr.Zero;
            ContextHandle dummy_context = ContextHandle.Zero;

            try
            {
                Debug.WriteLine("Enumerating audio devices.");
                Debug.Indent();

                // need a dummy context for correct results
                dummy_device = Alc.OpenDevice(null);
                dummy_context = Alc.CreateContext(dummy_device, (int[])null);
                bool dummy_success = Alc.MakeContextCurrent(dummy_context);
                AlcError dummy_error = Alc.GetError(dummy_device);
                if (!dummy_success || dummy_error != AlcError.NoError)
                {
                    throw new AudioContextException("Failed to create dummy Context. Device (" + dummy_device.ToString() +
                                                    ") Context (" + dummy_context.Handle.ToString() +
                                                    ") MakeContextCurrent " + (dummy_success ? "succeeded" : "failed") +
                                                    ", Alc Error (" + dummy_error.ToString() + ") " + Alc.GetString(IntPtr.Zero, (AlcGetString)dummy_error));
                }

                // Get a list of all known playback devices, using best extension available
                if (Alc.IsExtensionPresent(IntPtr.Zero, "ALC_ENUMERATION_EXT"))
                {
                    Version = AlcVersion.Alc1_1;
                    if (Alc.IsExtensionPresent(IntPtr.Zero, "ALC_ENUMERATE_ALL_EXT"))
                    {
                        available_playback_devices.Clear();
                        available_playback_devices.AddRange(Alc.GetString(IntPtr.Zero, AlcGetStringList.AllDevicesSpecifier));
                        default_playback_device = Alc.GetString(IntPtr.Zero, AlcGetString.DefaultAllDevicesSpecifier);
                    }
                    else
                    {
                        available_playback_devices.Clear();
                        available_playback_devices.AddRange(Alc.GetString(IntPtr.Zero, AlcGetStringList.DeviceSpecifier));
                        DefaultPlaybackDevice = Alc.GetString(IntPtr.Zero, AlcGetString.DefaultDeviceSpecifier);
                    }
                }
                else
                {
                    Version = AlcVersion.Alc1_0;
                    Debug.Print("Device enumeration extension not available. Failed to enumerate playback devices.");
                }
                AlcError playback_err = Alc.GetError(dummy_device);
                if (playback_err != AlcError.NoError)
                    throw new AudioContextException("Alc Error occured when querying available playback devices. " + playback_err.ToString());

                // Get a list of all known recording devices, at least ALC_ENUMERATION_EXT is needed too
                if (Version == AlcVersion.Alc1_1 && Alc.IsExtensionPresent(IntPtr.Zero, "ALC_EXT_CAPTURE"))
                {
                    available_recording_devices.Clear();
                    available_recording_devices.AddRange(Alc.GetString(IntPtr.Zero, AlcGetStringList.CaptureDeviceSpecifier));
                    DefaultRecordingDevice = Alc.GetString(IntPtr.Zero, AlcGetString.CaptureDefaultDeviceSpecifier);
                }
                else
                {
                    Debug.Print("Capture extension not available. Failed to enumerate recording devices.");
                }
                AlcError record_err = Alc.GetError(dummy_device);
                if (record_err != AlcError.NoError)
                    throw new AudioContextException("Alc Error occured when querying available recording devices. " + record_err.ToString());

#if DEBUG
                Debug.WriteLine("Found playback devices:");
                foreach (string s in available_playback_devices)
                    Debug.WriteLine(s);

                Debug.WriteLine("Default playback device: " + default_playback_device);

                Debug.WriteLine("Found recording devices:");
                foreach (string s in available_recording_devices)
                    Debug.WriteLine(s);

                Debug.WriteLine("Default recording device: " + default_recording_device);
#endif
                openal_supported = true;
            }
            catch (DllNotFoundException e)
            {
                Trace.WriteLine(e.ToString());
            }
            catch (AudioContextException ace)
            {
                Trace.WriteLine(ace.ToString());
            }
            finally
            {
                Debug.Unindent();

                // clean up the dummy context
                Alc.MakeContextCurrent(ContextHandle.Zero);
                if (dummy_context != ContextHandle.Zero && dummy_context.Handle != IntPtr.Zero)
                    Alc.DestroyContext(dummy_context);
                if (dummy_device != IntPtr.Zero)
                    Alc.CloseDevice(dummy_device);
            }
        }
    }
}