using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace MOB.ScriptableMasterSystem
{
    /// <summary>
    ///     Master基底クラス
    /// </summary>
    public abstract class MasterBase : ScriptableObject
    {
        private const string MasterRootDirectoryPath = "MasterData/";

        private static readonly Dictionary<Type, IReadOnlyDictionary<int, MasterBase>> MasterCachesByType = new();

        [SerializeField] private int _id;

        /// <summary>MasterID</summary>
        public int Id => _id;

        public static void CreateCaches<T>()
            where T : MasterBase
        {
            var masterDirectoryPath = $"{MasterRootDirectoryPath}{typeof(T).Name}";
            var masters = Resources.LoadAll<MasterBase>(masterDirectoryPath)
                .Select(x => (T)x);
            MasterCachesByType[typeof(T)] = masters.ToDictionary(x => x.Id, x => (MasterBase)x);
        }

        /// <summary>
        ///     IDからMasterを取得します
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns>Masterインスタンス</returns>
        protected static T GetById<T>(int id)
            where T : MasterBase
        {
            // キャッシュがまだ無ければキャッシュ作成
            if (!MasterCachesByType.ContainsKey(typeof(T)))
            {
                CreateCaches<T>();
                if (!MasterCachesByType.ContainsKey(typeof(T))) throw new KeyNotFoundException();
            }

            var masterById = MasterCachesByType[typeof(T)];
            if (masterById.TryGetValue(id, out var master)) return (T)master;

            return default;
        }

        protected static IEnumerable<T> GetList<T>()
            where T : MasterBase
        {
            // キャッシュがまだ無ければキャッシュ作成
            if (!MasterCachesByType.ContainsKey(typeof(T)))
            {
                CreateCaches<T>();
                if (!MasterCachesByType.ContainsKey(typeof(T))) throw new KeyNotFoundException();
            }

            return MasterCachesByType[typeof(T)].Values.Select(x => (T)x);
        }
    }
}
