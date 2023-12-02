#include "Math.h"
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

	bool isRectangleCircleCollide(Position2D rectanglePosition, float playerSize, Position2D circlePosition, float circleSize)
	{
		// Находим ближайшую точку на прямоугольнике к центру круга
		float closestX = std::max(rectanglePosition.X - (playerSize / 2.f), std::min(circlePosition.X, rectanglePosition.X + (playerSize / 2.f)));
		float closestY = std::max(rectanglePosition.Y - (playerSize / 2.f), std::min(circlePosition.Y, rectanglePosition.Y + (playerSize / 2.f)));

		// Вычисляем расстояние между центром круга и ближайшей точкой на прямоугольнике
		float distanceX = circlePosition.X - closestX;
		float distanceY = circlePosition.Y - closestY;

		// Проверяем, пересекаются ли круг и прямоугольник
		float distanceSquared = (distanceX * distanceX) + (distanceY * distanceY);
		float circleRadius = (circleSize / 2.f) * (circleSize / 2.f);

		return distanceSquared <= circleRadius;
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