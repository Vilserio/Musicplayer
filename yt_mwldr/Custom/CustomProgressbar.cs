using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace yt_mwldr.Custom
{
    public enum Textposition
    {
        Left,
        Right,
        Center,
        None
    }
    class CustomProgressbar : ProgressBar
    {
        private Color channelColor = Color.LightSteelBlue;
        private Color sliderColor = Color.RoyalBlue;
        private Color foreBackColor = Color.RoyalBlue;
        private int channelHeight = 6;
        private int sliderHeight = 6;
        private Textposition showValue = Textposition.Right;

        private bool paintedBack = false;
        private bool stopPainting = false;

        public CustomProgressbar()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.ForeColor = Color.White;
        }

        public Color ChannelColor 
        {   get
            {
                return channelColor;
            }
            
            set
            { 
                channelColor = value;
                this.Invalidate();
            }
        
        }

        public Color SliderColor
        {
            get
            {
                return sliderColor;
            }

            set
            {
                sliderColor = value;
                this.Invalidate();
            }

        }

        public Color ForeBackColor
        {
            get
            {
                return foreBackColor;
            }

            set
            {
                foreBackColor = value;
                this.Invalidate();
            }

        }

        public int ChannelHeight
        {
            get
            {
                return channelHeight;
            }

            set
            {
                channelHeight = value;
                this.Invalidate();
            }

        }

        public int SliderHeight
        {
            get
            {
                return SliderHeight;
            }

            set
            {
                SliderHeight = value;
                this.Invalidate();
            }

        }
        public Textposition ShowValue
        {
            get
            {
                return showValue;
            }

            set
            {
                showValue = value;
                this.Invalidate();
            }

        }

        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public override Font Font 
        {
            get
            {
                return base.Font;
            }


            set
            {
                base.Font = value;
            }
        
        }

        public override Color ForeColor 
        { get => base.ForeColor; set => base.ForeColor = value; }

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            if (stopPainting == false)
            {
                if (paintedBack == false)
                {
                    Graphics graph = pevent.Graphics;
                    Rectangle rectChannel = new Rectangle(0, 0, this.Width, ChannelHeight);
                    using (var brushChannel = new SolidBrush(channelColor))
                    {
                        if (channelHeight >= sliderHeight)
                            rectChannel.Y = this.Height - channelHeight;
                        else rectChannel.Y = this.Height - ((channelHeight + sliderHeight) / 2);

                        graph.Clear(this.Parent.BackColor);
                        graph.FillRectangle(brushChannel, rectChannel);

                        if (this.DesignMode == false)
                            paintedBack = true;

                    }
                }
                if(this.Value == this.Maximum)  this.Value == this.Minimum)
                        paintedBack = false;
            }

        }
    }


}
