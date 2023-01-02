using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Runtime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;
using Microsoft.Web.Services3;
using System.Web.Services;
using System.Web.Services.Description;
using System.Web.Services.Protocols;
using System.Configuration;
using System.Runtime.CompilerServices;
namespace DenemeEnabiz
{

	[DesignerCategory("code")]
	[GeneratedCode("System.Web.Services", "4.0.30319.33440")]
	[DebuggerStepThrough]
	public class SYSSendMessageCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		internal SYSSendMessageCompletedEventArgs(
		  object[] results,
		  Exception exception,
		  bool cancelled,
		  object userState)
		  : base(exception, cancelled, userState)
		{
			this.results = results;
		}

		public string Result
		{
			get
			{
				this.RaiseExceptionIfNecessary();
				return (string)this.results[0];
			}
		}
	}

	[GeneratedCode("System.Web.Services", "4.0.30319.33440")]
	public delegate void SYSSendMessageCompletedEventHandler(
  object sender,
  SYSSendMessageCompletedEventArgs e);

	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
	internal sealed class Settings : ApplicationSettingsBase
	{
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized((SettingsBase)new Settings());

		public static Settings Default
		{
			get
			{
				Settings defaultInstance = Settings.defaultInstance;
				return defaultInstance;
			}
		}

		[ApplicationScopedSetting]
		[DefaultSettingValue("https://sys.sagliknet.saglik.gov.tr/SYS/SYSWS.svc")]
		[DebuggerNonUserCode]
		[SpecialSetting(SpecialSetting.WebServiceUrl)]
		public string SYSWS => (string)this[nameof(SYSWS)];
	}



	[WebServiceBinding(Name = "BasicHttpBinding_ISYSWS", Namespace = "http://ns.sagliknet.saglik.gov.tr")]
	[GeneratedCode("System.Web.Services", "4.0.30319.33440")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public class SYSWS : WebServicesClientProtocol
	{
		private SendOrPostCallback SYSSendMessageOperationCompleted;
		private bool useDefaultCredentialsSetExplicitly;

		protected override WebRequest GetWebRequest(Uri uri)
		{
			WebRequest webRequest = base.GetWebRequest(uri);
			if (webRequest is HttpWebRequest httpWebRequest)
				httpWebRequest.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
			return webRequest;
		}

		public SYSWS()
		{
			this.Url = Settings.Default.SYSWS;
			if (this.IsLocalFileSystemWebService(this.Url))
			{
				this.UseDefaultCredentials = true;
				this.useDefaultCredentialsSetExplicitly = false;
			}
			else
				this.useDefaultCredentialsSetExplicitly = true;
		}

		public new string Url
		{
			get => base.Url;
			set
			{
				if (this.IsLocalFileSystemWebService(base.Url) && !this.useDefaultCredentialsSetExplicitly && !this.IsLocalFileSystemWebService(value))
					base.UseDefaultCredentials = false;
				base.Url = value;
			}
		}

		public new bool UseDefaultCredentials
		{
			get => base.UseDefaultCredentials;
			set
			{
				base.UseDefaultCredentials = value;
				this.useDefaultCredentialsSetExplicitly = true;
			}
		}

		public event SYSSendMessageCompletedEventHandler SYSSendMessageCompleted;

		[SoapDocumentMethod("https://sys.sagliknet.saglik.gov.tr/SYS/ISYSWS/SYSSendMessage", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "https://sys.sagliknet.saglik.gov.tr/SYS/", ResponseNamespace = "https://sys.sagliknet.saglik.gov.tr/SYS/", Use = SoapBindingUse.Literal)]
		[return: XmlElement(IsNullable = true)]
		public string SYSSendMessage([XmlElement(IsNullable = true)] string input) => (string)this.Invoke(nameof(SYSSendMessage), new object[1]
		{
	  (object) input
		})[0];

		public void SYSSendMessageAsync(string input) => this.SYSSendMessageAsync(input, (object)null);

		public void SYSSendMessageAsync(string input, object userState)
		{
			if (this.SYSSendMessageOperationCompleted == null)
				this.SYSSendMessageOperationCompleted = new SendOrPostCallback(this.OnSYSSendMessageOperationCompleted);
			this.InvokeAsync("SYSSendMessage", new object[1]
			{
		(object) input
			}, this.SYSSendMessageOperationCompleted, userState);
		}

		private void OnSYSSendMessageOperationCompleted(object arg)
		{
			if (this.SYSSendMessageCompleted == null)
				return;
			InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs)arg;
			this.SYSSendMessageCompleted((object)this, new SYSSendMessageCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
		}

		public new void CancelAsync(object userState) => base.CancelAsync(userState);

		private bool IsLocalFileSystemWebService(string url)
		{
			if (url == null || url == string.Empty)
				return false;
			Uri uri = new Uri(url);
			return uri.Port >= 1024 && string.Compare(uri.Host, "localHost", StringComparison.OrdinalIgnoreCase) == 0;
		}
	}
}
