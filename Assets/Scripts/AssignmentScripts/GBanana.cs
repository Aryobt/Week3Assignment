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

        public AudioClip MonkeySound;
        private AudioSource audioSource;

        protected override string OnInit() {

            audioSource = agent.GetComponent<AudioSource>();

            if (audioSource == null)
            {
                Debug.LogWarning("Walk Action: No AudioSource found on agent.");
            }

            return null;
		}

	

		protected override void OnExecute() {
            if (audioSource != null && MonkeySound != null)
            {
                audioSource.clip = MonkeySound;
                audioSource.loop = true;
                audioSource.Play();
            }
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
            if (audioSource != null)
            {
                audioSource.Stop();

            }
        }

		protected override void OnPause() {
			
		}
	}
}