namespace Sandbox.TimelessPlayerNS
{
	public partial class TimelessPlayer : Player
	{
		TimeSince timeSinceDropped;

		[Net]
		public float Armor { get; set; } = 0;

		[Net]
		public float MaxHealth { get; set; } = 100;

		public bool SupressPickupNotices { get; private set; }

		public int ComboKillCount { get; set; } = 0;
		public TimeSince TimeSinceLastKill { get; set; }

		public TimelessPlayer()
		{
		}

		public override void Respawn()
		{
			SetModel( "models/citizen/citizen.vmdl" );

			Controller = new WalkController
			{
				WalkSpeed = 270,
				SprintSpeed = 100,
				DefaultSpeed = 270,
				AirAcceleration = 10,

			};

			Animator = new StandardPlayerAnimator();

			CameraMode = new FirstPersonCamera();

			EnableAllCollisions = true;
			EnableDrawing = true;
			EnableHideInFirstPerson = true;
			EnableShadowInFirstPerson = true;

			SupressPickupNotices = true;



			SupressPickupNotices = false;
			Health = 100;
			Armor = 50;

			base.Respawn();
		}

		public override void OnKilled()
		{
			base.OnKilled();


			Controller = null;

			CameraMode = new SpectateRagdollCamera();

			EnableAllCollisions = false;
			EnableDrawing = false;
		}

		public override void StartTouch( Entity other )
		{
			if ( timeSinceDropped < 1 ) return;

			base.StartTouch( other );
		}

	}

}
