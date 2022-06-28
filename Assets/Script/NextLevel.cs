using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NextLevel : MonoBehaviour
{
    public AudioSource nextLevelSource;

    [SerializeField] AudioClip nextLevel;


    void Start()
    {
        nextLevelSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision other)
    {
        switch (other.gameObject.tag)
        {
            case "Turtle":
                nextLevelSource.clip = nextLevel;
                nextLevelSource.Play();
                LoadLevel();
                break;
        }
    }

    void LoadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
