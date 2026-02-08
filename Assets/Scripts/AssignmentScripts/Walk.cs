using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class Walk : ActionTask {

		public BBParameter<Transform> target;
        public BBParameter <float> speed;
        public BBParameter<bool> reachedTree;
        public float stopDistance = 0.5f;




        protected override string OnInit() {
			return null;
		}

		protected override void OnExecute() {
	
        }

		protected override void OnUpdate() {
            float distance = Vector3.Distance(agent.transform.position, target.value.position);

            if (distance <= stopDistance)
            {
                reachedTree.value = true;   
                EndAction(true);            
                return;
            }

            Vector3 moveDirection = (target.value.position-agent.transform.position).normalized;
			agent.transform.position += moveDirection * speed.value * Time.deltaTime;
			

        }

        protected override void OnStop() {
			
		}

		protected override void OnPause() {
			
		}
	}
}