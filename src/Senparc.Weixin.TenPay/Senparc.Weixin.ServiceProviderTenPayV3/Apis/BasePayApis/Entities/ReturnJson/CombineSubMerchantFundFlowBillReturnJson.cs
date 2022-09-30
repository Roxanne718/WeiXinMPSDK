/// <summary>
/// 申请单个子商户资金账单 返回json
/// 详细请参考微信支付官方文档: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter5_1_20.shtml
/// <summary>
public class CombineSubMerchantFundFlowBillReturnJson
{

/// <summary>
/// 下载信息总数
/// 下载信息总数
/// 示例值：1
/// 可为空: True
/// </summary>
public int download_bill_count { get; set; }

/// <summary>
/// 下载信息明细
/// 下载信息明细
/// 可为空: True
/// </summary>
public Download_Bill_List[] download_bill_list { get; set; }


 #region 子数据类型

/// <summary>
/// 下载信息明细
/// 下载信息明细
/// <summary>
public class Download_Bill_List
{

/// <summary>
/// 账单文件序号
/// 商户将多个文件按账单文件序号的顺序合并为完整的资金账单文件，起始值为1
/// 示例值：1
/// 可为空: True
/// </summary>
public int bill_sequence { get; set; }

/// <summary>
/// 下载地址
/// 下载地址30s内有效
/// 示例值：https://api.mch.weixin.qq.com/v3/bill/downloadurl?token=xxx
/// 可为空: True
/// </summary>
public string download_url { get; set; }

/// <summary>
/// 加密密钥
/// 加密账单文件使用的加密密钥。密钥用商户证书的公钥进行加密，然后进行Base64编码
/// 示例值：a0YK7p+9XaKzE9N4qtFfG/9za1oqKlLXXJWBkH+kX84onAs2Ol/E1fk+6S+FuBXczGDRU8I8D+6PfbwKYBGm0wANUTqHOSezzfbieIo2t51UIId7sP9SoN38W2+IcYDviIsu59KSdyiL3TY2xqZNT8UDcnMWzTNZdSv+CLsSgblB6OKGN9JONTadOFGfv1OKkTp86Li+X7S9bG62wsa572/5Rm4MmDCiKwY4bX2EynWQHBEOExD5URxT6/MX3F1D3BNYrE4fUu1F03k25xVlXnZDjksy6Rf3SCgadR+Cepc6mdfF9b2gTxNsJFMEdYXbqL0W1WQZ3UqSPQCguK6uLA==
/// 可为空: True
/// </summary>
public string encrypt_key { get; set; }

/// <summary>
/// 哈希类型
/// 原始账单（gzip需要解压缩）的摘要值，用于校验文件的完整性。
/// 示例值：SHA1
/// 可为空: True
/// </summary>
public string hash_type { get; set; }

/// <summary>
/// 哈希值
/// 原始账单（gzip需要解压缩）的摘要值，用于校验文件的完整性
/// 示例值：79bb0f45fc4c42234a918000b2668d689e2bde04
/// 可为空: True
/// </summary>
public string hash_value { get; set; }

/// <summary>
/// 随机字符串
/// 加密账单文件使用的随机字符串
/// 示例值：a8607ef79034c49c
/// 可为空: True
/// </summary>
public string nonce { get; set; }



}

#endregion
}