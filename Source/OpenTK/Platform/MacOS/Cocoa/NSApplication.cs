#region License
//
// NSApplication.cs
//
// Author:
//       Olle Håkansson <ollhak@gmail.com>
//
// Copyright (c) 2014 Olle Håkansson
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
using System.ComponentModel;
using System.Runtime.InteropServices;
using OpenTK.Platform.MacOS;

namespace OpenTK.Platform.MacOS
{
    static class NSApplication
    {
        internal static IntPtr Handle;
        internal static IntPtr AutoreleasePool;

        static readonly IntPtr selQuit = Selector.Get("quit");

        internal static void Initialize()
        {
            // Create the NSAutoreleasePool
            AutoreleasePool = Cocoa.SendIntPtr(Cocoa.SendIntPtr(Class.Get("NSAutoreleasePool"), Selector.Alloc), Selector.Init);

            // Register a Quit method to be called on cmd-q
            IntPtr nsapp = Class.Get("NSApplication");
            Class.RegisterMethod(nsapp, new OnQuitDelegate(OnQuit), "quit", "v@:");
            Class.RegisterMethod(nsapp, new OnWillFinishLaunchingDelegate(OnWillFinishLaunching),
                "applicationWillnFinishLaunching:", "v@:@");

            // Fetch the application handle
            Handle = Cocoa.SendIntPtr(nsapp, Selector.Get("sharedApplication"));

            // Setup the application
            Cocoa.SendBool(Handle, Selector.Get("setActivationPolicy:"), (int)NSApplicationActivationPolicy.Regular);
            Cocoa.SendVoid(Handle, Selector.Get("activateIgnoringOtherApps:"), true);

            // Setup application menu
            SetupAppMenu(Handle);

            // Tell cocoa we're ready to run the application (usually called by [NSApp run]). 
            Cocoa.SendVoid(Handle, Selector.Get("finishLaunching"));
        }

        static void SetupAppMenu(IntPtr nsapp)
        {
            var entry = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            var name = Cocoa.ToNSString(entry);

            // [NSApp setMainMenu:[[NSMenu alloc] init]];
            //Cocoa.SendVoid(nsapp, Selector.Get("setMainMenu:"),
            //    Cocoa.SendIntPtr(
            //        Cocoa.SendIntPtr(Class.Get("NSMenu"), Selector.Alloc),
            //        Selector.Init));
            var menubar =
                Cocoa.SendIntPtr(
                    Cocoa.SendIntPtr(Class.Get("NSMenu"), Selector.Alloc),
                    Selector.Get("initWithTitle:"), name);
            Cocoa.SendVoid(nsapp, Selector.Get("setMainMenu:"), menubar);

            var appleMenuItem =
                Cocoa.SendIntPtr(menubar, Selector.Get("addItemWithTitle:action:keyEquivalent:"),
                    name, IntPtr.Zero, name);
            var appleMenu =
                Cocoa.SendIntPtr(
                    Cocoa.SendIntPtr(Class.Get("NSMenu"), Selector.Alloc),
                    Selector.Init);
            Cocoa.SendVoid(appleMenuItem, Selector.Get("setSubmenu:"), appleMenu);

            // Add menu items
            //title = [@"About " stringByAppendingString:appName];
            //[appleMenu addItemWithTitle:title action:@selector(orderFrontStandardAboutPanel:) keyEquivalent:@""];

            //[appleMenu addItem:[NSMenuItem separatorItem]];

            //title = [@"Hide " stringByAppendingString:appName];
            //[appleMenu addItemWithTitle:title action:@selector(hide:) keyEquivalent:@"h"];

            //menuItem = (NSMenuItem *)[appleMenu addItemWithTitle:@"Hide Others" action:@selector(hideOtherApplications:) keyEquivalent:@"h"];
            //[menuItem setKeyEquivalentModifierMask:(NSAlternateKeyMask|NSCommandKeyMask)];

            //[appleMenu addItemWithTitle:@"Show All" action:@selector(unhideAllApplications:) keyEquivalent:@""];

            //[appleMenu addItem:[NSMenuItem separatorItem]];

            // Add Quit item
            Cocoa.SendIntPtr(appleMenu, Selector.Get("addItemWithTitle:action:keyEquivalent:"),
                Cocoa.ToNSString("Quit"), Selector.Get("quit"), Cocoa.ToNSString("q"));

            var selSetAppleMenu = Selector.Get("setAppleMenu:");
            if (Cocoa.SendBool(nsapp, Selector.Get("respondsToSelector:"), selSetAppleMenu))
            {
                Cocoa.SendVoid(nsapp, selSetAppleMenu, appleMenu);
            }

            /*
            // Put menu into the menubar
            var menuItem = Cocoa.SendIntPtr(
                Cocoa.SendIntPtr(Cocoa.SendIntPtr(Class.Get("NSMenuItem"), Selector.Alloc), Selector.Autorelease),
                Selector.Get("initWithTitle:action:keyEquivalent:"),
                Cocoa.ToNSString(""),
                IntPtr.Zero,
                Cocoa.ToNSString(""));
            Cocoa.SendVoid(menuItem, Selector.Get("setSubmenu:"), appleMenu);
            Cocoa.SendVoid(
                Cocoa.SendIntPtr(nsapp, Selector.Get("mainMenu")),
                Selector.Get("addItem:"),
                menuItem);

            // Tell the application object that this is now the application menu
            Cocoa.SendVoid(nsapp, Selector.Get("setAppleMenu:"), appleMenu);
            Cocoa.SendVoid(appleMenu, Selector.Get("setTitle:"), name);
            */

            /*
            NSMenu      *windowMenu;
            NSMenuItem  *windowMenuItem;
            NSMenuItem  *menuItem;

            windowMenu = [[NSMenu alloc] initWithTitle:@"Window"];

            // "Minimize" item
            menuItem = [[NSMenuItem alloc] initWithTitle:@"Minimize" action:@selector(performMiniaturize:) keyEquivalent:@"m"];
            [windowMenu addItem:menuItem];
            [menuItem release];

            // Put menu into the menubar
            windowMenuItem = [[NSMenuItem alloc] initWithTitle:@"Window" action:nil keyEquivalent:@""];
            [windowMenuItem setSubmenu:windowMenu];
            [[NSApp mainMenu] addItem:windowMenuItem];

            // Tell the application object that this is now the window menu
            [NSApp setWindowsMenu:windowMenu];

            // Finally give up our references to the objects
            [windowMenu release];
            [windowMenuItem release];
            */
            #if false
            // Create the menu bar
            var appleMenu = Cocoa.SendIntPtr(Cocoa.SendIntPtr(Class.Get("NSMenu"), Selector.Alloc),
                Selector.Autorelease);

            var menuItem = Cocoa.SendIntPtr(Cocoa.SendIntPtr(Class.Get("NSMenuItem"), Selector.Alloc),
                Selector.Autorelease);

            // Add menu item to bar, and bar to application
            Cocoa.SendIntPtr(appleMenu, Selector.Get("addItem:"), menuItem);
            Cocoa.SendIntPtr(Handle, Selector.Get("setMainMenu:"), appleMenu);

            // Add a "Quit" menu item and bind the button.
            var appMenu = Cocoa.SendIntPtr(Cocoa.SendIntPtr(Class.Get("NSMenu"), Selector.Alloc),
                Selector.Autorelease);
            var quitMenuItem = Cocoa.SendIntPtr(Cocoa.SendIntPtr(Cocoa.SendIntPtr(Class.Get("NSMenuItem"), Selector.Alloc),
                Selector.Get("initWithTitle:action:keyEquivalent:"), Cocoa.ToNSString("Quit"), selQuit, Cocoa.ToNSString("q")),
                Selector.Autorelease);

            Cocoa.SendIntPtr(appMenu, Selector.Get("addItem:"), quitMenuItem);
            Cocoa.SendIntPtr(menuItem, Selector.Get("setSubmenu:"), appMenu);

            Cocoa.SendVoid(menuItem, Selector.Get("setTitle:"), Cocoa.ToNSString("FooBar"));
            Cocoa.SendVoid(appMenu, Selector.Get("setTitle:"), Cocoa.ToNSString("FooBar"));
            Cocoa.SendVoid(appleMenu, Selector.Get("setTitle:"), Cocoa.ToNSString("FooBar"));

            Cocoa.SendVoid(Handle, Selector.Get("setAppleMenu:"), appleMenu);
            #endif
        }

        internal static event EventHandler<CancelEventArgs> Quit = delegate { };

        delegate void OnQuitDelegate(IntPtr self, IntPtr cmd);
        static void OnQuit(IntPtr self, IntPtr cmd)
        {
            var e = new CancelEventArgs();
            Quit(null, e);
            if (!e.Cancel)
            {
                Cocoa.SendVoid(Handle, Selector.Get("terminate:"), Handle);
            }
        }

        delegate void OnWillFinishLaunchingDelegate(IntPtr self, IntPtr cmd, IntPtr notification);
        static void OnWillFinishLaunching(IntPtr self, IntPtr cmd, IntPtr notification)
        {
            SetupAppMenu(Handle);
        }


    }
}
