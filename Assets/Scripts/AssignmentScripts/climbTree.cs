using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;


namespace NodeCanvas.Tasks.Actions {

	public class climbTree : ActionTask {

        public BBParameter<Transform> topTree;
        public BBParameter<float> ClimbSpeed;
        public BBParameter<bool> reachedTop;
        public float stopDistance = 0.5f;

        protected override string OnInit() {
			return null;
		}

	
		protected override void OnExecute() {
			
		}

	
		protected override void OnUpdate() {
            float distance = Vector3.Distance(agent.transform.position, topTree.value.position);

            if (distance <= stopDistance)
            {
                reachedTop.value = true;
                EndAction(true);
                return;
            }
            Vector3 moveDirection = (topTree.value.position - agent.transform.position).normalized;
            agent.transform.position += moveDirection * ClimbSpeed.value * Time.deltaTime;
        }

		
		protected override void OnStop() {
			
		}

	
		protected override void OnPause() {
			
		}
	}
}