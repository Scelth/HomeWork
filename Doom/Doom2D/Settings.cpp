#include "Settings.h"
#include "Game.h"

namespace Doom2D
{
	void InitSettings(GameSettings& gameSettings, Game& game, sf::RenderWindow& window)
	{
		InitSettingsText(game.text);
		InitSettingsSound(game.sound);
		InitSettingsBackground(game.background);

		while (gameSettings.isSettingsChosen)
		{
			window.clear();
			window.draw(game.backgroundColor);
			window.draw(game.text.settingText);
			window.display();

			if (sf::Keyboard::isKeyPressed(sf::Keyboard::Num1))
			{
				if (gameSettings.choiñe & (1 << 1))
				{
					game.sound.denySound.play();
				}

				else 
				{
					gameSettings.choiñe |= 1 << 0;
					game.sound.settingsSound.play();
				}
			}

			else if (sf::Keyboard::isKeyPressed(sf::Keyboard::Num2))
			{
				if (gameSettings.choiñe & (1 << 0))
				{
					game.sound.denySound.play();
				}

				else
				{
					gameSettings.choiñe |= 1 << 1;
					game.sound.settingsSound.play();
				}
			}

			else if (sf::Keyboard::isKeyPressed(sf::Keyboard::Num3))
			{
				if (gameSettings.choiñe & (1 << 3))
				{
					game.sound.denySound.play();
				}

				else
				{
					gameSettings.choiñe |= 1 << 2;
					game.sound.settingsSound.play();
				}
			}

			else if (sf::Keyboard::isKeyPressed(sf::Keyboard::Num4))
			{
				if (gameSettings.choiñe & (1 << 2))
				{
					game.sound.denySound.play();
				}

				else
				{
					gameSettings.choiñe |= 1 << 3;
					game.sound.settingsSound.play();
				}
			}

			else if (sf::Keyboard::isKeyPressed(sf::Keyboard::Num5))
			{
				gameSettings.choiñe |= 1 << 4;
				game.sound.settingsSound.play();
			}

			else if (sf::Keyboard::isKeyPressed(sf::Keyboard::Num0))
			{
				if (gameSettings.choiñe != 5 && 
					gameSettings.choiñe != 6 && 
					gameSettings.choiñe != 9 && 
					gameSettings.choiñe != 10 &&
					gameSettings.choiñe != 21 &&
					gameSettings.choiñe != 22 &&
					gameSettings.choiñe != 25 &&
					gameSettings.choiñe != 26)
				{
					game.sound.denySound.play();
				}

				else
				{
					if (gameSettings.choiñe & (1 << 4))
					{
						GenerateRecordTable(game.gameScore, game);
					}

					gameSettings.isSettingsChosen = false;
				}
			}

			else
			{
				HandleWindowEvents(game, window);
			}
		}
	}
}