using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private PlayerGeneric RedForcePlayer = new ("Red Force Ranger", "Red Army", "Republic of Red", "sword",
        0.2, 0.8, 0.3, 0.1, 0.6);

    private PlayerGeneric CyanForcePlayer = new ("Cyan Force Ranger", "Cyan Army", "Republic of Cyan",
        "polearm", 0.8, 0.5, 1.0, 0.9, 1.0);

    private GameObject player;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {

        }
    }
}
