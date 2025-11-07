using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    public string tag;

    float volume = 1;
    AudioSource audioSource;
    
    void Start()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag(transform.tag);

        if (objs.Length > 1)
        {
            objs[0].GetComponent<DontDestroy>().StartFake();

            Destroy(this.gameObject);
        }


        audioSource = FindObjectOfType<AudioSource>();

        if(audioSource != null)
        {

            audioSource.volume = volume;

        }

        DontDestroyOnLoad(this.gameObject);
    }

    public void StartFake()
    {

        audioSource = FindObjectOfType<AudioSource>();

        if (audioSource != null)
        {

            audioSource.volume = volume;

        }

    }
}
