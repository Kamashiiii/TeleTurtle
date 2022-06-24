using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

public class Swap : MonoBehaviour
{

    public GameObject TortueBleu;
    public GameObject TortueRouge;
    public GameObject cameraBleu;
    public GameObject cameraRouge;

    public float swapCooldown;
    float swap;

    string selectedTurtle;


    // Start is called before the first frame update
    void Start()
    {
        selectedTurtle = "rouge";
        cameraBleu.SetActive(false);
        cameraRouge.SetActive(true);

        TortueBleu.GetComponent<Animator>().SetBool("isHiding", true);
        TortueRouge.GetComponent<animationStateController>().selected = true;
        TortueBleu.GetComponent<animationStateController>().selected = false;
        TortueBleu.GetComponent<ThirdPersonUserControl>().enabled = false;
        TortueBleu.GetComponent<animationStateController>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.G))
        {
            if (Time.time - swap < swapCooldown)
                return;
            if (selectedTurtle == "rouge" && (!TortueBleu.GetComponent<Hold>().isHeld))
            {
                TortueRouge.GetComponent<ThirdPersonUserControl>().enabled = false; // Désactive la premiere tortue (Rouge)
                TortueRouge.GetComponent<animationStateController>().enabled = false;
                cameraBleu.SetActive(true); // Change la caméra
                cameraRouge.SetActive(false);
                TortueBleu.GetComponent<ThirdPersonCharacter>().enabled = true; // Active la deuxieme Tortue (Bleu)
                TortueBleu.GetComponent<ThirdPersonUserControl>().enabled = true;
                TortueBleu.GetComponent<animationStateController>().enabled = true;
                selectedTurtle = "bleu";
                TortueBleu.GetComponent<animationStateController>().selected = true;
                TortueRouge.GetComponent<animationStateController>().selected = false;
                TortueRouge.GetComponent<Animator>().SetBool("isHiding", true);

            }
            else if (selectedTurtle == "bleu" && (!TortueRouge.GetComponent<Hold>().isHeld))
            {
                TortueBleu.GetComponent<ThirdPersonUserControl>().enabled = false; // Désactive la premiere tortue (Bleu)
                TortueBleu.GetComponent<animationStateController>().enabled = false;
                cameraRouge.SetActive(true);
                cameraBleu.SetActive(false); // Change la caméra
                TortueRouge.GetComponent<ThirdPersonCharacter>().enabled = true; // Active la deuxieme Tortue (Rouge)
                TortueRouge.GetComponent<ThirdPersonUserControl>().enabled = true;
                TortueRouge.GetComponent<animationStateController>().enabled = true;
                selectedTurtle = "rouge";
                TortueRouge.GetComponent<animationStateController>().selected = true;
                TortueBleu.GetComponent<animationStateController>().selected = false;
                TortueBleu.GetComponent<Animator>().SetBool("isHiding", true);
            }
            swap = Time.time;
        }
    }
}
