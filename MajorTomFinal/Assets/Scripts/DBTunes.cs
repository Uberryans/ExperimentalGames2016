using UnityEngine;
using System.Collections;

public class DBTunes : MonoBehaviour
{

    public AudioSource AS;
    public AudioClip[] list;
    public int i = 0;


    void Start()
    {
        AS = gameObject.GetComponent<AudioSource>();

        list = new AudioClip[]{(AudioClip)Resources.Load("david bowie - changes"),
                                     (AudioClip)Resources.Load("David Bowie - Fame"),
                                     (AudioClip)Resources.Load("David Bowie - Heroes   lyrics"),
                                     (AudioClip)Resources.Load("David Bowie - Rebel Rebel"),
                                     (AudioClip)Resources.Load("David Bowie - Suffragette city"),
                                     (AudioClip)Resources.Load("David Bowie - Ziggy Stardust"),
                                     (AudioClip)Resources.Load("David Bowie- Space Oddity Original Video (1969)"),
                                     (AudioClip)Resources.Load("David Bowie Young Americans"),
                                     (AudioClip)Resources.Load("DAVID BOWIE_____THE MAN WHO SOLD THE WORLD")};
    }



    void Update()
    {
        AS.volume += Input.GetAxis("Mouse ScrollWheel");

        if (!AS.isPlaying)
        {
            if (i == 8)
            {
                i = 0;
            }
            else { i++; }
            AS.clip = list[i];
            AS.Play();
        }

        if (Input.GetMouseButtonDown(0))
        {
            if (i == 0)
            {
                i = 8;
            }
            else { i--; }
            AS.clip = list[i];
            AS.Play();
        }

        if (Input.GetMouseButtonDown(1))
        {
            if (i == 8)
            {
                i = 0;
            }
            else { i++; }
            AS.clip = list[i];
            AS.Play();
        }
    }

}
