using UnityEngine;
using System.Collections;

public class HomeSelector : MonoBehaviour {

	public static string NombreCarta;
	public GameObject SeccionCrucigramas;
	public GameObject SeccionCartas;

	void Update() {
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		if (Physics.Raycast(ray, out hit, 100)) {
			NombreCarta = hit.collider.name.ToString();
		}
	}

	void SelectCrucigramas () {
		SeccionCrucigramas.SetActive(true);
		SeccionCartas.SetActive(false);
	}
	
	void SelectCartas () {
		SeccionCrucigramas.SetActive(false);
		SeccionCartas.SetActive(true);
	}
}
