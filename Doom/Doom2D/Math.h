#pragma once

namespace sf 
{
	class Sprite;
}

namespace Doom2D
{
	struct Vector2D
	{
		float X = 0;
		float Y = 0;
	};

	typedef Vector2D Position2D;

	bool isCercleCollide(Position2D cercle1Position, float cercle1Size, Position2D cercle2Position, float cercle2Size);

	Position2D GetRandomPosition(float screenWidth, float screenHeight);

	void SetSpriteSize(sf::Sprite& sprite, float desiredWidth, float desiredHeight);
	void SetSpriteOrigin(sf::Sprite& sprite, float size);
}