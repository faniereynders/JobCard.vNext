// Decompiled with JetBrains decompiler
// Type: Reytec.GUI.Controls.SoftButton
// Assembly: ReytecSoftButton, Version=1.0.3388.24394, Culture=neutral, PublicKeyToken=null
// MVID: C14E6952-5037-433A-9BF9-B0E87662D692
// Assembly location: C:\dev\Reytec JobCard\Reytec JobCard\ReytecSoftButton.dll

using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Reytec.GUI.Controls
{
  [DefaultEvent("Click")]
  public class SoftButton : UserControl
  {
    private Timer mFadeIn = new Timer();
    private Timer mFadeOut = new Timer();
    private Color mForeColor = Color.White;
    private Color mShadowColor = Color.Transparent;
    private ContentAlignment mTextAlign = ContentAlignment.MiddleCenter;
    private ContentAlignment mImageAlign = ContentAlignment.MiddleLeft;
    private Size mImageSize = new Size(24, 24);
    private int mCornerRadius = 8;
    private Color mHighlightColor = Color.White;
    private Color mButtonColor = Color.Black;
    private Color mGlowColor = Color.FromArgb(141, 189, (int) byte.MaxValue);
    private Color mGlow2Color = Color.FromArgb(141, 189, (int) byte.MaxValue);
    private Color mBaseColor = Color.Black;
    private Container components;
    private bool calledbykey;
    private SoftButton.State mButtonState;
    private int mGlowAlpha;
    private string mText;
    private Image mImage;
    private SoftButton.Style mButtonStyle;
    private Image mBackImage;
    private int gX;

    public SoftButton()
    {
      this.InitializeComponent();
      this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
      this.SetStyle(ControlStyles.DoubleBuffer, true);
      this.SetStyle(ControlStyles.ResizeRedraw, true);
      this.SetStyle(ControlStyles.Selectable, true);
      this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
      this.SetStyle(ControlStyles.UserPaint, true);
      this.BackColor = Color.Transparent;
      this.mFadeIn.Interval = 30;
      this.mFadeOut.Interval = 60;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.Name = "VistaButton";
      this.Size = new Size(100, 32);
      this.Paint += new PaintEventHandler(this.VistaButton_Paint);
      this.KeyUp += new KeyEventHandler(this.VistaButton_KeyUp);
      this.KeyDown += new KeyEventHandler(this.VistaButton_KeyDown);
      this.MouseEnter += new EventHandler(this.VistaButton_MouseEnter);
      this.MouseMove += new MouseEventHandler(this.VistaButton_MouseMove);
      this.MouseLeave += new EventHandler(this.VistaButton_MouseLeave);
      this.MouseUp += new MouseEventHandler(this.VistaButton_MouseUp);
      this.MouseDown += new MouseEventHandler(this.VistaButton_MouseDown);
      this.GotFocus += new EventHandler(this.VistaButton_MouseEnter);
      this.LostFocus += new EventHandler(this.VistaButton_MouseLeave);
      this.mFadeIn.Tick += new EventHandler(this.mFadeIn_Tick);
      this.mFadeOut.Tick += new EventHandler(this.mFadeOut_Tick);
      this.Resize += new EventHandler(this.VistaButton_Resize);
    }

    [Description("The text that is displayed on the button.")]
    [Category("Text")]
    public string ButtonText
    {
      get
      {
        return this.mText;
      }
      set
      {
        this.mText = value;
        this.Invalidate();
      }
    }

    [Browsable(true)]
    [Category("Text")]
    [DefaultValue(typeof (Color), "White")]
    [Description("The color with which the text is drawn.")]
    public override Color ForeColor
    {
      get
      {
        return this.mForeColor;
      }
      set
      {
        this.mForeColor = value;
        this.Invalidate();
      }
    }

    [Description("The shadow color with which the text is drawn.")]
    [Category("Text")]
    [Browsable(true)]
    [DefaultValue(typeof (Color), "Transparent")]
    public Color ShadowColor
    {
      get
      {
        return this.mShadowColor;
      }
      set
      {
        this.mShadowColor = value;
        this.Invalidate();
      }
    }

    [Description("The alignment of the button text that is displayed on the control.")]
    [Category("Text")]
    [DefaultValue(typeof (ContentAlignment), "MiddleCenter")]
    public ContentAlignment TextAlign
    {
      get
      {
        return this.mTextAlign;
      }
      set
      {
        this.mTextAlign = value;
        this.Invalidate();
      }
    }

    [Description("The image displayed on the button that is used to help the user identifyit's function if the text is ambiguous.")]
    [DefaultValue(null)]
    [Category("Image")]
    public Image Image
    {
      get
      {
        return this.mImage;
      }
      set
      {
        this.mImage = value;
        this.Invalidate();
      }
    }

    [Description("The alignment of the image in relation to the button.")]
    [DefaultValue(typeof (ContentAlignment), "MiddleLeft")]
    [Category("Image")]
    public ContentAlignment ImageAlign
    {
      get
      {
        return this.mImageAlign;
      }
      set
      {
        this.mImageAlign = value;
        this.Invalidate();
      }
    }

    [Category("Image")]
    [DefaultValue(typeof (Size), "24, 24")]
    [Description("The size of the image to be displayed on thebutton. This property defaults to 24x24.")]
    public Size ImageSize
    {
      get
      {
        return this.mImageSize;
      }
      set
      {
        this.mImageSize = value;
        this.Invalidate();
      }
    }

    [Description("Sets whether the button background is drawn while the mouse is outside of the client area.")]
    [Category("Appearance")]
    [DefaultValue(typeof (SoftButton.Style), "Default")]
    public SoftButton.Style ButtonStyle
    {
      get
      {
        return this.mButtonStyle;
      }
      set
      {
        this.mButtonStyle = value;
        this.Invalidate();
      }
    }

    [Description("The radius for the button corners. The greater this value is, the more 'smooth' the corners are. This property should not be greater than half of the controls height.")]
    [DefaultValue(8)]
    [Category("Appearance")]
    public int CornerRadius
    {
      get
      {
        return this.mCornerRadius;
      }
      set
      {
        this.mCornerRadius = value;
        this.Invalidate();
      }
    }

    [Category("Appearance")]
    [Description("The colour of the highlight on the top of the button.")]
    [DefaultValue(typeof (Color), "White")]
    public Color HighlightColor
    {
      get
      {
        return this.mHighlightColor;
      }
      set
      {
        this.mHighlightColor = value;
        this.Invalidate();
      }
    }

    [Description("The bottom color of the button that will be drawn over the base color.")]
    [DefaultValue(typeof (Color), "Black")]
    [Category("Appearance")]
    public Color ButtonColor
    {
      get
      {
        return this.mButtonColor;
      }
      set
      {
        this.mButtonColor = value;
        this.Invalidate();
      }
    }

    [Category("Appearance")]
    [Description("The colour that the button glows when the mouse is inside the client area.")]
    [DefaultValue(typeof (Color), "141,189,255")]
    public Color GlowColor
    {
      get
      {
        return this.mGlowColor;
      }
      set
      {
        this.mGlowColor = value;
        this.Invalidate();
      }
    }

    [Category("Appearance")]
    [DefaultValue(typeof (Color), "141,189,255")]
    [Description("The top colour that the button glows when the mouse is inside the client area.")]
    public Color Glow2Color
    {
      get
      {
        return this.mGlow2Color;
      }
      set
      {
        this.mGlow2Color = value;
        this.Invalidate();
      }
    }

    [DefaultValue(null)]
    [Description("The background image for the button, this image is drawn over the base color of the button.")]
    [Category("Appearance")]
    public Image BackImage
    {
      get
      {
        return this.mBackImage;
      }
      set
      {
        this.mBackImage = value;
        this.Invalidate();
      }
    }

    [DefaultValue(typeof (Color), "Black")]
    [Category("Appearance")]
    [Description("The backing color that the rest ofthe button is drawn. For a glassier effect set this property to Transparent.")]
    public Color BaseColor
    {
      get
      {
        return this.mBaseColor;
      }
      set
      {
        this.mBaseColor = value;
        this.Invalidate();
      }
    }

    private GraphicsPath RoundRect(
      RectangleF r,
      float r1,
      float r2,
      float r3,
      float r4)
    {
      float x = r.X;
      float y = r.Y;
      float width = r.Width;
      float height = r.Height;
      GraphicsPath graphicsPath = new GraphicsPath();
      graphicsPath.AddBezier(x, y + r1, x, y, x + r1, y, x + r1, y);
      graphicsPath.AddLine(x + r1, y, x + width - r2, y);
      graphicsPath.AddBezier(x + width - r2, y, x + width, y, x + width, y + r2, x + width, y + r2);
      graphicsPath.AddLine(x + width, y + r2, x + width, y + height - r3);
      graphicsPath.AddBezier(x + width, y + height - r3, x + width, y + height, x + width - r3, y + height, x + width - r3, y + height);
      graphicsPath.AddLine(x + width - r3, y + height, x + r4, y + height);
      graphicsPath.AddBezier(x + r4, y + height, x, y + height, x, y + height - r4, x, y + height - r4);
      graphicsPath.AddLine(x, y + height - r4, x, y + r1);
      return graphicsPath;
    }

    private StringFormat StringFormatAlignment(ContentAlignment textalign)
    {
      StringFormat stringFormat = new StringFormat();
      switch (textalign)
      {
        case ContentAlignment.TopLeft:
        case ContentAlignment.TopCenter:
        case ContentAlignment.TopRight:
          stringFormat.LineAlignment = StringAlignment.Near;
          break;
        case ContentAlignment.MiddleLeft:
        case ContentAlignment.MiddleCenter:
        case ContentAlignment.MiddleRight:
          stringFormat.LineAlignment = StringAlignment.Center;
          break;
        case ContentAlignment.BottomLeft:
        case ContentAlignment.BottomCenter:
        case ContentAlignment.BottomRight:
          stringFormat.LineAlignment = StringAlignment.Far;
          break;
      }
      switch (textalign)
      {
        case ContentAlignment.TopLeft:
        case ContentAlignment.MiddleLeft:
        case ContentAlignment.BottomLeft:
          stringFormat.Alignment = StringAlignment.Near;
          break;
        case ContentAlignment.TopCenter:
        case ContentAlignment.MiddleCenter:
        case ContentAlignment.BottomCenter:
          stringFormat.Alignment = StringAlignment.Center;
          break;
        case ContentAlignment.TopRight:
        case ContentAlignment.MiddleRight:
        case ContentAlignment.BottomRight:
          stringFormat.Alignment = StringAlignment.Far;
          break;
      }
      return stringFormat;
    }

    private void DrawOuterStroke(Graphics g)
    {
      if (this.ButtonStyle == SoftButton.Style.Flat && this.mButtonState == SoftButton.State.None)
        return;
      Rectangle clientRectangle = this.ClientRectangle;
      --clientRectangle.Width;
      --clientRectangle.Height;
      using (GraphicsPath path = this.RoundRect((RectangleF) clientRectangle, (float) this.CornerRadius, (float) this.CornerRadius, (float) this.CornerRadius, (float) this.CornerRadius))
      {
        using (Pen pen = new Pen(this.ButtonColor))
          g.DrawPath(pen, path);
      }
    }

    private void DrawInnerStroke(Graphics g)
    {
      if (this.ButtonStyle == SoftButton.Style.Flat && this.mButtonState == SoftButton.State.None)
        return;
      Rectangle clientRectangle = this.ClientRectangle;
      ++clientRectangle.X;
      ++clientRectangle.Y;
      clientRectangle.Width -= 3;
      clientRectangle.Height -= 3;
      using (GraphicsPath path = this.RoundRect((RectangleF) clientRectangle, (float) this.CornerRadius, (float) this.CornerRadius, (float) this.CornerRadius, (float) this.CornerRadius))
      {
        using (Pen pen = new Pen(this.HighlightColor))
          g.DrawPath(pen, path);
      }
    }

    private void DrawBackground(Graphics g)
    {
      Color color = this.BaseColor;
      if (this.ButtonStyle == SoftButton.Style.Flat && this.mButtonState == SoftButton.State.None)
        color = this.BackColor;
      int num = this.mButtonState == SoftButton.State.Pressed ? 204 : (int) sbyte.MaxValue;
      int alpha = this.mGlowAlpha;
      if (this.ButtonStyle != SoftButton.Style.Flat)
        alpha = num;
      Rectangle clientRectangle = this.ClientRectangle;
      --clientRectangle.Width;
      --clientRectangle.Height;
      using (GraphicsPath path = this.RoundRect((RectangleF) clientRectangle, (float) this.CornerRadius, (float) this.CornerRadius, (float) this.CornerRadius, (float) this.CornerRadius))
      {
        using (SolidBrush solidBrush = new SolidBrush(color))
          g.FillPath((Brush) solidBrush, path);
        this.SetClip(g);
        if (this.BackImage != null)
          g.DrawImage(this.BackImage, this.ClientRectangle);
        g.ResetClip();
        using (SolidBrush solidBrush = new SolidBrush(Color.FromArgb(alpha, this.ButtonColor)))
          g.FillPath((Brush) solidBrush, path);
      }
    }

    private void DrawHighlight(Graphics g)
    {
      if (this.mButtonState == SoftButton.State.Pressed)
        return;
      int num = this.mButtonState == SoftButton.State.Pressed ? 60 : 150;
      int alpha = this.mGlowAlpha;
      if (this.ButtonStyle != SoftButton.Style.Flat)
        alpha = num;
      using (GraphicsPath path = this.RoundRect((RectangleF) new Rectangle(0, 0, this.Width, this.Height / 2), (float) this.CornerRadius, (float) this.CornerRadius, 0.0f, 0.0f))
      {
        using (LinearGradientBrush linearGradientBrush = new LinearGradientBrush(path.GetBounds(), Color.FromArgb(alpha, this.HighlightColor), Color.FromArgb(alpha / 3, this.HighlightColor), LinearGradientMode.Vertical))
          g.FillPath((Brush) linearGradientBrush, path);
      }
    }

    private void DrawGlow(Graphics g)
    {
      if (this.mButtonState == SoftButton.State.Pressed)
        return;
      this.SetClip(g);
      using (GraphicsPath path = new GraphicsPath())
      {
        path.AddEllipse(this.gX - this.Width / 2, this.Height / 2 - 10, this.Width + 11, this.Height + 11);
        using (PathGradientBrush pathGradientBrush = new PathGradientBrush(path))
        {
          pathGradientBrush.CenterColor = Color.FromArgb(this.mGlowAlpha, this.GlowColor);
          pathGradientBrush.SurroundColors = new Color[1]
          {
            Color.FromArgb(0, this.GlowColor)
          };
          if (this.GlowColor != Color.Transparent)
            g.FillPath((Brush) pathGradientBrush, path);
        }
      }
      using (GraphicsPath path = new GraphicsPath())
      {
        path.AddEllipse(this.gX * -1 + this.Width / 2, this.Height / 2 * -1, this.Width + 11, this.Height + 11);
        using (PathGradientBrush pathGradientBrush = new PathGradientBrush(path))
        {
          pathGradientBrush.CenterColor = Color.FromArgb(this.mGlowAlpha, this.Glow2Color);
          pathGradientBrush.SurroundColors = new Color[1]
          {
            Color.FromArgb(0, this.GlowColor)
          };
          if (this.Glow2Color != Color.Transparent)
            g.FillPath((Brush) pathGradientBrush, path);
        }
      }
      g.ResetClip();
    }

    private void DrawText(Graphics g)
    {
      StringFormat format = this.StringFormatAlignment(this.TextAlign);
      Rectangle rectangle1 = new Rectangle(9, 9, this.Width - 17, this.Height - 17);
      if (this.Enabled)
        g.DrawString(this.ButtonText, this.Font, (Brush) new SolidBrush(this.ShadowColor), (RectangleF) rectangle1, format);
      else
        g.DrawString(this.ButtonText, this.Font, (Brush) new SolidBrush(this.HighlightColor), (RectangleF) rectangle1, format);
      Rectangle rectangle2 = new Rectangle(8, 8, this.Width - 17, this.Height - 17);
      if (this.Enabled)
        g.DrawString(this.ButtonText, this.Font, (Brush) new SolidBrush(this.ForeColor), (RectangleF) rectangle2, format);
      else
        g.DrawString(this.ButtonText, this.Font, (Brush) new SolidBrush(this.ButtonColor), (RectangleF) rectangle2, format);
    }

    private void DrawImage(Graphics g)
    {
      if (this.Image == null)
        return;
      Rectangle rectangle = new Rectangle(8, 8, this.ImageSize.Width, this.ImageSize.Height);
      switch (this.ImageAlign)
      {
        case ContentAlignment.TopCenter:
          rectangle = new Rectangle(this.Width / 2 - this.ImageSize.Width / 2, 8, this.ImageSize.Width, this.ImageSize.Height);
          break;
        case ContentAlignment.TopRight:
          rectangle = new Rectangle(this.Width - 8 - this.ImageSize.Width, 8, this.ImageSize.Width, this.ImageSize.Height);
          break;
        case ContentAlignment.MiddleLeft:
          rectangle = new Rectangle(8, this.Height / 2 - this.ImageSize.Height / 2, this.ImageSize.Width, this.ImageSize.Height);
          break;
        case ContentAlignment.MiddleCenter:
          rectangle = new Rectangle(this.Width / 2 - this.ImageSize.Width / 2, this.Height / 2 - this.ImageSize.Height / 2, this.ImageSize.Width, this.ImageSize.Height);
          break;
        case ContentAlignment.MiddleRight:
          rectangle = new Rectangle(this.Width - 8 - this.ImageSize.Width, this.Height / 2 - this.ImageSize.Height / 2, this.ImageSize.Width, this.ImageSize.Height);
          break;
        case ContentAlignment.BottomLeft:
          rectangle = new Rectangle(8, this.Height - 8 - this.ImageSize.Height, this.ImageSize.Width, this.ImageSize.Height);
          break;
        case ContentAlignment.BottomCenter:
          rectangle = new Rectangle(this.Width / 2 - this.ImageSize.Width / 2, this.Height - 8 - this.ImageSize.Height, this.ImageSize.Width, this.ImageSize.Height);
          break;
        case ContentAlignment.BottomRight:
          rectangle = new Rectangle(this.Width - 8 - this.ImageSize.Width, this.Height - 8 - this.ImageSize.Height, this.ImageSize.Width, this.ImageSize.Height);
          break;
      }
      if (!this.Enabled)
      {
        ColorMatrix newColorMatrix = new ColorMatrix();
        newColorMatrix.Matrix33 = 0.3f;
        ImageAttributes imageAttr = new ImageAttributes();
        imageAttr.SetColorMatrix(newColorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
        g.DrawImage(this.Image, rectangle, 0, 0, this.Image.Width, this.Image.Height, GraphicsUnit.Pixel, imageAttr);
      }
      else
        g.DrawImage(this.Image, rectangle);
    }

    private void SetClip(Graphics g)
    {
      Rectangle clientRectangle = this.ClientRectangle;
      ++clientRectangle.X;
      ++clientRectangle.Y;
      clientRectangle.Width -= 3;
      clientRectangle.Height -= 3;
      using (GraphicsPath path = this.RoundRect((RectangleF) clientRectangle, (float) this.CornerRadius, (float) this.CornerRadius, (float) this.CornerRadius, (float) this.CornerRadius))
        g.SetClip(path);
    }

    private void VistaButton_Paint(object sender, PaintEventArgs e)
    {
      e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
      e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
      this.DrawBackground(e.Graphics);
      this.DrawHighlight(e.Graphics);
      this.DrawGlow(e.Graphics);
      this.DrawImage(e.Graphics);
      this.DrawText(e.Graphics);
      this.DrawOuterStroke(e.Graphics);
      this.DrawInnerStroke(e.Graphics);
    }

    private void VistaButton_Resize(object sender, EventArgs e)
    {
      Rectangle clientRectangle = this.ClientRectangle;
      --clientRectangle.X;
      --clientRectangle.Y;
      clientRectangle.Width += 2;
      clientRectangle.Height += 2;
      using (GraphicsPath path = this.RoundRect((RectangleF) clientRectangle, (float) this.CornerRadius, (float) this.CornerRadius, (float) this.CornerRadius, (float) this.CornerRadius))
        this.Region = new Region(path);
    }

    private void VistaButton_MouseEnter(object sender, EventArgs e)
    {
      this.mButtonState = SoftButton.State.Hover;
      this.mFadeOut.Stop();
      this.mFadeIn.Start();
    }

    private void VistaButton_MouseMove(object sender, MouseEventArgs e)
    {
      if (this.mButtonState == SoftButton.State.Pressed)
        return;
      this.mButtonState = SoftButton.State.Hover;
      this.gX = e.X;
      this.mFadeOut.Stop();
      this.mFadeIn.Start();
    }

    private void VistaButton_MouseLeave(object sender, EventArgs e)
    {
      this.mButtonState = SoftButton.State.None;
      this.mFadeIn.Stop();
      this.mFadeOut.Start();
    }

    private void VistaButton_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      this.mButtonState = SoftButton.State.Pressed;
      if (this.mButtonStyle != SoftButton.Style.Flat)
        this.mGlowAlpha = (int) byte.MaxValue;
      this.mFadeIn.Stop();
      this.mFadeOut.Stop();
      this.Invalidate();
    }

    private void mFadeIn_Tick(object sender, EventArgs e)
    {
      int buttonStyle = (int) this.ButtonStyle;
      if (this.mGlowAlpha + 30 >= (int) byte.MaxValue)
      {
        this.mGlowAlpha = (int) byte.MaxValue;
        this.mFadeIn.Stop();
      }
      else
        this.mGlowAlpha += 30;
      this.Invalidate();
    }

    private void mFadeOut_Tick(object sender, EventArgs e)
    {
      if (this.mGlowAlpha - 30 <= 0)
      {
        this.mGlowAlpha = 0;
        this.mFadeOut.Stop();
      }
      else
        this.mGlowAlpha -= 30;
      this.Invalidate();
    }

    private void VistaButton_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return || !this.TabStop)
        return;
      MouseEventArgs e1 = new MouseEventArgs(MouseButtons.Left, 0, 0, 0, 0);
      this.VistaButton_MouseDown(sender, e1);
    }

    private void VistaButton_KeyUp(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return || !this.TabStop)
        return;
      MouseEventArgs e1 = new MouseEventArgs(MouseButtons.Left, 0, 0, 0, 0);
      this.calledbykey = true;
      this.VistaButton_MouseUp(sender, e1);
    }

    private void VistaButton_MouseUp(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      this.mButtonState = SoftButton.State.None;
      this.mFadeIn.Stop();
      this.mFadeOut.Stop();
      this.Invalidate();
      if (!this.calledbykey)
        return;
      this.calledbykey = false;
      this.OnClick(EventArgs.Empty);
    }

    private void VistaButton_Load(object sender, EventArgs e)
    {
    }

    private enum State
    {
      None,
      Hover,
      Pressed,
    }

    public enum Style
    {
      Default,
      Flat,
    }
  }
}
