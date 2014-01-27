﻿/* oio : 12/27/2013 2:03 AM */
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Web.UI.WebControls;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using FirstFloor.ModernUI.Presentation;
using FirstFloor.ModernUI.Windows;
using FirstFloor.ModernUI.Windows.Controls;
using FirstFloor.ModernUI.Windows.Controls;
using FirstFloor.ModernUI.Windows.Media;
using FirstFloor.ModernUI.Windows.Navigation;
using ICSharpCode.SharpDevelop;

namespace GeneratorTool.Views
{
	/// <summary>
	/// Interaction logic for MuiModern.xaml
	/// </summary>
	public partial class MuiModern : ModernWindow
	{
		public ModernFrame Frame { get;set; }
		// #a6cd5f
		public MuiModern()
		{
			//FontFamily="/assets/typo/#Roboto 900"
			InitializeComponent();
//			this.GetValue(DependencyObject
			
			//System.Diagnostics.Debug.WriteLine("We have: {0}",this.);
			mainLinks.Links.Add(
				new Link(){
					DisplayName="GENERATOR",
					Source = new Uri("/1",UriKind.RelativeOrAbsolute)
				});
			mainLinks.Links.Add(
				new Link(){
					DisplayName="TEMPLATE",
					Source = new Uri("/2",UriKind.RelativeOrAbsolute),
				});
			mainLinks.Links.Add(
				new Link(){
					DisplayName="3",
					Source = new Uri("/3",UriKind.RelativeOrAbsolute),
				});
			mainLinks.Links.Add(
				new Link(){
					DisplayName="4",
					Source = new Uri("/4",UriKind.RelativeOrAbsolute),
				});
			
		}
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			Frame = GetTemplateChild("ContentFrame") as ModernFrame;
			Debug.WriteLine("FRAME: {0}",Frame);
			
			Frame.Navigating += (sender,e) => ;
		}
		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);
		}
	}
}