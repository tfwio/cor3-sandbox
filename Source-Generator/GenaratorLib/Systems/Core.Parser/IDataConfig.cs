﻿/*
 * User: oIo
 * Date: 11/15/2010 ? 2:33 AM
 */
#region Using
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

using Generator.Core;
using Generator.Core.Entities;
using Generator.Core.Entities.Types;
using Generator.Core.Markup;
using SqlDbType = System.Data.SqlDbType;

#endregion

/*
 * This is designed to be imported into another project as an include.
 */
namespace Generator.Core
{
	public interface IDataConfig
	{
		DatabaseCollection Databases { get; set; }
		DatabaseElement Database { get; set; }
		TemplateCollection Templates { get;set; }
		TableElement Table { get;set; }
		TableTemplate Template { get;set; }
		bool HasTemplate(string alias);
	}
}
