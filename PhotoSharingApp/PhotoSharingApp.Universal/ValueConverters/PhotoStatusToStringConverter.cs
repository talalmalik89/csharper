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

using System;
using PhotoSharingApp.Portable.DataContracts;
using PhotoSharingApp.Universal.Extensions;
using Windows.UI.Xaml.Data;
using Windows.ApplicationModel.Resources;

namespace PhotoSharingApp.Universal.ValueConverters
{
    /// <summary>
    /// Converts values of <see cref="PhotoStatus" /> into a human readable string
    /// for binding purposes.
    /// </summary>
    public class PhotoStatusToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var photoStatus = (PhotoStatus)value;
            var resourceLoader = ResourceLoader.GetForCurrentView();
            string result = string.Empty;

            switch (photoStatus)
            {
                case PhotoStatus.Active:
                    result = resourceLoader.GetString("PhotoStatus_Active");
                    break;
                case PhotoStatus.Deleted:
                    result = resourceLoader.GetString("PhotoStatus_Deleted");
                    break;
                case PhotoStatus.ObjectionableContent:
                    result = resourceLoader.GetString("PhotoStatus_ObjectionableContent");
                    break;
                case PhotoStatus.DoesntFitCategory:
                    result = resourceLoader.GetString("PhotoStatus_DoesntFitCategory");
                    break;
                case PhotoStatus.Hidden:
                    result = resourceLoader.GetString("PhotoStatus_Hidden");
                    break;
                case PhotoStatus.UnderReview:
                    result = resourceLoader.GetString("PhotoStatus_UnderReview");
                    break;
            }
            return result;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}