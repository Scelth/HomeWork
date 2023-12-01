#include "Sound.h"

namespace Doom2D
{
	void InitSound(Sound& sound)
	{
		sound.backgroundMusic.openFromFile(RESOURCES_PATH + "Audio/Background.ogg");
		sound.backgroundMusic.setLoop(true); // Зацикливание аудио

		sound.shotSoundBuffer.loadFromFile(RESOURCES_PATH + "Audio/Shot.ogg");
		sound.shotSound.setBuffer(sound.shotSoundBuffer);

		sound.gameOverSoundBuffer.loadFromFile(RESOURCES_PATH + "Audio/GameOverSound.ogg");
		sound.gameOverSound.setBuffer(sound.gameOverSoundBuffer);

		sound.backgroundMusic.play();
	}
}