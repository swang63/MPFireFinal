namespace GMap.NET.WindowsForms.Markers
{
   using System.Drawing;
   using System.Runtime.Serialization;
   using System;

#if !PocketPC
   [Serializable]
   public class GMarkerPoint : GMapMarker, ISerializable

#else
   public class GMarkerPoint : GMapMarker
#endif
   {
#if !PocketPC
        public static readonly Pen DefaultPen = new Pen(Brushes.Red, 1);
        public static readonly SolidBrush DefaultBrush = new SolidBrush(Color.FromArgb(50, 255, 0, 0)); //RED MARKER
        public static readonly Pen Pen2 = new Pen(Brushes.Green, 1);
        public static readonly SolidBrush Brush2 = new SolidBrush(Color.FromArgb(50, 0, 255, 0)); //GREEN MARKER
#else
         public static readonly Pen DefaultPen = new Pen(Color.Red, 1);
         public static readonly SolidBrush FireBrush = new SolidBrush(Color.FromArgb(50,255,0,0));
#endif

        [NonSerialized]
        public Pen Pen = DefaultPen;
        public SolidBrush Brush = DefaultBrush;
        


        //ZOOM PRESETS
        private readonly float defaultZoomLevel = 16;
        private float zoomRatio = 1f;

        private float heading = 0;
        private double zoom = 0;
        private float scaleX = 0;
        private float scaleY = 0;
        int pxSize;
        int bColor;

      public GMarkerPoint(PointLatLng p, int sz, int brushColor)
         : base(p)
      {
            IsHitTestVisible = false;
            pxSize = sz;
            bColor = brushColor;
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

            //g.DrawLine(Pen, p1.X, p1.Y, p3.X, p3.Y);
            //g.DrawLine(Pen, p2.X, p2.Y, p4.X, p4.Y);
            if (bColor == 1)
            {
                g.FillPolygon(Brush, SquareShape);
                g.DrawPolygon(Pen, SquareShape);
            }
            else 
            {
                g.FillPolygon(Brush2, SquareShape);
                g.DrawPolygon(Pen2, SquareShape);
            }

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

      protected GMarkerPoint(SerializationInfo info, StreamingContext context)
         : base(info, context)
      {
      }

      #endregion

#endif
   }
}
