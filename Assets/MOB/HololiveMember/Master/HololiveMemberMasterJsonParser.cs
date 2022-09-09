using System.IO;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace MOB.HololiveMember.Master
{
    /// <summary>
    ///     Json変換
    /// </summary>
    public sealed class HololiveMemberMasterJsonParser
    {
        private const string ResourcesPath = "Assets/Resources/MasterDataJson";
        private const string MasterRootDirectoryPath = "Assets/Resources/MasterData";

        [MenuItem("MOB/Master/ConvertMasterObjectsToJson")]
        private static void ExportJsons()
        {
            Debug.Log($"{nameof(ExportJsons)}");

            var saveDirectoryPath = Path.Combine(Application.dataPath, $"Export");
            if (!Directory.Exists(saveDirectoryPath))
            {
                Directory.CreateDirectory(saveDirectoryPath);
            }

            var masterObjects = LoadHololiveMemberMasterObjects();
            foreach (var masterObject in masterObjects)
            {
                var json = JsonUtility.ToJson(masterObject);
                var savePath = Path.Combine(saveDirectoryPath, $"{masterObject.name}.json");
                Debug.Log($"{nameof(savePath)}: {savePath}");
                File.WriteAllText(savePath, json);
            }
        }

        private static HololiveMemberMaster[] LoadHololiveMemberMasterObjects()
        {
            return Resources.LoadAll<HololiveMemberMaster>("MasterData");
        }
    }
}
