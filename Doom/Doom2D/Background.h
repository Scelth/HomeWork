#pragma once
#include "Constants.h"

namespace Doom2D
{
	struct Background
	{
		sf::Sprite backgroundSprite;
	};

	struct Game;

	void InitBackground(Background& background, const Game& game);
}