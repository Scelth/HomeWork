#pragma once
#include "Constants.h"
#include "Math.h"

namespace Doom2D
{
	struct Obstacle
	{
		Position2D obstaclePosition[NUM_OBSTACLES];
		sf::Sprite obstacleSprite[NUM_OBSTACLES];
	};

	struct Game;

	void InitObstacle(Obstacle& obstacle, const Game& game);

	void DrawObstacle(Obstacle obstacle[], sf::RenderWindow& window);
}