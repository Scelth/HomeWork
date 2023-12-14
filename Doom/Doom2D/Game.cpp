#include "Game.h"

namespace Doom2D
{
	// Function to restart the game
	void RestartGame(Game& game)
	{
		InitBackground(game.background, game);
		InitPlayer(game.player, game);

		for (int i = 0; i < NUM_ENEMIES; i++)
		{
			SetEnemyPosition(game.enemy[i], GetRandomPosition(SCREEN_WIDTH, SCREEN_HEIGTH));
		}

		for (int i = 0; i < NUM_OBSTACLES; i++)
		{
			SetObstaclePosition(game.obstacle[i], GetRandomPosition(SCREEN_WIDTH, SCREEN_HEIGTH));
		}

		InitText(game.text);
		InitSound(game.sound);

		game.numKilledEnemies = 0;
		game.isGameFinished = false;
		game.gameFinishTime = 0;
	}

	void InitGame(Game& game)
	{
		// Textures
		game.backgroundTexture.loadFromFile(RESOURCES_PATH + "Assets/Hell.png");
		game.playerTexture.loadFromFile(RESOURCES_PATH + "Assets/Doom.png");
		game.enemyTexture.loadFromFile(RESOURCES_PATH + "Assets/Enemy.png");
		game.obstacleTexture.loadFromFile(RESOURCES_PATH + "Assets/Fire.png");

		// Font
		game.text.font.loadFromFile(RESOURCES_PATH + "Fonts/Linepixels.ttf");

		for (int i = 0; i < NUM_ENEMIES; ++i)
		{
			InitEnemy(game.enemy[i], game);
		}

		for (int i = 0; i < NUM_OBSTACLES; ++i)
		{
			InitObstacle(game.obstacle[i], game);
		}

		RestartGame(game);
	}

	void GameFinished(Game& game, float lastTime)
	{
		game.isGameFinished = true;
		game.gameFinishTime = lastTime;
	}

	void UpdateGame(Game& game, float deltaTime, float lastTime, sf::RenderWindow& window)
	{
		if (!game.isGameFinished)
		{
			UpdatePlayer(game.player, deltaTime);

			// Conditions so that if the player goes outside the window (1920 x 1080), the game restarts
			if (game.player.playerPosition.X - PLAYER_SIZE / 2.f < 0.f || game.player.playerPosition.X + PLAYER_SIZE / 2.f > SCREEN_WIDTH ||
				game.player.playerPosition.Y - PLAYER_SIZE / 2.f < 0.f || game.player.playerPosition.Y + PLAYER_SIZE / 2.f > SCREEN_HEIGTH)
			{
				GameFinished(game, lastTime);
			}

			// A loop to create a collision of enemies
			for (int i = 0; i < NUM_ENEMIES; i++)
			{
				if (IsRectangleCircleCollide(game.player.playerPosition, PLAYER_SIZE, game.enemy[i].enemyPosition, ENEMY_SIZE))
				{
					SetEnemyPosition(game.enemy[i], GetRandomPosition(SCREEN_WIDTH, SCREEN_HEIGTH));
					++game.numKilledEnemies;
					SetPlayerSpeed(game.player, GetPlayerSpeed(game.player) + ACCELERATION);
					game.sound.shotSound.play();

					//game.enemy[i].enemyPosition = GetRandomPosition(SCREEN_WIDTH, SCREEN_HEIGTH);
				}

				game.text.scoreText.setString("Demons killed: " + std::to_string(game.numKilledEnemies));
			}

			// A cycle for creating a collision of obstacles
			for (int i = 0; i < NUM_OBSTACLES; i++)
			{
				if (IsRectangleCircleCollide(game.player.playerPosition, PLAYER_SIZE, game.obstacle[i].obstaclePosition, OBSTACLE_SIZE))
				{
					GameFinished(game, lastTime);
				}
			}
		}

		else
		{
			if (lastTime - game.gameFinishTime <= PAUSE_LENGH)
			{
				window.draw(game.text.gameOverText);
				game.text.totalScoreText.setString("Demons killed: " + std::to_string(game.numKilledEnemies));
				window.draw(game.text.totalScoreText);
				window.display();

				game.sound.backgroundMusic.stop();
				game.sound.gameOverSound.play();

				while (game.sound.gameOverSound.getStatus() == sf::Sound::Playing)
				{
					sf::sleep(sf::milliseconds(5));
				}
			}

			else
			{
				// Calling the game restart function
				RestartGame(game);
				game.isGameFinished = false;
			}
		}
	}

	void DrawGame(Game& game, sf::RenderWindow& window)
	{
		window.draw(game.background.backgroundSprite);
		game.text.inputHintText.setPosition(window.getSize().x - 450.f, 10.f);
		DrawPlayer(game.player, window);

		for (int i = 0; i < NUM_ENEMIES; i++)
		{
			DrawEnemy(game.enemy[i], window);
		}

		for (int i = 0; i < NUM_OBSTACLES; i++)
		{
			DrawObstacle(game.obstacle[i], window);
		}

		window.draw(game.text.scoreText);
		window.draw(game.text.inputHintText);
	}

	void HandleWindowEvents(sf::RenderWindow& window)
	{
		sf::Event event;
		while (window.pollEvent(event))
		{
			// Close the window when clicking on the X or ESC
			if (event.type == sf::Event::Closed)
			{
				window.close();
			}

			if ((event.type == sf::Event::KeyPressed) && (event.key.code == sf::Keyboard::Escape))
			{
				window.close();
			}
		}
	}
}