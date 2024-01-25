using IrrKlang;

namespace Core {
    public class MediaCore {
        private ISoundEngine _engine;
        private ISound? _currentMedia;

        public string? Path { get; set; }
        public bool IsPlaying { get; private set; } = false;

        /// <summary>
        /// CONSTRUCTOR
        /// DESC: INIT SOUND ENGINE
        /// </summary>

        public MediaCore() {
            _engine = new();
        }

        //[STAThread]
        public void SetMedia(string path) {
            Path = path;
            if(!File.Exists(path)) throw new FileNotFoundException($"{path} not exist");
        }

        public void Play() {
            if(_currentMedia != null) _currentMedia.Stop();
            _currentMedia = _engine.Play2D(Path, true);
            IsPlaying = true;
        }

        public void PauseResume() {
            if(_currentMedia != null) _currentMedia.Paused = !_currentMedia.Paused;
        }
    }
}
