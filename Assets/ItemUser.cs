// === 4. ItemUser クラス（アイテム使用の責務のみ） ===
using UnityEngine;
public class ItemUser : MonoBehaviour
{
    public void UseItem(Item item)
    {
        if (item == null)
        {
            Debug.LogWarning("[ItemUser] アイテムがnullです - 呼び出し元を確認してください");
            Debug.LogWarning(System.Environment.StackTrace);
            return;
        }

        if (item.Data == null)
        {
            Debug.LogWarning($"[ItemUser] アイテム {item.gameObject.name} のItemDataがnullです");
            return;
        }

        if (item.Data.effect == null)
        {
            Debug.LogWarning($"[ItemUser] アイテム {item.Data.itemName} のエフェクトがnullです");
            return;
        }

        Debug.Log($"[ItemUser] {gameObject.name} が {item.Data.itemName} を使用します");

        // エフェクトを適用
        item.Data.effect.Apply(gameObject);

        // アイテムを消費
        Debug.Log($"[ItemUser] アイテム {item.Data.itemName} を消費します");
        item.ConsumeItem();
    }
}