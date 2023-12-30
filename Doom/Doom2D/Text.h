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
		sf::Text settingText;
		sf::Text youWinText;
		sf::Text recordText;
	};

	void InitText(GameText& text);
	void InitSettingsText(GameText& text);
}