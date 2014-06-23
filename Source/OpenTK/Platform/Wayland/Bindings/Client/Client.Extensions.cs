//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2013 Stefanos Apostolopoulos for the Open Toolkit Library
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

namespace OpenTK.Platform.Wayland
{
    using System;
    using System.Text;
    using System.Runtime.InteropServices;
    using OpenTK.Extensions;


    /// <summary>
    /// Defines methods to simplify WaylandDisplay usage.
    /// </summary>
    partial struct WaylandDisplay : IComparable<WaylandDisplay>, IEquatable<WaylandDisplay>
    {
        internal IntPtr Value;

        #region IComparable<WaylandDisplay> Implementation

        /// <summary>
        /// Returns the sort order of the current instance compared to the specified <see cref="WaylandDisplay"/>.
        /// </summary>
        /// <param name="other">The <see cref="WaylandDisplay"/> to compare with the current <see cref="WaylandDisplay"/>.</param>
        /// <returns>A value that indicates the relative order of the objects being compared.
        public int CompareTo(WaylandDisplay other)
        {
            int result = 0;
            if (result == 0)
                result = Value.CompareTo(other.Value);
            return result;
        }

        #endregion

        #region IEquatable<WaylandDisplay> Implementation

        /// <summary>
        /// Determines whether the specified <see cref="WaylandDisplay"/> is equal to the current <see cref="WaylandDisplay"/>.
        /// </summary>
        /// <param name="other">The <see cref="WaylandDisplay"/> to compare with the current <see cref="WaylandDisplay"/>.</param>
        /// <returns><c>true</c> if the specified <see cref="WaylandDisplay"/> is equal to the current
        /// <see cref="WaylandDisplay"/>; otherwise, <c>false</c>.</returns>
        public bool Equals(WaylandDisplay other)
        {
            bool result = true;
            result &= Value.Equals(other.Value);
            return result;
        }

        #endregion

        #region Public Members

        /// <summary>Defines a zero (or null) <see cref="WaylandDisplay"/></summary>
        public static readonly WaylandDisplay Zero = new WaylandDisplay();

        /// <summary>Tests two <see cref="WaylandDisplay"/> instances for equality.</summary>
        public static bool operator ==(WaylandDisplay left, WaylandDisplay right)
        {
            return left.Equals(right);
        }

        /// <summary>Tests two <see cref="WaylandDisplay"/> instances for inequality.</summary>
        public static bool operator !=(WaylandDisplay left, WaylandDisplay right)
        {
            return !left.Equals(right);
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object"/> is equal to the current <see cref="WaylandDisplay"/>.
        /// </summary>
        /// <param name="other">The <see cref="System.Object"/> to compare with the current <see cref="WaylandDisplay"/>.</param>
        /// <returns><c>true</c> if the specified <see cref="WaylandDisplay"/> is equal to the current
        /// <see cref="WaylandDisplay"/>; otherwise, <c>false</c>.</returns>
        public override bool Equals(object other)
        {
            return other is WaylandDisplay && Equals((WaylandDisplay)other);
        }

        /// <summary>
        /// Serves as a hash function for a <see cref="WaylandDisplay"/> object.
        /// </summary>
        /// <returns>A hash code for this instance that is suitable for use in hashing algorithms and data structures such as a
        /// hash table.</returns>
        public override int GetHashCode()
        {
            int hash = 0;
            hash ^= Value.GetHashCode();
            return hash;
        }

        #endregion
    }

    /// <summary>
    /// Defines methods to simplify WaylandDisplay usage.
    /// </summary>
    static partial class WaylandDisplayExtensions
    {
        /// <summary>[requires: v1.5]</summary>
        /// <param name="display"></param>
        public static void DisplayCancelRead(this WaylandDisplay display)
        {
            Client.DisplayCancelRead(display);
        }

        /// <summary>[requires: v1.5]</summary>
        /// <param name="name"></param>
        public static WaylandDisplay DisplayConnect(this String name)
        {
            return Client.DisplayConnect(name);
        }

        /// <summary>[requires: v1.5]</summary>
        /// <param name="fd"></param>
        public static WaylandDisplay DisplayConnectToFd(this Int32 fd)
        {
            return Client.DisplayConnectToFd(fd);
        }

        /// <summary>[requires: v1.5]</summary>
        /// <param name="display"></param>
        public static WaylandEventQueue DisplayCreateQueue(this WaylandDisplay display)
        {
            return Client.DisplayCreateQueue(display);
        }

        /// <summary>[requires: v1.5]</summary>
        /// <param name="display"></param>
        public static void DisplayDisconnect(this WaylandDisplay display)
        {
            Client.DisplayDisconnect(display);
        }

        /// <summary>[requires: v1.5]</summary>
        /// <param name="display"></param>
        public static Int32 DisplayDispatch(this WaylandDisplay display)
        {
            return Client.DisplayDispatch(display);
        }

        /// <summary>[requires: v1.5]</summary>
        /// <param name="display"></param>
        public static Int32 DisplayDispatchPending(this WaylandDisplay display)
        {
            return Client.DisplayDispatchPending(display);
        }

        /// <summary>[requires: v1.5]</summary>
        /// <param name="display"></param>
        /// <param name="queue"></param>
        public static Int32 DisplayDispatchQueue(this WaylandDisplay display, WaylandEventQueue queue)
        {
            return Client.DisplayDispatchQueue(display, queue);
        }

        /// <summary>[requires: v1.5]</summary>
        /// <param name="display"></param>
        /// <param name="queue"></param>
        public static Int32 DisplayDispatchQueuePending(this WaylandDisplay display, WaylandEventQueue queue)
        {
            return Client.DisplayDispatchQueuePending(display, queue);
        }

        /// <summary>[requires: v1.5]</summary>
        /// <param name="display"></param>
        public static Int32 DisplayFlush(this WaylandDisplay display)
        {
            return Client.DisplayFlush(display);
        }

        /// <summary>[requires: v1.5]</summary>
        /// <param name="display"></param>
        public static OpenTK.Platform.Wayland.ErrorCode DisplayGetError(this WaylandDisplay display)
        {
            return Client.DisplayGetError(display);
        }

        /// <summary>[requires: v1.5]</summary>
        /// <param name="display"></param>
        public static Int32 DisplayGetFd(this WaylandDisplay display)
        {
            return Client.DisplayGetFd(display);
        }

        /// <summary>[requires: v1.5]</summary>
        /// <param name="display"></param>
        public static Int32 DisplayPrepareRead(this WaylandDisplay display)
        {
            return Client.DisplayPrepareRead(display);
        }

        /// <summary>[requires: v1.5]</summary>
        /// <param name="display"></param>
        /// <param name="queue"></param>
        public static Int32 DisplayPrepareReadQueue(this WaylandDisplay display, WaylandEventQueue queue)
        {
            return Client.DisplayPrepareReadQueue(display, queue);
        }

        /// <summary>[requires: v1.5]</summary>
        /// <param name="display"></param>
        public static Int32 DisplayReadEvents(this WaylandDisplay display)
        {
            return Client.DisplayReadEvents(display);
        }

        /// <summary>[requires: v1.5]</summary>
        /// <param name="display"></param>
        public static Int32 DisplayRoundtrip(this WaylandDisplay display)
        {
            return Client.DisplayRoundtrip(display);
        }

    }

    /// <summary>
    /// Defines methods to simplify WaylandEventQueue usage.
    /// </summary>
    partial struct WaylandEventQueue : IComparable<WaylandEventQueue>, IEquatable<WaylandEventQueue>
    {
        internal IntPtr Value;

        #region IComparable<WaylandEventQueue> Implementation

        /// <summary>
        /// Returns the sort order of the current instance compared to the specified <see cref="WaylandEventQueue"/>.
        /// </summary>
        /// <param name="other">The <see cref="WaylandEventQueue"/> to compare with the current <see cref="WaylandEventQueue"/>.</param>
        /// <returns>A value that indicates the relative order of the objects being compared.
        public int CompareTo(WaylandEventQueue other)
        {
            int result = 0;
            if (result == 0)
                result = Value.CompareTo(other.Value);
            return result;
        }

        #endregion

        #region IEquatable<WaylandEventQueue> Implementation

        /// <summary>
        /// Determines whether the specified <see cref="WaylandEventQueue"/> is equal to the current <see cref="WaylandEventQueue"/>.
        /// </summary>
        /// <param name="other">The <see cref="WaylandEventQueue"/> to compare with the current <see cref="WaylandEventQueue"/>.</param>
        /// <returns><c>true</c> if the specified <see cref="WaylandEventQueue"/> is equal to the current
        /// <see cref="WaylandEventQueue"/>; otherwise, <c>false</c>.</returns>
        public bool Equals(WaylandEventQueue other)
        {
            bool result = true;
            result &= Value.Equals(other.Value);
            return result;
        }

        #endregion

        #region Public Members

        /// <summary>Defines a zero (or null) <see cref="WaylandEventQueue"/></summary>
        public static readonly WaylandEventQueue Zero = new WaylandEventQueue();

        /// <summary>Tests two <see cref="WaylandEventQueue"/> instances for equality.</summary>
        public static bool operator ==(WaylandEventQueue left, WaylandEventQueue right)
        {
            return left.Equals(right);
        }

        /// <summary>Tests two <see cref="WaylandEventQueue"/> instances for inequality.</summary>
        public static bool operator !=(WaylandEventQueue left, WaylandEventQueue right)
        {
            return !left.Equals(right);
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object"/> is equal to the current <see cref="WaylandEventQueue"/>.
        /// </summary>
        /// <param name="other">The <see cref="System.Object"/> to compare with the current <see cref="WaylandEventQueue"/>.</param>
        /// <returns><c>true</c> if the specified <see cref="WaylandEventQueue"/> is equal to the current
        /// <see cref="WaylandEventQueue"/>; otherwise, <c>false</c>.</returns>
        public override bool Equals(object other)
        {
            return other is WaylandEventQueue && Equals((WaylandEventQueue)other);
        }

        /// <summary>
        /// Serves as a hash function for a <see cref="WaylandEventQueue"/> object.
        /// </summary>
        /// <returns>A hash code for this instance that is suitable for use in hashing algorithms and data structures such as a
        /// hash table.</returns>
        public override int GetHashCode()
        {
            int hash = 0;
            hash ^= Value.GetHashCode();
            return hash;
        }

        #endregion
    }

    /// <summary>
    /// Defines methods to simplify WaylandEventQueue usage.
    /// </summary>
    static partial class WaylandEventQueueExtensions
    {
        /// <summary>[requires: v1.5]</summary>
        /// <param name="queue"></param>
        public static void EventQueueDestroy(this WaylandEventQueue queue)
        {
            Client.EventQueueDestroy(queue);
        }

    }

    /// <summary>
    /// Defines methods to simplify WaylandProxy usage.
    /// </summary>
    partial struct WaylandProxy : IComparable<WaylandProxy>, IEquatable<WaylandProxy>
    {
        internal IntPtr Value;

        #region IComparable<WaylandProxy> Implementation

        /// <summary>
        /// Returns the sort order of the current instance compared to the specified <see cref="WaylandProxy"/>.
        /// </summary>
        /// <param name="other">The <see cref="WaylandProxy"/> to compare with the current <see cref="WaylandProxy"/>.</param>
        /// <returns>A value that indicates the relative order of the objects being compared.
        public int CompareTo(WaylandProxy other)
        {
            int result = 0;
            if (result == 0)
                result = Value.CompareTo(other.Value);
            return result;
        }

        #endregion

        #region IEquatable<WaylandProxy> Implementation

        /// <summary>
        /// Determines whether the specified <see cref="WaylandProxy"/> is equal to the current <see cref="WaylandProxy"/>.
        /// </summary>
        /// <param name="other">The <see cref="WaylandProxy"/> to compare with the current <see cref="WaylandProxy"/>.</param>
        /// <returns><c>true</c> if the specified <see cref="WaylandProxy"/> is equal to the current
        /// <see cref="WaylandProxy"/>; otherwise, <c>false</c>.</returns>
        public bool Equals(WaylandProxy other)
        {
            bool result = true;
            result &= Value.Equals(other.Value);
            return result;
        }

        #endregion

        #region Public Members

        /// <summary>Defines a zero (or null) <see cref="WaylandProxy"/></summary>
        public static readonly WaylandProxy Zero = new WaylandProxy();

        /// <summary>Tests two <see cref="WaylandProxy"/> instances for equality.</summary>
        public static bool operator ==(WaylandProxy left, WaylandProxy right)
        {
            return left.Equals(right);
        }

        /// <summary>Tests two <see cref="WaylandProxy"/> instances for inequality.</summary>
        public static bool operator !=(WaylandProxy left, WaylandProxy right)
        {
            return !left.Equals(right);
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object"/> is equal to the current <see cref="WaylandProxy"/>.
        /// </summary>
        /// <param name="other">The <see cref="System.Object"/> to compare with the current <see cref="WaylandProxy"/>.</param>
        /// <returns><c>true</c> if the specified <see cref="WaylandProxy"/> is equal to the current
        /// <see cref="WaylandProxy"/>; otherwise, <c>false</c>.</returns>
        public override bool Equals(object other)
        {
            return other is WaylandProxy && Equals((WaylandProxy)other);
        }

        /// <summary>
        /// Serves as a hash function for a <see cref="WaylandProxy"/> object.
        /// </summary>
        /// <returns>A hash code for this instance that is suitable for use in hashing algorithms and data structures such as a
        /// hash table.</returns>
        public override int GetHashCode()
        {
            int hash = 0;
            hash ^= Value.GetHashCode();
            return hash;
        }

        #endregion
    }

    /// <summary>
    /// Defines methods to simplify WaylandProxy usage.
    /// </summary>
    static partial class WaylandProxyExtensions
    {
        /// <summary>[requires: v1.5]</summary>
        /// <param name="proxy"></param>
        /// <param name="dispatcher_func"></param>
        /// <param name="dispatcher_data"></param>
        /// <param name="data"></param>
        public static Int32 ProxyAddDispatcher(this WaylandProxy proxy, DispatcherCallback dispatcher_func, IntPtr dispatcher_data, IntPtr data)
        {
            return Client.ProxyAddDispatcher(proxy, dispatcher_func, dispatcher_data, data);
        }

        /// <summary>[requires: v1.5]</summary>
        /// <param name="proxy"></param>
        /// <param name="callback"></param>
        /// <param name="data"></param>
        public static Int32 ProxyAddListener(this WaylandProxy proxy, ListenerCallback callback, IntPtr data)
        {
            return Client.ProxyAddListener(proxy, callback, data);
        }

        /// <summary>[requires: v1.5]</summary>
        /// <param name="proxy"></param>
        public static void ProxyDestroy(this WaylandProxy proxy)
        {
            Client.ProxyDestroy(proxy);
        }

        /// <summary>[requires: v1.5]</summary>
        /// <param name="proxy"></param>
        [CLSCompliant(false)]
        public static unsafe char* ProxyGetClas(this WaylandProxy proxy)
        {
            return Client.ProxyGetClas(proxy);
        }

        /// <summary>[requires: v1.5]</summary>
        /// <param name="proxy"></param>
        public static Int32 ProxyGetI(this WaylandProxy proxy)
        {
            return Client.ProxyGetI(proxy);
        }

        /// <summary>[requires: v1.5]</summary>
        /// <param name="proxy"></param>
        public static IntPtr ProxyGetListener(this WaylandProxy proxy)
        {
            return Client.ProxyGetListener(proxy);
        }

        /// <summary>[requires: v1.5]</summary>
        /// <param name="proxy"></param>
        public static IntPtr ProxyGetUserData(this WaylandProxy proxy)
        {
            return Client.ProxyGetUserData(proxy);
        }

        /// <summary>[requires: v1.5]</summary>
        /// <param name="proxy"></param>
        /// <param name="opcode"></param>
        /// <param name="args"></param>
        [CLSCompliant(false)]
        public static void ProxyMarshalArray(this WaylandProxy proxy, Int32 opcode, WaylandArgument[] @args)
        {
            Client.ProxyMarshalArray(proxy, opcode, @args);
        }

        /// <summary>[requires: v1.5]</summary>
        /// <param name="proxy"></param>
        /// <param name="opcode"></param>
        /// <param name="args"></param>
        [CLSCompliant(false)]
        public static void ProxyMarshalArray(this WaylandProxy proxy, Int32 opcode, ref WaylandArgument @args)
        {
            Client.ProxyMarshalArray(proxy, opcode, ref @args);
        }

        /// <summary>[requires: v1.5]</summary>
        /// <param name="proxy"></param>
        /// <param name="opcode"></param>
        /// <param name="args"></param>
        [CLSCompliant(false)]
        public static unsafe void ProxyMarshalArray(this WaylandProxy proxy, Int32 opcode, WaylandArgument* @args)
        {
            Client.ProxyMarshalArray(proxy, opcode, @args);
        }

        /// <summary>[requires: v1.5]</summary>
        /// <param name="factory"></param>
        /// <param name="opcode"></param>
        /// <param name="args"></param>
        /// <param name="interface"></param>
        [CLSCompliant(false)]
        public static WaylandProxy ProxyMarshalArrayConstructor(this WaylandProxy factory, Int32 opcode, WaylandArgument[] @args, WaylandInterface @interface)
        {
            return Client.ProxyMarshalArrayConstructor(factory, opcode, @args, @interface);
        }

        /// <summary>[requires: v1.5]</summary>
        /// <param name="factory"></param>
        /// <param name="opcode"></param>
        /// <param name="args"></param>
        /// <param name="interface"></param>
        [CLSCompliant(false)]
        public static WaylandProxy ProxyMarshalArrayConstructor(this WaylandProxy factory, Int32 opcode, ref WaylandArgument @args, WaylandInterface @interface)
        {
            return Client.ProxyMarshalArrayConstructor(factory, opcode, ref @args, @interface);
        }

        /// <summary>[requires: v1.5]</summary>
        /// <param name="factory"></param>
        /// <param name="opcode"></param>
        /// <param name="args"></param>
        /// <param name="interface"></param>
        [CLSCompliant(false)]
        public static unsafe WaylandProxy ProxyMarshalArrayConstructor(this WaylandProxy factory, Int32 opcode, WaylandArgument* @args, WaylandInterface @interface)
        {
            return Client.ProxyMarshalArrayConstructor(factory, opcode, @args, @interface);
        }

        /// <summary>[requires: v1.5]</summary>
        /// <param name="proxy"></param>
        /// <param name="queue"></param>
        public static void ProxySetQueue(this WaylandProxy proxy, WaylandEventQueue queue)
        {
            Client.ProxySetQueue(proxy, queue);
        }

        /// <summary>[requires: v1.5]</summary>
        /// <param name="proxy"></param>
        /// <param name="user_data"></param>
        public static void ProxySetUserData(this WaylandProxy proxy, IntPtr user_data)
        {
            Client.ProxySetUserData(proxy, user_data);
        }

    }
}
