using System;
using MOB.ScriptableMasterSystem;
using UnityEngine;

namespace MOB.HololiveMember.Master
{
    /// <summary>
    ///     ホロライブメンバーマスタ
    /// </summary>
    [CreateAssetMenu(order = 1, fileName = "HololiveMemberMaster", menuName = "MOB/HololiveMemberMaster")]
    public sealed class HololiveMemberMaster : MasterBase
    {
        // 名称
        [SerializeField] private string _characterName;
        [SerializeField] private string _nickName;

        // 日付
        [SerializeField] private string _birthDay;
        [SerializeField] private string _debutDate;

        /// <summary>キャラクター名称</summary>
        public string CharacterName => _characterName;

        /// <summary>愛称</summary>
        public string NickName => _nickName;

        /// <summary>誕生日</summary>
        public DateTime BirthDay => DateTime.Parse(_birthDay);

        /// <summary>デビュー日付</summary>
        public DateTime DebutDate => DateTime.Parse(_debutDate);

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
