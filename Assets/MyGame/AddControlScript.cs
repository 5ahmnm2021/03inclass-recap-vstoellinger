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

    public float n1Float;
    public float n2Float;

    private bool num1 = true;
    private bool num2 = true;

    public void Addition()
    {
        string errorMsg = "Versuch es mit Nummern!";

        try
        {
            n1Float = float.Parse(n1.text);
            n1.image.color = Color.white;
            message.text = "";
            num1 = true;
        }

        catch (System.Exception)
        {
            message.text = errorMsg;
            n1.image.color = Color.red;
            num1 = false;
        }

        try
        {
            n2Float = float.Parse(n2.text);
            n2.image.color = Color.white;
            num2 = true;
        }

        catch (System.Exception)
        {
            message.text = errorMsg;
            n2.image.color = Color.red;
            num2 = false;
        }


        if (num1 && num2)
        {
            sum.text = (n1Float + n2Float).ToString();
        }

        else
        {
            sum.text = "/";
        }

    }
}
