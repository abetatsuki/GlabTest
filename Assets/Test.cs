using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private ItemData itemData;

    void Start()
    {
        if (spriteRenderer != null && itemData != null)
        {
            spriteRenderer.sprite = itemData.itemSprite;
        }
    }

}
