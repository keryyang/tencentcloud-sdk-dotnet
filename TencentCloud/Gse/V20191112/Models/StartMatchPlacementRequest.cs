/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Gse.V20191112.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StartMatchPlacementRequest : AbstractModel
    {
        
        /// <summary>
        /// 开始部署游戏服务器会话的唯一标识符
        /// </summary>
        [JsonProperty("PlacementId")]
        public string PlacementId{ get; set; }

        /// <summary>
        /// 游戏服务器会话队列名称
        /// </summary>
        [JsonProperty("GameServerSessionQueueName")]
        public string GameServerSessionQueueName{ get; set; }

        /// <summary>
        /// 游戏服务器允许同时连接到游戏会话的最大玩家数量
        /// </summary>
        [JsonProperty("MaximumPlayerSessionCount")]
        public ulong? MaximumPlayerSessionCount{ get; set; }

        /// <summary>
        /// 玩家游戏会话信息
        /// </summary>
        [JsonProperty("DesiredPlayerSessions")]
        public DesiredPlayerSession[] DesiredPlayerSessions{ get; set; }

        /// <summary>
        /// 玩家游戏会话属性
        /// </summary>
        [JsonProperty("GameProperties")]
        public GameProperty[] GameProperties{ get; set; }

        /// <summary>
        /// 游戏服务器会话数据
        /// </summary>
        [JsonProperty("GameServerSessionData")]
        public string GameServerSessionData{ get; set; }

        /// <summary>
        /// 游戏服务器会话名称
        /// </summary>
        [JsonProperty("GameServerSessionName")]
        public string GameServerSessionName{ get; set; }

        /// <summary>
        /// 玩家延迟
        /// </summary>
        [JsonProperty("PlayerLatencies")]
        public PlayerLatency[] PlayerLatencies{ get; set; }

        /// <summary>
        /// 游戏匹配数据
        /// </summary>
        [JsonProperty("MatchmakerData")]
        public string MatchmakerData{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PlacementId", this.PlacementId);
            this.SetParamSimple(map, prefix + "GameServerSessionQueueName", this.GameServerSessionQueueName);
            this.SetParamSimple(map, prefix + "MaximumPlayerSessionCount", this.MaximumPlayerSessionCount);
            this.SetParamArrayObj(map, prefix + "DesiredPlayerSessions.", this.DesiredPlayerSessions);
            this.SetParamArrayObj(map, prefix + "GameProperties.", this.GameProperties);
            this.SetParamSimple(map, prefix + "GameServerSessionData", this.GameServerSessionData);
            this.SetParamSimple(map, prefix + "GameServerSessionName", this.GameServerSessionName);
            this.SetParamArrayObj(map, prefix + "PlayerLatencies.", this.PlayerLatencies);
            this.SetParamSimple(map, prefix + "MatchmakerData", this.MatchmakerData);
        }
    }
}

