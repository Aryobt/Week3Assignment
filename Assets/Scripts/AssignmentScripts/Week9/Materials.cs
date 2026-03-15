using NodeCanvas.Framework;
using UnityEngine;

public class Materials : MonoBehaviour
{
    public Blackboard blackboard;
    public float materialGain = 100f;
    public GameObject materialBox;

   private void Start()
    {
        blackboard.SetVariableValue ("Material", 0f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == materialBox)
        {
            float current = blackboard.GetVariableValue<float>("Material");
            float newAmount = current + materialGain;

            blackboard.SetVariableValue("Material", newAmount);


        }
    }


}
