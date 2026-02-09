using NodeCanvas.Framework;
using ParadoxNotion.Design;
using Unity.VisualScripting;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class ThrowBanana : ActionTask {

        public BBParameter<Transform> Banana;
        public BBParameter<bool> throwBanana;
        public BBParameter<float> throwForce = 5f;

        private float timer ;



        protected override void OnExecute () {
            timer = 0f;

        }



        protected override void OnUpdate() {
            timer += Time.deltaTime;
         

        }

    }
}