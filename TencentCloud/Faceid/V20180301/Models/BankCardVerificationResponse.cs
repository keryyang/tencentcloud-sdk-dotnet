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

namespace TencentCloud.Faceid.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BankCardVerificationResponse : AbstractModel
    {
        
        /// <summary>
        /// 认证结果码
        /// 收费结果码：
        /// '0': '认证通过'
        /// '-1': '认证未通过'
        /// '-5': '持卡人信息有误'
        /// '-6': '未开通无卡支付'
        /// '-7': '此卡被没收'
        /// '-8': '无效卡号'
        /// '-9': '此卡无对应发卡行'
        /// '-10': '该卡未初始化或睡眠卡'
        /// '-11': '作弊卡、吞卡'
        /// '-12': '此卡已挂失'
        /// '-13': '该卡已过期'
        /// '-14': '受限制的卡'
        /// '-15': '密码错误次数超限'
        /// '-16': '发卡行不支持此交易'
        /// 不收费结果码：
        /// '-2': '姓名校验不通过'
        /// '-3': '身份证号码有误'
        /// '-4': '银行卡号码有误'
        /// '-17': '验证中心服务繁忙'
        /// </summary>
        [JsonProperty("Result")]
        public string Result{ get; set; }

        /// <summary>
        /// 业务结果描述。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Result", this.Result);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

