using UnityEngine;
using System.Collections.Generic;

public class ItemCombiner : MonoBehaviour
{
    private List<Item> collectedItems = new List<Item>();

    // ItemCollector�̃C�x���g���󂯂ăA�C�e�������X�g�ɒǉ�
    public void OnItemCollected(Item item)
    {
        collectedItems.Add(item);
        Debug.Log($"�A�C�e���ǉ�: {item.name}, ���݂̌�: {collectedItems.Count}");

        TryCombine();
    }

    // ���������𖞂������獇������
    private void TryCombine()
    {
        // �Ⴆ��3�ȏ�W�܂����獇��
        if (collectedItems.Count >= 3)
        {
            CombineItems();
        }
    }

    private void CombineItems()
    {
        // ���������̋�̗�i���j
        Debug.Log("�A�C�e�����������܂����I");

        // ������̓��X�g���N���A����Ȃ�
        collectedItems.Clear();
    }
}
