using NodeCanvas.Framework;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class MoveAT : ActionTask {

		public BBParameter<Vector3> moveDirection;
		public BBParameter<float> moveSpeed;
		public BBParameter<float> turnSpeed;

		protected override void OnUpdate()
		{
			Vector3 normalizedDirection = new Vector3(moveDirection.value.x, 0, moveDirection.value.z).normalized;
			Quaternion desiredRotation = Quaternion.LookRotation(normalizedDirection);

			agent.transform.rotation = Quaternion.RotateTowards(agent.transform.rotation, desiredRotation, turnSpeed.value * Time.deltaTime);
			agent.transform.position += moveSpeed.value * Time.deltaTime * agent.transform.forward;

			moveDirection.value = Vector3.zero;
		}

	}
}
