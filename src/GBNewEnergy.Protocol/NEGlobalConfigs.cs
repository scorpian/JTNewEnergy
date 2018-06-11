﻿using GBNewEnergy.Protocol.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GBNewEnergy.Protocol
{
    public  class NEGlobalConfigs
    {
        /// <summary>
        /// 密钥
        /// </summary>
        public string NEEncryptKey { get; set; }
        /// <summary>
        /// 数据单元加密方式
        /// 0x01：数据不加密；0x02：数据经过 RSA 算法加密；0x03:数据经过 AES128 位算法加密；“0xFE”表示异常，“0xFF”表示无效
        /// </summary>
        public NEEncryptMethod EncryptMethod { get; set; } = NEEncryptMethod.None;
        /// <summary>
        /// 数据单元加密
        /// 当数据单元存在加密时，应先加密后校验，先校验后解密
        /// </summary>
        public INEEncrypt Encrypt { get; set; }
    }
}