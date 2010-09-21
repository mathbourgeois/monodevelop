
// This file has been generated by the GUI designer. Do not modify.
namespace MonoDevelop.CSharp.Formatting
{
	public partial class CSharpFormattingProfileDialog
	{
		private global::Gtk.VBox vbox5;
		
		private global::Gtk.HBox hbox3;
		
		private global::Gtk.Label label5;
		
		private global::Gtk.Entry entryName;
		
		private global::Gtk.HBox hbox4;
		
		private global::Gtk.Label label12;
		
		private global::Gtk.ComboBox comboboxCategories;
		
		private global::Gtk.HPaned hpaned1;
		
		private global::Gtk.Notebook notebookCategories;
		
		private global::Gtk.VBox vbox8;
		
		private global::Gtk.Frame frame1;
		
		private global::Gtk.Alignment GtkAlignment2;
		
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		
		private global::Gtk.TreeView treeviewIndentOptions;
		
		private global::Gtk.Label GtkLabel;
		
		private global::Gtk.Label label8;
		
		private global::Gtk.Frame frame2;
		
		private global::Gtk.Alignment GtkAlignment3;
		
		private global::Gtk.ScrolledWindow GtkScrolledWindow1;
		
		private global::Gtk.TreeView treeviewBracePositions;
		
		private global::Gtk.Label GtkLabel4;
		
		private global::Gtk.Label label9;
		
		private global::Gtk.VBox vbox10;
		
		private global::Gtk.Frame frame5;
		
		private global::Gtk.Alignment GtkAlignment6;
		
		private global::Gtk.Table table1;
		
		private global::Gtk.Entry entry3;
		
		private global::Gtk.Entry entry4;
		
		private global::Gtk.Entry entry5;
		
		private global::Gtk.Label label15;
		
		private global::Gtk.Label label16;
		
		private global::Gtk.Label label17;
		
		private global::Gtk.Label GtkLabel7;
		
		private global::Gtk.Frame frame6;
		
		private global::Gtk.Alignment GtkAlignment7;
		
		private global::Gtk.Table table2;
		
		private global::Gtk.Entry entry7;
		
		private global::Gtk.Entry entry8;
		
		private global::Gtk.Label label19;
		
		private global::Gtk.Label label20;
		
		private global::Gtk.Label GtkLabel8;
		
		private global::Gtk.Frame frame7;
		
		private global::Gtk.Alignment GtkAlignment8;
		
		private global::Gtk.Table table3;
		
		private global::Gtk.Entry entry10;
		
		private global::Gtk.Entry entry9;
		
		private global::Gtk.Label label21;
		
		private global::Gtk.Label label22;
		
		private global::Gtk.Label GtkLabel9;
		
		private global::Gtk.Label label14;
		
		private global::Gtk.Frame frame3;
		
		private global::Gtk.Alignment GtkAlignment4;
		
		private global::Gtk.VPaned vpaned1;
		
		private global::Gtk.ScrolledWindow GtkScrolledWindow2;
		
		private global::Gtk.TreeView treeviewInsertWhiteSpaceCategory;
		
		private global::Gtk.ScrolledWindow GtkScrolledWindow3;
		
		private global::Gtk.TreeView treeviewInsertWhiteSpaceOptions;
		
		private global::Gtk.Label GtkLabel5;
		
		private global::Gtk.Label label10;
		
		private global::Gtk.Frame frame4;
		
		private global::Gtk.Alignment GtkAlignment5;
		
		private global::Gtk.ScrolledWindow GtkScrolledWindow4;
		
		private global::Gtk.TreeView treeviewNewLines;
		
		private global::Gtk.Label GtkLabel6;
		
		private global::Gtk.Label label11;
		
		private global::Gtk.VBox vbox6;
		
		private global::Gtk.Label label13;
		
		private global::Gtk.ScrolledWindow scrolledwindow;
		
		private global::Gtk.Button buttonCancel;
		
		private global::Gtk.Button buttonOk;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MonoDevelop.CSharp.Formatting.CSharpFormattingProfileDialog
			this.Name = "MonoDevelop.CSharp.Formatting.CSharpFormattingProfileDialog";
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.BorderWidth = ((uint)(6));
			// Internal child MonoDevelop.CSharp.Formatting.CSharpFormattingProfileDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.Spacing = 6;
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.vbox5 = new global::Gtk.VBox ();
			this.vbox5.Name = "vbox5";
			this.vbox5.Spacing = 6;
			// Container child vbox5.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox ();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.label5 = new global::Gtk.Label ();
			this.label5.Name = "label5";
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("_Name:");
			this.label5.UseUnderline = true;
			this.hbox3.Add (this.label5);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.label5]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.entryName = new global::Gtk.Entry ();
			this.entryName.CanFocus = true;
			this.entryName.Name = "entryName";
			this.entryName.IsEditable = true;
			this.entryName.InvisibleChar = '●';
			this.hbox3.Add (this.entryName);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.entryName]));
			w3.Position = 1;
			this.vbox5.Add (this.hbox3);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.hbox3]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox ();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.label12 = new global::Gtk.Label ();
			this.label12.Name = "label12";
			this.label12.LabelProp = global::Mono.Unix.Catalog.GetString ("_Category:");
			this.label12.UseUnderline = true;
			this.hbox4.Add (this.label12);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.label12]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.comboboxCategories = global::Gtk.ComboBox.NewText ();
			this.comboboxCategories.Name = "comboboxCategories";
			this.hbox4.Add (this.comboboxCategories);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.comboboxCategories]));
			w6.Position = 1;
			this.vbox5.Add (this.hbox4);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.hbox4]));
			w7.Position = 1;
			w7.Expand = false;
			w7.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.hpaned1 = new global::Gtk.HPaned ();
			this.hpaned1.CanFocus = true;
			this.hpaned1.Name = "hpaned1";
			this.hpaned1.Position = 424;
			// Container child hpaned1.Gtk.Paned+PanedChild
			this.notebookCategories = new global::Gtk.Notebook ();
			this.notebookCategories.CanFocus = true;
			this.notebookCategories.Name = "notebookCategories";
			this.notebookCategories.CurrentPage = 3;
			// Container child notebookCategories.Gtk.Notebook+NotebookChild
			this.vbox8 = new global::Gtk.VBox ();
			this.vbox8.Name = "vbox8";
			this.vbox8.Spacing = 6;
			// Container child vbox8.Gtk.Box+BoxChild
			this.frame1 = new global::Gtk.Frame ();
			this.frame1.Name = "frame1";
			this.frame1.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame1.Gtk.Container+ContainerChild
			this.GtkAlignment2 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment2.Name = "GtkAlignment2";
			// Container child GtkAlignment2.Gtk.Container+ContainerChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.treeviewIndentOptions = new global::Gtk.TreeView ();
			this.treeviewIndentOptions.CanFocus = true;
			this.treeviewIndentOptions.Name = "treeviewIndentOptions";
			this.GtkScrolledWindow.Add (this.treeviewIndentOptions);
			this.GtkAlignment2.Add (this.GtkScrolledWindow);
			this.frame1.Add (this.GtkAlignment2);
			this.GtkLabel = new global::Gtk.Label ();
			this.GtkLabel.Name = "GtkLabel";
			this.GtkLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Indent</b>");
			this.GtkLabel.UseMarkup = true;
			this.frame1.LabelWidget = this.GtkLabel;
			this.vbox8.Add (this.frame1);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox8[this.frame1]));
			w11.Position = 0;
			this.notebookCategories.Add (this.vbox8);
			// Notebook tab
			this.label8 = new global::Gtk.Label ();
			this.label8.Name = "label8";
			this.label8.LabelProp = global::Mono.Unix.Catalog.GetString ("page1");
			this.notebookCategories.SetTabLabel (this.vbox8,this.label8);
			this.label8.ShowAll ();
			// Container child notebookCategories.Gtk.Notebook+NotebookChild
			this.frame2 = new global::Gtk.Frame ();
			this.frame2.Name = "frame2";
			this.frame2.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame2.Gtk.Container+ContainerChild
			this.GtkAlignment3 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment3.Name = "GtkAlignment3";
			// Container child GtkAlignment3.Gtk.Container+ContainerChild
			this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
			this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
			this.treeviewBracePositions = new global::Gtk.TreeView ();
			this.treeviewBracePositions.CanFocus = true;
			this.treeviewBracePositions.Name = "treeviewBracePositions";
			this.GtkScrolledWindow1.Add (this.treeviewBracePositions);
			this.GtkAlignment3.Add (this.GtkScrolledWindow1);
			this.frame2.Add (this.GtkAlignment3);
			this.GtkLabel4 = new global::Gtk.Label ();
			this.GtkLabel4.Name = "GtkLabel4";
			this.GtkLabel4.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Brace positions</b>");
			this.GtkLabel4.UseMarkup = true;
			this.frame2.LabelWidget = this.GtkLabel4;
			this.notebookCategories.Add (this.frame2);
			global::Gtk.Notebook.NotebookChild w16 = ((global::Gtk.Notebook.NotebookChild)(this.notebookCategories[this.frame2]));
			w16.Position = 1;
			// Notebook tab
			this.label9 = new global::Gtk.Label ();
			this.label9.Name = "label9";
			this.label9.LabelProp = global::Mono.Unix.Catalog.GetString ("page2");
			this.notebookCategories.SetTabLabel (this.frame2,this.label9);
			this.label9.ShowAll ();
			// Container child notebookCategories.Gtk.Notebook+NotebookChild
			this.vbox10 = new global::Gtk.VBox ();
			this.vbox10.Name = "vbox10";
			this.vbox10.Spacing = 6;
			// Container child vbox10.Gtk.Box+BoxChild
			this.frame5 = new global::Gtk.Frame ();
			this.frame5.Name = "frame5";
			this.frame5.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame5.Gtk.Container+ContainerChild
			this.GtkAlignment6 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment6.Name = "GtkAlignment6";
			this.GtkAlignment6.LeftPadding = ((uint)(12));
			// Container child GtkAlignment6.Gtk.Container+ContainerChild
			this.table1 = new global::Gtk.Table (((uint)(3)), ((uint)(2)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.entry3 = new global::Gtk.Entry ();
			this.entry3.CanFocus = true;
			this.entry3.Name = "entry3";
			this.entry3.IsEditable = true;
			this.entry3.InvisibleChar = '●';
			this.table1.Add (this.entry3);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.table1[this.entry3]));
			w17.LeftAttach = ((uint)(1));
			w17.RightAttach = ((uint)(2));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entry4 = new global::Gtk.Entry ();
			this.entry4.CanFocus = true;
			this.entry4.Name = "entry4";
			this.entry4.IsEditable = true;
			this.entry4.InvisibleChar = '●';
			this.table1.Add (this.entry4);
			global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.table1[this.entry4]));
			w18.TopAttach = ((uint)(1));
			w18.BottomAttach = ((uint)(2));
			w18.LeftAttach = ((uint)(1));
			w18.RightAttach = ((uint)(2));
			w18.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entry5 = new global::Gtk.Entry ();
			this.entry5.CanFocus = true;
			this.entry5.Name = "entry5";
			this.entry5.IsEditable = true;
			this.entry5.InvisibleChar = '●';
			this.table1.Add (this.entry5);
			global::Gtk.Table.TableChild w19 = ((global::Gtk.Table.TableChild)(this.table1[this.entry5]));
			w19.TopAttach = ((uint)(2));
			w19.BottomAttach = ((uint)(3));
			w19.LeftAttach = ((uint)(1));
			w19.RightAttach = ((uint)(2));
			w19.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label15 = new global::Gtk.Label ();
			this.label15.Name = "label15";
			this.label15.Xalign = 0F;
			this.label15.LabelProp = global::Mono.Unix.Catalog.GetString ("Before using declaration:");
			this.table1.Add (this.label15);
			global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.table1[this.label15]));
			w20.XOptions = ((global::Gtk.AttachOptions)(4));
			w20.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label16 = new global::Gtk.Label ();
			this.label16.Name = "label16";
			this.label16.Xalign = 0F;
			this.label16.LabelProp = global::Mono.Unix.Catalog.GetString ("After using declaration:");
			this.table1.Add (this.label16);
			global::Gtk.Table.TableChild w21 = ((global::Gtk.Table.TableChild)(this.table1[this.label16]));
			w21.TopAttach = ((uint)(1));
			w21.BottomAttach = ((uint)(2));
			w21.XOptions = ((global::Gtk.AttachOptions)(4));
			w21.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label17 = new global::Gtk.Label ();
			this.label17.Name = "label17";
			this.label17.Xalign = 0F;
			this.label17.LabelProp = global::Mono.Unix.Catalog.GetString ("Between declarations:");
			this.table1.Add (this.label17);
			global::Gtk.Table.TableChild w22 = ((global::Gtk.Table.TableChild)(this.table1[this.label17]));
			w22.TopAttach = ((uint)(2));
			w22.BottomAttach = ((uint)(3));
			w22.XOptions = ((global::Gtk.AttachOptions)(4));
			w22.YOptions = ((global::Gtk.AttachOptions)(4));
			this.GtkAlignment6.Add (this.table1);
			this.frame5.Add (this.GtkAlignment6);
			this.GtkLabel7 = new global::Gtk.Label ();
			this.GtkLabel7.Name = "GtkLabel7";
			this.GtkLabel7.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Blank lines in compilation unit</b>");
			this.GtkLabel7.UseMarkup = true;
			this.frame5.LabelWidget = this.GtkLabel7;
			this.vbox10.Add (this.frame5);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.vbox10[this.frame5]));
			w25.Position = 0;
			w25.Expand = false;
			w25.Fill = false;
			// Container child vbox10.Gtk.Box+BoxChild
			this.frame6 = new global::Gtk.Frame ();
			this.frame6.Name = "frame6";
			this.frame6.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame6.Gtk.Container+ContainerChild
			this.GtkAlignment7 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment7.Name = "GtkAlignment7";
			this.GtkAlignment7.LeftPadding = ((uint)(12));
			// Container child GtkAlignment7.Gtk.Container+ContainerChild
			this.table2 = new global::Gtk.Table (((uint)(2)), ((uint)(2)), false);
			this.table2.Name = "table2";
			this.table2.RowSpacing = ((uint)(6));
			this.table2.ColumnSpacing = ((uint)(6));
			// Container child table2.Gtk.Table+TableChild
			this.entry7 = new global::Gtk.Entry ();
			this.entry7.CanFocus = true;
			this.entry7.Name = "entry7";
			this.entry7.IsEditable = true;
			this.entry7.InvisibleChar = '●';
			this.table2.Add (this.entry7);
			global::Gtk.Table.TableChild w26 = ((global::Gtk.Table.TableChild)(this.table2[this.entry7]));
			w26.TopAttach = ((uint)(1));
			w26.BottomAttach = ((uint)(2));
			w26.LeftAttach = ((uint)(1));
			w26.RightAttach = ((uint)(2));
			w26.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.entry8 = new global::Gtk.Entry ();
			this.entry8.CanFocus = true;
			this.entry8.Name = "entry8";
			this.entry8.IsEditable = true;
			this.entry8.InvisibleChar = '●';
			this.table2.Add (this.entry8);
			global::Gtk.Table.TableChild w27 = ((global::Gtk.Table.TableChild)(this.table2[this.entry8]));
			w27.LeftAttach = ((uint)(1));
			w27.RightAttach = ((uint)(2));
			w27.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label19 = new global::Gtk.Label ();
			this.label19.Name = "label19";
			this.label19.Xalign = 0F;
			this.label19.LabelProp = global::Mono.Unix.Catalog.GetString ("Between type declarations:");
			this.table2.Add (this.label19);
			global::Gtk.Table.TableChild w28 = ((global::Gtk.Table.TableChild)(this.table2[this.label19]));
			w28.TopAttach = ((uint)(1));
			w28.BottomAttach = ((uint)(2));
			w28.XOptions = ((global::Gtk.AttachOptions)(4));
			w28.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label20 = new global::Gtk.Label ();
			this.label20.Name = "label20";
			this.label20.Xalign = 0F;
			this.label20.LabelProp = global::Mono.Unix.Catalog.GetString ("Before first declaration:");
			this.table2.Add (this.label20);
			global::Gtk.Table.TableChild w29 = ((global::Gtk.Table.TableChild)(this.table2[this.label20]));
			w29.XOptions = ((global::Gtk.AttachOptions)(4));
			w29.YOptions = ((global::Gtk.AttachOptions)(4));
			this.GtkAlignment7.Add (this.table2);
			this.frame6.Add (this.GtkAlignment7);
			this.GtkLabel8 = new global::Gtk.Label ();
			this.GtkLabel8.Name = "GtkLabel8";
			this.GtkLabel8.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Blank lines in namespaces</b>");
			this.GtkLabel8.UseMarkup = true;
			this.frame6.LabelWidget = this.GtkLabel8;
			this.vbox10.Add (this.frame6);
			global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.vbox10[this.frame6]));
			w32.Position = 1;
			w32.Expand = false;
			w32.Fill = false;
			// Container child vbox10.Gtk.Box+BoxChild
			this.frame7 = new global::Gtk.Frame ();
			this.frame7.Name = "frame7";
			this.frame7.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame7.Gtk.Container+ContainerChild
			this.GtkAlignment8 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment8.Name = "GtkAlignment8";
			this.GtkAlignment8.LeftPadding = ((uint)(12));
			// Container child GtkAlignment8.Gtk.Container+ContainerChild
			this.table3 = new global::Gtk.Table (((uint)(2)), ((uint)(2)), false);
			this.table3.Name = "table3";
			this.table3.RowSpacing = ((uint)(6));
			this.table3.ColumnSpacing = ((uint)(6));
			// Container child table3.Gtk.Table+TableChild
			this.entry10 = new global::Gtk.Entry ();
			this.entry10.CanFocus = true;
			this.entry10.Name = "entry10";
			this.entry10.IsEditable = true;
			this.entry10.InvisibleChar = '●';
			this.table3.Add (this.entry10);
			global::Gtk.Table.TableChild w33 = ((global::Gtk.Table.TableChild)(this.table3[this.entry10]));
			w33.TopAttach = ((uint)(1));
			w33.BottomAttach = ((uint)(2));
			w33.LeftAttach = ((uint)(1));
			w33.RightAttach = ((uint)(2));
			w33.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.entry9 = new global::Gtk.Entry ();
			this.entry9.CanFocus = true;
			this.entry9.Name = "entry9";
			this.entry9.IsEditable = true;
			this.entry9.InvisibleChar = '●';
			this.table3.Add (this.entry9);
			global::Gtk.Table.TableChild w34 = ((global::Gtk.Table.TableChild)(this.table3[this.entry9]));
			w34.LeftAttach = ((uint)(1));
			w34.RightAttach = ((uint)(2));
			w34.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.label21 = new global::Gtk.Label ();
			this.label21.Name = "label21";
			this.label21.Xalign = 0F;
			this.label21.LabelProp = global::Mono.Unix.Catalog.GetString ("Between field declarations:");
			this.table3.Add (this.label21);
			global::Gtk.Table.TableChild w35 = ((global::Gtk.Table.TableChild)(this.table3[this.label21]));
			w35.XOptions = ((global::Gtk.AttachOptions)(4));
			w35.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.label22 = new global::Gtk.Label ();
			this.label22.Name = "label22";
			this.label22.Xalign = 0F;
			this.label22.LabelProp = global::Mono.Unix.Catalog.GetString ("Between other member declarations:");
			this.table3.Add (this.label22);
			global::Gtk.Table.TableChild w36 = ((global::Gtk.Table.TableChild)(this.table3[this.label22]));
			w36.TopAttach = ((uint)(1));
			w36.BottomAttach = ((uint)(2));
			w36.XOptions = ((global::Gtk.AttachOptions)(4));
			w36.YOptions = ((global::Gtk.AttachOptions)(4));
			this.GtkAlignment8.Add (this.table3);
			this.frame7.Add (this.GtkAlignment8);
			this.GtkLabel9 = new global::Gtk.Label ();
			this.GtkLabel9.Name = "GtkLabel9";
			this.GtkLabel9.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Blank lines in types</b>");
			this.GtkLabel9.UseMarkup = true;
			this.frame7.LabelWidget = this.GtkLabel9;
			this.vbox10.Add (this.frame7);
			global::Gtk.Box.BoxChild w39 = ((global::Gtk.Box.BoxChild)(this.vbox10[this.frame7]));
			w39.Position = 2;
			w39.Expand = false;
			w39.Fill = false;
			this.notebookCategories.Add (this.vbox10);
			global::Gtk.Notebook.NotebookChild w40 = ((global::Gtk.Notebook.NotebookChild)(this.notebookCategories[this.vbox10]));
			w40.Position = 2;
			// Notebook tab
			this.label14 = new global::Gtk.Label ();
			this.label14.Name = "label14";
			this.label14.LabelProp = global::Mono.Unix.Catalog.GetString ("page5");
			this.notebookCategories.SetTabLabel (this.vbox10,this.label14);
			this.label14.ShowAll ();
			// Container child notebookCategories.Gtk.Notebook+NotebookChild
			this.frame3 = new global::Gtk.Frame ();
			this.frame3.Name = "frame3";
			this.frame3.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame3.Gtk.Container+ContainerChild
			this.GtkAlignment4 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment4.Name = "GtkAlignment4";
			// Container child GtkAlignment4.Gtk.Container+ContainerChild
			this.vpaned1 = new global::Gtk.VPaned ();
			this.vpaned1.CanFocus = true;
			this.vpaned1.Name = "vpaned1";
			this.vpaned1.Position = 168;
			// Container child vpaned1.Gtk.Paned+PanedChild
			this.GtkScrolledWindow2 = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow2.Name = "GtkScrolledWindow2";
			this.GtkScrolledWindow2.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow2.Gtk.Container+ContainerChild
			this.treeviewInsertWhiteSpaceCategory = new global::Gtk.TreeView ();
			this.treeviewInsertWhiteSpaceCategory.CanFocus = true;
			this.treeviewInsertWhiteSpaceCategory.Name = "treeviewInsertWhiteSpaceCategory";
			this.GtkScrolledWindow2.Add (this.treeviewInsertWhiteSpaceCategory);
			this.vpaned1.Add (this.GtkScrolledWindow2);
			global::Gtk.Paned.PanedChild w42 = ((global::Gtk.Paned.PanedChild)(this.vpaned1[this.GtkScrolledWindow2]));
			w42.Resize = false;
			// Container child vpaned1.Gtk.Paned+PanedChild
			this.GtkScrolledWindow3 = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow3.Name = "GtkScrolledWindow3";
			this.GtkScrolledWindow3.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow3.Gtk.Container+ContainerChild
			this.treeviewInsertWhiteSpaceOptions = new global::Gtk.TreeView ();
			this.treeviewInsertWhiteSpaceOptions.CanFocus = true;
			this.treeviewInsertWhiteSpaceOptions.Name = "treeviewInsertWhiteSpaceOptions";
			this.GtkScrolledWindow3.Add (this.treeviewInsertWhiteSpaceOptions);
			this.vpaned1.Add (this.GtkScrolledWindow3);
			this.GtkAlignment4.Add (this.vpaned1);
			this.frame3.Add (this.GtkAlignment4);
			this.GtkLabel5 = new global::Gtk.Label ();
			this.GtkLabel5.Name = "GtkLabel5";
			this.GtkLabel5.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Insert Space</b>");
			this.GtkLabel5.UseMarkup = true;
			this.frame3.LabelWidget = this.GtkLabel5;
			this.notebookCategories.Add (this.frame3);
			global::Gtk.Notebook.NotebookChild w47 = ((global::Gtk.Notebook.NotebookChild)(this.notebookCategories[this.frame3]));
			w47.Position = 3;
			// Notebook tab
			this.label10 = new global::Gtk.Label ();
			this.label10.Name = "label10";
			this.label10.LabelProp = global::Mono.Unix.Catalog.GetString ("page3");
			this.notebookCategories.SetTabLabel (this.frame3,this.label10);
			this.label10.ShowAll ();
			// Container child notebookCategories.Gtk.Notebook+NotebookChild
			this.frame4 = new global::Gtk.Frame ();
			this.frame4.Name = "frame4";
			this.frame4.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame4.Gtk.Container+ContainerChild
			this.GtkAlignment5 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment5.Name = "GtkAlignment5";
			// Container child GtkAlignment5.Gtk.Container+ContainerChild
			this.GtkScrolledWindow4 = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow4.Name = "GtkScrolledWindow4";
			this.GtkScrolledWindow4.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow4.Gtk.Container+ContainerChild
			this.treeviewNewLines = new global::Gtk.TreeView ();
			this.treeviewNewLines.CanFocus = true;
			this.treeviewNewLines.Name = "treeviewNewLines";
			this.GtkScrolledWindow4.Add (this.treeviewNewLines);
			this.GtkAlignment5.Add (this.GtkScrolledWindow4);
			this.frame4.Add (this.GtkAlignment5);
			this.GtkLabel6 = new global::Gtk.Label ();
			this.GtkLabel6.Name = "GtkLabel6";
			this.GtkLabel6.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>New Lines</b>");
			this.GtkLabel6.UseMarkup = true;
			this.frame4.LabelWidget = this.GtkLabel6;
			this.notebookCategories.Add (this.frame4);
			global::Gtk.Notebook.NotebookChild w51 = ((global::Gtk.Notebook.NotebookChild)(this.notebookCategories[this.frame4]));
			w51.Position = 4;
			// Notebook tab
			this.label11 = new global::Gtk.Label ();
			this.label11.Name = "label11";
			this.label11.LabelProp = global::Mono.Unix.Catalog.GetString ("page4");
			this.notebookCategories.SetTabLabel (this.frame4,this.label11);
			this.label11.ShowAll ();
			this.hpaned1.Add (this.notebookCategories);
			global::Gtk.Paned.PanedChild w52 = ((global::Gtk.Paned.PanedChild)(this.hpaned1[this.notebookCategories]));
			w52.Resize = false;
			// Container child hpaned1.Gtk.Paned+PanedChild
			this.vbox6 = new global::Gtk.VBox ();
			this.vbox6.Name = "vbox6";
			this.vbox6.Spacing = 6;
			// Container child vbox6.Gtk.Box+BoxChild
			this.label13 = new global::Gtk.Label ();
			this.label13.Name = "label13";
			this.label13.Xalign = 0F;
			this.label13.LabelProp = global::Mono.Unix.Catalog.GetString ("Preview:");
			this.vbox6.Add (this.label13);
			global::Gtk.Box.BoxChild w53 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.label13]));
			w53.Position = 0;
			w53.Expand = false;
			w53.Fill = false;
			// Container child vbox6.Gtk.Box+BoxChild
			this.scrolledwindow = new global::Gtk.ScrolledWindow ();
			this.scrolledwindow.CanFocus = true;
			this.scrolledwindow.Name = "scrolledwindow";
			this.scrolledwindow.ShadowType = ((global::Gtk.ShadowType)(1));
			this.vbox6.Add (this.scrolledwindow);
			global::Gtk.Box.BoxChild w54 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.scrolledwindow]));
			w54.Position = 1;
			this.hpaned1.Add (this.vbox6);
			this.vbox5.Add (this.hpaned1);
			global::Gtk.Box.BoxChild w56 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.hpaned1]));
			w56.Position = 2;
			w1.Add (this.vbox5);
			global::Gtk.Box.BoxChild w57 = ((global::Gtk.Box.BoxChild)(w1[this.vbox5]));
			w57.Position = 0;
			// Internal child MonoDevelop.CSharp.Formatting.CSharpFormattingProfileDialog.ActionArea
			global::Gtk.HButtonBox w58 = this.ActionArea;
			w58.Name = "dialog1_ActionArea";
			w58.Spacing = 10;
			w58.BorderWidth = ((uint)(5));
			w58.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-cancel";
			this.AddActionWidget (this.buttonCancel,-6);
			global::Gtk.ButtonBox.ButtonBoxChild w59 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w58[this.buttonCancel]));
			w59.Expand = false;
			w59.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			this.AddActionWidget (this.buttonOk,-5);
			global::Gtk.ButtonBox.ButtonBoxChild w60 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w58[this.buttonOk]));
			w60.Position = 1;
			w60.Expand = false;
			w60.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 880;
			this.DefaultHeight = 551;
			this.label5.MnemonicWidget = this.entryName;
			this.Show ();
		}
	}
}
