using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Ground : MonoBehaviour
{
    public UnityEvent pumkinFallEvent;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Pumpkin>())
            pumkinFallEvent?.Invoke();

        if (collision.gameObject.GetComponent<Destroyable>())
            collision.gameObject.GetComponent<Destroyable>().Destroy(.5f);
    }
}
