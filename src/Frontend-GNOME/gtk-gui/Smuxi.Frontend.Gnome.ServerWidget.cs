// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Smuxi.Frontend.Gnome {
    
    
    public partial class ServerWidget {
        
        private Gtk.VBox vbox16;
        
        private Gtk.Table table2;
        
        private Gtk.ComboBoxEntry f_NetworkComboBoxEntry;
        
        private Gtk.Label f_NetworkLabel;
        
        private Gtk.CheckButton f_OnStartupConnectCheckButton;
        
        private Gtk.ComboBox f_ProtocolComboBox;
        
        private Gtk.Entry f_UsernameEntry;
        
        private Gtk.HBox hbox10;
        
        private Gtk.Entry f_HostnameEntry;
        
        private Gtk.HBox hbox11;
        
        private Gtk.Label label20;
        
        private Gtk.SpinButton f_PortSpinButton;
        
        private Gtk.HBox hbox2;
        
        private Gtk.Entry f_PasswordEntry;
        
        private Gtk.CheckButton f_ShowPasswordCheckButton;
        
        private Gtk.Label label11;
        
        private Gtk.Label label21;
        
        private Gtk.Label label22;
        
        private Gtk.Label label5;
        
        private Gtk.VBox vbox2;
        
        private Gtk.HBox hbox3;
        
        private Gtk.Label label37;
        
        private Gtk.CheckButton f_IgnoreOnConnectCommandsCheckButton;
        
        private Gtk.ScrolledWindow scrolledwindow1;
        
        private Gtk.TextView f_OnConnectCommandsTextView;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget Smuxi.Frontend.Gnome.ServerWidget
            Stetic.BinContainer.Attach(this);
            this.Name = "Smuxi.Frontend.Gnome.ServerWidget";
            // Container child Smuxi.Frontend.Gnome.ServerWidget.Gtk.Container+ContainerChild
            this.vbox16 = new Gtk.VBox();
            this.vbox16.Name = "vbox16";
            this.vbox16.Spacing = 5;
            // Container child vbox16.Gtk.Box+BoxChild
            this.table2 = new Gtk.Table(((uint)(6)), ((uint)(2)), false);
            this.table2.Name = "table2";
            this.table2.RowSpacing = ((uint)(5));
            this.table2.ColumnSpacing = ((uint)(5));
            // Container child table2.Gtk.Table+TableChild
            this.f_NetworkComboBoxEntry = Gtk.ComboBoxEntry.NewText();
            this.f_NetworkComboBoxEntry.Name = "f_NetworkComboBoxEntry";
            this.table2.Add(this.f_NetworkComboBoxEntry);
            Gtk.Table.TableChild w1 = ((Gtk.Table.TableChild)(this.table2[this.f_NetworkComboBoxEntry]));
            w1.TopAttach = ((uint)(2));
            w1.BottomAttach = ((uint)(3));
            w1.LeftAttach = ((uint)(1));
            w1.RightAttach = ((uint)(2));
            w1.XOptions = ((Gtk.AttachOptions)(4));
            w1.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table2.Gtk.Table+TableChild
            this.f_NetworkLabel = new Gtk.Label();
            this.f_NetworkLabel.Name = "f_NetworkLabel";
            this.f_NetworkLabel.Xalign = 0F;
            this.f_NetworkLabel.LabelProp = Mono.Unix.Catalog.GetString("_Network:");
            this.f_NetworkLabel.UseUnderline = true;
            this.table2.Add(this.f_NetworkLabel);
            Gtk.Table.TableChild w2 = ((Gtk.Table.TableChild)(this.table2[this.f_NetworkLabel]));
            w2.TopAttach = ((uint)(2));
            w2.BottomAttach = ((uint)(3));
            w2.XOptions = ((Gtk.AttachOptions)(4));
            w2.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table2.Gtk.Table+TableChild
            this.f_OnStartupConnectCheckButton = new Gtk.CheckButton();
            this.f_OnStartupConnectCheckButton.CanFocus = true;
            this.f_OnStartupConnectCheckButton.Name = "f_OnStartupConnectCheckButton";
            this.f_OnStartupConnectCheckButton.Label = Mono.Unix.Catalog.GetString("Automatically connect to server at startup");
            this.f_OnStartupConnectCheckButton.DrawIndicator = true;
            this.f_OnStartupConnectCheckButton.UseUnderline = true;
            this.f_OnStartupConnectCheckButton.Xalign = 0F;
            this.table2.Add(this.f_OnStartupConnectCheckButton);
            Gtk.Table.TableChild w3 = ((Gtk.Table.TableChild)(this.table2[this.f_OnStartupConnectCheckButton]));
            w3.TopAttach = ((uint)(5));
            w3.BottomAttach = ((uint)(6));
            w3.RightAttach = ((uint)(2));
            w3.XOptions = ((Gtk.AttachOptions)(4));
            w3.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table2.Gtk.Table+TableChild
            this.f_ProtocolComboBox = new Gtk.ComboBox();
            this.f_ProtocolComboBox.Name = "f_ProtocolComboBox";
            this.table2.Add(this.f_ProtocolComboBox);
            Gtk.Table.TableChild w4 = ((Gtk.Table.TableChild)(this.table2[this.f_ProtocolComboBox]));
            w4.LeftAttach = ((uint)(1));
            w4.RightAttach = ((uint)(2));
            // Container child table2.Gtk.Table+TableChild
            this.f_UsernameEntry = new Gtk.Entry();
            this.f_UsernameEntry.Name = "f_UsernameEntry";
            this.f_UsernameEntry.IsEditable = true;
            this.f_UsernameEntry.InvisibleChar = '●';
            this.table2.Add(this.f_UsernameEntry);
            Gtk.Table.TableChild w5 = ((Gtk.Table.TableChild)(this.table2[this.f_UsernameEntry]));
            w5.TopAttach = ((uint)(3));
            w5.BottomAttach = ((uint)(4));
            w5.LeftAttach = ((uint)(1));
            w5.RightAttach = ((uint)(2));
            // Container child table2.Gtk.Table+TableChild
            this.hbox10 = new Gtk.HBox();
            this.hbox10.Name = "hbox10";
            // Container child hbox10.Gtk.Box+BoxChild
            this.f_HostnameEntry = new Gtk.Entry();
            this.f_HostnameEntry.Name = "f_HostnameEntry";
            this.f_HostnameEntry.IsEditable = true;
            this.f_HostnameEntry.InvisibleChar = '●';
            this.hbox10.Add(this.f_HostnameEntry);
            Gtk.Box.BoxChild w6 = ((Gtk.Box.BoxChild)(this.hbox10[this.f_HostnameEntry]));
            w6.Position = 0;
            // Container child hbox10.Gtk.Box+BoxChild
            this.hbox11 = new Gtk.HBox();
            this.hbox11.Name = "hbox11";
            this.hbox11.Spacing = 5;
            // Container child hbox11.Gtk.Box+BoxChild
            this.label20 = new Gtk.Label();
            this.label20.Name = "label20";
            this.label20.LabelProp = Mono.Unix.Catalog.GetString("_Port:");
            this.label20.UseUnderline = true;
            this.hbox11.Add(this.label20);
            Gtk.Box.BoxChild w7 = ((Gtk.Box.BoxChild)(this.hbox11[this.label20]));
            w7.Position = 0;
            // Container child hbox11.Gtk.Box+BoxChild
            this.f_PortSpinButton = new Gtk.SpinButton(0, 65535, 1);
            this.f_PortSpinButton.Name = "f_PortSpinButton";
            this.f_PortSpinButton.Adjustment.PageIncrement = 10;
            this.f_PortSpinButton.Adjustment.PageSize = 10;
            this.f_PortSpinButton.ClimbRate = 1;
            this.f_PortSpinButton.Numeric = true;
            this.hbox11.Add(this.f_PortSpinButton);
            Gtk.Box.BoxChild w8 = ((Gtk.Box.BoxChild)(this.hbox11[this.f_PortSpinButton]));
            w8.Position = 1;
            this.hbox10.Add(this.hbox11);
            Gtk.Box.BoxChild w9 = ((Gtk.Box.BoxChild)(this.hbox10[this.hbox11]));
            w9.Position = 1;
            this.table2.Add(this.hbox10);
            Gtk.Table.TableChild w10 = ((Gtk.Table.TableChild)(this.table2[this.hbox10]));
            w10.TopAttach = ((uint)(1));
            w10.BottomAttach = ((uint)(2));
            w10.LeftAttach = ((uint)(1));
            w10.RightAttach = ((uint)(2));
            // Container child table2.Gtk.Table+TableChild
            this.hbox2 = new Gtk.HBox();
            this.hbox2.Name = "hbox2";
            this.hbox2.Spacing = 6;
            // Container child hbox2.Gtk.Box+BoxChild
            this.f_PasswordEntry = new Gtk.Entry();
            this.f_PasswordEntry.Name = "f_PasswordEntry";
            this.f_PasswordEntry.IsEditable = true;
            this.f_PasswordEntry.Visibility = false;
            this.f_PasswordEntry.InvisibleChar = '●';
            this.hbox2.Add(this.f_PasswordEntry);
            Gtk.Box.BoxChild w11 = ((Gtk.Box.BoxChild)(this.hbox2[this.f_PasswordEntry]));
            w11.Position = 0;
            // Container child hbox2.Gtk.Box+BoxChild
            this.f_ShowPasswordCheckButton = new Gtk.CheckButton();
            this.f_ShowPasswordCheckButton.CanFocus = true;
            this.f_ShowPasswordCheckButton.Name = "f_ShowPasswordCheckButton";
            this.f_ShowPasswordCheckButton.Label = Mono.Unix.Catalog.GetString("Show Password");
            this.f_ShowPasswordCheckButton.DrawIndicator = true;
            this.f_ShowPasswordCheckButton.UseUnderline = true;
            this.hbox2.Add(this.f_ShowPasswordCheckButton);
            Gtk.Box.BoxChild w12 = ((Gtk.Box.BoxChild)(this.hbox2[this.f_ShowPasswordCheckButton]));
            w12.Position = 1;
            this.table2.Add(this.hbox2);
            Gtk.Table.TableChild w13 = ((Gtk.Table.TableChild)(this.table2[this.hbox2]));
            w13.TopAttach = ((uint)(4));
            w13.BottomAttach = ((uint)(5));
            w13.LeftAttach = ((uint)(1));
            w13.RightAttach = ((uint)(2));
            w13.XOptions = ((Gtk.AttachOptions)(4));
            w13.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table2.Gtk.Table+TableChild
            this.label11 = new Gtk.Label();
            this.label11.Name = "label11";
            this.label11.Xalign = 0F;
            this.label11.LabelProp = Mono.Unix.Catalog.GetString("_Hostname:");
            this.label11.UseUnderline = true;
            this.table2.Add(this.label11);
            Gtk.Table.TableChild w14 = ((Gtk.Table.TableChild)(this.table2[this.label11]));
            w14.TopAttach = ((uint)(1));
            w14.BottomAttach = ((uint)(2));
            // Container child table2.Gtk.Table+TableChild
            this.label21 = new Gtk.Label();
            this.label21.Name = "label21";
            this.label21.Xalign = 0F;
            this.label21.LabelProp = Mono.Unix.Catalog.GetString("_Username:");
            this.label21.UseUnderline = true;
            this.table2.Add(this.label21);
            Gtk.Table.TableChild w15 = ((Gtk.Table.TableChild)(this.table2[this.label21]));
            w15.TopAttach = ((uint)(3));
            w15.BottomAttach = ((uint)(4));
            // Container child table2.Gtk.Table+TableChild
            this.label22 = new Gtk.Label();
            this.label22.Name = "label22";
            this.label22.Xalign = 0F;
            this.label22.LabelProp = Mono.Unix.Catalog.GetString("_Password:");
            this.label22.UseUnderline = true;
            this.table2.Add(this.label22);
            Gtk.Table.TableChild w16 = ((Gtk.Table.TableChild)(this.table2[this.label22]));
            w16.TopAttach = ((uint)(4));
            w16.BottomAttach = ((uint)(5));
            // Container child table2.Gtk.Table+TableChild
            this.label5 = new Gtk.Label();
            this.label5.Name = "label5";
            this.label5.Xalign = 0F;
            this.label5.LabelProp = Mono.Unix.Catalog.GetString("_Protocol:");
            this.label5.UseUnderline = true;
            this.table2.Add(this.label5);
            this.vbox16.Add(this.table2);
            Gtk.Box.BoxChild w18 = ((Gtk.Box.BoxChild)(this.vbox16[this.table2]));
            w18.Position = 0;
            w18.Expand = false;
            // Container child vbox16.Gtk.Box+BoxChild
            this.vbox2 = new Gtk.VBox();
            this.vbox2.Name = "vbox2";
            this.vbox2.Spacing = 5;
            // Container child vbox2.Gtk.Box+BoxChild
            this.hbox3 = new Gtk.HBox();
            this.hbox3.Name = "hbox3";
            this.hbox3.Spacing = 6;
            // Container child hbox3.Gtk.Box+BoxChild
            this.label37 = new Gtk.Label();
            this.label37.Name = "label37";
            this.label37.Xalign = 0F;
            this.label37.LabelProp = Mono.Unix.Catalog.GetString("_On Connect Commands:");
            this.label37.UseUnderline = true;
            this.hbox3.Add(this.label37);
            Gtk.Box.BoxChild w19 = ((Gtk.Box.BoxChild)(this.hbox3[this.label37]));
            w19.Position = 0;
            w19.Expand = false;
            w19.Fill = false;
            // Container child hbox3.Gtk.Box+BoxChild
            this.f_IgnoreOnConnectCommandsCheckButton = new Gtk.CheckButton();
            this.f_IgnoreOnConnectCommandsCheckButton.CanFocus = true;
            this.f_IgnoreOnConnectCommandsCheckButton.Name = "f_IgnoreOnConnectCommandsCheckButton";
            this.f_IgnoreOnConnectCommandsCheckButton.Label = Mono.Unix.Catalog.GetString("_Ignore Commands");
            this.f_IgnoreOnConnectCommandsCheckButton.DrawIndicator = true;
            this.f_IgnoreOnConnectCommandsCheckButton.UseUnderline = true;
            this.hbox3.Add(this.f_IgnoreOnConnectCommandsCheckButton);
            Gtk.Box.BoxChild w20 = ((Gtk.Box.BoxChild)(this.hbox3[this.f_IgnoreOnConnectCommandsCheckButton]));
            w20.Position = 1;
            this.vbox2.Add(this.hbox3);
            Gtk.Box.BoxChild w21 = ((Gtk.Box.BoxChild)(this.vbox2[this.hbox3]));
            w21.Position = 0;
            w21.Expand = false;
            w21.Fill = false;
            // Container child vbox2.Gtk.Box+BoxChild
            this.scrolledwindow1 = new Gtk.ScrolledWindow();
            this.scrolledwindow1.WidthRequest = 350;
            this.scrolledwindow1.HeightRequest = 100;
            this.scrolledwindow1.Name = "scrolledwindow1";
            this.scrolledwindow1.ShadowType = ((Gtk.ShadowType)(1));
            // Container child scrolledwindow1.Gtk.Container+ContainerChild
            this.f_OnConnectCommandsTextView = new Gtk.TextView();
            this.f_OnConnectCommandsTextView.WidthRequest = 152;
            this.f_OnConnectCommandsTextView.HeightRequest = 168;
            this.f_OnConnectCommandsTextView.Name = "f_OnConnectCommandsTextView";
            this.f_OnConnectCommandsTextView.WrapMode = ((Gtk.WrapMode)(2));
            this.scrolledwindow1.Add(this.f_OnConnectCommandsTextView);
            this.vbox2.Add(this.scrolledwindow1);
            Gtk.Box.BoxChild w23 = ((Gtk.Box.BoxChild)(this.vbox2[this.scrolledwindow1]));
            w23.Position = 1;
            this.vbox16.Add(this.vbox2);
            Gtk.Box.BoxChild w24 = ((Gtk.Box.BoxChild)(this.vbox16[this.vbox2]));
            w24.Position = 1;
            this.Add(this.vbox16);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.f_NetworkLabel.MnemonicWidget = this.f_NetworkComboBoxEntry;
            this.label20.MnemonicWidget = this.f_PortSpinButton;
            this.label11.MnemonicWidget = this.f_HostnameEntry;
            this.label21.MnemonicWidget = this.f_UsernameEntry;
            this.label22.MnemonicWidget = this.f_PasswordEntry;
            this.label5.MnemonicWidget = this.f_ProtocolComboBox;
            this.label37.MnemonicWidget = this.f_OnConnectCommandsTextView;
            this.Hide();
        }
    }
}