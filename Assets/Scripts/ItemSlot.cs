using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour,
    IPointerDownHandler
{
    public Item     currentItem;
    public Image    itemImage;

    void Start()
    {
        SetItem(currentItem);
    }

    void SetItem(Item item)
    {
        if (item)
        {
            itemImage.enabled = true;
            itemImage.sprite = item.image;
        }
        else
        {
            itemImage.enabled = false;
        }

        currentItem = item;
    }

    public Item GetItem()
    {
        return currentItem;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        CursorHandler ch = GetComponentInParent<CursorHandler>();

        Item prevItem = ch.GetItem();

        ch.SetItem(currentItem);
        SetItem(prevItem);
    }
}
