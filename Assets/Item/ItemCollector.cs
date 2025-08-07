// �A�C�e�����擾�������Ƃ�ʒm���邾���ɂ���

using UnityEngine;
using System;

public class ItemCollector : MonoBehaviour
{
    public event Action<Item> OnItemCollected;//�A�C�e���������ɂ��郁�\�b�h��o�^�ł���

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Item item = collision.GetComponent<Item>();
        if (item == null) return;

        OnItemCollected?.Invoke(item);//�ʒm����
    }
}
