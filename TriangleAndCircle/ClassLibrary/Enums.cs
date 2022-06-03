using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public enum Result
    {
        a_円が三角形に含まれる,
        b_三角形が円に含まれる,
        c_一部共通部分がある,
        d_共通部分がない,
    }

    public enum 三角形の頂点位置
    {
        全て円の外,
        全て円の中,
        一部円の中,
    }
}
