using UnityEngine;
using System.Collections;

public class SeleccionCartas : MonoBehaviour {

	public GameObject[] cartasLista;
	public GameObject[] cartasGrandes;
	public GameObject FondoGris;
	public string CartaGrande = "Grande";
	public string CartaTmp;


	void CartaChicaNoMostrar () {
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
	}

	void AbrirCartaGrande(){
		foreach (GameObject obj in cartasGrandes){
			CartaTmp = HomeSelector.NombreCarta + CartaGrande;
			if(obj.name == CartaTmp){
				obj.active = true;
			}
		}
	}

	void CerrarCartaGrande(){
		foreach (GameObject obj in cartasGrandes){
			obj.active = false;
			}
		}


}
