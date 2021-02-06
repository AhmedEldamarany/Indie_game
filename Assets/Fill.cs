using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Fill : MonoBehaviour
{
  public TMP_Text name;
  public TMP_Text email;
  public TMP_Text gender;
  public TMP_Text country;
  public GameObject panel1;
  public Form form;
    void Start()
    {
        form = panel1.GetComponent<Form>();
        Data data = form.data;
        Debug.Log(data.name);
        name.text = data.name;
        email.text = data.mail;
        gender.text = data.gender;
        country.text = data.country;
    }
}
