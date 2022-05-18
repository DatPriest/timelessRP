using Sandbox.UI.Construct;

namespace Sandbox.UI
{
	public class Money : Label
	{
		public IconPanel Icon;
		public Label Label;

		public Money()
		{
			Icon = Add.Icon( "💎", "icon icon-money" );
			Label = Add.Label( "0", "money" );

			Label.Style.Dirty();
		}

		public override void Tick()
		{
			var player = Local.Pawn;
			if ( player == null ) return;

			Label.Text = $"{player.Health*5:n0}";
		}
	}
}
