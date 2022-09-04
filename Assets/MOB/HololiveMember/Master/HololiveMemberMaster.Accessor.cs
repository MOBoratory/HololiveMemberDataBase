using System.Collections.Generic;
using System.Linq;

namespace MOB.HololiveMember.Master
{
    /// <summary>
    ///     アクセサ
    /// </summary>
    public sealed partial class HololiveMemberMaster
    {
        /// <summary>
        ///     IDでマスタを取得
        /// </summary>
        /// <param name="id">HololiveMemberMaster.ID</param>
        /// <returns>MasterInstance</returns>
        public static HololiveMemberMaster GetById(int id)
        {
            return GetById<HololiveMemberMaster>(id);
        }

        public static IEnumerable<HololiveMemberMaster> GetList()
        {
            return GetList<HololiveMemberMaster>();
        }

        public static IEnumerable<HololiveMemberMaster> GetListByGenerations(Generations generations)
        {
            return GetList().Where(x => x.Generations == generations);
        }
    }
}
