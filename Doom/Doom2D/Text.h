#pragma once
#include "Constants.h"

namespace Doom2D
{
	struct Text
	{
		sf::Font font;
		sf::Text scoreText;
		sf::Text inputHintText;
		sf::Text gameOverText;
	};

	void InitText(Text& text);
}