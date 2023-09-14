using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov : MonoBehaviour
{
    public int fuerzaDeSalto = 8;
    public bool estaSaltando;

    void Start()
    {
        estaSaltando = false;
    }



    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && estaSaltando == false)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, fuerzaDeSalto, 0);
            estaSaltando = true;
        }

        if (Input.GetKeyDown(KeyCode.S) && estaSaltando == true)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0, 0);
        }
    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Piso")
        {
            estaSaltando = false;
        }

        if (collision.gameObject.tag == "Obstaculo")
        {
            Time.timeScale = 0;
        }
    }
}