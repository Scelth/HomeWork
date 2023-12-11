#pragma once
#include "Constants.h"
#include <SFML/Audio.hpp>

namespace Doom2D
{
	struct GameSound
	{
		sf::Music backgroundMusic;

		sf::SoundBuffer shotSoundBuffer;
		sf::Sound shotSound;

		sf::SoundBuffer gameOverSoundBuffer;
		sf::Sound gameOverSound;
	};

	void InitSound(GameSound& sound);
}