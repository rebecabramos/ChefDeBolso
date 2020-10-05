using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class videopanel : MonoBehaviour
{
    public UnityEngine.Video.VideoClip[] vClips;
    public UnityEngine.Video.VideoPlayer myVideoSource;
    string btnName;

    // Start is called before the first frame update
    void Start()
    {
        myVideoSource = GetComponent<UnityEngine.Video.VideoPlayer>();   
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit Hit;

            if(Physics.Raycast(ray, out Hit)){
                btnName = Hit.transform.name;
                switch (btnName)
                {
                    case "b1":
                        myVideoSource.clip = vClips[0];
                        myVideoSource.Play();
                        break;
                    case "b2":
                        myVideoSource.clip = vClips[0];
                        myVideoSource.Stop();
                        break;
                    default:
                        break;
                }
            }
        }
    }

}
