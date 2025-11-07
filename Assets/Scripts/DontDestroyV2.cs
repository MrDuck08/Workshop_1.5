using UnityEngine;

public class DontDestroyV2 : MonoBehaviour
{
    public GameObject gameObject;

    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
}
