﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18213
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace System {
	using System;
	
	
	/// <summary>
	///   A strongly-typed resource class, for looking up localized strings, etc.
	/// </summary>
	// This class was auto-generated by the StronglyTypedResourceBuilder
	// class via a tool like ResGen or Visual Studio.
	// To add or remove a member, edit your .ResX file then rerun ResGen
	// with the /str option, or rebuild your VS project.
	[global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
	[global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
	public class Strings {
		
		private static global::System.Resources.ResourceManager resourceMan;
		
		private static global::System.Globalization.CultureInfo resourceCulture;
		
		[global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
		internal Strings() {
		}
		
		/// <summary>
		///   Returns the cached ResourceManager instance used by this class.
		/// </summary>
		[global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		public static global::System.Resources.ResourceManager ResourceManager {
			get {
				if (object.ReferenceEquals(resourceMan, null)) {
					global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Mu.Strings", typeof(Strings).Assembly);
					resourceMan = temp;
				}
				return resourceMan;
			}
		}
		
		/// <summary>
		///   Overrides the current thread's CurrentUICulture property for all
		///   resource lookups using this strongly typed resource class.
		/// </summary>
		[global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		public static global::System.Globalization.CultureInfo Culture {
			get {
				return resourceCulture;
			}
			set {
				resourceCulture = value;
			}
		}
		
		/// <summary>
		///   Looks up a localized string similar to 	&lt;Compile Include=&quot;{inc}&quot;&gt;
		///		&lt;Link&gt;{link}&lt;/Link&gt;{deps}
		///	&lt;/Compile&gt;
		///.
		/// </summary>
		public static string CompileElement0 {
			get {
				return ResourceManager.GetString("CompileElement0", resourceCulture);
			}
		}
		
		/// <summary>
		///   Looks up a localized string similar to 	&lt;Compile Include=&quot;{inc}&quot;&gt;
		///		&lt;Link&gt;{link}&lt;/Link&gt;{deps}
		///	&lt;/Compile&gt;
		///.
		/// </summary>
		public static string CompileElement1 {
			get {
				return ResourceManager.GetString("CompileElement1", resourceCulture);
			}
		}
		
		/// <summary>
		///   Looks up a localized string similar to 	&lt;{tag} Include=&quot;{inc}&quot;&gt;
		///		&lt;Link&gt;{fname:pre}\{fname}&lt;/Link&gt;{vals}
		///	&lt;/{tag}&gt;
		///.
		/// </summary>
		public static string CompileElement2 {
			get {
				return ResourceManager.GetString("CompileElement2", resourceCulture);
			}
		}
		
		/// <summary>
		///   Looks up a localized string similar to Argument ‘{0}’ as allready been added to the Dictionary..
		/// </summary>
		public static string DictionaryList_ErrorMessage {
			get {
				return ResourceManager.GetString("DictionaryList_ErrorMessage", resourceCulture);
			}
		}
		
		/// <summary>
		///   Looks up a localized string similar to DictionaryList Usage Error.
		/// </summary>
		public static string DictionaryList_ErrorMessage_Title {
			get {
				return ResourceManager.GetString("DictionaryList_ErrorMessage_Title", resourceCulture);
			}
		}
		
		/// <summary>
		///   Looks up a localized string similar to &lt;error Message=&quot;You probably need to select a project.&quot; /&gt;.
		/// </summary>
		public static string ErrorSelectAProject {
			get {
				return ResourceManager.GetString("ErrorSelectAProject", resourceCulture);
			}
		}
		
		/// <summary>
		///   Looks up a localized string similar to 
		///		&lt;{0}&gt;{1}&lt;/{0}&gt;.
		/// </summary>
		public static string FormatTag0 {
			get {
				return ResourceManager.GetString("FormatTag0", resourceCulture);
			}
		}
		
		/// <summary>
		///   Looks up a localized string similar to No Project!.
		/// </summary>
		public static string MsgNoProject {
			get {
				return ResourceManager.GetString("MsgNoProject", resourceCulture);
			}
		}
		
		/// <summary>
		///   Looks up a localized string similar to DependentUpon.
		/// </summary>
		public static string TagDependentUpon {
			get {
				return ResourceManager.GetString("TagDependentUpon", resourceCulture);
			}
		}
		
		/// <summary>
		///   Looks up a localized string similar to Link.
		/// </summary>
		public static string TagLink {
			get {
				return ResourceManager.GetString("TagLink", resourceCulture);
			}
		}
		
		/// <summary>
		///   Looks up a localized string similar to 
		///&lt;div class=&apos;xpopup&apos;&gt;
		///
		///	&lt;span style=&apos;float:right&apos;&gt;&lt;input pickupid=&apos;{Pickup_ID}&apos; type=&apos;button&apos; value=&apos;edit&apos; id=&apos;editbutton&apos; /&gt;&lt;/span&gt;
		///	
		///	&lt;div class=&apos;addr&apos; style=&apos;float:left&apos;&gt;
		///		&lt;font size=&apos;4&apos;&gt;&lt;b&gt;{Pickup_Name}&lt;/b&gt;&lt;/font&gt;&lt;br /&gt;
		///		&lt;font size=&apos;1&apos;&gt;{addrStreet} {addrSuite}&lt;br /&gt;
		///		{addrCity} {addrState} {addrZip}&lt;/font&gt;
		///    &lt;/div&gt;
		///    
		///    &lt;div class=&apos;phone&apos; style=&apos;float:left;&apos;&gt;
		///		&lt;table style=&apos;border-collapse: collapse; min-width:120px;&apos;&gt;
		///			&lt;tr&gt;&lt;td&gt;{Phone_1}&lt;/td&gt;&lt;/tr&gt;
		///			&lt;tr&gt;&lt;td&gt;{Phone_2}&lt;/td&gt;&lt;/tr&gt; [rest of string was truncated]&quot;;.
		/// </summary>
		public static string TestRow_Value {
			get {
				return ResourceManager.GetString("TestRow:Value", resourceCulture);
			}
		}
	}
}
