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

namespace Microsoft.OneGet.Utility.PowerShell {
    using System.Management.Automation;

    internal static class Errors {
        public static ErrorMessage FileNotFound = new ErrorMessage(Constants.FileNotFound, ErrorCategory.ObjectNotFound);
        public static ErrorMessage FolderNotFound = new ErrorMessage(Constants.FolderNotFound, ErrorCategory.ObjectNotFound);
        public static ErrorMessage MoreThanOneFolderMatched = new ErrorMessage(Constants.MoreThanOneFolderMatched, ErrorCategory.ObjectNotFound);
        public static ErrorMessage MoreThanOneFileMatched = new ErrorMessage(Constants.MoreThanOneFileMatched, ErrorCategory.ObjectNotFound);
    }

    internal static class Constants {
        public const string MSGPrefix = "MSG:";

        internal static object[] NoParameters = new object[0];

        public const string ConfirmParameter = "Confirm";
        public const string WhatIfParameter = "WhatIf";

        public const string MoreThanOneFileMatched = "MSG:MoreThanOneFileMatched";
        public const string FileNotFound = "MSG:FileNotFound";
        public const string FolderNotFound = "MSG:FolderNotFound";
        public const string MoreThanOneFolderMatched = "MSG:MoreThanOneFolderMatched";

        public const string StopProcessingAsyncMethod = "StopProcessingAsync";
        public const string ProcessRecordAsyncMethod = "ProcessRecordAsync";
        public const string GenerateDynamicParametersMethod = "GenerateDynamicParameters";
        public const string BeginProcessingAsyncMethod = "BeginProcessingAsync";
        public const string EndProcessingAsyncMethod = "EndProcessingAsync";
    }
}