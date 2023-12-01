#pragma once
#include "Constants.h"
#include <SFML/Audio.hpp>

namespace Doom2D
{
	struct Sound
	{
		sf::Music backgroundMusic;

		sf::SoundBuffer shotSoundBuffer;
		sf::Sound shotSound;

		sf::SoundBuffer gameOverSoundBuffer;
		sf::Sound gameOverSound;
	};

	void InitSound(Sound& sound);
}