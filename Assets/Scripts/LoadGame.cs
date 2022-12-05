using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGame : MonoBehaviour

{

    //remover os métodos default
	public void CarregarCorredor(){
		//método inicia uma nova cena
		SceneManager.LoadScene ("corredor");
	}
}