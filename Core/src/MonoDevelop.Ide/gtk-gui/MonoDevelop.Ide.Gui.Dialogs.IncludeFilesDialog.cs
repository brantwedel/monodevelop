// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.42
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MonoDevelop.Ide.Gui.Dialogs {
    
    
    internal partial class IncludeFilesDialog {
        
        private Gtk.VBox vbox62;
        
        private Gtk.Label newFilesInProjectLabel;
        
        private Gtk.ScrolledWindow scrolledwindow9;
        
        private Gtk.TreeView IncludeFileListView;
        
        private Gtk.HBox hbox41;
        
        private Gtk.VBox vbox63;
        
        private Gtk.Label viewLabel;
        
        private Gtk.HBox hbox42;
        
        private Gtk.Label labelSpacer1;
        
        private Gtk.VBox vbox64;
        
        private Gtk.RadioButton newFilesOnlyRadioButton;
        
        private Gtk.RadioButton allFilesRadioButton;
        
        private Gtk.VButtonBox vbuttonbox2;
        
        private Gtk.Button selectAllButton;
        
        private Gtk.Button deselectAllButton;
        
        private Gtk.Button cancelbutton;
        
        private Gtk.Button okbutton;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget MonoDevelop.Ide.Gui.Dialogs.IncludeFilesDialog
            this.Name = "MonoDevelop.Ide.Gui.Dialogs.IncludeFilesDialog";
            this.Title = "Include Found Files";
            this.TypeHint = ((Gdk.WindowTypeHint)(1));
            this.Modal = true;
            this.BorderWidth = ((uint)(6));
            this.DestroyWithParent = true;
            // Internal child MonoDevelop.Ide.Gui.Dialogs.IncludeFilesDialog.VBox
            Gtk.VBox w1 = this.VBox;
            w1.Name = "dialog-vbox3";
            w1.Spacing = 6;
            // Container child dialog-vbox3.Gtk.Box+BoxChild
            this.vbox62 = new Gtk.VBox();
            this.vbox62.Name = "vbox62";
            this.vbox62.Spacing = 6;
            this.vbox62.BorderWidth = ((uint)(6));
            // Container child vbox62.Gtk.Box+BoxChild
            this.newFilesInProjectLabel = new Gtk.Label();
            this.newFilesInProjectLabel.Name = "newFilesInProjectLabel";
            this.newFilesInProjectLabel.Xalign = 0F;
            this.newFilesInProjectLabel.Yalign = 0F;
            this.newFilesInProjectLabel.LabelProp = Mono.Unix.Catalog.GetString("New files:");
            this.newFilesInProjectLabel.UseMarkup = true;
            this.vbox62.Add(this.newFilesInProjectLabel);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.vbox62[this.newFilesInProjectLabel]));
            w2.Position = 0;
            w2.Expand = false;
            w2.Fill = false;
            // Container child vbox62.Gtk.Box+BoxChild
            this.scrolledwindow9 = new Gtk.ScrolledWindow();
            this.scrolledwindow9.WidthRequest = 100;
            this.scrolledwindow9.HeightRequest = 100;
            this.scrolledwindow9.Name = "scrolledwindow9";
            this.scrolledwindow9.VscrollbarPolicy = ((Gtk.PolicyType)(1));
            this.scrolledwindow9.HscrollbarPolicy = ((Gtk.PolicyType)(1));
            this.scrolledwindow9.ShadowType = ((Gtk.ShadowType)(1));
            // Container child scrolledwindow9.Gtk.Container+ContainerChild
            this.IncludeFileListView = new Gtk.TreeView();
            this.IncludeFileListView.Name = "IncludeFileListView";
            this.IncludeFileListView.HeadersVisible = false;
            this.IncludeFileListView.RulesHint = true;
            this.IncludeFileListView.HeadersClickable = true;
            this.scrolledwindow9.Add(this.IncludeFileListView);
            this.vbox62.Add(this.scrolledwindow9);
            Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(this.vbox62[this.scrolledwindow9]));
            w4.Position = 1;
            // Container child vbox62.Gtk.Box+BoxChild
            this.hbox41 = new Gtk.HBox();
            this.hbox41.Name = "hbox41";
            this.hbox41.Spacing = 6;
            // Container child hbox41.Gtk.Box+BoxChild
            this.vbox63 = new Gtk.VBox();
            this.vbox63.Name = "vbox63";
            // Container child vbox63.Gtk.Box+BoxChild
            this.viewLabel = new Gtk.Label();
            this.viewLabel.Name = "viewLabel";
            this.viewLabel.Xalign = 0F;
            this.viewLabel.LabelProp = Mono.Unix.Catalog.GetString("View:");
            this.viewLabel.UseMarkup = true;
            this.vbox63.Add(this.viewLabel);
            Gtk.Box.BoxChild w5 = ((Gtk.Box.BoxChild)(this.vbox63[this.viewLabel]));
            w5.Position = 0;
            // Container child vbox63.Gtk.Box+BoxChild
            this.hbox42 = new Gtk.HBox();
            this.hbox42.Name = "hbox42";
            // Container child hbox42.Gtk.Box+BoxChild
            this.labelSpacer1 = new Gtk.Label();
            this.labelSpacer1.Name = "labelSpacer1";
            this.labelSpacer1.Xalign = 0F;
            this.labelSpacer1.Yalign = 0F;
            this.labelSpacer1.LabelProp = Mono.Unix.Catalog.GetString("   ");
            this.hbox42.Add(this.labelSpacer1);
            Gtk.Box.BoxChild w6 = ((Gtk.Box.BoxChild)(this.hbox42[this.labelSpacer1]));
            w6.Position = 0;
            w6.Expand = false;
            w6.Fill = false;
            // Container child hbox42.Gtk.Box+BoxChild
            this.vbox64 = new Gtk.VBox();
            this.vbox64.Name = "vbox64";
            // Container child vbox64.Gtk.Box+BoxChild
            this.newFilesOnlyRadioButton = new Gtk.RadioButton(Mono.Unix.Catalog.GetString("New Files Only"));
            this.newFilesOnlyRadioButton.Name = "newFilesOnlyRadioButton";
            this.newFilesOnlyRadioButton.Active = true;
            this.newFilesOnlyRadioButton.DrawIndicator = true;
            this.newFilesOnlyRadioButton.UseUnderline = true;
            this.newFilesOnlyRadioButton.Group = new GLib.SList(System.IntPtr.Zero);
            this.vbox64.Add(this.newFilesOnlyRadioButton);
            Gtk.Box.BoxChild w7 = ((Gtk.Box.BoxChild)(this.vbox64[this.newFilesOnlyRadioButton]));
            w7.Position = 0;
            // Container child vbox64.Gtk.Box+BoxChild
            this.allFilesRadioButton = new Gtk.RadioButton(Mono.Unix.Catalog.GetString("All Files"));
            this.allFilesRadioButton.Name = "allFilesRadioButton";
            this.allFilesRadioButton.DrawIndicator = true;
            this.allFilesRadioButton.UseUnderline = true;
            this.allFilesRadioButton.Group = this.newFilesOnlyRadioButton.Group;
            this.vbox64.Add(this.allFilesRadioButton);
            Gtk.Box.BoxChild w8 = ((Gtk.Box.BoxChild)(this.vbox64[this.allFilesRadioButton]));
            w8.Position = 1;
            this.hbox42.Add(this.vbox64);
            Gtk.Box.BoxChild w9 = ((Gtk.Box.BoxChild)(this.hbox42[this.vbox64]));
            w9.Position = 1;
            this.vbox63.Add(this.hbox42);
            Gtk.Box.BoxChild w10 = ((Gtk.Box.BoxChild)(this.vbox63[this.hbox42]));
            w10.Position = 1;
            this.hbox41.Add(this.vbox63);
            Gtk.Box.BoxChild w11 = ((Gtk.Box.BoxChild)(this.hbox41[this.vbox63]));
            w11.Position = 0;
            // Container child hbox41.Gtk.Box+BoxChild
            this.vbuttonbox2 = new Gtk.VButtonBox();
            this.vbuttonbox2.Name = "vbuttonbox2";
            this.vbuttonbox2.Spacing = 6;
            // Container child vbuttonbox2.Gtk.ButtonBox+ButtonBoxChild
            this.selectAllButton = new Gtk.Button();
            this.selectAllButton.Name = "selectAllButton";
            this.selectAllButton.UseUnderline = true;
            this.selectAllButton.Label = Mono.Unix.Catalog.GetString("Select _All");
            this.vbuttonbox2.Add(this.selectAllButton);
            // Container child vbuttonbox2.Gtk.ButtonBox+ButtonBoxChild
            this.deselectAllButton = new Gtk.Button();
            this.deselectAllButton.Name = "deselectAllButton";
            this.deselectAllButton.UseStock = true;
            this.deselectAllButton.UseUnderline = true;
            this.deselectAllButton.Label = "gtk-clear";
            this.vbuttonbox2.Add(this.deselectAllButton);
            Gtk.ButtonBox.ButtonBoxChild w13 = ((Gtk.ButtonBox.ButtonBoxChild)(this.vbuttonbox2[this.deselectAllButton]));
            w13.Position = 1;
            this.hbox41.Add(this.vbuttonbox2);
            Gtk.Box.BoxChild w14 = ((Gtk.Box.BoxChild)(this.hbox41[this.vbuttonbox2]));
            w14.Position = 1;
            w14.Expand = false;
            this.vbox62.Add(this.hbox41);
            Gtk.Box.BoxChild w15 = ((Gtk.Box.BoxChild)(this.vbox62[this.hbox41]));
            w15.Position = 2;
            w15.Expand = false;
            w15.Fill = false;
            w1.Add(this.vbox62);
            Gtk.Box.BoxChild w16 = ((Gtk.Box.BoxChild)(w1[this.vbox62]));
            w16.Position = 0;
            // Internal child MonoDevelop.Ide.Gui.Dialogs.IncludeFilesDialog.ActionArea
            Gtk.HButtonBox w17 = this.ActionArea;
            w17.Name = "dialog-action_area3";
            w17.Spacing = 10;
            w17.BorderWidth = ((uint)(5));
            w17.LayoutStyle = ((Gtk.ButtonBoxStyle)(4));
            // Container child dialog-action_area3.Gtk.ButtonBox+ButtonBoxChild
            this.cancelbutton = new Gtk.Button();
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.UseStock = true;
            this.cancelbutton.UseUnderline = true;
            this.cancelbutton.Label = "gtk-cancel";
            this.AddActionWidget(this.cancelbutton, -6);
            // Container child dialog-action_area3.Gtk.ButtonBox+ButtonBoxChild
            this.okbutton = new Gtk.Button();
            this.okbutton.CanDefault = true;
            this.okbutton.Name = "okbutton";
            this.okbutton.UseStock = true;
            this.okbutton.UseUnderline = true;
            this.okbutton.Label = "gtk-ok";
            this.AddActionWidget(this.okbutton, -5);
            Gtk.ButtonBox.ButtonBoxChild w19 = ((Gtk.ButtonBox.ButtonBoxChild)(w17[this.okbutton]));
            w19.Position = 1;
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 475;
            this.DefaultHeight = 489;
            this.okbutton.HasDefault = true;
            this.Show();
        }
    }
}
