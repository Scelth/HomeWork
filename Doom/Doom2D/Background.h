#pragma once
#include "Constants.h"

namespace Doom2D
{
	struct Game;

	struct Background
	{
		sf::Sprite backgroundSprite;
	};

	void InitBackground(Background& background, const Game& game);
}