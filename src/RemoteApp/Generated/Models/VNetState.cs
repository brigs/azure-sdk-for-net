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
    /// Possible values for virtual network state.
    /// </summary>
    public enum VNetState
    {
        /// <summary>
        /// Unsupported state.
        /// </summary>
        None = 0,
        
        /// <summary>
        /// Virtual network is being provisioned and cannot be modified at this
        /// time
        /// </summary>
        Provisioning = 1,
        
        /// <summary>
        /// Virtual network is attempting to connect to the VPN device. In this
        /// state the network can be modified
        /// </summary>
        Connecting = 2,
        
        /// <summary>
        /// Virtual network is connected to the VPN device and operating
        /// normally. In this state the network can be modified
        /// </summary>
        Ready = 3,
        
        /// <summary>
        /// Virtual network is being deleted. In this state the network cannot
        /// be modified
        /// </summary>
        Deleting = 4,
        
        /// <summary>
        /// Virtual network has been deleted
        /// </summary>
        Deleted = 5,
        
        /// <summary>
        /// Error in connecting the virtual network
        /// </summary>
        ConnectionError = 6,
        
        /// <summary>
        /// Error in creatting the virtual network
        /// </summary>
        CreationError = 7,
        
        /// <summary>
        /// The operation result is unknown
        /// </summary>
        Unknown = 8,
    }
}
