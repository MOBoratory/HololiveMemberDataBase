using System.Collections.Generic;
using MOB.ScriptableMasterSystem;
using UnityEngine;

namespace MOB.HololiveMember.Master
{
    /// <summary>
    ///     ホロライブメンバーグループマスタ
    /// </summary>
    [CreateAssetMenu(order = 1, fileName = "HololiveMemberGroupMaster", menuName = "MOB/HololiveMemberGroupMaster")]
    public sealed class HololiveMemberGroupMaster : MasterBase
    {
        [SerializeField] private string _groupName;
        [SerializeField] private string _description;

        [SerializeField] private HololiveMemberMaster[] _memberMasters;

        /// <summary>名称</summary>
        public string GroupName => _groupName;

        /// <summary>説明文</summary>
        public string Description => _description;

        /// <summary>所属メンバー</summary>
        public IReadOnlyList<HololiveMemberMaster> MemberMasters => _memberMasters;

        /// <summary>
        ///     IDでマスタを取得
        /// </summary>
        /// <param name="id">HololiveMemberGroupMaster.ID</param>
        /// <returns>MasterInstance</returns>
        public static HololiveMemberGroupMaster GetById(int id)
        {
            return GetById<HololiveMemberGroupMaster>(id);
        }
    }
}
