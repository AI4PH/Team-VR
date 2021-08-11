using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class EndGoalScript : MonoBehaviour
{

    public GameObject player;
    [SerializeField] private GameObject EndGoal;

    // Start is called before the first frame update
    void Start()
    {
        isGoalReached();
        EndGoal.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        isGoalReached();
    }

    void isGoalReached(){
        float distFromGoal = Vector3.Distance(transform.position, player.transform.position);
        if (distFromGoal < 20.0) {
            Debug.Log(distFromGoal.ToString());
            Debug.Log("Goal Reached!!");
            EndGoal.SetActive(true);
            delay();
            EndGoal.SetActive(false);
        }
    }

    private async Task delay()
    {
        await Task.Delay(5000);
        EndGoal.SetActive(false);
    }
}
