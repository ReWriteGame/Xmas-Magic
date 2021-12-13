using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Pumpkin : MonoBehaviour
{
    public UnityEvent openPumpkinEvent;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Hero>())
            openPumpkinEvent?.Invoke();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Hero>())
            openPumpkinEvent?.Invoke();
    }
}
