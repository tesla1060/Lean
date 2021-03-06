﻿/*
 * QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
 * Lean Algorithmic Trading Engine v2.0. Copyright 2014 QuantConnect Corporation.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License"); 
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
*/

using Newtonsoft.Json;

namespace QuantConnect.Packets
{
    /******************************************************** 
    * CLASS DEFINITIONS
    *********************************************************/
    /// <summary>
    /// Send a simple debug message from the users algorithm to the console.
    /// </summary>
    public class DebugPacket : Packet
    {
        /******************************************************** 
        * CLASS VARIABLES
        *********************************************************/
        /// <summary>
        /// String debug message to send to the users console
        /// </summary>
        [JsonProperty(PropertyName = "sMessage")]
        public string Message;

        /// <summary>
        /// Associated algorithm Id.
        /// </summary>
        [JsonProperty(PropertyName = "sAlgorithmID")]
        public string AlgorithmId;

        /// <summary>
        /// Compile id of the algorithm sending this message
        /// </summary>
        [JsonProperty(PropertyName = "sCompileID")]
        public string CompileId;

        /// <summary>
        /// Project Id for this message
        /// </summary>
        [JsonProperty(PropertyName = "iProjectID")]
        public int ProjectId;

        /******************************************************** 
        * CLASS CONSTRUCTOR
        *********************************************************/
        /// <summary>
        /// Default constructor for JSON
        /// </summary>
        public DebugPacket()
            : base (PacketType.Debug)
        { }

        /// <summary>
        /// Create a new instance of the notify debug packet:
        /// </summary>
        public DebugPacket(int projectId, string algorithmId, string compileId, string message)
            : base(PacketType.Debug)
        {
            ProjectId = projectId;
            Message = message;
            CompileId = compileId;
            AlgorithmId = algorithmId;
        }
    
    } // End Work Packet:

} // End of Namespace:
