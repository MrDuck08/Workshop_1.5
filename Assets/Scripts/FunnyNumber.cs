using UnityEngine;

public class FunnyNumber : MonoBehaviour
{
    [SerializeField] private bool notNewgen;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (notNewgen == false)
        {
            Debug.Log(message: "67");
        }
        if (notNewgen == true)
        {
            Debug.Log(message: "69");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
