using NodeCanvas.Framework;
using ParadoxNotion.Design;
using System;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions{

	public class AwaitActionTask : ActionTask{
		public float maxWaitTime;
		public float minWaitTime;
		public BBParameter<Vector3> startingPosition;

		private float totalTimeToWait;
		private float timeWaiting = 0f;


		protected override string OnInit(){
            startingPosition.value = agent.transform.position;
            return null;
		}

		//protected override void OnExecute(){
		//	timeWaiting = 0f;
		//totalTimeToWait = UnityEngine.Random.Range(minWaitTime, maxWaitTime);
			
		//}

		//protected override void OnUpdate(){
		
		//	timeWaiting += Time.deltaTime;
		//	if(timeWaiting > totalTimeToWait)
		//	{
		//		EndAction(true);
		//	}
  //      }

		}
	}
