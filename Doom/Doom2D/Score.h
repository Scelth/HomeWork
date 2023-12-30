#pragma once
#include <string>
#include "Text.h"
#include "SFML/Graphics.hpp"

namespace Doom2D
{
	struct Game;

	struct PlayersData
	{
		std::string playersNames;
		short playersScore = 0;
	};

	struct GameScore
	{
		short yourScore = 0;
		std::vector<PlayersData> playersData;
	};

	void GetGameScore(Game& game, GameText& text, sf::RenderWindow& window, std::string situation);
	void GenerateRecordTable(GameScore& gameScore);
	void DisplayRecordTable(GameText& text, GameScore& gameScore, sf::RenderWindow& window);
	void UpdatePlayerScore(GameScore& gameScore, Game& game);
}