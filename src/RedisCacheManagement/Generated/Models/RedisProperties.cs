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
using Microsoft.Azure.Management.Redis.Models;

namespace Microsoft.Azure.Management.Redis.Models
{
    /// <summary>
    /// Parameters supplied to the create redis operation.
    /// </summary>
    public partial class RedisProperties
    {
        private string _maxMemoryPolicy;
        
        /// <summary>
        /// Optional. what is maxMemoryPolicy of redis cache. Valid values:
        /// (VolatileLRU, AllKeysLRU, VolatileRandom, AllKeysRandom,
        /// VolatileTTL, NoEviction)
        /// </summary>
        public string MaxMemoryPolicy
        {
            get { return this._maxMemoryPolicy; }
            set { this._maxMemoryPolicy = value; }
        }
        
        private string _redisVersion;
        
        /// <summary>
        /// Required. The version of Redis to deploy, or 'latest'. Valid
        /// values: (2.8)
        /// </summary>
        public string RedisVersion
        {
            get { return this._redisVersion; }
            set { this._redisVersion = value; }
        }
        
        private Sku _sku;
        
        /// <summary>
        /// Required. What sku of redis cache to deploy.
        /// </summary>
        public Sku Sku
        {
            get { return this._sku; }
            set { this._sku = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the RedisProperties class.
        /// </summary>
        public RedisProperties()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the RedisProperties class with
        /// required arguments.
        /// </summary>
        public RedisProperties(string redisVersion, Sku sku)
            : this()
        {
            if (redisVersion == null)
            {
                throw new ArgumentNullException("redisVersion");
            }
            if (sku == null)
            {
                throw new ArgumentNullException("sku");
            }
            this.RedisVersion = redisVersion;
            this.Sku = sku;
        }
    }
}
