// === 4. ItemUser �N���X�i�A�C�e���g�p�̐Ӗ��̂݁j ===
using UnityEngine;
public class ItemUser : MonoBehaviour
{
    public void UseItem(Item item)
    {
        if (item == null)
        {
            Debug.LogWarning("[ItemUser] �A�C�e����null�ł� - �Ăяo�������m�F���Ă�������");
            Debug.LogWarning(System.Environment.StackTrace);
            return;
        }

        if (item.Data == null)
        {
            Debug.LogWarning($"[ItemUser] �A�C�e�� {item.gameObject.name} ��ItemData��null�ł�");
            return;
        }

        if (item.Data.effect == null)
        {
            Debug.LogWarning($"[ItemUser] �A�C�e�� {item.Data.itemName} �̃G�t�F�N�g��null�ł�");
            return;
        }

        Debug.Log($"[ItemUser] {gameObject.name} �� {item.Data.itemName} ���g�p���܂�");

        // �G�t�F�N�g��K�p
        item.Data.effect.Apply(gameObject);

        // �A�C�e��������
        Debug.Log($"[ItemUser] �A�C�e�� {item.Data.itemName} ������܂�");
        item.ConsumeItem();
    }
}