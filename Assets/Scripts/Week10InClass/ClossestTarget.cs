using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class ClossestTarget : ActionTask {

		public BBParameter<Collider[]> nearbyTargets;
		public BBParameter<Transform> target;
		protected override void OnExecute() {

			Transform closestTarget = null;
			float distanceToBeat = float.MaxValue;

			foreach (Collider collider in nearbyTargets.value)
			{
				float distanceToTarget = Vector3.Distance(agent.transform.position, collider.transform.position);

                if (distanceToTarget < distanceToBeat)
                {
					distanceToBeat = distanceToTarget;
						closestTarget = collider.transform;
                }
            }
			target.value = closestTarget;
			EndAction(true);
		}


	}
}