using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Collections.Generic
{
    public static class Expansion
    {
        /// <summary>
        /// 扩展方法：
        /// 返回值：随意定义
        /// this string str：表示是给string的扩展方法，此参数不用传入
        /// index：是需要传入的参数
        /// </summary>
        /// <param name="str"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static string zunDuHaoXiao(this string str, int index)
        {
            return str.Split(',')[index];
        }
    }
}
