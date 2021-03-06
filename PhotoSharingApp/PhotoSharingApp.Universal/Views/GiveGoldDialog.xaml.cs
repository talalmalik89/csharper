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
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace PhotoSharingApp.Universal.Views
{
    /// <summary>
    /// The dialog that allows giving gold to a photo.
    /// </summary>
    public sealed partial class GiveGoldDialog : ContentDialog
    {
        public GiveGoldDialog(Photo photo)
        {
            InitializeComponent();

            ViewModel = ServiceLocator.Current.GetInstance<GiveGoldViewModel>();
            ViewModel.Photo = photo;
            DataContext = ViewModel;

            // Register for events
            Loaded += GiveGoldDialog_Loaded;
        }

        /// <summary>
        /// Gets the ViewModel.
        /// </summary>
        public GiveGoldViewModel ViewModel { get; }

        private async void GiveGoldDialog_Loaded(object sender, RoutedEventArgs e)
        {
            await ViewModel.LoadState();
        }

        private async void GiveGoldDialog_OnPrimaryButtonClick(ContentDialog sender,
            ContentDialogButtonClickEventArgs args)
        {
            // Get the deferral because we need to await the
            // annotation to post.
            var deferral = args.GetDeferral();

            // Get creation status and if failed, let's
            // keep the dialog opened.
            var success = await ViewModel.PostAnnotationToService();
            args.Cancel = !success;

            // Complete deferral to close the dialog.
            deferral.Complete();
        }
    }
}