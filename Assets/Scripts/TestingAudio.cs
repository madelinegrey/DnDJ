using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingAudio : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AkSoundEngine.PostEvent("Test", this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
