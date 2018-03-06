using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntos : MonoBehaviour {

	public static int puntos = 0;

	public Text textoPuntos;

	public GameObject nivelCompleto;

	public GameObject juegoFinalizado;

	public SiguienteNivel siguienteNivel;

	public Bola bola;

	public Transform contenedorBloques;

	public Barra barra;

	public SonidosFinPartida sonidosFinpartida;

	// Use this for initialization
	void Start () {
		ActualizarMarcador ();
	}

	void ActualizarMarcador()
	{
		textoPuntos.text = "Puntos: " + Puntos.puntos;
	}

	public void GanarPunto()
	{
		Puntos.puntos++;
		ActualizarMarcador ();

		if (contenedorBloques.childCount <= 0) 
		{
			bola.DetenerMovimiento ();
			barra.enabled = false;

			if (siguienteNivel.EsUltimoNivel ()) 
			{
				juegoFinalizado.SetActive (true);
			} 
			else 
			{
				nivelCompleto.SetActive (true);
			}

			sonidosFinpartida.NivelCompletado();

			siguienteNivel.ActivarCarga ();

		}
	}
}
