// === 1. Item �N���X�i�A�C�e�����̂̐Ӗ��̂݁j ===
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