using UnityEngine;
using System.Collections;

public class flashlight : MonoBehaviour
{
    public static float batery;
    public int maxBatery = 300;
    private bool TurnOn;
    // Use this for initialization
    void Start()
    {
        batery = maxBatery;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Light>().intensity = 0.1f + 2 * batery / maxBatery;

        if (Input.GetKeyDown(KeyCode.F) && TurnOn)
        {
            GetComponent<Light>().enabled = !GetComponent<Light>().enabled;
        }

        if (GetComponent<Light>().enabled)
        {
            batery -= Time.deltaTime;           
        }

        if (batery <= 0)
        {
            TurnOn = false;
            GetComponent<Light>().enabled = false;
        }
        else
        {
            TurnOn = true;
        }
    }
}
