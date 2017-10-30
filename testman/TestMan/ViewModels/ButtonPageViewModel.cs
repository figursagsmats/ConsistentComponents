using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TestMan.ViewModels
{
	public class ButtonPageViewModel : BindableBase
	{
        private double _targetHeightRequest;
        private double _targetWidthRequest;
        private double _targetFontSize;
        private double _targetBorderWidth;
        private double _targetBorderRadius;
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


        public double TargetBorderWidth
        {
            get { return _targetBorderWidth; }
            set { SetProperty(ref _targetBorderWidth, value); }

        }


        public double TargetBorderRadius
        {
            get { return _targetBorderRadius; }
            set { SetProperty(ref _targetBorderRadius, value); }

        }

        public ButtonPageViewModel()
        {
            TargetHeightRequest = 40;
            TargetWidthRequest = 150;
            TargetFontSize = 15;
            TargetBorderWidth = 2;
            TargetBorderRadius = 10;
        }


	}
}
