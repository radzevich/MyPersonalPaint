using System;
using PaintWPF.Shapes;
using System.Windows;
using System.Windows.Ink;
using PaintWPF.Meta;
using PaintWPF.Configuration;
using System.Media;

namespace PaintWPF.Drawers
{
    class Drawer
    {
        private readonly MetaData metaData;
        //public Stroke stroke { get; private set; }

        public virtual Stroke draw()
        {
            var stroke = new Stroke(metaData.shape.GetShapePointCollection(metaData.anchor, metaData.cursor));
            return stroke;
        }

        public virtual StrokeCollection drawWithFrame(MainConfig config)
        {
            var strokeCollection = new StrokeCollection();

            var shapeStroke = new Stroke(metaData.shape.GetShapePointCollection(metaData.anchor, metaData.cursor));
            var frame = new Rectangle();
            var frameStroke = new Stroke(frame.GetShapePointCollection(metaData.anchor, metaData.cursor));

            shapeStroke.DrawingAttributes.Color = config.StrokeColor;
            shapeStroke.DrawingAttributes.Width = config.StrokeThickness;
            shapeStroke.DrawingAttributes.Height = config.StrokeThickness;
            shapeStroke.DrawingAttributes.IsHighlighter = config.StrokeHighliter;

            strokeCollection.Add(shapeStroke);
            strokeCollection.Add(frameStroke);

           /* var conf = new FrameConfig();

            frameStroke.DrawingAttributes.Color = conf.DefaultPenColor;
            frameStroke.DrawingAttributes.Width = conf.DefaultThickness;
            frameStroke.DrawingAttributes.Height = conf.DefaultThickness;
            frameStroke.DrawingAttributes.IsHighlighter = true;
            
*/
            return strokeCollection;
        }

        /*public virtual Stroke drawFrame()
        {
            var frame = new StrokeFrame(GetShapePointCollection(metaData.anchor, metaData.cursor));
        }
        */
        public Drawer(MetaData metaData)
        {
            if (metaData == null)
            {
                throw new ArgumentNullException();
            }
            this.metaData = metaData;
        }
    }
}
