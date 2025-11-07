using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class dacoolerscript : MonoBehaviour
{
    public TMP_Text btn;
    public int num;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        btn.text = num.ToString();
        if (num < 666)
        {
            num++;
        }
        
    }
}
