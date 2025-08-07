// === 2. ItemCollector �N���X�i�A�C�e�����W�̐Ӗ��̂݁j ===
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

        // �A�C�e���g�p�V�X�e���ɏ������Ϗ�
        var itemUser = player.GetComponent<ItemUser>();
        if (itemUser != null)
        {
            itemUser.UseItem(item);
        }
    }
}