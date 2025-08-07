// === 1. Item クラス（アイテム自体の責務のみ） ===
using UnityEngine;
public class Item : MonoBehaviour
{
    [SerializeField] private ItemData data;
    public ItemData Data => data;

    public void ConsumeItem()
    {
        Destroy(gameObject);
    }
}