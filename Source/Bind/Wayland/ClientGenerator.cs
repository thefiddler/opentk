#region License
//
// ClientGenerator.cs
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
using Bind;

namespace Bind.Wayland
{
    class ClientGenerator : GeneratorBase
    {
        public ClientGenerator(Settings settings, string directory) :
            base(settings, directory)
        {
            Settings.DefaultOutputPath = String.Format(
                Settings.DefaultOutputPath, "Platform/Wayland/Bindings", "Client");
            Settings.DefaultDocPath = String.Empty;

            // Common settings for all OpenCL generators
            Settings.DefaultTypeMapFile = "Wayland/wl.tm";
            Settings.DefaultSignaturesFile = "../Wayland/client.xml";
            Settings.DefaultOverridesFile = "../Wayland/overrides.xml";

            Settings.FunctionPrefix = "wl";
            Settings.ConstantPrefix = "WL_";
            Settings.EnumPrefix = "wl";
            Settings.OutputClass = "Client";

            Settings.Compatibility |= Settings.Legacy.NoDebugHelpers;
            Settings.Compatibility |= Settings.Legacy.UseDllImports;
            //Settings.Compatibility |= Settings.Legacy.NoPublicUnsafeFunctions;
            Settings.Compatibility |= Settings.Legacy.NoUnsignedOverloads;

            Settings.DefaultOutputNamespace = "OpenTK.Platform.Wayland";
            Settings.DefaultWrappersFile = "Client.cs";
            Settings.DefaultEnumsFile = "Client.Enums.cs";
            Settings.DefaultClassesFile = "Client.Extensions.cs";

            Profile = "wl";
            Version = "1.5";
        }
    }
}

