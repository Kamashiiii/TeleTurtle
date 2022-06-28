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

    public AudioSource sourceAudio;
    [SerializeField] AudioClip teleportation;

    // Start is called before the first frame update
    void Start()
    {
        selectedTurtle = "rouge";
        cameraBleu.SetActive(false);
        cameraRouge.SetActive(true);

        TortueBleu.GetComponent<Animator>().SetBool("isHiding", true);
        TortueBleu.GetComponent<ThirdPersonUserControl>().enabled = false;
        TortueBleu.GetComponent<animationStateController>().enabled = false;
        TortueRouge.GetComponent<ThirdPersonCharacter>().isSelected = true;

        sourceAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.G))
        {
            if (Time.time - swap < swapCooldown)
                return;
            else if (selectedTurtle == "rouge" && (!TortueBleu.GetComponent<Hold>().isHeld))
            {
                sourceAudio.clip = teleportation;
                sourceAudio.Play();
                TortueBleu.GetComponent<ThirdPersonUserControl>().enabled = true; // Active la deuxieme Tortue (Bleu)
                TortueBleu.GetComponent<animationStateController>().enabled = true;
                TortueRouge.GetComponent<ThirdPersonUserControl>().enabled = false; // Désactive la premiere tortue (Rouge)
                TortueRouge.GetComponent<animationStateController>().enabled = false;
                TortueRouge.GetComponent<Rigidbody>().velocity = new Vector3(0,0,0);
                cameraBleu.SetActive(true); // Change la caméra
                cameraRouge.SetActive(false);
                selectedTurtle = "bleu";
                TortueBleu.GetComponent<animationStateController>().selected = true;
                TortueBleu.GetComponent<ThirdPersonCharacter>().isSelected = true;
                TortueRouge.GetComponent<ThirdPersonCharacter>().isSelected = false;
                TortueRouge.GetComponent<animationStateController>().selected = false;
                TortueRouge.GetComponent<Animator>().SetBool("isHiding", true);

            }
            else if (selectedTurtle == "bleu" && (!TortueRouge.GetComponent<Hold>().isHeld))
            {
                sourceAudio.clip = teleportation;
                sourceAudio.Play();
                TortueRouge.GetComponent<ThirdPersonUserControl>().enabled = true; // Active la deuxieme Tortue (Rouge)
                TortueRouge.GetComponent<animationStateController>().enabled = true;
                TortueBleu.GetComponent<ThirdPersonUserControl>().enabled = false; // Désactive la premiere tortue (Bleu)
                TortueBleu.GetComponent<animationStateController>().enabled = false;
                TortueBleu.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
                cameraRouge.SetActive(true);
                cameraBleu.SetActive(false); // Change la caméra
                selectedTurtle = "rouge";
                TortueRouge.GetComponent<animationStateController>().selected = true;
                TortueRouge.GetComponent<ThirdPersonCharacter>().isSelected = true;
                TortueBleu.GetComponent<ThirdPersonCharacter>().isSelected = false;
                TortueBleu.GetComponent<animationStateController>().selected = false;
                TortueBleu.GetComponent<Animator>().SetBool("isHiding", true);
            }
            swap = Time.time;
        }
    }
}
