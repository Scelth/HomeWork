#pragma once
#include "Constants.h"

namespace Doom2D
{
	struct GameText
	{
		sf::Font font;
		sf::Text scoreText;
		sf::Text inputHintText;
		sf::Text gameOverText;
		sf::Text totalScoreText;
	};

	void InitText(GameText& text);
}