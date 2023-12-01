#include "Background.h"
#include "Game.h"

namespace Doom2D
{
	void InitBackground(Background& background, const Game& game)
	{
		background.backgroundSprite.setTexture(game.backgroundTexture);
	}
}