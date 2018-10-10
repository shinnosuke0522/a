using System;
namespace test1
{
    public partial class Window1 : Gtk.Window
    {
        public Window1() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }
    }
}
