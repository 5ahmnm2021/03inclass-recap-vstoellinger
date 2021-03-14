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

    public void Addition()
    {
        try
        {
            n1Float = float.Parse(n1.text);
            n1.image.color = weiss;
            message.text = "";
        }

        catch (System.Exception)
        {
            message.text = "Versuch es mit Nummern!";
            n1.image.color = rot;
        }

        try
        {
            n2Float = float.Parse(n2.text);
            n2.image.color = weiss;
        }

        catch (System.Exception)
        {
            message.text = "Versuch es mit Nummern!";
            n2.image.color = rot;
        }

        sum.text = (n1Float + n2Float).ToString();
        Debug.Log("Es kommt raus: " + sum.text);

    }
}
