using MOB.ScriptableMasterSystem;
using UnityEngine;

namespace MOB.HololiveMember.Master
{
    /// <summary>
    ///     ホロライブメンバーマスタ
    /// </summary>
    public sealed class HololiveMemberMaster : MasterBase
    {
        [SerializeField] private string _characterName;
        [SerializeField] private string _nickName;

        /// <summary>キャラクター名称</summary>
        public string CharacterName => _characterName;

        /// <summary>愛称</summary>
        public string NickName => _nickName;

        /// <summary>
        ///     IDでマスタを取得
        /// </summary>
        /// <param name="id">HololiveMemberMaster.ID</param>
        /// <returns>MasterInstance</returns>
        public static HololiveMemberMaster GetById(int id)
        {
            return GetById<HololiveMemberMaster>(id);
        }
    }
}
