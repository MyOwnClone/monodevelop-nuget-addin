
// This file has been generated by the GUI designer. Do not modify.
namespace MonoDevelop.PackageManagement
{
	public partial class PackagesWidget
	{
		private global::Gtk.HPaned mainPane;
		private global::Gtk.VBox packagesListVBox;
		private global::Gtk.ScrolledWindow packagesTreeScrolledWindow;
		private global::Gtk.TreeView packagesTreeView;
		private global::Gtk.HBox pagedResultsHBox;
		private global::Gtk.Label pagedResultsLeftLabel;
		private global::MonoDevelop.PackageManagement.PagedResultsWidget pagedResultsWidget;
		private global::Gtk.Label pagedResultsRightLabel;
		private global::Gtk.VBox packageInfoVBox;
		private global::Gtk.ComboBox packageSourceComboBox;
		private global::Gtk.HBox packageSearchHBox;
		private global::Gtk.Entry packageSearchEntry;
		private global::Gtk.Button packageSearchButton;
		private global::Gtk.CheckButton includePrereleaseCheckButton;
		private global::Gtk.Frame packageInfoFrame;
		private global::Gtk.Alignment packageInfoFrameAlignment;
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		private global::Gtk.VBox packageInfoFrameVBox;
		private global::Gtk.HBox packageCreatedByHBox;
		private global::Gtk.Label packageCreatedByLabel;
		private global::Gtk.Label packageCreatedByTextBox;
		private global::Gtk.HBox packageVersionHBox;
		private global::Gtk.Label packageVersionLabel;
		private global::Gtk.Label packageVersionTextBox;
		private global::Gtk.HBox packageLastUpdatedHBox;
		private global::Gtk.Label packageLastUpdatedLabel;
		private global::Gtk.Label packageLastUpdatedTextBox;
		private global::Gtk.HBox packageDownloadsHBox;
		private global::Gtk.Label packageDownloadsLabel;
		private global::Gtk.Label packageDownloadsTextBox;
		private global::Gtk.HBox viewLicenseTermsHBox;
		private global::MonoDevelop.PackageManagement.HyperlinkWidget viewLicenseTermsButton;
		private global::Gtk.HBox moreInformationHBox;
		private global::MonoDevelop.PackageManagement.HyperlinkWidget moreInformationButton;
		private global::Gtk.TextView packageDescriptionTextView;
		private global::Gtk.HBox packageDependenciesHBox;
		private global::Gtk.Label packageDependenciesLabel;
		private global::Gtk.Label packageDependenciesNoneLabel;
		private global::Gtk.HBox packageDependenciesListHBox;
		private global::Gtk.Label packageDependenciesListLabel;
		private global::Gtk.Label packageDependenciesListFillerLabel;
		private global::Gtk.HButtonBox managePackageButtonBox;
		private global::Gtk.Button addPackageButton;
		private global::Gtk.Button removePackageButton;
		private global::Gtk.Button managePackageButton;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MonoDevelop.PackageManagement.PackagesWidget
			global::Stetic.BinContainer.Attach (this);
			this.Name = "MonoDevelop.PackageManagement.PackagesWidget";
			// Container child MonoDevelop.PackageManagement.PackagesWidget.Gtk.Container+ContainerChild
			this.mainPane = new global::Gtk.HPaned ();
			this.mainPane.CanFocus = true;
			this.mainPane.Name = "mainPane";
			this.mainPane.Position = 322;
			// Container child mainPane.Gtk.Paned+PanedChild
			this.packagesListVBox = new global::Gtk.VBox ();
			this.packagesListVBox.Name = "packagesListVBox";
			this.packagesListVBox.Spacing = 6;
			// Container child packagesListVBox.Gtk.Box+BoxChild
			this.packagesTreeScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.packagesTreeScrolledWindow.Name = "packagesTreeScrolledWindow";
			this.packagesTreeScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child packagesTreeScrolledWindow.Gtk.Container+ContainerChild
			this.packagesTreeView = new global::Gtk.TreeView ();
			this.packagesTreeView.CanFocus = true;
			this.packagesTreeView.Name = "packagesTreeView";
			this.packagesTreeView.EnableSearch = false;
			this.packagesTreeView.HeadersVisible = false;
			this.packagesTreeScrolledWindow.Add (this.packagesTreeView);
			this.packagesListVBox.Add (this.packagesTreeScrolledWindow);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.packagesListVBox [this.packagesTreeScrolledWindow]));
			w2.Position = 0;
			// Container child packagesListVBox.Gtk.Box+BoxChild
			this.pagedResultsHBox = new global::Gtk.HBox ();
			this.pagedResultsHBox.Name = "pagedResultsHBox";
			this.pagedResultsHBox.Spacing = 6;
			// Container child pagedResultsHBox.Gtk.Box+BoxChild
			this.pagedResultsLeftLabel = new global::Gtk.Label ();
			this.pagedResultsLeftLabel.Name = "pagedResultsLeftLabel";
			this.pagedResultsHBox.Add (this.pagedResultsLeftLabel);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.pagedResultsHBox [this.pagedResultsLeftLabel]));
			w3.Position = 0;
			// Container child pagedResultsHBox.Gtk.Box+BoxChild
			this.pagedResultsWidget = new global::MonoDevelop.PackageManagement.PagedResultsWidget ();
			this.pagedResultsWidget.Events = ((global::Gdk.EventMask)(256));
			this.pagedResultsWidget.Name = "pagedResultsWidget";
			this.pagedResultsHBox.Add (this.pagedResultsWidget);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.pagedResultsHBox [this.pagedResultsWidget]));
			w4.Position = 1;
			w4.Expand = false;
			w4.Fill = false;
			// Container child pagedResultsHBox.Gtk.Box+BoxChild
			this.pagedResultsRightLabel = new global::Gtk.Label ();
			this.pagedResultsRightLabel.Name = "pagedResultsRightLabel";
			this.pagedResultsHBox.Add (this.pagedResultsRightLabel);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.pagedResultsHBox [this.pagedResultsRightLabel]));
			w5.Position = 2;
			this.packagesListVBox.Add (this.pagedResultsHBox);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.packagesListVBox [this.pagedResultsHBox]));
			w6.Position = 1;
			w6.Expand = false;
			w6.Fill = false;
			this.mainPane.Add (this.packagesListVBox);
			global::Gtk.Paned.PanedChild w7 = ((global::Gtk.Paned.PanedChild)(this.mainPane [this.packagesListVBox]));
			w7.Resize = false;
			// Container child mainPane.Gtk.Paned+PanedChild
			this.packageInfoVBox = new global::Gtk.VBox ();
			this.packageInfoVBox.Name = "packageInfoVBox";
			this.packageInfoVBox.Spacing = 6;
			// Container child packageInfoVBox.Gtk.Box+BoxChild
			this.packageSourceComboBox = global::Gtk.ComboBox.NewText ();
			this.packageSourceComboBox.Name = "packageSourceComboBox";
			this.packageInfoVBox.Add (this.packageSourceComboBox);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.packageInfoVBox [this.packageSourceComboBox]));
			w8.Position = 0;
			w8.Expand = false;
			w8.Fill = false;
			// Container child packageInfoVBox.Gtk.Box+BoxChild
			this.packageSearchHBox = new global::Gtk.HBox ();
			this.packageSearchHBox.Name = "packageSearchHBox";
			this.packageSearchHBox.Spacing = 6;
			// Container child packageSearchHBox.Gtk.Box+BoxChild
			this.packageSearchEntry = new global::Gtk.Entry ();
			this.packageSearchEntry.CanFocus = true;
			this.packageSearchEntry.Name = "packageSearchEntry";
			this.packageSearchEntry.IsEditable = true;
			this.packageSearchEntry.InvisibleChar = '●';
			this.packageSearchHBox.Add (this.packageSearchEntry);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.packageSearchHBox [this.packageSearchEntry]));
			w9.Position = 0;
			// Container child packageSearchHBox.Gtk.Box+BoxChild
			this.packageSearchButton = new global::Gtk.Button ();
			this.packageSearchButton.CanFocus = true;
			this.packageSearchButton.Name = "packageSearchButton";
			this.packageSearchButton.UseUnderline = true;
			// Container child packageSearchButton.Gtk.Container+ContainerChild
			global::Gtk.Alignment w10 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w11 = new global::Gtk.HBox ();
			w11.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w12 = new global::Gtk.Image ();
			w12.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-find", global::Gtk.IconSize.Menu);
			w11.Add (w12);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w14 = new global::Gtk.Label ();
			w11.Add (w14);
			w10.Add (w11);
			this.packageSearchButton.Add (w10);
			this.packageSearchHBox.Add (this.packageSearchButton);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.packageSearchHBox [this.packageSearchButton]));
			w18.Position = 1;
			w18.Expand = false;
			w18.Fill = false;
			this.packageInfoVBox.Add (this.packageSearchHBox);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.packageInfoVBox [this.packageSearchHBox]));
			w19.Position = 1;
			w19.Expand = false;
			w19.Fill = false;
			// Container child packageInfoVBox.Gtk.Box+BoxChild
			this.includePrereleaseCheckButton = new global::Gtk.CheckButton ();
			this.includePrereleaseCheckButton.CanFocus = true;
			this.includePrereleaseCheckButton.Name = "includePrereleaseCheckButton";
			this.includePrereleaseCheckButton.Label = global::Mono.Unix.Catalog.GetString ("Include Prerelease");
			this.includePrereleaseCheckButton.DrawIndicator = true;
			this.includePrereleaseCheckButton.UseUnderline = true;
			this.packageInfoVBox.Add (this.includePrereleaseCheckButton);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.packageInfoVBox [this.includePrereleaseCheckButton]));
			w20.Position = 2;
			w20.Expand = false;
			w20.Fill = false;
			// Container child packageInfoVBox.Gtk.Box+BoxChild
			this.packageInfoFrame = new global::Gtk.Frame ();
			this.packageInfoFrame.Name = "packageInfoFrame";
			this.packageInfoFrame.ShadowType = ((global::Gtk.ShadowType)(0));
			this.packageInfoFrame.LabelYalign = 0F;
			// Container child packageInfoFrame.Gtk.Container+ContainerChild
			this.packageInfoFrameAlignment = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.packageInfoFrameAlignment.Name = "packageInfoFrameAlignment";
			// Container child packageInfoFrameAlignment.Gtk.Container+ContainerChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			global::Gtk.Viewport w21 = new global::Gtk.Viewport ();
			w21.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child GtkViewport.Gtk.Container+ContainerChild
			this.packageInfoFrameVBox = new global::Gtk.VBox ();
			this.packageInfoFrameVBox.Name = "packageInfoFrameVBox";
			this.packageInfoFrameVBox.Spacing = 6;
			// Container child packageInfoFrameVBox.Gtk.Box+BoxChild
			this.packageCreatedByHBox = new global::Gtk.HBox ();
			this.packageCreatedByHBox.Name = "packageCreatedByHBox";
			this.packageCreatedByHBox.Spacing = 6;
			// Container child packageCreatedByHBox.Gtk.Box+BoxChild
			this.packageCreatedByLabel = new global::Gtk.Label ();
			this.packageCreatedByLabel.Name = "packageCreatedByLabel";
			this.packageCreatedByLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("<span weight=\'bold\'>Created by:</span>");
			this.packageCreatedByLabel.UseMarkup = true;
			this.packageCreatedByHBox.Add (this.packageCreatedByLabel);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.packageCreatedByHBox [this.packageCreatedByLabel]));
			w22.Position = 0;
			w22.Expand = false;
			w22.Fill = false;
			// Container child packageCreatedByHBox.Gtk.Box+BoxChild
			this.packageCreatedByTextBox = new global::Gtk.Label ();
			this.packageCreatedByTextBox.Name = "packageCreatedByTextBox";
			this.packageCreatedByTextBox.Selectable = true;
			this.packageCreatedByHBox.Add (this.packageCreatedByTextBox);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.packageCreatedByHBox [this.packageCreatedByTextBox]));
			w23.Position = 1;
			w23.Expand = false;
			w23.Fill = false;
			this.packageInfoFrameVBox.Add (this.packageCreatedByHBox);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.packageInfoFrameVBox [this.packageCreatedByHBox]));
			w24.Position = 0;
			w24.Expand = false;
			w24.Fill = false;
			// Container child packageInfoFrameVBox.Gtk.Box+BoxChild
			this.packageVersionHBox = new global::Gtk.HBox ();
			this.packageVersionHBox.Name = "packageVersionHBox";
			this.packageVersionHBox.Spacing = 6;
			// Container child packageVersionHBox.Gtk.Box+BoxChild
			this.packageVersionLabel = new global::Gtk.Label ();
			this.packageVersionLabel.Name = "packageVersionLabel";
			this.packageVersionLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("<span weight=\'bold\'>Version:</span>");
			this.packageVersionLabel.UseMarkup = true;
			this.packageVersionHBox.Add (this.packageVersionLabel);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.packageVersionHBox [this.packageVersionLabel]));
			w25.Position = 0;
			w25.Expand = false;
			w25.Fill = false;
			// Container child packageVersionHBox.Gtk.Box+BoxChild
			this.packageVersionTextBox = new global::Gtk.Label ();
			this.packageVersionTextBox.Name = "packageVersionTextBox";
			this.packageVersionTextBox.Selectable = true;
			this.packageVersionHBox.Add (this.packageVersionTextBox);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.packageVersionHBox [this.packageVersionTextBox]));
			w26.Position = 1;
			w26.Expand = false;
			w26.Fill = false;
			this.packageInfoFrameVBox.Add (this.packageVersionHBox);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.packageInfoFrameVBox [this.packageVersionHBox]));
			w27.Position = 1;
			w27.Expand = false;
			w27.Fill = false;
			// Container child packageInfoFrameVBox.Gtk.Box+BoxChild
			this.packageLastUpdatedHBox = new global::Gtk.HBox ();
			this.packageLastUpdatedHBox.Name = "packageLastUpdatedHBox";
			this.packageLastUpdatedHBox.Spacing = 6;
			// Container child packageLastUpdatedHBox.Gtk.Box+BoxChild
			this.packageLastUpdatedLabel = new global::Gtk.Label ();
			this.packageLastUpdatedLabel.Name = "packageLastUpdatedLabel";
			this.packageLastUpdatedLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("<span weight=\'bold\'>Last Updated:</span>");
			this.packageLastUpdatedLabel.UseMarkup = true;
			this.packageLastUpdatedHBox.Add (this.packageLastUpdatedLabel);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.packageLastUpdatedHBox [this.packageLastUpdatedLabel]));
			w28.Position = 0;
			w28.Expand = false;
			w28.Fill = false;
			// Container child packageLastUpdatedHBox.Gtk.Box+BoxChild
			this.packageLastUpdatedTextBox = new global::Gtk.Label ();
			this.packageLastUpdatedTextBox.Name = "packageLastUpdatedTextBox";
			this.packageLastUpdatedTextBox.Selectable = true;
			this.packageLastUpdatedHBox.Add (this.packageLastUpdatedTextBox);
			global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.packageLastUpdatedHBox [this.packageLastUpdatedTextBox]));
			w29.Position = 1;
			w29.Expand = false;
			w29.Fill = false;
			this.packageInfoFrameVBox.Add (this.packageLastUpdatedHBox);
			global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.packageInfoFrameVBox [this.packageLastUpdatedHBox]));
			w30.Position = 2;
			w30.Expand = false;
			w30.Fill = false;
			// Container child packageInfoFrameVBox.Gtk.Box+BoxChild
			this.packageDownloadsHBox = new global::Gtk.HBox ();
			this.packageDownloadsHBox.Name = "packageDownloadsHBox";
			this.packageDownloadsHBox.Spacing = 6;
			// Container child packageDownloadsHBox.Gtk.Box+BoxChild
			this.packageDownloadsLabel = new global::Gtk.Label ();
			this.packageDownloadsLabel.Name = "packageDownloadsLabel";
			this.packageDownloadsLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("<span weight=\'bold\'>Downloads:</span>");
			this.packageDownloadsLabel.UseMarkup = true;
			this.packageDownloadsHBox.Add (this.packageDownloadsLabel);
			global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.packageDownloadsHBox [this.packageDownloadsLabel]));
			w31.Position = 0;
			w31.Expand = false;
			w31.Fill = false;
			// Container child packageDownloadsHBox.Gtk.Box+BoxChild
			this.packageDownloadsTextBox = new global::Gtk.Label ();
			this.packageDownloadsTextBox.Name = "packageDownloadsTextBox";
			this.packageDownloadsTextBox.Selectable = true;
			this.packageDownloadsHBox.Add (this.packageDownloadsTextBox);
			global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.packageDownloadsHBox [this.packageDownloadsTextBox]));
			w32.Position = 1;
			w32.Expand = false;
			w32.Fill = false;
			this.packageInfoFrameVBox.Add (this.packageDownloadsHBox);
			global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.packageInfoFrameVBox [this.packageDownloadsHBox]));
			w33.Position = 3;
			w33.Expand = false;
			w33.Fill = false;
			// Container child packageInfoFrameVBox.Gtk.Box+BoxChild
			this.viewLicenseTermsHBox = new global::Gtk.HBox ();
			this.viewLicenseTermsHBox.Name = "viewLicenseTermsHBox";
			this.viewLicenseTermsHBox.Spacing = 6;
			// Container child viewLicenseTermsHBox.Gtk.Box+BoxChild
			this.viewLicenseTermsButton = new global::MonoDevelop.PackageManagement.HyperlinkWidget ();
			this.viewLicenseTermsButton.Events = ((global::Gdk.EventMask)(256));
			this.viewLicenseTermsButton.Name = "viewLicenseTermsButton";
			this.viewLicenseTermsButton.Uri = "";
			this.viewLicenseTermsButton.Label = "View License Terms";
			this.viewLicenseTermsHBox.Add (this.viewLicenseTermsButton);
			global::Gtk.Box.BoxChild w34 = ((global::Gtk.Box.BoxChild)(this.viewLicenseTermsHBox [this.viewLicenseTermsButton]));
			w34.Position = 0;
			this.packageInfoFrameVBox.Add (this.viewLicenseTermsHBox);
			global::Gtk.Box.BoxChild w35 = ((global::Gtk.Box.BoxChild)(this.packageInfoFrameVBox [this.viewLicenseTermsHBox]));
			w35.Position = 4;
			w35.Expand = false;
			w35.Fill = false;
			// Container child packageInfoFrameVBox.Gtk.Box+BoxChild
			this.moreInformationHBox = new global::Gtk.HBox ();
			this.moreInformationHBox.Name = "moreInformationHBox";
			// Container child moreInformationHBox.Gtk.Box+BoxChild
			this.moreInformationButton = new global::MonoDevelop.PackageManagement.HyperlinkWidget ();
			this.moreInformationButton.Events = ((global::Gdk.EventMask)(256));
			this.moreInformationButton.Name = "moreInformationButton";
			this.moreInformationButton.Uri = "";
			this.moreInformationButton.Label = "More Information";
			this.moreInformationHBox.Add (this.moreInformationButton);
			global::Gtk.Box.BoxChild w36 = ((global::Gtk.Box.BoxChild)(this.moreInformationHBox [this.moreInformationButton]));
			w36.Position = 0;
			this.packageInfoFrameVBox.Add (this.moreInformationHBox);
			global::Gtk.Box.BoxChild w37 = ((global::Gtk.Box.BoxChild)(this.packageInfoFrameVBox [this.moreInformationHBox]));
			w37.Position = 5;
			w37.Expand = false;
			// Container child packageInfoFrameVBox.Gtk.Box+BoxChild
			this.packageDescriptionTextView = new global::Gtk.TextView ();
			this.packageDescriptionTextView.CanFocus = true;
			this.packageDescriptionTextView.Name = "packageDescriptionTextView";
			this.packageDescriptionTextView.Editable = false;
			this.packageDescriptionTextView.CursorVisible = false;
			this.packageDescriptionTextView.WrapMode = ((global::Gtk.WrapMode)(2));
			this.packageInfoFrameVBox.Add (this.packageDescriptionTextView);
			global::Gtk.Box.BoxChild w38 = ((global::Gtk.Box.BoxChild)(this.packageInfoFrameVBox [this.packageDescriptionTextView]));
			w38.Position = 6;
			// Container child packageInfoFrameVBox.Gtk.Box+BoxChild
			this.packageDependenciesHBox = new global::Gtk.HBox ();
			this.packageDependenciesHBox.Name = "packageDependenciesHBox";
			this.packageDependenciesHBox.Spacing = 6;
			// Container child packageDependenciesHBox.Gtk.Box+BoxChild
			this.packageDependenciesLabel = new global::Gtk.Label ();
			this.packageDependenciesLabel.Name = "packageDependenciesLabel";
			this.packageDependenciesLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("<span weight=\'bold\'>Dependencies:</span>");
			this.packageDependenciesLabel.UseMarkup = true;
			this.packageDependenciesHBox.Add (this.packageDependenciesLabel);
			global::Gtk.Box.BoxChild w39 = ((global::Gtk.Box.BoxChild)(this.packageDependenciesHBox [this.packageDependenciesLabel]));
			w39.Position = 0;
			w39.Expand = false;
			w39.Fill = false;
			// Container child packageDependenciesHBox.Gtk.Box+BoxChild
			this.packageDependenciesNoneLabel = new global::Gtk.Label ();
			this.packageDependenciesNoneLabel.Name = "packageDependenciesNoneLabel";
			this.packageDependenciesNoneLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("None");
			this.packageDependenciesNoneLabel.Selectable = true;
			this.packageDependenciesHBox.Add (this.packageDependenciesNoneLabel);
			global::Gtk.Box.BoxChild w40 = ((global::Gtk.Box.BoxChild)(this.packageDependenciesHBox [this.packageDependenciesNoneLabel]));
			w40.Position = 1;
			w40.Expand = false;
			w40.Fill = false;
			this.packageInfoFrameVBox.Add (this.packageDependenciesHBox);
			global::Gtk.Box.BoxChild w41 = ((global::Gtk.Box.BoxChild)(this.packageInfoFrameVBox [this.packageDependenciesHBox]));
			w41.Position = 7;
			w41.Expand = false;
			w41.Fill = false;
			// Container child packageInfoFrameVBox.Gtk.Box+BoxChild
			this.packageDependenciesListHBox = new global::Gtk.HBox ();
			this.packageDependenciesListHBox.Name = "packageDependenciesListHBox";
			this.packageDependenciesListHBox.Spacing = 6;
			this.packageDependenciesListHBox.BorderWidth = ((uint)(2));
			// Container child packageDependenciesListHBox.Gtk.Box+BoxChild
			this.packageDependenciesListLabel = new global::Gtk.Label ();
			this.packageDependenciesListLabel.Name = "packageDependenciesListLabel";
			this.packageDependenciesListLabel.UseMarkup = true;
			this.packageDependenciesListHBox.Add (this.packageDependenciesListLabel);
			global::Gtk.Box.BoxChild w42 = ((global::Gtk.Box.BoxChild)(this.packageDependenciesListHBox [this.packageDependenciesListLabel]));
			w42.Position = 0;
			w42.Expand = false;
			w42.Fill = false;
			// Container child packageDependenciesListHBox.Gtk.Box+BoxChild
			this.packageDependenciesListFillerLabel = new global::Gtk.Label ();
			this.packageDependenciesListFillerLabel.Name = "packageDependenciesListFillerLabel";
			this.packageDependenciesListFillerLabel.Selectable = true;
			this.packageDependenciesListHBox.Add (this.packageDependenciesListFillerLabel);
			global::Gtk.Box.BoxChild w43 = ((global::Gtk.Box.BoxChild)(this.packageDependenciesListHBox [this.packageDependenciesListFillerLabel]));
			w43.Position = 1;
			this.packageInfoFrameVBox.Add (this.packageDependenciesListHBox);
			global::Gtk.Box.BoxChild w44 = ((global::Gtk.Box.BoxChild)(this.packageInfoFrameVBox [this.packageDependenciesListHBox]));
			w44.Position = 8;
			w44.Expand = false;
			w44.Fill = false;
			w21.Add (this.packageInfoFrameVBox);
			this.GtkScrolledWindow.Add (w21);
			this.packageInfoFrameAlignment.Add (this.GtkScrolledWindow);
			this.packageInfoFrame.Add (this.packageInfoFrameAlignment);
			this.packageInfoVBox.Add (this.packageInfoFrame);
			global::Gtk.Box.BoxChild w49 = ((global::Gtk.Box.BoxChild)(this.packageInfoVBox [this.packageInfoFrame]));
			w49.Position = 3;
			// Container child packageInfoVBox.Gtk.Box+BoxChild
			this.managePackageButtonBox = new global::Gtk.HButtonBox ();
			this.managePackageButtonBox.Name = "managePackageButtonBox";
			this.managePackageButtonBox.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(3));
			// Container child managePackageButtonBox.Gtk.ButtonBox+ButtonBoxChild
			this.addPackageButton = new global::Gtk.Button ();
			this.addPackageButton.CanFocus = true;
			this.addPackageButton.Name = "addPackageButton";
			this.addPackageButton.UseUnderline = true;
			this.addPackageButton.Label = global::Mono.Unix.Catalog.GetString ("Add");
			this.managePackageButtonBox.Add (this.addPackageButton);
			global::Gtk.ButtonBox.ButtonBoxChild w50 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.managePackageButtonBox [this.addPackageButton]));
			w50.Expand = false;
			w50.Fill = false;
			// Container child managePackageButtonBox.Gtk.ButtonBox+ButtonBoxChild
			this.removePackageButton = new global::Gtk.Button ();
			this.removePackageButton.CanFocus = true;
			this.removePackageButton.Name = "removePackageButton";
			this.removePackageButton.UseUnderline = true;
			this.removePackageButton.Label = global::Mono.Unix.Catalog.GetString ("Remove");
			this.managePackageButtonBox.Add (this.removePackageButton);
			global::Gtk.ButtonBox.ButtonBoxChild w51 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.managePackageButtonBox [this.removePackageButton]));
			w51.Position = 1;
			w51.Expand = false;
			w51.Fill = false;
			// Container child managePackageButtonBox.Gtk.ButtonBox+ButtonBoxChild
			this.managePackageButton = new global::Gtk.Button ();
			this.managePackageButton.CanFocus = true;
			this.managePackageButton.Name = "managePackageButton";
			this.managePackageButton.UseUnderline = true;
			this.managePackageButton.Label = global::Mono.Unix.Catalog.GetString ("Manage");
			this.managePackageButtonBox.Add (this.managePackageButton);
			global::Gtk.ButtonBox.ButtonBoxChild w52 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.managePackageButtonBox [this.managePackageButton]));
			w52.Position = 2;
			w52.Expand = false;
			w52.Fill = false;
			this.packageInfoVBox.Add (this.managePackageButtonBox);
			global::Gtk.Box.BoxChild w53 = ((global::Gtk.Box.BoxChild)(this.packageInfoVBox [this.managePackageButtonBox]));
			w53.PackType = ((global::Gtk.PackType)(1));
			w53.Position = 4;
			w53.Expand = false;
			w53.Fill = false;
			this.mainPane.Add (this.packageInfoVBox);
			this.Add (this.mainPane);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.packageInfoFrameVBox.Hide ();
			this.addPackageButton.Hide ();
			this.removePackageButton.Hide ();
			this.managePackageButton.Hide ();
			this.Hide ();
			this.packageSourceComboBox.Changed += new global::System.EventHandler (this.PackageSourceChanged);
			this.packageSearchEntry.Activated += new global::System.EventHandler (this.PackageSearchEntryActivated);
			this.packageSearchButton.Clicked += new global::System.EventHandler (this.SearchButtonClicked);
			this.addPackageButton.Clicked += new global::System.EventHandler (this.OnAddPackageButtonClicked);
			this.removePackageButton.Clicked += new global::System.EventHandler (this.RemovePackageButtonClicked);
			this.managePackageButton.Clicked += new global::System.EventHandler (this.ManagePackagesButtonClicked);
		}
	}
}
