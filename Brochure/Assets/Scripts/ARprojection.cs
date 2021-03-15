using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;


public class ARprojection : MonoBehaviour
{
    public GameObject[] fooditems;
    public TMP_Text fooditem;
    public int selectedfooditems = 0;

    void Update()
    {
        fooditem.text = fooditems[selectedfooditems].gameObject.name;
    }
    public void NextCharacter()
    {
        fooditems[selectedfooditems].SetActive(false);
        selectedfooditems = (selectedfooditems + 1) % fooditems.Length;
        fooditems[selectedfooditems].SetActive(true);
    }

    public void PreviousCharacter()
    {
        fooditems[selectedfooditems].SetActive(false);
        selectedfooditems--;
        if (selectedfooditems < 0)
        {
            selectedfooditems += fooditems.Length;
        }
        fooditems[selectedfooditems].SetActive(true);

    }
    public void addcart()
    {
        PlayerPrefs.SetString("fooditem", fooditem.text);
    }
    public void Viewcart()
    {
        SceneManager.LoadScene("Order");
    }
}
