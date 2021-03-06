//-----------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
// 
//  The MIT License (MIT)
// 
//  Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in
//  all copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
//  THE SOFTWARE.
//  ---------------------------------------------------------------------------------

using Microsoft.Practices.ServiceLocation;
using PhotoSharingApp.Universal.Models;
using PhotoSharingApp.Universal.ViewModels;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace PhotoSharingApp.Universal.Controls
{
    /// <summary>
    /// A control which displays a featured photo.
    /// </summary>
    public sealed partial class FeaturedPhotoControl : UserControl
    {
        /// <summary>
        /// The dependency property for the caption font size.
        /// </summary>
        public static readonly DependencyProperty CaptionFontSizeProperty =
            DependencyProperty.Register("CaptionFontSize", typeof(object), typeof(FeaturedPhotoControl),
            new PropertyMetadata(null));

        /// <summary>
        /// The dependency property for the photoDetailsContainer margin.
        /// </summary>
        public static readonly DependencyProperty PhotoDetailsContainerMarginProperty =
            DependencyProperty.Register("PhotoDetailsContainerMargin", typeof(object), typeof(FeaturedPhotoControl),
            new PropertyMetadata("12,24"));

        /// <summary>
        /// The dependency property for the photo source.
        /// </summary>
        public static readonly DependencyProperty PhotoSourceProperty =
            DependencyProperty.Register("PhotoSource", typeof(object), typeof(FeaturedPhotoControl),
            new PropertyMetadata(null));

        /// <summary>
        /// The constructor.
        /// </summary>
        public FeaturedPhotoControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The caption font size.
        /// </summary>
        public double CaptionFontSize
        {
            get { return (double)GetValue(CaptionFontSizeProperty); }
            set { SetValue(CaptionFontSizeProperty, value); }
        }

        /// <summary>
        /// The photoDetailsContainer margin.
        /// </summary>
        public string PhotoDetailsContainerMargin
        {
            get { return (string)GetValue(PhotoDetailsContainerMarginProperty); }
            set { SetValue(PhotoDetailsContainerMarginProperty, value); }
        }

        /// <summary>
        /// The photo source.
        /// </summary>
        public Photo PhotoSource
        {
            get { return (Photo)GetValue(PhotoSourceProperty); }
            set { SetValue(PhotoSourceProperty, value); }
        }
    }
}