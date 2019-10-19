using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Demo.GdMap.WindowsForms
{
   public partial class AboutForm: Form
   {
      public AboutForm()
      {
         InitializeComponent();
      }

      private void close_Click(object sender, EventArgs e)
      {
         Close();
      }
   }
}
