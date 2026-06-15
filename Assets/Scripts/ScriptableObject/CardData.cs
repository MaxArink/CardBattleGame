using UnityEditor;
using UnityEngine;

[CreateAssetMenu(fileName = "CardData", menuName = "Cards/Card")]
public class CardData : ScriptableObject
{
    public string Name = "";
    public int Cost = 0;
    public int Health = 1;
    public int Damage = 1;

    public GameObject BoardModel = null;

    #if UNITY_EDITOR
    private void OnValidate()
    {
        if (string.IsNullOrWhiteSpace(Name))
            return;

        string path = AssetDatabase.GetAssetPath(this);

        if (!string.IsNullOrEmpty(path))
        {
            AssetDatabase.RenameAsset(path, Name);
            AssetDatabase.SaveAssets();
        }
    }
    #endif
}
