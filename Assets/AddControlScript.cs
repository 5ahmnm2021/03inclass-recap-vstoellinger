using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddControlScript : MonoBehaviour
{

    public InputField n1;
    public InputField n2;
    public Text sum;
    public Text message;

    public Color rot = Color.red;
    public Color weiss = Color.white;

    public float n1Float;
    public float n2Float;

    private bool num1 = true;
    private bool num2 = true;

    public void Addition()
    {
        try
        {
            n1Float = float.Parse(n1.text);
            n1.image.color = weiss;
            message.text = "";
            num1 = true;
        }

        catch (System.Exception)
        {
            message.text = "Versuch es mit Nummern!";
            n1.image.color = rot;
            num1 = false;
        }

        try
        {
            n2Float = float.Parse(n2.text);
            n2.image.color = weiss;
            num2 = true;
        }

        catch (System.Exception)
        {
            message.text = "Versuch es mit Nummern!";
            n2.image.color = rot;
            num2 = false;
        }


        if (num1 && num2)
        {
            sum.text = (n1Float + n2Float).ToString();
            Debug.Log("Es kommt raus: " + sum.text);
        }

        else
        {
            sum.text = "/";
        }

    }
}
