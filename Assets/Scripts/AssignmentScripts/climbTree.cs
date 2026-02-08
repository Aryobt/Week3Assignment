using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;


namespace NodeCanvas.Tasks.Actions {

	public class climbTree : ActionTask {

        public BBParameter<Transform> topTree;
        public BBParameter<float> ClimbSpeed;
     
        protected override string OnInit() {
			return null;
		}

	
		protected override void OnExecute() {
			
		}

	
		protected override void OnUpdate() {
            Vector3 moveDirection = (topTree.value.position - agent.transform.position).normalized;
            agent.transform.position += moveDirection * ClimbSpeed.value * Time.deltaTime;
        }

		
		protected override void OnStop() {
			
		}

	
		protected override void OnPause() {
			
		}
	}
}