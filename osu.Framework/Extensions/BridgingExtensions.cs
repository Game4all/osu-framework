// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Platform;
using TKVector2 = osuTK.Vector2;
using SNVector2 = System.Numerics.Vector2;
using SDPoint = System.Drawing.Point;
using VPoint = Veldrid.Point;
using SDSize = System.Drawing.Size;
using VWindowState = Veldrid.WindowState;
using TKWindowState = osuTK.WindowState;

namespace osu.Framework.Extensions
{
    /// <summary>
    /// Temporary extension functions for bridging between osuTK, Veldrid, and System.Numerics
    /// </summary>
    public static class BridgingExtensions
    {
        public static TKVector2 ToOsuTK(this SNVector2 vec) =>
            new TKVector2(vec.X, vec.Y);

        public static SNVector2 ToSystemNumerics(this TKVector2 vec) =>
            new SNVector2(vec.X, vec.Y);

        public static SNVector2 ToSystemNumerics(this SDSize size) =>
            new SNVector2(size.Width, size.Height);

        public static SNVector2 ToSystemNumerics(this SDPoint point) =>
            new SNVector2(point.X, point.Y);

        public static SDSize ToSystemDrawingSize(this SNVector2 vec) =>
            new SDSize((int)vec.X, (int)vec.Y);

        public static SDPoint ToSystemDrawingPoint(this SNVector2 vec) =>
            new SDPoint((int)vec.X, (int)vec.Y);

        public static VPoint ToVeldridPoint(this SNVector2 vec) =>
            new VPoint((int)vec.X, (int)vec.Y);

        public static SNVector2 ToSystemNumerics(this VPoint point) =>
            new SNVector2(point.X, point.Y);

        public static TKWindowState ToOsuTK(this WindowState state)
        {
            switch (state)
            {
                case WindowState.Normal:
                    return TKWindowState.Normal;

                case WindowState.Fullscreen:
                case WindowState.FullscreenBorderless:
                    return TKWindowState.Fullscreen;

                case WindowState.Maximised:
                    return TKWindowState.Maximized;

                case WindowState.Minimised:
                    return TKWindowState.Minimized;
            }

            return TKWindowState.Normal;
        }

        public static VWindowState ToVeldrid(this WindowState state)
        {
            switch (state)
            {
                case WindowState.Normal:
                    return VWindowState.Normal;

                case WindowState.Minimised:
                    return VWindowState.Minimized;

                case WindowState.Maximised:
                    return VWindowState.Maximized;

                case WindowState.Fullscreen:
                    return VWindowState.FullScreen;

                case WindowState.FullscreenBorderless:
                    return VWindowState.BorderlessFullScreen;
            }

            return VWindowState.Normal;
        }

        public static WindowState ToFramework(this VWindowState state)
        {
            switch (state)
            {
                case VWindowState.Normal:
                    return WindowState.Normal;

                case VWindowState.Minimized:
                    return WindowState.Minimised;

                case VWindowState.Maximized:
                    return WindowState.Maximised;

                case VWindowState.FullScreen:
                    return WindowState.Fullscreen;

                case VWindowState.BorderlessFullScreen:
                    return WindowState.FullscreenBorderless;
            }

            return WindowState.Normal;
        }

        public static WindowState ToFramework(this TKWindowState state)
        {
            switch (state)
            {
                case TKWindowState.Normal:
                    return WindowState.Normal;

                case TKWindowState.Minimized:
                    return WindowState.Minimised;

                case TKWindowState.Maximized:
                    return WindowState.Maximised;

                case TKWindowState.Fullscreen:
                    return WindowState.Fullscreen;
            }

            return WindowState.Normal;
        }
    }
}
