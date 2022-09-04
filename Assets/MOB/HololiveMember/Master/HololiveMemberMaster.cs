using System;
using System.Globalization;
using MOB.ScriptableMasterSystem;
using UnityEngine;

namespace MOB.HololiveMember.Master
{
    /// <summary>
    ///     ホロライブメンバーマスタ
    /// </summary>
    [CreateAssetMenu(order = 1, fileName = "HololiveMemberMaster", menuName = "MOB/HololiveMemberMaster")]
    public sealed partial class HololiveMemberMaster : MasterBase
    {
        // 名称
        [SerializeField] private string _characterName;
        [SerializeField] private string _nickName;
        [SerializeField] private string _fanName;

        // 日付
        [SerializeField] private string _birthDay;
        [SerializeField] private string _debutDate;

        [SerializeField] private Languages _languages;
        [SerializeField] private Generations _generation;
        [SerializeField] private string _description;

        /// <summary>キャラクター名称</summary>
        public string CharacterName => _characterName;

        /// <summary>愛称</summary>
        public string NickName => _nickName;

        /// <summary>ファン名称</summary>
        public string FanName => _fanName;

        /// <summary>誕生日</summary>
        public DateTime BirthDay
        {
            get
            {
                DateTime.TryParseExact(_birthDay,
                    "MM/dd",
                    CultureInfo.CurrentCulture,
                    DateTimeStyles.None,
                    out var result);
                return result;
            }
        }

        /// <summary>デビュー日付</summary>
        public DateTime DebutDate
        {
            get
            {
                DateTime.TryParseExact(_debutDate,
                    "yyyy/MM/dd",
                    CultureInfo.CurrentCulture,
                    DateTimeStyles.None,
                    out var result);
                return result;
            }
        }

        /// <summary>言語</summary>
        public Languages Languages => _languages;

        /// <summary>世代</summary>
        public Generations Generation => _generation;

        /// <summary>説明文</summary>
        public string Description => _description;
    }
}
