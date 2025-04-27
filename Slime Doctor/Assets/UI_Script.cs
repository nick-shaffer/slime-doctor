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
    public GameObject pic7;
    public GameObject pic8;
    public GameObject pic9;
    public GameObject pic10;
    // pictures for the ingredients. 

public GameObject i_pic1;
public GameObject i_pic2;
public GameObject i_pic3;
public GameObject i_pic4;
public GameObject i_pic5;
public GameObject i_pic6;
public GameObject i_pic7;
public GameObject i_pic8;
public GameObject i_pic9;
public GameObject i_pic10;
public GameObject i_pic11;
public GameObject i_pic12;
public GameObject i_pic13;
public GameObject i_pic14;
public GameObject i_pic15;
public GameObject i_pic16;
public GameObject i_pic17;
public GameObject i_pic18;
public GameObject i_pic19;
public GameObject i_pic20;
public GameObject i_pic21;
public GameObject i_pic22;
public GameObject i_pic23;
public GameObject i_pic24;
public GameObject i_pic25;
public GameObject i_pic26;
public GameObject i_pic27;
public GameObject i_pic28;
public GameObject i_pic29;
public GameObject i_pic30;


    public GameObject cauldron;

    //game objects that will be changed when curing the slimes :)

    public GameObject leftvampireteeth;
    public GameObject leftvampireteethblood;
    public GameObject rightvampireteeth;
    public GameObject rightvampireteethblood;

    public GameObject feverlight;

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
public GameObject potion_pic3;
public GameObject potion_pic4;
public GameObject potion_pic5;
public GameObject potion_pic6;
public GameObject potion_pic7;
public GameObject potion_pic8;
public GameObject potion_pic9;
public GameObject potion_pic10;

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
                    pic1.SetActive(true);
                    pic2.SetActive(false);
                    pic3.SetActive(false);
                    pic4.SetActive(false);
                    pic5.SetActive(false);
                    pic6.SetActive(false);
                    pic7.SetActive(false);
                    pic8.SetActive(false);
                    pic9.SetActive(false);
                    pic10.SetActive(false);
                    recipe = 1;
                }

                if (gg.CompareTag("2"))
                {
                    pic1.SetActive(false);
                    pic2.SetActive(true);
                    pic3.SetActive(false);
                    pic4.SetActive(false);
                    pic5.SetActive(false);
                    pic6.SetActive(false);
                    pic7.SetActive(false);
                    pic8.SetActive(false);
                    pic9.SetActive(false);
                    pic10.SetActive(false);
                    recipe = 2;
                }

                if (gg.CompareTag("3"))
                {
                    pic1.SetActive(false);
                    pic2.SetActive(false);
                    pic3.SetActive(true);
                    pic4.SetActive(false);
                    pic5.SetActive(false);
                    pic6.SetActive(false);
                    pic7.SetActive(false);
                    pic8.SetActive(false);
                    pic9.SetActive(false);
                    pic10.SetActive(false);
                    recipe = 3;
                }

                if (gg.CompareTag("4"))
                {
                    pic1.SetActive(false);
                    pic2.SetActive(false);
                    pic3.SetActive(false);
                    pic4.SetActive(true);
                    pic5.SetActive(false);
                    pic6.SetActive(false);
                    pic7.SetActive(false);
                    pic8.SetActive(false);
                    pic9.SetActive(false);
                    pic10.SetActive(false);
                    recipe = 4;
                }

                if (gg.CompareTag("5"))
                {
                    pic1.SetActive(false);
                    pic2.SetActive(false);
                    pic3.SetActive(false);
                    pic4.SetActive(false);
                    pic5.SetActive(true);
                    pic6.SetActive(false);
                    pic7.SetActive(false);
                    pic8.SetActive(false);
                    pic9.SetActive(false);
                    pic10.SetActive(false);
                    recipe = 5;
                }

                if (gg.CompareTag("6"))
                {
                    pic1.SetActive(false);
                    pic2.SetActive(false);
                    pic3.SetActive(false);
                    pic4.SetActive(false);
                    pic5.SetActive(false);
                    pic6.SetActive(true);
                    pic7.SetActive(false);
                    pic8.SetActive(false);
                    pic9.SetActive(false);
                    pic10.SetActive(false);
                    recipe = 6;
                }

                if (gg.CompareTag("7"))
                {
                    pic1.SetActive(false);
                    pic2.SetActive(false);
                    pic3.SetActive(false);
                    pic4.SetActive(false);
                    pic5.SetActive(false);
                    pic6.SetActive(false);
                    pic7.SetActive(true);
                    pic8.SetActive(false);
                    pic9.SetActive(false);
                    pic10.SetActive(false);
                    recipe = 7;
                }

                if (gg.CompareTag("8"))
                {
                    pic1.SetActive(false);
                    pic2.SetActive(false);
                    pic3.SetActive(false);
                    pic4.SetActive(false);
                    pic5.SetActive(false);
                    pic6.SetActive(false);
                    pic7.SetActive(false);
                    pic8.SetActive(true);
                    pic9.SetActive(false);
                    pic10.SetActive(false);
                    recipe = 8;
                }

                if (gg.CompareTag("9"))
                {
                    pic1.SetActive(false);
                    pic2.SetActive(false);
                    pic3.SetActive(false);
                    pic4.SetActive(false);
                    pic5.SetActive(false);
                    pic6.SetActive(false);
                    pic7.SetActive(false);
                    pic8.SetActive(false);
                    pic9.SetActive(true);
                    pic10.SetActive(false);
                    recipe = 9;
                }

                if (gg.CompareTag("10"))
                {
                    pic1.SetActive(false);
                    pic2.SetActive(false);
                    pic3.SetActive(false);
                    pic4.SetActive(false);
                    pic5.SetActive(false);
                    pic6.SetActive(false);
                    pic7.SetActive(false);
                    pic8.SetActive(false);
                    pic9.SetActive(false);
                    pic10.SetActive(true);
                    recipe = 10;
                }



                // 
                if (gg.CompareTag("c1") && recipe == 1)
                {
                    gg.SetActive(false);
                    i_pic1.SetActive(true);
                    ingredient_list++;
                }
                else if (gg.CompareTag("c2") && recipe == 1)
                {
                    gg.SetActive(false);
                    i_pic2.SetActive(true);
                    ingredient_list++;
                }
                else if (gg.CompareTag("c3") && recipe == 1)
                {
                    gg.SetActive(false);
                    i_pic3.SetActive(true);
                    ingredient_list++;
                }
                else if (gg.CompareTag("c4") && recipe == 2)
                {
                    gg.SetActive(false);
                    i_pic4.SetActive(true);
                    ingredient_list++;
                }
                else if (gg.CompareTag("c5") && recipe == 2)
                {
                    gg.SetActive(false);
                    i_pic5.SetActive(true);
                    ingredient_list++;
                }
                else if (gg.CompareTag("c6") && recipe == 2)
                {
                    gg.SetActive(false);
                    i_pic6.SetActive(true);
                    ingredient_list++;
                }
                else if (gg.CompareTag("c7") && recipe == 3)
                {
                    gg.SetActive(false);
                    i_pic7.SetActive(true);
                    ingredient_list++;
                }
                else if (gg.CompareTag("c8") && recipe == 3)
                {
                    gg.SetActive(false);
                    i_pic8.SetActive(true);
                    ingredient_list++;
                }
                else if (gg.CompareTag("c9") && recipe == 3)
                {
                    gg.SetActive(false);
                    i_pic9.SetActive(true);
                    ingredient_list++;
                }
                else if (gg.CompareTag("c10") && recipe == 4)
                {
                    gg.SetActive(false);
                    i_pic10.SetActive(true);
                    ingredient_list++;
                }
                else if (gg.CompareTag("c11") && recipe == 4)
                {
                    gg.SetActive(false);
                    i_pic11.SetActive(true);
                    ingredient_list++;
                }
                else if (gg.CompareTag("c12") && recipe == 4)
                {
                    gg.SetActive(false);
                    i_pic12.SetActive(true);
                    ingredient_list++;
                }
                else if (gg.CompareTag("c13") && recipe == 5)
                {
                    gg.SetActive(false);
                    i_pic13.SetActive(true);
                    ingredient_list++;
                }
                else if (gg.CompareTag("c14") && recipe == 5)
                {
                    gg.SetActive(false);
                    i_pic14.SetActive(true);
                    ingredient_list++;
                }
                else if (gg.CompareTag("c15") && recipe == 5)
                {
                    gg.SetActive(false);
                    i_pic15.SetActive(true);
                    ingredient_list++;
                }
                else if (gg.CompareTag("c16") && recipe == 6)
                {
                    gg.SetActive(false);
                    i_pic16.SetActive(true);
                    ingredient_list++;
                }
                else if (gg.CompareTag("c17") && recipe == 6)
                {
                    gg.SetActive(false);
                    i_pic17.SetActive(true);
                    ingredient_list++;
                }
                else if (gg.CompareTag("c18") && recipe == 6)
                {
                    gg.SetActive(false);
                    i_pic18.SetActive(true);
                    ingredient_list++;
                }
                else if (gg.CompareTag("c19") && recipe == 7)
                {
                    gg.SetActive(false);
                    i_pic19.SetActive(true);
                    ingredient_list++;
                }
                else if (gg.CompareTag("c20") && recipe == 7)
                {
                    gg.SetActive(false);
                    i_pic20.SetActive(true);
                    ingredient_list++;
                }
                else if (gg.CompareTag("c21") && recipe == 7)
                {
                    gg.SetActive(false);
                    i_pic21.SetActive(true);
                    ingredient_list++;
                }
                else if (gg.CompareTag("c22") && recipe == 8)
                {
                    gg.SetActive(false);
                    i_pic22.SetActive(true);
                    ingredient_list++;
                }
                else if (gg.CompareTag("c23") && recipe == 8)
                {
                    gg.SetActive(false);
                    i_pic23.SetActive(true);
                    ingredient_list++;
                }
                else if (gg.CompareTag("c24") && recipe == 8)
                {
                    gg.SetActive(false);
                    i_pic24.SetActive(true);
                    ingredient_list++;
                }
                else if (gg.CompareTag("c25") && recipe == 9)
                {
                    gg.SetActive(false);
                    i_pic25.SetActive(true);
                    ingredient_list++;
                }
                else if (gg.CompareTag("c26") && recipe == 9)
                {
                    gg.SetActive(false);
                    i_pic26.SetActive(true);
                    ingredient_list++;
                }
                else if (gg.CompareTag("c27") && recipe == 9)
                {
                    gg.SetActive(false);
                    i_pic27.SetActive(true);
                    ingredient_list++;
                }
                else if (gg.CompareTag("c28") && recipe == 10)
                {
                    gg.SetActive(false);
                    i_pic28.SetActive(true);
                    ingredient_list++;
                }
                else if (gg.CompareTag("c29") && recipe == 10)
                {
                    gg.SetActive(false);
                    i_pic29.SetActive(true);
                    ingredient_list++;
                }
                else if (gg.CompareTag("c30") && recipe == 10)
                {
                    gg.SetActive(false);
                    i_pic30.SetActive(true);
                    ingredient_list++;
                }



                if (gg.CompareTag("slime1") && potion == 1)
                {
                    potion = 0;
                    potion_pic1.SetActive(false);
                    leftvampireteeth.SetActive(false);
                    rightvampireteeth.SetActive(false);
                    leftvampireteethblood.SetActive(false);
                    rightvampireteethblood.SetActive(false);

                    Debug.Log("slime1 cured");
                }

                if (gg.CompareTag("slime2") && potion == 2)
                {
                    potion = 0;
                    potion_pic2.SetActive(false);
                    Material slime2_mat = gg.GetComponent<Renderer>().material;
                    slime2_mat.color = Color.green;
                    Debug.Log("slime2 cured");
                }

                if (gg.CompareTag("slime3") && potion == 3)
                {
                    potion = 0;
                    potion_pic3.SetActive(false);
                    Material slime3_mat = gg.GetComponent<Renderer>().material;
                    slime3_mat.color = Color.green;
                    Debug.Log("slime3 cured");
                }

                if (gg.CompareTag("slime4") && potion == 4)
                {
                    potion = 0;
                    potion_pic4.SetActive(false);
                    Material slime4_mat = gg.GetComponent<Renderer>().material;
                    slime4_mat.color = Color.green;
                    Debug.Log("slime4 cured");
                }

                if (gg.CompareTag("slime5") && potion == 5)
                {
                    potion = 0;
                    potion_pic5.SetActive(false);
                    Material slime5_mat = gg.GetComponent<Renderer>().material;
                    slime5_mat.color = Color.green;
                    Debug.Log("slime5 cured");
                }

                if (gg.CompareTag("slime6") && potion == 6)
                {
                    potion = 0;
                    potion_pic6.SetActive(false);
                    Material slime6_mat = gg.GetComponent<Renderer>().material;
                    slime6_mat.color = Color.green;
                    Debug.Log("slime6 cured");
                }

                if (gg.CompareTag("slime7") && potion == 7)
                {
                    potion = 0;
                    potion_pic7.SetActive(false);
                    feverlight.SetActive(false);
                    Debug.Log("slime7 cured");
                }

                if (gg.CompareTag("slime8") && potion == 8)
                {
                    potion = 0;
                    potion_pic8.SetActive(false);
                    Material slime8_mat = gg.GetComponent<Renderer>().material;
                    slime8_mat.color = Color.green;
                    Debug.Log("slime8 cured");
                }

                if (gg.CompareTag("slime9") && potion == 9)
                {
                    potion = 0;
                    potion_pic9.SetActive(false);
                    Material slime9_mat = gg.GetComponent<Renderer>().material;
                    slime9_mat.color = Color.green;
                    Debug.Log("slime9 cured");
                }

                if (gg.CompareTag("slime10") && potion == 10)
                {
                    potion = 0;
                    potion_pic10.SetActive(false);
                    Material slime10_mat = gg.GetComponent<Renderer>().material;
                    slime10_mat.color = Color.green;
                    Debug.Log("slime10 cured");
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


                if (cauldron_active && ingredient_list > 2 && recipe == 1)
                {
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

                if (cauldron_active && ingredient_list > 2 && recipe == 2)
                {
                    cauldron_active = false;
                    mat.color = Color.white;
                    potion_pic2.SetActive(true);
                    potion = 2;
                    ingredient_list = 0;

                    i_pic4.SetActive(false);
                    i_pic5.SetActive(false);
                    i_pic6.SetActive(false);

                    pic2.SetActive(false);
                }

                if (cauldron_active && ingredient_list > 2 && recipe == 3)
                {
                    cauldron_active = false;
                    mat.color = Color.white;
                    potion_pic3.SetActive(true);
                    potion = 3;
                    ingredient_list = 0;

                    i_pic7.SetActive(false);
                    i_pic8.SetActive(false);
                    i_pic9.SetActive(false);

                    pic3.SetActive(false);
                }

                if (cauldron_active && ingredient_list > 2 && recipe == 4)
                {
                    cauldron_active = false;
                    mat.color = Color.white;
                    potion_pic4.SetActive(true);
                    potion = 4;
                    ingredient_list = 0;

                    i_pic10.SetActive(false);
                    i_pic11.SetActive(false);
                    i_pic12.SetActive(false);

                    pic4.SetActive(false);
                }

                if (cauldron_active && ingredient_list > 2 && recipe == 5)
                {
                    cauldron_active = false;
                    mat.color = Color.white;
                    potion_pic5.SetActive(true);
                    potion = 5;
                    ingredient_list = 0;

                    i_pic13.SetActive(false);
                    i_pic14.SetActive(false);
                    i_pic15.SetActive(false);

                    pic5.SetActive(false);
                }

                if (cauldron_active && ingredient_list > 2 && recipe == 6)
                {
                    cauldron_active = false;
                    mat.color = Color.white;
                    potion_pic6.SetActive(true);
                    potion = 6;
                    ingredient_list = 0;

                    i_pic16.SetActive(false);
                    i_pic17.SetActive(false);
                    i_pic18.SetActive(false);

                    pic6.SetActive(false);
                }

                if (cauldron_active && ingredient_list > 2 && recipe == 7)
                {
                    cauldron_active = false;
                    mat.color = Color.white;
                    potion_pic7.SetActive(true);
                    potion = 7;
                    ingredient_list = 0;

                    i_pic19.SetActive(false);
                    i_pic20.SetActive(false);
                    i_pic21.SetActive(false);

                    pic7.SetActive(false);
                }

                if (cauldron_active && ingredient_list > 2 && recipe == 8)
                {
                    cauldron_active = false;
                    mat.color = Color.white;
                    potion_pic8.SetActive(true);
                    potion = 8;
                    ingredient_list = 0;

                    i_pic22.SetActive(false);
                    i_pic23.SetActive(false);
                    i_pic24.SetActive(false);

                    pic8.SetActive(false);
                }

                if (cauldron_active && ingredient_list > 2 && recipe == 9)
                {
                    cauldron_active = false;
                    mat.color = Color.white;
                    potion_pic9.SetActive(true);
                    potion = 9;
                    ingredient_list = 0;

                    i_pic25.SetActive(false);
                    i_pic26.SetActive(false);
                    i_pic27.SetActive(false);

                    pic9.SetActive(false);
                }

                if (cauldron_active && ingredient_list > 2 && recipe == 10)
                {
                    cauldron_active = false;
                    mat.color = Color.white;
                    potion_pic10.SetActive(true);
                    potion = 10;
                    ingredient_list = 0;

                    i_pic28.SetActive(false);
                    i_pic29.SetActive(false);
                    i_pic30.SetActive(false);

                    pic10.SetActive(false);
                }







            }
        }
     } 
}
