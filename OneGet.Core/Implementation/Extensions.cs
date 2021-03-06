// 
//  Copyright (c) Microsoft Corporation. All rights reserved. 
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//  http://www.apache.org/licenses/LICENSE-2.0
//  
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.
//  

namespace Microsoft.OneGet.Implementation {
    using System.Globalization;
    using Api;
    using Utility.Extensions;

    internal static class Extensions {
        internal static string FormatMessageString(this IHostApi request, string messageText, params object[] args) {
            if (string.IsNullOrEmpty(messageText)) {
                return string.Empty;
            }

            if (messageText.StartsWith(Constants.MSGPrefix, true, CultureInfo.CurrentCulture)) {
                messageText = request.GetMessageString(messageText.Substring(Constants.MSGPrefix.Length)) ?? messageText;
            }

            return args == null || args.Length == 0 ? messageText : messageText.format(args);
        }
    }
}