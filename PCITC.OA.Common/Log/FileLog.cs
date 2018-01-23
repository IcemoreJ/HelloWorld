/***********************************************************************************************************
 * Copyright (c) 2018Microsoft All Rights Reserved.
 * CLR版本: 4.0.30319.42000
 * 机器名称: PC201711131501
 * 公司名称: Microsoft
 * 命名空间: PCITC.OA.Common
 * 文件名: FileLog
 * 版本号: V1.0.0.0
 * 唯一标识: b3bcf139-def8-498f-b7f1-a73af71dfb8c
 * 当前的用户域: PC201711131501
 * 创建人: Administrator
 * 电子邮箱: 1977936166@qq.com
 * 创建时间: 2018/1/23 23:01:13
 
 *描述:
 *
 * =========================================================================================================
 * 修改标记
 * 修改时间: 2018/1/23 23:01:13
 * 修改人: Administrator
 * 版本号: V1.0.0.0
 * 描述:
 * 
 * ********************************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace PCITC.OA.Common
{
    public class FileLog : IFileLog
    {
        public void WriteLog(string exception)
        {
            using (FileStream fs = new FileStream(@"F:\PCITC.OA.Test\PCITC.OA.UI.Portal\App_Data\Log.txt", FileMode.Append, FileAccess.Write))
            {
                byte[] bytes = Encoding.Default.GetBytes(exception);
                fs.Write(bytes, 0, bytes.Length);
            }
        }
    }
}
