using Unity.VisualScripting;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    public float playerSpeed = 5;
    
        
  // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = new Vector3(0, -4, 0);
    }

    // Update is called once per frame
    void Update()
    { 
    

       if (Input.GetKey(KeyCode.D))
        {
          
            
          transform.Translate(Vector3.right * playerSpeed * Time.deltaTime);


        }
        if (Input.GetKey(KeyCode.A))
        {


            transform.Translate(Vector3.left * playerSpeed * Time.deltaTime);
        
        }

        
            
            
         if(transform.position.x <= -11)
        {


            transform.position = new Vector3(10.5f, transform.position.y, 0);

        }
           
        

       

       if(transform.position.x >= 11)
        {

            transform.position = new Vector3(-10.5f, transform.position.y, 0);
            


            
        }
        


    }

    



         

          
        
        
}








