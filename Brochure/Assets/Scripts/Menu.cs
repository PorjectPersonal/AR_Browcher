using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;



public class Menu : MonoBehaviour
{
    public TMP_Text[] fooditem;
    public TMP_Text[] foodcost;
    private int fooditemvalue;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {

    }
    public void ToggleValueChanged()
    {
        PlayerPrefs.SetString("fooditem", fooditem[fooditemvalue].text);
        PlayerPrefs.SetString("foodcost", foodcost[fooditemvalue].text);
    }
    public void orders()
    {
        SceneManager.LoadScene("Order");
    }
}
