using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorSwitch : MonoBehaviour
{

    private int random;

    public Image colorSwitch;

   void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            random = Random.Range(0, 4);

            if(random == 0)
            {
                colorSwitch.color = new Color32(255, 205, 25, 255);
            }

            if (random == 1)
            {
                colorSwitch.color = new Color32(95, 34, 0, 255);
            }

            if (random == 2)
            {
                colorSwitch.color = new Color32(207, 63, 21, 255);
            }

            if (random == 3)
            {
                colorSwitch.color = new Color32(102, 47, 84, 255);
            }

        }
    }
       
}
