#include <SFML/Graphics.hpp>
#include <SFML/Audio.hpp>

const std::string RESOURCES_PATH = "Resources/";
const int SCREEN_WIDTH = 1920;
const int SCREEN_HEIGTH = 1080;
const float INITIAL_SPEED = 100.f;
const float PLAYER_SIZE = 20.f;
const float ACCELIRATION = 20.f;
const int NUM_APPLES = 20;
const int NUM_OBSTACLES = 5;
const float APPLE_SIZE = 20.f;
const float OBSTACLE_SIZE = 20.f;
sf::Font font;

void HandleWindowEvents(sf::RenderWindow& window)
{
	sf::Event event;
	while (window.pollEvent(event))
	{
		// Закрыть окно при нажатии на крестик или ESC
		if (event.type == sf::Event::Closed)
		{
			window.close();
		}

		if ((event.type == sf::Event::KeyPressed) && (event.key.code == sf::Keyboard::Escape))
		{
			window.close();
		}
	}
}

// Функция для перезапуска игры
void ResetGame(float& playerX, float& playerY, float& playerSpeed, int& numEatenApples, 
	float appleX[], float appleY[], sf::CircleShape applesShape[],
	float obstacleX[], float obstacleY[], sf::RectangleShape obstaclesShape[])
{
	playerX = SCREEN_WIDTH / 2.f;
	playerY = SCREEN_HEIGTH / 2.f;
	playerSpeed = INITIAL_SPEED;
	numEatenApples = 0;

	for (int i = 0; i < NUM_APPLES; i++)
	{
		appleX[i] = rand() / (float)RAND_MAX * SCREEN_WIDTH;
		appleY[i] = rand() / (float)RAND_MAX * SCREEN_HEIGTH;
		applesShape[i].setPosition(appleX[i], appleY[i]);
	}

	for (int i = 0; i < NUM_OBSTACLES; i++)
	{
		obstacleX[i] = rand() / (float)RAND_MAX * SCREEN_WIDTH;
		obstacleY[i] = rand() / (float)RAND_MAX * SCREEN_HEIGTH;
		obstaclesShape[i].setPosition(obstacleX[i], obstacleY[i]);
	}
}

int main()
{
	int seed = (int)time(nullptr);
	srand(seed);

	sf::RenderWindow window(sf::VideoMode(SCREEN_WIDTH, SCREEN_HEIGTH), "Apple!");

	float playerX = SCREEN_WIDTH / 2.f;
	float playerY = SCREEN_HEIGTH / 2.f;
	float playerSpeed = INITIAL_SPEED;
	int playerDirection = 0;

	sf::RectangleShape playerShape;
	playerShape.setSize(sf::Vector2f(PLAYER_SIZE, PLAYER_SIZE));
	playerShape.setFillColor(sf::Color::Yellow);
	playerShape.setOrigin(PLAYER_SIZE / 2.f, PLAYER_SIZE / 2.f);
	playerShape.setPosition(playerX, playerY);

	sf::CircleShape applesShape[NUM_APPLES];
	float appleX[NUM_APPLES];
	float appleY[NUM_APPLES];
	bool isAppleEaten[NUM_APPLES];

	sf::RectangleShape obstaclesShape[NUM_OBSTACLES];
	float obstacleX[NUM_OBSTACLES];
	float obstacleY[NUM_OBSTACLES];
	bool isHitObstacle[NUM_OBSTACLES];

	// Шрифт
	font.loadFromFile(RESOURCES_PATH + "Fonts/Linepixels.ttf");

	// Текст
	sf::Text scoreText;
	scoreText.setFont(font);
	scoreText.setCharacterSize(24);
	scoreText.setFillColor(sf::Color::Yellow);
	scoreText.setPosition(10.f, 10.f);

	sf::Text inputHintText;
	inputHintText.setFont(font);
	inputHintText.setCharacterSize(24);
	inputHintText.setFillColor(sf::Color::Red);
	inputHintText.setString("Use WASD keys to move, ESC to exit");

	sf::Text gameOverText;
	gameOverText.setFont(font);
	gameOverText.setCharacterSize(24);
	gameOverText.setFillColor(sf::Color::White);
	gameOverText.setString("GAME OVER");
	gameOverText.setPosition(SCREEN_WIDTH / 2.f, SCREEN_HEIGTH / 2.f);

	// Цикл координат яблок
	for (int i = 0; i < NUM_APPLES; i++)
	{
		isAppleEaten[i] = false;
		appleX[i] = rand() / (float)RAND_MAX * SCREEN_WIDTH;
		appleY[i] = rand() / (float)RAND_MAX * SCREEN_HEIGTH;

		applesShape[i].setRadius(APPLE_SIZE / 2.f);
		applesShape[i].setFillColor(sf::Color::Red);
		applesShape[i].setOrigin(APPLE_SIZE / 2.f, APPLE_SIZE / 2.f);
		applesShape[i].setPosition(appleX[i], appleY[i]);
	}

	// Цикл координат препядсвий
	for (int i = 0; i < NUM_OBSTACLES; i++)
	{
		isHitObstacle[i] = false;
		obstacleX[i] = rand() / (float)RAND_MAX * SCREEN_WIDTH;
		obstacleY[i] = rand() / (float)RAND_MAX * SCREEN_HEIGTH;

		obstaclesShape[i].setSize(sf::Vector2f(OBSTACLE_SIZE, OBSTACLE_SIZE));
		obstaclesShape[i].setFillColor(sf::Color::Green);
		obstaclesShape[i].setOrigin(OBSTACLE_SIZE / 2.f, OBSTACLE_SIZE / 2.f);
		obstaclesShape[i].setPosition(obstacleX[i], obstacleY[i]);
	}

	int numEatenApples = 0;

	sf::Clock gameClock;
	float lastTime = gameClock.getElapsedTime().asSeconds();

	while (window.isOpen())
	{
		HandleWindowEvents(window);

		float currentTime = gameClock.getElapsedTime().asSeconds();
		float deltaTime = currentTime - lastTime;
		lastTime = currentTime;

		// Условия для привязки клавиш к направления
		if (sf::Keyboard::isKeyPressed(sf::Keyboard::D))
		{
			playerDirection = 0;
		}

		else if (sf::Keyboard::isKeyPressed(sf::Keyboard::W))
		{
			playerDirection = 1;
		}

		else if (sf::Keyboard::isKeyPressed(sf::Keyboard::A))
		{
			playerDirection = 2;
		}

		else if (sf::Keyboard::isKeyPressed(sf::Keyboard::S))
		{
			playerDirection = 3;
		}


		// Условия для направления ускорения
		playerSpeed += ACCELIRATION * deltaTime;

		if (playerDirection == 0)
		{
			playerX += playerSpeed * deltaTime;
		}

		else if (playerDirection == 1)
		{
			playerY -= playerSpeed * deltaTime;
		}

		else if (playerDirection == 2)
		{
			playerX -= playerSpeed * deltaTime;
		}

		else if (playerDirection == 3)
		{
			playerY += playerSpeed * deltaTime;
		}


		// Условия для того, чтобы, если игрок вышел за пределы окна (1920 х 1080), то игра перезапускалась
		if (playerX - PLAYER_SIZE / 2.f < 0.f || playerX + PLAYER_SIZE / 2.f > SCREEN_WIDTH ||
			playerY - PLAYER_SIZE / 2.f < 0.f || playerY + PLAYER_SIZE / 2.f > SCREEN_HEIGTH)
		{
			window.draw(gameOverText);
			window.display();
			sf::sleep(sf::seconds(2)); // Есть одна проблема с паузой между сессиями. 
									   // После начала новой сессии, игрок оказывается не в центре, а почти на границе окна.

			// Вызываем функцию для перезапуска игры
			ResetGame(playerX, playerY, playerSpeed, numEatenApples, appleX, appleY, applesShape, obstacleX, obstacleY, obstaclesShape);
		}

		// Цикл для создания коллизии препядсвий
		for (int i = 0; i < NUM_OBSTACLES; i++)
		{
			if (!isHitObstacle[i])
			{
				float dx = fabs(playerX - obstacleX[i]);
				float dy = fabs(playerY - obstacleY[i]);

				if (dx <= (OBSTACLE_SIZE + PLAYER_SIZE) / 2.f && dy <= (OBSTACLE_SIZE + PLAYER_SIZE) / 2.f)
				{
					window.draw(gameOverText);
					window.display();
					sf::sleep(sf::seconds(2)); // Есть одна проблема с паузой между сессиями. 
											   // После начала новой сессии, игрок оказывается не в центре, а почти на границе окна.

					// Вызываем функцию для перезапуска игры
					ResetGame(playerX, playerY, playerSpeed, numEatenApples, appleX, appleY, applesShape, obstacleX, obstacleY, obstaclesShape);
				}
			}
		}

		// Цикл для создания коллизии яблок
		for (int i = 0; i < NUM_APPLES; i++)
		{
			if (!isAppleEaten[i])
			{
				float squareDistance = (playerX - appleX[i]) * (playerX - appleX[i]) +
					(playerY - appleY[i]) * (playerY - appleY[i]);

				float squareRaduisSum = (APPLE_SIZE + PLAYER_SIZE) * (APPLE_SIZE + PLAYER_SIZE) / 4;

				// if изменен так, что теперь игра бесконечная. Яблоки появляются вновь, после съедения
				if (squareDistance <= squareRaduisSum)
				{
					++numEatenApples;

					appleX[i] = rand() / (float)RAND_MAX * SCREEN_WIDTH;
					appleY[i] = rand() / (float)RAND_MAX * SCREEN_HEIGTH;
					applesShape[i].setPosition(appleX[i], appleY[i]);
				}
			}

			scoreText.setString("Apples eaten: " + std::to_string(numEatenApples));
		}

		inputHintText.setPosition(window.getSize().x - 450.f, 10.f);

		window.clear();
		playerShape.setPosition(playerX, playerY);

		for (int i = 0; i < NUM_APPLES; i++)
		{
			if (!isAppleEaten[i])
			{
				window.draw(applesShape[i]);
			}
		}

		for (int i = 0; i < NUM_OBSTACLES; i++)
		{
			if (!isHitObstacle[i])
			{
				window.draw(obstaclesShape[i]);
			}
		}
		
		window.draw(playerShape);
		window.draw(scoreText);
		window.draw(inputHintText);
		window.display();
	}

	return 0;
}