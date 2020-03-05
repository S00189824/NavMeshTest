using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(AudioSource))]
public class PlayerMovementAudio : MonoBehaviour
{
    public List<AudioClip> possibleClips;
    AudioSource AudioSource;
    // Start is called before the first frame update
    public  void Start()
    {
        AudioSource = GetComponent<AudioSource>();
        GetComponent<PlayerMovementRayCast>().RayCastReady += PlayerNavMover_RayCastReady;
        
    }

    private void PlayerNavMover_RayCastReady(RaycastHit selectionData)
    {
        //pic random Audio

        if(possibleClips.Count > 0)
        {
            int index = Random.Range(0, possibleClips.Count - 1);
            AudioSource.clip = possibleClips[index];

            if (!AudioSource.isPlaying)
                AudioSource.Play();
        }
        
    }
}
