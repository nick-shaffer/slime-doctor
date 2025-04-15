using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class UI_Script : MonoBehaviour
{
    
    public Camera cam;
// pictures for the recipes.
    public GameObject pic1;
    public GameObject pic2;
    public GameObject pic3;
    public GameObject pic4;
    public GameObject pic5;
    public GameObject pic6;

// pictures for the ingredients. 

public GameObject i_pic1;
public GameObject i_pic2;
public GameObject i_pic3;
public GameObject i_pic4;

public GameObject i_pic5;

public GameObject i_pic6;








    public GameObject cauldron;

    //ingredients

    int r1 = 0;
    int r2 = 0;
    int r3 = 0;
    int r4 = 0;
    int r5 = 0;
    int r6 = 0;

   int recipe = 0;

   int potion = 0;

   int ingredient_list = 0;
    Material mat;
   
//// potion pictures
///
public GameObject potion_pic1;
public GameObject potion_pic2;

    void Start(){

       mat = cauldron.GetComponent<Renderer>().material;
    }


     void Update(){
        Cursor.lockState = CursorLockMode.Locked;        
        Cursor.visible = false;
        bool cauldron_active = false;
        
        RaycastHit hit;
        Vector3 screenCenter = new(Screen.width/2f, Screen.height/2f);    
        // a raycast sends a beam out of the camera to detect objects in the vicinity.
        Ray rayOrigin = cam.ScreenPointToRay(screenCenter);


        if (Input.GetMouseButtonDown(0))
        {
            // if it hits something
            if (Physics.Raycast(rayOrigin, out hit))
            {
                //this is the GameObject it hit

                GameObject gg = hit.transform.gameObject;

                

                if (gg.CompareTag("1"))
                {
              //      gg.gameObject.SetActive(false);
                    pic1.SetActive(true);
                    pic2.SetActive(false);
                    pic3.SetActive(false);
                    pic4.SetActive(false);
                    pic5.SetActive(false);
                    pic6.SetActive(false);

                   recipe = 1;
                   
                    
                }

                if (gg.CompareTag("2"))
                {
                   // gg.gameObject.SetActive(false);

                    pic2.SetActive(true);
                    pic1.SetActive(false);
                    pic3.SetActive(false);
                    pic4.SetActive(false);
                    pic5.SetActive(false);
                    pic6.SetActive(false);
                    recipe = 2;
                    
                }

                if (gg.CompareTag("3"))
                {
                  //  gg.gameObject.SetActive(false);
                    pic3.SetActive(true);
                    pic1.SetActive(false);
                    pic2.SetActive(false);
                    pic4.SetActive(false);
                    pic5.SetActive(false);
                    pic6.SetActive(false);
               
                    recipe = 3;
                }

                if (gg.CompareTag("4"))
                {
                 //   gg.gameObject.SetActive(false);
                    pic4.SetActive(true);
                    pic1.SetActive(false);
                    pic2.SetActive(false);
                    pic3.SetActive(false);
                    pic5.SetActive(false);
                    pic6.SetActive(false);
              
                    recipe = 4;
                }

                if (gg.CompareTag("5"))
                {
                //    gg.gameObject.SetActive(false);
                    pic5.SetActive(true);
                    pic1.SetActive(false);
                    pic2.SetActive(false);
                    pic3.SetActive(false);
                    pic4.SetActive(false);
                    pic6.SetActive(false);
                    r5++;
                  
                    recipe = 5;
                }
                if (gg.CompareTag("6"))
                {
              //      gg.gameObject.SetActive(false);
                    pic6.SetActive(true);
                    pic1.SetActive(false);
                    pic2.SetActive(false);
                    pic3.SetActive(false);
                    pic4.SetActive(false);
                    pic5.SetActive(false);

                  
                   recipe = 6;
                }
                // 

                if (gg.CompareTag("c1") && recipe == 1){

                    Debug.Log("Hit the thing");
                   gg.SetActive(false);
                   i_pic1.SetActive(true);
                   ingredient_list++;

                   

                }

               else  if (gg.CompareTag("c2") && recipe == 1){

                  gg.SetActive(false);
                i_pic2.SetActive(true);
                 ingredient_list++;

                }

                else  if (gg.CompareTag("c3") && recipe == 1){

                      gg.SetActive(false);
                      i_pic3.SetActive(true);
                       ingredient_list++;

                }

                else if (gg.CompareTag("c4") && recipe == 2){

                      gg.SetActive(false);
                      i_pic4.SetActive(true);
                       ingredient_list++;

                }

                else if (gg.CompareTag("c5") && recipe == 2){

                      gg.SetActive(false);
                      i_pic5.SetActive(true);
                       ingredient_list++;

                }

                else if (gg.CompareTag("c6") && recipe == 2){

                    gg.SetActive(false);
                      i_pic6.SetActive(true);
                       ingredient_list++;


                }
               

               if (gg.CompareTag("slime1") && potion == 1){

                    // cure the slime. 

                    potion = 0;
                    potion_pic1.SetActive(false);
                     Material slime1_mat = gg.GetComponent<Renderer>().material;
                    slime1_mat.color = Color.green;
                    Debug.Log("slime1 cured");


               }






                // cooking
                if (gg.CompareTag("cauldron"))
                {
                    cauldron_active = true;
                    mat.color = Color.blue;
                

                }
                else
                {

                    //deactivate the cauldron, set the recipe to 0;
                    cauldron_active = false;
                
                    mat.color = Color.white;

                }


            if(cauldron_active && ingredient_list > 2 && recipe ==1){
                
                 cauldron_active = false;
                 mat.color = Color.white;
                 potion_pic1.SetActive(true);
                 potion = 1;
                 ingredient_list = 0; 

                i_pic1.SetActive(false);
                i_pic2.SetActive(false);
                i_pic3.SetActive(false);

                pic1.SetActive(false);
                    


            }

                 if(cauldron_active && ingredient_list > 2 && recipe ==2){
                
                 cauldron_active = false;
                 mat.color = Color.white;
                 potion_pic2.SetActive(true);
                 ingredient_list = 0; 

                i_pic4.SetActive(false);
                i_pic5.SetActive(false);
                i_pic6.SetActive(false);

                pic2.SetActive(false);
                 }  





                
            }
        }
     } 
}
