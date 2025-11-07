using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BUTTONN : MonoBehaviour

{
    public Button Robin;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Button robinbtn = Robin.GetComponent<Button>();
        robinbtn.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {


    }

    void TaskOnClick()
    {
        SceneManager.LoadScene("Robin");
    }
    
}