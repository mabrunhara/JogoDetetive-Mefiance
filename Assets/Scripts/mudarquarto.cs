using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class mudarquarto : MonoBehaviour
{
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // abrir com tecla "A"
        if(Input.GetKeyDown(KeyCode.Q) ) {
          SceneManager.LoadScene("quarto");
        }
    }

   
     public void abrirQuarto(){
      
    }


}
