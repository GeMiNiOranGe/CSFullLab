using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace STT5_Retarded_Paint {
    public enum ClipboardAction {
        Cut,
        Copy,
        Paste
    }

    public enum BrushToolType {
        Eraser,
        FreeBrush
    }

    public enum DrawMode {
        Outline,
        Filled,
        Mixed,
        MixedWithSolidOutline
    }

    public enum BrushType {
        SolidBrush,
        TextureBrush,
        GradiantBrush,
        HatchBrush
    }
}