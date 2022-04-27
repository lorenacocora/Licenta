using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(PolygonCollider2D))]
public class TeritoryHandler : MonoBehaviour
{

    private SpriteRenderer sprite;
    private Color32 spriteColor = new Color32(50,50,48,100);
    private Color32 hoverColor = new Color32(50,50,48,60);


    private void Awake()
    {
        sprite = GetComponent<SpriteRenderer>();
        sprite.color = spriteColor;
    }

    void OnMouseEnter()
    {
        spriteColor = sprite.color;
        sprite.color = hoverColor;
    }

    void OnMouseExit()
    {
        sprite.color = spriteColor;
    }
}
