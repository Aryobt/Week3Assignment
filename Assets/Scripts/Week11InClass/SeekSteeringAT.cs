using NodeCanvas.Framework;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class SeekSteeringAT : ActionTask {

		public BBParameter<Transform> seekTarget;
		public BBParameter<Vector3> moveDirection;
		public float weight;

		//Called once per frame while the action is active.
		protected override void OnUpdate() {
			moveDirection.value += (seekTarget.value.position - agent.transform.position).normalized * weight;
		}

	}
}