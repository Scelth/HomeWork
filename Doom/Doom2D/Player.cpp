#include "Player.h"
#include "Game.h"

namespace Doom2D
{
	void InitPlayer(Player& player, const Game& game)
	{
		player.playerPosition = { SCREEN_WIDTH / 2.f, SCREEN_HEIGTH / 2.f };
		player.playerSpeed = INITIAL_SPEED;
		player.playerDirection = PlayerDirection::Right;

		player.playerSprite.setTexture(game.playerTexture);
		SetSpriteSize(player.playerSprite, PLAYER_SIZE, PLAYER_SIZE);
		SetSpriteOrigin(player.playerSprite, 0.5f, 0.5f);
	}

	void DrawPlayer(Player& player, sf::RenderWindow& window)
	{
		player.playerSprite.setPosition(player.playerPosition.X, player.playerPosition.Y);
		window.draw(player.playerSprite);
	}
}