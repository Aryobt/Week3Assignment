using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class ScanTarget : ActionTask {

		public BBParameter<Collider[]> nearbyTargets;
		public BBParameter<float> scanRadius;
		public BBParameter<LayerMask> layerMask;

   //     protected override bool OnCheck()
   //     {
   //         nearbyTargets.value = Physics.OverlapSphere(agent.transform.position, scanRadius.value, layerMask.value);

			//if (nearbyTargets.value.Length > 0f)
			//{
			//	return true;
			//}
			//else
			//{
			//	return false;
			//}
   //     }

	}
}