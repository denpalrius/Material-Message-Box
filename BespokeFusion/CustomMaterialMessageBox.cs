using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace BespokeFusion
{
    public class CustomMaterialMessageBox : MessageBoxWindow
    {
        public new void Show()
        {
            ShowDialog();
        }
    }
}
