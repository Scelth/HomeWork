#include "Text.h"

namespace Doom2D
{
	void InitText(GameText& text)
	{
		text.scoreText.setFont(text.font);
		text.scoreText.setCharacterSize(24);
		text.scoreText.setFillColor(sf::Color::Yellow);
		text.scoreText.setPosition(10.f, 10.f);

		text.totalScoreText.setFont(text.font);
		text.totalScoreText.setCharacterSize(30);
		text.totalScoreText.setFillColor(sf::Color::White);
		text.totalScoreText.setPosition(SCREEN_WIDTH / 2.5f, SCREEN_HEIGTH / 2.f);

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