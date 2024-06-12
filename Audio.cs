using System;
using System.Media;
using System.Threading.Tasks;

internal class Audio
{
    private SoundPlayer player;
    private SoundPlayer intro;
    private SoundPlayer win;
    private SoundPlayer lose;
    private SoundPlayer key;
    private SoundPlayer coin;
    private SoundPlayer door;

    public Audio()
    {
        intro = new SoundPlayer("D:\\хтмл\\Labirint\\Labirint\\bin\\Debug\\net8.0\\intr.wav");
        player = new SoundPlayer("D:\\хтмл\\Labirint\\Labirint\\bin\\Debug\\net8.0\\game.wav");
        win = new SoundPlayer("D:\\хтмл\\Labirint\\Labirint\\bin\\Debug\\net8.0\\win.wav");
        lose = new SoundPlayer("D:\\хтмл\\Labirint\\Labirint\\bin\\Debug\\net8.0\\lose.wav");
        key = new SoundPlayer("D:\\хтмл\\Labirint\\Labirint\\bin\\Debug\\net8.0\\key.wav");
        coin = new SoundPlayer("D:\\хтмл\\Labirint\\Labirint\\bin\\Debug\\net8.0\\coin.wav");
        door = new SoundPlayer("D:\\хтмл\\Labirint\\Labirint\\bin\\Debug\\net8.0\\door.wav");
    }

    public async Task PlayIntro()
    {
       intro.PlayLooping();
    }

    public void StopIntro()
    {
        intro.Stop();
    }

    public async Task PlayGame()
    {
        await Task.Run(() => player.PlayLooping());
    }

    public void StopGame()
    {
        player.Stop();
    }

    public void PlayWin()
    {
        win.Play();
    }

    public void PlayLose()
    {
        lose.Play();
    }

    public async Task KeyCollected()
    {
        await Task.Run(() => key.PlaySync());
    }

    public async Task CoinCollected()
    {
        await Task.Run(() => coin.PlaySync());
    }

    public async Task DoorOpened()
    {
        await Task.Run(() => door.PlaySync());
    }
}
