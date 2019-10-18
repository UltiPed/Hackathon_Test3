using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    public partial class MenuShell : Shell
    {
        public MenuShell()
        {
            InitializeComponent();
            var a = GetBackgroundColor(this);
            var b = GetDisabledColor(this);
            var c = GetForegroundColor(this);
            var d = GetTabBarBackgroundColor(this);
            var e = GetTabBarDisabledColor(this);
            var f = GetTabBarForegroundColor(this);
            var g = GetTabBarTitleColor(this);
            var h = GetTabBarUnselectedColor(this);
        }
    }
}