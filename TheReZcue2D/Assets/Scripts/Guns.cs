using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guns : MonoBehaviour
{
    //Armas da classe ArmasLeves
    ArmasLeves Glock;
    ArmasLeves Usp;

    public GameObject Bala;
    public Transform LocalTiro;

    void Start()
    {
        Glock = new ArmasLeves();

        //ArmasAtributos
        GlockAtributos();
        UspAtributos();

    }
    void Update()
    {
        //Voids
        Recarga();
    }
    public void Tiro()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && Player.Vivo == true)
        {
            //Sistema de Tiros da Glock
            if (Player.EstaComGlock == true)
            {
                //Precisa criar o FireRate da Glock
                Instantiate(Bala, new Vector3
                    (LocalTiro.position.x,
                    LocalTiro.position.y,
                    LocalTiro.position.z), LocalTiro.rotation);

                //Aplicacao da Velocidade do Disparo
                Bala.gameObject.transform.Translate(Glock.VelDisparo*Time.deltaTime,
                    Glock.VelDisparo * Time.deltaTime,
                    Glock.VelDisparo * Time.deltaTime);
            }
        }
    }
    public void Recarga()
    {
        if (Input.GetKeyDown(KeyCode.R) && Player.Vivo == true)
        {
            if (Player.EstaComGlock == true)
            {
                Glock.Balas = Glock.MaximoBalas;
            }
            if (Player.EstaComUsp == true)
            {
                Usp.Balas = Usp.MaximoBalas;
            }
        }
    }
    void GlockAtributos()
    {
        Glock.Dano = 20;
        Glock.Peso = 1;
        Glock.VelDisparo = 5;
        Glock.TempRecarga = 4;
        Glock.MaximoBalas = 20;
        Glock.Balas = Glock.MaximoBalas;
    }
    void UspAtributos()
    {
        Usp.Dano = 25;
        Usp.Peso = 1;
        Usp.VelDisparo = 4;
        Usp.TempRecarga = 4;
        Usp.MaximoBalas = 20;
        Usp.Balas = Usp.MaximoBalas;
    }
}
public class ArmasLeves : Guns
{
    public int Dano;
    public int Peso;
    public int VelDisparo;
    public int TempRecarga;
    public int Balas;
    public int MaximoBalas;
}
