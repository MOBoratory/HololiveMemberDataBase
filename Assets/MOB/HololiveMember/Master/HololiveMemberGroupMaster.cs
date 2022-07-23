using MOB.ScriptableMasterSystem;
using UnityEngine;

namespace MOB.HololiveMember.Master
{
    /// <summary>
    ///     ホロライブメンバーマスタ
    /// </summary>
    [CreateAssetMenu(order = 1, fileName = "HololiveMemberGroupMaster", menuName = "MOB/HololiveMemberGroupMaster")]
    public sealed class HololiveMemberGroupMaster : MasterBase
    {
        [SerializeField] private string _characterName;
        [SerializeField] private string _description;

        /// <summary>キャラクター名称</summary>
        public string CharacterName => _characterName;

        /// <summary>説明文</summary>
        public string Description => _description;

        /// <summary>
        ///     IDでマスタを取得
        /// </summary>
        /// <param name="id">HololiveMemberMaster.ID</param>
        /// <returns>MasterInstance</returns>
        public static HololiveMemberGroupMaster GetById(int id)
        {
            return GetById<HololiveMemberGroupMaster>(id);
        }
    }
}
