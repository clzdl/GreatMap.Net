using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.GdMap.WindowForms
{
   class EventData
   {
      
      private int type;
      private object obj;
      private object paramerters;

      public EventData(int type, object obj) {
         this.type = type;
         this.obj = obj;
      }

      public int getType() {
         return type;
      }
      public void setType(int type) {
         this.type = type;
      }

      public object getObj() {
         return this.obj;
      }

      public void setObj(object obj) {
         this.obj = obj;
      }

      public object getParameters() {
         return this.paramerters;
      }

      public void setParameters(object paramerters) {
         this.paramerters = paramerters;
      }
   }
}
