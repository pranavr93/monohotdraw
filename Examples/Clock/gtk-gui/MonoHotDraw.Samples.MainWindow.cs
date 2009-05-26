// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MonoHotDraw.Samples {
    
    
    public partial class MainWindow {
        
        private Gtk.UIManager UIManager;
        
        private Gtk.Action FiguresAction;
        
        private Gtk.Action AddAnalogClockAction;
        
        private Gtk.Action AddDigitalClockAction;
        
        private Gtk.VBox vbox1;
        
        private Gtk.MenuBar menubar1;
        
        private Gtk.ScrolledWindow scrolledwindow1;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget MonoHotDraw.Samples.MainWindow
            this.UIManager = new Gtk.UIManager();
            Gtk.ActionGroup w1 = new Gtk.ActionGroup("Default");
            this.FiguresAction = new Gtk.Action("FiguresAction", Mono.Unix.Catalog.GetString("Figures"), null, null);
            this.FiguresAction.ShortLabel = Mono.Unix.Catalog.GetString("Figures");
            w1.Add(this.FiguresAction, null);
            this.AddAnalogClockAction = new Gtk.Action("AddAnalogClockAction", Mono.Unix.Catalog.GetString("Add Analog Clock"), null, null);
            this.AddAnalogClockAction.ShortLabel = Mono.Unix.Catalog.GetString("Add Analog Clock");
            w1.Add(this.AddAnalogClockAction, null);
            this.AddDigitalClockAction = new Gtk.Action("AddDigitalClockAction", Mono.Unix.Catalog.GetString("Add Digital Clock"), null, null);
            this.AddDigitalClockAction.ShortLabel = Mono.Unix.Catalog.GetString("Add Digital Clock");
            w1.Add(this.AddDigitalClockAction, null);
            this.UIManager.InsertActionGroup(w1, 0);
            this.AddAccelGroup(this.UIManager.AccelGroup);
            this.Name = "MonoHotDraw.Samples.MainWindow";
            this.Title = Mono.Unix.Catalog.GetString("MainWindow");
            this.WindowPosition = ((Gtk.WindowPosition)(4));
            // Container child MonoHotDraw.Samples.MainWindow.Gtk.Container+ContainerChild
            this.vbox1 = new Gtk.VBox();
            this.vbox1.Name = "vbox1";
            this.vbox1.Spacing = 6;
            // Container child vbox1.Gtk.Box+BoxChild
            this.UIManager.AddUiFromString("<ui><menubar name='menubar1'><menu name='FiguresAction' action='FiguresAction'><menuitem name='AddAnalogClockAction' action='AddAnalogClockAction'/><menuitem name='AddDigitalClockAction' action='AddDigitalClockAction'/></menu></menubar></ui>");
            this.menubar1 = ((Gtk.MenuBar)(this.UIManager.GetWidget("/menubar1")));
            this.menubar1.Name = "menubar1";
            this.vbox1.Add(this.menubar1);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.vbox1[this.menubar1]));
            w2.Position = 0;
            w2.Expand = false;
            w2.Fill = false;
            // Container child vbox1.Gtk.Box+BoxChild
            this.scrolledwindow1 = new Gtk.ScrolledWindow();
            this.scrolledwindow1.CanFocus = true;
            this.scrolledwindow1.Name = "scrolledwindow1";
            this.scrolledwindow1.ShadowType = ((Gtk.ShadowType)(1));
            this.vbox1.Add(this.scrolledwindow1);
            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.vbox1[this.scrolledwindow1]));
            w3.Position = 1;
            this.Add(this.vbox1);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 400;
            this.DefaultHeight = 300;
            this.Show();
            this.AddAnalogClockAction.Activated += new System.EventHandler(this.OnAddAnalogClockActionActivated);
            this.AddDigitalClockAction.Activated += new System.EventHandler(this.OnAddDigitalClockActionActivated);
        }
    }
}
