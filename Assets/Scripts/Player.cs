using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{

    public static int life { get; set; }
    private int initialLife { get; set; }

    // Use this for initialization
    void Start()
    {
        initialLife = 100;
        life = initialLife;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
