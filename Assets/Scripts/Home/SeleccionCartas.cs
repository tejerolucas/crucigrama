using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SeleccionCartas : MonoBehaviour {

	public GameObject[] cartasLista;
	public GameObject[] cartasGrandes;
	public GameObject FondoGris;
	public int IDCarta;
	public string NombreCarta;
	public Text DescripcionCarta;

	void CartaChicaNoMostrar () {
		NombreCarta = "Carta" + IDCarta.ToString() + "Grande";
		foreach (GameObject obj in cartasLista){
			obj.active = false;
		}
		AbrirCartaGrande();
		FondoGris.SetActive(true);
	}

	void CartaChicaMostrar () {
		foreach (GameObject obj in cartasLista){
			obj.active = true;
		}
		CerrarCartaGrande();
		FondoGris.SetActive(false);
		DescripcionCarta.text = "Descripcion de la carta.";
	}

	void AbrirCartaGrande(){
		foreach (GameObject obj in cartasGrandes){
			if(obj.name == NombreCarta){
				obj.active = true;
			}
		}
		switch(NombreCarta){
		case "Carta1Grande":
			DescripcionCarta.text = "CHICA ELFA RUBIA...";
			break;
		case "Carta2Grande":
			DescripcionCarta.text = "Parn Guerrero Legendario de mucho poder";
			break;
		case "Carta3Grande":
			DescripcionCarta.text = "Chica elfa rubia... ahora con mas texto";
			break;
		case "Carta4Grande":
			DescripcionCarta.text = "EL TEAM ENTERO, GUERREROS SUPER PODEROSOS!!!";
			break;
		}
	}

	void CerrarCartaGrande(){
		foreach (GameObject obj in cartasGrandes){
			obj.active = false;
		}
	}

	void Setear1(){
		IDCarta = 1;
		CartaChicaNoMostrar();
	}
	void Setear2(){
		IDCarta = 2;
		CartaChicaNoMostrar();
	}
	void Setear3(){
		IDCarta = 3;
		CartaChicaNoMostrar();
	}
	void Setear4(){
		IDCarta = 4;
		CartaChicaNoMostrar();
	}
}
