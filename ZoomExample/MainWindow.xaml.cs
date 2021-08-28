using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using SharpVectors;
using SharpVectors.Converters;
using Syncfusion.UI.Xaml.Diagram;

namespace ZoomExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Point? lastCenterPositionOnTarget;
        Point? lastMousePositionOnTarget;
        Point? lastDragPoint;

        public MainWindow()
        {
            InitializeComponent();

            scrollViewer.ScrollChanged += OnScrollViewerScrollChanged;
            scrollViewer.MouseLeftButtonUp += OnMouseLeftButtonUp;
            scrollViewer.PreviewMouseLeftButtonUp += OnMouseLeftButtonUp;
            scrollViewer.PreviewMouseWheel += OnPreviewMouseWheel;

            scrollViewer.PreviewMouseLeftButtonDown += OnMouseLeftButtonDown;
            scrollViewer.MouseMove += OnMouseMove;

            slider.ValueChanged += OnSliderValueChanged;
        }
        SvgViewbox dragObj = null;
        Point offset;
       


        private void CanvasImages_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

            dragObj = null;
            this.canvasss.ReleaseMouseCapture();
           
        }
        private void CanvasImages_PreviewMouseMove(object sender, MouseEventArgs e)
        {

            if (dragObj == null)
            {
                return;
            }
            else
            {
                var position = e.GetPosition(sender as IInputElement);
               // MessageBox.Show(position.X + " " + position.Y);
                Canvas.SetTop(dragObj, position.Y - this.offset.Y);
                Canvas.SetLeft(dragObj, position.X - this.offset.X);
            }

            
        }



        private void UserControl_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void UserControl_PreviewGiveFeedback(object sender, GiveFeedbackEventArgs e)
        {
       
        }

        private void OPEN_Click(object sender, RoutedEventArgs e)
        {

            SvgViewbox svg = new SvgViewbox();
            string path = "C:/Users/Bytes-04/Music/FlowChartUI/ZoomExample/Resources/magnet.svg";
            svg.Source = new System.Uri(path);
            svg.AutoSize = true;
            svg.AllowDrop = true;
            svg.OptimizePath = false;
            svg.TextAsGeometry = true;
            Canvas.SetTop(svg, 220);
            Canvas.SetLeft(svg, 469);
            // svg.MouseMove += OnMouseMove;
            svg.MouseLeftButtonDown += Img_MouseLeftButtonDown;
            svg.MouseRightButtonDown += Img_MouseRightButtonDown;
            //svg.PreviewMouseDown += Img_MouseLeftButtonDown;
            svg.AutoSize = true;
          



            canvasss.Children.Add(svg);
            


        }

        private void Img_MouseRightButtonDown(object sender, MouseEventArgs e)
        {
            SvgViewbox svgLine = sender as SvgViewbox;
            var position = e.GetPosition(svgLine);

            MessageBox.Show(position.X + " " + position.Y);
            Path myPath = new Path();
            myPath.Stroke = System.Windows.Media.Brushes.Black;
            myPath.Fill = System.Windows.Media.Brushes.MediumSlateBlue;
            myPath.StrokeThickness = 4;
            myPath.HorizontalAlignment = HorizontalAlignment.Stretch;
            myPath.VerticalAlignment = VerticalAlignment.Stretch;

            /*    PathFigure myPathFigure = new PathFigure();
                myPathFigure.StartPoint = position;

                LineSegment myLineSegment = new LineSegment();
                myLineSegment.Point = new Point(5, 5);

                PathSegmentCollection myPathSegmentCollection = new PathSegmentCollection();
                myPathSegmentCollection.Add(myLineSegment);

                myPathFigure.Segments = myPathSegmentCollection;

                PathFigureCollection myPathFigureCollection = new PathFigureCollection();
                myPathFigureCollection.Add(myPathFigure);*/

            LineGeometry myLineGeometry = new LineGeometry();
            myLineGeometry.StartPoint = new Point(position.X, position.Y);
            myLineGeometry.EndPoint = new Point(position.X + 50, position.Y + 50);



            //  PathGeometry pathGeometry = new PathGeometry();
            // pathGeometry.Figures = myPathFigureCollection;


            myPath.Data = myLineGeometry;
            
            Canvas.SetTop(myPath, 220);
            Canvas.SetLeft(myPath, 469);
            canvasss.Children.Add(myPath);
            var pop1 = new Popup();
            pop1.Child = new TextBox { Text = "Type", Background = Brushes.White };
            pop1.Placement = PlacementMode.MousePoint;
            pop1.StaysOpen = false;
            pop1.Width = 130;
            pop1.Height = 20;
            pop1.IsOpen = true;
            pop1.StaysOpen = true;

        }
        
        private void Img_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            dragObj = sender as SvgViewbox;
            this.offset = e.GetPosition(this.canvasss);
            this.offset.Y -= Canvas.GetTop(dragObj);
            this.offset.X -= Canvas.GetLeft(dragObj);
            this.canvasss.CaptureMouse();
            //popup1.IsOpen = true;
            //popup1.StaysOpen = false;
            var pop1 = new Popup();
            pop1.Child = new TextBox { Text = "Type", Background = Brushes.White };
            pop1.Placement = PlacementMode.MousePoint;
            pop1.StaysOpen = false;
            pop1.Width = 130;
            pop1.Height = 20;
            pop1.IsOpen = true;
            pop1.StaysOpen = true;
           

           


        }
        

        private void OPEN_Flag(object sender, RoutedEventArgs e)
        {

            SvgViewbox svg = new SvgViewbox();
            string path = "C:/Users/Bytes-04/Music/FlowChartUI/ZoomExample/Resources/flag.svg";
            svg.Source = new System.Uri(path);
            svg.AutoSize = true;
            svg.AllowDrop = true;
            svg.OptimizePath = false;
            svg.TextAsGeometry = true;
            Canvas.SetTop(svg, 220);
            Canvas.SetLeft(svg, 469);
            // svg.MouseMove += OnMouseMove;
            svg.MouseLeftButtonDown += Img_MouseLeftButtonDown;
            svg.MouseRightButtonDown += Img_MouseRightButtonDown;
            //svg.PreviewMouseDown += Img_MouseLeftButtonDown;
            svg.AutoSize = true;
            

            canvasss.Children.Add(svg);



        }

        private void OPEN_Treasure(object sender, RoutedEventArgs e)
        {

            SvgViewbox svg = new SvgViewbox();
            string path = "C:/Users/Bytes-04/Music/FlowChartUI/ZoomExample/Resources/treasure.svg";
            svg.Source = new System.Uri(path);
            svg.AutoSize = true;
            svg.AllowDrop = true;
            svg.OptimizePath = false;
            svg.TextAsGeometry = true;
            Canvas.SetTop(svg, 220);
            Canvas.SetLeft(svg, 469);
            // svg.MouseMove += OnMouseMove;
            svg.MouseLeftButtonDown += Img_MouseLeftButtonDown;
            svg.MouseRightButtonDown += Img_MouseRightButtonDown;
            //svg.PreviewMouseDown += Img_MouseLeftButtonDown;
            svg.AutoSize = true;


            canvasss.Children.Add(svg);


        }

        private void OPEN_Speaker(object sender, RoutedEventArgs e)
        {

            SvgViewbox svg = new SvgViewbox();
            string path = "C:/Users/Bytes-04/Music/FlowChartUI/ZoomExample/Resources/speaker.svg";
            svg.Source = new System.Uri(path);
            svg.AutoSize = true;
            svg.AllowDrop = true;
            svg.OptimizePath = false;
            svg.TextAsGeometry = true;
            Canvas.SetTop(svg, 220);
            Canvas.SetLeft(svg, 469);
            // svg.MouseMove += OnMouseMove;
            svg.MouseLeftButtonDown += Img_MouseLeftButtonDown;
            svg.MouseRightButtonDown += Img_MouseRightButtonDown;
            //svg.PreviewMouseDown += Img_MouseLeftButtonDown;
            svg.AutoSize = true;


            canvasss.Children.Add(svg);

        }


        private void OPEN_Backtrack(object sender, RoutedEventArgs e)
        {

            SvgViewbox svg = new SvgViewbox();
            string path = "C:/Users/Bytes-04/Music/FlowChartUI/ZoomExample/Resources/backtrack.svg";
            svg.Source = new System.Uri(path);
            svg.AutoSize = true;
            svg.AllowDrop = true;
            svg.OptimizePath = false;
            svg.TextAsGeometry = true;
            Canvas.SetTop(svg, 220);
            Canvas.SetLeft(svg, 469);
            // svg.MouseMove += OnMouseMove;
            svg.MouseLeftButtonDown += Img_MouseLeftButtonDown;
            svg.MouseRightButtonDown += Img_MouseRightButtonDown;
            //svg.PreviewMouseDown += Img_MouseLeftButtonDown;
            svg.AutoSize = true;


            canvasss.Children.Add(svg);


        }

        private void OPEN_Output(object sender, RoutedEventArgs e)
        {

            SvgViewbox svg = new SvgViewbox();
            string path = "C:/Users/Bytes-04/Music/FlowChartUI/ZoomExample/Resources/output.svg";
            svg.Source = new System.Uri(path);
            svg.AutoSize = true;
            svg.AllowDrop = true;
            svg.OptimizePath = false;
            svg.TextAsGeometry = true;
            Canvas.SetTop(svg, 220);
            Canvas.SetLeft(svg, 469);
            // svg.MouseMove += OnMouseMove;
            svg.MouseLeftButtonDown += Img_MouseLeftButtonDown;
            svg.MouseRightButtonDown += Img_MouseRightButtonDown;
            //svg.PreviewMouseDown += Img_MouseLeftButtonDown;
            svg.AutoSize = true;


            canvasss.Children.Add(svg);

        }

        private void OPEN_Homophone(object sender, RoutedEventArgs e)
        {

            SvgViewbox svg = new SvgViewbox();
            string path = "C:/Users/Bytes-04/Music/FlowChartUI/ZoomExample/Resources/homophone.svg";
            svg.Source = new System.Uri(path);
            svg.AutoSize = true;
            svg.AllowDrop = true;
            svg.OptimizePath = false;
            svg.TextAsGeometry = true;
            Canvas.SetTop(svg, 220);
            Canvas.SetLeft(svg, 469);
            // svg.MouseMove += OnMouseMove;
            svg.MouseLeftButtonDown += Img_MouseLeftButtonDown;
            svg.MouseRightButtonDown += Img_MouseRightButtonDown;
            //svg.PreviewMouseDown += Img_MouseLeftButtonDown;
            svg.AutoSize = true;


            canvasss.Children.Add(svg);


        }

        private void OPEN_Bucket(object sender, RoutedEventArgs e)
        {

            SvgViewbox svg = new SvgViewbox();
            string path = "C:/Users/Bytes-04/Music/FlowChartUI/ZoomExample/Resources/bucket.svg";
            svg.Source = new System.Uri(path);
            svg.AutoSize = true;
            svg.AllowDrop = true;
            svg.OptimizePath = false;
            svg.TextAsGeometry = true;
            Canvas.SetTop(svg, 220);
            Canvas.SetLeft(svg, 469);
            // svg.MouseMove += OnMouseMove;
            svg.MouseLeftButtonDown += Img_MouseLeftButtonDown;
            svg.MouseRightButtonDown += Img_MouseRightButtonDown;
            //svg.PreviewMouseDown += Img_MouseLeftButtonDown;
            svg.AutoSize = true;


            canvasss.Children.Add(svg);



        }

        private void OPEN_Scale(object sender, RoutedEventArgs e)
        {

            SvgViewbox svg = new SvgViewbox();
            string path = "C:/Users/Bytes-04/Music/FlowChartUI/ZoomExample/Resources/scale.svg";
            svg.Source = new System.Uri(path);
            svg.AutoSize = true;
            svg.AllowDrop = true;
            svg.OptimizePath = false;
            svg.TextAsGeometry = true;
            Canvas.SetTop(svg, 220);
            Canvas.SetLeft(svg, 469);
            // svg.MouseMove += OnMouseMove;
            svg.MouseLeftButtonDown += Img_MouseLeftButtonDown;
            svg.MouseRightButtonDown += Img_MouseRightButtonDown;
            //svg.PreviewMouseDown += Img_MouseLeftButtonDown;
            svg.AutoSize = true;


            canvasss.Children.Add(svg);


        }


        void OnMouseMove(object sender, MouseEventArgs e)
        {
           /* if (lastDragPoint.HasValue)
            {
                Point posNow = e.GetPosition(scrollViewer);

                double dX = posNow.X - lastDragPoint.Value.X;
                double dY = posNow.Y - lastDragPoint.Value.Y;

                lastDragPoint = posNow;

                scrollViewer.ScrollToHorizontalOffset(scrollViewer.HorizontalOffset - dX);
                scrollViewer.ScrollToVerticalOffset(scrollViewer.VerticalOffset - dY);
            }*/
        }

        void OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
          /*  var mousePos = e.GetPosition(scrollViewer);
            if (mousePos.X <= scrollViewer.ViewportWidth && mousePos.Y < scrollViewer.ViewportHeight) //make sure we still can use the scrollbars
            {
                scrollViewer.Cursor = Cursors.SizeAll;
                lastDragPoint = mousePos;
                Mouse.Capture(scrollViewer);
            }*/
        }

        void OnPreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            lastMousePositionOnTarget = Mouse.GetPosition(grid);

            if (e.Delta > 0)
            {
                slider.Value += 1;
            }
            if (e.Delta < 0)
            {
                slider.Value -= 1;
            }

            e.Handled = true;
        }

        void OnMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            scrollViewer.Cursor = Cursors.Arrow;
            scrollViewer.ReleaseMouseCapture();
            lastDragPoint = null;
        }

        void OnSliderValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            scaleTransform.ScaleX = e.NewValue;
            scaleTransform.ScaleY = e.NewValue;

            var centerOfViewport = new Point(scrollViewer.ViewportWidth/2, scrollViewer.ViewportHeight/2);
            lastCenterPositionOnTarget = scrollViewer.TranslatePoint(centerOfViewport, grid);
        }

        void OnScrollViewerScrollChanged(object sender, ScrollChangedEventArgs e)
        {
            if (e.ExtentHeightChange != 0 || e.ExtentWidthChange != 0)
            {
                Point? targetBefore = null;
                Point? targetNow = null;

                if (!lastMousePositionOnTarget.HasValue)
                {
                    if (lastCenterPositionOnTarget.HasValue)
                    {
                        var centerOfViewport = new Point(scrollViewer.ViewportWidth/2, scrollViewer.ViewportHeight/2);
                        Point centerOfTargetNow = scrollViewer.TranslatePoint(centerOfViewport, grid);

                        targetBefore = lastCenterPositionOnTarget;
                        targetNow = centerOfTargetNow;
                    }
                }
                else
                {
                    targetBefore = lastMousePositionOnTarget;
                    targetNow = Mouse.GetPosition(grid);

                    lastMousePositionOnTarget = null;
                }

                if (targetBefore.HasValue)
                {
                    double dXInTargetPixels = targetNow.Value.X - targetBefore.Value.X;
                    double dYInTargetPixels = targetNow.Value.Y - targetBefore.Value.Y;

                    double multiplicatorX = e.ExtentWidth/grid.Width;
                    double multiplicatorY = e.ExtentHeight/grid.Height;

                    double newOffsetX = scrollViewer.HorizontalOffset - dXInTargetPixels*multiplicatorX;
                    double newOffsetY = scrollViewer.VerticalOffset - dYInTargetPixels*multiplicatorY;

                    if (double.IsNaN(newOffsetX) || double.IsNaN(newOffsetY))
                    {
                        return;
                    }

                    scrollViewer.ScrollToHorizontalOffset(newOffsetX);
                    scrollViewer.ScrollToVerticalOffset(newOffsetY);
                }
            }
        }
    }
}