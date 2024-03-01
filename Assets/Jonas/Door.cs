using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public bool isOpened;
    public Sprite doorOpen;
    public Sprite doorClose;
    private SpriteRenderer spriteRenderer;
    private Collider2D hitbox;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        hitbox = GetComponent<Collider2D>();
    }
    public void Open()
    {
        hitbox.enabled = false;
        spriteRenderer.sprite = doorOpen;
        isOpened = true;
    }
    public void Close()
    {
        hitbox.enabled = true;
        spriteRenderer.sprite = doorClose;
        isOpened = false;
    }
}
