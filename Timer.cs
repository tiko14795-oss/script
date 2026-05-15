using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public int minuts;
    public float secund;



    void Update()
    {

        secund -= Time.deltaTime;

        if (secund <= 0)
        {
            

            if (minuts > 0)
            {

            minuts--;
            secund += 59;


            }
            else
            {
                
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(sceneIndex);

            }



        }
        

    }
}
