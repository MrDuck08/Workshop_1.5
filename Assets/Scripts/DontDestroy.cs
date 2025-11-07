using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    public string tag;
    
    void Start()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag(tag);

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }
}
