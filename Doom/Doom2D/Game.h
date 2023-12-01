#pragma once
#include "Constants.h"
#include "Background.h"
#include "Player.h"
#include "Enemy.h"
#include "Obstacle.h"
#include "Text.h"
#include "Sound.h"

namespace Doom2D
{
	struct Game
	{
		Player player;
		Background background;
		Enemy enemy[NUM_ENEMIES];
		Obstacle obstacle[NUM_OBSTACLES];
		Text text;
		Sound sound;


		int numKilledEnemies = 0;
		bool isGameFinished = false;
		float gameFinishTime = 0.f;
		float restartTimer = 0.f;

		sf::Texture backgroundTexture;
		sf::Texture playerTexture;
		sf::Texture enemyTexture;
		sf::Texture obstacleTexture;
	};

	// Функция для перезапуска игры
	void RestartGame(Game& gameState);

	void InitGame(Game& gameState);

	void UpdateGame(Game& gameState, float deltaTime, float lastTime, sf::RenderWindow& window);

	void DrawGame(Game& gameState, sf::RenderWindow& window);

	void HandleWindowEvents(sf::RenderWindow& window);
}