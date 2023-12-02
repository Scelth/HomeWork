#include "Text.h"

namespace Doom2D
{
	void InitText(Text& text)
	{
		// Font
		text.font.loadFromFile(RESOURCES_PATH + "Fonts/Linepixels.ttf");

		// Text
		text.scoreText.setFont(text.font);
		text.scoreText.setCharacterSize(24);
		text.scoreText.setFillColor(sf::Color::Yellow);
		text.scoreText.setPosition(10.f, 10.f);

		text.inputHintText.setFont(text.font);
		text.inputHintText.setCharacterSize(24);
		text.inputHintText.setFillColor(sf::Color::Red);
		text.inputHintText.setString("Use WASD keys to move, ESC to exit");

		text.gameOverText.setFont(text.font);
		text.gameOverText.setCharacterSize(50);
		text.gameOverText.setFillColor(sf::Color::White);
		text.gameOverText.setString("GAME OVER");
		text.gameOverText.setPosition(SCREEN_WIDTH / 2.5f, SCREEN_HEIGTH / 2.5f);
	}
}