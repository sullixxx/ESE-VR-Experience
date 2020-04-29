using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationURL : MonoBehaviour
{

    public float m_rotationSpeed = 40.0f;   // rotation speed in degrees/second
    private float m_angle = 0.0f;           // current orientation angle (in degrees) around Y axis

    // Start is called before the first frame update
    void Start()
    {
        m_angle = 0.0f; // reset the orientation of the object setting the angle
    }

    // Update is called once per frame
    void Update()
    {
        // calculate the new angle according to the time elapsed since last frame
        m_angle += m_rotationSpeed * Time.deltaTime;

        // apply local rotation to the object the script is applied on
        if (m_angle >= 105.0f && m_angle <= 360.0f){
            //disable script
            enabled = false;
        }
        else{
          this.transform.localRotation = Quaternion.Euler(m_angle,0.0f,0.0f);
        }

    }

    void OnDisable()
	{
        Application.OpenURL("https://ese.esiea.fr");
    }
}
