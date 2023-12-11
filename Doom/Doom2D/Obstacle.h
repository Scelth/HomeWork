#pragma once
#include "Constants.h"
#include "Math.h"

namespace Doom2D
{
	struct Game;

	struct Obstacle
	{
		Position2D obstaclePosition[NUM_OBSTACLES];
		sf::Sprite obstacleSprite[NUM_OBSTACLES];
	};

	void InitObstacle(Obstacle& obstacle, const Game& game);
	void DrawObstacle(Obstacle obstacle[], sf::RenderWindow& window);
}