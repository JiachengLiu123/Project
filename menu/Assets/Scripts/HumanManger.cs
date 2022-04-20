using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanManger : MonoBehaviour
{
    public GameObject human;
    public float value;
    public Vector3 sizeChange;

    public void MoveLeft()
    {
        value = value - 1f;
        human.transform.position = new Vector3(value, 0, 0);
    }

    public void MoveRight()
    {
        value = value + 1f;
        human.transform.position = new Vector3(value, 0, 0);
    }

    public void MoveOn()
    {
        value = value + 5f;
        human.transform.position = new Vector3(0, value, 0);
    }

    public void MoveUnder()
    {
        value = value - 5f;
        human.transform.position = new Vector3(0, value, 0);
    }

    public void MoveForeword()
    {
        value = value + 5f;
        human.transform.position = new Vector3(0, 0, value);
    }

    public void MoveBackword()
    {
        value = value - 5f;
        human.transform.position = new Vector3(0, 0, value);
    }

    public void RotateLeft()
    {
        human.transform.Rotate(20f, 0f, 0f);
    }

    public void Grow()
    {
        human.transform.localScale = human.transform.localScale + sizeChange;
    }

    public void ResetHuman()
    {
        human.transform.position = new Vector3(0, 0, 0);
        human.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
    }
}
