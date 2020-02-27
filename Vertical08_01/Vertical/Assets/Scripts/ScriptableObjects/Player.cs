using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Player", order = 1)]
public class Player : ScriptableObject
{

    public float walkSpeed;
    public float maxSpeed;
    public float jumpForce;
    public float weight;

    public bool isJumping;
    public bool isClimbing;


    public void moveTo(Vector3 Direction)
    {

    }
}
