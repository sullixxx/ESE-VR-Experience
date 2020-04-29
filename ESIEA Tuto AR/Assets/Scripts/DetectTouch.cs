using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class DetectTouch : MonoBehaviour
{

    Camera m_meCamera = null;
    ARSessionOrigin m_ARorigin = null;
    public int m_layerMask = 1 << 9;
    private Vector2 touchPosition = default;

    // Start is called before the first frame update
    void Start()
    {
        m_meCamera = GetComponent<Camera>();
        m_ARorigin = FindObjectOfType<ARSessionOrigin>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            touchPosition = touch.position;

            if (touch.phase == TouchPhase.Began)
            {
                Ray ray = m_meCamera.ScreenPointToRay(touch.position);
                RaycastHit hitObject;
                if (Physics.Raycast(ray, out hitObject, 900.0f, m_layerMask))
                {
                    GameObject.Find("screen").GetComponent<AnimationURL>().enabled = true;
                    //Application.OpenURL("https://ese.esiea.fr");               
                }
            }
        }
    }
}
