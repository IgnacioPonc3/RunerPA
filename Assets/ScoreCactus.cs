using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCactus : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("player"))
        {
            Score.instance.UpdateScore();
        }
    }
}
