using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guns : MonoBehaviour
{
    ArmasLeves Glock;

    void Start()
    {
        Glock = new ArmasLeves();
        Glock.Peso = 1;
        Glock.VelDisparo = 5;
        Glock.TempRecarga = 4;
    }
    void Update()
    {
        if (Player.EstaComGlock == true && Player.Vivo == true)
        {

        }
    }

}
public class ArmasLeves : Guns
{

    public int Peso;
    public int VelDisparo;
    public int TempRecarga;

    public GameObject Bala;
    public GameObject LocalTiro;


    void Tiro()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && Player.Vivo == true)
        {

        }
    }
    void Recarga()
    {
        if (Input.GetKeyDown(KeyCode.R) && Player.Vivo == true)
        {

        }
    }
    void TempTiro()
    {

    }
}
