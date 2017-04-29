using PaintWPF.SysShapes;
using System.Windows.Media;


namespace PaintWPF.Configuration
{
    class MainConfig
    {
        //Declare the delegate (if any drawer config changed).
        public delegate void configChangedEventHandler(object sender, DrawerStyle e);
        public delegate void configBackupEventHandler(object sender, DrawerStyle e);
        //Declare the event.
        public event configChangedEventHandler configChanged;
        public event configBackupEventHandler configBackup;


        //Contains primary settings (shape color, line thickness etc.).
        private DrawerStyle primaryConfig;
        //Contains configuration of focused items.
        public DrawerStyle activeDrawerStyle { get; set; }
        //Containes frame configuration.
        public DrawerStyle frameDraweStyle { get; set; }

        //Shape pattern (rectangle by default).
        private Frame setedFrame = new RectangleFrame();

        //Shape configuration properties.
        public Color StrokeColor
        {
            get { return activeDrawerStyle.Color; }
            set
            {
                activeDrawerStyle.Color = value;
                configChanged?.Invoke(this, activeDrawerStyle);
            }
        }

        public double StrokeThickness
        {
            get { return activeDrawerStyle.Thickness; }
            set
            {
                activeDrawerStyle.Thickness = value;
                configChanged?.Invoke(this, activeDrawerStyle);
            }
        } 

        public bool StrokeHighliter
        {
            get { return activeDrawerStyle.Highlighter; }
            set
            {
                activeDrawerStyle.Highlighter = value;
                configChanged?.Invoke(this, activeDrawerStyle);
            }
        }

        //Frame configuration properties.
        public Color FrameColor
        {
            get { return frameDraweStyle.Color; }
            set { frameDraweStyle.Color = value; }
        }

        public double FrameThickness
        {
            get { return frameDraweStyle.Thickness; }
            set { frameDraweStyle.Thickness = value; }
        }

        public bool FrameHighliter
        {
            get { return frameDraweStyle.Highlighter; }
            set { frameDraweStyle.Highlighter = value; }
        }

        public void backupConfig()
        {
            activeDrawerStyle = primaryConfig;
            configBackup?.Invoke(this, activeDrawerStyle);
        }

        //Constructor.
        public MainConfig()
        {
            primaryConfig = new DrawerStyle();
            //frameConfig = new DrawingAttributes();
            activeDrawerStyle = primaryConfig;
        }
    }
}
