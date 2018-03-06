using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Vidas : MonoBehaviour {

	public static int vidas = 3;   //Variable static 'var de Clase'.

	public Bola bola;

	public Barra barra;

	public Text textoVidas;

	public GameObject gameOver;

	public SiguienteNivel siguienteNivel;

	public SonidosFinPartida sonidosFinPartida;



	// Use this for initialization
	void Start () 
	{
		ActualizarMarcadorVidas ();
	}

	void ActualizarMarcadorVidas()
	{
		textoVidas.text = "Vidas: " + Vidas.vidas;
	}

	public void PerderVida()
	{
		if (Vidas.vidas <= 0)
			return;

		Vidas.vidas--;
		ActualizarMarcadorVidas ();
		sonidosFinPartida.BolaPerdida ();
		sonidosFinPartida.sourceMusicaJuego.Play ();

			if (Vidas.vidas <= 0) 
		{
			sonidosFinPartida.GameOver ();
			// Mostrar mensage GameOver
			gameOver.SetActive(true);  //activa el GameObject 
			bola.DetenerMovimiento ();
			barra.enabled = false;      //activa un componente del GameObject

			sonidosFinPartida.sourceMusicaJuego.Stop ();

			siguienteNivel.nivelACargar = "Portada"; //provisional

			siguienteNivel.ActivarCarga ();
		}
		else
		{
			barra.Reset ();
			bola.Reset ();
		}

	}


}
