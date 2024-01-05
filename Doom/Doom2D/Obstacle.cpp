#include "Obstacle.h"
#include "Game.h"

namespace Doom2D
{
	void InitObstacle(Obstacle& obstacle, const Game& game)
	{
		obstacle.obstacleSprite.setTexture(game.obstacleTexture);
		SetSpriteSize(obstacle.obstacleSprite, OBSTACLE_SIZE, OBSTACLE_SIZE);
		SetSpriteOrigin(obstacle.obstacleSprite, 0.5f, 0.5f);
	}

	void SetObstaclePosition(Obstacle& obstacle, const Position2D& position)
	{
		obstacle.obstaclePosition = position;
	}

	void DrawObstacle(Obstacle& obstacle, sf::RenderWindow& window)
	{
		obstacle.obstacleSprite.setPosition(obstacle.obstaclePosition.X, obstacle.obstaclePosition.Y);
		window.draw(obstacle.obstacleSprite);
	}
}