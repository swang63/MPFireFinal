namespace GMap.NET.WindowsForms.Markers
{
   using System.Drawing;
   using System.Runtime.Serialization;
   using System;

#if !PocketPC
   [Serializable]
   public class GMarkerBoundAvg : GMapMarker, ISerializable

#else
   public class GMarkerBoundAvg : GMapMarker
#endif
   {
#if !PocketPC
        public static readonly Pen DefaultPen = new Pen(Brushes.Ivory, 1);
        public static readonly Pen InsidePen = new Pen(Brushes.Blue, 1);
        public static readonly SolidBrush FireBrush = new SolidBrush(Color.FromArgb(255, 255, 0, 0));
#else
         public static readonly Pen DefaultPen = new Pen(Color.Red, 1);
         public static readonly SolidBrush FireBrush = new SolidBrush(Color.FromArgb(50,255,0,0));
#endif

        [NonSerialized]
        public Pen OutPen = DefaultPen;
        public Pen InPen = InsidePen;
        public SolidBrush Brush = FireBrush;

        //ZOOM PRESETS
        private readonly float defaultZoomLevel = 16;
        private float zoomRatio = 1f;

        private float heading = 0;
        private double zoom = 0;
        private float scaleX = 0;
        private float scaleY = 0;
        int pxSize;
        bool outBound;

      public GMarkerBoundAvg(PointLatLng p, int sz, bool outside)
         : base(p)
      {
            IsHitTestVisible = false;
            pxSize = sz;
            outBound = outside;
        }

      public override void OnRender(IGraphics g)
      {
            int size = pxSize;
            //int size = 2;
            System.Drawing.Point p1 = new System.Drawing.Point(LocalPosition.X, LocalPosition.Y);
            p1.Offset(-size, -size);
            System.Drawing.Point p2 = new System.Drawing.Point(LocalPosition.X, LocalPosition.Y);
            p2.Offset(-size, size);
            System.Drawing.Point p3 = new System.Drawing.Point(LocalPosition.X, LocalPosition.Y);
            p3.Offset(size, size);
            System.Drawing.Point p4 = new System.Drawing.Point(LocalPosition.X, LocalPosition.Y);
            p4.Offset(size, -size);
            Point[] SquareShape =
                {
                    p1,
                    p2,
                    p3,
                    p4,
                };
            if (outBound)
            {
                g.DrawLine(OutPen, p1.X, p1.Y, p3.X, p3.Y);
                g.DrawLine(OutPen, p2.X, p2.Y, p4.X, p4.Y);
            }
            else 
            {
                g.DrawLine(InPen, p1.X, p1.Y, p3.X, p3.Y);
                g.DrawLine(InPen, p2.X, p2.Y, p4.X, p4.Y);
            }
            //g.FillPolygon(Brush, SquareShape);
            //g.DrawPolygon(Pen, SquareShape);
      }

      public override void Dispose()
      {
         base.Dispose();
      }

#if !PocketPC

      #region ISerializable Members

      void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
      {
         base.GetObjectData(info, context);
      }

      protected GMarkerBoundAvg(SerializationInfo info, StreamingContext context)
         : base(info, context)
      {
      }

      #endregion

#endif
   }
}
