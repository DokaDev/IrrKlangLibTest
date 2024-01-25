using Core;
namespace ConsolePlayer {
    internal class Program {
        [STAThread]
        static void Main(string[] args) {
            MediaCore core = new();
            core.SetMedia("getout.ogg");

            while(true) {
                Console.WriteLine("Play : [Enter]");
                Console.WriteLine("PauseResume/Resume : [Space]");
                Console.Write(": ");
                ConsoleKeyInfo c = Console.ReadKey();

                switch(c.Key) {
                    case ConsoleKey.Enter:
                        core.Play();
                        Console.WriteLine("Start Playing");
                        break;
                    case ConsoleKey.Spacebar:
                        core.PauseResume();
                        Console.WriteLine("PauseResume / Resume");
                        break;
                    default:
                        break;
                }
            }
        }

        private void Play() {

        }

        private void Pause() {

        }
    }
}
