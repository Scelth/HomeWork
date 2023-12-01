#include "Math.h"
#include <cstdlib>
#include <SFML/Graphics.hpp>

namespace Doom2D
{
	bool isCercleCollide(Position2D cercle1Position, float cercle1Size, Position2D cercle2Position, float cercle2Size)
	{
		float squareDistance = (cercle1Position.X - cercle2Position.X) * (cercle1Position.X - cercle2Position.X) +
			(cercle1Position.Y - cercle2Position.Y) * (cercle1Position.Y - cercle2Position.Y);

		float squareRaduisSum = (cercle2Size + cercle1Size) * (cercle2Size + cercle1Size);

		return squareDistance <= squareRaduisSum;
	}

	Position2D GetRandomPosition(float screenWidth, float screenHeight)
	{
		Position2D result;

		result.X = rand() / (float)RAND_MAX * screenWidth;
		result.Y = rand() / (float)RAND_MAX * screenHeight;

		return result;
	}

	void SetSpriteSize(sf::Sprite& sprite, float desiredWidth, float desiredHeight)
	{
		sf::FloatRect spriteReact = sprite.getLocalBounds();
		sf::Vector2f scale = { desiredWidth / spriteReact.width, desiredHeight / spriteReact.height };
		sprite.setScale(scale);
	}

	void SetSpriteOrigin(sf::Sprite& sprite, float size) 
	{
		sf::FloatRect spriteReact = sprite.getLocalBounds();
		sprite.setOrigin(size / spriteReact.width, size / spriteReact.height);
	}
}