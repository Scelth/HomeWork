#pragma once
#include <SFML/Graphics.hpp>
#include "Math.h"
#include "Constants.h"

namespace Doom2D
{
	enum class PlayerDirection
	{
		Right = 0,
		Up,
		Left,
		Down
	};

	struct Player
	{
		Position2D playerPosition;
		float playerSpeed = INITIAL_SPEED;
		PlayerDirection playerDirection = PlayerDirection::Right;
		sf::Sprite playerSprite;
	};

	struct Game;

	void InitPlayer(Player& player, const Game& game);
	void DrawPlayer(Player& player, sf::RenderWindow& window);
}