using Demo.GdMap.WindowForms.source;
using Demo.GdMap.WindowsForms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo.GdMap.WindowForms
{
   public partial class MainForm : Form
   {
      // layers
      readonly GMapOverlay top = new GMapOverlay();
      internal readonly GMapOverlay objectsLay = new GMapOverlay("objects");
      internal readonly GMapOverlay routesLay = new GMapOverlay("routes");
      internal readonly GMapOverlay markersLay = new GMapOverlay("markers"); //放置marker的图层
      BackgroundWorker flightWorker = new BackgroundWorker();      //

      Hashtable htPoints = new Hashtable();
      public MainForm()
      {

         InitializeComponent();

      }

      private void MainForm_Load(object sender, EventArgs e)
      {
         SplashScreen splash = new SplashScreen();
         splash.Show();
         if (!Stuff.PingNetwork("baidu.com"))
         {
            MainMap.Manager.Mode = AccessMode.CacheOnly;
            GMap.NET.GMaps.Instance.ImportFromGMDB(Application.StartupPath + "/NetMapCache/TileDBv5/en/Data.gmdb");
         }
         else
         {
            MainMap.CacheLocation = Application.StartupPath + "/NetMapCache";
         }

         // config map         
         MainMap.MapProvider = GMapProviders.GoogleChinaMap;
         //
         MainMap.Position = new PointLatLng(39.918913, 116.394985); //地图中心位置：北京
         MainMap.MinZoom = 2;
         MainMap.MaxZoom = 24;
         MainMap.Zoom = 10;
         MainMap.ShowCenter = false; //不显示中心十字点
         MainMap.DragButton = System.Windows.Forms.MouseButtons.Left; //左键拖拽地图

         MainMap.Overlays.Add(objectsLay);
         MainMap.Overlays.Add(routesLay);

         MainMap.Overlays.Add(markersLay);
         MainMap.MouseClick += new MouseEventHandler(mapControl_MouseClick);
         MainMap.MouseMove += new MouseEventHandler(mapControl_MouseMove);
         //MainMap.OnMarkerClick += new MarkerClick(mapControl_OnMarkerClick);

         {
            flightWorker.DoWork += new DoWorkEventHandler(flight_DoWork);
            flightWorker.ProgressChanged += new ProgressChangedEventHandler(flight_ProgressChanged);
            flightWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(flight_ProgressCompleted);
            flightWorker.WorkerSupportsCancellation = true;
            flightWorker.WorkerReportsProgress = true;
         }

         splash.Dispose();
         this.WindowState = FormWindowState.Normal;      //打开主界面

      }


      void mapControl_MouseClick(object sender, MouseEventArgs e)
      {
         if (e.Button == System.Windows.Forms.MouseButtons.Left && e.Clicks > 1)
         {

         }
      }

      // move current marker with left holding
      void mapControl_MouseMove(object sender, MouseEventArgs e)
      {
         PointLatLng pos = MainMap.FromLocalToLatLng(e.X, e.Y);
         this.statusLabelLng.Text = "lng:" + pos.Lat;
         this.statusLabelLat.Text = "lat:" + pos.Lng + "";
      }

      void mapControl_OnMarkerClick(GMapMarker item, MouseEventArgs e)
      {
         MessageBox.Show(string.Format("lng:{0},lat:{1}", item.Position.Lng, item.Position.Lat), "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }

      void flight_DoWork(object sender, DoWorkEventArgs e)
      {
         try
         {
            foreach (string key in this.htPoints.Keys)
            {
               RouteData routeData = (RouteData)this.htPoints[key];
               List<PointLatLng> lstPlay = routeData.getPoints();

               ///开始点
               GMapMarker m1 = new GMarkerGoogle(lstPlay[0], GMarkerGoogleType.green_dot);
               flightWorker.ReportProgress(10, new EventData(0, m1));

               ///路径
               GMapRoute r = new GMapRoute(lstPlay, string.Format("运行轨迹[{0},{1}]", routeData.getId(), routeData.getName()));
               r.IsHitTestVisible = true;
               r.Stroke = new Pen(Color.Red, 4);
               r.Stroke.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
               flightWorker.ReportProgress(11, new EventData(1, r));

               ///结束点
               GMapMarker m2 = new GMarkerGoogle(lstPlay[lstPlay.Count() - 1], GMarkerGoogleType.green_dot);
               flightWorker.ReportProgress(11, new EventData(0, m2));

               for (int i = 0; i < lstPlay.Count(); ++i)
               {
                  PointLatLng pot = lstPlay[i];
                  if (i > 0 && i < lstPlay.Count - 1)
                  {
                     GMapMarker m3 = new GMarkerGoogle(pot, GMarkerGoogleType.red_small);
                     m3.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                     m3.ToolTipText = string.Format("lng:{0},lat:{1}", pot.Lng, pot.Lat);
                     flightWorker.ReportProgress(11, new EventData(0, m3));
                  }
               }


               GMapMarker marker = new GMarkerGoogle(lstPlay[0], GMarkerGoogleType.green);
               marker.ToolTipMode = MarkerTooltipMode.Always;
               flightWorker.ReportProgress(50, new EventData(0, marker));
               foreach (PointLatLng pot in lstPlay)
               {
                  marker.Position = pot;
                  marker.ToolTipText = "(lat:" + pot.Lat + ";\n lng:" + pot.Lng + ")";
                  flightWorker.ReportProgress(50, new EventData(0, marker));
                  Thread.Sleep(500);
               }
            }
         }
         catch (Exception ex)
         {
            Debug.WriteLine("flight_DoWork: " + ex.ToString());
         }
         flightWorker.ReportProgress(100);
      }


      void flight_ProgressChanged(object sender, ProgressChangedEventArgs e)
      {
         // stops immediate marker/route/polygon invalidations;
         // call Refresh to perform single refresh and reset invalidation state
         MainMap.HoldInvalidation = true;
         try
         {
            EventData eventData = (EventData)e.UserState;
            if (null != eventData)
            {
               switch (eventData.getType())
               {
                  case 0:///瞄点
                     markersLay.Markers.Add((GMapMarker)eventData.getObj());
                     break;
                  case 1:///路径
                     routesLay.Routes.Add((GMapRoute)eventData.getObj());
                     break;
               }
               MainMap.Refresh();
            }
         }
         catch (Exception ex)
         {
            MessageBox.Show("incorrect coordinate format: " + ex.Message);
         }
      }

      void flight_ProgressCompleted(object sender, RunWorkerCompletedEventArgs e)
      {
         this.button1.Enabled = true;
      }

      private void button1_Click(object sender, EventArgs e)
      {
         this.button1.Enabled = false;
         routesLay.Routes.Clear();
         markersLay.Markers.Clear();
         mockPointData();
         flightWorker.RunWorkerAsync();
      }



      private void btnDownSelMap_Click(object sender, EventArgs e)
      {
         RectLatLng area = MainMap.SelectedArea;
         if (!area.IsEmpty)
         {
            for (int i = (int)MainMap.Zoom; i <= MainMap.MaxZoom; i++)
            {
               DialogResult res = MessageBox.Show("Ready ripp at Zoom = " + i + " ?", "GMap.NET", MessageBoxButtons.YesNoCancel);

               if (res == DialogResult.Yes)
               {
                  using (TilePrefetcher obj = new TilePrefetcher())
                  {
                     obj.Overlay = objectsLay; // set overlay if you want to see cache progress on the map

                     obj.Shuffle = MainMap.Manager.Mode != AccessMode.CacheOnly;

                     obj.Owner = this;
                     obj.ShowCompleteMessage = true;
                     obj.Start(area, i, MainMap.MapProvider, MainMap.Manager.Mode == AccessMode.CacheOnly ? 0 : 100, MainMap.Manager.Mode == AccessMode.CacheOnly ? 0 : 1);
                  }
               }
               else if (res == DialogResult.No)
               {
                  continue;
               }
               else if (res == DialogResult.Cancel)
               {
                  break;
               }
            }
         }
         else
         {
            MessageBox.Show(" Alt + 右键选择地图", "GMap.NET", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
         }
      }

      private void btnGoto_Click(object sender, EventArgs e)
      {
         char[] sep = { ',' };
         String[] latLng = tbLatLong.Text.Split(sep);
         markersLay.Markers.Clear();
         try
         {
            double lng = double.Parse(latLng[0], CultureInfo.InvariantCulture);
            double lat = double.Parse(latLng[1], CultureInfo.InvariantCulture);

            MainMap.Position = new PointLatLng(lat, lng);
            GMapMarker maker = new GMarkerGoogle(new PointLatLng(lat, lng), GMarkerGoogleType.green_big_go);
            markersLay.Markers.Add(maker);
         }
         catch (Exception ex)
         {
            MessageBox.Show("incorrect coordinate format: " + ex.Message);
         }
      }

      private void mockPointData()
      {
         this.htPoints.Clear();
         ////第一条线
         RouteData pd = new RouteData("0", "point1");
         pd.addPoint(new PointLatLng(39.907754, 116.398805));
         pd.addPoint(new PointLatLng(39.907919, 116.406508));
         pd.addPoint(new PointLatLng(39.907919, 116.410306));
         pd.addPoint(new PointLatLng(39.908034, 116.411229));
         pd.addPoint(new PointLatLng(39.908166, 116.415177));
         pd.addPoint(new PointLatLng(39.908182, 116.418374));
         pd.addPoint(new PointLatLng(39.908314, 116.422022));
         pd.addPoint(new PointLatLng(39.908429, 116.433974));
         pd.addPoint(new PointLatLng(39.906619, 116.435626));
         pd.addPoint(new PointLatLng(39.905861, 116.435798));
         pd.addPoint(new PointLatLng(39.903147, 116.436314));
         this.htPoints.Add(pd.getId(), pd);

         ///第二条线
         RouteData pd2 = new RouteData("1", "point2");
         pd2.addPoint(new PointLatLng(39.891486, 116.398442));
         pd2.addPoint(new PointLatLng(39.892276, 116.404364));
         pd2.addPoint(new PointLatLng(39.892276, 116.408313));
         pd2.addPoint(new PointLatLng(39.892605, 116.413892));
         pd2.addPoint(new PointLatLng(39.892605, 116.418527));
         pd2.addPoint(new PointLatLng(39.892737, 116.427539));
         pd2.addPoint(new PointLatLng(39.893659, 116.434148));
         pd2.addPoint(new PointLatLng(39.893659, 116.439641));
         pd2.addPoint(new PointLatLng(39.893132, 116.447709));
         pd2.addPoint(new PointLatLng(39.893659, 116.461013));
         pd2.addPoint(new PointLatLng(39.887534, 116.461442));
         pd2.addPoint(new PointLatLng(39.881673, 116.461356));
         pd2.addPoint(new PointLatLng(39.877326, 116.461013));
         pd2.addPoint(new PointLatLng(39.871068, 116.46024));
         pd2.addPoint(new PointLatLng(39.871224, 116.456241));
         pd2.addPoint(new PointLatLng(39.871924, 116.444439));

         this.htPoints.Add(pd2.getId(), pd2);
      }

      private void btnSelFile_Click(object sender, EventArgs e)
      {
         OpenFileDialog pOpenFileDialog = new OpenFileDialog();

         //设置对话框标题
         pOpenFileDialog.Title = "打开shp文件";
         //设置打开文件类型
         pOpenFileDialog.Filter = "所有文件（*.*）|*.*";
         //监测文件是否存在
         pOpenFileDialog.CheckFileExists = true;
         //文件打开后执行以下程序
         if (pOpenFileDialog.ShowDialog() == DialogResult.OK)
         {
            //System.IO.Path.GetExtension(pOpenFileDialog.FileName);                           //文件扩展名
            //System.IO.Path.GetFileNameWithoutExtension(pOpenFileDialog.FileName);//文件名没有扩展名
            //System.IO.Path.GetFileName(pOpenFileDialog.FileName);                          //得到文件
            //System.IO.Path.GetDirectoryName(pOpenFileDialog.FileName);                  //得到路径
            string absFile = System.IO.Path.GetFullPath(pOpenFileDialog.FileName);/// //绝对路径
            Debug.WriteLine(absFile);
            decodeFile4Test(absFile);
            routesLay.Routes.Clear();
            markersLay.Markers.Clear();
            flightWorker.RunWorkerAsync();
         }
      }

      private void decodeFile4Test(string absFile)
      {
         this.htPoints.Clear();
         string line;
         char[] sep = { ',' };
         System.IO.StreamReader file = new System.IO.StreamReader(absFile);
         while ((line = file.ReadLine()) != null)
         {
            ////记录id,lng,lat
            string[] result = line.Split(sep);
            PointLatLng pot = new PointLatLng(double.Parse(result[2]), double.Parse(result[1]));
            if (this.htPoints.ContainsKey(result[0]))
            {
               ///
               RouteData routeData = (RouteData)this.htPoints[result[0]];
               routeData.addPoint(pot);
            }
            else
            {
               RouteData routeData = new RouteData(result[0], "test");
               routeData.addPoint(pot);
               this.htPoints.Add(routeData.getId(), routeData);
            }
         }
         file.Close();

      }


      private void menuItemUseMethod_Click(object sender, EventArgs e)
      {
         UseMethodForm form = new UseMethodForm();
         form.ShowDialog();
      }

      private void menuItemAbout_Click(object sender, EventArgs e)
      {
         AboutForm form = new AboutForm();
         form.ShowDialog();
      }
   }
}
