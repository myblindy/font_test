using SixLabors.Fonts;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Drawing.Processing;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;
using System.Diagnostics;
using System.Drawing;

var img = new Image<Bgra32>(100, 100);
img.Mutate(ctx => ctx.DrawText(
    new DrawingOptions
    {
        GraphicsOptions =
        {
            //AlphaCompositionMode = PixelAlphaCompositionMode.SrcOver,
            //ColorBlendingMode= PixelColorBlendingMode.Normal,
            //AntialiasSubpixelDepth = 1,
            //Antialias = false
        }
    },
    new TextOptions(SixLabors.Fonts.SystemFonts.CreateFont("Segoe UI", 10))
    {
        KerningMode = KerningMode.Normal,
        ColorFontSupport = ColorFontSupport.MicrosoftColrFormat,
        HintingMode = HintingMode.HintXY,
    }, "Assigning food to tree.", SixLabors.ImageSharp.Drawing.Processing.Brushes.Solid(SixLabors.ImageSharp.Color.White), null));
img.SaveAsPng(@"c:\temp\a.png");
Process.Start(new ProcessStartInfo(@"c:\temp\a.png") { UseShellExecute = true });

var img2 = new Bitmap(100, 100, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
using (var g = Graphics.FromImage(img2))
{
    g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
    g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
    g.DrawString("Assigning food to tree.", new System.Drawing.Font("Segoe UI", 10, GraphicsUnit.Pixel), System.Drawing.Brushes.White, new System.Drawing.PointF());
}
img2.Save(@"c:\temp\a2.png");
Process.Start(new ProcessStartInfo(@"c:\temp\a2.png") { UseShellExecute = true });