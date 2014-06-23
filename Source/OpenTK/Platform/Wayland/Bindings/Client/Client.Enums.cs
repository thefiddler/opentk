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

using System;

namespace OpenTK.Platform.Wayland
{
    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum All : int
    {
        /// <summary>
        /// Original was WL_argb8888 = 0
        /// </summary>
        Argb8888 = ((int)0),
        /// <summary>
        /// Original was WL_bad_surface = 0
        /// </summary>
        BadSurface = ((int)0),
        /// <summary>
        /// Original was WL_default = 0
        /// </summary>
        Default = ((int)0),
        /// <summary>
        /// Original was WL_invalid_format = 0
        /// </summary>
        InvalidFormat = ((int)0),
        /// <summary>
        /// Original was WL_invalid_object = 0
        /// </summary>
        InvalidObject = ((int)0),
        /// <summary>
        /// Original was WL_invalid_scale = 0
        /// </summary>
        InvalidScale = ((int)0),
        /// <summary>
        /// Original was WL_no_keymap = 0
        /// </summary>
        NoKeymap = ((int)0),
        /// <summary>
        /// Original was WL_none = 0
        /// </summary>
        None = ((int)0),
        /// <summary>
        /// Original was WL_normal = 0
        /// </summary>
        Normal = ((int)0),
        /// <summary>
        /// Original was WL_released = 0
        /// </summary>
        Released = ((int)0),
        /// <summary>
        /// Original was WL_unknown = 0
        /// </summary>
        Unknown = ((int)0),
        /// <summary>
        /// Original was WL_vertical_scroll = 0
        /// </summary>
        VerticalScroll = ((int)0),
        /// <summary>
        /// Original was WL_current = 0x1
        /// </summary>
        Current = ((int)0x1),
        /// <summary>
        /// Original was WL_inactive = 0x1
        /// </summary>
        Inactive = ((int)0x1),
        /// <summary>
        /// Original was WL_preferred = 0x2
        /// </summary>
        Preferred = ((int)0x2),
        /// <summary>
        /// Original was WL_c8 = 0x20203843
        /// </summary>
        C8 = ((int)0x20203843),
        /// <summary>
        /// Original was WL_bgra1010102 = 0x30334142
        /// </summary>
        Bgra1010102 = ((int)0x30334142),
        /// <summary>
        /// Original was WL_rgba1010102 = 0x30334152
        /// </summary>
        Rgba1010102 = ((int)0x30334152),
        /// <summary>
        /// Original was WL_abgr2101010 = 0x30334241
        /// </summary>
        Abgr2101010 = ((int)0x30334241),
        /// <summary>
        /// Original was WL_xbgr2101010 = 0x30334258
        /// </summary>
        Xbgr2101010 = ((int)0x30334258),
        /// <summary>
        /// Original was WL_argb2101010 = 0x30335241
        /// </summary>
        Argb2101010 = ((int)0x30335241),
        /// <summary>
        /// Original was WL_xrgb2101010 = 0x30335258
        /// </summary>
        Xrgb2101010 = ((int)0x30335258),
        /// <summary>
        /// Original was WL_bgrx1010102 = 0x30335842
        /// </summary>
        Bgrx1010102 = ((int)0x30335842),
        /// <summary>
        /// Original was WL_rgbx1010102 = 0x30335852
        /// </summary>
        Rgbx1010102 = ((int)0x30335852),
        /// <summary>
        /// Original was WL_yuv411 = 0x31315559
        /// </summary>
        Yuv411 = ((int)0x31315559),
        /// <summary>
        /// Original was WL_yvu411 = 0x31315659
        /// </summary>
        Yvu411 = ((int)0x31315659),
        /// <summary>
        /// Original was WL_nv21 = 0x3132564e
        /// </summary>
        Nv21 = ((int)0x3132564e),
        /// <summary>
        /// Original was WL_nv61 = 0x3136564e
        /// </summary>
        Nv61 = ((int)0x3136564e),
        /// <summary>
        /// Original was WL_bgra4444 = 0x32314142
        /// </summary>
        Bgra4444 = ((int)0x32314142),
        /// <summary>
        /// Original was WL_rgba4444 = 0x32314152
        /// </summary>
        Rgba4444 = ((int)0x32314152),
        /// <summary>
        /// Original was WL_abgr4444 = 0x32314241
        /// </summary>
        Abgr4444 = ((int)0x32314241),
        /// <summary>
        /// Original was WL_xbgr4444 = 0x32314258
        /// </summary>
        Xbgr4444 = ((int)0x32314258),
        /// <summary>
        /// Original was WL_argb4444 = 0x32315241
        /// </summary>
        Argb4444 = ((int)0x32315241),
        /// <summary>
        /// Original was WL_xrgb4444 = 0x32315258
        /// </summary>
        Xrgb4444 = ((int)0x32315258),
        /// <summary>
        /// Original was WL_yuv420 = 0x32315559
        /// </summary>
        Yuv420 = ((int)0x32315559),
        /// <summary>
        /// Original was WL_nv12 = 0x3231564e
        /// </summary>
        Nv12 = ((int)0x3231564e),
        /// <summary>
        /// Original was WL_yvu420 = 0x32315659
        /// </summary>
        Yvu420 = ((int)0x32315659),
        /// <summary>
        /// Original was WL_bgrx4444 = 0x32315842
        /// </summary>
        Bgrx4444 = ((int)0x32315842),
        /// <summary>
        /// Original was WL_rgbx4444 = 0x32315852
        /// </summary>
        Rgbx4444 = ((int)0x32315852),
        /// <summary>
        /// Original was WL_bgra8888 = 0x34324142
        /// </summary>
        Bgra8888 = ((int)0x34324142),
        /// <summary>
        /// Original was WL_rgba8888 = 0x34324152
        /// </summary>
        Rgba8888 = ((int)0x34324152),
        /// <summary>
        /// Original was WL_abgr8888 = 0x34324241
        /// </summary>
        Abgr8888 = ((int)0x34324241),
        /// <summary>
        /// Original was WL_xbgr8888 = 0x34324258
        /// </summary>
        Xbgr8888 = ((int)0x34324258),
        /// <summary>
        /// Original was WL_bgr888 = 0x34324742
        /// </summary>
        Bgr888 = ((int)0x34324742),
        /// <summary>
        /// Original was WL_rgb888 = 0x34324752
        /// </summary>
        Rgb888 = ((int)0x34324752),
        /// <summary>
        /// Original was WL_yuv444 = 0x34325559
        /// </summary>
        Yuv444 = ((int)0x34325559),
        /// <summary>
        /// Original was WL_yvu444 = 0x34325659
        /// </summary>
        Yvu444 = ((int)0x34325659),
        /// <summary>
        /// Original was WL_bgrx8888 = 0x34325842
        /// </summary>
        Bgrx8888 = ((int)0x34325842),
        /// <summary>
        /// Original was WL_rgbx8888 = 0x34325852
        /// </summary>
        Rgbx8888 = ((int)0x34325852),
        /// <summary>
        /// Original was WL_bgra5551 = 0x35314142
        /// </summary>
        Bgra5551 = ((int)0x35314142),
        /// <summary>
        /// Original was WL_rgba5551 = 0x35314152
        /// </summary>
        Rgba5551 = ((int)0x35314152),
        /// <summary>
        /// Original was WL_abgr1555 = 0x35314241
        /// </summary>
        Abgr1555 = ((int)0x35314241),
        /// <summary>
        /// Original was WL_xbgr1555 = 0x35314258
        /// </summary>
        Xbgr1555 = ((int)0x35314258),
        /// <summary>
        /// Original was WL_argb1555 = 0x35315241
        /// </summary>
        Argb1555 = ((int)0x35315241),
        /// <summary>
        /// Original was WL_xrgb1555 = 0x35315258
        /// </summary>
        Xrgb1555 = ((int)0x35315258),
        /// <summary>
        /// Original was WL_bgrx5551 = 0x35315842
        /// </summary>
        Bgrx5551 = ((int)0x35315842),
        /// <summary>
        /// Original was WL_rgbx5551 = 0x35315852
        /// </summary>
        Rgbx5551 = ((int)0x35315852),
        /// <summary>
        /// Original was WL_bgr565 = 0x36314742
        /// </summary>
        Bgr565 = ((int)0x36314742),
        /// <summary>
        /// Original was WL_rgb565 = 0x36314752
        /// </summary>
        Rgb565 = ((int)0x36314752),
        /// <summary>
        /// Original was WL_yuv422 = 0x36315559
        /// </summary>
        Yuv422 = ((int)0x36315559),
        /// <summary>
        /// Original was WL_nv16 = 0x3631564e
        /// </summary>
        Nv16 = ((int)0x3631564e),
        /// <summary>
        /// Original was WL_yvu422 = 0x36315659
        /// </summary>
        Yvu422 = ((int)0x36315659),
        /// <summary>
        /// Original was WL_rgb332 = 0x38424752
        /// </summary>
        Rgb332 = ((int)0x38424752),
        /// <summary>
        /// Original was WL_bgr233 = 0x38524742
        /// </summary>
        Bgr233 = ((int)0x38524742),
        /// <summary>
        /// Original was WL_yvu410 = 0x39555659
        /// </summary>
        Yvu410 = ((int)0x39555659),
        /// <summary>
        /// Original was WL_yuv410 = 0x39565559
        /// </summary>
        Yuv410 = ((int)0x39565559),
        /// <summary>
        /// Original was WL_yvyu = 0x55595659
        /// </summary>
        Yvyu = ((int)0x55595659),
        /// <summary>
        /// Original was WL_ayuv = 0x56555941
        /// </summary>
        Ayuv = ((int)0x56555941),
        /// <summary>
        /// Original was WL_yuyv = 0x56595559
        /// </summary>
        Yuyv = ((int)0x56595559),
        /// <summary>
        /// Original was WL_vyuy = 0x59555956
        /// </summary>
        Vyuy = ((int)0x59555956),
        /// <summary>
        /// Original was WL_uyvy = 0x59565955
        /// </summary>
        Uyvy = ((int)0x59565955),
        /// <summary>
        /// Original was WL_horizontal_scroll = 1
        /// </summary>
        HorizontalScroll = ((int)1),
        /// <summary>
        /// Original was WL_invalid_method = 1
        /// </summary>
        InvalidMethod = ((int)1),
        /// <summary>
        /// Original was WL_invalid_stride = 1
        /// </summary>
        InvalidStride = ((int)1),
        /// <summary>
        /// Original was WL_invalid_transform = 1
        /// </summary>
        InvalidTransform = ((int)1),
        /// <summary>
        /// Original was WL_pointer = 1
        /// </summary>
        Pointer = ((int)1),
        /// <summary>
        /// Original was WL_pressed = 1
        /// </summary>
        Pressed = ((int)1),
        /// <summary>
        /// Original was WL_scale = 1
        /// </summary>
        Scale = ((int)1),
        /// <summary>
        /// Original was WL_top = 1
        /// </summary>
        Top = ((int)1),
        /// <summary>
        /// Original was WL_90 = 1
        /// </summary>
        Wl90 = ((int)1),
        /// <summary>
        /// Original was WL_xkb_v1 = 1
        /// </summary>
        XkbV1 = ((int)1),
        /// <summary>
        /// Original was WL_xrgb8888 = 1
        /// </summary>
        Xrgb8888 = ((int)1),
        /// <summary>
        /// Original was WL_bottom_right = 10
        /// </summary>
        BottomRight = ((int)10),
        /// <summary>
        /// Original was WL_bottom = 2
        /// </summary>
        Bottom = ((int)2),
        /// <summary>
        /// Original was WL_driver = 2
        /// </summary>
        Driver = ((int)2),
        /// <summary>
        /// Original was WL_horizontal_rgb = 2
        /// </summary>
        HorizontalRgb = ((int)2),
        /// <summary>
        /// Original was WL_invalid_fd = 2
        /// </summary>
        InvalidFd = ((int)2),
        /// <summary>
        /// Original was WL_keyboard = 2
        /// </summary>
        Keyboard = ((int)2),
        /// <summary>
        /// Original was WL_no_memory = 2
        /// </summary>
        NoMemory = ((int)2),
        /// <summary>
        /// Original was WL_180 = 2
        /// </summary>
        Wl180 = ((int)2),
        /// <summary>
        /// Original was WL_fill = 3
        /// </summary>
        Fill = ((int)3),
        /// <summary>
        /// Original was WL_horizontal_bgr = 3
        /// </summary>
        HorizontalBgr = ((int)3),
        /// <summary>
        /// Original was WL_270 = 3
        /// </summary>
        Wl270 = ((int)3),
        /// <summary>
        /// Original was WL_flipped = 4
        /// </summary>
        Flipped = ((int)4),
        /// <summary>
        /// Original was WL_left = 4
        /// </summary>
        Left = ((int)4),
        /// <summary>
        /// Original was WL_touch = 4
        /// </summary>
        Touch = ((int)4),
        /// <summary>
        /// Original was WL_vertical_rgb = 4
        /// </summary>
        VerticalRgb = ((int)4),
        /// <summary>
        /// Original was WL_flipped_90 = 5
        /// </summary>
        Flipped90 = ((int)5),
        /// <summary>
        /// Original was WL_top_left = 5
        /// </summary>
        TopLeft = ((int)5),
        /// <summary>
        /// Original was WL_vertical_bgr = 5
        /// </summary>
        VerticalBgr = ((int)5),
        /// <summary>
        /// Original was WL_bottom_left = 6
        /// </summary>
        BottomLeft = ((int)6),
        /// <summary>
        /// Original was WL_flipped_180 = 6
        /// </summary>
        Flipped180 = ((int)6),
        /// <summary>
        /// Original was WL_flipped_270 = 7
        /// </summary>
        Flipped270 = ((int)7),
        /// <summary>
        /// Original was WL_right = 8
        /// </summary>
        Right = ((int)8),
        /// <summary>
        /// Original was WL_top_right = 9
        /// </summary>
        TopRight = ((int)9),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum Axis : int
    {
        /// <summary>
        /// Original was WL_vertical_scroll = 0
        /// </summary>
        VerticalScroll = ((int)0),
        /// <summary>
        /// Original was WL_horizontal_scroll = 1
        /// </summary>
        HorizontalScroll = ((int)1),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ButtonState : int
    {
        /// <summary>
        /// Original was WL_released = 0
        /// </summary>
        Released = ((int)0),
        /// <summary>
        /// Original was WL_pressed = 1
        /// </summary>
        Pressed = ((int)1),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum Capability : int
    {
        /// <summary>
        /// Original was WL_pointer = 1
        /// </summary>
        Pointer = ((int)1),
        /// <summary>
        /// Original was WL_keyboard = 2
        /// </summary>
        Keyboard = ((int)2),
        /// <summary>
        /// Original was WL_touch = 4
        /// </summary>
        Touch = ((int)4),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum Error : int
    {
        /// <summary>
        /// Original was WL_bad_surface = 0
        /// </summary>
        BadSurface = ((int)0),
        /// <summary>
        /// Original was WL_invalid_format = 0
        /// </summary>
        InvalidFormat = ((int)0),
        /// <summary>
        /// Original was WL_invalid_object = 0
        /// </summary>
        InvalidObject = ((int)0),
        /// <summary>
        /// Original was WL_invalid_scale = 0
        /// </summary>
        InvalidScale = ((int)0),
        /// <summary>
        /// Original was WL_invalid_method = 1
        /// </summary>
        InvalidMethod = ((int)1),
        /// <summary>
        /// Original was WL_invalid_stride = 1
        /// </summary>
        InvalidStride = ((int)1),
        /// <summary>
        /// Original was WL_invalid_transform = 1
        /// </summary>
        InvalidTransform = ((int)1),
        /// <summary>
        /// Original was WL_invalid_fd = 2
        /// </summary>
        InvalidFd = ((int)2),
        /// <summary>
        /// Original was WL_no_memory = 2
        /// </summary>
        NoMemory = ((int)2),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ErrorCode : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum Format : int
    {
        /// <summary>
        /// Original was WL_argb8888 = 0
        /// </summary>
        Argb8888 = ((int)0),
        /// <summary>
        /// Original was WL_c8 = 0x20203843
        /// </summary>
        C8 = ((int)0x20203843),
        /// <summary>
        /// Original was WL_bgra1010102 = 0x30334142
        /// </summary>
        Bgra1010102 = ((int)0x30334142),
        /// <summary>
        /// Original was WL_rgba1010102 = 0x30334152
        /// </summary>
        Rgba1010102 = ((int)0x30334152),
        /// <summary>
        /// Original was WL_abgr2101010 = 0x30334241
        /// </summary>
        Abgr2101010 = ((int)0x30334241),
        /// <summary>
        /// Original was WL_xbgr2101010 = 0x30334258
        /// </summary>
        Xbgr2101010 = ((int)0x30334258),
        /// <summary>
        /// Original was WL_argb2101010 = 0x30335241
        /// </summary>
        Argb2101010 = ((int)0x30335241),
        /// <summary>
        /// Original was WL_xrgb2101010 = 0x30335258
        /// </summary>
        Xrgb2101010 = ((int)0x30335258),
        /// <summary>
        /// Original was WL_bgrx1010102 = 0x30335842
        /// </summary>
        Bgrx1010102 = ((int)0x30335842),
        /// <summary>
        /// Original was WL_rgbx1010102 = 0x30335852
        /// </summary>
        Rgbx1010102 = ((int)0x30335852),
        /// <summary>
        /// Original was WL_yuv411 = 0x31315559
        /// </summary>
        Yuv411 = ((int)0x31315559),
        /// <summary>
        /// Original was WL_yvu411 = 0x31315659
        /// </summary>
        Yvu411 = ((int)0x31315659),
        /// <summary>
        /// Original was WL_nv21 = 0x3132564e
        /// </summary>
        Nv21 = ((int)0x3132564e),
        /// <summary>
        /// Original was WL_nv61 = 0x3136564e
        /// </summary>
        Nv61 = ((int)0x3136564e),
        /// <summary>
        /// Original was WL_bgra4444 = 0x32314142
        /// </summary>
        Bgra4444 = ((int)0x32314142),
        /// <summary>
        /// Original was WL_rgba4444 = 0x32314152
        /// </summary>
        Rgba4444 = ((int)0x32314152),
        /// <summary>
        /// Original was WL_abgr4444 = 0x32314241
        /// </summary>
        Abgr4444 = ((int)0x32314241),
        /// <summary>
        /// Original was WL_xbgr4444 = 0x32314258
        /// </summary>
        Xbgr4444 = ((int)0x32314258),
        /// <summary>
        /// Original was WL_argb4444 = 0x32315241
        /// </summary>
        Argb4444 = ((int)0x32315241),
        /// <summary>
        /// Original was WL_xrgb4444 = 0x32315258
        /// </summary>
        Xrgb4444 = ((int)0x32315258),
        /// <summary>
        /// Original was WL_yuv420 = 0x32315559
        /// </summary>
        Yuv420 = ((int)0x32315559),
        /// <summary>
        /// Original was WL_nv12 = 0x3231564e
        /// </summary>
        Nv12 = ((int)0x3231564e),
        /// <summary>
        /// Original was WL_yvu420 = 0x32315659
        /// </summary>
        Yvu420 = ((int)0x32315659),
        /// <summary>
        /// Original was WL_bgrx4444 = 0x32315842
        /// </summary>
        Bgrx4444 = ((int)0x32315842),
        /// <summary>
        /// Original was WL_rgbx4444 = 0x32315852
        /// </summary>
        Rgbx4444 = ((int)0x32315852),
        /// <summary>
        /// Original was WL_bgra8888 = 0x34324142
        /// </summary>
        Bgra8888 = ((int)0x34324142),
        /// <summary>
        /// Original was WL_rgba8888 = 0x34324152
        /// </summary>
        Rgba8888 = ((int)0x34324152),
        /// <summary>
        /// Original was WL_abgr8888 = 0x34324241
        /// </summary>
        Abgr8888 = ((int)0x34324241),
        /// <summary>
        /// Original was WL_xbgr8888 = 0x34324258
        /// </summary>
        Xbgr8888 = ((int)0x34324258),
        /// <summary>
        /// Original was WL_bgr888 = 0x34324742
        /// </summary>
        Bgr888 = ((int)0x34324742),
        /// <summary>
        /// Original was WL_rgb888 = 0x34324752
        /// </summary>
        Rgb888 = ((int)0x34324752),
        /// <summary>
        /// Original was WL_yuv444 = 0x34325559
        /// </summary>
        Yuv444 = ((int)0x34325559),
        /// <summary>
        /// Original was WL_yvu444 = 0x34325659
        /// </summary>
        Yvu444 = ((int)0x34325659),
        /// <summary>
        /// Original was WL_bgrx8888 = 0x34325842
        /// </summary>
        Bgrx8888 = ((int)0x34325842),
        /// <summary>
        /// Original was WL_rgbx8888 = 0x34325852
        /// </summary>
        Rgbx8888 = ((int)0x34325852),
        /// <summary>
        /// Original was WL_bgra5551 = 0x35314142
        /// </summary>
        Bgra5551 = ((int)0x35314142),
        /// <summary>
        /// Original was WL_rgba5551 = 0x35314152
        /// </summary>
        Rgba5551 = ((int)0x35314152),
        /// <summary>
        /// Original was WL_abgr1555 = 0x35314241
        /// </summary>
        Abgr1555 = ((int)0x35314241),
        /// <summary>
        /// Original was WL_xbgr1555 = 0x35314258
        /// </summary>
        Xbgr1555 = ((int)0x35314258),
        /// <summary>
        /// Original was WL_argb1555 = 0x35315241
        /// </summary>
        Argb1555 = ((int)0x35315241),
        /// <summary>
        /// Original was WL_xrgb1555 = 0x35315258
        /// </summary>
        Xrgb1555 = ((int)0x35315258),
        /// <summary>
        /// Original was WL_bgrx5551 = 0x35315842
        /// </summary>
        Bgrx5551 = ((int)0x35315842),
        /// <summary>
        /// Original was WL_rgbx5551 = 0x35315852
        /// </summary>
        Rgbx5551 = ((int)0x35315852),
        /// <summary>
        /// Original was WL_bgr565 = 0x36314742
        /// </summary>
        Bgr565 = ((int)0x36314742),
        /// <summary>
        /// Original was WL_rgb565 = 0x36314752
        /// </summary>
        Rgb565 = ((int)0x36314752),
        /// <summary>
        /// Original was WL_yuv422 = 0x36315559
        /// </summary>
        Yuv422 = ((int)0x36315559),
        /// <summary>
        /// Original was WL_nv16 = 0x3631564e
        /// </summary>
        Nv16 = ((int)0x3631564e),
        /// <summary>
        /// Original was WL_yvu422 = 0x36315659
        /// </summary>
        Yvu422 = ((int)0x36315659),
        /// <summary>
        /// Original was WL_rgb332 = 0x38424752
        /// </summary>
        Rgb332 = ((int)0x38424752),
        /// <summary>
        /// Original was WL_bgr233 = 0x38524742
        /// </summary>
        Bgr233 = ((int)0x38524742),
        /// <summary>
        /// Original was WL_yvu410 = 0x39555659
        /// </summary>
        Yvu410 = ((int)0x39555659),
        /// <summary>
        /// Original was WL_yuv410 = 0x39565559
        /// </summary>
        Yuv410 = ((int)0x39565559),
        /// <summary>
        /// Original was WL_yvyu = 0x55595659
        /// </summary>
        Yvyu = ((int)0x55595659),
        /// <summary>
        /// Original was WL_ayuv = 0x56555941
        /// </summary>
        Ayuv = ((int)0x56555941),
        /// <summary>
        /// Original was WL_yuyv = 0x56595559
        /// </summary>
        Yuyv = ((int)0x56595559),
        /// <summary>
        /// Original was WL_vyuy = 0x59555956
        /// </summary>
        Vyuy = ((int)0x59555956),
        /// <summary>
        /// Original was WL_uyvy = 0x59565955
        /// </summary>
        Uyvy = ((int)0x59565955),
        /// <summary>
        /// Original was WL_xrgb8888 = 1
        /// </summary>
        Xrgb8888 = ((int)1),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum FullscreenMethod : int
    {
        /// <summary>
        /// Original was WL_default = 0
        /// </summary>
        Default = ((int)0),
        /// <summary>
        /// Original was WL_scale = 1
        /// </summary>
        Scale = ((int)1),
        /// <summary>
        /// Original was WL_driver = 2
        /// </summary>
        Driver = ((int)2),
        /// <summary>
        /// Original was WL_fill = 3
        /// </summary>
        Fill = ((int)3),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum KeymapFormat : int
    {
        /// <summary>
        /// Original was WL_no_keymap = 0
        /// </summary>
        NoKeymap = ((int)0),
        /// <summary>
        /// Original was WL_xkb_v1 = 1
        /// </summary>
        XkbV1 = ((int)1),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum KeyState : int
    {
        /// <summary>
        /// Original was WL_released = 0
        /// </summary>
        Released = ((int)0),
        /// <summary>
        /// Original was WL_pressed = 1
        /// </summary>
        Pressed = ((int)1),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum Mode : int
    {
        /// <summary>
        /// Original was WL_current = 0x1
        /// </summary>
        Current = ((int)0x1),
        /// <summary>
        /// Original was WL_preferred = 0x2
        /// </summary>
        Preferred = ((int)0x2),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum Resize : int
    {
        /// <summary>
        /// Original was WL_none = 0
        /// </summary>
        None = ((int)0),
        /// <summary>
        /// Original was WL_top = 1
        /// </summary>
        Top = ((int)1),
        /// <summary>
        /// Original was WL_bottom_right = 10
        /// </summary>
        BottomRight = ((int)10),
        /// <summary>
        /// Original was WL_bottom = 2
        /// </summary>
        Bottom = ((int)2),
        /// <summary>
        /// Original was WL_left = 4
        /// </summary>
        Left = ((int)4),
        /// <summary>
        /// Original was WL_top_left = 5
        /// </summary>
        TopLeft = ((int)5),
        /// <summary>
        /// Original was WL_bottom_left = 6
        /// </summary>
        BottomLeft = ((int)6),
        /// <summary>
        /// Original was WL_right = 8
        /// </summary>
        Right = ((int)8),
        /// <summary>
        /// Original was WL_top_right = 9
        /// </summary>
        TopRight = ((int)9),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum Subpixel : int
    {
        /// <summary>
        /// Original was WL_unknown = 0
        /// </summary>
        Unknown = ((int)0),
        /// <summary>
        /// Original was WL_none = 1
        /// </summary>
        None = ((int)1),
        /// <summary>
        /// Original was WL_horizontal_rgb = 2
        /// </summary>
        HorizontalRgb = ((int)2),
        /// <summary>
        /// Original was WL_horizontal_bgr = 3
        /// </summary>
        HorizontalBgr = ((int)3),
        /// <summary>
        /// Original was WL_vertical_rgb = 4
        /// </summary>
        VerticalRgb = ((int)4),
        /// <summary>
        /// Original was WL_vertical_bgr = 5
        /// </summary>
        VerticalBgr = ((int)5),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum Transform : int
    {
        /// <summary>
        /// Original was WL_normal = 0
        /// </summary>
        Normal = ((int)0),
        /// <summary>
        /// Original was WL_90 = 1
        /// </summary>
        Wl90 = ((int)1),
        /// <summary>
        /// Original was WL_180 = 2
        /// </summary>
        Wl180 = ((int)2),
        /// <summary>
        /// Original was WL_270 = 3
        /// </summary>
        Wl270 = ((int)3),
        /// <summary>
        /// Original was WL_flipped = 4
        /// </summary>
        Flipped = ((int)4),
        /// <summary>
        /// Original was WL_flipped_90 = 5
        /// </summary>
        Flipped90 = ((int)5),
        /// <summary>
        /// Original was WL_flipped_180 = 6
        /// </summary>
        Flipped180 = ((int)6),
        /// <summary>
        /// Original was WL_flipped_270 = 7
        /// </summary>
        Flipped270 = ((int)7),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum Transient : int
    {
        /// <summary>
        /// Original was WL_inactive = 0x1
        /// </summary>
        Inactive = ((int)0x1),
    }

}
