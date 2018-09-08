using UnityEngine;
using UnityEditor;

public class PackageTool
{
    [MenuItem("Package/Update Package")]
    static void UpdatePackage()
    {
        AssetDatabase.ExportPackage("Assets/Klak", "KlakNDI.unitypackage", ExportPackageOptions.Recurse);
    }
}
