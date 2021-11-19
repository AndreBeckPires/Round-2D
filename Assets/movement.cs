using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    bool keyA = false;
    bool keyD = false;
    public float timer, max = 10, min = 2;
    // public AudioClip clip;
    AudioSource audioData;
    bool shouldplay = false;
    // Start is called before the first frame update
    void Start()
    {
        timer = Random.Range(min, max);
        audioData = GetComponent<AudioSource>();
        audioData.Play(0);

    }

    // Update is called once per frame
    void Update()
    {
            
     
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            print(timer);
        }
        if(timer <= 0)
        {
            print("entrou");
            if(audioData.isPlaying)
            audioData.Stop();
            else if (!audioData.isPlaying)
                audioData.Play(0);
            timer = Random.Range(min, max);

        }
            

        if (Input.GetKeyDown(KeyCode.A))
        {
            print("space key A pressed");
            keyA = true;

        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            print("space key D pressed");
            if (keyA == true)
                keyD = true;
            else
            {
                keyA = false;
                keyD = false;
            }
        }
        if(keyA == true && keyD == true)
        {
            keyA = false;
            keyD = false;
            transform.position = new Vector3(transform.position.x, transform.position.y + 0.3f, transform.position.z);
        }
    }
}
