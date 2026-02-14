using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class Walk : ActionTask {

		public BBParameter<Transform> target;
        public BBParameter <float> speed;
        public BBParameter<bool> reachedTree;
        public float stopDistance = 0.5f;

        public AudioClip walkingSound;
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
            if (audioSource != null && walkingSound != null)
            {
                audioSource.clip = walkingSound;
                audioSource.loop = true;
                audioSource.Play();
            }


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

        protected override void OnStop()
        {
            if (audioSource != null)
            {
                audioSource.Stop();

            }
        }

        protected override void OnPause() {
			
		}
	}
}