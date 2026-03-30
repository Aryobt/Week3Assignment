using NodeCanvas.Framework;
using Unity.VisualScripting;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class AvoidSteering : ActionTask {

		public BBParameter<Vector3> moveDirection;
		public LayerMask avoidLayers;
		public float closeRadius, nearRadius, farRadius;
		public float closeWeight, nearWeight, farWeight;

		protected override void OnUpdate() {
			moveDirection.value += CaculateAvoidVector();
		}

		private Vector3 CaculateAvoidVector()
		{
			Collider[] detectedColliders = Physics.OverlapSphere(agent.transform.position, farRadius, avoidLayers);

			Vector3 avoidDirection = Vector3.zero;


			foreach (Collider collider in detectedColliders)
			{
				float weight = 0f;
				float distanceToCollider = Vector3.Distance(agent.transform.position, collider.transform.position);

				if (distanceToCollider < closeRadius)
				{
					weight = closeWeight;
				}
				else if (distanceToCollider < nearRadius)
				{
					weight = nearWeight;
				}
				else
				{
					weight = farWeight;
				}

				Vector3 direction = (agent.transform.position - collider.transform.position).normalized;
				avoidDirection += direction * weight;
			}
			return avoidDirection;
		}
	}
}