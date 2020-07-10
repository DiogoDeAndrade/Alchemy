using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CursorHandler : MonoBehaviour
{
    public Image cursorObj;

    Item currentItem;

    void Start()
    {
        SetItem(null);
    }

    private void Update()
    {
        if (currentItem)
        {
            Vector2 mp = Input.mousePosition;
            cursorObj.transform.position = mp;
        }
    }

    public void SetItem(Item item)
    {
        if (item)
        {
            cursorObj.enabled = true;
            cursorObj.sprite = item.image;
        }
        else
        {
            cursorObj.enabled = false;
        }

        currentItem = item;
    }

    public Item GetItem()
    {
        return currentItem;
    }
}
