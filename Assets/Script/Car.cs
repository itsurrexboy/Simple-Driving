using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Car : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float speedGain = 0.2f;
    [SerializeField] float turnSpeed = 200f;

    float steerValue;

    void Update()
    {

        speed += speedGain * Time.deltaTime;
        transform.Rotate(0f, steerValue * turnSpeed * Time.deltaTime, 0f);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Obstacle"))
        {
            SceneManager.LoadScene(0);
        }

    }

    public void Steer(int value)
    {
        steerValue = value;
    }
}
