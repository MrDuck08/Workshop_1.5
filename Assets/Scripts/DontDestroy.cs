using UnityEngine;
using UnityEngine.UI;

public class DontDestroy : MonoBehaviour
{

    float volume = 1;
    AudioSource audioSource;
    Slider slider;
    
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

    public void ChangeVolume()
    {

        slider = FindObjectOfType<Slider>();

        volume = slider.value;

        if (audioSource != null)
        {

            audioSource.volume = volume;

        }

    }
}
