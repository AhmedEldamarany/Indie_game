
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class Data
{
    public string name;
    public string mail;
    public string gender;
    public string country;
}
public class Form : MonoBehaviour
{
    public TMP_Text name;
    public TMP_Text Email;
    public TMP_Text Country;
    public ToggleGroup gender;
    public Data data { get; set; }
    public GameObject otherPanel;
   
    
    
    public void onSubmit()
    {
        data = new Data();
        data.name = name.text;
        data.mail = Email.text;

        foreach (Toggle toggle in gender.ActiveToggles())
        {
            if (toggle.isOn)
                data.gender = toggle.name;
        }

        data.country = Country.text;
        this.transform.gameObject.SetActive(false);
        otherPanel.SetActive(true);

    }
   


}
