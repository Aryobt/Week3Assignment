using UnityEngine;
using NodeCanvas.Framework;

public class FindPlayer : MonoBehaviour
{
    public Blackboard bb;
    public Transform player;
    public Transform guard;

    void Update()
    {
        float dist = Vector3.Distance(guard.position, player.position);
        bb.SetVariableValue("playerposition",dist);
    }
}
