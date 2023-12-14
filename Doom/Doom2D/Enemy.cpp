#include "Enemy.h"
#include "Game.h"

namespace Doom2D
{
	void InitEnemy(Enemy& enemy, const Game& game)
	{
		enemy.enemySprite.setTexture(game.enemyTexture);
		SetSpriteSize(enemy.enemySprite, ENEMY_SIZE, ENEMY_SIZE);
		SetSpriteOrigin(enemy.enemySprite, 0.5f, 0.5f);
	}

	void DrawEnemy(Enemy& enemy, sf::RenderWindow& window)
	{
		enemy.enemySprite.setPosition(enemy.enemyPosition.X, enemy.enemyPosition.Y);
		window.draw(enemy.enemySprite);
	}

	void SetEnemyPosition(Enemy& enemy, const Position2D& position)
	{
		enemy.enemyPosition = position;
	}
}