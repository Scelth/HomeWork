#include "Obstacle.h"
#include "Game.h"

namespace Doom2D
{
	void InitObstacle(Obstacle& obstacle, const Game& game)
	{
		// The cycle of obstacle coordinates
		for (int i = 0; i < NUM_OBSTACLES; i++)
		{
			obstacle.obstaclePosition[i] = GetRandomPosition(SCREEN_WIDTH, SCREEN_HEIGTH);

			obstacle.obstacleSprite[i].setTexture(game.obstacleTexture);
			SetSpriteSize(obstacle.obstacleSprite[i], OBSTACLE_SIZE, OBSTACLE_SIZE);
			SetSpriteOrigin(obstacle.obstacleSprite[i], OBSTACLE_SIZE);
		}
	}

	void DrawObstacle(Obstacle obstacle[], sf::RenderWindow& window)
	{
		for (int i = 0; i < NUM_OBSTACLES; i++)
		{
			obstacle[i].obstacleSprite[i].setPosition(obstacle[i].obstaclePosition[i].X, obstacle[i].obstaclePosition[i].Y);
			window.draw(obstacle[i].obstacleSprite[i]);
		}
	}
}