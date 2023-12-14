#pragma once
#include <SFML/Graphics.hpp>
#include "Constants.h"
#include "Math.h"

namespace Doom2D
{
	struct Game;

	struct Enemy
	{
		Position2D enemyPosition;
		sf::Sprite enemySprite;
	};

	void InitEnemy(Enemy& enemy, const Game& game);
	void SetEnemyPosition(Enemy& enemy, const Position2D& position);
	void DrawEnemy(Enemy& enemy, sf::RenderWindow& window);
}
