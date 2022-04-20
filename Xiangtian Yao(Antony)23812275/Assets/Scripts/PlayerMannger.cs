using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMannger : MonoBehaviour
{
    public GameObject human;
    public void ResetHuman()
    {
        human.transform.position = new Vector3(0, 0, 0);
        human.transform.rotation = Quaternion.Euler(new Vector3((float)7.09, (float)0.217, (float)-3.68));
    }

}
