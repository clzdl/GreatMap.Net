using GMap.NET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.GdMap.WindowForms.source
{
   class RouteData
   {
      private List<PointLatLng> points = new List<PointLatLng>();
      private string id;
      private string name;

      public RouteData(string id, string name)  // 参数化构造函数
      {
         this.id = id;
         this.name = name;
      }

      public string getId() {
         return id;
      }

      public void setId(string id) {
         this.id = id;
      }

      public string getName() {
         return name;
      }

      public void setName(string name) {
         this.name = name;
      }

     
      public List<PointLatLng> getPoints() {
         return points;
      }
      public void addPoint(PointLatLng pot) {
         points.Add(pot);
      }
   }
}
