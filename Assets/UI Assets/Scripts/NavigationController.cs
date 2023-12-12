using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavigationController : MonoBehaviour
{
    public void mainMenu()
    {
        Application.LoadLevel(0);
    }
    public void GoLevel1(){
        Application.LoadLevel(1);
    }
    
    public void GoLevel2_1(){
        Application.LoadLevel(2);
    }

    public void GoLevel2_2(){
        Application.LoadLevel(3);
    }

    /* public void GoLevel3(){
         application.loadLevel(4);
     }

     public void GoLevel4(){
         application.loadLevel(5);
     }
     */
    public void Quit()
    {
        Application.Quit();
    }
}
