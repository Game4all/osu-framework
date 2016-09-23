﻿// Copyright (c) 2007-2016 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu-framework/master/LICENCE

using System.Drawing;
using osu.Framework.Graphics.OpenGL;

namespace osu.Framework.Graphics.Containers
{
    public class ContainerDrawNode : DrawNode
    {
        public Rectangle? MaskingRect;

        protected override void PreDraw()
        {
            base.PreDraw();

            if (MaskingRect != null)
                GLWrapper.PushScissor(MaskingRect);
        }

        protected override void PostDraw()
        {
            base.PostDraw();

            if (MaskingRect != null)
                GLWrapper.PopScissor();
        }
    }
}
