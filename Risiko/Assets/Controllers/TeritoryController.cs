using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(PolygonCollider2D))]
public class TeritoryController : MonoBehaviour
{

    private SpriteRenderer _sprite;
    private Color32 _spriteColor = new Color32(50,50,48,100);
    private Color32 _hoverColor = new Color32(50,50,48,60);

    public GameObject Tank;



    private void Awake()
    {
        _sprite = GetComponent<SpriteRenderer>();
        _sprite.color = _spriteColor;

        SpriteRenderer tankRenderer = Tank.GetComponent<SpriteRenderer>();
        int randomNumber = Random.Range(0, 10);
        print(randomNumber);
        if (randomNumber <= 5)
        {
            tankRenderer.color = new Color32(0, 0, 0, 255);
        }
        else tankRenderer.color = new Color32(255, 255, 255, 255);

    }

    void OnMouseEnter()
    {
        _spriteColor = _sprite.color;
        _sprite.color = _hoverColor;
    }

    void OnMouseExit()
    {
        _sprite.color = _spriteColor;
    }
}
