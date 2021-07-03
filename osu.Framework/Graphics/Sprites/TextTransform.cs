// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

namespace osu.Framework.Graphics.Sprites
{
    /// <summary>
    /// Types of text transforms that can be applied to the text of a <see cref="SpriteText"/>.
    /// </summary>
    public enum TextTransform
    {
        /// <summary>
        /// The text is displayed as is.
        /// </summary>
        None,

        /// <summary>
        /// The text is displayed in uppercase.
        /// </summary>
        Uppercased,

        /// <summary>
        /// The text is displayed capitalized.
        /// </summary>
        Capitalized,

        /// <summary>
        /// The text is displayed in lowercase.
        /// </summary>
        Lowercase
    }
}
