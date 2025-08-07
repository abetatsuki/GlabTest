// アイテムを取得したことを通知するだけにする

using UnityEngine;
using System;

public class ItemCollector : MonoBehaviour
{
    public event Action<Item> OnItemCollected;//アイテムを引数にするメソッドを登録できる

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Item item = collision.GetComponent<Item>();
        if (item == null) return;

        OnItemCollected?.Invoke(item);//通知する
    }
}
