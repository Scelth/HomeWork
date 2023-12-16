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
				gameSettings.choiñe |= 1 << 0;
				game.sound.settingsSound.play();
			}

			else if (sf::Keyboard::isKeyPressed(sf::Keyboard::Num2))
			{
				gameSettings.choiñe |= 1 << 1;
				game.sound.settingsSound.play();
			}

			else if (sf::Keyboard::isKeyPressed(sf::Keyboard::Num3))
			{
				gameSettings.choiñe |= 1 << 2;
				game.sound.settingsSound.play();
			}

			else if (sf::Keyboard::isKeyPressed(sf::Keyboard::Num4))
			{
				gameSettings.choiñe |= 1 << 3;
				game.sound.settingsSound.play();
			}

			else if (sf::Keyboard::isKeyPressed(sf::Keyboard::Num0))
			{
				if (gameSettings.choiñe == 1 || gameSettings.choiñe == 2 || gameSettings.choiñe == 4 || gameSettings.choiñe == 8)
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