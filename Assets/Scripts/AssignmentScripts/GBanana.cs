using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;


namespace NodeCanvas.Tasks.Actions {

	public class GBanana : ActionTask {

		public BBParameter<Transform> Banana;
        public BBParameter<float> speed;
        public BBParameter<bool> reachBanana;
        public float DistanceGrabBanana = 0.5f;

        protected override string OnInit() {
			return null;
		}

	

		protected override void OnExecute() {
		
		}

		protected override void OnUpdate() {
            float distance = Vector3.Distance(agent.transform.position, Banana.value.position);

            if (distance <= DistanceGrabBanana)
            {
                reachBanana.value = true;
                EndAction(true);
                return;
            }

            Vector3 moveDirection = (Banana.value.position - agent.transform.position).normalized;
            agent.transform.position += moveDirection * speed.value * Time.deltaTime;
        }


		protected override void OnStop() {
			
		}

		protected override void OnPause() {
			
		}
	}
}