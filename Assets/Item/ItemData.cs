// === 5. ItemData �N���X�i�f�[�^�ێ��̐Ӗ��̂݁j ===
using UnityEngine;
[CreateAssetMenu(menuName = "Item/ItemData")]
public class ItemData : ScriptableObject
{
    [Header("��{���")]
    public string itemName;
    public Sprite itemSprite; // �� �ǉ��I

    [Header("�G�t�F�N�g�ݒ�")]
    public HealEffect effect = new HealEffect();
  
   
}
