using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace TestMan.ViewModels
{
	public class EntryPageViewModel : BindableBase
	{
        private double _targetHeightRequest;
        private double _targetWidthRequest;
        private double _targetFontSize;
        public double TargetHeightRequest
        {
            get { return _targetHeightRequest; }
            set { SetProperty(ref _targetHeightRequest, value); }
        }
        public double TargetWidthRequest
        {
            get { return _targetWidthRequest; }
            set { SetProperty(ref _targetWidthRequest, value); }
        }
        public double TargetFontSize
        {
            get { return _targetFontSize; }
            set { SetProperty(ref _targetFontSize, value); }
        }   
        public EntryPageViewModel()
        {
            TargetHeightRequest = 40;
            TargetWidthRequest = 150;
            TargetFontSize = 15;
        }
	}
}
