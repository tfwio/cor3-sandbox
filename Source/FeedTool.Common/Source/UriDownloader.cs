﻿
using System;
using System.ComponentModel;
using System.Net;

namespace FeedTool
{
	public class UriProgress
	{
		[System.ComponentModel.DefaultValue(false)]
		public bool Cancelled { get;set; }
		public bool IsEnabled { get;set; }
		public long ByteProgress { get;set; }
		public long ByteLength { get;set; }
		public int Percentage { get;set; }
	}
	public class UriDownloader : INotifyPropertyChanged
	{
		#region Crap
		// this didn't work.
		class WebClientTest : WebClient
		{
			public bool HeadOnly { get; set; }
			public WebClientTest():base(){}
			protected override WebRequest GetWebRequest(Uri address)
			{
				WebRequest req = base.GetWebRequest(address);
				if (HeadOnly && req.Method == "GET")
				{
					req.Method = "HEAD";
				}
				return req;
			}
		}

		#endregion
		/// <summary>
		/// The data that has been retrieved.
		/// </summary>
		public string Content { get; set; }
		/// <summary>
		/// URL to get
		/// </summary>
		public string UriAddress { get; set; }
		/// <summary>
		/// weather or not we have content (yet)
		/// </summary>
		public bool HasContent { get; internal set; }
		/// <summary>
		/// A progress indicator.
		/// </summary>
		public UriProgress Progress { get; internal set; }
		
		public bool hasException = false;
		
		public bool HasException {
			get { return hasException; }
		}
		
		public Exception InnerException { get; set; }
		
		public Action<UriDownloader> OnComplete { get; set; }
		public Action OnProgress { get; set; }
		
		public void Run()
		{
//			bool UrlExists = true;
			var uri = new Uri(UriAddress);
			uri.EnableHacks();
			
			System.Diagnostics.Debug.Print(
				"configure-download: {0}", UriAddress
			);
			using (
				var Client = new WebClient
				{
					Encoding = System.Text.Encoding.UTF8,
					UseDefaultCredentials = true,
				}
			)
			{
				Client.DownloadStringCompleted += CompletionHandler;
				Client.DownloadStringAsync(uri);
				uri = null;
			}
		}
		
		public void ProgressHandler(object sender, DownloadProgressChangedEventArgs e)
		{
			System.Diagnostics.Debug.Print(
				"Progress: {1}, {0}", UriAddress, e.ProgressPercentage
			);
			Progress = new UriProgress
			{
				ByteProgress=e.BytesReceived,
				ByteLength = e.TotalBytesToReceive,
				Percentage = e.ProgressPercentage,
			};
//			this.Max = Convert.ToDouble(e1.TotalBytesToReceive);
//			this.Progress = Convert.ToDouble(e1.BytesReceived);
//			this.TextStatus = string.Format("{0:N2}%—{1:N1}/{2:N1}Mb",(this.Progress/this.Max),this.Progress/1024,this.Max/1024);
			if (this.PropertyChanged !=null)
			{
				this.PropertyChanged(this,new PropertyChangedEventArgs("Progress"));
				this.PropertyChanged(this,new PropertyChangedEventArgs("Max"));
				this.PropertyChanged(this,new PropertyChangedEventArgs("TextStatus"));
			}
		}
		public void CompletionHandler(object sender, DownloadStringCompletedEventArgs args)
		{
			System.Diagnostics.Debug.Print(
				"Completion-Error: {0}",
				args.Error!=null?args.Error.ToString():"no error"
			);
			var webException = args.Error!=null?args.Error as WebException:null;
			
			if (webException != null/* && webException.Status == WebExceptionStatus.NameResolutionFailure*/)
			{
				Progress = new UriProgress{Cancelled = true};
				hasException = true;
				InnerException = webException;
			}
			
			if (!hasException) Content = args.Result;
			if (Progress!=null) Progress.Cancelled = args.Cancelled;
			if (OnComplete!=null)
				OnComplete(this);
		}
		
		
		public event PropertyChangedEventHandler PropertyChanged;
	}
}
