// === 5. ItemData クラス（データ保持の責務のみ） ===
using UnityEngine;
[CreateAssetMenu(menuName = "Item/ItemData")]
public class ItemData : ScriptableObject
{
    [Header("基本情報")]
    public string itemName;
    public Sprite icon;

    [Header("エフェクト設定")]
    public HealEffect effect = new HealEffect();
}
