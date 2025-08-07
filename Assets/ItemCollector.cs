// === 2. ItemCollector クラス（アイテム収集の責務のみ） ===
using UnityEngine;
public class ItemCollector : MonoBehaviour
{
    [SerializeField] private string playerTag = "Player";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Item item = collision.GetComponent<Item>();
        if (item == null) return;

        GameObject player = GameObject.FindWithTag(playerTag);
        if (player == null) return;

        // アイテム使用システムに処理を委譲
        var itemUser = player.GetComponent<ItemUser>();
        if (itemUser != null)
        {
            itemUser.UseItem(item);
        }
    }
}