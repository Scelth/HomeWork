#pragma once
#include "Constants.h"
#include "Math.h"

namespace Doom2D
{
	struct Enemy
	{
		Position2D enemyPosition[NUM_ENEMIES];
		sf::Sprite enemySprite[NUM_ENEMIES];
	};

	struct Game;

	void InitEnemy(Enemy& enemy, const Game& game);

	void DrawEnemy(Enemy enemy[], sf::RenderWindow& window);
}