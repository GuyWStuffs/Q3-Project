using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Button : MonoBehaviour
{
    public UnityEvent onButtonPressed;
    public UnityEvent onButtonUnpressed;
    // Start is called before the first frame update
    //void Start()
    //{

    //}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && onButtonPressed != null) onButtonPressed.Invoke();
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && onButtonUnpressed != null) onButtonUnpressed.Invoke();
    }
}
