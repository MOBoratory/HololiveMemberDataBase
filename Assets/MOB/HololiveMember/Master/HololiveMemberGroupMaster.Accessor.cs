namespace MOB.HololiveMember.Master
{
    /// <summary>
    ///     アクセサ
    /// </summary>
    public sealed partial class HololiveMemberGroupMaster
    {
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
