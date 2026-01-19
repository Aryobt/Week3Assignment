using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions {

	public class ScanAT : ActionTask {

		public BBParameter<Transform> targetBBP;
		public BBParameter<bool> hasTargetBBP;
		public BBParameter<float> initialScanRadiousBBP;
		public BBParameter<float> currentScanRadiusBBP;

		public LayerMask targetLayerMask;
		public float scanDurationInSeconds;
		public Color scanColour;
		public int numberOfScanCirclePoints;

		private float currentScanDuration = 0f;


		protected override string OnInit() 
		{
			currentScanRadiusBBP.value = initialScanRadiousBBP.value;
			return null;
		}

		protected override void OnExecute()
		{
			currentScanDuration = 0f;
			//currentScanRadiusBB.value = initialScanRadiousBB.value;

		}

		protected override void OnUpdate()
		{
			DrawCircle(agent.transform.position, currentScanRadiusBBP.value,scanColour,numberOfScanCirclePoints);	

			currentScanDuration += Time.deltaTime;
			if (currentScanDuration > scanDurationInSeconds)
			{
				Collider[] colliders = Physics.OverlapSphere(agent.transform.position, currentScanRadiusBBP.value, targetLayerMask);
				foreach (Collider collider in colliders)
				{
					Blackboard bb = collider.GetComponentInParent<Blackboard>();
					float repairValue = bb.GetVariableValue<float>("repairValue");

					if (repairValue == 0f)
					{
                        targetBBP.value = bb.GetVariableValue<Transform>("workpad");
						hasTargetBBP.value = true;
				    }

				}
                EndAction(true);
            }
		}

		private void DrawCircle(Vector3 center, float radius, Color colour, int numberOfPoints)
		{
			Vector3 startPoint, endPoint;
			int anglePerPoint = 360 / numberOfPoints;
			for (int i = 1; i <= numberOfPoints; i++)
			{
				startPoint = new Vector3(Mathf.Cos(Mathf.Deg2Rad * anglePerPoint * (i-1)), 0, Mathf.Sin(Mathf.Deg2Rad * anglePerPoint * (i-1)));
				startPoint = center + startPoint * radius;
				endPoint = new Vector3(Mathf.Cos(Mathf.Deg2Rad * anglePerPoint * i), 0, Mathf.Sin(Mathf.Deg2Rad * anglePerPoint * i));
				endPoint = center + endPoint * radius;
				Debug.DrawLine(startPoint, endPoint, colour);
			}

			
		}

		protected override void OnStop() 
		{
			
		}

		protected override void OnPause() 
		{
			
		}
	}
}