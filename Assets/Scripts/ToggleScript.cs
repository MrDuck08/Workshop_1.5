using UnityEngine;

public class ToggleScript : MonoBehaviour
{
    public GameObject gameObject;
    public bool toggle;
    
    public void Toggle()
    {
        if (toggle)
        {
            gameObject.SetActive(false);
            toggle = false;
        }
        else
        {
            gameObject.SetActive(true);
            toggle = true;
        }
    }
}
