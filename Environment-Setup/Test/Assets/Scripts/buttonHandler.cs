using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonHandler : MonoBehaviour {

    public bool scene1;
    public bool scene2;
    public bool scene3;


    void OnTriggerEnter(Collider Other) //Senses when an controller touches the object
    {
        if (Other.tag == "VrController")
        {
            if (scene1 == true)
            {
                SceneManager.LoadScene("HouseScene1"); //This will load the scene that is named "Floor One" change the scene name in the script
            }
            else if (scene2 == true)
            {
                SceneManager.LoadScene("scene2"); // loads a scene called "Floor Two"
            }
            else if (scene3 == true)
            {
                SceneManager.LoadScene("scene3");
            }
            else
            {
                Debug.Log("Multiple bools were enabled on one object");
            }
        }
    }
}
