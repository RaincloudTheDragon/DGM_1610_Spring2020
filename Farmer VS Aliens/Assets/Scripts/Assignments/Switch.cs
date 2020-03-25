using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public string favHero;
    public int smarts = 5;

    // Start is called before the first frame update
    void Start()
    {
        /*if(favHero == "Superman")
        {
            print("Wrong! He's old news");
        }
        else if(favHero == "Thor")
        {
            print("Correct!");
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        /*switch (favHero)
        {
            case "Superman":
                print("Wrong!");
                break;

            case "Thor":
                print("Correct!");
                break;
			default:
				print("what...?");
				break;
        }*/

        switch(smarts)
        {
            case 1:
                print("you're dumb!");
                break;
			case 2:
				print("you're not smart");
				break;
            case 5:
                print("you're smart!");
                break;
            default:
                print("Derp!");
                break;
        }
    }
}
