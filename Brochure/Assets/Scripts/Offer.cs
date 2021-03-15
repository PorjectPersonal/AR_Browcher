using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Offer : MonoBehaviour
{
    public TMP_Text[] fooditem;
    private int fooditemvalue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void offerfoodaddcart()
    {
        PlayerPrefs.SetString("fooditem", fooditem[fooditemvalue].text);
    }
    public void arprojection()
    {
        SceneManager.LoadScene("AR");
    }
    public void orders()
    {
        SceneManager.LoadScene("Order");
    }
}
