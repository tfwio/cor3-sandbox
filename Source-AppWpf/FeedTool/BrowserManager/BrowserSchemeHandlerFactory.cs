﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Text;
using System.Windows;

using CefSharp;
using FeedTool.Properties;

namespace FeedTool
{
	class BrowserSchemeHandlerFactory : ISchemeHandlerFactory
	{
	    public ISchemeHandler Create()
	    {
	        return new BrowserSchemeHandler();
	    }
	}
}
