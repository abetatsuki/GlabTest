using UnityEngine;
using System.Collections.Generic;

public class ItemCombiner : MonoBehaviour
{
    private List<Item> collectedItems = new List<Item>();

    // ItemCollectorのイベントを受けてアイテムをリストに追加
    public void OnItemCollected(Item item)
    {
        collectedItems.Add(item);
        Debug.Log($"アイテム追加: {item.name}, 現在の個数: {collectedItems.Count}");

        TryCombine();
    }

    // 合成条件を満たしたら合成処理
    private void TryCombine()
    {
        // 例えば3つ以上集まったら合成
        if (collectedItems.Count >= 3)
        {
            CombineItems();
        }
    }

    private void CombineItems()
    {
        // 合成処理の具体例（仮）
        Debug.Log("アイテムを合成しました！");

        // 合成後はリストをクリアするなど
        collectedItems.Clear();
    }
}
