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
            Destroy(this.gameObject);
        }


        audioSource = GetComponent<AudioSource>();

        if(audioSource != null)
        {

            audioSource.volume = volume;

        }

        DontDestroyOnLoad(this.gameObject);
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
