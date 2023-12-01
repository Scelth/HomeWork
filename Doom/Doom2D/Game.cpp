#include "Game.h"

namespace Doom2D 
{
	// Функция для перезапуска игры
	void RestartGame(Game& game)
	{
		InitBackground(game.background, game);
		InitPlayer(game.player, game);

		for (int i = 0; i < NUM_ENEMIES; i++)
		{
			InitEnemy(game.enemy[i], game);
		}

		for (int i = 0; i < NUM_OBSTACLES; i++)
		{
			InitObstacle(game.obstacle[i], game);
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

		RestartGame(game);
	}

	void UpdateGame(Game& game, float deltaTime, float lastTime, sf::RenderWindow& window)
	{
		if (!game.isGameFinished)
		{
			// Условия для привязки клавиш к направления
			if (sf::Keyboard::isKeyPressed(sf::Keyboard::D))
			{
				game.player.playerDirection = PlayerDirection::Right;
			}

			else if (sf::Keyboard::isKeyPressed(sf::Keyboard::W))
			{
				game.player.playerDirection = PlayerDirection::Up;
			}

			else if (sf::Keyboard::isKeyPressed(sf::Keyboard::A))
			{
				game.player.playerDirection = PlayerDirection::Left;
			}

			else if (sf::Keyboard::isKeyPressed(sf::Keyboard::S))
			{
				game.player.playerDirection = PlayerDirection::Down;
			}


			switch (game.player.playerDirection)
			{
			case PlayerDirection::Right:
				game.player.playerPosition.X += game.player.playerSpeed * deltaTime;
				break;

			case PlayerDirection::Up:
				game.player.playerPosition.Y -= game.player.playerSpeed * deltaTime;
				break;

			case PlayerDirection::Left:
				game.player.playerPosition.X -= game.player.playerSpeed * deltaTime;
				break;

			case PlayerDirection::Down:
				game.player.playerPosition.Y += game.player.playerSpeed * deltaTime;
				break;
			}

			// Цикл для создания коллизии врагов
			for (int i = 0; i < NUM_ENEMIES; i++)
			{
				if (isCercleCollide(game.player.playerPosition, PLAYER_SIZE / 2.f, game.enemy[i].enemyPosition[i], ENEMY_SIZE / 2.f))
				{
					++game.numKilledEnemies;
					game.player.playerSpeed += ACCELIRATION;
					game.sound.shotSound.play();

					game.enemy[i].enemyPosition[i] = GetRandomPosition(SCREEN_WIDTH, SCREEN_HEIGTH);
				}

				game.text.scoreText.setString("Demons killed: " + std::to_string(game.numKilledEnemies));
			}

			// Условия для того, чтобы, если игрок вышел за пределы окна (1920 х 1080), то игра перезапускалась
			if (game.player.playerPosition.X - PLAYER_SIZE / 1.1f < 0.f || game.player.playerPosition.X + PLAYER_SIZE / 1.1f > SCREEN_WIDTH ||
				game.player.playerPosition.Y - PLAYER_SIZE / 6.f < 0.f || game.player.playerPosition.Y + PLAYER_SIZE / 0.75f > SCREEN_HEIGTH)
			{
				game.isGameFinished = true;
				game.gameFinishTime = lastTime;
			}

			// Цикл для создания коллизии препядсвий
			for (int i = 0; i < NUM_OBSTACLES; i++)
			{
				if (isCercleCollide(game.player.playerPosition, PLAYER_SIZE / 2.f, game.obstacle[i].obstaclePosition[i], OBSTACLE_SIZE / 2.f))
				{
					game.isGameFinished = true;
					game.gameFinishTime = lastTime;
				}
			}
		}

		else
		{
			if (lastTime - game.gameFinishTime <= PAUSE_LENGH)
			{
				window.draw(game.text.gameOverText);
				window.display();

				game.sound.backgroundMusic.stop();
				game.sound.gameOverSound.play();
			}

			else
			{
				// Вызываем функцию для перезапуска игры
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
			DrawEnemy(game.enemy, window);
		}

		for (int i = 0; i < NUM_OBSTACLES; i++)
		{
			DrawObstacle(game.obstacle, window);
		}

		window.draw(game.text.scoreText);
		window.draw(game.text.inputHintText);
	}

	void HandleWindowEvents(sf::RenderWindow& window)
	{
		sf::Event event;
		while (window.pollEvent(event))
		{
			// Закрыть окно при нажатии на крестик или ESC
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