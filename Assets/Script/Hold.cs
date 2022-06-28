using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;
using UnityEngine.UI;

public class Hold : MonoBehaviour
{
    public Transform holder;
    public bool isHeld;
    public float minForce;
    bool charge;
    public float maxForce;
    public float chargeSpeed;
    float throwForce;
    public Slider slider;
    public GameObject barDeCharge;
    public AudioSource sourceAudio;

    [SerializeField] AudioClip lancer;
    [SerializeField] AudioClip chargement;

    void Start()
    {
        charge = false;
        throwForce = minForce - 0.1f;
        slider.maxValue = maxForce;
        slider.minValue = throwForce = minForce - 0.1f;
        barDeCharge.SetActive(false);
        sourceAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!GetComponent<animationStateController>().selected)
        {
            if (Input.GetMouseButtonDown(1) && holder.parent.GetComponent<ThirdPersonCharacter>().m_IsGrounded)
                pickup();
            if (Input.GetMouseButtonDown(0) && isHeld)
            {
                charge = true;
                sourceAudio.clip = chargement;
                sourceAudio.Play();
            }
            if (Input.GetMouseButtonUp(0))
                charge = false;
            if (charge && throwForce <= maxForce)
                throwForce += chargeSpeed;
            if (!charge && throwForce >= minForce && isHeld)
            {
                turtleThrow();
                sourceAudio.clip = lancer;
                sourceAudio.Play();
            }
            slider.value = throwForce;
        }
    }

    void pickup()
    {
        barDeCharge.SetActive(true);
        GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        GetComponent<ThirdPersonCharacter>().m_IsGrounded = false;
        GetComponent<ThirdPersonUserControl>().enabled = false;
        GetComponent<animationStateController>().enabled = false;
        GetComponent<Rigidbody>().useGravity = false;
        GetComponent<Transform>().position = holder.position;
        GetComponent<Transform>().parent = holder.parent;
        isHeld = true;
    }
    void turtleThrow()
    {
        GetComponent<Transform>().parent = null;
        GetComponent<ThirdPersonUserControl>().enabled = false;
        GetComponent<animationStateController>().enabled = false;
        GetComponent<Rigidbody>().useGravity = true;
        GetComponent<Rigidbody>().AddForce((holder.forward + new Vector3(0, 0.5f, 0)) * throwForce, ForceMode.Impulse);
        isHeld = false;
        charge = false;
        throwForce = minForce - 0.1f;
        barDeCharge.SetActive(false);
    }
}