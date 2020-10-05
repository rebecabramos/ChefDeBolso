using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickDetector : MonoBehaviour
{
    public GameObject prato1;
    public GameObject prato2;
    public GameObject prato3;
    public GameObject prato4;

    private bool isPlaying;

    // Start is called before the first frame update
    void Start()
    {
        isPlaying = false;
        prato1.GetComponent<GameObject>();
        prato2.GetComponent<GameObject>();
        prato3.GetComponent<GameObject>();
        prato4.GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            if (!isPlaying)
            {
                prato1.SetActive(true);
                prato2.SetActive(true);
                prato3.SetActive(true);
                prato4.SetActive(true);
            }  
            else
            {
                prato1.SetActive(false);
                prato2.SetActive(false);
                prato3.SetActive(false);
                prato4.SetActive(false);
            }

        }
        
        isPlaying = !isPlaying;
    }

    

}
