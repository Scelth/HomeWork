#include "Enemy.h"
#include "Game.h"

namespace Doom2D
{
	void InitEnemy(Enemy& enemy, const Game& game)
	{
		// The cycle of coordinates of enemies
		for (int i = 0; i < NUM_ENEMIES; i++)
		{
			enemy.enemyPosition[i] = GetRandomPosition(SCREEN_WIDTH, SCREEN_HEIGTH);

			enemy.enemySprite[i].setTexture(game.enemyTexture);
			SetSpriteSize(enemy.enemySprite[i], ENEMY_SIZE, ENEMY_SIZE);
			SetSpriteOrigin(enemy.enemySprite[i], ENEMY_SIZE);
		}
	}

	void DrawEnemy(Enemy enemy[], sf::RenderWindow& window)
	{
		for (int i = 0; i < NUM_ENEMIES; i++)
		{
			enemy[i].enemySprite[i].setPosition(enemy[i].enemyPosition[i].X, enemy[i].enemyPosition[i].Y);
			window.draw(enemy[i].enemySprite[i]);
		}
	}
}