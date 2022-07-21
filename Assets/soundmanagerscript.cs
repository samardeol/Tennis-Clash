using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundmanagerscript : MonoBehaviour
{
	public static AudioClip hitsound;
	static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        hitsound=Resources.Load<AudioClip> ("bat+hit+ball");
        audioSrc= GetComponent<AudioSource> ();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void PlaySound(string clip)
    {
    	audioSrc.PlayOneShot(hitsound);
    }
}
