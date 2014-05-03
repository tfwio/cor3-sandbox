﻿#region User/License
//       2/10/2011 * 9:52 PM
// oio * 8/19/2012 * 5:55 PM

// Permission is hereby granted, free of charge, to any person obtaining a
// copy of this software and associated documentation files (the "Software"),
// to deal in the Software without restriction, including without limitation
// the rights to use, copy, modify, merge, publish, distribute, sublicense,
// and/or sell copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included
// in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
// THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
// DEALINGS IN THE SOFTWARE.
#endregion
using System;
using Generator.Core.Markup;

#if WPF4
using System.Collections.ObjectModel;
#else
using System.Collections.Generic;
#endif
namespace Generator.Export.Intrinsic
{
	public interface ITemplateContext
	{
		TemplateCollection TemplateCollection { get; set; }
		#if WPF4
		ObservableCollection<string> TemplateGroups { get; set; }
		ObservableCollection<TableTemplate> Templates { get; set; }
		#else
		List<string> TemplateGroups { get; set; }
		List<TableTemplate> Templates { get; set; }
		#endif
	}
}