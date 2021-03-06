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

using PhotoSharingApp.Universal.Commands;
using PhotoSharingApp.Universal.Models;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace PhotoSharingApp.Universal.Controls
{
    /// <summary>
    /// User control for photo leaderboard data
    /// </summary>
    public sealed partial class LeaderboardsPhotoControl : UserControl
    {
        /// <summary>
        /// The dependency property backing the <see cref="NavigationCommand" /> property
        /// </summary>
        public static readonly DependencyProperty NavigationCommandProperty =
            DependencyProperty.Register("NavigationCommand", typeof(object), typeof(LeaderboardsPhotoControl),
                new PropertyMetadata(null));

        /// <summary>
        /// The dependency property backing the <see cref="PhotoEntryProperty" /> property
        /// </summary>
        public static readonly DependencyProperty PhotoEntryProperty =
            DependencyProperty.Register("PhotoEntry", typeof(object), typeof(LeaderboardsPhotoControl),
                new PropertyMetadata(null));

        /// <summary>
        /// Initializes a new instance of the <see cref="LeaderboardsPhotoControl" /> class.
        /// </summary>
        public LeaderboardsPhotoControl()
        {
            InitializeComponent();
            layoutRoot.DataContext = this;
        }

        /// <summary>
        /// The command used to navigate when this entry is clicked
        /// </summary>
        public RelayCommand<Photo> NavigationCommand
        {
            get { return (RelayCommand<Photo>) GetValue(NavigationCommandProperty); }
            set { SetValue(NavigationCommandProperty, value); }
        }

        /// <summary>
        /// The leaderboard entry
        /// </summary>
        public LeaderboardEntry<Photo> PhotoEntry
        {
            get { return (LeaderboardEntry<Photo>) GetValue(PhotoEntryProperty); }
            set { SetValue(PhotoEntryProperty, value); }
        }
    }
}