using Sandbox.UI;

namespace Sandbox
{
	public class HUD : HudEntity<RootPanel>
	{
		public HUD()
		{
			if ( !IsClient ) return;

			RootPanel.StyleSheet.Load( "Resources/styles/HUD.scss" );

			RootPanel.AddChild<Health>();
		}
	}
}
