using Prism.Logging;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrismLoggerTest.ViewModels
{
    public class MainViewModel : BindableBase
    {
		private string text;

		public string Text
		{
			get { return text; }
			set { SetProperty(ref text, value); }
		}

		public MainViewModel(ILoggerFacade logger)
		{
			Text = "aa";
			logger.Log(Text, Category.Debug,Priority.None);
		}
	}
}
