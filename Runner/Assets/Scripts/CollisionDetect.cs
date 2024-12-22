using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionDetect : MonoBehaviour
{
    public PlayerController playercontroller;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision) //Metoda która na wejsciu w kolizje zostaje wykonana
    {
        if (collision.gameObject.tag == "Obstacle") //Czy gameobject z ktorym doszlo do kolizji ma tag "Obstacle"
        {
            Debug.Log("doszlo do kolizji z przeszkod¹"); //Debug.Log wyswietla nam informacje w konsoli

            SceneManager.LoadScene(SceneManager.GetActiveScene().name); //Scene Manager wczytuje scene ktora akutualnie jest aktywna

        }

        if (collision.gameObject.tag == "Shield")
        {
            Debug.Log("zebrano tarcze");


        }









    }
}
