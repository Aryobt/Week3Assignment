using UnityEngine;
using NodeCanvas.Framework;
using ParadoxNotion.Design;


namespace NodeCanvas.Tasks.Actions {

	public class FollowPlayer : ActionTask {

		public BBParameter<Transform> PlayerPosition;
		public float moveSpeed = 3f;
		public float rotateSpeed = 5f;
		public float stopDistance = 2f;

  
        public AudioSource audioSource;
        public float audioTriggerDistance = 8f;

        private bool audioPlayed = false;


        protected override void OnUpdate() {
			
			if (PlayerPosition.value == null)
			{
				EndAction(false);
				return;
			}

            float distance = Vector3.Distance(agent.transform.position, PlayerPosition.value.position);


            if (distance <= audioTriggerDistance && !audioPlayed)
            {
                if (audioSource != null)
                {
                    audioSource.Play();
                    audioPlayed = true;
                }
            }


            if (distance < stopDistance)
			{
				EndAction(true);
				return;
			}
            Vector3 direction = (PlayerPosition.value.position - agent.transform.position).normalized;

            Vector3 newDirection = Vector3.RotateTowards(agent.transform.forward,direction,rotateSpeed * Time.deltaTime, 0f );


			agent.transform.forward = newDirection;
            agent.transform.position += agent.transform.forward * moveSpeed * Time.deltaTime;


        }


    }
}