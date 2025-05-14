using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class script : MonoBehaviour
{
    int num1;
    public TMP_InputField inputField;
    public TextMeshProUGUI txtParOImpar;

    // Start is called before the first frame update
    void Start()
    {
        txtParOImpar.text = string.Empty;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ParOImpar()
    {
        num1 = int.Parse(inputField.text);
        if(num1<= 0)
        {
            txtParOImpar.text = "el numero no es valido";
            return;
        }
        if (num1 % 2 == 0)
        {
            txtParOImpar.text = "el numero es par";
            return;
        }
        else
        {
            txtParOImpar.text = "el numero es impar";
            return;
        }
    }

}
