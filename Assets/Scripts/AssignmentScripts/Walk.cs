using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class Walk : ActionTask {

        public float speed = 2f;

        protected override string OnInit() {
			return null;
		}

		protected override void OnExecute() {
			
		}

		protected override void OnUpdate() {

            agent.transform.Translate(Vector3.forward * speed * Time.deltaTime);


        }

        protected override void OnStop() {
			
		}

		protected override void OnPause() {
			
		}
	}
}