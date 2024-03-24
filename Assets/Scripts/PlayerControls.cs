using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControls : MonoBehaviour

{
     [Header("Rigidbody")]
    //ridegbody component
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        //varible rb equals to
        //COMPONENT RIDGBODY    
        rb = GetComponent<Rigidbody>();
        //game is at normal pace
        Time.timeScale = 1f;

    }

    // Update is called once per frame
    void Update()
    {
        //rotating object on z object
        transform.rotation *= Quaternion.Euler(0, 0, 7 * Time.deltaTime);
        //time scale of game plus physics and other ifxed  from rate updates
        Time.timeScale += Time.fixedDeltaTime * 0.01f;
        //movement and rotation of the camera on the horizonal y axis
        rb.velocity += transform.rotation * (Vector3.right * Input.GetAxisRaw("Horizontal") * 10f * Time.deltaTime);
        //movement and rotation of the camera on the vertically y axis
        rb.velocity += transform.rotation * (Vector3.up * Input.GetAxisRaw("Vertical") * 10f * Time.deltaTime);
        //keeping the camera positions inbound
         transform.position = new Vector3(Mathf.Clamp(transform.position.x, -30f, 30f),
             transform.position.y, Mathf.Clamp(transform.position.z, -30f, 30f));
        
    }
}
