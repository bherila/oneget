﻿// 
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

namespace Microsoft.OneGet.Utility.Collections {
    using System.Collections;

    public class CancellableEnumerator<T> : SerializableEnumerator<T>, ICancellableEnumerator<T> {
        private readonly ByRefCancellationTokenSource _cancellationTokenSource;

        public CancellableEnumerator(ByRefCancellationTokenSource cts, IEnumerator enumerator)
            : base(enumerator) {
            _cancellationTokenSource = cts;
        }

        public override bool MoveNext() {
            // if the collection has been cancelled, then don't advance anymore.
            return !_cancellationTokenSource.IsCancellationRequested && base.MoveNext();
        }

        public void Cancel() {
            _cancellationTokenSource.Cancel();
        }
    }
}