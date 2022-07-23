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
    }
}
