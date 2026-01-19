using NodeCanvas.Framework;
using ParadoxNotion.Design;


namespace NodeCanvas.Tasks.Actions {
	public class BoostAT : ActionTask {

		public BBParameter<float> currentScanRadiousBBP;
        public float boostValue = 5f;

		protected override void OnExecute()
		{
			currentScanRadiousBBP.value += boostValue;
			EndAction(true);
		}

		
	}
}