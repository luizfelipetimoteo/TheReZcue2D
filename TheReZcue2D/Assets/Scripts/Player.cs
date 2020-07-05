using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static bool EstaComGlock;
    public static bool Vivo;
    private int Speed;
    private int Vida;

    void Start()
    {
        EstaComGlock = false;
        Vida = 100;
        Vivo = true;
        Speed = 3;
    }
    void Update()
    {
        Player_Move();
        Player_Dead();
    }

    void Player_Move()
    {
        //Vertical
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0,Speed*Time.deltaTime,0);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -Speed * Time.deltaTime, 0);
        }
        //Horizontal
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-Speed * Time.deltaTime, 0,0);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Speed * Time.deltaTime, 0, 0);
        }
    }
    void Player_Dead()
    {
        if (Vida <= 0)
        {
            Vida = 0;
            Vivo = false;
            Destroy(gameObject);
        }
    }
}
