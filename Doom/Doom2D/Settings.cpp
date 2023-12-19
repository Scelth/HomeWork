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
				if (game.gameSettings.choiñe & (1 << 1))
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
				if (game.gameSettings.choiñe & (1 << 0))
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
				if (game.gameSettings.choiñe & (1 << 3))
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
				if (game.gameSettings.choiñe & (1 << 2))
				{
					game.sound.denySound.play();
				}

				else
				{
					gameSettings.choiñe |= 1 << 3;
					game.sound.settingsSound.play();
				}
			}

			else if (sf::Keyboard::isKeyPressed(sf::Keyboard::Num0))
			{
				if ((gameSettings.choiñe != 5 && gameSettings.choiñe != 6 && gameSettings.choiñe != 9 && gameSettings.choiñe != 10))
				{
					game.sound.denySound.play();
				}

				else if (gameSettings.choiñe == 0)
				{
					gameSettings.isSettingsChosen = false;
					window.close();
				}

				else
				{
					gameSettings.isSettingsChosen = false;
				}
			}
		}
	}
}