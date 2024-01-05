#include "Game.h"
#include "Score.h"

namespace Doom2D
{
	void GetGameScore(Game& game, GameText& text, sf::RenderWindow& window, std::string situation)
	{
		if (situation == "GameOver")
		{
			window.draw(text.gameOverText);
		}

		else if (situation == "YouWin")
		{
			window.draw(text.youWinText);
		}

		text.totalScoreText.setString("Demons killed: " + std::to_string(game.numKilledEnemies));
        UpdatePlayerScore(game.gameScore, game);
        DisplayRecordTable(text, game.gameScore, window);
		window.draw(text.totalScoreText);
		window.display();
	}

    bool operator<(const PlayersData& left, const PlayersData& right)
    {
        return left.playersScore > right.playersScore;
    }

    void GenerateRecordTable(GameScore& gameScore)
    {
        gameScore.playersData.clear();

        PlayersData playersInit[] = {
            {"Player1", rand() % 20 + 1},
            {"Player2", rand() % 20 + 1},
            {"Player3", rand() % 20 + 1},
            {"Player4", rand() % 20 + 1},
            {"Player5", rand() % 20 + 1},
        };

        const auto playersInitSize = sizeof(playersInit) / sizeof(playersInit[0]);
        PlayersData players[playersInitSize];
        
        for (int i = 0; i < playersInitSize; i++)
        {
            gameScore.playersData.push_back(playersInit[i]);
        }
    }

    void DisplayRecordTable(GameText& text, GameScore& gameScore, sf::RenderWindow& window)
    {
        std::string recordString = "Records:\n";
        std::sort(gameScore.playersData.begin(), gameScore.playersData.end());

        for (const auto& entry : gameScore.playersData)
        {
            recordString += entry.playersNames + ": " + std::to_string(entry.playersScore) + "\n";
        }

        text.recordText.setString(recordString);
        window.draw(text.recordText);
    }


    void UpdatePlayerScore(GameScore& gameScore, Game& game)
    {
        for (const auto& entry : gameScore.playersData)
        {
            if ((gameScore.yourScore < game.numKilledEnemies) || gameScore.yourScore == 0)
            {
                gameScore.yourScore = game.numKilledEnemies;
            }
        }

        gameScore.playersData.push_back({ "You", gameScore.yourScore });
    }

}