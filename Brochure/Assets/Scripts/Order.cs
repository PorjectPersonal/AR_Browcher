using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEditor;
using TMPro;
public class Order : MonoBehaviour
{
    public TMP_Text fooditem;
    public TMP_Text foodcost;
    public TMP_Text foodquantity;
    private int quantity = 1;

    // Start is called before the first frame update
    void Start()
    {
        fooditem.text = PlayerPrefs.GetString("fooditem");
        foodcost.text = PlayerPrefs.GetString("foodcost");
    }

    // Update is called once per frame
    void Update()
    {
        foodquantity.text = quantity.ToString();
    }
    public void Quantityadd()
    {
        quantity++;
    }
    public void Quantityless()
    {
        quantity--;
    }
    public void arprojection()
    {
        SceneManager.LoadScene("AR");
    }
    public void menu()
    {
        SceneManager.LoadScene("Menu");
        PlayerPrefs.DeleteAll();

    }
    public void quit()
    {
        Application.Quit();
        PlayerPrefs.DeleteAll();
    }
}
