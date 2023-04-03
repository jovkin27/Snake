using System;
using System.Collections.Generic;
using System.Text;
using WMPLib;
using System.Media;

namespace Snake
{
    public class Sounds //звуки
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        private string pathToMedia;

        public Sounds(string pathToResources)
        {

            pathToMedia = pathToResources;
        }
        public void Stop(string sound)
        {
            player.URL = pathToMedia + sound;
            player.controls.stop();
        }
        public void Movement()
        {
            player.URL = pathToMedia + "click.mp3";
            player.settings.volume = 40;
            //player.controls.play();
        }

        public void Play(string sound)
        {
            player.URL = pathToMedia + sound;
            player.settings.volume = 30;
            player.controls.play();
            player.settings.setMode("loop", true);
        }
        public void Dead()
        {
            player.URL = pathToMedia + "lost.mp3";
            player.settings.volume = 40;
            player.controls.play();
        }

    }
}
