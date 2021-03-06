// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;

namespace Microsoft.Azure.Management.RemoteApp.Models
{
    /// <summary>
    /// The collection usage billing details.
    /// </summary>
    public partial class CollectionUsageDetails
    {
        private string _operationTrackingId;
        
        /// <summary>
        /// Optional. The tracking id of the requested operation.
        /// </summary>
        public string OperationTrackingId
        {
            get { return this._operationTrackingId; }
            set { this._operationTrackingId = value; }
        }
        
        private string _sasUri;
        
        /// <summary>
        /// Optional. The URL of the detailed billing report. Use the operation
        /// tracking ID with OperationResult.Get API to determine when the
        /// report is ready, then download the report using this URI.
        /// </summary>
        public string SasUri
        {
            get { return this._sasUri; }
            set { this._sasUri = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the CollectionUsageDetails class.
        /// </summary>
        public CollectionUsageDetails()
        {
        }
    }
}
